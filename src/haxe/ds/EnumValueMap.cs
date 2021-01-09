// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class EnumValueMap<K, V> : global::haxe.ds.BalancedTree<K, V>, global::haxe.ds.EnumValueMap, global::haxe.IMap<K, V> {
		
		public EnumValueMap(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public EnumValueMap() : base(global::haxe.lang.EmptyObject.EMPTY) {
			#line 41 "/opt/haxe/std/haxe/ds/BalancedTree.hx"
			global::haxe.ds.EnumValueMap<object, object>.__hx_ctor_haxe_ds_EnumValueMap<K, V>(((global::haxe.ds.EnumValueMap<K, V>) (this) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_ds_EnumValueMap<K_c, V_c>(global::haxe.ds.EnumValueMap<K_c, V_c> __hx_this) {
			#line 41 "/opt/haxe/std/haxe/ds/BalancedTree.hx"
			global::haxe.ds.BalancedTree<object, object>.__hx_ctor_haxe_ds_BalancedTree<K_c, V_c>(((global::haxe.ds.BalancedTree<K_c, V_c>) (__hx_this) ));
		}
		#line default
		
		public static new object __hx_cast<K_c_c, V_c_c>(global::haxe.ds.EnumValueMap me) {
			#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			return ( (( me != null )) ? (me.haxe_ds_EnumValueMap_cast<K_c_c, V_c_c>()) : default(object) );
		}
		#line default
		
		global::haxe.IMap<K, V> global::haxe.IMap<K, V>.copy() {
			#line 144 "/opt/haxe/std/haxe/ds/BalancedTree.hx"
			return ((global::haxe.IMap<K, V>) (this.copy()) );
		}
		#line default
		
		public virtual object haxe_ds_EnumValueMap_cast<K_c, V_c>() {
			#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			if (( global::haxe.lang.Runtime.eq(typeof(K), typeof(K_c)) && global::haxe.lang.Runtime.eq(typeof(V), typeof(V_c)) )) {
				#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				return this;
			}
			
			#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			global::haxe.ds.EnumValueMap<K_c, V_c> new_me = new global::haxe.ds.EnumValueMap<K_c, V_c>(global::haxe.lang.EmptyObject.EMPTY);
			#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			global::Array<string> fields = global::Reflect.fields(this);
			#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			int i = 0;
			#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			while (( i < fields.length )) {
				#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				string field = fields[i++];
				#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
			}
			
			#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			return new_me;
		}
		#line default
		
		public override object haxe_IMap_cast<K_c, V_c>() {
			#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			return this.haxe_ds_EnumValueMap_cast<K, V>();
		}
		#line default
		
		public override object haxe_ds_BalancedTree_cast<K_c, V_c>() {
			#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			return this.haxe_ds_EnumValueMap_cast<K, V>();
		}
		#line default
		
		public override int compare(K __temp_k11, K __temp_k22) {
			#line 32 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			object k2 = ((object) (__temp_k22) );
			#line 32 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			object k1 = ((object) (__temp_k11) );
			int d = ( global::Type.enumIndex(k1) - global::Type.enumIndex(k2) );
			#line 34 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			if (( d != 0 )) {
				#line 35 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				return d;
			}
			
			#line 36 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			global::Array p1 = global::Type.enumParameters(k1);
			global::Array p2 = global::Type.enumParameters(k2);
			#line 38 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			if (( ( ((int) (global::haxe.lang.Runtime.getField_f(p1, "length", 520590566, true)) ) == 0 ) && ( ((int) (global::haxe.lang.Runtime.getField_f(p2, "length", 520590566, true)) ) == 0 ) )) {
				#line 39 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				return 0;
			}
			
			#line 40 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			return this.compareArgs(p1, p2);
		}
		#line default
		
		public virtual int compareArgs(global::Array a1, global::Array a2) {
			#line 44 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			int ld = ( ((int) (global::haxe.lang.Runtime.getField_f(a1, "length", 520590566, true)) ) - ((int) (global::haxe.lang.Runtime.getField_f(a2, "length", 520590566, true)) ) );
			if (( ld != 0 )) {
				#line 46 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				return ld;
			}
			
			#line 47 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			{
				#line 47 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				int _g = 0;
				#line 47 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				int _g1 = ((int) (global::haxe.lang.Runtime.getField_f(a1, "length", 520590566, true)) );
				#line 47 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				while (( _g < _g1 )) {
					#line 47 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
					int i = _g++;
					int d = this.compareArg(a1[i], a2[i]);
					#line 49 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
					if (( d != 0 )) {
						#line 50 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
						return d;
					}
					
				}
				
			}
			
			#line 52 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			return 0;
		}
		#line default
		
		public virtual int compareArg(object v1, object v2) {
			#line 56 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			if (( global::Reflect.isEnumValue(v1) && global::Reflect.isEnumValue(v2) )) {
				#line 57 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				return this.compare(global::haxe.lang.Runtime.genericCast<K>(v1), global::haxe.lang.Runtime.genericCast<K>(v2));
			}
			else if (( ( v1 is global::Array ) && ( v2 is global::Array ) )) {
				#line 59 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				return this.compareArgs(((global::Array) (v1) ), ((global::Array) (v2) ));
			}
			else {
				#line 61 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				return global::Reflect.compare<object>(((object) (v1) ), ((object) (v2) ));
			}
			
		}
		#line default
		
		public override global::haxe.ds.BalancedTree<K, V> copy() {
			#line 66 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			global::haxe.ds.EnumValueMap<K, V> copied = new global::haxe.ds.EnumValueMap<K, V>();
			copied.root = this.root;
			#line 68 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
			return copied;
		}
		#line default
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				switch (hash) {
					case 1103412149:
					{
						#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "copy", 1103412149)) );
					}
					
					
					case 244830897:
					{
						#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "compareArg", 244830897)) );
					}
					
					
					case 910198946:
					{
						#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "compareArgs", 910198946)) );
					}
					
					
					case 57219237:
					{
						#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "compare", 57219237)) );
					}
					
					
					default:
					{
						#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
				switch (hash) {
					case 57219237:
					case 1103412149:
					{
						#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
						return global::haxe.lang.Runtime.slowCallField(this, field, dynargs);
					}
					
					
					case 244830897:
					{
						#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
						return this.compareArg(dynargs[0], dynargs[1]);
					}
					
					
					case 910198946:
					{
						#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
						return this.compareArgs(((global::Array) (dynargs[0]) ), ((global::Array) (dynargs[1]) ));
					}
					
					
					default:
					{
						#line 31 "/opt/haxe/std/haxe/ds/EnumValueMap.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.ds.EnumValueMap<object, object>))]
	public interface EnumValueMap : global::haxe.lang.IHxObject, global::haxe.ds.BalancedTree, global::haxe.lang.IGenericObject {
		
		object haxe_ds_EnumValueMap_cast<K_c, V_c>();
		
		object haxe_ds_BalancedTree_cast<K_c, V_c>();
		
		int compareArgs(global::Array a1, global::Array a2);
		
		int compareArg(object v1, object v2);
		
	}
}

