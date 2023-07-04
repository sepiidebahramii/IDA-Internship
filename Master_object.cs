namespace INI
{
    class Master_object
    {
        public string sample_period_s = "";
        public string master_port = "";
        public string master_addr = "";
        public string clients_num = "";
        public string debug_mode = "";
        public string debug_mode2 = "";
        public string no_watchdog = "";
        public string database_utime = "";
        public string refresh_reg = "";
        public string request_delay = "";
        public string db_delay = "";

        public Master_object(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10, string v11)
        {
            sample_period_s = v1;
            master_port = v2;
            master_addr = v3;
            clients_num = v4;
            debug_mode = v5;
            debug_mode2 = v6;
            no_watchdog = v7;
            database_utime = v8;
            refresh_reg = v9;
            request_delay = v10;
            db_delay = v11;
        }

        public string Get_sample_period_s() { return sample_period_s; }
        public string Get_master_port() { return master_port; }
        public string Get_master_addr() { return master_addr; }
        public string Get_clients_num() { return clients_num; }
        public string Get_debug_mode() { return debug_mode; }
        public string Get_debug_mode2() { return debug_mode2; }
        public string Get_no_watchdog() { return no_watchdog; }
        public string Get_database_utime() { return database_utime; }
        public string Get_refresh_reg() { return refresh_reg; }
        public string Get_request_delay() { return request_delay; }
        public string Get_db_delay() { return db_delay; }
    }
}