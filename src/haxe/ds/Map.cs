// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._Map {
	public sealed class Map_Impl_ {
		
		public static void @set<K, V>(global::haxe.IMap<K, V> this1, K key, V @value) {
			#line 75 "/opt/haxe/std/haxe/ds/Map.hx"
			this1.@set(key, @value);
		}
		#line default
		
		public static global::haxe.lang.Null<V> @get<K, V>(global::haxe.IMap<K, V> this1, K key) {
			#line 93 "/opt/haxe/std/haxe/ds/Map.hx"
			return this1.@get(key);
		}
		#line default
		
		public static bool exists<K, V>(global::haxe.IMap<K, V> this1, K key) {
			#line 101 "/opt/haxe/std/haxe/ds/Map.hx"
			return this1.exists(key);
		}
		#line default
		
		public static bool @remove<K, V>(global::haxe.IMap<K, V> this1, K key) {
			#line 110 "/opt/haxe/std/haxe/ds/Map.hx"
			return this1.@remove(key);
		}
		#line default
		
		public static object keys<K, V>(global::haxe.IMap<K, V> this1) {
			#line 118 "/opt/haxe/std/haxe/ds/Map.hx"
			return this1.keys();
		}
		#line default
		
		public static object iterator<K, V>(global::haxe.IMap<K, V> this1) {
			#line 127 "/opt/haxe/std/haxe/ds/Map.hx"
			return this1.iterator();
		}
		#line default
		
		public static object keyValueIterator<K, V>(global::haxe.IMap<K, V> this1) {
			#line 136 "/opt/haxe/std/haxe/ds/Map.hx"
			return this1.keyValueIterator();
		}
		#line default
		
		public static global::haxe.IMap<K, V> copy<K, V>(global::haxe.IMap<K, V> this1) {
			#line 145 "/opt/haxe/std/haxe/ds/Map.hx"
			return ((global::haxe.IMap<K, V>) (this1.copy()) );
		}
		#line default
		
		public static string toString<K, V>(global::haxe.IMap<K, V> this1) {
			#line 154 "/opt/haxe/std/haxe/ds/Map.hx"
			return this1.toString();
		}
		#line default
		
		public static void clear<K, V>(global::haxe.IMap<K, V> this1) {
			#line 161 "/opt/haxe/std/haxe/ds/Map.hx"
			this1.clear();
		}
		#line default
		
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static V arrayWrite<K, V>(global::haxe.IMap<K, V> this1, K k, V v) {
			#line 165 "/opt/haxe/std/haxe/ds/Map.hx"
			this1.@set(k, v);
			return v;
		}
		#line default
		
		public static global::haxe.ds.StringMap<V> toStringMap<K, V>(global::haxe.IMap<K, V> t) {
			#line 170 "/opt/haxe/std/haxe/ds/Map.hx"
			return new global::haxe.ds.StringMap<V>();
		}
		#line default
		
		public static global::haxe.ds.IntMap<V> toIntMap<K, V>(global::haxe.IMap<K, V> t) {
			#line 174 "/opt/haxe/std/haxe/ds/Map.hx"
			return new global::haxe.ds.IntMap<V>();
		}
		#line default
		
		public static global::haxe.ds.EnumValueMap<K, V> toEnumValueMapMap<K, V>(global::haxe.IMap<K, V> t) {
			#line 178 "/opt/haxe/std/haxe/ds/Map.hx"
			return new global::haxe.ds.EnumValueMap<K, V>();
		}
		#line default
		
		public static global::haxe.ds.ObjectMap<K, V> toObjectMap<K, V>(global::haxe.IMap<K, V> t) {
			#line 182 "/opt/haxe/std/haxe/ds/Map.hx"
			return new global::haxe.ds.ObjectMap<K, V>();
		}
		#line default
		
		public static global::haxe.ds.StringMap<V> fromStringMap<V>(global::haxe.ds.StringMap<V> map) {
			#line 186 "/opt/haxe/std/haxe/ds/Map.hx"
			return ((global::haxe.ds.StringMap<V>) (map) );
		}
		#line default
		
		public static global::haxe.ds.IntMap<V> fromIntMap<V>(global::haxe.ds.IntMap<V> map) {
			#line 190 "/opt/haxe/std/haxe/ds/Map.hx"
			return ((global::haxe.ds.IntMap<V>) (map) );
		}
		#line default
		
		public static global::haxe.ds.ObjectMap<K, V> fromObjectMap<K, V>(global::haxe.ds.ObjectMap<K, V> map) {
			#line 194 "/opt/haxe/std/haxe/ds/Map.hx"
			return ((global::haxe.ds.ObjectMap<K, V>) (map) );
		}
		#line default
		
	}
}


