#define Min-Max normalization function
min_max_norm <- function(x) {
  (x - min(x)) / (max(x) - min(x))
}
max_min_norm <- function(x) {
  (max(x)-x) / (max(x) - min(x))
}

library('ISLR')
library('GGally')
library('MASS')
library('lmtest')
library('FNN')
library('caret')
library(stargazer)
library(dbplyr)
library(readxl)
library('GGally')
library('stringi')
library("ggplot2")
library(randomForest)

my.seed <- 12345
phones.percent <- 0.85
options("ggmatrix.progress.bar" = FALSE)

phones <- read_excel("C:/Users/Artsiom_Kharkevich/Study/study/bzppr/lab2/Rlab/lab2.xlsx")

?phones
str(phones)
set.seed(my.seed)

phones$RAM<- as.factor(phones$`RAM гб`)

#обучающая выборка
inPhones <- sample(seq_along(phones$`Price (byn)`), 
                   nrow(phones) * phones.percent)

df.phones <- phones[inPhones, c(2,5,6,9,11,12,14,15,23)]
df.test <- phones[-inPhones, c(2,5,6,9,11,12,14,15,23)]

df.phones[is.na(df.phones)] <- 0
df.test[is.na(df.test)] <- 0

p_ <- GGally::print_if_interactive

ggp <- ggpairs(df.phones, cardinality_threshold = 233, columns = 2:4)

p_(ggp)

ggp <- ggpairs(df.phones, 
               #mapping = aes(color = phones$`Price (byn)`),
               ggplot2::aes(color="red"),
               cardinality_threshold=233,
               columns = 1:4)

p_(ggp)

print(ggp, progress = FALSE)

model.1 <-  lm(phones$`Price (byn)` ~
                 phones$`ScreenRefreshRate (Гц)`
               + phones$`ProcessorClockSpeed(МГц)`
               + phones$`NumberOfMatrixPoints мп`
               + phones$ NumberOfSIMCards
               + phones$`BatteryCapacity(мА·ч)`
               + phones$ ProcessTechnology
               + phones$`Memory(Гб)`
               + phones$`RAM гб`,
               data = df.phones)
summary(model.1)

#Некоторые регрессоры, входящие в модель незначимы, постепенно исключаем их:
model.2 <-  lm(phones$`Price (byn)` ~
                 phones$`ProcessorClockSpeed(МГц)`
               + phones$`NumberOfMatrixPoints мп`
               + phones$ NumberOfSIMCards
               + phones$`BatteryCapacity(мА·ч)`
               + phones$ ProcessTechnology
               + phones$`Memory(Гб)`
               + phones$`RAM гб`,
               data = df.phones)
summary(model.2)

model.3 <-  lm(phones$`Price (byn)` ~
                 phones$`ProcessorClockSpeed(МГц)`
               + phones$ NumberOfSIMCards
               + phones$`BatteryCapacity(мА·ч)`
               + phones$ ProcessTechnology
               + phones$`Memory(Гб)`
               + phones$`RAM гб`,
               data = df.phones)
summary(model.3)

model.4 <-  lm(phones$`Price (byn)` ~
                 phones$`ProcessorClockSpeed(МГц)`
               + phones$`BatteryCapacity(мА·ч)`
               + phones$ ProcessTechnology
               + phones$`Memory(Гб)`
               + phones$`RAM гб`,
               data = df.phones)
summary(model.4)

model.5 <-  lm(phones$`Price (byn)` ~
                 phones$`ProcessorClockSpeed(МГц)`
               + phones$ ProcessTechnology
               + phones$`Memory(Гб)`
               + phones$`RAM гб`,
               data = df.phones)
summary(model.5)

model.6 <-  lm(phones$`Price (byn)` ~
                 phones$`ProcessorClockSpeed(МГц)`
               + phones$`Memory(Гб)`
               + phones$`RAM гб`,
               data = df.phones)
summary(model.6)

model.7 <-  lm(phones$`Price (byn)` ~
                 phones$`ProcessorClockSpeed(МГц)`
               + phones$`RAM гб`,
               data = df.phones)
summary(model.7)

# качество модели на контрольной выборке 
P <- predict(model.7, df.test)

x <- df.test$`Price (byn)`
y <- P

plot(x, y[1: length (x)])

ER <- x - predict(model.7,df.test)

MSE.lm <- sum(ER^2) / length(P)

#прогноз
new<-data.frame(ProcessorClockSpeed = mean(phones$`ProcessorClockSpeed(МГц)`),
                ram = mean(phones$`RAM гб`))
hist(ER)
plot(1:54, x, type = 'b', col = 'darkgreen',
     xlab = 'порядковый номер тестовой выборки',
     ylab = 'эмпирические и теоретические значения на тестовой выборке')

lines(1:54, x, type = 'b', col = 'red')
shapiro.test(ER)

#КНН регрессия (пофиксить)
knn_fit <- train(`Price (byn)` ~ `ProcessorClockSpeed(МГц)` + `RAM гб`,
                 preProcess = c("center","scale"), 
                 method = "knn",
                 data = df.phones)

knn_fit$results

# качество модели на контрольной выборке 
Pknn<-predict(knn_fit, df.test)
plot(1:54, Pknn, type = 'b', col = 'darkgreen',
     xlab = 'порядковый номер тестовой выборки',
     ylab = 'эмпирические и теоретические значения на тестовой выборке')
lines(1:54, df.test$`Price (byn)`, type = 'b', col = 'red')
ERKN<-df.test$`Price (byn)` - Pknn
MSEknn <- sum(ERKN^2) / length(Pknn)#RMSE^2

#Три графика вместе 
plot(1:54, Pknn, type = 'b', col = 'darkgreen',
     xlab = 'порядковый номер тестовой выборки',
     ylab = 'эмпирические и теоретические значения на тестовой выборке')

lines(1:360, P, type = 'b', col = 'black')
lines(1:54, df.test$`Price (byn)`, type = 'b', col = 'red')

#прогноз
new <- data.frame(`ProcessorClockSpeed(МГц)` <- mean(df.phones$`ProcessorClockSpeed(МГц)`),
                  `RAM гб` <- mean(df.phones$`RAM гб`))

PknnNEW <- predict(knn_fit, new)
Pnew <- predict(model.7, new)
P

#логистическая регрессия
?Default
str(Default)
ggp <- ggpairs(Default, aes(colour = default, alpha = 0.4)) +
  scale_colour_manual(values = c('darkgreen', 'red')) + 
  scale_fill_manual(values = c('darkgreen', 'red'))
print(ggp, progress = FALSE)
T<-table(Default$default)
prop.table(T)
set.seed(my.seed)
inTrain <- sample(seq_along(Default$default),
                  nrow(Default)*phones.percent)
df <- Default[inTrain, ]

Fakt<- df$default
model.logit <- glm(default ~ balance, data = df, family = 'binomial')
summary(model.logit)
p.logit <- predict(model.logit, df, type = 'response')
PROGN <- factor(ifelse(p.logit > 0.5, 2, 1),
                levels = c(1, 2),
                labels = c('No', 'Yes'))

# матрица ошибок
conf.m <- table(Fakt, PROGN)
conf.m
# чувствительность модели это и есть доля истинно положительных случаев:
conf.m[2, 2] / sum(conf.m[2, ])
#специфичность доля истинно отрицательных случаев, которые были правильно идентифицированы моделью:
conf.m[1, 1] / sum(conf.m[1, ])
#Чувствительный диагностический тест проявляется в гипердиагностике — максимальном предотвращении пропуска больных.
#Специфичный диагностический тест диагностирует только доподлинно больных. Это важно в случае, когда, например, лечение больного связано с серьезными побочными эффектами и гипердиагностика пациентов не желательна.
# точность 
sum(diag(conf.m)) / sum(conf.m)
logit.or = exp(coef(model.logit))
logit.or