namespace ModelTransformationComponent{
    /// <summary>
    /// Системная конструкция создания конструкции на основе регулярного выражения
    /// </summary>
    class Reg : SystemRule{
        /// <summary>
        /// Литерао конструкции создания конструкции на основе регулярного выражения
        /// </summary>
        public override string GetLiteral => "/reg";
    }
}