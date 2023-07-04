namespace INI
{
    class Pin_object
    {
        public string model = "";
        public string pin1 = "";
        public string pin2 = "";
        public string pin3 = "";
        public string pin4 = "";
        public string pin5 = "";
        public string pin6 = "";
        public string rel1 = "";
        public string rel2 = "";

        public Pin_object(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9)
        {
            model = v1;
            pin1 = v2;
            pin2 = v3;
            pin3 = v4;
            pin4 = v5;
            pin5 = v6;
            pin6 = v7;
            rel1 = v8;
            rel2 = v9;
        }

        public string Get_model() { return model; }
        public string Get_pin1() { return pin1; }
        public string Get_pin2() { return pin2; }
        public string Get_pin3() { return pin3; }
        public string Get_pin4() { return pin4; }
        public string Get_pin5() { return pin5; }
        public string Get_pin6() { return pin6; }
        public string Get_rel1() { return rel1; }
        public string Get_rel2() { return rel2; }
    }
}