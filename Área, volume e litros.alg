inicio
    real raio
    real area 
    real altura
    real volume
    real litros
    real pi
    pi <- 3.14
    
    escrever "Qual a medida do raio do circulo que voc� deseja calcular a �rea?"
    ler raio
    
    area <- pi*(raio*raio)
    escrever "A �rea do c�rculo �: " 
    escrever area 
    
    escrever ". Qual a medida da altura do cone que voc� deseja calcular o vomule?"
    ler altura
    
    volume <- (1.0/3.0)*pi*(raio*raio)*altura
   
    litros <- volume*1000
    
    escrever "O volume do seu cone � de " 
    escrever volume 
    escrever "m� e cabem " 
    escrever litros 
    escrever "L nele."
fim 