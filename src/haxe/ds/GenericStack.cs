// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class GenericCell<T> : global::haxe.lang.HxObject, global::haxe.ds.GenericCell {
		
		public GenericCell(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public GenericCell(T elt, global::haxe.ds.GenericCell<T> next) {
			#line 37 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::haxe.ds.GenericCell<object>.__hx_ctor_haxe_ds_GenericCell<T>(((global::haxe.ds.GenericCell<T>) (this) ), global::haxe.lang.Runtime.genericCast<T>(elt), ((global::haxe.ds.GenericCell<T>) (next) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_ds_GenericCell<T_c>(global::haxe.ds.GenericCell<T_c> __hx_this, T_c elt, global::haxe.ds.GenericCell<T_c> next) {
			#line 38 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			__hx_this.elt = elt;
			__hx_this.next = next;
		}
		#line default
		
		public static object __hx_cast<T_c_c>(global::haxe.ds.GenericCell me) {
			#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			return ( (( me != null )) ? (me.haxe_ds_GenericCell_cast<T_c_c>()) : default(object) );
		}
		#line default
		
		public virtual object haxe_ds_GenericCell_cast<T_c>() {
			#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				return this;
			}
			
			#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::haxe.ds.GenericCell<T_c> new_me = new global::haxe.ds.GenericCell<T_c>(global::haxe.lang.EmptyObject.EMPTY);
			#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::Array<string> fields = global::Reflect.fields(this);
			#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			int i = 0;
			#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			while (( i < fields.length )) {
				#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				string field = fields[i++];
				#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
			}
			
			#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			return new_me;
		}
		#line default
		
		public T elt;
		
		public global::haxe.ds.GenericCell<T> next;
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				switch (hash) {
					case 5046829:
					{
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						this.elt = global::haxe.lang.Runtime.genericCast<T>(((object) (@value) ));
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (@value) ))) );
					}
					
					
					default:
					{
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						this.next = ((global::haxe.ds.GenericCell<T>) (global::haxe.ds.GenericCell<object>.__hx_cast<T>(((global::haxe.ds.GenericCell) (@value) ))) );
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return @value;
					}
					
					
					case 5046829:
					{
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						this.elt = global::haxe.lang.Runtime.genericCast<T>(@value);
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return @value;
					}
					
					
					default:
					{
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return this.next;
					}
					
					
					case 5046829:
					{
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return this.elt;
					}
					
					
					default:
					{
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				switch (hash) {
					case 5046829:
					{
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this.elt) ))) );
					}
					
					
					default:
					{
						#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			baseArr.push("next");
			#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			baseArr.push("elt");
			#line 33 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.ds.GenericCell<object>))]
	public interface GenericCell : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object haxe_ds_GenericCell_cast<T_c>();
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class GenericStack<T> : global::haxe.lang.HxObject, global::haxe.ds.GenericStack {
		
		public GenericStack(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public GenericStack() {
			#line 107 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::haxe.ds.GenericStack<object>.__hx_ctor_haxe_ds_GenericStack<T>(((global::haxe.ds.GenericStack<T>) (this) ));
		}
		#line default
		
		protected static void __hx_ctor_haxe_ds_GenericStack<T_c>(global::haxe.ds.GenericStack<T_c> __hx_this) {
		}
		
		
		public static object __hx_cast<T_c_c>(global::haxe.ds.GenericStack me) {
			#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			return ( (( me != null )) ? (me.haxe_ds_GenericStack_cast<T_c_c>()) : default(object) );
		}
		#line default
		
		public virtual object haxe_ds_GenericStack_cast<T_c>() {
			#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				return this;
			}
			
			#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::haxe.ds.GenericStack<T_c> new_me = new global::haxe.ds.GenericStack<T_c>(global::haxe.lang.EmptyObject.EMPTY);
			#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::Array<string> fields = global::Reflect.fields(this);
			#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			int i = 0;
			#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			while (( i < fields.length )) {
				#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				string field = fields[i++];
				#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
			}
			
			#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			return new_me;
		}
		#line default
		
		public global::haxe.ds.GenericCell<T> head;
		
		public void @add(T item) {
			#line 113 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			this.head = new global::haxe.ds.GenericCell<T>(item, this.head);
		}
		#line default
		
		public global::haxe.lang.Null<T> first() {
			#line 122 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			if (( this.head == null )) {
				#line 122 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				return default(global::haxe.lang.Null<T>);
			}
			else {
				#line 122 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				return new global::haxe.lang.Null<T>(this.head.elt, true);
			}
			
		}
		#line default
		
		public global::haxe.lang.Null<T> pop() {
			#line 131 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::haxe.ds.GenericCell<T> k = this.head;
			if (( k == null )) {
				#line 133 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				return default(global::haxe.lang.Null<T>);
			}
			else {
				#line 135 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				this.head = k.next;
				return new global::haxe.lang.Null<T>(k.elt, true);
			}
			
		}
		#line default
		
		public bool isEmpty() {
			#line 144 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			return ( this.head == null );
		}
		#line default
		
		public virtual bool @remove(T v) {
			#line 157 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::haxe.ds.GenericCell<T> prev = null;
			global::haxe.ds.GenericCell<T> l = this.head;
			#line 159 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			while (( l != null )) {
				#line 160 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				if (global::haxe.lang.Runtime.eq(l.elt, v)) {
					#line 161 "/opt/haxe/std/haxe/ds/GenericStack.hx"
					if (( prev == null )) {
						#line 162 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						this.head = l.next;
					}
					else {
						#line 164 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						prev.next = l.next;
					}
					
					#line 165 "/opt/haxe/std/haxe/ds/GenericStack.hx"
					break;
				}
				
				#line 167 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				prev = l;
				l = l.next;
			}
			
			#line 170 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			return ( l != null );
		}
		#line default
		
		public virtual object iterator() {
			#line 186 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::haxe.ds.GenericCell<T>[] l = new global::haxe.ds.GenericCell<T>[]{this.head};
			{
				#line 188 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				global::haxe.lang.Function __temp_odecl1 = new global::haxe.ds.GenericStack_iterator_188__Fun<T>(l);
				#line 191 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				global::haxe.lang.Function __temp_odecl2 = new global::haxe.ds.GenericStack_iterator_191__Fun<T>(l);
				#line 187 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				return new global::haxe.lang.DynamicObject(new int[]{407283053, 1224901875}, new object[]{__temp_odecl1, __temp_odecl2}, new int[]{}, new double[]{});
			}
			
		}
		#line default
		
		public virtual string toString() {
			#line 204 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::Array<T> a = new global::Array<T>();
			global::haxe.ds.GenericCell<T> l = this.head;
			#line 206 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			while (( l != null )) {
				#line 207 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				a.push(l.elt);
				l = l.next;
			}
			
			#line 210 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			return global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("{", a.@join(",")), "}");
		}
		#line default
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				switch (hash) {
					case 1158359328:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						this.head = ((global::haxe.ds.GenericCell<T>) (global::haxe.ds.GenericCell<object>.__hx_cast<T>(((global::haxe.ds.GenericCell) (@value) ))) );
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return @value;
					}
					
					
					default:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				switch (hash) {
					case 946786476:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
					}
					
					
					case 328878574:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "iterator", 328878574)) );
					}
					
					
					case 76061764:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "remove", 76061764)) );
					}
					
					
					case 207609411:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "isEmpty", 207609411)) );
					}
					
					
					case 5594513:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "pop", 5594513)) );
					}
					
					
					case 10319920:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "first", 10319920)) );
					}
					
					
					case 4846113:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "add", 4846113)) );
					}
					
					
					case 1158359328:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return this.head;
					}
					
					
					default:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				switch (hash) {
					case 946786476:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return this.toString();
					}
					
					
					case 328878574:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return this.iterator();
					}
					
					
					case 76061764:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return this.@remove(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					}
					
					
					case 207609411:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return this.isEmpty();
					}
					
					
					case 5594513:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return (this.pop()).toDynamic();
					}
					
					
					case 10319920:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return (this.first()).toDynamic();
					}
					
					
					case 4846113:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						this.@add(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						break;
					}
					
					
					default:
					{
						#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
				return null;
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			baseArr.push("head");
			#line 101 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class GenericStack_iterator_188__Fun<T> : global::haxe.lang.Function {
		
		public GenericStack_iterator_188__Fun(global::haxe.ds.GenericCell<T>[] l) : base(0, 0) {
			#line 189 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			this.l = l;
		}
		#line default
		
		public override object __hx_invoke0_o() {
			#line 189 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			return ( ((global::haxe.ds.GenericCell<T>) (this.l[0]) ) != null );
		}
		#line default
		
		public global::haxe.ds.GenericCell<T>[] l;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class GenericStack_iterator_191__Fun<T> : global::haxe.lang.Function {
		
		public GenericStack_iterator_191__Fun(global::haxe.ds.GenericCell<T>[] l) : base(0, 0) {
			#line 191 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			this.l = l;
		}
		#line default
		
		public override object __hx_invoke0_o() {
			#line 192 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			global::haxe.ds.GenericCell<T> k = ((global::haxe.ds.GenericCell<T>) (this.l[0]) );
			this.l[0] = k.next;
			#line 194 "/opt/haxe/std/haxe/ds/GenericStack.hx"
			return k.elt;
		}
		#line default
		
		public global::haxe.ds.GenericCell<T>[] l;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.ds.GenericStack<object>))]
	public interface GenericStack : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object haxe_ds_GenericStack_cast<T_c>();
		
		bool isEmpty();
		
		object iterator();
		
		string toString();
		
	}
}


