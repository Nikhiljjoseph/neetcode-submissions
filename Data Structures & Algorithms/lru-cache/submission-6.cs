public class ListNode{
    public int key;
    public int value;
    public ListNode prev;
    public ListNode next;
    public ListNode(int key, int value){
        this.key = key;
        this.value = value;
        this.prev = null;
        this.next = null;
    }
}  

public class LRUCache {
    private Dictionary<int, ListNode> cache;
    private int cap;
    private ListNode right;
    private ListNode left;  


    public LRUCache(int capacity) {
        cache = new Dictionary<int, ListNode>();
        cap = capacity;
        right = new ListNode(0,0);
        left = new ListNode(0,0);
        right.prev=left;
        left.next=right;
    }

    private void Remove(ListNode node){
        ListNode prev = node.prev;
        ListNode next = node.next;
        prev.next=next;
        next.prev=prev;
    }

    private void Insert(ListNode node){
        ListNode prev = right.prev;
        prev.next=node;
        node.next=right;
        right.prev=node;
        node.prev=prev;
    }
    
    public int Get(int key) {
        if(cache.ContainsKey(key)){
            ListNode node = cache[key];
            Remove(node);
            Insert(node);
            return node.value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        ListNode node = new ListNode(key,value);
        if(cache.ContainsKey(key))
            Remove(cache[key]);
        cache[key]=node;
        Insert(node);
        if(cache.Count>cap){
            ListNode lru = left.next;
            cache.Remove(lru.key);
            Remove(lru);
        }
    }
}
