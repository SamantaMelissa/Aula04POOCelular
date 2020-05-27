namespace POO4celular
{
    public class celulares
    {

        public string cor;

        public string modelo;

        public float tamanho;

        public bool ligado;

        public int ligado2 (int desligar, int ligar, int fazerLigaçao, int enviarMensagem) {
            return desligar + ligar + fazerLigaçao + enviarMensagem;
        }




        public bool TraduzConsole(string condicao){

            if(condicao == "ligado"){
                ligado = true;
              
            }else{
                ligado = false;
            }

            return ligado;
        }
    }
}