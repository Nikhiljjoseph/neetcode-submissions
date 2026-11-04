public class TimeMap {
    private Dictionary<string,List<(string value,int timestamp)>> map;

    public TimeMap() {
       map = new Dictionary<string, List<(string value, int timestamp)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key))
             map[key] = new List<(string value, int timestamp)>();
        map[key].Add((value,timestamp));
    }
    
    public string Get(string key, int timestamp) {
        int result = -1;
        if(!map.ContainsKey(key))
            return "";
        var sorted = map[key];
        int left = 0;
        int right = sorted.Count - 1;
        while(left<=right){
            int mid = left+(right-left)/2;
            if(sorted[mid].timestamp<=timestamp){
                result = mid;
                left=mid+1;
            }
            else 
                right=mid-1;
        }
        return result==-1?"":sorted[result].value;

    }
}
