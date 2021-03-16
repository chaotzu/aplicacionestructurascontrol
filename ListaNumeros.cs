using System;


namespace aplicacionestructurascontrol
{
    class ListaNumeros
    {
        String[] lista;
        bool esOrdenada;

        public ListaNumeros(){
        }

        public ListaNumeros(String[] lista, bool esOrdenada = false)
        {
            this.lista = lista;
            this.esOrdenada = esOrdenada;
        }

        public bool ordenar()
        {
            try
            {
                for (int i = 0; i <= this.lista.Length - 1; i++)
                {
                    for (int j = 0; j < this.lista.Length - i - 1; j++)
                    {
                        if (int.Parse(this.lista[j]) < int.Parse(this.lista[j + 1]))
                        {
                            string tem = this.lista[j];
                            this.lista[j] = this.lista[j + 1];
                            this.lista[j + 1] = tem;
                        }
                    }
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public float sumar()
        {
            int numElementos = this.lista.Length - 1;
            float suma = 0;
            while(numElementos>=1){
                suma = int.Parse(this.lista[numElementos]) + suma;
                numElementos--;
            }
            return suma;
        }

        public float restar()
        {
            int numElementos = this.lista.Length - 1
                ;
            float resta = 0;
            while(numElementos>=1)
            {
                resta = resta - int.Parse(this.lista[numElementos]);
                numElementos--;
            } 
            return resta;
        }

        public void imprimirLista()
        {
            foreach (string i in this.lista)
            {
                Console.Write("{0} ", i);
            }
        }


        public void setNumeros(string[] lista)
        {
            this.lista = lista;
        }
    }
}
