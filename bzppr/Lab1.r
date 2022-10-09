library(readxl)
install.packages("psych")
library(psych)
ish <- read_excel("C:\\Users\\User\\Downloads\\ish.xlsx")
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

hist(A, col = "lightblue", main = "Гистограмма А")
hist(B, col = "lightblue", main = "Гистограмма B")

boxplot(ish)

shapiro.test(vec1)
shapiro.test(vec2)

t.test(vec1, mu = avarageA)
t.test(vec2, mu = avarageB)