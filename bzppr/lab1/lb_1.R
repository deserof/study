library(readxl)
library(psych)
ish <- read_excel("C:/Users/22ar0/Desktop/Учеба/БЗ/не крутолевич/ish.xlsx")
View(ish)

describe(ish)

vec1 <- table(ish$A)
vec2 <- table(ish$B)


A <- rnorm(n = 100, mean = 5.74, sd = 2.13)
B <- rnorm(n = 100, mean = 6.72, sd = 2.81)

hist(A, col = "lightblue", main = "Гистограмма А")
hist(B, col = "lightblue", main = "Гистограмма B")

boxplot(ish)

shapiro.test(vec1)
shapiro.test(vec2)
mean_Length_canvasesA<-mean(vec1)
sd_Length_canvasesA<- sd(vec1)
mean_Length_canvasesB<-mean(vec2)
sd_Length_canvasesB<- sd(vec2)
hist(ish$A,
     #можно менять количество интервалов разбиения для большого числа данных 
     xlab = "Кол-во поломок", # изменить подпись оси OX
     ylab = "Плотность вероятности", # изменить подпись оси OY
     main = "Гистограмма поломок\n производителя A  \n(c кривой нормального распределения)", # изменить название гистограммы
     col = "plum", # поменять цвет гистограммы
     freq = F # плотность
)
c<-curve(dnorm( x,# рассчитываем значения функции плотности нормального распределения
                mean = mean_Length_canvasesA, # с выборочным средним
                sd = sd_Length_canvasesA), # и выборочным стандартным отклонением
         add = T # дорисовываем кривую на предыдущем графике 
)
hist(ish$B,
     #можно менять количество интервалов разбиения для большого числа данных 
     xlab = "Кол-во поломок", # изменить подпись оси OX
     ylab = "Плотность вероятности", # изменить подпись оси OY
     main = "Гистограмма поломок\n производителя B  \n(c кривой нормального распределения)", # изменить название гистограммы
     col = "plum", # поменять цвет гистограммы
     freq = F # плотность
)
c<-curve(dnorm( x,# рассчитываем значения функции плотности нормального распределения
                mean = mean_Length_canvasesB, # с выборочным средним
                sd = sd_Length_canvasesB), # и выборочным стандартным отклонением
         add = T # дорисовываем кривую на предыдущем графике 
)
fisher.test(ish,simulate.p.value=TRUE)
t.test(vec1,vec2)
var.test(vec1,vec2)
t.test(ish)
