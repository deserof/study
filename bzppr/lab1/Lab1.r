library(readxl)
library(psych)
library(ggplot2)
ish <- read_excel("C:\\Users\\Artsiom_Kharkevich\\Study\\study\\bzppr\\ish.xlsx")
View(ish)

describe(ish)

vec1 <- table(ish$A)
vec2 <- table(ish$B)
avarageA <- mean(ish$A)
avarageB <- mean(ish$B)
n <- length(ish$A)
sdA <- sd(ish$A)
sdB <- sd(ish$B)
A <- rnorm(n, avarageA, sdA)
B <- rnorm(n, avarageB, sdB)

var.test(A, B)

hist(ish$A, col = "lightblue")
curve(dnorm( x,# рассчитываем значения функции плотности нормального распределения
             mean = avarageA, # с выборочным средним
             sd = sdA), # и выборочным стандартным отклонением
      add = T # дорисовываем кривую на предыдущем графике 
)

hist(ish$B, col = "green")
sd_Length_B <- sd(vec2)
curve(dnorm( x,# рассчитываем значения функции плотности нормального распределения
             mean = avarageB, # с выборочным средним
             sd = sdB), # и выборочным стандартным отклонением
      add = T # дорисовываем кривую на предыдущем графике 
)


shapiro.t

boxplot(ish)

shapiro.test(vec1)
shapiro.test(vec2)

t.test(vec1, mu = avarageA)
t.test(vec2, mu = avarageB)