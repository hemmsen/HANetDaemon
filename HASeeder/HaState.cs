using System;

namespace HASeeder;
public class HaState
{
    public string entity_id { get; set; }
    public string state { get; set; }
    public class HaStateAttribute
    {
        public bool editable { get; set; }
        public string id { get; set; }
        public string friendly_name { get; set; }
    }
    public object attributes { get; set; }
    public DateTimeOffset last_changed { get; set; }
    public string last_updated { get; set; }

    public class Context
    {
        public string id { get; set; }
        public string parent_id { get; set; }
        public string user_id { get; set; }
    }
    public Context context { get; set; }
}