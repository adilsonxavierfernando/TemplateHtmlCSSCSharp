namespace TemplateHtmlCSSCSharp.Models
{
    public class ModelIMC
    {
        decimal _imc;
        string _descricao;
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }
        public decimal IMC 
        {
            get
            {
                // Calcular o IMC somente se a altura for maior que zero
                if (Altura > 0)
                {
                    _imc = Peso / (Altura * Altura);
                }
                return _imc;
            }
        }
        public string Descricao 
        {
            get
            {
           
                if (IMC < 18.5m)
                {
                    _descricao = "Abaixo do Peso";
                }
                else if (IMC >= 18.5m && IMC < 25m)
                {
                    _descricao = "Peso Normal";
                }
                else if (IMC >= 25m && IMC < 30m)
                {
                    _descricao = "Sobrepeso";
                }
                else
                {
                    _descricao = "Obesidade";
                }
                return _descricao;
            }
        }
    }
}
