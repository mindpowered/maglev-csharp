// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class WeakMap<K, V> : global::haxe.lang.HxObject, global::haxe.ds.WeakMap, global::haxe.IMap<K, V> {
		
		public WeakMap(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public WeakMap() {
			#line 38 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			global::haxe.ds.WeakMap<object, object>.__hx_ctor_haxe_ds_WeakMap<K, V>(((global::haxe.ds.WeakMap<K, V>) (this) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_ds_WeakMap<K_c, V_c>(global::haxe.ds.WeakMap<K_c, V_c> __hx_this) {
			#line 39 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			throw ((global::System.Exception) (global::haxe.Exception.thrown("Not implemented for this platform")) );
		}
		#line default
		
		public static object __hx_cast<K_c_c, V_c_c>(global::haxe.ds.WeakMap me) {
			#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return ( (( me != null )) ? (me.haxe_ds_WeakMap_cast<K_c_c, V_c_c>()) : default(object) );
		}
		#line default
		
		global::haxe.IMap<K, V> global::haxe.IMap<K, V>.copy() {
			#line 92 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return ((global::haxe.IMap<K, V>) (this.copy()) );
		}
		#line default
		
		public virtual object haxe_ds_WeakMap_cast<K_c, V_c>() {
			#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			if (( global::haxe.lang.Runtime.eq(typeof(K), typeof(K_c)) && global::haxe.lang.Runtime.eq(typeof(V), typeof(V_c)) )) {
				#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
				return this;
			}
			
			#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			global::haxe.ds.WeakMap<K_c, V_c> new_me = new global::haxe.ds.WeakMap<K_c, V_c>(global::haxe.lang.EmptyObject.EMPTY);
			#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			global::Array<string> fields = global::Reflect.fields(this);
			#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			int i = 0;
			#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			while (( i < fields.length )) {
				#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
				string field = fields[i++];
				#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
				global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
			}
			
			#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return new_me;
		}
		#line default
		
		public virtual object haxe_IMap_cast<K_c, V_c>() {
			#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return this.haxe_ds_WeakMap_cast<K, V>();
		}
		#line default
		
		public virtual void @set(K key, V @value) {
		}
		
		
		public virtual global::haxe.lang.Null<V> @get(K key) {
			#line 51 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return default(global::haxe.lang.Null<V>);
		}
		#line default
		
		public virtual bool exists(K key) {
			#line 58 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return false;
		}
		#line default
		
		public virtual bool @remove(K key) {
			#line 65 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return false;
		}
		#line default
		
		public virtual object keys() {
			#line 72 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return null;
		}
		#line default
		
		public virtual object iterator() {
			#line 79 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return null;
		}
		#line default
		
		public object keyValueIterator() {
			#line 86 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return null;
		}
		#line default
		
		public virtual global::haxe.ds.WeakMap<K, V> copy() {
			#line 93 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return null;
		}
		#line default
		
		public virtual string toString() {
			#line 100 "/opt/haxe/std/haxe/ds/WeakMap.hx"
			return null;
		}
		#line default
		
		public virtual void clear() {
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
				switch (hash) {
					case 1213952397:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "clear", 1213952397)) );
					}
					
					
					case 946786476:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 1103412149:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "copy", 1103412149)) );
					}
					
					
					case 1257164128:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "keyValueIterator", 1257164128)) );
					}
					
					
					case 328878574:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "iterator", 328878574)) );
					}
					
					
					case 1191633396:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "keys", 1191633396)) );
					}
					
					
					case 76061764:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "remove", 76061764)) );
					}
					
					
					case 1071652316:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "exists", 1071652316)) );
					}
					
					
					case 5144726:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "get", 5144726)) );
					}
					
					
					case 5741474:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "set", 5741474)) );
					}
					
					
					default:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
				switch (hash) {
					case 1213952397:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						this.clear();
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						break;
					}
					
					
					case 946786476:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return this.toString();
					}
					
					
					case 1103412149:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return this.copy();
					}
					
					
					case 1257164128:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return this.keyValueIterator();
					}
					
					
					case 328878574:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return this.iterator();
					}
					
					
					case 1191633396:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return this.keys();
					}
					
					
					case 76061764:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return this.@remove(global::haxe.lang.Runtime.genericCast<K>(dynargs[0]));
					}
					
					
					case 1071652316:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return this.exists(global::haxe.lang.Runtime.genericCast<K>(dynargs[0]));
					}
					
					
					case 5144726:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return (this.@get(global::haxe.lang.Runtime.genericCast<K>(dynargs[0]))).toDynamic();
					}
					
					
					case 5741474:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						this.@set(global::haxe.lang.Runtime.genericCast<K>(dynargs[0]), global::haxe.lang.Runtime.genericCast<V>(dynargs[1]));
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						break;
					}
					
					
					default:
					{
						#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 34 "/opt/haxe/std/haxe/ds/WeakMap.hx"
				return null;
			}
			#line default
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.ds.WeakMap<object, object>))]
	public interface WeakMap : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object haxe_ds_WeakMap_cast<K_c, V_c>();
		
		object haxe_IMap_cast<K_c, V_c>();
		
		object keys();
		
		object iterator();
		
		object keyValueIterator();
		
		string toString();
		
		void clear();
		
	}
}


