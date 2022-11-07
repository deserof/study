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
library("caret")
library("ggplot2")
library(stargazer)
library(dbplyr)
library(readxl)

# Цель: исследовать набор данных phones, построить регрессионную модель,
# взяв за Y - Price, а в качестве X: ScreenRefreshRate, ProcessorClockSpeed, BatteryCapacity, ProcessTechnology, OS
# сделать вывод о пригодности модели для прогноза. Сравнить с методом k ближайших соседей по MSE на тестовой выборке.

my.seed <- 12345
phones.percent <- 0.85
options("ggmatrix.progress.bar" = FALSE)

phones <- read_excel("D:\\Users\\deserof\\Desktop\\study\\bzppr\\lab2\\Rlab\\lab2.xlsx");

?phones
str(phones)
set.seed(my.seed)

#обучающая выборка
inPhones <- sample(seq_along(phones$`Price (byn)`), 
                   nrow(phones) * phones.percent)

df.phones <- phones[inPhones, c(1:5)]

df.test <- phones[-inPhones, c(1:5)]

ggp <- ggpairs(df.phones, cardinality_threshold = 306)

ggplot(ggp, mapping = ggplot2::aes(color = phones$`Price (byn)`))

print(ggp, bins = 400)

ggp <- ggpairs(df.phones,
               cardinality_threshold = 306)

print(ggp, bins = 400)
model.1 <-  lm(phones$`Price (byn)` ~
                 phones$`ScreenRefreshRate (Гц)`
               + phones$`ProcessorClockSpeed(МГц)`
               + phones$`BatteryCapacity(мА·ч)`
               + phones$ProcessTechnology
               + phones$OS)
summary(model.1)

###

ES1 <- as.data.frame(phones[2:5], min_max_norm)
ES1<-round(ES1,2)

relation <- lm(phones$`Price (byn)` ~
                 phones$`ScreenRefreshRate (Гц)`
               + phones$`ProcessorClockSpeed(МГц)`
               + phones$`BatteryCapacity(мА·ч)`
               + phones$ProcessTechnology
               + phones$OS)

print(summary(relation))
