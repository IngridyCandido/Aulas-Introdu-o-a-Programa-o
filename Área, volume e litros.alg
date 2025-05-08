inicio
    real raio
    real area 
    real altura
    real volume
    real litros
    real pi
    pi <- 3.14
    
    escrever "Qual a medida do raio do circulo que você deseja calcular a área?"
    ler raio
    
    area <- pi*(raio*raio)
    escrever "A área do círculo é: " 
    escrever area 
    
    escrever ". Qual a medida da altura do cone que você deseja calcular o vomule?"
    ler altura
    
    volume <- (1.0/3.0)*pi*(raio*raio)*altura
   
    litros <- volume*1000
    
    escrever "O volume do seu cone é de " 
    escrever volume 
    escrever "m³ e cabem " 
    escrever litros 
    escrever "L nele."
fim 