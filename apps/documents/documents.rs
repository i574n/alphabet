#![allow(dead_code)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(unreachable_code)]
#![allow(unused_attributes)]
#![allow(unused_imports)]
#![allow(unused_macros)]
#![allow(unused_parens)]
#![allow(unused_variables)]
#![allow(unused_assignments)]
use fable_library_rust::NativeArray_::array_from;
use fable_library_rust::String_::fromString;
mod module_b8cdef03 {
    pub mod Documents {
        use super::*;
        use fable_library_rust::Async_::Async;
        use fable_library_rust::DateTime_::DateTime;
        use fable_library_rust::Exception_::try_catch;
        use fable_library_rust::List_::List;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::singleton;
        use fable_library_rust::List_::toArray as toArray_1;
        use fable_library_rust::Map_::find;
        use fable_library_rust::Map_::ofSeq;
        use fable_library_rust::Native_::Any;
        use fable_library_rust::Native_::Arc;
        use fable_library_rust::Native_::Func0;
        use fable_library_rust::Native_::Func1;
        use fable_library_rust::Native_::Func2;
        use fable_library_rust::Native_::LrcPtr;
        use fable_library_rust::Native_::MutCell;
        use fable_library_rust::Native_::OnceInit;
        use fable_library_rust::Native_::getNull;
        use fable_library_rust::Native_::unbox;
        use fable_library_rust::NativeArray_::Array;
        use fable_library_rust::NativeArray_::get_Count;
        use fable_library_rust::NativeArray_::new_array;
        use fable_library_rust::NativeArray_::new_empty;
        use fable_library_rust::NativeArray_::new_init;
        use fable_library_rust::Option_::defaultValue;
        use fable_library_rust::Option_::map;
        use fable_library_rust::Range_::rangeNumeric;
        use fable_library_rust::Seq_::delay;
        use fable_library_rust::Seq_::map as map_1;
        use fable_library_rust::Seq_::ofArray as ofArray_1;
        use fable_library_rust::Seq_::ofList;
        use fable_library_rust::Seq_::toArray;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::concat;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith3;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::join;
        use fable_library_rust::String_::lastIndexOf;
        use fable_library_rust::String_::length;
        use fable_library_rust::String_::ofChar;
        use fable_library_rust::String_::printfn;
        use fable_library_rust::String_::replace;
        use fable_library_rust::String_::split;
        use fable_library_rust::String_::sprintf;
        use fable_library_rust::String_::string;
        use fable_library_rust::String_::toLower;
        use fable_library_rust::String_::toString;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::System::Exception;
        use fable_library_rust::System::Threading::CancellationToken;
        use fable_library_rust::TimeSpan_::TimeSpan;
        pub trait IOsEnviron: core::fmt::Debug + core::fmt::Display {
            fn environ(&self) -> LrcPtr<dyn Any>;
        }
        impl<V: IOsEnviron + core::fmt::Debug + core::fmt::Display> IOsEnviron for LrcPtr<V> {
            #[inline]
            fn environ(&self) -> LrcPtr<dyn Any> {
                (**self).environ()
            }
        }
        pub mod TraceState {
            use super::*;
            pub fn trace_state() -> LrcPtr<
                MutCell<
                    Option<(
                        LrcPtr<Documents::Mut0>,
                        LrcPtr<Documents::Mut1>,
                        LrcPtr<Documents::Mut2>,
                        LrcPtr<Documents::Mut3>,
                        LrcPtr<Documents::Mut4>,
                        Option<i64>,
                    )>,
                >,
            > {
                static trace_state: OnceInit<
                    LrcPtr<
                        MutCell<
                            Option<(
                                LrcPtr<Documents::Mut0>,
                                LrcPtr<Documents::Mut1>,
                                LrcPtr<Documents::Mut2>,
                                LrcPtr<Documents::Mut3>,
                                LrcPtr<Documents::Mut4>,
                                Option<i64>,
                            )>,
                        >,
                    >,
                > = OnceInit::new();
                trace_state
                    .get_or_init(|| {
                        LrcPtr::new(MutCell::new(
                            None::<(
                                LrcPtr<Documents::Mut0>,
                                LrcPtr<Documents::Mut1>,
                                LrcPtr<Documents::Mut2>,
                                LrcPtr<Documents::Mut3>,
                                LrcPtr<Documents::Mut4>,
                                Option<i64>,
                            )>,
                        ))
                    })
                    .clone()
            }
        }
        pub trait IFs: core::fmt::Debug + core::fmt::Display {
            fn realpathSync(&self, path: string) -> string;
        }
        impl<V: IFs + core::fmt::Debug + core::fmt::Display> IFs for LrcPtr<V> {
            #[inline]
            fn realpathSync(&self, path: string) -> string {
                (**self).realpathSync(path)
            }
        }
        pub trait IPathJoin: core::fmt::Debug + core::fmt::Display {
            fn join(&self, paths: Array<string>) -> string;
        }
        impl<V: IPathJoin + core::fmt::Debug + core::fmt::Display> IPathJoin for LrcPtr<V> {
            #[inline]
            fn join(&self, paths: Array<string>) -> string {
                (**self).join(paths)
            }
        }
        pub trait IFsExistsSync: core::fmt::Debug + core::fmt::Display {
            fn existsSync(&self, path: string) -> bool;
        }
        impl<V: IFsExistsSync + core::fmt::Debug + core::fmt::Display> IFsExistsSync for LrcPtr<V> {
            #[inline]
            fn existsSync(&self, path: string) -> bool {
                (**self).existsSync(path)
            }
        }
        pub trait IPathDirname: core::fmt::Debug + core::fmt::Display {
            fn dirname(&self, path: string) -> string;
        }
        impl<V: IPathDirname + core::fmt::Debug + core::fmt::Display> IPathDirname for LrcPtr<V> {
            #[inline]
            fn dirname(&self, path: string) -> string {
                (**self).dirname(path)
            }
        }
        pub trait IPathBasename: core::fmt::Debug + core::fmt::Display {
            fn basename(&self, path: string) -> string;
        }
        impl<V: IPathBasename + core::fmt::Debug + core::fmt::Display> IPathBasename for LrcPtr<V> {
            #[inline]
            fn basename(&self, path: string) -> string {
                (**self).basename(path)
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US0 {
            US0_0,
            US0_1,
            US0_2,
            US0_3,
            US0_4,
        }
        impl core::fmt::Display for US0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut0 {
            pub l0: MutCell<i64>,
        }
        impl core::fmt::Display for Mut0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub struct Mut1 {
            pub l0: MutCell<Func1<string, ()>>,
        }
        impl core::fmt::Display for Mut1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut2 {
            pub l0: MutCell<bool>,
        }
        impl core::fmt::Display for Mut2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut3 {
            pub l0: MutCell<string>,
        }
        impl core::fmt::Display for Mut3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut4 {
            pub l0: MutCell<Documents::US0>,
        }
        impl core::fmt::Display for Mut4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US1 {
            US1_0(Documents::US0),
            US1_1,
        }
        impl core::fmt::Display for US1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US2 {
            US2_0(i64),
            US2_1,
        }
        impl core::fmt::Display for US2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US3 {
            US3_0,
            US3_1,
            US3_2,
        }
        impl core::fmt::Display for US3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US4 {
            US4_0(Documents::US3),
            US4_1(Documents::US3),
            US4_2(Documents::US3),
            US4_3(Documents::US3),
            US4_4(Documents::US3),
            US4_5(Documents::US3),
            US4_6(Documents::US3),
        }
        impl core::fmt::Display for US4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US5 {
            US5_0(string),
            US5_1,
        }
        impl core::fmt::Display for US5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US6 {
            US6_0(i64),
            US6_1(LrcPtr<Exception>),
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ),
            US7_1,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0(char),
            US8_1,
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US9 {
            US9_0(std::string::String),
            US9_1,
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US10 {
            US10_0,
            US10_1,
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US11 {
            US11_0(string),
            US11_1(string),
        }
        impl core::fmt::Display for US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(std::path::PathBuf),
            US12_1(string),
        }
        impl core::fmt::Display for US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US13 {
            US13_0(string),
            US13_1(LrcPtr<Exception>),
        }
        impl core::fmt::Display for US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0(std::path::PathBuf),
            US14_1,
        }
        impl core::fmt::Display for US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut6 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US15 {
            US15_0(std::fs::FileType),
            US15_1(std::string::String),
        }
        impl core::fmt::Display for US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US16 {
            US16_0,
            US16_1,
            US16_2,
        }
        impl core::fmt::Display for US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0(async_walkdir::DirEntry),
            US17_1(std::string::String),
        }
        impl core::fmt::Display for US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US18 {
            US18_0(string, Documents::US5),
            US18_1(string),
        }
        impl core::fmt::Display for US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0(Func0<char>, i32, i32, i32, i32, i32),
            US19_1(Func0<string>),
        }
        impl core::fmt::Display for US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH0 {
            UH0_0,
            UH0_1(
                Func1<(string, i32, i32, i32, i32, i32), Documents::US19>,
                LrcPtr<Documents::UH0>,
            ),
        }
        impl core::fmt::Display for UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(Func0<string>, i32, i32, i32, i32, i32),
            US20_1(Func0<string>),
        }
        impl core::fmt::Display for US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(Func0<()>, i32, i32, i32, i32, i32),
            US21_1(Func0<string>),
        }
        impl core::fmt::Display for US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US23 {
            US23_0(Func0<string>),
            US23_1,
        }
        impl core::fmt::Display for US23 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US22 {
            US22_0(
                Func0<(Func0<string>, Func0<Documents::US23>)>,
                i32,
                i32,
                i32,
                i32,
                i32,
            ),
            US22_1(Func0<string>),
        }
        impl core::fmt::Display for US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US24 {
            US24_0(Func0<Documents::US23>, i32, i32, i32, i32, i32),
            US24_1(Func0<string>),
        }
        impl core::fmt::Display for US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(
                Func0<(Func0<string>, Func0<Documents::US23>)>,
                Func0<string>,
                i32,
                i32,
                i32,
                i32,
            ),
            US25_1(Func0<string>),
        }
        impl core::fmt::Display for US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(
                Func0<string>,
                Func0<Documents::US23>,
                string,
                i32,
                i32,
                i32,
                i32,
            ),
            US26_1(Func0<string>),
        }
        impl core::fmt::Display for US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0(string, Documents::US5),
            US27_1(Func0<string>),
        }
        impl core::fmt::Display for US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US28 {
            US28_0(Array<string>),
            US28_1(string),
        }
        impl core::fmt::Display for US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0,
            UH1_1(
                Func1<(string, i32, i32, i32, i32, i32), Documents::US20>,
                LrcPtr<Documents::UH1>,
            ),
        }
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH2 {
            UH2_0,
            UH2_1(string, LrcPtr<Documents::UH2>),
        }
        impl core::fmt::Display for UH2 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0(Func0<LrcPtr<Documents::UH2>>, i32, i32, i32, i32, i32),
            US29_1(Func0<string>),
        }
        impl core::fmt::Display for US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US30 {
            US30_0(
                Func0<LrcPtr<Documents::UH2>>,
                Func0<string>,
                i32,
                i32,
                i32,
                i32,
            ),
            US30_1(Func0<string>),
        }
        impl core::fmt::Display for US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US31 {
            US31_0(LrcPtr<Documents::UH2>, string, i32, i32, i32, i32),
            US31_1(Func0<string>),
        }
        impl core::fmt::Display for US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US32 {
            US32_0(Array<string>),
            US32_1(Func0<string>),
        }
        impl core::fmt::Display for US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US33 {
            US33_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US33_1(std::string::String),
        }
        impl core::fmt::Display for US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US34 {
            US34_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US34_1,
        }
        impl core::fmt::Display for US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US35 {
            US35_0(std::string::String),
            US35_1(std::string::String),
        }
        impl core::fmt::Display for US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US36 {
            US36_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US36_1,
        }
        impl core::fmt::Display for US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US37 {
            US37_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US37_1,
        }
        impl core::fmt::Display for US37 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US38 {
            US38_0(std::process::Output),
            US38_1(std::string::String),
        }
        impl core::fmt::Display for US38 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US39 {
            US39_0(i32),
            US39_1,
        }
        impl core::fmt::Display for US39 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US40 {
            US40_0(Documents::US5),
            US40_1,
        }
        impl core::fmt::Display for US40 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US41 {
            US41_0(Result<string, LrcPtr<(string, string)>>),
            US41_1,
        }
        impl core::fmt::Display for US41 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH4 {
            UH4_0,
            UH4_1(
                string,
                string,
                Func2<string, string, Documents::US41>,
                LrcPtr<Documents::UH4>,
            ),
        }
        impl core::fmt::Display for UH4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(LrcPtr<Documents::UH4>, LrcPtr<Documents::UH3>),
        }
        impl core::fmt::Display for UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US42 {
            US42_0(usize),
            US42_1(LrcPtr<Exception>),
        }
        impl core::fmt::Display for US42 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US43 {
            US43_0(usize),
            US43_1,
        }
        impl core::fmt::Display for US43 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US44 {
            US44_0(string),
            US44_1(std::string::String),
        }
        impl core::fmt::Display for US44 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US45 {
            US45_0(u64),
            US45_1(std::string::String),
        }
        impl core::fmt::Display for US45 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US46 {
            US46_0(i32, string),
            US46_1(i32, string),
        }
        impl core::fmt::Display for US46 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut7 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
        }
        impl core::fmt::Display for Mut7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut8 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<string>,
            pub l2: MutCell<i32>,
            pub l3: MutCell<i32>,
        }
        impl core::fmt::Display for Mut8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US47 {
            US47_0(
                Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >,
            ),
            US47_1(std::string::String),
        }
        impl core::fmt::Display for US47 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        pub fn method0() -> clap::Command {
            let v1_1: string = string("r#\"command\"#");
            let v2: &'static str = r#"command"#;
            let v4: clap::Command = clap::Command::new(v2);
            let v6: string = string("r#\"source-dir\"#");
            let v7: &'static str = r#"source-dir"#;
            let v9: clap::Arg = clap::Arg::new(v7);
            let v11: clap::Arg = v9.short('s');
            let v12: string = string("r#\"source-dir\"#");
            let v13: &'static str = r#"source-dir"#;
            let v15: clap::Arg = v11.long(v13);
            let v17: clap::Arg = v15.required(true);
            let v19: clap::Command = clap::Command::arg(v4, v17);
            let v21: string = string("r#\"dist-dir\"#");
            let v22: &'static str = r#"dist-dir"#;
            let v24: clap::Arg = clap::Arg::new(v22);
            let v26: clap::Arg = v24.short('d');
            let v27: string = string("r#\"dist-dir\"#");
            let v28: &'static str = r#"dist-dir"#;
            let v30: clap::Arg = v26.long(v28);
            let v32: clap::Arg = v30.required(true);
            let v34: clap::Command = clap::Command::arg(v19, v32);
            let v36: string = string("r#\"cache-dir\"#");
            let v37: &'static str = r#"cache-dir"#;
            let v39: clap::Arg = clap::Arg::new(v37);
            let v41: clap::Arg = v39.short('c');
            let v42: string = string("r#\"cache-dir\"#");
            let v43: &'static str = r#"cache-dir"#;
            let v45: clap::Arg = v41.long(v43);
            let v47: clap::Arg = v45.required(true);
            let v49: clap::Command = clap::Command::arg(v34, v47);
            let v51: string = string("r#\"hangul-spec\"#");
            let v52: &'static str = r#"hangul-spec"#;
            let v54: clap::Arg = clap::Arg::new(v52);
            let v56: clap::Arg = v54.short('h');
            let v57: string = string("r#\"hangul-spec\"#");
            let v58: &'static str = r#"hangul-spec"#;
            let v60: clap::Arg = v56.long(v58);
            let v62: clap::Command = clap::Command::arg(v49, v60);
            let v64: string = string("r#\"filter\"#");
            let v65: &'static str = r#"filter"#;
            let v67: clap::Arg = clap::Arg::new(v65);
            let v69: clap::Arg = v67.short('f');
            let v70: string = string("r#\"filter\"#");
            let v71: &'static str = r#"filter"#;
            let v73: clap::Arg = v69.long(v71);
            let v75: clap::Command = clap::Command::arg(v62, v73);
            let v77: string = string("r#\"transcribe-only\"#");
            let v78: &'static str = r#"transcribe-only"#;
            let v80: clap::Arg = clap::Arg::new(v78);
            let v82: clap::Arg = v80.short('t');
            let v83: string = string("r#\"transcribe-only\"#");
            let v84: &'static str = r#"transcribe-only"#;
            let v86: clap::Arg = v82.long(v84);
            let v88: string = string("r#\"false\"#");
            let v89: &str = r#"false"#;
            let v91: clap::Arg = v86.default_value(v89);
            let v93: clap::ArgAction = clap::ArgAction::SetTrue;
            let v95: clap::Arg = v91.action(v93);
            clap::Command::arg(v75, v95)
        }
        pub fn closure0(unitVar: (), unitVar_1: ()) {
            let v1_1: bool = true;
            () //;
        } /* /*;
        {
        let v4: string = string("*/ #[test] fn verify_app() { //");
        let v5: bool = */
        #[test]
        fn verify_app() {
            //;
            let v6: clap::Command = Documents::method0();
            clap::Command::debug_assert(v6);
            {
                //;
                ()
            }
        }
        pub fn method4(v0_1: string) -> string {
            v0_1
        }
        pub fn method5() -> string {
            string("")
        }
        pub fn closure3(unitVar: (), v0_1: string) -> Documents::US5 {
            Documents::US5::US5_0(v0_1)
        }
        pub fn method6() -> Func1<string, Documents::US5> {
            Func1::new(move |v: string| Documents::closure3((), v))
        }
        pub fn method3(v0_1: string) -> string {
            let v21: string = Documents::method4(v0_1);
            let v23: Result<std::string::String, std::env::VarError> = std::env::var(&*v21);
            let v25: bool = true;
            let _result_map_ = v23.map(|x| {
                //;
                let v27: std::string::String = x;
                let v29: string = fable_library_rust::String_::fromString(v27);
                let v31: bool = true;
                v29
            });
            let v33: Result<string, std::env::VarError> = _result_map_;
            let v34: string = Documents::method5();
            v33.unwrap_or(v34)
        }
        pub fn closure4(v0_1: i64, unitVar: ()) -> i64 {
            v0_1
        }
        pub fn closure5(unitVar: (), v0_1: i64) -> Documents::US6 {
            Documents::US6::US6_0(v0_1)
        }
        pub fn closure6(unitVar: (), v0_1: Func0<LrcPtr<Exception>>) -> LrcPtr<Exception> {
            v0_1()
        }
        pub fn closure7(unitVar: (), v0_1: LrcPtr<Exception>) -> Documents::US6 {
            Documents::US6::US6_1(v0_1)
        }
        pub fn method7(v0_1: i64) -> Documents::US6 {
            try_catch(
                || Documents::closure5((), Documents::closure4(v0_1, ())),
                |ex: LrcPtr<Exception>| {
                    Documents::closure7(
                        (),
                        Documents::closure6(
                            (),
                            Func0::new({
                                let ex = ex.clone();
                                move || ex.clone()
                            }),
                        ),
                    )
                },
            )
        }
        pub fn method2() -> (Documents::US1, Documents::US2) {
            let v1_1: string = Documents::method3(string("TRACE_LEVEL"));
            let v6: string = toLower(string("Critical"));
            let v20: string = toLower(string("Warning"));
            let v34: string = toLower(string("Info"));
            let v48: string = toLower(string("Debug"));
            let v62: string = toLower(string("Verbose"));
            let v76: Documents::US1 = if string("Verbose") == (v1_1.clone()) {
                Documents::US1::US1_0(Documents::US0::US0_0)
            } else {
                Documents::US1::US1_1
            };
            (
                match &v76 {
                    Documents::US1::US1_0(v76_0_0) => Documents::US1::US1_0(
                        match &v76 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v83: Documents::US1 = if string("Debug") == (v1_1.clone()) {
                            Documents::US1::US1_0(Documents::US0::US0_1)
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v83 {
                            Documents::US1::US1_0(v83_0_0) => Documents::US1::US1_0(
                                match &v83 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v90: Documents::US1 = if string("Info") == (v1_1.clone()) {
                                    Documents::US1::US1_0(Documents::US0::US0_2)
                                } else {
                                    Documents::US1::US1_1
                                };
                                match &v90 {
                                    Documents::US1::US1_0(v90_0_0) => Documents::US1::US1_0(
                                        match &v90 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v97: Documents::US1 =
                                            if string("Warning") == (v1_1.clone()) {
                                                Documents::US1::US1_0(Documents::US0::US0_3)
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v97 {
                                            Documents::US1::US1_0(v97_0_0) => {
                                                Documents::US1::US1_0(
                                                    match &v97 {
                                                        Documents::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v104: Documents::US1 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Documents::US1::US1_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US1::US1_1
                                                    };
                                                match &v104 {
                                                    Documents::US1::US1_0(v104_0_0) => {
                                                        Documents::US1::US1_0(
                                                            match &v104 {
                                                                Documents::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => {
                                                        let v111: Documents::US1 =
                                                            if (v62.clone()) == (v1_1.clone()) {
                                                                Documents::US1::US1_0(
                                                                    Documents::US0::US0_0,
                                                                )
                                                            } else {
                                                                Documents::US1::US1_1
                                                            };
                                                        match &v111 {
                                                            Documents::US1::US1_0(v111_0_0) => {
                                                                Documents::US1::US1_0(
                                                                    match &v111 {
                                                                        Documents::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    }
                                                                    .clone(),
                                                                )
                                                            }
                                                            _ => {
                                                                let v118: Documents::US1 = if (v48
                                                                    .clone())
                                                                    == (v1_1.clone())
                                                                {
                                                                    Documents::US1::US1_0(
                                                                        Documents::US0::US0_1,
                                                                    )
                                                                } else {
                                                                    Documents::US1::US1_1
                                                                };
                                                                match &v118 {
                                                                 Documents::US1::US1_0(v118_0_0)
                                                                 =>
                                                                 Documents::US1::US1_0(match &v118
                                                                                           {
                                                                                           Documents::US1::US1_0(x)
                                                                                           =>
                                                                                           x.clone(),
                                                                                           _
                                                                                           =>
                                                                                           unreachable!(),
                                                                                       }.clone()),
                                                                 _ => {
                                                                     let v125:
                                                                             Documents::US1 =
                                                                         if (v34.clone())
                                                                                ==
                                                                                (v1_1.clone())
                                                                            {
                                                                             Documents::US1::US1_0(Documents::US0::US0_2)
                                                                         } else {
                                                                             Documents::US1::US1_1
                                                                         };
                                                                     match &v125
                                                                         {
                                                                         Documents::US1::US1_0(v125_0_0)
                                                                         =>
                                                                         Documents::US1::US1_0(match &v125
                                                                                                   {
                                                                                                   Documents::US1::US1_0(x)
                                                                                                   =>
                                                                                                   x.clone(),
                                                                                                   _
                                                                                                   =>
                                                                                                   unreachable!(),
                                                                                               }.clone()),
                                                                         _ =>
                                                                         {
                                                                             let v132:
                                                                                     Documents::US1 =
                                                                                 if (v20.clone())
                                                                                        ==
                                                                                        (v1_1.clone())
                                                                                    {
                                                                                     Documents::US1::US1_0(Documents::US0::US0_3)
                                                                                 } else {
                                                                                     Documents::US1::US1_1
                                                                                 };
                                                                             match &v132
                                                                                 {
                                                                                 Documents::US1::US1_0(v132_0_0)
                                                                                 =>
                                                                                 Documents::US1::US1_0(match &v132
                                                                                                           {
                                                                                                           Documents::US1::US1_0(x)
                                                                                                           =>
                                                                                                           x.clone(),
                                                                                                           _
                                                                                                           =>
                                                                                                           unreachable!(),
                                                                                                       }.clone()),
                                                                                 _
                                                                                 =>
                                                                                 {
                                                                                     let v139:
                                                                                             Documents::US1 =
                                                                                         if (v6.clone())
                                                                                                ==
                                                                                                (v1_1.clone())
                                                                                            {
                                                                                             Documents::US1::US1_0(Documents::US0::US0_4)
                                                                                         } else {
                                                                                             Documents::US1::US1_1
                                                                                         };
                                                                                     match &v139
                                                                                         {
                                                                                         Documents::US1::US1_0(v139_0_0)
                                                                                         =>
                                                                                         Documents::US1::US1_0(match &v139
                                                                                                                   {
                                                                                                                   Documents::US1::US1_0(x)
                                                                                                                   =>
                                                                                                                   x.clone(),
                                                                                                                   _
                                                                                                                   =>
                                                                                                                   unreachable!(),
                                                                                                               }.clone()),
                                                                                         _
                                                                                         =>
                                                                                         Documents::US1::US1_1,
                                                                                     }
                                                                                 }
                                                                             }
                                                                         }
                                                                     }
                                                                 }
                                                             }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                if (Documents::method3(string("AUTOMATION"))) != string("True") {
                    Documents::US2::US2_1
                } else {
                    let v365: Documents::US6 = Documents::method7({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    });
                    let v384: Documents::US2 = match &v365 {
                        Documents::US6::US6_0(v365_0_0) => Documents::US2::US2_0(v365_0_0.clone()),
                        _ => Documents::US2::US2_1,
                    };
                    Documents::US2::US2_0(match &v384 {
                        Documents::US2::US2_0(v384_0_0) => match &v384 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    })
                },
            )
        }
        pub fn closure8(unitVar: (), v0_1: string) {
            ();
        }
        pub fn method1(
            v0_1: Documents::US0,
        ) -> (
            LrcPtr<Documents::Mut0>,
            LrcPtr<Documents::Mut1>,
            LrcPtr<Documents::Mut2>,
            LrcPtr<Documents::Mut3>,
            LrcPtr<Documents::Mut4>,
            Option<i64>,
        ) {
            let patternInput: (Documents::US1, Documents::US2) = Documents::method2();
            let _run_target_args__v3: (Documents::US1, Documents::US2) =
                (patternInput.0.clone(), patternInput.1.clone());
            let v395: Documents::US2 = _run_target_args__v3.1.clone();
            let v394: Documents::US1 = _run_target_args__v3.0.clone();
            (
                LrcPtr::new(Documents::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Documents::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Documents::closure8((), v))),
                }),
                LrcPtr::new(Documents::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(match &v394 {
                        Documents::US1::US1_0(v394_0_0) => match &v394 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v395 {
                    Documents::US2::US2_0(v395_0_0) => Some(match &v395 {
                        Documents::US2::US2_0(x) => x.clone(),
                        _ => unreachable!(),
                    }),
                    _ => None::<i64>,
                },
            )
        }
        pub fn closure2(unitVar: (), unitVar_1: ()) {
            if Documents::TraceState::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::method1(Documents::US0::US0_2);
                Documents::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn closure10(unitVar: (), unitVar_1: ()) {
            if Documents::TraceState::trace_state().get().clone().is_none() {
                let patternInput: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::method1(Documents::US0::US0_0);
                Documents::TraceState::trace_state().set(Some((
                    patternInput.0.clone(),
                    patternInput.1.clone(),
                    patternInput.2.clone(),
                    patternInput.3.clone(),
                    patternInput.4.clone(),
                    patternInput.5.clone(),
                )));
                ()
            };
        }
        pub fn closure11(unitVar: (), v0_1: i64) -> Documents::US2 {
            Documents::US2::US2_0(v0_1)
        }
        pub fn method9() -> Func1<i64, Documents::US2> {
            Func1::new(move |v: i64| Documents::closure11((), v))
        }
        pub fn method10() -> string {
            string("hh:mm:ss")
        }
        pub fn method11() -> string {
            string("HH:mm:ss")
        }
        pub fn method8(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v633: Documents::US2 =
                defaultValue(Documents::US2::US2_1, map(Documents::method9(), v5));
            let v1111: DateTime = match &v633 {
                Documents::US2::US2_0(v633_0_0) => {
                    let v831: Documents::US6 = Documents::method7({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    });
                    let v850: Documents::US2 = match &v831 {
                        Documents::US6::US6_0(v831_0_0) => Documents::US2::US2_0(v831_0_0.clone()),
                        _ => Documents::US2::US2_1,
                    };
                    let v957: TimeSpan = TimeSpan::new_ticks(
                        (match &v850 {
                            Documents::US2::US2_0(v850_0_0) => match &v850 {
                                Documents::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }) - (match &v633 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v957.hours(),
                        v957.minutes(),
                        v957.seconds(),
                        v957.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v1112: string = Documents::method10();
            let provider: string = if (v1112.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v1112
            };
            v1111.toString(provider)
        }
        pub fn method14() -> string {
            string("")
        }
        pub fn method15(v0_1: LrcPtr<Documents::Mut3>, v1_1: string) {
            let v4: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v4);
            ()
        }
        pub fn method13(v0_1: char) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method15(v10.clone(), sprintf!("{}", v0_1));
            v10.l0.get().clone()
        }
        pub fn method12() -> string {
            let v3: &str = inline_colorization::color_bright_green;
            let v17: std::string::String = String::from(v3);
            let v293: string = append(
                (fable_library_rust::String_::fromString(v17)),
                (Documents::method13(getCharAt(toLower(string("Info")), 0_i32))),
            );
            let v306: &str = inline_colorization::color_reset;
            let v320: std::string::String = String::from(v306);
            append((v293), (fable_library_rust::String_::fromString(v320)))
        }
        pub fn method18(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("{ "));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method19(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("args"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method20(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string(" = "));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method21(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string(" }"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method17(v0_1: Array<string>) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v10.clone());
            Documents::method19(v10.clone());
            Documents::method20(v10.clone());
            Documents::method15(v10.clone(), sprintf!("{:?}", v0_1));
            Documents::method21(v10.clone());
            v10.l0.get().clone()
        }
        pub fn method24(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method24: loop {
                break '_method24 (if (v1_1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Documents::US8 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US8::US8_0(' ')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US8::US8_0('\t')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US8::US8_0('\r')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Documents::US8::US8_0('\n')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Documents::US8::US8_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Documents::US8::US8_0(v19_0_0) => match &v19 {
                                Documents::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method24;
                    }
                });
            }
        }
        pub fn method23(v0_1: string, v1_1: i32, v2: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2: MutCell<i32> = MutCell::new(v2);
            '_method23: loop {
                break '_method23 (if (v2.get().clone()) >= (v1_1.get().clone()) {
                    v1_1.get().clone()
                } else {
                    if Documents::method24(getCharAt(v0_1.get().clone(), v2.get().clone()), 0_i64) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone();
                        let v2_temp: i32 = (v2.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2.set(v2_temp);
                        continue '_method23;
                    } else {
                        v2.get().clone()
                    }
                });
            }
        }
        pub fn method26(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method26: loop {
                break '_method26 (if (v1_1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Documents::US8 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US8::US8_0(' ')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US8::US8_0('/')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Documents::US8::US8_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Documents::US8::US8_0(v11_0_0) => match &v11 {
                                Documents::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method26;
                    }
                });
            }
        }
        pub fn method25(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method25: loop {
                break '_method25 (if (v1_1.get().clone()) <= 0_i32 {
                    0_i32
                } else {
                    let v3: i32 = (v1_1.get().clone()) - 1_i32;
                    if Documents::method26(getCharAt(v0_1.get().clone(), v3), 0_i64) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v3;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method25;
                    } else {
                        v3
                    }
                });
            }
        }
        pub fn method22(v0_1: string) -> string {
            let v1_1: i32 = length(v0_1.clone());
            let v492: string = getSlice(
                v0_1.clone(),
                Some(Documents::method23(v0_1, v1_1, 0_i32)),
                Some(v1_1),
            );
            getSlice(
                v492.clone(),
                Some(0_i32),
                Some(Documents::method25(v492.clone(), length(v492))),
            )
        }
        pub fn method16(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: Array<string>,
        ) -> string {
            let v9: string = Documents::method17(v8);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.main"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure12(v0_1: LrcPtr<Documents::Mut0>, unitVar: ()) {
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure14(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure13(unitVar: (), v0_1: string) {
            let v22: () = {
                Documents::closure14(v0_1, ());
                ()
            };
            ()
        }
        pub fn method27(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn closure9(v0_1: Array<string>, unitVar: ()) {
            fn v31() {
                Documents::closure10((), ());
            }
            let v32: () = {
                v31();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v110: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v513: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v110,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v148: () = {
                    v31();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v191: Option<i64> = patternInput_1.5.clone();
                let v190: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v189: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v188: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v187: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v186: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v228: string = Documents::method16(
                    v186.clone(),
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    Documents::method8(v186, v187, v188, v189, v190, v191),
                    Documents::method12(),
                    v0_1,
                );
                let v259: () = {
                    v31();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v298: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v297: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v341: () = {
                    Documents::closure12(v297.clone(), ());
                    ()
                };
                println!("{}", v228.clone());
                (v298.l0.get().clone())(v228);
                Documents::US7::US7_0(
                    v297,
                    v298,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method28() -> string {
            string("source-dir")
        }
        pub fn closure15(unitVar: (), v0_1: std::string::String) -> Documents::US9 {
            Documents::US9::US9_0(v0_1)
        }
        pub fn method29() -> Func1<std::string::String, Documents::US9> {
            Func1::new(move |v: std::string::String| Documents::closure15((), v))
        }
        pub fn method30() -> string {
            string("dist-dir")
        }
        pub fn method31() -> string {
            string("cache-dir")
        }
        pub fn method32() -> string {
            string("hangul-spec")
        }
        pub fn method33() -> string {
            string("filter")
        }
        pub fn method34() -> string {
            string("transcribe-only")
        }
        pub fn method37(v0_1: std::path::PathBuf) -> std::path::PathBuf {
            v0_1
        }
        pub fn method36() -> string {
            let v13: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v41: std::path::PathBuf = Documents::method37(v13.unwrap());
            let v43: std::path::Display = v41.display();
            let v130: std::string::String = format!("{}", v43);
            fable_library_rust::String_::fromString(v130)
        }
        pub fn method39(v0_1: string, v1_1: string) -> string {
            let v20: &str = &*v0_1;
            let v105: std::string::String = String::from(v20);
            let v190: std::path::PathBuf = std::path::PathBuf::from(v105);
            let v275: &str = &*v1_1;
            let v360: std::string::String = String::from(v275);
            let v446: std::path::PathBuf = Documents::method37(v190.join(v360));
            let v448: std::path::Display = v446.display();
            let v535: std::string::String = format!("{}", v448);
            fable_library_rust::String_::fromString(v535)
        }
        pub fn method41(v0_1: string) -> bool {
            let v26: &str = &*v0_1;
            let v111: std::string::String = String::from(v26);
            let v245: std::path::PathBuf = std::path::PathBuf::from(v111);
            if v245.clone().exists() {
                v245.is_file()
            } else {
                false
            }
        }
        pub fn closure16(unitVar: (), v0_1: string) -> bool {
            Documents::method41(v0_1)
        }
        pub fn method42(v0_1: string) -> bool {
            let v26: &str = &*v0_1;
            let v111: std::string::String = String::from(v26);
            let v245: std::path::PathBuf = std::path::PathBuf::from(v111);
            if v245.clone().exists() {
                v245.is_dir()
            } else {
                false
            }
        }
        pub fn closure17(unitVar: (), v0_1: string) -> bool {
            Documents::method42(v0_1)
        }
        pub fn method44(v0_1: string) -> Option<string> {
            let v26: &str = &*v0_1;
            let v111: std::string::String = String::from(v26);
            let v196: std::path::PathBuf = std::path::PathBuf::from(v111);
            let v269: Option<std::path::PathBuf> = v196.parent().map(std::path::PathBuf::from);
            let v271: bool = true;
            let _optionm_map_ = v269.map(|x| {
                //;
                let v286: std::path::PathBuf = Documents::method37(x);
                let v288: std::path::Display = v286.display();
                let v375: std::string::String = format!("{}", v288);
                let v448: string = fable_library_rust::String_::fromString(v375);
                let v450: bool = true;
                v448
            });
            _optionm_map_
        }
        pub fn method45(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
            v4: string,
        ) -> Documents::US11 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<bool> = MutCell::new(v2);
            let v3 = MutCell::new(v3.clone());
            let v4: MutCell<string> = MutCell::new(v4.clone());
            '_method45: loop {
                break '_method45 (if v3(Documents::method39(v4.get().clone(), v0_1.get().clone())) {
                    Documents::US11::US11_0(v4.get().clone())
                } else {
                    let v8: Option<string> = Documents::method44(v4.get().clone());
                    let v70: Documents::US5 =
                        defaultValue(Documents::US5::US5_1, map(Documents::method6(), v8));
                    match &v70 {
                        Documents::US5::US5_0(v70_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: bool = v2.get().clone();
                            let v3_temp = v3.get().clone();
                            let v4_temp: string = match &v70 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method45;
                        }
                        _ => Documents::US11::US11_1(append(
                            (concat(new_array(&[
                                string("file_system.find_parent / No parent for "),
                                if v2.get().clone() {
                                    string("file")
                                } else {
                                    string("dir")
                                },
                            ]))),
                            sprintf!(
                                " \'{}\' at \'{}\' (until \'{}\')",
                                v0_1.get().clone(),
                                v1_1.get().clone(),
                                v4.get().clone()
                            ),
                        )),
                    }
                });
            }
        }
        pub fn method43(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
        ) -> Documents::US11 {
            if v3(Documents::method39(v1_1.clone(), v0_1.clone())) {
                Documents::US11::US11_0(v1_1.clone())
            } else {
                let v7: Option<string> = Documents::method44(v1_1.clone());
                let v69: Documents::US5 =
                    defaultValue(Documents::US5::US5_1, map(Documents::method6(), v7));
                match &v69 {
                    Documents::US5::US5_0(v69_0_0) => Documents::method45(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2,
                        v3.clone(),
                        match &v69 {
                            Documents::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => Documents::US11::US11_1(append(
                        (concat(new_array(&[
                            string("file_system.find_parent / No parent for "),
                            if v2 { string("file") } else { string("dir") },
                        ]))),
                        sprintf!(
                            " \'{}\' at \'{}\' (until \'{}\')",
                            v0_1.clone(),
                            v1_1.clone(),
                            v1_1.clone()
                        ),
                    )),
                }
            }
        }
        pub fn method40(v0_1: Documents::US10, v1_1: string, v2: string) -> Documents::US11 {
            let v3: bool = if let Documents::US10::US10_0 = &v0_1 {
                true
            } else {
                false
            };
            Documents::method43(
                v1_1,
                v2,
                v3,
                if v3 {
                    Func1::new(move |v: string| Documents::closure16((), v))
                } else {
                    Func1::new(move |v_1: string| Documents::closure17((), v_1))
                },
            )
        }
        pub fn method46() -> string {
            let v3: &str = inline_colorization::color_yellow;
            let v17: std::string::String = String::from(v3);
            let v293: string = append(
                (fable_library_rust::String_::fromString(v17)),
                (Documents::method13(getCharAt(toLower(string("Warning")), 0_i32))),
            );
            let v306: &str = inline_colorization::color_reset;
            let v320: std::string::String = String::from(v306);
            append((v293), (fable_library_rust::String_::fromString(v320)))
        }
        pub fn method49(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("dir"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method50(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("; "));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method51(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("error"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method48(v0_1: string, v1_1: string) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v11.clone());
            Documents::method49(v11.clone());
            Documents::method20(v11.clone());
            Documents::method15(v11.clone(), v0_1);
            Documents::method50(v11.clone());
            Documents::method51(v11.clone());
            Documents::method20(v11.clone());
            Documents::method15(v11.clone(), v1_1);
            Documents::method21(v11.clone());
            v11.l0.get().clone()
        }
        pub fn method47(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
        ) -> string {
            let v10: string = Documents::method48(v8, v9);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("file_system.get_workspace_root"),
                    )),
                    string(" / "),
                )),
                (v10),
            ))
        }
        pub fn closure18(v0_1: string, v1_1: string, unitVar: ()) {
            fn v32() {
                Documents::closure10((), ());
            }
            let v33: () = {
                v32();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v111: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v514: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v111,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v149: () = {
                    v32();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v192: Option<i64> = patternInput_1.5.clone();
                let v191: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v190: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v189: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v188: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v187: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v229: string = Documents::method47(
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    Documents::method8(v187, v188, v189, v190, v191, v192),
                    Documents::method46(),
                    v0_1,
                    v1_1,
                );
                let v260: () = {
                    v32();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v299: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v298: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v342: () = {
                    Documents::closure12(v298.clone(), ());
                    ()
                };
                println!("{}", v229.clone());
                (v299.l0.get().clone())(v229);
                Documents::US7::US7_0(
                    v298,
                    v299,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method56(v0_1: std::io::Error) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v24: std::string::String = format!("{:#?}", v0_1);
            Documents::method15(v10.clone(), fable_library_rust::String_::fromString(v24));
            v10.l0.get().clone()
        }
        pub fn closure19(unitVar: (), v0_1: std::io::Error) -> string {
            Documents::method56(v0_1)
        }
        pub fn method55() -> Func1<std::io::Error, string> {
            Func1::new(move |v: std::io::Error| Documents::closure19((), v))
        }
        pub fn closure20(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US12 {
            Documents::US12::US12_0(v0_1)
        }
        pub fn method57() -> Func1<std::path::PathBuf, Documents::US12> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure20((), v))
        }
        pub fn closure21(unitVar: (), v0_1: string) -> Documents::US12 {
            Documents::US12::US12_1(v0_1)
        }
        pub fn method58() -> Func1<string, Documents::US12> {
            Func1::new(move |v: string| Documents::closure21((), v))
        }
        pub fn method61(v0_1: string) -> string {
            let v19: &str = &*v0_1;
            let v104: std::string::String = String::from(v19);
            let v189: std::path::PathBuf = std::path::PathBuf::from(v104);
            let v262: Option<&std::ffi::OsStr> = v189.file_name();
            let v264: bool = true;
            let _optionm_map_ = v262.map(|x| {
                //;
                let v266: &std::ffi::OsStr = x;
                let v268: std::ffi::OsString = v266.to_os_string();
                let v270: Option<&str> = v268.to_str();
                let v272: &str = v270.unwrap();
                let v286: std::string::String = String::from(v272);
                let v359: string = fable_library_rust::String_::fromString(v286);
                let v361: bool = true;
                v359
            });
            let v363: Option<string> = _optionm_map_;
            let v425: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v363));
            match &v425 {
                Documents::US5::US5_0(v425_0_0) => match &v425 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            }
        }
        pub fn method62(v0_1: string) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method15(v10.clone(), v0_1);
            v10.l0.get().clone()
        }
        pub fn closure24(v0_1: std::path::Display, unitVar: ()) -> string {
            toString(v0_1)
        }
        pub fn closure25(unitVar: (), v0_1: string) -> Documents::US13 {
            Documents::US13::US13_0(v0_1)
        }
        pub fn closure26(unitVar: (), v0_1: LrcPtr<Exception>) -> Documents::US13 {
            Documents::US13::US13_1(v0_1)
        }
        pub fn method63(v0_1: std::path::Display) -> Documents::US13 {
            try_catch(
                || Documents::closure25((), Documents::closure24(v0_1, ())),
                |ex: LrcPtr<Exception>| {
                    Documents::closure26(
                        (),
                        Documents::closure6(
                            (),
                            Func0::new({
                                let ex = ex.clone();
                                move || ex.clone()
                            }),
                        ),
                    )
                },
            )
        }
        pub fn method60(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method61(v4.clone());
            let v6: Option<string> = Documents::method44(v4.clone());
            let v68: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v79: string = Documents::method62(v3);
            if (v2) >= 11_u8 {
                let v83: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v97: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v83);
                Err(v97)
            } else {
                if let Documents::US5::US5_0(v68_0_0) = &v68 {
                    if (v4.clone()) != string("") {
                        let v200: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v68_0_0.clone());
                        let v201 = Documents::method55();
                        let v214: Result<std::path::PathBuf, string> = v200.map_err(|x| v201(x));
                        let v217 = Documents::method57();
                        let v218 = Documents::method58();
                        let v220: Documents::US12 = match &v214 {
                            Err(v214_1_0) => v218(v214_1_0.clone()),
                            Ok(v214_0_0) => v217(v214_0_0.clone()),
                        };
                        match &v220 {
                            Documents::US12::US12_0(v220_0_0) => {
                                let v249: std::path::PathBuf =
                                    Documents::method37(v220_0_0.clone());
                                let v331: Documents::US13 = Documents::method63(v249.display());
                                let v350: Documents::US5 = match &v331 {
                                    Documents::US13::US13_0(v331_0_0) => {
                                        Documents::US5::US5_0(v331_0_0.clone())
                                    }
                                    _ => Documents::US5::US5_1,
                                };
                                let v388: string = Documents::method39(
                                    match &v350 {
                                        Documents::US5::US5_0(v350_0_0) => match &v350 {
                                            Documents::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    },
                                    v5.clone(),
                                );
                                let v402: &str = &*v388;
                                let v487: std::string::String = String::from(v402);
                                let v572: std::path::PathBuf = std::path::PathBuf::from(v487);
                                Ok(v572)
                            }
                            Documents::US12::US12_1(v220_1_0) => {
                                let v662: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v220_1_0.clone(),
                                        v79.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v676: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v662);
                                Err(v676)
                            }
                        }
                    } else {
                        let v767: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v79.clone(),
                                v4.clone(),
                                v5.clone()
                            ),
                        );
                        let v781: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v767);
                        Err(v781)
                    }
                } else {
                    let v871: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1,
                            v79.clone(),
                            v4,
                            v5.clone()
                        ),
                    );
                    let v885: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v871);
                    Err(v885)
                }
            }
        }
        pub fn method59(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v16: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v17 = Documents::method55();
            let v30: Result<std::path::PathBuf, string> = v16.map_err(|x| v17(x));
            let v33 = Documents::method57();
            let v34 = Documents::method58();
            let v36: Documents::US12 = match &v30 {
                Err(v30_1_0) => v34(v30_1_0.clone()),
                Ok(v30_0_0) => v33(v30_0_0.clone()),
            };
            match &v36 {
                Documents::US12::US12_0(v36_0_0) => Ok(v36_0_0.clone()),
                Documents::US12::US12_1(v36_1_0) => Documents::method60(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure22(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v36_1_0.clone(),
                    v2.clone(),
                ),
            }
        }
        pub fn closure23(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method59(v0_1, v1_1, v2)
        }
        pub fn closure22(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure23(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method64(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method61(v0_1.clone());
            let v5: Option<string> = Documents::method44(v0_1.clone());
            let v67: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v78: string = Documents::method62(v3);
            if (v2) >= 11_u8 {
                let v82: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v96: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v82);
                Err(v96)
            } else {
                if let Documents::US5::US5_0(v67_0_0) = &v67 {
                    if (v0_1.clone()) != string("") {
                        let v199: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v67_0_0.clone());
                        let v200 = Documents::method55();
                        let v213: Result<std::path::PathBuf, string> = v199.map_err(|x| v200(x));
                        let v216 = Documents::method57();
                        let v217 = Documents::method58();
                        let v219: Documents::US12 = match &v213 {
                            Err(v213_1_0) => v217(v213_1_0.clone()),
                            Ok(v213_0_0) => v216(v213_0_0.clone()),
                        };
                        match &v219 {
                            Documents::US12::US12_0(v219_0_0) => {
                                let v248: std::path::PathBuf =
                                    Documents::method37(v219_0_0.clone());
                                let v330: Documents::US13 = Documents::method63(v248.display());
                                let v349: Documents::US5 = match &v330 {
                                    Documents::US13::US13_0(v330_0_0) => {
                                        Documents::US5::US5_0(v330_0_0.clone())
                                    }
                                    _ => Documents::US5::US5_1,
                                };
                                let v387: string = Documents::method39(
                                    match &v349 {
                                        Documents::US5::US5_0(v349_0_0) => match &v349 {
                                            Documents::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    },
                                    v4.clone(),
                                );
                                let v401: &str = &*v387;
                                let v486: std::string::String = String::from(v401);
                                let v571: std::path::PathBuf = std::path::PathBuf::from(v486);
                                Ok(v571)
                            }
                            Documents::US12::US12_1(v219_1_0) => {
                                let v661: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v219_1_0.clone(),
                                        v78.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v675: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v661);
                                Err(v675)
                            }
                        }
                    } else {
                        let v766: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v78.clone(),
                                v0_1.clone(),
                                v4.clone()
                            ),
                        );
                        let v780: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v766);
                        Err(v780)
                    }
                } else {
                    let v870: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1.clone(),
                            v78.clone(),
                            v0_1,
                            v4.clone()
                        ),
                    );
                    let v884: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v870);
                    Err(v884)
                }
            }
        }
        pub fn method54(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v15: Result<std::path::PathBuf, std::io::Error> =
                std::fs::read_link(&*v0_1.clone());
            let v16 = Documents::method55();
            let v29: Result<std::path::PathBuf, string> = v15.map_err(|x| v16(x));
            let v32 = Documents::method57();
            let v33 = Documents::method58();
            let v35: Documents::US12 = match &v29 {
                Err(v29_1_0) => v33(v29_1_0.clone()),
                Ok(v29_0_0) => v32(v29_0_0.clone()),
            };
            match &v35 {
                Documents::US12::US12_0(v35_0_0) => Ok(v35_0_0.clone()),
                Documents::US12::US12_1(v35_1_0) => Documents::method64(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure22(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v35_1_0.clone(),
                ),
            }
        }
        pub fn method66(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method67() -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method68(v0_1: i32, v1_1: i32) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method70(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method61(v4.clone());
            let v6: Option<string> = Documents::method44(v4.clone());
            let v68: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v79: string = Documents::method56(v3);
            if (v2) >= 11_u8 {
                let v83: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v97: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v83);
                Err(v97)
            } else {
                if let Documents::US5::US5_0(v68_0_0) = &v68 {
                    if (v4.clone()) != string("") {
                        let v200: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v68_0_0.clone());
                        let v201 = Documents::method55();
                        let v214: Result<std::path::PathBuf, string> = v200.map_err(|x| v201(x));
                        let v217 = Documents::method57();
                        let v218 = Documents::method58();
                        let v220: Documents::US12 = match &v214 {
                            Err(v214_1_0) => v218(v214_1_0.clone()),
                            Ok(v214_0_0) => v217(v214_0_0.clone()),
                        };
                        match &v220 {
                            Documents::US12::US12_0(v220_0_0) => {
                                let v249: std::path::PathBuf =
                                    Documents::method37(v220_0_0.clone());
                                let v331: Documents::US13 = Documents::method63(v249.display());
                                let v350: Documents::US5 = match &v331 {
                                    Documents::US13::US13_0(v331_0_0) => {
                                        Documents::US5::US5_0(v331_0_0.clone())
                                    }
                                    _ => Documents::US5::US5_1,
                                };
                                let v388: string = Documents::method39(
                                    match &v350 {
                                        Documents::US5::US5_0(v350_0_0) => match &v350 {
                                            Documents::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    },
                                    v5.clone(),
                                );
                                let v402: &str = &*v388;
                                let v487: std::string::String = String::from(v402);
                                let v572: std::path::PathBuf = std::path::PathBuf::from(v487);
                                Ok(v572)
                            }
                            Documents::US12::US12_1(v220_1_0) => {
                                let v662: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v220_1_0.clone(),
                                        v79.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v676: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v662);
                                Err(v676)
                            }
                        }
                    } else {
                        let v767: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v79.clone(),
                                v4.clone(),
                                v5.clone()
                            ),
                        );
                        let v781: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v767);
                        Err(v781)
                    }
                } else {
                    let v871: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1,
                            v79.clone(),
                            v4,
                            v5.clone()
                        ),
                    );
                    let v885: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v871);
                    Err(v885)
                }
            }
        }
        pub fn method69(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v105: i32 =
                Documents::method66(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v107: bool = Documents::method68(Documents::method67(), v105);
            if v107 {
                let v121: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v314: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v314)
            } else {
                let v343: string = append(
                    string(
                        "file_system.read_link / Fsharp / The file or directory is not a reparse point. / ",
                    ),
                    sprintf!(
                        "path: {} / result: {} / path\': {} / n: {}",
                        v0_1.clone(),
                        v107,
                        v2.clone(),
                        v1_1
                    ),
                );
                Documents::method70(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure27(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v343),
                    v2,
                )
            }
        }
        pub fn closure28(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method69(v0_1, v1_1, v2)
        }
        pub fn closure27(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure28(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method71(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method61(v0_1.clone());
            let v5: Option<string> = Documents::method44(v0_1.clone());
            let v67: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v78: string = Documents::method56(v3);
            if (v2) >= 11_u8 {
                let v82: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v96: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v82);
                Err(v96)
            } else {
                if let Documents::US5::US5_0(v67_0_0) = &v67 {
                    if (v0_1.clone()) != string("") {
                        let v199: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v67_0_0.clone());
                        let v200 = Documents::method55();
                        let v213: Result<std::path::PathBuf, string> = v199.map_err(|x| v200(x));
                        let v216 = Documents::method57();
                        let v217 = Documents::method58();
                        let v219: Documents::US12 = match &v213 {
                            Err(v213_1_0) => v217(v213_1_0.clone()),
                            Ok(v213_0_0) => v216(v213_0_0.clone()),
                        };
                        match &v219 {
                            Documents::US12::US12_0(v219_0_0) => {
                                let v248: std::path::PathBuf =
                                    Documents::method37(v219_0_0.clone());
                                let v330: Documents::US13 = Documents::method63(v248.display());
                                let v349: Documents::US5 = match &v330 {
                                    Documents::US13::US13_0(v330_0_0) => {
                                        Documents::US5::US5_0(v330_0_0.clone())
                                    }
                                    _ => Documents::US5::US5_1,
                                };
                                let v387: string = Documents::method39(
                                    match &v349 {
                                        Documents::US5::US5_0(v349_0_0) => match &v349 {
                                            Documents::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    },
                                    v4.clone(),
                                );
                                let v401: &str = &*v387;
                                let v486: std::string::String = String::from(v401);
                                let v571: std::path::PathBuf = std::path::PathBuf::from(v486);
                                Ok(v571)
                            }
                            Documents::US12::US12_1(v219_1_0) => {
                                let v661: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v219_1_0.clone(),
                                        v78.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v675: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v661);
                                Err(v675)
                            }
                        }
                    } else {
                        let v766: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v78.clone(),
                                v0_1.clone(),
                                v4.clone()
                            ),
                        );
                        let v780: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v766);
                        Err(v780)
                    }
                } else {
                    let v870: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1.clone(),
                            v78.clone(),
                            v0_1,
                            v4.clone()
                        ),
                    );
                    let v884: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v870);
                    Err(v884)
                }
            }
        }
        pub fn method65(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v104: i32 =
                Documents::method66(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v106: bool = Documents::method68(Documents::method67(), v104);
            if v106 {
                let v120: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v313: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v313)
            } else {
                let v342: string = append(
                    string(
                        "file_system.read_link / Fsharp / The file or directory is not a reparse point. / ",
                    ),
                    sprintf!(
                        "path: {} / result: {} / path\': {} / n: {}",
                        v0_1.clone(),
                        v106,
                        v0_1.clone(),
                        v1_1
                    ),
                );
                Documents::method71(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure27(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v342),
                )
            }
        }
        pub fn method53(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
            if Documents::method42(v0_1.clone()) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                Documents::method54(v0_1, 0_u8)
            }
        }
        pub fn closure29(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US14 {
            Documents::US14::US14_0(v0_1)
        }
        pub fn method72() -> Func1<std::path::PathBuf, Documents::US14> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure29((), v))
        }
        pub fn method74(v0_1: string) -> string {
            v0_1
        }
        pub fn method75() -> string {
            string("")
        }
        pub fn method73(v0_1: string, v1_1: string, v2: string) -> string {
            let v6: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v10: regex::Regex = v6.unwrap();
            let v22: string = Documents::method74(v2);
            let v24: std::borrow::Cow<str> = v10.replace_all(&*v22, &*v1_1);
            let v26: std::string::String = String::from(v24);
            fable_library_rust::String_::fromString(v26)
        }
        pub fn method52(v0_1: string) -> string {
            if (v0_1.clone()) == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Documents::method53(v0_1.clone());
                let v7: Option<std::path::PathBuf> = v3.ok();
                let v80: Documents::US14 =
                    defaultValue(Documents::US14::US14_1, map(Documents::method72(), v7));
                let v244: string = match &v80 {
                    Documents::US14::US14_0(v80_0_0) => {
                        let v104: std::path::PathBuf = Documents::method37(
                            match &v80 {
                                Documents::US14::US14_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        );
                        let v186: Documents::US13 = Documents::method63(v104.display());
                        let v205: Documents::US5 = match &v186 {
                            Documents::US13::US13_0(v186_0_0) => {
                                Documents::US5::US5_0(v186_0_0.clone())
                            }
                            _ => Documents::US5::US5_1,
                        };
                        match &v205 {
                            Documents::US5::US5_0(v205_0_0) => match &v205 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => panic!("{}", string("Option does not have a value."),),
                        }
                    }
                    _ => v0_1.clone(),
                };
                let v249: string = Documents::method73(
                    string("^\\\\\\\\\\?\\\\"),
                    string(""),
                    if (v244.clone()) == string("") {
                        v0_1.clone()
                    } else {
                        v244
                    },
                );
                if (length(v249.clone())) < 2_i32 {
                    v0_1.clone()
                } else {
                    replace(
                        concat(new_array(&[
                            toLower(ofChar(getCharAt(v249.clone(), 0_i32))),
                            getSlice(v249, Some(1_i32), None::<i32>),
                        ])),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method38(v0_1: string) -> Documents::US5 {
            let v5: Documents::US11 = Documents::method40(
                Documents::US10::US10_1,
                Documents::method39(string("spiral"), string("workspace")),
                v0_1.clone(),
            );
            match &v5 {
                Documents::US11::US11_0(v5_0_0) => {
                    Documents::US5::US5_0(Documents::method52(v5_0_0.clone()))
                }
                Documents::US11::US11_1(v5_1_0) => {
                    let v561: () = {
                        Documents::closure18(v0_1.clone(), v5_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            }
        }
        pub fn method77(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method78() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method79(v0_1: string) -> string {
            v0_1
        }
        pub fn method76(v0_1: string) -> string {
            let v26: &str = &*v0_1.clone();
            let v111: std::string::String = String::from(v26);
            let v196: std::path::PathBuf = std::path::PathBuf::from(v111);
            if (v196.exists()) == false {
                let v271: string = Documents::method36();
                let v305: Array<string> = split(
                    Documents::method52(Documents::method39(v271.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v316: i32 = get_Count(v305.clone());
                let v317: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method77(v316, v317.clone()) {
                    let v319: i32 = v317.l0.get().clone();
                    let v322: i32 = ((v319.wrapping_neg()) + (v316)) - 1_i32;
                    let matchValue: i32 = v317.l1.get().clone();
                    let v324: Array<string> = v317.l2.get().clone();
                    let v323: i32 = matchValue;
                    let v325: string = v305[v322].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == (v325.clone()) {
                        ((v323) + 1_i32, v324.clone())
                    } else {
                        if string(".") == (v325.clone()) {
                            (v323, v324.clone())
                        } else {
                            if 0_i32 == (v323) {
                                if endsWith3(v325.clone(), string(":"), false) {
                                    let v344: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v271.clone(), 0_i32)
                                    )]);
                                    let v345: i32 = get_Count(v344.clone());
                                    let v347: i32 = (v345) + (get_Count(v324.clone()));
                                    let v348: Array<string> = new_init(&string(""), v347);
                                    let v349: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method27(v347, v349.clone()) {
                                        let v351: i32 = v349.l0.get().clone();
                                        let v356: string = if (v351) < (v345) {
                                            v344[v351].clone()
                                        } else {
                                            let v354: i32 = (v351) - (v345);
                                            v324[v354].clone()
                                        };
                                        v348.get_mut()[v351 as usize] = v356;
                                        {
                                            let v357: i32 = (v351) + 1_i32;
                                            v349.l0.set(v357);
                                            ()
                                        }
                                    }
                                    (0_i32, v348.clone())
                                } else {
                                    let v358: Array<string> = new_array(&[v325]);
                                    let v359: i32 = get_Count(v358.clone());
                                    let v361: i32 = (v359) + (get_Count(v324.clone()));
                                    let v362: Array<string> = new_init(&string(""), v361);
                                    let v363: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method27(v361, v363.clone()) {
                                        let v365: i32 = v363.l0.get().clone();
                                        let v370: string = if (v365) < (v359) {
                                            v358[v365].clone()
                                        } else {
                                            let v368: i32 = (v365) - (v359);
                                            v324[v368].clone()
                                        };
                                        v362.get_mut()[v365 as usize] = v370;
                                        {
                                            let v371: i32 = (v365) + 1_i32;
                                            v363.l0.set(v371);
                                            ()
                                        }
                                    }
                                    (0_i32, v362.clone())
                                }
                            } else {
                                ((v323) - 1_i32, v324.clone())
                            }
                        }
                    };
                    let v381: i32 = (v319) + 1_i32;
                    v317.l0.set(v381);
                    v317.l1.set(patternInput_1.0.clone());
                    v317.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v317.l1.get().clone();
                    let v383: Array<string> = v317.l2.get().clone();
                    let _let__v388: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v383 = v383.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v383 = v383.clone();
                                    move |i: i32| v383[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, (get_Count(v383.clone())) - 1_i32),
                            )
                        }
                    }));
                    let v482: string = ofChar(Documents::method78());
                    join(
                        if (v482.clone()) == string("\n") {
                            Documents::method79(v482.clone())
                        } else {
                            v482
                        },
                        toArray(_let__v388),
                    )
                }
            } else {
                let v509: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v537: std::path::PathBuf = Documents::method37(v509.unwrap());
                let v539: std::path::Display = v537.display();
                let v626: std::string::String = format!("{}", v539);
                fable_library_rust::String_::fromString(v626)
            }
        }
        pub fn method80() -> string {
            let v3: &str = inline_colorization::color_bright_blue;
            let v17: std::string::String = String::from(v3);
            let v293: string = append(
                (fable_library_rust::String_::fromString(v17)),
                (Documents::method13(getCharAt(toLower(string("Debug")), 0_i32))),
            );
            let v306: &str = inline_colorization::color_reset;
            let v320: std::string::String = String::from(v306);
            append((v293), (fable_library_rust::String_::fromString(v320)))
        }
        pub fn method83(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("source_dir"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method84(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("dist_dir"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method85(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("cache_dir"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method86(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("hangul_spec"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method87(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("filter"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method88(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("transcribe_only"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method82(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: Documents::US5,
            v5: bool,
        ) -> string {
            let v15: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v15.clone());
            Documents::method83(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), v0_1);
            Documents::method50(v15.clone());
            Documents::method84(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), v1_1);
            Documents::method50(v15.clone());
            Documents::method85(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), v2);
            Documents::method50(v15.clone());
            Documents::method86(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), v3);
            Documents::method50(v15.clone());
            Documents::method87(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), sprintf!("{:?}", v4));
            Documents::method50(v15.clone());
            Documents::method88(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(
                v15.clone(),
                if v5 { string("true") } else { string("false") },
            );
            Documents::method21(v15.clone());
            v15.l0.get().clone()
        }
        pub fn method81(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: string,
            v12: Documents::US5,
            v13: bool,
        ) -> string {
            let v14: string = Documents::method82(v8, v9, v10, v11, v12, v13);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run"),
                    )),
                    string(" / "),
                )),
                (v14),
            ))
        }
        pub fn closure30(
            v0_1: bool,
            v1_1: Documents::US5,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
            unitVar: (),
        ) {
            fn v36() {
                Documents::closure10((), ());
            }
            let v37: () = {
                v36();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v115: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v518: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v115,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v153: () = {
                    v36();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v196: Option<i64> = patternInput_1.5.clone();
                let v195: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v194: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v193: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v192: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v191: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v233: string = Documents::method81(
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    v194.clone(),
                    v195.clone(),
                    v196.clone(),
                    Documents::method8(v191, v192, v193, v194, v195, v196),
                    Documents::method80(),
                    v3,
                    v4,
                    v5,
                    v2,
                    v1_1,
                    v0_1,
                );
                let v264: () = {
                    v36();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v303: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v302: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v346: () = {
                    Documents::closure12(v302.clone(), ());
                    ()
                };
                println!("{}", v233.clone());
                (v303.l0.get().clone())(v233);
                Documents::US7::US7_0(
                    v302,
                    v303,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure32(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method89() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure32((), v))
        }
        pub fn closure33(unitVar: (), v0_1: std::fs::FileType) -> Documents::US15 {
            Documents::US15::US15_0(v0_1)
        }
        pub fn method90() -> Func1<std::fs::FileType, Documents::US15> {
            Func1::new(move |v: std::fs::FileType| Documents::closure33((), v))
        }
        pub fn closure34(unitVar: (), v0_1: std::string::String) -> Documents::US15 {
            Documents::US15::US15_1(v0_1)
        }
        pub fn method91() -> Func1<std::string::String, Documents::US15> {
            Func1::new(move |v: std::string::String| Documents::closure34((), v))
        }
        pub fn closure31(
            v0_1: Documents::US5,
            v1_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let v3: bool = true;
            let __future_init = Box::pin(
                /*;
                let v5: bool = */
                async {
                    /*;
                    let v7: bool = */
                    ();
                    let v9: bool = true;
                    let __future_init = Box::pin(
                        /*;
                        let v11: bool = */
                        async move {
                            /*;
                            let v13: bool = */
                            ();
                            let v15: async_walkdir::DirEntry = v1_1.clone();
                            let v17: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                            Output = Result<std::fs::FileType, std::io::Error>,
                                        > + Send,
                                >,
                            > = Box::pin(async_walkdir::DirEntry::file_type(&v15));
                            let v19: Result<std::fs::FileType, std::io::Error> = v17.await;
                            let v20 = Documents::method89();
                            let v33: Result<std::fs::FileType, std::string::String> =
                                v19.map_err(|x| v20(x));
                            let v36 = Documents::method90();
                            let v37 = Documents::method91();
                            let v39: Documents::US15 = match &v33 {
                                Err(v33_1_0) => v37(v33_1_0.clone()),
                                Ok(v33_0_0) => v36(v33_0_0.clone()),
                            };
                            let v508: Documents::US16 = if let Documents::US15::US15_0(v39_0_0) =
                                &v39
                            {
                                if std::fs::FileType::is_dir(&v39_0_0.clone()) {
                                    Documents::US16::US16_0
                                } else {
                                    let v73: std::path::PathBuf = Documents::method37(
                                        async_walkdir::DirEntry::path(&v1_1.clone()),
                                    );
                                    let v75: std::path::Display = v73.display();
                                    let v162: std::string::String = format!("{}", v75);
                                    let v235: string =
                                        fable_library_rust::String_::fromString(v162);
                                    if if if (endsWith3(v235.clone(), string(".md"), false))
                                        == false
                                    {
                                        true
                                    } else {
                                        match &v0_1 {
                                            Documents::US5::US5_0(v0_1_0_0) => {
                                                (contains(
                                                    v235.clone(),
                                                    match &v0_1 {
                                                        Documents::US5::US5_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )) == false
                                            }
                                            _ => false,
                                        }
                                    } {
                                        true
                                    } else {
                                        endsWith3(v235.clone(), string(".hangul.md"), false)
                                    } {
                                        Documents::US16::US16_0
                                    } else {
                                        Documents::US16::US16_2
                                    }
                                }
                            } else {
                                let v298: std::path::PathBuf =
                                    Documents::method37(async_walkdir::DirEntry::path(&v1_1));
                                let v300: std::path::Display = v298.display();
                                let v387: std::string::String = format!("{}", v300);
                                let v460: string = fable_library_rust::String_::fromString(v387);
                                if if if (endsWith3(v460.clone(), string(".md"), false)) == false {
                                    true
                                } else {
                                    match &v0_1 {
                                        Documents::US5::US5_0(v0_1_0_0) => {
                                            (contains(
                                                v460.clone(),
                                                match &v0_1 {
                                                    Documents::US5::US5_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                            )) == false
                                        }
                                        _ => false,
                                    }
                                } {
                                    true
                                } else {
                                    endsWith3(v460.clone(), string(".hangul.md"), false)
                                } {
                                    Documents::US16::US16_0
                                } else {
                                    Documents::US16::US16_2
                                }
                            };
                            let v511: string = string("}");
                            let v516: bool = true;
                            let _fix_closure_v513 = v508;
                            let v522: string = append(
                                (append(
                                    (append(
                                        (append(string("true; _fix_closure_v513 "), (v511))),
                                        string("); "),
                                    )),
                                    string(""),
                                )),
                                string(" // rust.fix_closure\'"),
                            );
                            let v523: bool = true;
                            _fix_closure_v513
                        },
                    ); // rust.fix_closure';
                    let v525 = __future_init;
                    let v527: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US16> + Send>,
                    > = v525;
                    let v529: Documents::US16 = v527.await;
                    let v538: async_walkdir::Filtering = match &v529 {
                        Documents::US16::US16_0 => async_walkdir::Filtering::Ignore,
                        Documents::US16::US16_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    };
                    let v539: string = string("}");
                    let v544: bool = true;
                    let _fix_closure_v541 = v538;
                    let v550: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v541 "), (v539))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v551: bool = true;
                    _fix_closure_v541
                },
            ); // rust.fix_closure';
            let v553 = __future_init;
            v553
        }
        pub fn closure36(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method93() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure36((), v))
        }
        pub fn closure37(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US17 {
            Documents::US17::US17_0(v0_1)
        }
        pub fn method94() -> Func1<async_walkdir::DirEntry, Documents::US17> {
            Func1::new(move |v: async_walkdir::DirEntry| Documents::closure37((), v))
        }
        pub fn closure38(unitVar: (), v0_1: std::string::String) -> Documents::US17 {
            Documents::US17::US17_1(v0_1)
        }
        pub fn method95() -> Func1<std::string::String, Documents::US17> {
            Func1::new(move |v: std::string::String| Documents::closure38((), v))
        }
        pub fn method96() -> string {
            let v3: &str = inline_colorization::color_bright_red;
            let v17: std::string::String = String::from(v3);
            let v293: string = append(
                (fable_library_rust::String_::fromString(v17)),
                (Documents::method13(getCharAt(toLower(string("Critical")), 0_i32))),
            );
            let v306: &str = inline_colorization::color_reset;
            let v320: std::string::String = String::from(v306);
            append((v293), (fable_library_rust::String_::fromString(v320)))
        }
        pub fn method98(v0_1: std::string::String) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v10.clone());
            Documents::method51(v10.clone());
            Documents::method20(v10.clone());
            {
                let v156: std::string::String = format!("{:#?}", v0_1);
                Documents::method15(v10.clone(), fable_library_rust::String_::fromString(v156));
                Documents::method21(v10.clone());
                v10.l0.get().clone()
            }
        }
        pub fn method97(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Documents::method98(v8);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run / stream_filter_map"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure39(v0_1: std::string::String, unitVar: ()) {
            fn v31() {
                Documents::closure10((), ());
            }
            let v32: () = {
                v31();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v110: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v513: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v110,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v148: () = {
                    v31();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v191: Option<i64> = patternInput_1.5.clone();
                let v190: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v189: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v188: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v187: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v186: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v228: string = Documents::method97(
                    v186.clone(),
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    Documents::method8(v186, v187, v188, v189, v190, v191),
                    Documents::method96(),
                    v0_1,
                );
                let v259: () = {
                    v31();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v298: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v297: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v341: () = {
                    Documents::closure12(v297.clone(), ());
                    ()
                };
                println!("{}", v228.clone());
                (v298.l0.get().clone())(v228);
                Documents::US7::US7_0(
                    v297,
                    v298,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure35(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method93();
            let v14: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v17 = Documents::method94();
            let v18 = Documents::method95();
            let v20: Documents::US17 = match &v14 {
                Err(v14_1_0) => v18(v14_1_0.clone()),
                Ok(v14_0_0) => v17(v14_0_0.clone()),
            };
            let v1326: Documents::US5 = match &v20 {
                Documents::US17::US17_0(v20_0_0) => {
                    let v51: std::path::PathBuf =
                        Documents::method37(async_walkdir::DirEntry::path(&v20_0_0.clone()));
                    let v53: std::path::Display = v51.display();
                    let v140: std::string::String = format!("{}", v53);
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(v140))
                }
                Documents::US17::US17_1(v20_1_0) => {
                    let v767: () = {
                        Documents::closure39(v20_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            match &v1326 {
                Documents::US5::US5_0(v1326_0_0) => Some(
                    match &v1326 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<string>,
            }
        }
        pub fn method92()
        -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure35((), v)
                },
            )
        }
        pub fn method101(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("files_len"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method100(v0_1: usize) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v10.clone());
            Documents::method101(v10.clone());
            Documents::method20(v10.clone());
            {
                let v156: std::string::String = format!("{:#?}", v0_1);
                Documents::method15(v10.clone(), fable_library_rust::String_::fromString(v156));
                Documents::method21(v10.clone());
                v10.l0.get().clone()
            }
        }
        pub fn method99(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: usize,
        ) -> string {
            let v9: string = Documents::method100(v8);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure40(v0_1: Vec<string>, unitVar: ()) {
            fn v31() {
                Documents::closure10((), ());
            }
            let v32: () = {
                v31();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v110: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v515: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v110,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v148: () = {
                    v31();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v191: Option<i64> = patternInput_1.5.clone();
                let v190: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v189: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v188: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v187: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v186: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v230: string = Documents::method99(
                    v186.clone(),
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    Documents::method8(v186, v187, v188, v189, v190, v191),
                    Documents::method80(),
                    v0_1.len(),
                );
                let v261: () = {
                    v31();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v300: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v299: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v343: () = {
                    Documents::closure12(v299.clone(), ());
                    ()
                };
                println!("{}", v230.clone());
                (v300.l0.get().clone())(v230);
                Documents::US7::US7_0(
                    v299,
                    v300,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method102() -> string {
            string("")
        }
        pub fn method103(v0_1: string) -> string {
            Documents::method52(Documents::method76(v0_1))
        }
        pub fn method105(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
        ) -> string {
            v0_1
        }
        pub fn method108(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("c"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method109(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("st"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method110(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("line_start"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method111(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("position"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method112(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("line"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method113(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("col"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method114(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("input_len"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method107(v0_1: char, v1_1: i32, v2: i32, v3: i32, v4: i32) -> string {
            let v14: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v14.clone());
            Documents::method108(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v0_1));
            Documents::method50(v14.clone());
            Documents::method109(v14.clone());
            Documents::method20(v14.clone());
            Documents::method18(v14.clone());
            Documents::method110(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v1_1));
            Documents::method50(v14.clone());
            Documents::method111(v14.clone());
            Documents::method20(v14.clone());
            Documents::method18(v14.clone());
            Documents::method112(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v2));
            Documents::method50(v14.clone());
            Documents::method113(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v3));
            Documents::method21(v14.clone());
            Documents::method50(v14.clone());
            Documents::method114(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v4));
            Documents::method21(v14.clone());
            Documents::method21(v14.clone());
            v14.l0.get().clone()
        }
        pub fn closure43(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.p_char / unexpected end of input / "),
                (Documents::method107('\"', v0_1, v1_1, v2, v3)),
            )
        }
        pub fn closure44(v0_1: char, unitVar: ()) -> char {
            v0_1
        }
        pub fn method115(v0_1: string, v1_1: i32, v2: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2: MutCell<i32> = MutCell::new(v2);
            '_method115: loop {
                break '_method115 (if (v2.get().clone()) >= (v1_1.get().clone()) {
                    v2.get().clone()
                } else {
                    if ('\n' == (getCharAt(v0_1.get().clone(), v2.get().clone()))) != true {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone();
                        let v2_temp: i32 = (v2.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2.set(v2_temp);
                        continue '_method115;
                    } else {
                        v2.get().clone()
                    }
                });
            }
        }
        pub fn closure46(v0_1: i32, v1_1: i32, v2: string) -> string {
            if (v1_1) >= (v0_1) {
                v2.clone()
            } else {
                (Documents::method116(v0_1, (v1_1) + 1_i32))(append((v2), string(" ")))
            }
        }
        pub fn method116(v0_1: i32, v1_1: i32) -> Func1<string, string> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure46(v0_1, v1_1, v)
            })
        }
        pub fn method118(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("expected"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method117(v0_1: char, v1_1: i32, v2: i32) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method118(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), sprintf!("{}", v0_1));
            Documents::method50(v12.clone());
            Documents::method112(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), sprintf!("{}", v1_1));
            Documents::method50(v12.clone());
            Documents::method113(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), sprintf!("{}", v2));
            Documents::method21(v12.clone());
            v12.l0.get().clone()
        }
        pub fn closure45(
            v0_1: i32,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: string,
            unitVar: (),
        ) -> string {
            let v6: i32 = Documents::method115(v4.clone(), length(v4.clone()), v3);
            let v7: i32 = (v3) + 80_i32;
            let v9: i32 = if (v6) < (v7) { v6 } else { v7 };
            let v10: bool = (v2) == (v9);
            let v1011: string = getSlice(v4, Some(v2), Some((v9) - 1_i32));
            let v1022: i32 = length(v1011.clone());
            let v1030: string = if if (v1022) > 0_i32 {
                (getCharAt(v1011.clone(), (v1022) - 1_i32)) == '\n'
            } else {
                false
            } {
                string("")
            } else {
                string("\n")
            };
            let v1039: string = append(
                ((Documents::method116((v0_1) - 1_i32, 0_i32))(string(""))),
                string("^"),
            );
            append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    string("parsing.p_char / "),
                                    (Documents::method117('\"', v1_1, v0_1)),
                                )),
                                string("\n"),
                            )),
                            (v1011),
                        )),
                        (v1030),
                    )),
                    (v1039),
                )),
                string("\n"),
            )
        }
        pub fn closure42(unitVar: (), _arg: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
            let v5: i32 = _arg.5.clone();
            let v4: i32 = _arg.4.clone();
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: i32 = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if (v1_1) >= (v5) {
                Documents::US19::US19_1(Func0::new({
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    move || Documents::closure43(v2, v3, v4, v5, ())
                }))
            } else {
                let v9: char = getCharAt(v0_1.clone(), v1_1);
                if (v9) == '\"' {
                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v9) {
                        ((v2) + (v4), (v3) + 1_i32, 1_i32, v5)
                    } else {
                        (v2, v3, (v4) + 1_i32, v5)
                    };
                    Documents::US19::US19_0(
                        Func0::new({
                            let v9 = v9.clone();
                            move || Documents::closure44(v9, ())
                        }),
                        (v1_1) + 1_i32,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                        patternInput.3.clone(),
                    )
                } else {
                    Documents::US19::US19_1(Func0::new({
                        let v0_1 = v0_1.clone();
                        let v1_1 = v1_1.clone();
                        let v2 = v2.clone();
                        let v3 = v3.clone();
                        let v4 = v4.clone();
                        move || Documents::closure45(v4, v3, v2, v1_1, v0_1.clone(), ())
                    }))
                }
            }
        }
        pub fn closure48(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.p_char / unexpected end of input / "),
                (Documents::method107('\'', v0_1, v1_1, v2, v3)),
            )
        }
        pub fn closure49(
            v0_1: i32,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: string,
            unitVar: (),
        ) -> string {
            let v6: i32 = Documents::method115(v4.clone(), length(v4.clone()), v3);
            let v7: i32 = (v3) + 80_i32;
            let v9: i32 = if (v6) < (v7) { v6 } else { v7 };
            let v10: bool = (v2) == (v9);
            let v1011: string = getSlice(v4, Some(v2), Some((v9) - 1_i32));
            let v1022: i32 = length(v1011.clone());
            let v1030: string = if if (v1022) > 0_i32 {
                (getCharAt(v1011.clone(), (v1022) - 1_i32)) == '\n'
            } else {
                false
            } {
                string("")
            } else {
                string("\n")
            };
            let v1039: string = append(
                ((Documents::method116((v0_1) - 1_i32, 0_i32))(string(""))),
                string("^"),
            );
            append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    string("parsing.p_char / "),
                                    (Documents::method117('\'', v1_1, v0_1)),
                                )),
                                string("\n"),
                            )),
                            (v1011),
                        )),
                        (v1030),
                    )),
                    (v1039),
                )),
                string("\n"),
            )
        }
        pub fn closure47(unitVar: (), _arg: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
            let v5: i32 = _arg.5.clone();
            let v4: i32 = _arg.4.clone();
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: i32 = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if (v1_1) >= (v5) {
                Documents::US19::US19_1(Func0::new({
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    move || Documents::closure48(v2, v3, v4, v5, ())
                }))
            } else {
                let v9: char = getCharAt(v0_1.clone(), v1_1);
                if (v9) == '\'' {
                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v9) {
                        ((v2) + (v4), (v3) + 1_i32, 1_i32, v5)
                    } else {
                        (v2, v3, (v4) + 1_i32, v5)
                    };
                    Documents::US19::US19_0(
                        Func0::new({
                            let v9 = v9.clone();
                            move || Documents::closure44(v9, ())
                        }),
                        (v1_1) + 1_i32,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                        patternInput.3.clone(),
                    )
                } else {
                    Documents::US19::US19_1(Func0::new({
                        let v0_1 = v0_1.clone();
                        let v1_1 = v1_1.clone();
                        let v2 = v2.clone();
                        let v3 = v3.clone();
                        let v4 = v4.clone();
                        move || Documents::closure49(v4, v3, v2, v1_1, v0_1.clone(), ())
                    }))
                }
            }
        }
        pub fn closure50(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.choice / no parsers succeeded")
        }
        pub fn method119(v0_1: i32, v1_1: string, v2: LrcPtr<Documents::UH0>) -> Documents::US19 {
            let v0_1: MutCell<i32> = MutCell::new(v0_1);
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v2.clone());
            '_method119: loop {
                break '_method119 (match v2.get().clone().as_ref() {
                    Documents::UH0::UH0_0 => {
                        Documents::US19::US19_1(Func0::new(move || Documents::closure50((), ())))
                    }
                    Documents::UH0::UH0_1(v2_1_0, v2_1_1) => {
                        let v7: Documents::US19 = (match v2.get().clone().as_ref() {
                            Documents::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v1_1.get().clone(),
                            0_i32,
                            0_i32,
                            1_i32,
                            1_i32,
                            v0_1.get().clone(),
                        ));
                        match &v7 {
                            Documents::US19::US19_0(
                                v7_0_0,
                                v7_0_1,
                                v7_0_2,
                                v7_0_3,
                                v7_0_4,
                                v7_0_5,
                            ) => v7.clone(),
                            _ => {
                                let v0_1_temp: i32 = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH0> =
                                    match v2.get().clone().as_ref() {
                                        Documents::UH0::UH0_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method119;
                            }
                        }
                    }
                });
            }
        }
        pub fn method120(v0_1: Array<char>) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method15(v10.clone(), sprintf!("{:?}", v0_1));
            v10.l0.get().clone()
        }
        pub fn method122(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("chars\'"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method123(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("s"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method121(v0_1: string, v1_1: i32, v2: i32, v3: i32, v4: i32) -> string {
            let v14: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v14.clone());
            Documents::method122(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), v0_1);
            Documents::method50(v14.clone());
            Documents::method123(v14.clone());
            Documents::method20(v14.clone());
            {
                let v335: std::string::String = format!("{:#?}", v1_1);
                Documents::method15(v14.clone(), fable_library_rust::String_::fromString(v335));
                Documents::method21(v14.clone());
                v14.l0.get().clone()
            }
        }
        pub fn closure51(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected end of input / "),
                (Documents::method121(
                    Documents::method120(toArray_1(ofArray(new_array(&['\"', '\''])))),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                )),
            )
        }
        pub fn method124(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method124: loop {
                break '_method124 (if (v1_1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Documents::US8 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US8::US8_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US8::US8_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Documents::US8::US8_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Documents::US8::US8_0(v11_0_0) => match &v11 {
                                Documents::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method124;
                    }
                });
            }
        }
        pub fn closure52(v0_1: char, unitVar: ()) -> char {
            v0_1
        }
        pub fn method126(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("first_char"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method125(v0_1: char, v1_1: string, v2: i32, v3: i32, v4: i32, v5: i32) -> string {
            let v15: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v15.clone());
            Documents::method126(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), sprintf!("{}", v0_1));
            Documents::method50(v15.clone());
            Documents::method122(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), v1_1);
            Documents::method50(v15.clone());
            Documents::method123(v15.clone());
            Documents::method20(v15.clone());
            {
                let v524: std::string::String = format!("{:#?}", v2);
                Documents::method15(v15.clone(), fable_library_rust::String_::fromString(v524));
                Documents::method21(v15.clone());
                v15.l0.get().clone()
            }
        }
        pub fn closure53(v0_1: i32, v1_1: i32, v2: i32, v3: i32, v4: char, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected char / "),
                (Documents::method125(
                    v4,
                    Documents::method120(toArray_1(ofArray(new_array(&['\"', '\''])))),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                )),
            )
        }
        pub fn closure54(v0_1: i32, v1_1: string, v2: i32, unitVar: ()) -> string {
            let v3: bool = (v0_1) == (v2);
            getSlice(v1_1, Some(v0_1), Some((v2) - 1_i32))
        }
        pub fn closure55(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.many1_chars / inner parser succeeded without consuming input")
        }
        pub fn method127(
            v0_1: i32,
            v1_1: string,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: i32,
            v6: i32,
        ) -> Documents::US20 {
            let v0_1: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v0_1));
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v3));
            let v4: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v4));
            let v5: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v5));
            let v6: MutCell<i32> = MutCell::new(v6);
            '_method127: loop {
                break '_method127 ({
                    let v28: Documents::US19 = if (v2.get().clone()) >= (v6.get().clone()) {
                        Documents::US19::US19_1(Func0::new({
                            let v3 = v3.clone();
                            let v4 = v4.clone();
                            let v5 = v5.clone();
                            let v6 = v6.clone();
                            move || {
                                Documents::closure51(
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    v5.get().clone(),
                                    v6.get().clone(),
                                    (),
                                )
                            }
                        }))
                    } else {
                        let v10: char = getCharAt(v1_1.get().clone(), v2.get().clone());
                        if (Documents::method124(v10, 0_i64)) == false {
                            let patternInput: (i32, i32, i32, i32) = if '\n' == (v10) {
                                (
                                    (v3.get().clone()) + (v5.get().clone()),
                                    (v4.get().clone()) + 1_i32,
                                    1_i32,
                                    v6.get().clone(),
                                )
                            } else {
                                (
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    (v5.get().clone()) + 1_i32,
                                    v6.get().clone(),
                                )
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v10 = v10.clone();
                                    move || Documents::closure52(v10, ())
                                }),
                                (v2.get().clone()) + 1_i32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                                patternInput.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v10 = v10.clone();
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                let v6 = v6.clone();
                                move || {
                                    Documents::closure53(
                                        v3.get().clone(),
                                        v4.get().clone(),
                                        v5.get().clone(),
                                        v6.get().clone(),
                                        v10,
                                        (),
                                    )
                                }
                            }))
                        }
                    };
                    match &v28 {
                        Documents::US19::US19_0(
                            v28_0_0,
                            v28_0_1,
                            v28_0_2,
                            v28_0_3,
                            v28_0_4,
                            v28_0_5,
                        ) => {
                            let v30: i32 = v28_0_1.clone();
                            if (v30) == (v2.get().clone()) {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure55((), ())
                                }))
                            } else {
                                let v0_1_temp: i32 = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: i32 = v30;
                                let v3_temp: i32 = v28_0_2.clone();
                                let v4_temp: i32 = v28_0_3.clone();
                                let v5_temp: i32 = v28_0_4.clone();
                                let v6_temp: i32 = v28_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                continue '_method127;
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v1_1 = v1_1.clone();
                                let v2 = v2.clone();
                                move || {
                                    Documents::closure54(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v2.get().clone(),
                                        (),
                                    )
                                }
                            }),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure56(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn method128(
            v0_1: i32,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: string,
            v6: LrcPtr<Documents::UH0>,
        ) -> Documents::US19 {
            let v0_1: MutCell<i32> = MutCell::new(v0_1);
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: MutCell<string> = MutCell::new(v5.clone());
            let v6: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v6.clone());
            '_method128: loop {
                break '_method128 (match v6.get().clone().as_ref() {
                    Documents::UH0::UH0_0 => {
                        Documents::US19::US19_1(Func0::new(move || Documents::closure50((), ())))
                    }
                    Documents::UH0::UH0_1(v6_1_0, v6_1_1) => {
                        let v11: Documents::US19 = (match v6.get().clone().as_ref() {
                            Documents::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v5.get().clone(),
                            v4.get().clone(),
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v11 {
                            Documents::US19::US19_0(
                                v11_0_0,
                                v11_0_1,
                                v11_0_2,
                                v11_0_3,
                                v11_0_4,
                                v11_0_5,
                            ) => v11.clone(),
                            _ => {
                                let v0_1_temp: i32 = v0_1.get().clone();
                                let v1_1_temp: i32 = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: i32 = v4.get().clone();
                                let v5_temp: string = v5.get().clone();
                                let v6_temp: LrcPtr<Documents::UH0> =
                                    match v6.get().clone().as_ref() {
                                        Documents::UH0::UH0_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                continue '_method128;
                            }
                        }
                    }
                });
            }
        }
        pub fn method130(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("rest\'"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method129(v0_1: string) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v10.clone());
            Documents::method130(v10.clone());
            Documents::method20(v10.clone());
            Documents::method15(v10.clone(), v0_1);
            Documents::method21(v10.clone());
            v10.l0.get().clone()
        }
        pub fn closure57(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            let v2: i32 = length(v0_1.clone());
            let v3: i32 = (v1_1) + 80_i32;
            let v5: i32 = if (v2) < (v3) { v2 } else { v3 };
            let v6: bool = (v1_1) == (v5);
            append(
                string("parsing.between / expected content or closing delimiter / "),
                (Documents::method129(getSlice(v0_1, Some(v1_1), Some((v5) - 1_i32)))),
            )
        }
        pub fn closure58(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn method132(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("e"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method133(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("input"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method134(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("rest\'\'"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method131(v0_1: Func0<string>, v1_1: string, v2: string, v3: string) -> string {
            let v13: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v13.clone());
            Documents::method132(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(v13.clone(), v0_1());
            Documents::method50(v13.clone());
            Documents::method133(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(v13.clone(), v1_1);
            Documents::method50(v13.clone());
            Documents::method130(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(v13.clone(), v2);
            Documents::method50(v13.clone());
            Documents::method134(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(v13.clone(), v3);
            Documents::method21(v13.clone());
            v13.l0.get().clone()
        }
        pub fn closure59(
            v0_1: string,
            v1_1: i32,
            v2: i32,
            v3: Func0<string>,
            unitVar: (),
        ) -> string {
            let v4: i32 = length(v0_1.clone());
            let v5: i32 = (v1_1) + 80_i32;
            let v7: i32 = if (v4) < (v5) { v4 } else { v5 };
            let v8: i32 = (v2) + 80_i32;
            let v10: i32 = if (v4) < (v8) { v4 } else { v8 };
            let v11: bool = (v1_1) == (v7);
            let v1023: bool = (v2) == (v10);
            append(
                string("parsing.between / expected closing delimiter / "),
                (Documents::method131(
                    v3,
                    v0_1.clone(),
                    getSlice(v0_1.clone(), Some(v1_1), Some((v7) - 1_i32)),
                    getSlice(v0_1, Some(v2), Some((v10) - 1_i32)),
                )),
            )
        }
        pub fn closure60(v0_1: Func0<string>, unitVar: ()) -> string {
            replace(v0_1(), string("\\"), string("/"))
        }
        pub fn closure61(v0_1: i32, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected end of input / "),
                (Documents::method121(
                    Documents::method120(toArray_1(ofArray(new_array(&['\"', '\'', ' '])))),
                    0_i32,
                    1_i32,
                    1_i32,
                    v0_1,
                )),
            )
        }
        pub fn method135(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method135: loop {
                break '_method135 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US8 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US8::US8_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US8::US8_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US8::US8_0(' ')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US8::US8_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US8::US8_0(v15_0_0) => match &v15 {
                                Documents::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method135;
                    }
                });
            }
        }
        pub fn closure62(v0_1: i32, v1_1: char, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected char / "),
                (Documents::method125(
                    v1_1,
                    Documents::method120(toArray_1(ofArray(new_array(&['\"', '\'', ' '])))),
                    0_i32,
                    1_i32,
                    1_i32,
                    v0_1,
                )),
            )
        }
        pub fn closure63(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected end of input / "),
                (Documents::method121(
                    Documents::method120(toArray_1(ofArray(new_array(&['\"', '\'', ' '])))),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                )),
            )
        }
        pub fn closure64(v0_1: i32, v1_1: i32, v2: i32, v3: i32, v4: char, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected char / "),
                (Documents::method125(
                    v4,
                    Documents::method120(toArray_1(ofArray(new_array(&['\"', '\'', ' '])))),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                )),
            )
        }
        pub fn closure65(v0_1: string, v1_1: i32, unitVar: ()) -> string {
            let v2: bool = 0_i32 == (v1_1);
            getSlice(v0_1, Some(0_i32), Some((v1_1) - 1_i32))
        }
        pub fn method136(
            v0_1: string,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: i32,
        ) -> Documents::US20 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v2));
            let v3: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v3));
            let v4: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v4));
            let v5: MutCell<i32> = MutCell::new(v5);
            '_method136: loop {
                break '_method136 ({
                    let v27: Documents::US19 = if (v1_1.get().clone()) >= (v5.get().clone()) {
                        Documents::US19::US19_1(Func0::new({
                            let v2 = v2.clone();
                            let v3 = v3.clone();
                            let v4 = v4.clone();
                            let v5 = v5.clone();
                            move || {
                                Documents::closure63(
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    v5.get().clone(),
                                    (),
                                )
                            }
                        }))
                    } else {
                        let v9: char = getCharAt(v0_1.get().clone(), v1_1.get().clone());
                        if (Documents::method135(v9, 0_i64)) == false {
                            let patternInput: (i32, i32, i32, i32) = if '\n' == (v9) {
                                (
                                    (v2.get().clone()) + (v4.get().clone()),
                                    (v3.get().clone()) + 1_i32,
                                    1_i32,
                                    v5.get().clone(),
                                )
                            } else {
                                (
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    (v4.get().clone()) + 1_i32,
                                    v5.get().clone(),
                                )
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v9 = v9.clone();
                                    move || Documents::closure52(v9, ())
                                }),
                                (v1_1.get().clone()) + 1_i32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                                patternInput.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v2 = v2.clone();
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                let v9 = v9.clone();
                                move || {
                                    Documents::closure64(
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                        v5.get().clone(),
                                        v9,
                                        (),
                                    )
                                }
                            }))
                        }
                    };
                    match &v27 {
                        Documents::US19::US19_0(
                            v27_0_0,
                            v27_0_1,
                            v27_0_2,
                            v27_0_3,
                            v27_0_4,
                            v27_0_5,
                        ) => {
                            let v29: i32 = v27_0_1.clone();
                            if (v29) == (v1_1.get().clone()) {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure55((), ())
                                }))
                            } else {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: i32 = v29;
                                let v2_temp: i32 = v27_0_2.clone();
                                let v3_temp: i32 = v27_0_3.clone();
                                let v4_temp: i32 = v27_0_4.clone();
                                let v5_temp: i32 = v27_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                continue '_method136;
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v1_1 = v1_1.clone();
                                move || {
                                    Documents::closure65(v0_1.get().clone(), v1_1.get().clone(), ())
                                }
                            }),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure66(unitVar: (), unitVar_1: ()) {
            ();
        }
        pub fn method138(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("rest"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method137(v0_1: string) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v10.clone());
            Documents::method138(v10.clone());
            Documents::method20(v10.clone());
            Documents::method15(v10.clone(), v0_1);
            Documents::method21(v10.clone());
            v10.l0.get().clone()
        }
        pub fn closure67(v0_1: i32, v1_1: string, unitVar: ()) -> string {
            let v2: bool = 0_i32 == (v0_1);
            append(
                string("parsing.eof / expected end of input / "),
                (Documents::method137(getSlice(v1_1, Some(0_i32), Some((v0_1) - 1_i32)))),
            )
        }
        pub fn closure68(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn method139(
            v0_1: string,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: i32,
        ) -> (i32, i32, i32, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: MutCell<i32> = MutCell::new(v5);
            '_method139: loop {
                break '_method139 (if (v1_1.get().clone()) >= (v5.get().clone()) {
                    (
                        v1_1.get().clone(),
                        v2.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                        v5.get().clone(),
                    )
                } else {
                    let v7: char = getCharAt(v0_1.get().clone(), v1_1.get().clone());
                    if if if (v7) == ' ' { true } else { (v7) == '\t' } {
                        true
                    } else {
                        (v7) == '\r'
                    } {
                        let patternInput: (i32, i32, i32, i32) = if '\n' == (v7) {
                            (
                                (v2.get().clone()) + (v4.get().clone()),
                                (v3.get().clone()) + 1_i32,
                                1_i32,
                                v5.get().clone(),
                            )
                        } else {
                            (
                                v2.get().clone(),
                                v3.get().clone(),
                                (v4.get().clone()) + 1_i32,
                                v5.get().clone(),
                            )
                        };
                        {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: i32 = (v1_1.get().clone()) + 1_i32;
                            let v2_temp: i32 = patternInput.0.clone();
                            let v3_temp: i32 = patternInput.1.clone();
                            let v4_temp: i32 = patternInput.2.clone();
                            let v5_temp: i32 = patternInput.3.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            v5.set(v5_temp);
                            continue '_method139;
                        }
                    } else {
                        (
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                        )
                    }
                });
            }
        }
        pub fn closure69(
            v0_1: i32,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: string,
            unitVar: (),
        ) -> string {
            let v6: i32 = (v4) + 80_i32;
            let v8: i32 = if (v3) < (v6) { v3 } else { v6 };
            let v9: bool = (v4) == (v8);
            append(
                string("parsing.spaces1 / expected at least one space / "),
                (Documents::method137(getSlice(v5, Some(v4), Some((v8) - 1_i32)))),
            )
        }
        pub fn method140(
            v0_1: string,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: i32,
        ) -> (i32, i32, i32, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: MutCell<i32> = MutCell::new(v5);
            '_method140: loop {
                break '_method140 (if (v1_1.get().clone()) >= (v5.get().clone()) {
                    (
                        v1_1.get().clone(),
                        v2.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                        v5.get().clone(),
                    )
                } else {
                    let v8: bool = '\n' == (getCharAt(v0_1.get().clone(), v1_1.get().clone()));
                    if (v8) != true {
                        let patternInput: (i32, i32, i32, i32) = if v8 {
                            (
                                (v2.get().clone()) + (v4.get().clone()),
                                (v3.get().clone()) + 1_i32,
                                1_i32,
                                v5.get().clone(),
                            )
                        } else {
                            (
                                v2.get().clone(),
                                v3.get().clone(),
                                (v4.get().clone()) + 1_i32,
                                v5.get().clone(),
                            )
                        };
                        {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: i32 = (v1_1.get().clone()) + 1_i32;
                            let v2_temp: i32 = patternInput.0.clone();
                            let v3_temp: i32 = patternInput.1.clone();
                            let v4_temp: i32 = patternInput.2.clone();
                            let v5_temp: i32 = patternInput.3.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            v5.set(v5_temp);
                            continue '_method140;
                        }
                    } else {
                        (
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                        )
                    }
                });
            }
        }
        pub fn closure70(v0_1: i32, v1_1: string, v2: i32, unitVar: ()) -> string {
            let v3: bool = (v0_1) == (v2);
            getSlice(v1_1, Some(v0_1), Some((v2) - 1_i32))
        }
        pub fn closure71(unitVar: (), unitVar_1: ()) -> Documents::US23 {
            Documents::US23::US23_1
        }
        pub fn closure72(v0_1: Func0<string>, unitVar: ()) -> Documents::US23 {
            Documents::US23::US23_0(v0_1)
        }
        pub fn closure73(
            v0_1: Func0<string>,
            v1_1: Func0<Documents::US23>,
            unitVar: (),
        ) -> (Func0<string>, Func0<Documents::US23>) {
            (v0_1, v1_1)
        }
        pub fn closure74(
            v0_1: string,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: i32,
            unitVar: (),
        ) -> string {
            let v6: bool = (v5) == (v4);
            getSlice(v0_1, Some(v5), Some((v4) - 1_i32))
        }
        pub fn method106(v0_1: string) -> Documents::US18 {
            let v1_1: i32 = length(v0_1.clone());
            fn v2(arg10_0040: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
                Documents::closure42((), arg10_0040)
            }
            fn v3(arg10_0040_1: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
                Documents::closure47((), arg10_0040_1)
            }
            let v7: Documents::US19 = Documents::method119(
                v1_1,
                v0_1.clone(),
                LrcPtr::new(Documents::UH0::UH0_1(
                    Func1::from(v2),
                    LrcPtr::new(Documents::UH0::UH0_1(
                        Func1::from(v3),
                        LrcPtr::new(Documents::UH0::UH0_0),
                    )),
                )),
            );
            let v104: Documents::US20 = match &v7 {
                Documents::US19::US19_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4, v7_0_5) => {
                    let v9: i32 = v7_0_1.clone();
                    let v13: i32 = v7_0_5.clone();
                    let v12: i32 = v7_0_4.clone();
                    let v11: i32 = v7_0_3.clone();
                    let v10: i32 = v7_0_2.clone();
                    let v35: Documents::US19 = if (v9) >= (v13) {
                        Documents::US19::US19_1(Func0::new({
                            let v10 = v10.clone();
                            let v11 = v11.clone();
                            let v12 = v12.clone();
                            let v13 = v13.clone();
                            move || Documents::closure51(v10, v11, v12, v13, ())
                        }))
                    } else {
                        let v17: char = getCharAt(v0_1.clone(), v9);
                        if (Documents::method124(v17, 0_i64)) == false {
                            let patternInput: (i32, i32, i32, i32) = if '\n' == (v17) {
                                ((v10) + (v12), (v11) + 1_i32, 1_i32, v13)
                            } else {
                                (v10, v11, (v12) + 1_i32, v13)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v17 = v17.clone();
                                    move || Documents::closure52(v17, ())
                                }),
                                (v9) + 1_i32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                                patternInput.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v10 = v10.clone();
                                let v11 = v11.clone();
                                let v12 = v12.clone();
                                let v13 = v13.clone();
                                let v17 = v17.clone();
                                move || Documents::closure53(v10, v11, v12, v13, v17, ())
                            }))
                        }
                    };
                    let v46: Documents::US20 = match &v35 {
                        Documents::US19::US19_0(
                            v35_0_0,
                            v35_0_1,
                            v35_0_2,
                            v35_0_3,
                            v35_0_4,
                            v35_0_5,
                        ) => Documents::method127(
                            v9,
                            v0_1.clone(),
                            v35_0_1.clone(),
                            v35_0_2.clone(),
                            v35_0_3.clone(),
                            v35_0_4.clone(),
                            v35_0_5.clone(),
                        ),
                        Documents::US19::US19_1(v35_1_0) => {
                            Documents::US20::US20_1(v35_1_0.clone())
                        }
                    };
                    let v58: Documents::US20 = match &v46 {
                        Documents::US20::US20_0(
                            v46_0_0,
                            v46_0_1,
                            v46_0_2,
                            v46_0_3,
                            v46_0_4,
                            v46_0_5,
                        ) => Documents::US20::US20_0(
                            v46_0_0.clone(),
                            v46_0_1.clone(),
                            v46_0_2.clone(),
                            v46_0_3.clone(),
                            v46_0_4.clone(),
                            v46_0_5.clone(),
                        ),
                        _ => Documents::US20::US20_0(
                            Func0::new(move || Documents::closure56((), ())),
                            v9,
                            v10,
                            v11,
                            v12,
                            v13,
                        ),
                    };
                    match &v58 {
                        Documents::US20::US20_0(
                            v58_0_0,
                            v58_0_1,
                            v58_0_2,
                            v58_0_3,
                            v58_0_4,
                            v58_0_5,
                        ) => {
                            let v60: i32 = v58_0_1.clone();
                            let v68: Documents::US19 = Documents::method128(
                                v58_0_2.clone(),
                                v58_0_3.clone(),
                                v58_0_4.clone(),
                                v58_0_5.clone(),
                                v60,
                                v0_1.clone(),
                                LrcPtr::new(Documents::UH0::UH0_1(
                                    Func1::from(v2),
                                    LrcPtr::new(Documents::UH0::UH0_1(
                                        Func1::from(v3),
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    )),
                                )),
                            );
                            match &v68 {
                                Documents::US19::US19_0(
                                    v68_0_0,
                                    v68_0_1,
                                    v68_0_2,
                                    v68_0_3,
                                    v68_0_4,
                                    v68_0_5,
                                ) => Documents::US20::US20_0(
                                    v58_0_0.clone(),
                                    v68_0_1.clone(),
                                    v68_0_2.clone(),
                                    v68_0_3.clone(),
                                    v68_0_4.clone(),
                                    v68_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v68_1_0) => {
                                    Documents::US20::US20_1(Func0::new({
                                        let v0_1 = v0_1.clone();
                                        let v60 = v60.clone();
                                        let v68 = v68.clone();
                                        let v9 = v9.clone();
                                        move || {
                                            Documents::closure59(
                                                v0_1.clone(),
                                                v9,
                                                v60,
                                                match &v68 {
                                                    Documents::US19::US19_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                                (),
                                            )
                                        }
                                    }))
                                }
                            }
                        }
                        _ => {
                            let v85: Documents::US19 = Documents::method128(
                                v10,
                                v11,
                                v12,
                                v13,
                                v9,
                                v0_1.clone(),
                                LrcPtr::new(Documents::UH0::UH0_1(
                                    Func1::from(v2),
                                    LrcPtr::new(Documents::UH0::UH0_1(
                                        Func1::from(v3),
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    )),
                                )),
                            );
                            match &v85 {
                                Documents::US19::US19_0(
                                    v85_0_0,
                                    v85_0_1,
                                    v85_0_2,
                                    v85_0_3,
                                    v85_0_4,
                                    v85_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new(move || Documents::closure58((), ())),
                                    v85_0_1.clone(),
                                    v85_0_2.clone(),
                                    v85_0_3.clone(),
                                    v85_0_4.clone(),
                                    v85_0_5.clone(),
                                ),
                                _ => Documents::US20::US20_1(Func0::new({
                                    let v0_1 = v0_1.clone();
                                    let v9 = v9.clone();
                                    move || Documents::closure57(v0_1.clone(), v9, ())
                                })),
                            }
                        }
                    }
                }
                Documents::US19::US19_1(v7_1_0) => Documents::US20::US20_1(v7_1_0.clone()),
            };
            let v116: Documents::US20 = match &v104 {
                Documents::US20::US20_0(
                    v104_0_0,
                    v104_0_1,
                    v104_0_2,
                    v104_0_3,
                    v104_0_4,
                    v104_0_5,
                ) => Documents::US20::US20_0(
                    Func0::new({
                        let v104 = v104.clone();
                        move || {
                            Documents::closure60(
                                match &v104 {
                                    Documents::US20::US20_0(x, _, _, _, _, _) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                (),
                            )
                        }
                    }),
                    v104_0_1.clone(),
                    v104_0_2.clone(),
                    v104_0_3.clone(),
                    v104_0_4.clone(),
                    v104_0_5.clone(),
                ),
                Documents::US20::US20_1(v104_1_0) => Documents::US20::US20_1(v104_1_0.clone()),
            };
            let v166: Documents::US20 = match &v116 {
                Documents::US20::US20_0(
                    v116_0_0,
                    v116_0_1,
                    v116_0_2,
                    v116_0_3,
                    v116_0_4,
                    v116_0_5,
                ) => v116.clone(),
                _ => {
                    let v141: Documents::US19 = if 0_i32 >= (v1_1) {
                        Documents::US19::US19_1(Func0::new({
                            let v1_1 = v1_1.clone();
                            move || Documents::closure61(v1_1, ())
                        }))
                    } else {
                        let v127: char = getCharAt(v0_1.clone(), 0_i32);
                        if (Documents::method135(v127, 0_i64)) == false {
                            let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v127) {
                                (1_i32, 2_i32, 1_i32, v1_1)
                            } else {
                                (0_i32, 1_i32, 2_i32, v1_1)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v127 = v127.clone();
                                    move || Documents::closure52(v127, ())
                                }),
                                1_i32,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v127 = v127.clone();
                                let v1_1 = v1_1.clone();
                                move || Documents::closure62(v1_1, v127, ())
                            }))
                        }
                    };
                    let v152: Documents::US20 = match &v141 {
                        Documents::US19::US19_0(
                            v141_0_0,
                            v141_0_1,
                            v141_0_2,
                            v141_0_3,
                            v141_0_4,
                            v141_0_5,
                        ) => Documents::method136(
                            v0_1.clone(),
                            v141_0_1.clone(),
                            v141_0_2.clone(),
                            v141_0_3.clone(),
                            v141_0_4.clone(),
                            v141_0_5.clone(),
                        ),
                        Documents::US19::US19_1(v141_1_0) => {
                            Documents::US20::US20_1(v141_1_0.clone())
                        }
                    };
                    match &v152 {
                        Documents::US20::US20_0(
                            v152_0_0,
                            v152_0_1,
                            v152_0_2,
                            v152_0_3,
                            v152_0_4,
                            v152_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new({
                                let v152 = v152.clone();
                                move || {
                                    Documents::closure60(
                                        match &v152 {
                                            Documents::US20::US20_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v152_0_1.clone(),
                            v152_0_2.clone(),
                            v152_0_3.clone(),
                            v152_0_4.clone(),
                            v152_0_5.clone(),
                        ),
                        Documents::US20::US20_1(v152_1_0) => {
                            Documents::US20::US20_1(v152_1_0.clone())
                        }
                    }
                }
            };
            let v193: Documents::US20 = match &v166 {
                Documents::US20::US20_0(
                    v166_0_0,
                    v166_0_1,
                    v166_0_2,
                    v166_0_3,
                    v166_0_4,
                    v166_0_5,
                ) => v166.clone(),
                _ => {
                    let v179: Documents::US21 = if (v1_1) == 0_i32 {
                        Documents::US21::US21_0(
                            Func0::new(move || Documents::closure66((), ())),
                            0_i32,
                            0_i32,
                            1_i32,
                            1_i32,
                            v1_1,
                        )
                    } else {
                        Documents::US21::US21_1(Func0::new({
                            let v0_1 = v0_1.clone();
                            let v1_1 = v1_1.clone();
                            move || Documents::closure67(v1_1, v0_1.clone(), ())
                        }))
                    };
                    match &v179 {
                        Documents::US21::US21_0(
                            v179_0_0,
                            v179_0_1,
                            v179_0_2,
                            v179_0_3,
                            v179_0_4,
                            v179_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new(move || Documents::closure68((), ())),
                            v179_0_1.clone(),
                            v179_0_2.clone(),
                            v179_0_3.clone(),
                            v179_0_4.clone(),
                            v179_0_5.clone(),
                        ),
                        Documents::US21::US21_1(v179_1_0) => {
                            Documents::US20::US20_1(v179_1_0.clone())
                        }
                    }
                }
            };
            let v257: Documents::US22 = match &v193 {
                Documents::US20::US20_0(
                    v193_0_0,
                    v193_0_1,
                    v193_0_2,
                    v193_0_3,
                    v193_0_4,
                    v193_0_5,
                ) => {
                    let v199: i32 = v193_0_5.clone();
                    let v198: i32 = v193_0_4.clone();
                    let v197: i32 = v193_0_3.clone();
                    let v196: i32 = v193_0_2.clone();
                    let v195: i32 = v193_0_1.clone();
                    let patternInput_2: (i32, i32, i32, i32, i32) =
                        Documents::method139(v0_1.clone(), v195, v196, v197, v198, v199);
                    let v200: i32 = patternInput_2.0.clone();
                    let v211: Documents::US21 = if ((v200) == (v195)) != true {
                        Documents::US21::US21_0(
                            Func0::new(move || Documents::closure66((), ())),
                            v200,
                            patternInput_2.1.clone(),
                            patternInput_2.2.clone(),
                            patternInput_2.3.clone(),
                            patternInput_2.4.clone(),
                        )
                    } else {
                        Documents::US21::US21_1(Func0::new({
                            let v0_1 = v0_1.clone();
                            let v195 = v195.clone();
                            let v196 = v196.clone();
                            let v197 = v197.clone();
                            let v198 = v198.clone();
                            let v199 = v199.clone();
                            move || {
                                Documents::closure69(v196, v197, v198, v199, v195, v0_1.clone(), ())
                            }
                        }))
                    };
                    let v228: Documents::US20 = match &v211 {
                        Documents::US21::US21_0(
                            v211_0_0,
                            v211_0_1,
                            v211_0_2,
                            v211_0_3,
                            v211_0_4,
                            v211_0_5,
                        ) => {
                            let v213: i32 = v211_0_1.clone();
                            let patternInput_3: (i32, i32, i32, i32, i32) = Documents::method140(
                                v0_1.clone(),
                                v213,
                                v211_0_2.clone(),
                                v211_0_3.clone(),
                                v211_0_4.clone(),
                                v211_0_5.clone(),
                            );
                            let v218: i32 = patternInput_3.0.clone();
                            Documents::US20::US20_0(
                                Func0::new({
                                    let v0_1 = v0_1.clone();
                                    let v213 = v213.clone();
                                    let v218 = v218.clone();
                                    move || Documents::closure70(v213, v0_1.clone(), v218, ())
                                }),
                                v218,
                                patternInput_3.1.clone(),
                                patternInput_3.2.clone(),
                                patternInput_3.3.clone(),
                                patternInput_3.4.clone(),
                            )
                        }
                        Documents::US21::US21_1(v211_1_0) => {
                            Documents::US20::US20_1(v211_1_0.clone())
                        }
                    };
                    let v241: Documents::US24 = match &v228 {
                        Documents::US20::US20_0(
                            v228_0_0,
                            v228_0_1,
                            v228_0_2,
                            v228_0_3,
                            v228_0_4,
                            v228_0_5,
                        ) => Documents::US24::US24_0(
                            Func0::new({
                                let v228 = v228.clone();
                                move || {
                                    Documents::closure72(
                                        match &v228 {
                                            Documents::US20::US20_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v228_0_1.clone(),
                            v228_0_2.clone(),
                            v228_0_3.clone(),
                            v228_0_4.clone(),
                            v228_0_5.clone(),
                        ),
                        _ => Documents::US24::US24_0(
                            Func0::new(move || Documents::closure71((), ())),
                            v195,
                            v196,
                            v197,
                            v198,
                            v199,
                        ),
                    };
                    match &v241 {
                        Documents::US24::US24_0(
                            v241_0_0,
                            v241_0_1,
                            v241_0_2,
                            v241_0_3,
                            v241_0_4,
                            v241_0_5,
                        ) => Documents::US22::US22_0(
                            Func0::new({
                                let v193 = v193.clone();
                                let v241 = v241.clone();
                                move || {
                                    Documents::closure73(
                                        match &v193 {
                                            Documents::US20::US20_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        match &v241 {
                                            Documents::US24::US24_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v241_0_1.clone(),
                            v241_0_2.clone(),
                            v241_0_3.clone(),
                            v241_0_4.clone(),
                            v241_0_5.clone(),
                        ),
                        Documents::US24::US24_1(v241_1_0) => {
                            Documents::US22::US22_1(v241_1_0.clone())
                        }
                    }
                }
                Documents::US20::US20_1(v193_1_0) => Documents::US22::US22_1(v193_1_0.clone()),
            };
            let v269: Documents::US25 = match &v257 {
                Documents::US22::US22_0(
                    v257_0_0,
                    v257_0_1,
                    v257_0_2,
                    v257_0_3,
                    v257_0_4,
                    v257_0_5,
                ) => {
                    let v263: i32 = v257_0_5.clone();
                    let v262: i32 = v257_0_4.clone();
                    let v261: i32 = v257_0_3.clone();
                    let v260: i32 = v257_0_2.clone();
                    Documents::US25::US25_0(
                        v257_0_0.clone(),
                        Func0::new({
                            let v0_1 = v0_1.clone();
                            let v257 = v257.clone();
                            let v260 = v260.clone();
                            let v261 = v261.clone();
                            let v262 = v262.clone();
                            let v263 = v263.clone();
                            move || {
                                Documents::closure74(
                                    v0_1.clone(),
                                    v260,
                                    v261,
                                    v262,
                                    v263,
                                    match &v257 {
                                        Documents::US22::US22_0(_, x, _, _, _, _) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    (),
                                )
                            }
                        }),
                        v260,
                        v261,
                        v262,
                        v263,
                    )
                }
                Documents::US22::US22_1(v257_1_0) => Documents::US25::US25_1(v257_1_0.clone()),
            };
            let v283: Documents::US26 = match &v269 {
                Documents::US25::US25_0(
                    v269_0_0,
                    v269_0_1,
                    v269_0_2,
                    v269_0_3,
                    v269_0_4,
                    v269_0_5,
                ) => {
                    let patternInput_4 = (v269_0_0)();
                    Documents::US26::US26_0(
                        patternInput_4.0.clone(),
                        patternInput_4.1.clone(),
                        (v269_0_1)(),
                        v269_0_2.clone(),
                        v269_0_3.clone(),
                        v269_0_4.clone(),
                        v269_0_5.clone(),
                    )
                }
                Documents::US25::US25_1(v269_1_0) => Documents::US26::US26_1(v269_1_0.clone()),
            };
            let v303: Documents::US27 = match &v283 {
                Documents::US26::US26_0(
                    v283_0_0,
                    v283_0_1,
                    v283_0_2,
                    v283_0_3,
                    v283_0_4,
                    v283_0_5,
                    v283_0_6,
                ) => {
                    let v291: string = (v283_0_0)();
                    let v292: Documents::US23 = (v283_0_1)();
                    Documents::US27::US27_0(
                        v291,
                        match &v292 {
                            Documents::US23::US23_0(v292_0_0) => {
                                Documents::US5::US5_0((match &v292 {
                                    Documents::US23::US23_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })())
                            }
                            _ => Documents::US5::US5_1,
                        },
                    )
                }
                Documents::US26::US26_1(v283_1_0) => Documents::US27::US27_1(v283_1_0.clone()),
            };
            match &v303 {
                Documents::US27::US27_0(v303_0_0, v303_0_1) => {
                    Documents::US18::US18_0(v303_0_0.clone(), v303_0_1.clone())
                }
                Documents::US27::US27_1(v303_1_0) => Documents::US18::US18_1((v303_1_0)()),
            }
        }
        pub fn closure76(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.p_char / unexpected end of input / "),
                (Documents::method107('\\', v0_1, v1_1, v2, v3)),
            )
        }
        pub fn closure77(
            v0_1: i32,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: string,
            unitVar: (),
        ) -> string {
            let v6: i32 = Documents::method115(v4.clone(), length(v4.clone()), v3);
            let v7: i32 = (v3) + 80_i32;
            let v9: i32 = if (v6) < (v7) { v6 } else { v7 };
            let v10: bool = (v2) == (v9);
            let v1011: string = getSlice(v4, Some(v2), Some((v9) - 1_i32));
            let v1022: i32 = length(v1011.clone());
            let v1030: string = if if (v1022) > 0_i32 {
                (getCharAt(v1011.clone(), (v1022) - 1_i32)) == '\n'
            } else {
                false
            } {
                string("")
            } else {
                string("\n")
            };
            let v1039: string = append(
                ((Documents::method116((v0_1) - 1_i32, 0_i32))(string(""))),
                string("^"),
            );
            append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    string("parsing.p_char / "),
                                    (Documents::method117('\\', v1_1, v0_1)),
                                )),
                                string("\n"),
                            )),
                            (v1011),
                        )),
                        (v1030),
                    )),
                    (v1039),
                )),
                string("\n"),
            )
        }
        pub fn closure78(unitVar: (), unitVar_1: ()) -> char {
            '\"'
        }
        pub fn closure75(unitVar: (), _arg: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
            let v5: i32 = _arg.5.clone();
            let v4: i32 = _arg.4.clone();
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: i32 = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v25: Documents::US19 = if (v1_1) >= (v5) {
                Documents::US19::US19_1(Func0::new({
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    move || Documents::closure76(v2, v3, v4, v5, ())
                }))
            } else {
                let v9: char = getCharAt(v0_1.clone(), v1_1);
                if (v9) == '\\' {
                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v9) {
                        ((v2) + (v4), (v3) + 1_i32, 1_i32, v5)
                    } else {
                        (v2, v3, (v4) + 1_i32, v5)
                    };
                    Documents::US19::US19_0(
                        Func0::new({
                            let v9 = v9.clone();
                            move || Documents::closure44(v9, ())
                        }),
                        (v1_1) + 1_i32,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                        patternInput.3.clone(),
                    )
                } else {
                    Documents::US19::US19_1(Func0::new({
                        let v0_1 = v0_1.clone();
                        let v1_1 = v1_1.clone();
                        let v2 = v2.clone();
                        let v3 = v3.clone();
                        let v4 = v4.clone();
                        move || Documents::closure77(v4, v3, v2, v1_1, v0_1.clone(), ())
                    }))
                }
            };
            let v55: Documents::US19 = match &v25 {
                Documents::US19::US19_0(v25_0_0, v25_0_1, v25_0_2, v25_0_3, v25_0_4, v25_0_5) => {
                    let v31: i32 = v25_0_5.clone();
                    let v30: i32 = v25_0_4.clone();
                    let v29: i32 = v25_0_3.clone();
                    let v28: i32 = v25_0_2.clone();
                    let v27: i32 = v25_0_1.clone();
                    if (v27) >= (v31) {
                        Documents::US19::US19_1(Func0::new({
                            let v28 = v28.clone();
                            let v29 = v29.clone();
                            let v30 = v30.clone();
                            let v31 = v31.clone();
                            move || Documents::closure43(v28, v29, v30, v31, ())
                        }))
                    } else {
                        let v35: char = getCharAt(v0_1.clone(), v27);
                        if (v35) == '\"' {
                            let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v35) {
                                ((v28) + (v30), (v29) + 1_i32, 1_i32, v31)
                            } else {
                                (v28, v29, (v30) + 1_i32, v31)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v35 = v35.clone();
                                    move || Documents::closure44(v35, ())
                                }),
                                (v27) + 1_i32,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v0_1 = v0_1.clone();
                                let v27 = v27.clone();
                                let v28 = v28.clone();
                                let v29 = v29.clone();
                                let v30 = v30.clone();
                                move || Documents::closure45(v30, v29, v28, v27, v0_1.clone(), ())
                            }))
                        }
                    }
                }
                Documents::US19::US19_1(v25_1_0) => Documents::US19::US19_1(v25_1_0.clone()),
            };
            match &v55 {
                Documents::US19::US19_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4, v55_0_5) => {
                    Documents::US19::US19_0(
                        Func0::new(move || Documents::closure78((), ())),
                        v55_0_1.clone(),
                        v55_0_2.clone(),
                        v55_0_3.clone(),
                        v55_0_4.clone(),
                        v55_0_5.clone(),
                    )
                }
                Documents::US19::US19_1(v55_1_0) => Documents::US19::US19_1(v55_1_0.clone()),
            }
        }
        pub fn closure80(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.p_char / unexpected end of input / "),
                (Documents::method107('`', v0_1, v1_1, v2, v3)),
            )
        }
        pub fn closure81(
            v0_1: i32,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: string,
            unitVar: (),
        ) -> string {
            let v6: i32 = Documents::method115(v4.clone(), length(v4.clone()), v3);
            let v7: i32 = (v3) + 80_i32;
            let v9: i32 = if (v6) < (v7) { v6 } else { v7 };
            let v10: bool = (v2) == (v9);
            let v1011: string = getSlice(v4, Some(v2), Some((v9) - 1_i32));
            let v1022: i32 = length(v1011.clone());
            let v1030: string = if if (v1022) > 0_i32 {
                (getCharAt(v1011.clone(), (v1022) - 1_i32)) == '\n'
            } else {
                false
            } {
                string("")
            } else {
                string("\n")
            };
            let v1039: string = append(
                ((Documents::method116((v0_1) - 1_i32, 0_i32))(string(""))),
                string("^"),
            );
            append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    string("parsing.p_char / "),
                                    (Documents::method117('`', v1_1, v0_1)),
                                )),
                                string("\n"),
                            )),
                            (v1011),
                        )),
                        (v1030),
                    )),
                    (v1039),
                )),
                string("\n"),
            )
        }
        pub fn closure79(unitVar: (), _arg: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
            let v5: i32 = _arg.5.clone();
            let v4: i32 = _arg.4.clone();
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: i32 = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v25: Documents::US19 = if (v1_1) >= (v5) {
                Documents::US19::US19_1(Func0::new({
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    move || Documents::closure80(v2, v3, v4, v5, ())
                }))
            } else {
                let v9: char = getCharAt(v0_1.clone(), v1_1);
                if (v9) == '`' {
                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v9) {
                        ((v2) + (v4), (v3) + 1_i32, 1_i32, v5)
                    } else {
                        (v2, v3, (v4) + 1_i32, v5)
                    };
                    Documents::US19::US19_0(
                        Func0::new({
                            let v9 = v9.clone();
                            move || Documents::closure44(v9, ())
                        }),
                        (v1_1) + 1_i32,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                        patternInput.3.clone(),
                    )
                } else {
                    Documents::US19::US19_1(Func0::new({
                        let v0_1 = v0_1.clone();
                        let v1_1 = v1_1.clone();
                        let v2 = v2.clone();
                        let v3 = v3.clone();
                        let v4 = v4.clone();
                        move || Documents::closure81(v4, v3, v2, v1_1, v0_1.clone(), ())
                    }))
                }
            };
            let v55: Documents::US19 = match &v25 {
                Documents::US19::US19_0(v25_0_0, v25_0_1, v25_0_2, v25_0_3, v25_0_4, v25_0_5) => {
                    let v31: i32 = v25_0_5.clone();
                    let v30: i32 = v25_0_4.clone();
                    let v29: i32 = v25_0_3.clone();
                    let v28: i32 = v25_0_2.clone();
                    let v27: i32 = v25_0_1.clone();
                    if (v27) >= (v31) {
                        Documents::US19::US19_1(Func0::new({
                            let v28 = v28.clone();
                            let v29 = v29.clone();
                            let v30 = v30.clone();
                            let v31 = v31.clone();
                            move || Documents::closure43(v28, v29, v30, v31, ())
                        }))
                    } else {
                        let v35: char = getCharAt(v0_1.clone(), v27);
                        if (v35) == '\"' {
                            let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v35) {
                                ((v28) + (v30), (v29) + 1_i32, 1_i32, v31)
                            } else {
                                (v28, v29, (v30) + 1_i32, v31)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v35 = v35.clone();
                                    move || Documents::closure44(v35, ())
                                }),
                                (v27) + 1_i32,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v0_1 = v0_1.clone();
                                let v27 = v27.clone();
                                let v28 = v28.clone();
                                let v29 = v29.clone();
                                let v30 = v30.clone();
                                move || Documents::closure45(v30, v29, v28, v27, v0_1.clone(), ())
                            }))
                        }
                    }
                }
                Documents::US19::US19_1(v25_1_0) => Documents::US19::US19_1(v25_1_0.clone()),
            };
            match &v55 {
                Documents::US19::US19_0(v55_0_0, v55_0_1, v55_0_2, v55_0_3, v55_0_4, v55_0_5) => {
                    Documents::US19::US19_0(
                        Func0::new(move || Documents::closure78((), ())),
                        v55_0_1.clone(),
                        v55_0_2.clone(),
                        v55_0_3.clone(),
                        v55_0_4.clone(),
                        v55_0_5.clone(),
                    )
                }
                Documents::US19::US19_1(v55_1_0) => Documents::US19::US19_1(v55_1_0.clone()),
            }
        }
        pub fn closure82(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected end of input / "),
                (Documents::method121(
                    Documents::method120(toArray_1(ofArray(new_array(&['\\', '`', '\"'])))),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                )),
            )
        }
        pub fn method142(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method142: loop {
                break '_method142 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US8 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US8::US8_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US8::US8_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US8::US8_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US8::US8_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US8::US8_0(v15_0_0) => match &v15 {
                                Documents::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method142;
                    }
                });
            }
        }
        pub fn closure83(v0_1: i32, v1_1: i32, v2: i32, v3: i32, v4: char, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected char / "),
                (Documents::method125(
                    v4,
                    Documents::method120(toArray_1(ofArray(new_array(&['\\', '`', '\"'])))),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                )),
            )
        }
        pub fn closure84(v0_1: Func0<char>, unitVar: ()) -> string {
            ofChar(v0_1())
        }
        pub fn closure86(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected end of input / "),
                (Documents::method121(
                    Documents::method120(toArray_1(singleton('\"'))),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                )),
            )
        }
        pub fn method143(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method143: loop {
                break '_method143 (if (v1_1.get().clone()) >= 1_i64 {
                    false
                } else {
                    let v7: Documents::US8 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US8::US8_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        Documents::US8::US8_1
                    };
                    if (v0_1.get().clone())
                        == (match &v7 {
                            Documents::US8::US8_0(v7_0_0) => match &v7 {
                                Documents::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method143;
                    }
                });
            }
        }
        pub fn closure87(v0_1: i32, v1_1: i32, v2: i32, v3: i32, v4: char, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected char / "),
                (Documents::method125(
                    v4,
                    Documents::method120(toArray_1(singleton('\"'))),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                )),
            )
        }
        pub fn closure88(v0_1: Func0<char>, unitVar: ()) -> string {
            append((ofChar('\\')), (ofChar(v0_1())))
        }
        pub fn closure85(unitVar: (), _arg: (string, i32, i32, i32, i32, i32)) -> Documents::US20 {
            let v5: i32 = _arg.5.clone();
            let v4: i32 = _arg.4.clone();
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: i32 = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v25: Documents::US19 = if (v1_1) >= (v5) {
                Documents::US19::US19_1(Func0::new({
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    move || Documents::closure76(v2, v3, v4, v5, ())
                }))
            } else {
                let v9: char = getCharAt(v0_1.clone(), v1_1);
                if (v9) == '\\' {
                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v9) {
                        ((v2) + (v4), (v3) + 1_i32, 1_i32, v5)
                    } else {
                        (v2, v3, (v4) + 1_i32, v5)
                    };
                    Documents::US19::US19_0(
                        Func0::new({
                            let v9 = v9.clone();
                            move || Documents::closure44(v9, ())
                        }),
                        (v1_1) + 1_i32,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                        patternInput.3.clone(),
                    )
                } else {
                    Documents::US19::US19_1(Func0::new({
                        let v0_1 = v0_1.clone();
                        let v1_1 = v1_1.clone();
                        let v2 = v2.clone();
                        let v3 = v3.clone();
                        let v4 = v4.clone();
                        move || Documents::closure77(v4, v3, v2, v1_1, v0_1.clone(), ())
                    }))
                }
            };
            let v57: Documents::US19 = match &v25 {
                Documents::US19::US19_0(v25_0_0, v25_0_1, v25_0_2, v25_0_3, v25_0_4, v25_0_5) => {
                    let v31: i32 = v25_0_5.clone();
                    let v30: i32 = v25_0_4.clone();
                    let v29: i32 = v25_0_3.clone();
                    let v28: i32 = v25_0_2.clone();
                    let v27: i32 = v25_0_1.clone();
                    if (v27) >= (v31) {
                        Documents::US19::US19_1(Func0::new({
                            let v28 = v28.clone();
                            let v29 = v29.clone();
                            let v30 = v30.clone();
                            let v31 = v31.clone();
                            move || Documents::closure86(v28, v29, v30, v31, ())
                        }))
                    } else {
                        let v35: char = getCharAt(v0_1.clone(), v27);
                        if (Documents::method143(v35, 0_i64)) == false {
                            let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v35) {
                                ((v28) + (v30), (v29) + 1_i32, 1_i32, v31)
                            } else {
                                (v28, v29, (v30) + 1_i32, v31)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v35 = v35.clone();
                                    move || Documents::closure52(v35, ())
                                }),
                                (v27) + 1_i32,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v28 = v28.clone();
                                let v29 = v29.clone();
                                let v30 = v30.clone();
                                let v31 = v31.clone();
                                let v35 = v35.clone();
                                move || Documents::closure87(v28, v29, v30, v31, v35, ())
                            }))
                        }
                    }
                }
                Documents::US19::US19_1(v25_1_0) => Documents::US19::US19_1(v25_1_0.clone()),
            };
            match &v57 {
                Documents::US19::US19_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4, v57_0_5) => {
                    Documents::US20::US20_0(
                        Func0::new({
                            let v57 = v57.clone();
                            move || {
                                Documents::closure88(
                                    match &v57 {
                                        Documents::US19::US19_0(x, _, _, _, _, _) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    (),
                                )
                            }
                        }),
                        v57_0_1.clone(),
                        v57_0_2.clone(),
                        v57_0_3.clone(),
                        v57_0_4.clone(),
                        v57_0_5.clone(),
                    )
                }
                Documents::US19::US19_1(v57_1_0) => Documents::US20::US20_1(v57_1_0.clone()),
            }
        }
        pub fn closure90(v0_1: Func0<char>, unitVar: ()) -> string {
            append((ofChar('`')), (ofChar(v0_1())))
        }
        pub fn closure89(unitVar: (), _arg: (string, i32, i32, i32, i32, i32)) -> Documents::US20 {
            let v5: i32 = _arg.5.clone();
            let v4: i32 = _arg.4.clone();
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: i32 = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v25: Documents::US19 = if (v1_1) >= (v5) {
                Documents::US19::US19_1(Func0::new({
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    move || Documents::closure80(v2, v3, v4, v5, ())
                }))
            } else {
                let v9: char = getCharAt(v0_1.clone(), v1_1);
                if (v9) == '`' {
                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v9) {
                        ((v2) + (v4), (v3) + 1_i32, 1_i32, v5)
                    } else {
                        (v2, v3, (v4) + 1_i32, v5)
                    };
                    Documents::US19::US19_0(
                        Func0::new({
                            let v9 = v9.clone();
                            move || Documents::closure44(v9, ())
                        }),
                        (v1_1) + 1_i32,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                        patternInput.3.clone(),
                    )
                } else {
                    Documents::US19::US19_1(Func0::new({
                        let v0_1 = v0_1.clone();
                        let v1_1 = v1_1.clone();
                        let v2 = v2.clone();
                        let v3 = v3.clone();
                        let v4 = v4.clone();
                        move || Documents::closure81(v4, v3, v2, v1_1, v0_1.clone(), ())
                    }))
                }
            };
            let v57: Documents::US19 = match &v25 {
                Documents::US19::US19_0(v25_0_0, v25_0_1, v25_0_2, v25_0_3, v25_0_4, v25_0_5) => {
                    let v31: i32 = v25_0_5.clone();
                    let v30: i32 = v25_0_4.clone();
                    let v29: i32 = v25_0_3.clone();
                    let v28: i32 = v25_0_2.clone();
                    let v27: i32 = v25_0_1.clone();
                    if (v27) >= (v31) {
                        Documents::US19::US19_1(Func0::new({
                            let v28 = v28.clone();
                            let v29 = v29.clone();
                            let v30 = v30.clone();
                            let v31 = v31.clone();
                            move || Documents::closure86(v28, v29, v30, v31, ())
                        }))
                    } else {
                        let v35: char = getCharAt(v0_1.clone(), v27);
                        if (Documents::method143(v35, 0_i64)) == false {
                            let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v35) {
                                ((v28) + (v30), (v29) + 1_i32, 1_i32, v31)
                            } else {
                                (v28, v29, (v30) + 1_i32, v31)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v35 = v35.clone();
                                    move || Documents::closure52(v35, ())
                                }),
                                (v27) + 1_i32,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v28 = v28.clone();
                                let v29 = v29.clone();
                                let v30 = v30.clone();
                                let v31 = v31.clone();
                                let v35 = v35.clone();
                                move || Documents::closure87(v28, v29, v30, v31, v35, ())
                            }))
                        }
                    }
                }
                Documents::US19::US19_1(v25_1_0) => Documents::US19::US19_1(v25_1_0.clone()),
            };
            match &v57 {
                Documents::US19::US19_0(v57_0_0, v57_0_1, v57_0_2, v57_0_3, v57_0_4, v57_0_5) => {
                    Documents::US20::US20_0(
                        Func0::new({
                            let v57 = v57.clone();
                            move || {
                                Documents::closure90(
                                    match &v57 {
                                        Documents::US19::US19_0(x, _, _, _, _, _) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    (),
                                )
                            }
                        }),
                        v57_0_1.clone(),
                        v57_0_2.clone(),
                        v57_0_3.clone(),
                        v57_0_4.clone(),
                        v57_0_5.clone(),
                    )
                }
                Documents::US19::US19_1(v57_1_0) => Documents::US20::US20_1(v57_1_0.clone()),
            }
        }
        pub fn method144(
            v0_1: i32,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: string,
            v6: LrcPtr<Documents::UH1>,
        ) -> Documents::US20 {
            let v0_1: MutCell<i32> = MutCell::new(v0_1);
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: MutCell<string> = MutCell::new(v5.clone());
            let v6: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v6.clone());
            '_method144: loop {
                break '_method144 (match v6.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US20::US20_1(Func0::new(move || Documents::closure50((), ())))
                    }
                    Documents::UH1::UH1_1(v6_1_0, v6_1_1) => {
                        let v11: Documents::US20 = (match v6.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v5.get().clone(),
                            v4.get().clone(),
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v11 {
                            Documents::US20::US20_0(
                                v11_0_0,
                                v11_0_1,
                                v11_0_2,
                                v11_0_3,
                                v11_0_4,
                                v11_0_5,
                            ) => v11.clone(),
                            _ => {
                                let v0_1_temp: i32 = v0_1.get().clone();
                                let v1_1_temp: i32 = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: i32 = v4.get().clone();
                                let v5_temp: string = v5.get().clone();
                                let v6_temp: LrcPtr<Documents::UH1> =
                                    match v6.get().clone().as_ref() {
                                        Documents::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                continue '_method144;
                            }
                        }
                    }
                });
            }
        }
        pub fn closure91(unitVar: (), unitVar_1: ()) -> string {
            string("")
        }
        pub fn closure92(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.many_strings / first inner parser consumed no input")
        }
        pub fn closure93(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.many_strings / out of fuel (probable zero-length loop)")
        }
        pub fn method146(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method146: loop {
                break '_method146 (match v0_1.get().clone().as_ref() {
                    Documents::UH2::UH2_0 => v1_1.get().clone(),
                    Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => {
                        let v0_1_temp: LrcPtr<Documents::UH2> = match v0_1.get().clone().as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone();
                        let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(Documents::UH2::UH2_1(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH2::UH2_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            v1_1.get().clone(),
                        ));
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method146;
                    }
                });
            }
        }
        pub fn method147(v0_1: LrcPtr<Documents::UH2>, v1_1: string) -> (string, string) {
            let patternInput_2: (string, string) =
                if let Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) = v0_1.as_ref() {
                    let patternInput: (string, string) =
                        Documents::method147(v0_1_1_1.clone(), v1_1.clone());
                    (
                        append(
                            (append((v0_1_1_0.clone()), (patternInput.1.clone()))),
                            (patternInput.0.clone()),
                        ),
                        string(""),
                    )
                } else {
                    let patternInput_1: (string, string) =
                        if let Documents::UH2::UH2_0 = v0_1.as_ref() {
                            (v1_1.clone(), v1_1.clone())
                        } else {
                            (v1_1.clone(), v1_1)
                        };
                    (patternInput_1.0.clone(), patternInput_1.1.clone())
                };
            (patternInput_2.0.clone(), patternInput_2.1.clone())
        }
        pub fn closure94(v0_1: Func0<string>, v1_1: LrcPtr<Documents::UH2>, unitVar: ()) -> string {
            let v3: string = v0_1();
            let patternInput: (string, string) = Documents::method147(
                Documents::method146(v1_1, LrcPtr::new(Documents::UH2::UH2_0)),
                string(""),
            );
            append(
                (append((v3), (patternInput.1.clone()))),
                (patternInput.0.clone()),
            )
        }
        pub fn closure95(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.many_strings / inner parser succeeded without consuming input")
        }
        pub fn method145(
            v0_1: string,
            v1_1: Func0<string>,
            v2: LrcPtr<Documents::UH2>,
            v3: i32,
            v4: i32,
            v5: i32,
            v6: i32,
            v7: i32,
            v8: i32,
        ) -> Documents::US20 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1 = LrcPtr::new(MutCell::new(v1_1.clone()));
            let v2: LrcPtr<MutCell<LrcPtr<Documents::UH2>>> = LrcPtr::new(MutCell::new(v2.clone()));
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v5));
            let v6: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v6));
            let v7: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v7));
            let v8: MutCell<i32> = MutCell::new(v8);
            '_method145: loop {
                break '_method145 (if (v4.get().clone()) <= 0_i32 {
                    Documents::US20::US20_1(Func0::new(move || Documents::closure93((), ())))
                } else {
                    let v33: Documents::US19 = if (v3.get().clone()) >= (v8.get().clone()) {
                        Documents::US19::US19_1(Func0::new({
                            let v5 = v5.clone();
                            let v6 = v6.clone();
                            let v7 = v7.clone();
                            let v8 = v8.clone();
                            move || {
                                Documents::closure82(
                                    v5.get().clone(),
                                    v6.get().clone(),
                                    v7.get().clone(),
                                    v8.get().clone(),
                                    (),
                                )
                            }
                        }))
                    } else {
                        let v15: char = getCharAt(v0_1.get().clone(), v3.get().clone());
                        if (Documents::method142(v15, 0_i64)) == false {
                            let patternInput: (i32, i32, i32, i32) = if '\n' == (v15) {
                                (
                                    (v5.get().clone()) + (v7.get().clone()),
                                    (v6.get().clone()) + 1_i32,
                                    1_i32,
                                    v8.get().clone(),
                                )
                            } else {
                                (
                                    v5.get().clone(),
                                    v6.get().clone(),
                                    (v7.get().clone()) + 1_i32,
                                    v8.get().clone(),
                                )
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v15 = v15.clone();
                                    move || Documents::closure52(v15, ())
                                }),
                                (v3.get().clone()) + 1_i32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                                patternInput.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v15 = v15.clone();
                                let v5 = v5.clone();
                                let v6 = v6.clone();
                                let v7 = v7.clone();
                                let v8 = v8.clone();
                                move || {
                                    Documents::closure83(
                                        v5.get().clone(),
                                        v6.get().clone(),
                                        v7.get().clone(),
                                        v8.get().clone(),
                                        v15,
                                        (),
                                    )
                                }
                            }))
                        }
                    };
                    let v45: Documents::US20 = match &v33 {
                        Documents::US19::US19_0(
                            v33_0_0,
                            v33_0_1,
                            v33_0_2,
                            v33_0_3,
                            v33_0_4,
                            v33_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new({
                                let v33 = v33.clone();
                                move || {
                                    Documents::closure84(
                                        match &v33 {
                                            Documents::US19::US19_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v33_0_1.clone(),
                            v33_0_2.clone(),
                            v33_0_3.clone(),
                            v33_0_4.clone(),
                            v33_0_5.clone(),
                        ),
                        Documents::US19::US19_1(v33_1_0) => {
                            Documents::US20::US20_1(v33_1_0.clone())
                        }
                    };
                    let v60: Documents::US20 = match &v45 {
                        Documents::US20::US20_0(
                            v45_0_0,
                            v45_0_1,
                            v45_0_2,
                            v45_0_3,
                            v45_0_4,
                            v45_0_5,
                        ) => v45.clone(),
                        _ => Documents::method144(
                            v5.get().clone(),
                            v6.get().clone(),
                            v7.get().clone(),
                            v8.get().clone(),
                            v3.get().clone(),
                            v0_1.get().clone(),
                            LrcPtr::new(Documents::UH1::UH1_1(
                                Func1::new(
                                    move |arg10_0040_5: (string, i32, i32, i32, i32, i32)| {
                                        Documents::closure85((), arg10_0040_5)
                                    },
                                ),
                                LrcPtr::new(Documents::UH1::UH1_1(
                                    Func1::new(
                                        move |arg10_0040_6: (string, i32, i32, i32, i32, i32)| {
                                            Documents::closure89((), arg10_0040_6)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH1::UH1_0),
                                )),
                            )),
                        ),
                    };
                    match &v60 {
                        Documents::US20::US20_0(
                            v60_0_0,
                            v60_0_1,
                            v60_0_2,
                            v60_0_3,
                            v60_0_4,
                            v60_0_5,
                        ) => {
                            let v62: i32 = v60_0_1.clone();
                            if (v62) == (v3.get().clone()) {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure95((), ())
                                }))
                            } else {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                    Documents::UH2::UH2_1((v60_0_0)(), v2.get().clone()),
                                );
                                let v3_temp: i32 = v62;
                                let v4_temp: i32 = (v4.get().clone()) - 1_i32;
                                let v5_temp: i32 = v60_0_2.clone();
                                let v6_temp: i32 = v60_0_3.clone();
                                let v7_temp: i32 = v60_0_4.clone();
                                let v8_temp: i32 = v60_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                v7.set(v7_temp);
                                v8.set(v8_temp);
                                continue '_method145;
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new({
                                let v1_1 = v1_1.clone();
                                let v2 = v2.clone();
                                move || {
                                    Documents::closure94(v1_1.get().clone(), v2.get().clone(), ())
                                }
                            }),
                            v3.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            v7.get().clone(),
                            v8.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure96(v0_1: i32, unitVar: ()) -> string {
            append(
                string("parsing.p_char / unexpected end of input / "),
                (Documents::method107('\"', 0_i32, 1_i32, 1_i32, v0_1)),
            )
        }
        pub fn closure97(v0_1: string, unitVar: ()) -> string {
            let v3: i32 = Documents::method115(v0_1.clone(), length(v0_1.clone()), 0_i32);
            let v5: i32 = if (v3) < 80_i32 { v3 } else { 80_i32 };
            let v6: bool = 0_i32 == (v5);
            let v1007: string = getSlice(v0_1, Some(0_i32), Some((v5) - 1_i32));
            let v1018: i32 = length(v1007.clone());
            let v1026: string = if if (v1018) > 0_i32 {
                (getCharAt(v1007.clone(), (v1018) - 1_i32)) == '\n'
            } else {
                false
            } {
                string("")
            } else {
                string("\n")
            };
            let v1032: string = string("^");
            append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append(
                                    string("parsing.p_char / "),
                                    (Documents::method117('\"', 1_i32, 1_i32)),
                                )),
                                string("\n"),
                            )),
                            (v1007),
                        )),
                        (v1026),
                    )),
                    (v1032),
                )),
                string("\n"),
            )
        }
        pub fn method148(v0_1: i32, v1_1: i32, v2: i32, v3: i32) -> string {
            let v13: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v13.clone());
            Documents::method123(v13.clone());
            Documents::method20(v13.clone());
            {
                let v159: std::string::String = format!("{:#?}", v0_1);
                Documents::method15(v13.clone(), fable_library_rust::String_::fromString(v159));
                Documents::method21(v13.clone());
                v13.l0.get().clone()
            }
        }
        pub fn closure99(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.any_char / unexpected end of input / "),
                (Documents::method148(v0_1, v1_1, v2, v3)),
            )
        }
        pub fn closure100(v0_1: char, unitVar: ()) -> char {
            v0_1
        }
        pub fn closure101(v0_1: Func0<char>, unitVar: ()) -> string {
            append((ofChar('\\')), (ofChar(v0_1())))
        }
        pub fn closure98(unitVar: (), _arg: (string, i32, i32, i32, i32, i32)) -> Documents::US20 {
            let v5: i32 = _arg.5.clone();
            let v4: i32 = _arg.4.clone();
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: i32 = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v25: Documents::US19 = if (v1_1) >= (v5) {
                Documents::US19::US19_1(Func0::new({
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    move || Documents::closure76(v2, v3, v4, v5, ())
                }))
            } else {
                let v9: char = getCharAt(v0_1.clone(), v1_1);
                if (v9) == '\\' {
                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v9) {
                        ((v2) + (v4), (v3) + 1_i32, 1_i32, v5)
                    } else {
                        (v2, v3, (v4) + 1_i32, v5)
                    };
                    Documents::US19::US19_0(
                        Func0::new({
                            let v9 = v9.clone();
                            move || Documents::closure44(v9, ())
                        }),
                        (v1_1) + 1_i32,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                        patternInput.3.clone(),
                    )
                } else {
                    Documents::US19::US19_1(Func0::new({
                        let v0_1 = v0_1.clone();
                        let v1_1 = v1_1.clone();
                        let v2 = v2.clone();
                        let v3 = v3.clone();
                        let v4 = v4.clone();
                        move || Documents::closure77(v4, v3, v2, v1_1, v0_1.clone(), ())
                    }))
                }
            };
            let v51: Documents::US19 = match &v25 {
                Documents::US19::US19_0(v25_0_0, v25_0_1, v25_0_2, v25_0_3, v25_0_4, v25_0_5) => {
                    let v31: i32 = v25_0_5.clone();
                    let v30: i32 = v25_0_4.clone();
                    let v29: i32 = v25_0_3.clone();
                    let v28: i32 = v25_0_2.clone();
                    let v27: i32 = v25_0_1.clone();
                    if (v27) >= (v31) {
                        Documents::US19::US19_1(Func0::new({
                            let v28 = v28.clone();
                            let v29 = v29.clone();
                            let v30 = v30.clone();
                            let v31 = v31.clone();
                            move || Documents::closure99(v28, v29, v30, v31, ())
                        }))
                    } else {
                        let v35: char = getCharAt(v0_1.clone(), v27);
                        let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v35) {
                            ((v28) + (v30), (v29) + 1_i32, 1_i32, v31)
                        } else {
                            (v28, v29, (v30) + 1_i32, v31)
                        };
                        Documents::US19::US19_0(
                            Func0::new({
                                let v35 = v35.clone();
                                move || Documents::closure100(v35, ())
                            }),
                            (v27) + 1_i32,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                            patternInput_1.3.clone(),
                        )
                    }
                }
                Documents::US19::US19_1(v25_1_0) => Documents::US19::US19_1(v25_1_0.clone()),
            };
            match &v51 {
                Documents::US19::US19_0(v51_0_0, v51_0_1, v51_0_2, v51_0_3, v51_0_4, v51_0_5) => {
                    Documents::US20::US20_0(
                        Func0::new({
                            let v51 = v51.clone();
                            move || {
                                Documents::closure101(
                                    match &v51 {
                                        Documents::US19::US19_0(x, _, _, _, _, _) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    (),
                                )
                            }
                        }),
                        v51_0_1.clone(),
                        v51_0_2.clone(),
                        v51_0_3.clone(),
                        v51_0_4.clone(),
                        v51_0_5.clone(),
                    )
                }
                Documents::US19::US19_1(v51_1_0) => Documents::US20::US20_1(v51_1_0.clone()),
            }
        }
        pub fn closure103(v0_1: Func0<char>, unitVar: ()) -> string {
            append((ofChar('`')), (ofChar(v0_1())))
        }
        pub fn closure102(unitVar: (), _arg: (string, i32, i32, i32, i32, i32)) -> Documents::US20 {
            let v5: i32 = _arg.5.clone();
            let v4: i32 = _arg.4.clone();
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: i32 = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v25: Documents::US19 = if (v1_1) >= (v5) {
                Documents::US19::US19_1(Func0::new({
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    move || Documents::closure80(v2, v3, v4, v5, ())
                }))
            } else {
                let v9: char = getCharAt(v0_1.clone(), v1_1);
                if (v9) == '`' {
                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v9) {
                        ((v2) + (v4), (v3) + 1_i32, 1_i32, v5)
                    } else {
                        (v2, v3, (v4) + 1_i32, v5)
                    };
                    Documents::US19::US19_0(
                        Func0::new({
                            let v9 = v9.clone();
                            move || Documents::closure44(v9, ())
                        }),
                        (v1_1) + 1_i32,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                        patternInput.3.clone(),
                    )
                } else {
                    Documents::US19::US19_1(Func0::new({
                        let v0_1 = v0_1.clone();
                        let v1_1 = v1_1.clone();
                        let v2 = v2.clone();
                        let v3 = v3.clone();
                        let v4 = v4.clone();
                        move || Documents::closure81(v4, v3, v2, v1_1, v0_1.clone(), ())
                    }))
                }
            };
            let v51: Documents::US19 = match &v25 {
                Documents::US19::US19_0(v25_0_0, v25_0_1, v25_0_2, v25_0_3, v25_0_4, v25_0_5) => {
                    let v31: i32 = v25_0_5.clone();
                    let v30: i32 = v25_0_4.clone();
                    let v29: i32 = v25_0_3.clone();
                    let v28: i32 = v25_0_2.clone();
                    let v27: i32 = v25_0_1.clone();
                    if (v27) >= (v31) {
                        Documents::US19::US19_1(Func0::new({
                            let v28 = v28.clone();
                            let v29 = v29.clone();
                            let v30 = v30.clone();
                            let v31 = v31.clone();
                            move || Documents::closure99(v28, v29, v30, v31, ())
                        }))
                    } else {
                        let v35: char = getCharAt(v0_1.clone(), v27);
                        let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v35) {
                            ((v28) + (v30), (v29) + 1_i32, 1_i32, v31)
                        } else {
                            (v28, v29, (v30) + 1_i32, v31)
                        };
                        Documents::US19::US19_0(
                            Func0::new({
                                let v35 = v35.clone();
                                move || Documents::closure100(v35, ())
                            }),
                            (v27) + 1_i32,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                            patternInput_1.3.clone(),
                        )
                    }
                }
                Documents::US19::US19_1(v25_1_0) => Documents::US19::US19_1(v25_1_0.clone()),
            };
            match &v51 {
                Documents::US19::US19_0(v51_0_0, v51_0_1, v51_0_2, v51_0_3, v51_0_4, v51_0_5) => {
                    Documents::US20::US20_0(
                        Func0::new({
                            let v51 = v51.clone();
                            move || {
                                Documents::closure103(
                                    match &v51 {
                                        Documents::US19::US19_0(x, _, _, _, _, _) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                    (),
                                )
                            }
                        }),
                        v51_0_1.clone(),
                        v51_0_2.clone(),
                        v51_0_3.clone(),
                        v51_0_4.clone(),
                        v51_0_5.clone(),
                    )
                }
                Documents::US19::US19_1(v51_1_0) => Documents::US20::US20_1(v51_1_0.clone()),
            }
        }
        pub fn method149(
            v0_1: string,
            v1_1: Func0<string>,
            v2: LrcPtr<Documents::UH2>,
            v3: i32,
            v4: i32,
            v5: i32,
            v6: i32,
            v7: i32,
            v8: i32,
        ) -> Documents::US20 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1 = LrcPtr::new(MutCell::new(v1_1.clone()));
            let v2: LrcPtr<MutCell<LrcPtr<Documents::UH2>>> = LrcPtr::new(MutCell::new(v2.clone()));
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v5));
            let v6: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v6));
            let v7: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v7));
            let v8: MutCell<i32> = MutCell::new(v8);
            '_method149: loop {
                break '_method149 (if (v4.get().clone()) <= 0_i32 {
                    Documents::US20::US20_1(Func0::new(move || Documents::closure93((), ())))
                } else {
                    let v33: Documents::US19 = if (v3.get().clone()) >= (v8.get().clone()) {
                        Documents::US19::US19_1(Func0::new({
                            let v5 = v5.clone();
                            let v6 = v6.clone();
                            let v7 = v7.clone();
                            let v8 = v8.clone();
                            move || {
                                Documents::closure82(
                                    v5.get().clone(),
                                    v6.get().clone(),
                                    v7.get().clone(),
                                    v8.get().clone(),
                                    (),
                                )
                            }
                        }))
                    } else {
                        let v15: char = getCharAt(v0_1.get().clone(), v3.get().clone());
                        if (Documents::method142(v15, 0_i64)) == false {
                            let patternInput: (i32, i32, i32, i32) = if '\n' == (v15) {
                                (
                                    (v5.get().clone()) + (v7.get().clone()),
                                    (v6.get().clone()) + 1_i32,
                                    1_i32,
                                    v8.get().clone(),
                                )
                            } else {
                                (
                                    v5.get().clone(),
                                    v6.get().clone(),
                                    (v7.get().clone()) + 1_i32,
                                    v8.get().clone(),
                                )
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v15 = v15.clone();
                                    move || Documents::closure52(v15, ())
                                }),
                                (v3.get().clone()) + 1_i32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                                patternInput.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v15 = v15.clone();
                                let v5 = v5.clone();
                                let v6 = v6.clone();
                                let v7 = v7.clone();
                                let v8 = v8.clone();
                                move || {
                                    Documents::closure83(
                                        v5.get().clone(),
                                        v6.get().clone(),
                                        v7.get().clone(),
                                        v8.get().clone(),
                                        v15,
                                        (),
                                    )
                                }
                            }))
                        }
                    };
                    let v45: Documents::US20 = match &v33 {
                        Documents::US19::US19_0(
                            v33_0_0,
                            v33_0_1,
                            v33_0_2,
                            v33_0_3,
                            v33_0_4,
                            v33_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new({
                                let v33 = v33.clone();
                                move || {
                                    Documents::closure84(
                                        match &v33 {
                                            Documents::US19::US19_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v33_0_1.clone(),
                            v33_0_2.clone(),
                            v33_0_3.clone(),
                            v33_0_4.clone(),
                            v33_0_5.clone(),
                        ),
                        Documents::US19::US19_1(v33_1_0) => {
                            Documents::US20::US20_1(v33_1_0.clone())
                        }
                    };
                    let v60: Documents::US20 = match &v45 {
                        Documents::US20::US20_0(
                            v45_0_0,
                            v45_0_1,
                            v45_0_2,
                            v45_0_3,
                            v45_0_4,
                            v45_0_5,
                        ) => v45.clone(),
                        _ => Documents::method144(
                            v5.get().clone(),
                            v6.get().clone(),
                            v7.get().clone(),
                            v8.get().clone(),
                            v3.get().clone(),
                            v0_1.get().clone(),
                            LrcPtr::new(Documents::UH1::UH1_1(
                                Func1::new(
                                    move |arg10_0040_5: (string, i32, i32, i32, i32, i32)| {
                                        Documents::closure98((), arg10_0040_5)
                                    },
                                ),
                                LrcPtr::new(Documents::UH1::UH1_1(
                                    Func1::new(
                                        move |arg10_0040_6: (string, i32, i32, i32, i32, i32)| {
                                            Documents::closure102((), arg10_0040_6)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH1::UH1_0),
                                )),
                            )),
                        ),
                    };
                    match &v60 {
                        Documents::US20::US20_0(
                            v60_0_0,
                            v60_0_1,
                            v60_0_2,
                            v60_0_3,
                            v60_0_4,
                            v60_0_5,
                        ) => {
                            let v62: i32 = v60_0_1.clone();
                            if (v62) == (v3.get().clone()) {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure95((), ())
                                }))
                            } else {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                    Documents::UH2::UH2_1((v60_0_0)(), v2.get().clone()),
                                );
                                let v3_temp: i32 = v62;
                                let v4_temp: i32 = (v4.get().clone()) - 1_i32;
                                let v5_temp: i32 = v60_0_2.clone();
                                let v6_temp: i32 = v60_0_3.clone();
                                let v7_temp: i32 = v60_0_4.clone();
                                let v8_temp: i32 = v60_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                v7.set(v7_temp);
                                v8.set(v8_temp);
                                continue '_method149;
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new({
                                let v1_1 = v1_1.clone();
                                let v2 = v2.clone();
                                move || {
                                    Documents::closure94(v1_1.get().clone(), v2.get().clone(), ())
                                }
                            }),
                            v3.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            v7.get().clone(),
                            v8.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure104(v0_1: i32, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected end of input / "),
                (Documents::method121(
                    Documents::method120(toArray_1(ofArray(new_array(&['\\', '`', '\"', ' '])))),
                    0_i32,
                    1_i32,
                    1_i32,
                    v0_1,
                )),
            )
        }
        pub fn method150(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method150: loop {
                break '_method150 (if (v1_1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Documents::US8 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US8::US8_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US8::US8_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US8::US8_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Documents::US8::US8_0(' ')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Documents::US8::US8_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Documents::US8::US8_0(v19_0_0) => match &v19 {
                                Documents::US8::US8_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        })
                    {
                        true
                    } else {
                        let v0_1_temp: char = v0_1.get().clone();
                        let v1_1_temp: i64 = (v1_1.get().clone()) + 1_i64;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method150;
                    }
                });
            }
        }
        pub fn closure105(v0_1: i32, v1_1: char, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected char / "),
                (Documents::method125(
                    v1_1,
                    Documents::method120(toArray_1(ofArray(new_array(&['\\', '`', '\"', ' '])))),
                    0_i32,
                    1_i32,
                    1_i32,
                    v0_1,
                )),
            )
        }
        pub fn closure106(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected end of input / "),
                (Documents::method121(
                    Documents::method120(toArray_1(ofArray(new_array(&['\\', '`', '\"', ' '])))),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                )),
            )
        }
        pub fn closure107(v0_1: i32, v1_1: i32, v2: i32, v3: i32, v4: char, unitVar: ()) -> string {
            append(
                string("parsing.none_of / unexpected char / "),
                (Documents::method125(
                    v4,
                    Documents::method120(toArray_1(ofArray(new_array(&['\\', '`', '\"', ' '])))),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                )),
            )
        }
        pub fn method151(
            v0_1: string,
            v1_1: i32,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: i32,
        ) -> Documents::US20 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v2));
            let v3: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v3));
            let v4: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v4));
            let v5: MutCell<i32> = MutCell::new(v5);
            '_method151: loop {
                break '_method151 ({
                    let v27: Documents::US19 = if (v1_1.get().clone()) >= (v5.get().clone()) {
                        Documents::US19::US19_1(Func0::new({
                            let v2 = v2.clone();
                            let v3 = v3.clone();
                            let v4 = v4.clone();
                            let v5 = v5.clone();
                            move || {
                                Documents::closure106(
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    v5.get().clone(),
                                    (),
                                )
                            }
                        }))
                    } else {
                        let v9: char = getCharAt(v0_1.get().clone(), v1_1.get().clone());
                        if (Documents::method150(v9, 0_i64)) == false {
                            let patternInput: (i32, i32, i32, i32) = if '\n' == (v9) {
                                (
                                    (v2.get().clone()) + (v4.get().clone()),
                                    (v3.get().clone()) + 1_i32,
                                    1_i32,
                                    v5.get().clone(),
                                )
                            } else {
                                (
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    (v4.get().clone()) + 1_i32,
                                    v5.get().clone(),
                                )
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v9 = v9.clone();
                                    move || Documents::closure52(v9, ())
                                }),
                                (v1_1.get().clone()) + 1_i32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                                patternInput.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v2 = v2.clone();
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                let v9 = v9.clone();
                                move || {
                                    Documents::closure107(
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                        v5.get().clone(),
                                        v9,
                                        (),
                                    )
                                }
                            }))
                        }
                    };
                    match &v27 {
                        Documents::US19::US19_0(
                            v27_0_0,
                            v27_0_1,
                            v27_0_2,
                            v27_0_3,
                            v27_0_4,
                            v27_0_5,
                        ) => {
                            let v29: i32 = v27_0_1.clone();
                            if (v29) == (v1_1.get().clone()) {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure55((), ())
                                }))
                            } else {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: i32 = v29;
                                let v2_temp: i32 = v27_0_2.clone();
                                let v3_temp: i32 = v27_0_3.clone();
                                let v4_temp: i32 = v27_0_4.clone();
                                let v5_temp: i32 = v27_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                continue '_method151;
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v1_1 = v1_1.clone();
                                move || {
                                    Documents::closure65(v0_1.get().clone(), v1_1.get().clone(), ())
                                }
                            }),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure108(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.many / out of fuel (probable zero-length loop)")
        }
        pub fn closure109(v0_1: LrcPtr<Documents::UH2>, unitVar: ()) -> LrcPtr<Documents::UH2> {
            Documents::method146(v0_1, LrcPtr::new(Documents::UH2::UH2_0))
        }
        pub fn closure110(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.many / inner parser succeeded without consuming input")
        }
        pub fn method152(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH2>,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: i32,
            v6: i32,
            v7: i32,
        ) -> Documents::US29 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: LrcPtr<MutCell<LrcPtr<Documents::UH2>>> =
                LrcPtr::new(MutCell::new(v1_1.clone()));
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: MutCell<i32> = MutCell::new(v5);
            let v6: MutCell<i32> = MutCell::new(v6);
            let v7: MutCell<i32> = MutCell::new(v7);
            '_method152: loop {
                break '_method152 (if (v3.get().clone()) <= 0_i32 {
                    Documents::US29::US29_1(Func0::new(move || Documents::closure108((), ())))
                } else {
                    let v16: Documents::US20 = Documents::method144(
                        v4.get().clone(),
                        v5.get().clone(),
                        v6.get().clone(),
                        v7.get().clone(),
                        v2.get().clone(),
                        v0_1.get().clone(),
                        LrcPtr::new(Documents::UH1::UH1_1(
                            Func1::new(move |arg10_0040_1: (string, i32, i32, i32, i32, i32)| {
                                Documents::closure98((), arg10_0040_1)
                            }),
                            LrcPtr::new(Documents::UH1::UH1_1(
                                Func1::new(
                                    move |arg10_0040_2: (string, i32, i32, i32, i32, i32)| {
                                        Documents::closure102((), arg10_0040_2)
                                    },
                                ),
                                LrcPtr::new(Documents::UH1::UH1_0),
                            )),
                        )),
                    );
                    let v28: Documents::US20 = match &v16 {
                        Documents::US20::US20_0(
                            v16_0_0,
                            v16_0_1,
                            v16_0_2,
                            v16_0_3,
                            v16_0_4,
                            v16_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new(move || Documents::closure68((), ())),
                            v16_0_1.clone(),
                            v16_0_2.clone(),
                            v16_0_3.clone(),
                            v16_0_4.clone(),
                            v16_0_5.clone(),
                        ),
                        Documents::US20::US20_1(v16_1_0) => {
                            Documents::US20::US20_1(v16_1_0.clone())
                        }
                    };
                    let v72: Documents::US20 = match &v28 {
                        Documents::US20::US20_0(
                            v28_0_0,
                            v28_0_1,
                            v28_0_2,
                            v28_0_3,
                            v28_0_4,
                            v28_0_5,
                        ) => {
                            let v34: i32 = v28_0_5.clone();
                            let v33: i32 = v28_0_4.clone();
                            let v32: i32 = v28_0_3.clone();
                            let v31: i32 = v28_0_2.clone();
                            let v30: i32 = v28_0_1.clone();
                            let v56: Documents::US19 = if (v30) >= (v34) {
                                Documents::US19::US19_1(Func0::new({
                                    let v31 = v31.clone();
                                    let v32 = v32.clone();
                                    let v33 = v33.clone();
                                    let v34 = v34.clone();
                                    move || Documents::closure82(v31, v32, v33, v34, ())
                                }))
                            } else {
                                let v38: char = getCharAt(v0_1.get().clone(), v30);
                                if (Documents::method142(v38, 0_i64)) == false {
                                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v38) {
                                        ((v31) + (v33), (v32) + 1_i32, 1_i32, v34)
                                    } else {
                                        (v31, v32, (v33) + 1_i32, v34)
                                    };
                                    Documents::US19::US19_0(
                                        Func0::new({
                                            let v38 = v38.clone();
                                            move || Documents::closure52(v38, ())
                                        }),
                                        (v30) + 1_i32,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                        patternInput.3.clone(),
                                    )
                                } else {
                                    Documents::US19::US19_1(Func0::new({
                                        let v31 = v31.clone();
                                        let v32 = v32.clone();
                                        let v33 = v33.clone();
                                        let v34 = v34.clone();
                                        let v38 = v38.clone();
                                        move || Documents::closure83(v31, v32, v33, v34, v38, ())
                                    }))
                                }
                            };
                            match &v56 {
                                Documents::US19::US19_0(
                                    v56_0_0,
                                    v56_0_1,
                                    v56_0_2,
                                    v56_0_3,
                                    v56_0_4,
                                    v56_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new({
                                        let v56 = v56.clone();
                                        move || {
                                            Documents::closure84(
                                                match &v56 {
                                                    Documents::US19::US19_0(x, _, _, _, _, _) => {
                                                        x.clone()
                                                    }
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                                (),
                                            )
                                        }
                                    }),
                                    v56_0_1.clone(),
                                    v56_0_2.clone(),
                                    v56_0_3.clone(),
                                    v56_0_4.clone(),
                                    v56_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v56_1_0) => {
                                    Documents::US20::US20_1(v56_1_0.clone())
                                }
                            }
                        }
                        Documents::US20::US20_1(v28_1_0) => {
                            Documents::US20::US20_1(v28_1_0.clone())
                        }
                    };
                    match &v72 {
                        Documents::US20::US20_0(
                            v72_0_0,
                            v72_0_1,
                            v72_0_2,
                            v72_0_3,
                            v72_0_4,
                            v72_0_5,
                        ) => {
                            let v74: i32 = v72_0_1.clone();
                            if (v74) == (v2.get().clone()) {
                                Documents::US29::US29_1(Func0::new(move || {
                                    Documents::closure110((), ())
                                }))
                            } else {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                    Documents::UH2::UH2_1((v72_0_0)(), v1_1.get().clone()),
                                );
                                let v2_temp: i32 = v74;
                                let v3_temp: i32 = (v3.get().clone()) - 1_i32;
                                let v4_temp: i32 = v72_0_2.clone();
                                let v5_temp: i32 = v72_0_3.clone();
                                let v6_temp: i32 = v72_0_4.clone();
                                let v7_temp: i32 = v72_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                v7.set(v7_temp);
                                continue '_method152;
                            }
                        }
                        _ => Documents::US29::US29_0(
                            Func0::new({
                                let v1_1 = v1_1.clone();
                                move || Documents::closure109(v1_1.get().clone(), ())
                            }),
                            v2.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            v7.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure111(v0_1: Func0<LrcPtr<Documents::UH2>>, unitVar: ()) -> string {
            (Documents::method147(v0_1(), string(""))).0.clone()
        }
        pub fn closure112(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.split_args / segment zero-length success")
        }
        pub fn closure113(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.many1_strings / out of fuel (probable zero-length loop)")
        }
        pub fn method154(
            v0_1: i32,
            v1_1: string,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: i32,
            v6: i32,
        ) -> Documents::US20 {
            let v0_1: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v0_1));
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v3));
            let v4: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v4));
            let v5: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v5));
            let v6: MutCell<i32> = MutCell::new(v6);
            '_method154: loop {
                break '_method154 ({
                    let v28: Documents::US19 = if (v2.get().clone()) >= (v6.get().clone()) {
                        Documents::US19::US19_1(Func0::new({
                            let v3 = v3.clone();
                            let v4 = v4.clone();
                            let v5 = v5.clone();
                            let v6 = v6.clone();
                            move || {
                                Documents::closure106(
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    v5.get().clone(),
                                    v6.get().clone(),
                                    (),
                                )
                            }
                        }))
                    } else {
                        let v10: char = getCharAt(v1_1.get().clone(), v2.get().clone());
                        if (Documents::method150(v10, 0_i64)) == false {
                            let patternInput: (i32, i32, i32, i32) = if '\n' == (v10) {
                                (
                                    (v3.get().clone()) + (v5.get().clone()),
                                    (v4.get().clone()) + 1_i32,
                                    1_i32,
                                    v6.get().clone(),
                                )
                            } else {
                                (
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    (v5.get().clone()) + 1_i32,
                                    v6.get().clone(),
                                )
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v10 = v10.clone();
                                    move || Documents::closure52(v10, ())
                                }),
                                (v2.get().clone()) + 1_i32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                                patternInput.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v10 = v10.clone();
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                let v6 = v6.clone();
                                move || {
                                    Documents::closure107(
                                        v3.get().clone(),
                                        v4.get().clone(),
                                        v5.get().clone(),
                                        v6.get().clone(),
                                        v10,
                                        (),
                                    )
                                }
                            }))
                        }
                    };
                    match &v28 {
                        Documents::US19::US19_0(
                            v28_0_0,
                            v28_0_1,
                            v28_0_2,
                            v28_0_3,
                            v28_0_4,
                            v28_0_5,
                        ) => {
                            let v30: i32 = v28_0_1.clone();
                            if (v30) == (v2.get().clone()) {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure55((), ())
                                }))
                            } else {
                                let v0_1_temp: i32 = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: i32 = v30;
                                let v3_temp: i32 = v28_0_2.clone();
                                let v4_temp: i32 = v28_0_3.clone();
                                let v5_temp: i32 = v28_0_4.clone();
                                let v6_temp: i32 = v28_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                continue '_method154;
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new({
                                let v0_1 = v0_1.clone();
                                let v1_1 = v1_1.clone();
                                let v2 = v2.clone();
                                move || {
                                    Documents::closure54(
                                        v0_1.get().clone(),
                                        v1_1.get().clone(),
                                        v2.get().clone(),
                                        (),
                                    )
                                }
                            }),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure114(v0_1: LrcPtr<Documents::UH2>, unitVar: ()) -> string {
            (Documents::method147(
                Documents::method146(v0_1, LrcPtr::new(Documents::UH2::UH2_0)),
                string(""),
            ))
            .0
            .clone()
        }
        pub fn closure115(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.many1_strings / inner parser succeeded without consuming input")
        }
        pub fn method153(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH2>,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: i32,
            v6: i32,
            v7: i32,
        ) -> Documents::US20 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: LrcPtr<MutCell<LrcPtr<Documents::UH2>>> =
                LrcPtr::new(MutCell::new(v1_1.clone()));
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: MutCell<i32> = MutCell::new(v5);
            let v6: MutCell<i32> = MutCell::new(v6);
            let v7: MutCell<i32> = MutCell::new(v7);
            '_method153: loop {
                break '_method153 (if (v3.get().clone()) <= 0_i32 {
                    Documents::US20::US20_1(Func0::new(move || Documents::closure113((), ())))
                } else {
                    fn v11(arg10_0040_1: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
                        Documents::closure75((), arg10_0040_1)
                    }
                    fn v12(arg10_0040_2: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
                        Documents::closure79((), arg10_0040_2)
                    }
                    let v16: Documents::US19 = Documents::method128(
                        v4.get().clone(),
                        v5.get().clone(),
                        v6.get().clone(),
                        v7.get().clone(),
                        v2.get().clone(),
                        v0_1.get().clone(),
                        LrcPtr::new(Documents::UH0::UH0_1(
                            Func1::from(v11),
                            LrcPtr::new(Documents::UH0::UH0_1(
                                Func1::from(v12),
                                LrcPtr::new(Documents::UH0::UH0_0),
                            )),
                        )),
                    );
                    let v136: Documents::US20 = match &v16 {
                        Documents::US19::US19_0(
                            v16_0_0,
                            v16_0_1,
                            v16_0_2,
                            v16_0_3,
                            v16_0_4,
                            v16_0_5,
                        ) => {
                            let v22: i32 = v16_0_5.clone();
                            let v21: i32 = v16_0_4.clone();
                            let v20: i32 = v16_0_3.clone();
                            let v19: i32 = v16_0_2.clone();
                            let v18: i32 = v16_0_1.clone();
                            let v44: Documents::US19 = if (v18) >= (v22) {
                                Documents::US19::US19_1(Func0::new({
                                    let v19 = v19.clone();
                                    let v20 = v20.clone();
                                    let v21 = v21.clone();
                                    let v22 = v22.clone();
                                    move || Documents::closure82(v19, v20, v21, v22, ())
                                }))
                            } else {
                                let v26: char = getCharAt(v0_1.get().clone(), v18);
                                if (Documents::method142(v26, 0_i64)) == false {
                                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v26) {
                                        ((v19) + (v21), (v20) + 1_i32, 1_i32, v22)
                                    } else {
                                        (v19, v20, (v21) + 1_i32, v22)
                                    };
                                    Documents::US19::US19_0(
                                        Func0::new({
                                            let v26 = v26.clone();
                                            move || Documents::closure52(v26, ())
                                        }),
                                        (v18) + 1_i32,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                        patternInput.3.clone(),
                                    )
                                } else {
                                    Documents::US19::US19_1(Func0::new({
                                        let v19 = v19.clone();
                                        let v20 = v20.clone();
                                        let v21 = v21.clone();
                                        let v22 = v22.clone();
                                        let v26 = v26.clone();
                                        move || Documents::closure83(v19, v20, v21, v22, v26, ())
                                    }))
                                }
                            };
                            let v56: Documents::US20 = match &v44 {
                                Documents::US19::US19_0(
                                    v44_0_0,
                                    v44_0_1,
                                    v44_0_2,
                                    v44_0_3,
                                    v44_0_4,
                                    v44_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new({
                                        let v44 = v44.clone();
                                        move || {
                                            Documents::closure84(
                                                match &v44 {
                                                    Documents::US19::US19_0(x, _, _, _, _, _) => {
                                                        x.clone()
                                                    }
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                                (),
                                            )
                                        }
                                    }),
                                    v44_0_1.clone(),
                                    v44_0_2.clone(),
                                    v44_0_3.clone(),
                                    v44_0_4.clone(),
                                    v44_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v44_1_0) => {
                                    Documents::US20::US20_1(v44_1_0.clone())
                                }
                            };
                            let v71: Documents::US20 = match &v56 {
                                Documents::US20::US20_0(
                                    v56_0_0,
                                    v56_0_1,
                                    v56_0_2,
                                    v56_0_3,
                                    v56_0_4,
                                    v56_0_5,
                                ) => v56.clone(),
                                _ => Documents::method144(
                                    v19,
                                    v20,
                                    v21,
                                    v22,
                                    v18,
                                    v0_1.get().clone(),
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::new(
                                            move |arg10_0040_7: (
                                                string,
                                                i32,
                                                i32,
                                                i32,
                                                i32,
                                                i32,
                                            )| {
                                                Documents::closure85((), arg10_0040_7)
                                            },
                                        ),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            Func1::new(
                                                move |arg10_0040_8: (
                                                    string,
                                                    i32,
                                                    i32,
                                                    i32,
                                                    i32,
                                                    i32,
                                                )| {
                                                    Documents::closure89((), arg10_0040_8)
                                                },
                                            ),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                ),
                            };
                            let v90: Documents::US20 = match &v71 {
                                Documents::US20::US20_0(
                                    v71_0_0,
                                    v71_0_1,
                                    v71_0_2,
                                    v71_0_3,
                                    v71_0_4,
                                    v71_0_5,
                                ) => {
                                    let v76: i32 = v71_0_1.clone();
                                    if (v76) == (v18) {
                                        Documents::US20::US20_1(Func0::new(move || {
                                            Documents::closure92((), ())
                                        }))
                                    } else {
                                        Documents::method145(
                                            v0_1.get().clone(),
                                            v71_0_0.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v76,
                                            ((v22) - (v76)) + 2_i32,
                                            v71_0_2.clone(),
                                            v71_0_3.clone(),
                                            v71_0_4.clone(),
                                            v71_0_5.clone(),
                                        )
                                    }
                                }
                                _ => Documents::US20::US20_0(
                                    Func0::new(move || Documents::closure91((), ())),
                                    v18,
                                    v19,
                                    v20,
                                    v21,
                                    v22,
                                ),
                            };
                            match &v90 {
                                Documents::US20::US20_0(
                                    v90_0_0,
                                    v90_0_1,
                                    v90_0_2,
                                    v90_0_3,
                                    v90_0_4,
                                    v90_0_5,
                                ) => {
                                    let v92: i32 = v90_0_1.clone();
                                    let v100: Documents::US19 = Documents::method128(
                                        v90_0_2.clone(),
                                        v90_0_3.clone(),
                                        v90_0_4.clone(),
                                        v90_0_5.clone(),
                                        v92,
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH0::UH0_1(
                                            Func1::from(v11),
                                            LrcPtr::new(Documents::UH0::UH0_1(
                                                Func1::from(v12),
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            )),
                                        )),
                                    );
                                    match &v100 {
                                        Documents::US19::US19_0(
                                            v100_0_0,
                                            v100_0_1,
                                            v100_0_2,
                                            v100_0_3,
                                            v100_0_4,
                                            v100_0_5,
                                        ) => Documents::US20::US20_0(
                                            v90_0_0.clone(),
                                            v100_0_1.clone(),
                                            v100_0_2.clone(),
                                            v100_0_3.clone(),
                                            v100_0_4.clone(),
                                            v100_0_5.clone(),
                                        ),
                                        Documents::US19::US19_1(v100_1_0) => {
                                            Documents::US20::US20_1(Func0::new({
                                                let v0_1 = v0_1.clone();
                                                let v100 = v100.clone();
                                                let v18 = v18.clone();
                                                let v92 = v92.clone();
                                                move || {
                                                    Documents::closure59(
                                                        v0_1.get().clone(),
                                                        v18,
                                                        v92,
                                                        match &v100 {
                                                            Documents::US19::US19_1(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                        (),
                                                    )
                                                }
                                            }))
                                        }
                                    }
                                }
                                _ => {
                                    let v117: Documents::US19 = Documents::method128(
                                        v19,
                                        v20,
                                        v21,
                                        v22,
                                        v18,
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH0::UH0_1(
                                            Func1::from(v11),
                                            LrcPtr::new(Documents::UH0::UH0_1(
                                                Func1::from(v12),
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            )),
                                        )),
                                    );
                                    match &v117 {
                                        Documents::US19::US19_0(
                                            v117_0_0,
                                            v117_0_1,
                                            v117_0_2,
                                            v117_0_3,
                                            v117_0_4,
                                            v117_0_5,
                                        ) => Documents::US20::US20_0(
                                            Func0::new(move || Documents::closure58((), ())),
                                            v117_0_1.clone(),
                                            v117_0_2.clone(),
                                            v117_0_3.clone(),
                                            v117_0_4.clone(),
                                            v117_0_5.clone(),
                                        ),
                                        _ => Documents::US20::US20_1(Func0::new({
                                            let v0_1 = v0_1.clone();
                                            let v18 = v18.clone();
                                            move || {
                                                Documents::closure57(v0_1.get().clone(), v18, ())
                                            }
                                        })),
                                    }
                                }
                            }
                        }
                        Documents::US19::US19_1(v16_1_0) => {
                            Documents::US20::US20_1(v16_1_0.clone())
                        }
                    };
                    let v316: Documents::US20 = match &v136 {
                        Documents::US20::US20_0(
                            v136_0_0,
                            v136_0_1,
                            v136_0_2,
                            v136_0_3,
                            v136_0_4,
                            v136_0_5,
                        ) => v136.clone(),
                        _ => {
                            let v163: Documents::US19 = if (v2.get().clone()) >= (v7.get().clone())
                            {
                                Documents::US19::US19_1(Func0::new({
                                    let v4 = v4.clone();
                                    let v5 = v5.clone();
                                    let v6 = v6.clone();
                                    let v7 = v7.clone();
                                    move || {
                                        Documents::closure43(
                                            v4.get().clone(),
                                            v5.get().clone(),
                                            v6.get().clone(),
                                            v7.get().clone(),
                                            (),
                                        )
                                    }
                                }))
                            } else {
                                let v147: char = getCharAt(v0_1.get().clone(), v2.get().clone());
                                if (v147) == '\"' {
                                    let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v147) {
                                        (
                                            (v4.get().clone()) + (v6.get().clone()),
                                            (v5.get().clone()) + 1_i32,
                                            1_i32,
                                            v7.get().clone(),
                                        )
                                    } else {
                                        (
                                            v4.get().clone(),
                                            v5.get().clone(),
                                            (v6.get().clone()) + 1_i32,
                                            v7.get().clone(),
                                        )
                                    };
                                    Documents::US19::US19_0(
                                        Func0::new({
                                            let v147 = v147.clone();
                                            move || Documents::closure44(v147, ())
                                        }),
                                        (v2.get().clone()) + 1_i32,
                                        patternInput_1.0.clone(),
                                        patternInput_1.1.clone(),
                                        patternInput_1.2.clone(),
                                        patternInput_1.3.clone(),
                                    )
                                } else {
                                    Documents::US19::US19_1(Func0::new({
                                        let v0_1 = v0_1.clone();
                                        let v2 = v2.clone();
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        let v6 = v6.clone();
                                        move || {
                                            Documents::closure45(
                                                v6.get().clone(),
                                                v5.get().clone(),
                                                v4.get().clone(),
                                                v2.get().clone(),
                                                v0_1.get().clone(),
                                                (),
                                            )
                                        }
                                    }))
                                }
                            };
                            match &v163 {
                                Documents::US19::US19_0(
                                    v163_0_0,
                                    v163_0_1,
                                    v163_0_2,
                                    v163_0_3,
                                    v163_0_4,
                                    v163_0_5,
                                ) => {
                                    let v169: i32 = v163_0_5.clone();
                                    let v168: i32 = v163_0_4.clone();
                                    let v167: i32 = v163_0_3.clone();
                                    let v166: i32 = v163_0_2.clone();
                                    let v165: i32 = v163_0_1.clone();
                                    let v170: bool = (v165) >= (v169);
                                    let v191: Documents::US19 = if v170 {
                                        Documents::US19::US19_1(Func0::new({
                                            let v166 = v166.clone();
                                            let v167 = v167.clone();
                                            let v168 = v168.clone();
                                            let v169 = v169.clone();
                                            move || Documents::closure82(v166, v167, v168, v169, ())
                                        }))
                                    } else {
                                        let v173: char = getCharAt(v0_1.get().clone(), v165);
                                        if (Documents::method142(v173, 0_i64)) == false {
                                            let patternInput_2: (i32, i32, i32, i32) =
                                                if '\n' == (v173) {
                                                    ((v166) + (v168), (v167) + 1_i32, 1_i32, v169)
                                                } else {
                                                    (v166, v167, (v168) + 1_i32, v169)
                                                };
                                            Documents::US19::US19_0(
                                                Func0::new({
                                                    let v173 = v173.clone();
                                                    move || Documents::closure52(v173, ())
                                                }),
                                                (v165) + 1_i32,
                                                patternInput_2.0.clone(),
                                                patternInput_2.1.clone(),
                                                patternInput_2.2.clone(),
                                                patternInput_2.3.clone(),
                                            )
                                        } else {
                                            Documents::US19::US19_1(Func0::new({
                                                let v166 = v166.clone();
                                                let v167 = v167.clone();
                                                let v168 = v168.clone();
                                                let v169 = v169.clone();
                                                let v173 = v173.clone();
                                                move || {
                                                    Documents::closure83(
                                                        v166,
                                                        v167,
                                                        v168,
                                                        v169,
                                                        v173,
                                                        (),
                                                    )
                                                }
                                            }))
                                        }
                                    };
                                    let v203: Documents::US20 = match &v191 {
                                        Documents::US19::US19_0(
                                            v191_0_0,
                                            v191_0_1,
                                            v191_0_2,
                                            v191_0_3,
                                            v191_0_4,
                                            v191_0_5,
                                        ) => Documents::US20::US20_0(
                                            Func0::new({
                                                let v191 = v191.clone();
                                                move || {
                                                    Documents::closure84(
                                                        match &v191 {
                                                            Documents::US19::US19_0(
                                                                x,
                                                                _,
                                                                _,
                                                                _,
                                                                _,
                                                                _,
                                                            ) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                        (),
                                                    )
                                                }
                                            }),
                                            v191_0_1.clone(),
                                            v191_0_2.clone(),
                                            v191_0_3.clone(),
                                            v191_0_4.clone(),
                                            v191_0_5.clone(),
                                        ),
                                        Documents::US19::US19_1(v191_1_0) => {
                                            Documents::US20::US20_1(v191_1_0.clone())
                                        }
                                    };
                                    let v218: Documents::US20 =
                                                     match &v203 {
                                                         Documents::US20::US20_0(v203_0_0,
                                                                                 v203_0_1,
                                                                                 v203_0_2,
                                                                                 v203_0_3,
                                                                                 v203_0_4,
                                                                                 v203_0_5)
                                                         => v203.clone(),
                                                         _ =>
                                                         Documents::method144(v166,
                                                                              v167,
                                                                              v168,
                                                                              v169,
                                                                              v165,
                                                                              v0_1.get().clone(),
                                                                              LrcPtr::new(Documents::UH1::UH1_1(Func1::new(move
                                                                                                                               |arg10_0040_21:
                                                                                                                                    (string,
                                                                                                                                     i32,
                                                                                                                                     i32,
                                                                                                                                     i32,
                                                                                                                                     i32,
                                                                                                                                     i32)|
                                                                                                                               Documents::closure98((),
                                                                                                                                                    arg10_0040_21)),
                                                                                                                LrcPtr::new(Documents::UH1::UH1_1(Func1::new(move
                                                                                                                                                                 |arg10_0040_22:
                                                                                                                                                                      (string,
                                                                                                                                                                       i32,
                                                                                                                                                                       i32,
                                                                                                                                                                       i32,
                                                                                                                                                                       i32,
                                                                                                                                                                       i32)|
                                                                                                                                                                 Documents::closure102((),
                                                                                                                                                                                       arg10_0040_22)),
                                                                                                                                                  LrcPtr::new(Documents::UH1::UH1_0)))))),
                                                     };
                                    let v237: Documents::US20 = match &v218 {
                                        Documents::US20::US20_0(
                                            v218_0_0,
                                            v218_0_1,
                                            v218_0_2,
                                            v218_0_3,
                                            v218_0_4,
                                            v218_0_5,
                                        ) => {
                                            let v223: i32 = v218_0_1.clone();
                                            if (v223) == (v165) {
                                                Documents::US20::US20_1(Func0::new(move || {
                                                    Documents::closure92((), ())
                                                }))
                                            } else {
                                                Documents::method149(
                                                    v0_1.get().clone(),
                                                    v218_0_0.clone(),
                                                    LrcPtr::new(Documents::UH2::UH2_0),
                                                    v223,
                                                    ((v169) - (v223)) + 2_i32,
                                                    v218_0_2.clone(),
                                                    v218_0_3.clone(),
                                                    v218_0_4.clone(),
                                                    v218_0_5.clone(),
                                                )
                                            }
                                        }
                                        _ => Documents::US20::US20_0(
                                            Func0::new(move || Documents::closure91((), ())),
                                            v165,
                                            v166,
                                            v167,
                                            v168,
                                            v169,
                                        ),
                                    };
                                    match &v237 {
                                        Documents::US20::US20_0(
                                            v237_0_0,
                                            v237_0_1,
                                            v237_0_2,
                                            v237_0_3,
                                            v237_0_4,
                                            v237_0_5,
                                        ) => {
                                            let v243: i32 = v237_0_5.clone();
                                            let v242: i32 = v237_0_4.clone();
                                            let v241: i32 = v237_0_3.clone();
                                            let v240: i32 = v237_0_2.clone();
                                            let v239: i32 = v237_0_1.clone();
                                            let v263: Documents::US19 = if (v239) >= (v243) {
                                                Documents::US19::US19_1(Func0::new({
                                                    let v240 = v240.clone();
                                                    let v241 = v241.clone();
                                                    let v242 = v242.clone();
                                                    let v243 = v243.clone();
                                                    move || {
                                                        Documents::closure43(
                                                            v240,
                                                            v241,
                                                            v242,
                                                            v243,
                                                            (),
                                                        )
                                                    }
                                                }))
                                            } else {
                                                let v247: char =
                                                    getCharAt(v0_1.get().clone(), v239);
                                                if (v247) == '\"' {
                                                    let patternInput_4: (i32, i32, i32, i32) =
                                                        if '\n' == (v247) {
                                                            (
                                                                (v240) + (v242),
                                                                (v241) + 1_i32,
                                                                1_i32,
                                                                v243,
                                                            )
                                                        } else {
                                                            (v240, v241, (v242) + 1_i32, v243)
                                                        };
                                                    Documents::US19::US19_0(
                                                        Func0::new({
                                                            let v247 = v247.clone();
                                                            move || Documents::closure44(v247, ())
                                                        }),
                                                        (v239) + 1_i32,
                                                        patternInput_4.0.clone(),
                                                        patternInput_4.1.clone(),
                                                        patternInput_4.2.clone(),
                                                        patternInput_4.3.clone(),
                                                    )
                                                } else {
                                                    Documents::US19::US19_1(Func0::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v239 = v239.clone();
                                                        let v240 = v240.clone();
                                                        let v241 = v241.clone();
                                                        let v242 = v242.clone();
                                                        move || {
                                                            Documents::closure45(
                                                                v242,
                                                                v241,
                                                                v240,
                                                                v239,
                                                                v0_1.get().clone(),
                                                                (),
                                                            )
                                                        }
                                                    }))
                                                }
                                            };
                                            match &v263 {
                                                Documents::US19::US19_0(
                                                    v263_0_0,
                                                    v263_0_1,
                                                    v263_0_2,
                                                    v263_0_3,
                                                    v263_0_4,
                                                    v263_0_5,
                                                ) => Documents::US20::US20_0(
                                                    v237_0_0.clone(),
                                                    v263_0_1.clone(),
                                                    v263_0_2.clone(),
                                                    v263_0_3.clone(),
                                                    v263_0_4.clone(),
                                                    v263_0_5.clone(),
                                                ),
                                                Documents::US19::US19_1(v263_1_0) => {
                                                    Documents::US20::US20_1(Func0::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v165 = v165.clone();
                                                        let v239 = v239.clone();
                                                        let v263 = v263.clone();
                                                        move || {
                                                            Documents::closure59(
                                                                v0_1.get().clone(),
                                                                v165,
                                                                v239,
                                                                match &v263 {
                                                                    Documents::US19::US19_1(x) => {
                                                                        x.clone()
                                                                    }
                                                                    _ => unreachable!(),
                                                                }
                                                                .clone(),
                                                                (),
                                                            )
                                                        }
                                                    }))
                                                }
                                            }
                                        }
                                        _ => {
                                            let v295: Documents::US19 = if v170 {
                                                Documents::US19::US19_1(Func0::new({
                                                    let v166 = v166.clone();
                                                    let v167 = v167.clone();
                                                    let v168 = v168.clone();
                                                    let v169 = v169.clone();
                                                    move || {
                                                        Documents::closure43(
                                                            v166,
                                                            v167,
                                                            v168,
                                                            v169,
                                                            (),
                                                        )
                                                    }
                                                }))
                                            } else {
                                                let v279: char =
                                                    getCharAt(v0_1.get().clone(), v165);
                                                if (v279) == '\"' {
                                                    let patternInput_3: (i32, i32, i32, i32) =
                                                        if '\n' == (v279) {
                                                            (
                                                                (v166) + (v168),
                                                                (v167) + 1_i32,
                                                                1_i32,
                                                                v169,
                                                            )
                                                        } else {
                                                            (v166, v167, (v168) + 1_i32, v169)
                                                        };
                                                    Documents::US19::US19_0(
                                                        Func0::new({
                                                            let v279 = v279.clone();
                                                            move || Documents::closure44(v279, ())
                                                        }),
                                                        (v165) + 1_i32,
                                                        patternInput_3.0.clone(),
                                                        patternInput_3.1.clone(),
                                                        patternInput_3.2.clone(),
                                                        patternInput_3.3.clone(),
                                                    )
                                                } else {
                                                    Documents::US19::US19_1(Func0::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v165 = v165.clone();
                                                        let v166 = v166.clone();
                                                        let v167 = v167.clone();
                                                        let v168 = v168.clone();
                                                        move || {
                                                            Documents::closure45(
                                                                v168,
                                                                v167,
                                                                v166,
                                                                v165,
                                                                v0_1.get().clone(),
                                                                (),
                                                            )
                                                        }
                                                    }))
                                                }
                                            };
                                            match &v295 {
                                                Documents::US19::US19_0(
                                                    v295_0_0,
                                                    v295_0_1,
                                                    v295_0_2,
                                                    v295_0_3,
                                                    v295_0_4,
                                                    v295_0_5,
                                                ) => Documents::US20::US20_0(
                                                    Func0::new(move || {
                                                        Documents::closure58((), ())
                                                    }),
                                                    v295_0_1.clone(),
                                                    v295_0_2.clone(),
                                                    v295_0_3.clone(),
                                                    v295_0_4.clone(),
                                                    v295_0_5.clone(),
                                                ),
                                                _ => Documents::US20::US20_1(Func0::new({
                                                    let v0_1 = v0_1.clone();
                                                    let v165 = v165.clone();
                                                    move || {
                                                        Documents::closure57(
                                                            v0_1.get().clone(),
                                                            v165,
                                                            (),
                                                        )
                                                    }
                                                })),
                                            }
                                        }
                                    }
                                }
                                Documents::US19::US19_1(v163_1_0) => {
                                    Documents::US20::US20_1(v163_1_0.clone())
                                }
                            }
                        }
                    };
                    let v358: Documents::US20 = match &v316 {
                        Documents::US20::US20_0(
                            v316_0_0,
                            v316_0_1,
                            v316_0_2,
                            v316_0_3,
                            v316_0_4,
                            v316_0_5,
                        ) => v316.clone(),
                        _ => {
                            let v345: Documents::US19 = if (v2.get().clone()) >= (v7.get().clone())
                            {
                                Documents::US19::US19_1(Func0::new({
                                    let v4 = v4.clone();
                                    let v5 = v5.clone();
                                    let v6 = v6.clone();
                                    let v7 = v7.clone();
                                    move || {
                                        Documents::closure106(
                                            v4.get().clone(),
                                            v5.get().clone(),
                                            v6.get().clone(),
                                            v7.get().clone(),
                                            (),
                                        )
                                    }
                                }))
                            } else {
                                let v327: char = getCharAt(v0_1.get().clone(), v2.get().clone());
                                if (Documents::method150(v327, 0_i64)) == false {
                                    let patternInput_5: (i32, i32, i32, i32) = if '\n' == (v327) {
                                        (
                                            (v4.get().clone()) + (v6.get().clone()),
                                            (v5.get().clone()) + 1_i32,
                                            1_i32,
                                            v7.get().clone(),
                                        )
                                    } else {
                                        (
                                            v4.get().clone(),
                                            v5.get().clone(),
                                            (v6.get().clone()) + 1_i32,
                                            v7.get().clone(),
                                        )
                                    };
                                    Documents::US19::US19_0(
                                        Func0::new({
                                            let v327 = v327.clone();
                                            move || Documents::closure52(v327, ())
                                        }),
                                        (v2.get().clone()) + 1_i32,
                                        patternInput_5.0.clone(),
                                        patternInput_5.1.clone(),
                                        patternInput_5.2.clone(),
                                        patternInput_5.3.clone(),
                                    )
                                } else {
                                    Documents::US19::US19_1(Func0::new({
                                        let v327 = v327.clone();
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        let v6 = v6.clone();
                                        let v7 = v7.clone();
                                        move || {
                                            Documents::closure107(
                                                v4.get().clone(),
                                                v5.get().clone(),
                                                v6.get().clone(),
                                                v7.get().clone(),
                                                v327,
                                                (),
                                            )
                                        }
                                    }))
                                }
                            };
                            match &v345 {
                                Documents::US19::US19_0(
                                    v345_0_0,
                                    v345_0_1,
                                    v345_0_2,
                                    v345_0_3,
                                    v345_0_4,
                                    v345_0_5,
                                ) => Documents::method154(
                                    v2.get().clone(),
                                    v0_1.get().clone(),
                                    v345_0_1.clone(),
                                    v345_0_2.clone(),
                                    v345_0_3.clone(),
                                    v345_0_4.clone(),
                                    v345_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v345_1_0) => {
                                    Documents::US20::US20_1(v345_1_0.clone())
                                }
                            }
                        }
                    };
                    let v383: Documents::US20 = match &v358 {
                        Documents::US20::US20_0(
                            v358_0_0,
                            v358_0_1,
                            v358_0_2,
                            v358_0_3,
                            v358_0_4,
                            v358_0_5,
                        ) => v358.clone(),
                        _ => {
                            let v369: Documents::US29 = Documents::method152(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                                v2.get().clone(),
                                ((v7.get().clone()) - (v2.get().clone())) + 2_i32,
                                v4.get().clone(),
                                v5.get().clone(),
                                v6.get().clone(),
                                v7.get().clone(),
                            );
                            match &v369 {
                                Documents::US29::US29_0(
                                    v369_0_0,
                                    v369_0_1,
                                    v369_0_2,
                                    v369_0_3,
                                    v369_0_4,
                                    v369_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new({
                                        let v369 = v369.clone();
                                        move || {
                                            Documents::closure111(
                                                match &v369 {
                                                    Documents::US29::US29_0(x, _, _, _, _, _) => {
                                                        x.clone()
                                                    }
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                                (),
                                            )
                                        }
                                    }),
                                    v369_0_1.clone(),
                                    v369_0_2.clone(),
                                    v369_0_3.clone(),
                                    v369_0_4.clone(),
                                    v369_0_5.clone(),
                                ),
                                Documents::US29::US29_1(v369_1_0) => {
                                    Documents::US20::US20_1(v369_1_0.clone())
                                }
                            }
                        }
                    };
                    let v394: Documents::US20 = if let Documents::US20::US20_0(
                        v383_0_0,
                        v383_0_1,
                        v383_0_2,
                        v383_0_3,
                        v383_0_4,
                        v383_0_5,
                    ) = &v383
                    {
                        if (v383_0_1.clone()) == (v2.get().clone()) {
                            Documents::US20::US20_1(Func0::new(move || {
                                Documents::closure112((), ())
                            }))
                        } else {
                            v383.clone()
                        }
                    } else {
                        v383.clone()
                    };
                    match &v394 {
                        Documents::US20::US20_0(
                            v394_0_0,
                            v394_0_1,
                            v394_0_2,
                            v394_0_3,
                            v394_0_4,
                            v394_0_5,
                        ) => {
                            let v399: i32 = v394_0_1.clone();
                            if (v399) == (v2.get().clone()) {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure115((), ())
                                }))
                            } else {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                    Documents::UH2::UH2_1((v394_0_0)(), v1_1.get().clone()),
                                );
                                let v2_temp: i32 = v399;
                                let v3_temp: i32 = (v3.get().clone()) - 1_i32;
                                let v4_temp: i32 = v394_0_2.clone();
                                let v5_temp: i32 = v394_0_3.clone();
                                let v6_temp: i32 = v394_0_4.clone();
                                let v7_temp: i32 = v394_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                v7.set(v7_temp);
                                continue '_method153;
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new({
                                let v1_1 = v1_1.clone();
                                move || Documents::closure114(v1_1.get().clone(), ())
                            }),
                            v2.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            v7.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure116(unitVar: (), unitVar_1: ()) -> LrcPtr<Documents::UH2> {
            LrcPtr::new(Documents::UH2::UH2_0)
        }
        pub fn closure117(v0_1: LrcPtr<Documents::UH2>, unitVar: ()) -> LrcPtr<Documents::UH2> {
            Documents::method146(v0_1, LrcPtr::new(Documents::UH2::UH2_0))
        }
        pub fn closure118(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.sep_by / separator consumed no input")
        }
        pub fn closure119(v0_1: LrcPtr<Documents::UH2>, unitVar: ()) -> LrcPtr<Documents::UH2> {
            Documents::method146(v0_1, LrcPtr::new(Documents::UH2::UH2_0))
        }
        pub fn method155(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH2>,
            v2: i32,
            v3: i32,
            v4: i32,
            v5: i32,
            v6: i32,
        ) -> Documents::US29 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: LrcPtr<MutCell<LrcPtr<Documents::UH2>>> =
                LrcPtr::new(MutCell::new(v1_1.clone()));
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: MutCell<i32> = MutCell::new(v5);
            let v6: MutCell<i32> = MutCell::new(v6);
            '_method155: loop {
                break '_method155 ({
                    let patternInput: (i32, i32, i32, i32, i32) = Documents::method139(
                        v0_1.get().clone(),
                        v2.get().clone(),
                        v3.get().clone(),
                        v4.get().clone(),
                        v5.get().clone(),
                        v6.get().clone(),
                    );
                    let v7: i32 = patternInput.0.clone();
                    let v18: Documents::US21 = if ((v7) == (v2.get().clone())) != true {
                        Documents::US21::US21_0(
                            Func0::new(move || Documents::closure66((), ())),
                            v7,
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                            patternInput.3.clone(),
                            patternInput.4.clone(),
                        )
                    } else {
                        Documents::US21::US21_1(Func0::new({
                            let v0_1 = v0_1.clone();
                            let v2 = v2.clone();
                            let v3 = v3.clone();
                            let v4 = v4.clone();
                            let v5 = v5.clone();
                            let v6 = v6.clone();
                            move || {
                                Documents::closure69(
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    v5.get().clone(),
                                    v6.get().clone(),
                                    v2.get().clone(),
                                    v0_1.get().clone(),
                                    (),
                                )
                            }
                        }))
                    };
                    match &v18 {
                        Documents::US21::US21_0(
                            v18_0_0,
                            v18_0_1,
                            v18_0_2,
                            v18_0_3,
                            v18_0_4,
                            v18_0_5,
                        ) => {
                            let v24: i32 = v18_0_5.clone();
                            let v23: i32 = v18_0_4.clone();
                            let v22: i32 = v18_0_3.clone();
                            let v21: i32 = v18_0_2.clone();
                            let v20: i32 = v18_0_1.clone();
                            if (v20) == (v2.get().clone()) {
                                Documents::US29::US29_1(Func0::new(move || {
                                    Documents::closure118((), ())
                                }))
                            } else {
                                fn v28(
                                    arg10_0040_4: (string, i32, i32, i32, i32, i32),
                                ) -> Documents::US19 {
                                    Documents::closure75((), arg10_0040_4)
                                }
                                fn v29(
                                    arg10_0040_5: (string, i32, i32, i32, i32, i32),
                                ) -> Documents::US19 {
                                    Documents::closure79((), arg10_0040_5)
                                }
                                let v33: Documents::US19 = Documents::method128(
                                    v21,
                                    v22,
                                    v23,
                                    v24,
                                    v20,
                                    v0_1.get().clone(),
                                    LrcPtr::new(Documents::UH0::UH0_1(
                                        Func1::from(v28),
                                        LrcPtr::new(Documents::UH0::UH0_1(
                                            Func1::from(v29),
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        )),
                                    )),
                                );
                                let v153: Documents::US20 = match &v33 {
                                    Documents::US19::US19_0(
                                        v33_0_0,
                                        v33_0_1,
                                        v33_0_2,
                                        v33_0_3,
                                        v33_0_4,
                                        v33_0_5,
                                    ) => {
                                        let v39: i32 = v33_0_5.clone();
                                        let v38: i32 = v33_0_4.clone();
                                        let v37: i32 = v33_0_3.clone();
                                        let v36: i32 = v33_0_2.clone();
                                        let v35: i32 = v33_0_1.clone();
                                        let v61: Documents::US19 = if (v35) >= (v39) {
                                            Documents::US19::US19_1(Func0::new({
                                                let v36 = v36.clone();
                                                let v37 = v37.clone();
                                                let v38 = v38.clone();
                                                let v39 = v39.clone();
                                                move || Documents::closure82(v36, v37, v38, v39, ())
                                            }))
                                        } else {
                                            let v43: char = getCharAt(v0_1.get().clone(), v35);
                                            if (Documents::method142(v43, 0_i64)) == false {
                                                let patternInput_1: (i32, i32, i32, i32) =
                                                    if '\n' == (v43) {
                                                        ((v36) + (v38), (v37) + 1_i32, 1_i32, v39)
                                                    } else {
                                                        (v36, v37, (v38) + 1_i32, v39)
                                                    };
                                                Documents::US19::US19_0(
                                                    Func0::new({
                                                        let v43 = v43.clone();
                                                        move || Documents::closure52(v43, ())
                                                    }),
                                                    (v35) + 1_i32,
                                                    patternInput_1.0.clone(),
                                                    patternInput_1.1.clone(),
                                                    patternInput_1.2.clone(),
                                                    patternInput_1.3.clone(),
                                                )
                                            } else {
                                                Documents::US19::US19_1(Func0::new({
                                                    let v36 = v36.clone();
                                                    let v37 = v37.clone();
                                                    let v38 = v38.clone();
                                                    let v39 = v39.clone();
                                                    let v43 = v43.clone();
                                                    move || {
                                                        Documents::closure83(
                                                            v36,
                                                            v37,
                                                            v38,
                                                            v39,
                                                            v43,
                                                            (),
                                                        )
                                                    }
                                                }))
                                            }
                                        };
                                        let v73: Documents::US20 = match &v61 {
                                            Documents::US19::US19_0(
                                                v61_0_0,
                                                v61_0_1,
                                                v61_0_2,
                                                v61_0_3,
                                                v61_0_4,
                                                v61_0_5,
                                            ) => Documents::US20::US20_0(
                                                Func0::new({
                                                    let v61 = v61.clone();
                                                    move || {
                                                        Documents::closure84(
                                                            match &v61 {
                                                                Documents::US19::US19_0(
                                                                    x,
                                                                    _,
                                                                    _,
                                                                    _,
                                                                    _,
                                                                    _,
                                                                ) => x.clone(),
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                            (),
                                                        )
                                                    }
                                                }),
                                                v61_0_1.clone(),
                                                v61_0_2.clone(),
                                                v61_0_3.clone(),
                                                v61_0_4.clone(),
                                                v61_0_5.clone(),
                                            ),
                                            Documents::US19::US19_1(v61_1_0) => {
                                                Documents::US20::US20_1(v61_1_0.clone())
                                            }
                                        };
                                        let v88:
                                                             Documents::US20 =
                                                         match &v73 {
                                                             Documents::US20::US20_0(v73_0_0,
                                                                                     v73_0_1,
                                                                                     v73_0_2,
                                                                                     v73_0_3,
                                                                                     v73_0_4,
                                                                                     v73_0_5)
                                                             => v73.clone(),
                                                             _ =>
                                                             Documents::method144(v36,
                                                                                  v37,
                                                                                  v38,
                                                                                  v39,
                                                                                  v35,
                                                                                  v0_1.get().clone(),
                                                                                  LrcPtr::new(Documents::UH1::UH1_1(Func1::new(move
                                                                                                                                   |arg10_0040_10:
                                                                                                                                        (string,
                                                                                                                                         i32,
                                                                                                                                         i32,
                                                                                                                                         i32,
                                                                                                                                         i32,
                                                                                                                                         i32)|
                                                                                                                                   Documents::closure85((),
                                                                                                                                                        arg10_0040_10)),
                                                                                                                    LrcPtr::new(Documents::UH1::UH1_1(Func1::new(move
                                                                                                                                                                     |arg10_0040_11:
                                                                                                                                                                          (string,
                                                                                                                                                                           i32,
                                                                                                                                                                           i32,
                                                                                                                                                                           i32,
                                                                                                                                                                           i32,
                                                                                                                                                                           i32)|
                                                                                                                                                                     Documents::closure89((),
                                                                                                                                                                                          arg10_0040_11)),
                                                                                                                                                      LrcPtr::new(Documents::UH1::UH1_0)))))),
                                                         };
                                        let v107: Documents::US20 = match &v88 {
                                            Documents::US20::US20_0(
                                                v88_0_0,
                                                v88_0_1,
                                                v88_0_2,
                                                v88_0_3,
                                                v88_0_4,
                                                v88_0_5,
                                            ) => {
                                                let v93: i32 = v88_0_1.clone();
                                                if (v93) == (v35) {
                                                    Documents::US20::US20_1(Func0::new(move || {
                                                        Documents::closure92((), ())
                                                    }))
                                                } else {
                                                    Documents::method145(
                                                        v0_1.get().clone(),
                                                        v88_0_0.clone(),
                                                        LrcPtr::new(Documents::UH2::UH2_0),
                                                        v93,
                                                        ((v39) - (v93)) + 2_i32,
                                                        v88_0_2.clone(),
                                                        v88_0_3.clone(),
                                                        v88_0_4.clone(),
                                                        v88_0_5.clone(),
                                                    )
                                                }
                                            }
                                            _ => Documents::US20::US20_0(
                                                Func0::new(move || Documents::closure91((), ())),
                                                v35,
                                                v36,
                                                v37,
                                                v38,
                                                v39,
                                            ),
                                        };
                                        match &v107 {
                                            Documents::US20::US20_0(
                                                v107_0_0,
                                                v107_0_1,
                                                v107_0_2,
                                                v107_0_3,
                                                v107_0_4,
                                                v107_0_5,
                                            ) => {
                                                let v109: i32 = v107_0_1.clone();
                                                let v117: Documents::US19 = Documents::method128(
                                                    v107_0_2.clone(),
                                                    v107_0_3.clone(),
                                                    v107_0_4.clone(),
                                                    v107_0_5.clone(),
                                                    v109,
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH0::UH0_1(
                                                        Func1::from(v28),
                                                        LrcPtr::new(Documents::UH0::UH0_1(
                                                            Func1::from(v29),
                                                            LrcPtr::new(Documents::UH0::UH0_0),
                                                        )),
                                                    )),
                                                );
                                                match &v117 {
                                                    Documents::US19::US19_0(
                                                        v117_0_0,
                                                        v117_0_1,
                                                        v117_0_2,
                                                        v117_0_3,
                                                        v117_0_4,
                                                        v117_0_5,
                                                    ) => Documents::US20::US20_0(
                                                        v107_0_0.clone(),
                                                        v117_0_1.clone(),
                                                        v117_0_2.clone(),
                                                        v117_0_3.clone(),
                                                        v117_0_4.clone(),
                                                        v117_0_5.clone(),
                                                    ),
                                                    Documents::US19::US19_1(v117_1_0) => {
                                                        Documents::US20::US20_1(Func0::new({
                                                            let v0_1 = v0_1.clone();
                                                            let v109 = v109.clone();
                                                            let v117 = v117.clone();
                                                            let v35 = v35.clone();
                                                            move || {
                                                                Documents::closure59(
                                                                    v0_1.get().clone(),
                                                                    v35,
                                                                    v109,
                                                                    match &v117 {
                                                                        Documents::US19::US19_1(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    }
                                                                    .clone(),
                                                                    (),
                                                                )
                                                            }
                                                        }))
                                                    }
                                                }
                                            }
                                            _ => {
                                                let v134: Documents::US19 = Documents::method128(
                                                    v36,
                                                    v37,
                                                    v38,
                                                    v39,
                                                    v35,
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH0::UH0_1(
                                                        Func1::from(v28),
                                                        LrcPtr::new(Documents::UH0::UH0_1(
                                                            Func1::from(v29),
                                                            LrcPtr::new(Documents::UH0::UH0_0),
                                                        )),
                                                    )),
                                                );
                                                match &v134 {
                                                    Documents::US19::US19_0(
                                                        v134_0_0,
                                                        v134_0_1,
                                                        v134_0_2,
                                                        v134_0_3,
                                                        v134_0_4,
                                                        v134_0_5,
                                                    ) => Documents::US20::US20_0(
                                                        Func0::new(move || {
                                                            Documents::closure58((), ())
                                                        }),
                                                        v134_0_1.clone(),
                                                        v134_0_2.clone(),
                                                        v134_0_3.clone(),
                                                        v134_0_4.clone(),
                                                        v134_0_5.clone(),
                                                    ),
                                                    _ => Documents::US20::US20_1(Func0::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v35 = v35.clone();
                                                        move || {
                                                            Documents::closure57(
                                                                v0_1.get().clone(),
                                                                v35,
                                                                (),
                                                            )
                                                        }
                                                    })),
                                                }
                                            }
                                        }
                                    }
                                    Documents::US19::US19_1(v33_1_0) => {
                                        Documents::US20::US20_1(v33_1_0.clone())
                                    }
                                };
                                let v333: Documents::US20 = match &v153 {
                                    Documents::US20::US20_0(
                                        v153_0_0,
                                        v153_0_1,
                                        v153_0_2,
                                        v153_0_3,
                                        v153_0_4,
                                        v153_0_5,
                                    ) => v153.clone(),
                                    _ => {
                                        let v180: Documents::US19 = if (v20) >= (v24) {
                                            Documents::US19::US19_1(Func0::new({
                                                let v21 = v21.clone();
                                                let v22 = v22.clone();
                                                let v23 = v23.clone();
                                                let v24 = v24.clone();
                                                move || Documents::closure43(v21, v22, v23, v24, ())
                                            }))
                                        } else {
                                            let v164: char = getCharAt(v0_1.get().clone(), v20);
                                            if (v164) == '\"' {
                                                let patternInput_2: (i32, i32, i32, i32) =
                                                    if '\n' == (v164) {
                                                        ((v21) + (v23), (v22) + 1_i32, 1_i32, v24)
                                                    } else {
                                                        (v21, v22, (v23) + 1_i32, v24)
                                                    };
                                                Documents::US19::US19_0(
                                                    Func0::new({
                                                        let v164 = v164.clone();
                                                        move || Documents::closure44(v164, ())
                                                    }),
                                                    (v20) + 1_i32,
                                                    patternInput_2.0.clone(),
                                                    patternInput_2.1.clone(),
                                                    patternInput_2.2.clone(),
                                                    patternInput_2.3.clone(),
                                                )
                                            } else {
                                                Documents::US19::US19_1(Func0::new({
                                                    let v0_1 = v0_1.clone();
                                                    let v20 = v20.clone();
                                                    let v21 = v21.clone();
                                                    let v22 = v22.clone();
                                                    let v23 = v23.clone();
                                                    move || {
                                                        Documents::closure45(
                                                            v23,
                                                            v22,
                                                            v21,
                                                            v20,
                                                            v0_1.get().clone(),
                                                            (),
                                                        )
                                                    }
                                                }))
                                            }
                                        };
                                        match &v180 {
                                            Documents::US19::US19_0(
                                                v180_0_0,
                                                v180_0_1,
                                                v180_0_2,
                                                v180_0_3,
                                                v180_0_4,
                                                v180_0_5,
                                            ) => {
                                                let v186: i32 = v180_0_5.clone();
                                                let v185: i32 = v180_0_4.clone();
                                                let v184: i32 = v180_0_3.clone();
                                                let v183: i32 = v180_0_2.clone();
                                                let v182: i32 = v180_0_1.clone();
                                                let v187: bool = (v182) >= (v186);
                                                let v208: Documents::US19 = if v187 {
                                                    Documents::US19::US19_1(Func0::new({
                                                        let v183 = v183.clone();
                                                        let v184 = v184.clone();
                                                        let v185 = v185.clone();
                                                        let v186 = v186.clone();
                                                        move || {
                                                            Documents::closure82(
                                                                v183,
                                                                v184,
                                                                v185,
                                                                v186,
                                                                (),
                                                            )
                                                        }
                                                    }))
                                                } else {
                                                    let v190: char =
                                                        getCharAt(v0_1.get().clone(), v182);
                                                    if (Documents::method142(v190, 0_i64)) == false
                                                    {
                                                        let patternInput_3: (i32, i32, i32, i32) =
                                                            if '\n' == (v190) {
                                                                (
                                                                    (v183) + (v185),
                                                                    (v184) + 1_i32,
                                                                    1_i32,
                                                                    v186,
                                                                )
                                                            } else {
                                                                (v183, v184, (v185) + 1_i32, v186)
                                                            };
                                                        Documents::US19::US19_0(
                                                            Func0::new({
                                                                let v190 = v190.clone();
                                                                move || {
                                                                    Documents::closure52(v190, ())
                                                                }
                                                            }),
                                                            (v182) + 1_i32,
                                                            patternInput_3.0.clone(),
                                                            patternInput_3.1.clone(),
                                                            patternInput_3.2.clone(),
                                                            patternInput_3.3.clone(),
                                                        )
                                                    } else {
                                                        Documents::US19::US19_1(Func0::new({
                                                            let v183 = v183.clone();
                                                            let v184 = v184.clone();
                                                            let v185 = v185.clone();
                                                            let v186 = v186.clone();
                                                            let v190 = v190.clone();
                                                            move || {
                                                                Documents::closure83(
                                                                    v183,
                                                                    v184,
                                                                    v185,
                                                                    v186,
                                                                    v190,
                                                                    (),
                                                                )
                                                            }
                                                        }))
                                                    }
                                                };
                                                let v220: Documents::US20 = match &v208 {
                                                    Documents::US19::US19_0(
                                                        v208_0_0,
                                                        v208_0_1,
                                                        v208_0_2,
                                                        v208_0_3,
                                                        v208_0_4,
                                                        v208_0_5,
                                                    ) => Documents::US20::US20_0(
                                                        Func0::new({
                                                            let v208 = v208.clone();
                                                            move || {
                                                                Documents::closure84(
                                                                    match &v208 {
                                                                        Documents::US19::US19_0(
                                                                            x,
                                                                            _,
                                                                            _,
                                                                            _,
                                                                            _,
                                                                            _,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    }
                                                                    .clone(),
                                                                    (),
                                                                )
                                                            }
                                                        }),
                                                        v208_0_1.clone(),
                                                        v208_0_2.clone(),
                                                        v208_0_3.clone(),
                                                        v208_0_4.clone(),
                                                        v208_0_5.clone(),
                                                    ),
                                                    Documents::US19::US19_1(v208_1_0) => {
                                                        Documents::US20::US20_1(v208_1_0.clone())
                                                    }
                                                };
                                                let v235:
                                                                     Documents::US20 =
                                                                 match &v220 {
                                                                     Documents::US20::US20_0(v220_0_0,
                                                                                             v220_0_1,
                                                                                             v220_0_2,
                                                                                             v220_0_3,
                                                                                             v220_0_4,
                                                                                             v220_0_5)
                                                                     =>
                                                                     v220.clone(),
                                                                     _ =>
                                                                     Documents::method144(v183,
                                                                                          v184,
                                                                                          v185,
                                                                                          v186,
                                                                                          v182,
                                                                                          v0_1.get().clone(),
                                                                                          LrcPtr::new(Documents::UH1::UH1_1(Func1::new(move
                                                                                                                                           |arg10_0040_24:
                                                                                                                                                (string,
                                                                                                                                                 i32,
                                                                                                                                                 i32,
                                                                                                                                                 i32,
                                                                                                                                                 i32,
                                                                                                                                                 i32)|
                                                                                                                                           Documents::closure98((),
                                                                                                                                                                arg10_0040_24)),
                                                                                                                            LrcPtr::new(Documents::UH1::UH1_1(Func1::new(move
                                                                                                                                                                             |arg10_0040_25:
                                                                                                                                                                                  (string,
                                                                                                                                                                                   i32,
                                                                                                                                                                                   i32,
                                                                                                                                                                                   i32,
                                                                                                                                                                                   i32,
                                                                                                                                                                                   i32)|
                                                                                                                                                                             Documents::closure102((),
                                                                                                                                                                                                   arg10_0040_25)),
                                                                                                                                                              LrcPtr::new(Documents::UH1::UH1_0)))))),
                                                                 };
                                                let v254: Documents::US20 = match &v235 {
                                                    Documents::US20::US20_0(
                                                        v235_0_0,
                                                        v235_0_1,
                                                        v235_0_2,
                                                        v235_0_3,
                                                        v235_0_4,
                                                        v235_0_5,
                                                    ) => {
                                                        let v240: i32 = v235_0_1.clone();
                                                        if (v240) == (v182) {
                                                            Documents::US20::US20_1(Func0::new(
                                                                move || {
                                                                    Documents::closure92((), ())
                                                                },
                                                            ))
                                                        } else {
                                                            Documents::method149(
                                                                v0_1.get().clone(),
                                                                v235_0_0.clone(),
                                                                LrcPtr::new(Documents::UH2::UH2_0),
                                                                v240,
                                                                ((v186) - (v240)) + 2_i32,
                                                                v235_0_2.clone(),
                                                                v235_0_3.clone(),
                                                                v235_0_4.clone(),
                                                                v235_0_5.clone(),
                                                            )
                                                        }
                                                    }
                                                    _ => Documents::US20::US20_0(
                                                        Func0::new(move || {
                                                            Documents::closure91((), ())
                                                        }),
                                                        v182,
                                                        v183,
                                                        v184,
                                                        v185,
                                                        v186,
                                                    ),
                                                };
                                                match &v254 {
                                                    Documents::US20::US20_0(
                                                        v254_0_0,
                                                        v254_0_1,
                                                        v254_0_2,
                                                        v254_0_3,
                                                        v254_0_4,
                                                        v254_0_5,
                                                    ) => {
                                                        let v260: i32 = v254_0_5.clone();
                                                        let v259: i32 = v254_0_4.clone();
                                                        let v258: i32 = v254_0_3.clone();
                                                        let v257: i32 = v254_0_2.clone();
                                                        let v256: i32 = v254_0_1.clone();
                                                        let v280: Documents::US19 = if (v256)
                                                            >= (v260)
                                                        {
                                                            Documents::US19::US19_1(Func0::new({
                                                                let v257 = v257.clone();
                                                                let v258 = v258.clone();
                                                                let v259 = v259.clone();
                                                                let v260 = v260.clone();
                                                                move || {
                                                                    Documents::closure43(
                                                                        v257,
                                                                        v258,
                                                                        v259,
                                                                        v260,
                                                                        (),
                                                                    )
                                                                }
                                                            }))
                                                        } else {
                                                            let v264: char =
                                                                getCharAt(v0_1.get().clone(), v256);
                                                            if (v264) == '\"' {
                                                                let patternInput_5: (
                                                                    i32,
                                                                    i32,
                                                                    i32,
                                                                    i32,
                                                                ) = if '\n' == (v264) {
                                                                    (
                                                                        (v257) + (v259),
                                                                        (v258) + 1_i32,
                                                                        1_i32,
                                                                        v260,
                                                                    )
                                                                } else {
                                                                    (
                                                                        v257,
                                                                        v258,
                                                                        (v259) + 1_i32,
                                                                        v260,
                                                                    )
                                                                };
                                                                Documents::US19::US19_0(
                                                                    Func0::new({
                                                                        let v264 = v264.clone();
                                                                        move || {
                                                                            Documents::closure44(
                                                                                v264,
                                                                                (),
                                                                            )
                                                                        }
                                                                    }),
                                                                    (v256) + 1_i32,
                                                                    patternInput_5.0.clone(),
                                                                    patternInput_5.1.clone(),
                                                                    patternInput_5.2.clone(),
                                                                    patternInput_5.3.clone(),
                                                                )
                                                            } else {
                                                                Documents::US19::US19_1(Func0::new(
                                                                    {
                                                                        let v0_1 = v0_1.clone();
                                                                        let v256 = v256.clone();
                                                                        let v257 = v257.clone();
                                                                        let v258 = v258.clone();
                                                                        let v259 = v259.clone();
                                                                        move || {
                                                                            Documents::closure45(
                                                                                v259,
                                                                                v258,
                                                                                v257,
                                                                                v256,
                                                                                v0_1.get().clone(),
                                                                                (),
                                                                            )
                                                                        }
                                                                    },
                                                                ))
                                                            }
                                                        };
                                                        match &v280 {
                                                            Documents::US19::US19_0(
                                                                v280_0_0,
                                                                v280_0_1,
                                                                v280_0_2,
                                                                v280_0_3,
                                                                v280_0_4,
                                                                v280_0_5,
                                                            ) => Documents::US20::US20_0(
                                                                v254_0_0.clone(),
                                                                v280_0_1.clone(),
                                                                v280_0_2.clone(),
                                                                v280_0_3.clone(),
                                                                v280_0_4.clone(),
                                                                v280_0_5.clone(),
                                                            ),
                                                            Documents::US19::US19_1(v280_1_0) => {
                                                                Documents::US20::US20_1(Func0::new(
                                                                    {
                                                                        let v0_1 = v0_1.clone();
                                                                        let v182 = v182.clone();
                                                                        let v256 = v256.clone();
                                                                        let v280 = v280.clone();
                                                                        move || {
                                                                            Documents::closure59(v0_1.get().clone(),
                                                                                                                                         v182,
                                                                                                                                         v256,
                                                                                                                                         match &v280
                                                                                                                                             {
                                                                                                                                             Documents::US19::US19_1(x)
                                                                                                                                             =>
                                                                                                                                             x.clone(),
                                                                                                                                             _
                                                                                                                                             =>
                                                                                                                                             unreachable!(),
                                                                                                                                         }.clone(),
                                                                                                                                         ())
                                                                        }
                                                                    },
                                                                ))
                                                            }
                                                        }
                                                    }
                                                    _ => {
                                                        let v312: Documents::US19 = if v187 {
                                                            Documents::US19::US19_1(Func0::new({
                                                                let v183 = v183.clone();
                                                                let v184 = v184.clone();
                                                                let v185 = v185.clone();
                                                                let v186 = v186.clone();
                                                                move || {
                                                                    Documents::closure43(
                                                                        v183,
                                                                        v184,
                                                                        v185,
                                                                        v186,
                                                                        (),
                                                                    )
                                                                }
                                                            }))
                                                        } else {
                                                            let v296: char =
                                                                getCharAt(v0_1.get().clone(), v182);
                                                            if (v296) == '\"' {
                                                                let patternInput_4: (
                                                                    i32,
                                                                    i32,
                                                                    i32,
                                                                    i32,
                                                                ) = if '\n' == (v296) {
                                                                    (
                                                                        (v183) + (v185),
                                                                        (v184) + 1_i32,
                                                                        1_i32,
                                                                        v186,
                                                                    )
                                                                } else {
                                                                    (
                                                                        v183,
                                                                        v184,
                                                                        (v185) + 1_i32,
                                                                        v186,
                                                                    )
                                                                };
                                                                Documents::US19::US19_0(
                                                                    Func0::new({
                                                                        let v296 = v296.clone();
                                                                        move || {
                                                                            Documents::closure44(
                                                                                v296,
                                                                                (),
                                                                            )
                                                                        }
                                                                    }),
                                                                    (v182) + 1_i32,
                                                                    patternInput_4.0.clone(),
                                                                    patternInput_4.1.clone(),
                                                                    patternInput_4.2.clone(),
                                                                    patternInput_4.3.clone(),
                                                                )
                                                            } else {
                                                                Documents::US19::US19_1(Func0::new(
                                                                    {
                                                                        let v0_1 = v0_1.clone();
                                                                        let v182 = v182.clone();
                                                                        let v183 = v183.clone();
                                                                        let v184 = v184.clone();
                                                                        let v185 = v185.clone();
                                                                        move || {
                                                                            Documents::closure45(
                                                                                v185,
                                                                                v184,
                                                                                v183,
                                                                                v182,
                                                                                v0_1.get().clone(),
                                                                                (),
                                                                            )
                                                                        }
                                                                    },
                                                                ))
                                                            }
                                                        };
                                                        match &v312 {
                                                            Documents::US19::US19_0(
                                                                v312_0_0,
                                                                v312_0_1,
                                                                v312_0_2,
                                                                v312_0_3,
                                                                v312_0_4,
                                                                v312_0_5,
                                                            ) => Documents::US20::US20_0(
                                                                Func0::new(move || {
                                                                    Documents::closure58((), ())
                                                                }),
                                                                v312_0_1.clone(),
                                                                v312_0_2.clone(),
                                                                v312_0_3.clone(),
                                                                v312_0_4.clone(),
                                                                v312_0_5.clone(),
                                                            ),
                                                            _ => Documents::US20::US20_1(
                                                                Func0::new({
                                                                    let v0_1 = v0_1.clone();
                                                                    let v182 = v182.clone();
                                                                    move || {
                                                                        Documents::closure57(
                                                                            v0_1.get().clone(),
                                                                            v182,
                                                                            (),
                                                                        )
                                                                    }
                                                                }),
                                                            ),
                                                        }
                                                    }
                                                }
                                            }
                                            Documents::US19::US19_1(v180_1_0) => {
                                                Documents::US20::US20_1(v180_1_0.clone())
                                            }
                                        }
                                    }
                                };
                                let v375: Documents::US20 = match &v333 {
                                    Documents::US20::US20_0(
                                        v333_0_0,
                                        v333_0_1,
                                        v333_0_2,
                                        v333_0_3,
                                        v333_0_4,
                                        v333_0_5,
                                    ) => v333.clone(),
                                    _ => {
                                        let v362: Documents::US19 = if (v20) >= (v24) {
                                            Documents::US19::US19_1(Func0::new({
                                                let v21 = v21.clone();
                                                let v22 = v22.clone();
                                                let v23 = v23.clone();
                                                let v24 = v24.clone();
                                                move || {
                                                    Documents::closure106(v21, v22, v23, v24, ())
                                                }
                                            }))
                                        } else {
                                            let v344: char = getCharAt(v0_1.get().clone(), v20);
                                            if (Documents::method150(v344, 0_i64)) == false {
                                                let patternInput_6: (i32, i32, i32, i32) =
                                                    if '\n' == (v344) {
                                                        ((v21) + (v23), (v22) + 1_i32, 1_i32, v24)
                                                    } else {
                                                        (v21, v22, (v23) + 1_i32, v24)
                                                    };
                                                Documents::US19::US19_0(
                                                    Func0::new({
                                                        let v344 = v344.clone();
                                                        move || Documents::closure52(v344, ())
                                                    }),
                                                    (v20) + 1_i32,
                                                    patternInput_6.0.clone(),
                                                    patternInput_6.1.clone(),
                                                    patternInput_6.2.clone(),
                                                    patternInput_6.3.clone(),
                                                )
                                            } else {
                                                Documents::US19::US19_1(Func0::new({
                                                    let v21 = v21.clone();
                                                    let v22 = v22.clone();
                                                    let v23 = v23.clone();
                                                    let v24 = v24.clone();
                                                    let v344 = v344.clone();
                                                    move || {
                                                        Documents::closure107(
                                                            v21,
                                                            v22,
                                                            v23,
                                                            v24,
                                                            v344,
                                                            (),
                                                        )
                                                    }
                                                }))
                                            }
                                        };
                                        match &v362 {
                                            Documents::US19::US19_0(
                                                v362_0_0,
                                                v362_0_1,
                                                v362_0_2,
                                                v362_0_3,
                                                v362_0_4,
                                                v362_0_5,
                                            ) => Documents::method154(
                                                v20,
                                                v0_1.get().clone(),
                                                v362_0_1.clone(),
                                                v362_0_2.clone(),
                                                v362_0_3.clone(),
                                                v362_0_4.clone(),
                                                v362_0_5.clone(),
                                            ),
                                            Documents::US19::US19_1(v362_1_0) => {
                                                Documents::US20::US20_1(v362_1_0.clone())
                                            }
                                        }
                                    }
                                };
                                let v400: Documents::US20 = match &v375 {
                                    Documents::US20::US20_0(
                                        v375_0_0,
                                        v375_0_1,
                                        v375_0_2,
                                        v375_0_3,
                                        v375_0_4,
                                        v375_0_5,
                                    ) => v375.clone(),
                                    _ => {
                                        let v386: Documents::US29 = Documents::method152(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v20,
                                            ((v24) - (v20)) + 2_i32,
                                            v21,
                                            v22,
                                            v23,
                                            v24,
                                        );
                                        match &v386 {
                                            Documents::US29::US29_0(
                                                v386_0_0,
                                                v386_0_1,
                                                v386_0_2,
                                                v386_0_3,
                                                v386_0_4,
                                                v386_0_5,
                                            ) => Documents::US20::US20_0(
                                                Func0::new({
                                                    let v386 = v386.clone();
                                                    move || {
                                                        Documents::closure111(
                                                            match &v386 {
                                                                Documents::US29::US29_0(
                                                                    x,
                                                                    _,
                                                                    _,
                                                                    _,
                                                                    _,
                                                                    _,
                                                                ) => x.clone(),
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                            (),
                                                        )
                                                    }
                                                }),
                                                v386_0_1.clone(),
                                                v386_0_2.clone(),
                                                v386_0_3.clone(),
                                                v386_0_4.clone(),
                                                v386_0_5.clone(),
                                            ),
                                            Documents::US29::US29_1(v386_1_0) => {
                                                Documents::US20::US20_1(v386_1_0.clone())
                                            }
                                        }
                                    }
                                };
                                let v411: Documents::US20 = if let Documents::US20::US20_0(
                                    v400_0_0,
                                    v400_0_1,
                                    v400_0_2,
                                    v400_0_3,
                                    v400_0_4,
                                    v400_0_5,
                                ) = &v400
                                {
                                    if (v400_0_1.clone()) == (v20) {
                                        Documents::US20::US20_1(Func0::new(move || {
                                            Documents::closure112((), ())
                                        }))
                                    } else {
                                        v400.clone()
                                    }
                                } else {
                                    v400.clone()
                                };
                                let v437: Documents::US20 = match &v411 {
                                    Documents::US20::US20_0(
                                        v411_0_0,
                                        v411_0_1,
                                        v411_0_2,
                                        v411_0_3,
                                        v411_0_4,
                                        v411_0_5,
                                    ) => {
                                        let v415: i32 = v411_0_1.clone();
                                        let v421: i32 = ((v24) - (v415)) + 2_i32;
                                        Documents::method153(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Documents::UH2::UH2_1(
                                                (v411_0_0)(),
                                                LrcPtr::new(Documents::UH2::UH2_0),
                                            )),
                                            v415,
                                            v421,
                                            v411_0_2.clone(),
                                            v411_0_3.clone(),
                                            v411_0_4.clone(),
                                            v411_0_5.clone(),
                                        )
                                    }
                                    Documents::US20::US20_1(v411_1_0) => {
                                        Documents::US20::US20_1(v411_1_0.clone())
                                    }
                                };
                                match &v437 {
                                    Documents::US20::US20_0(
                                        v437_0_0,
                                        v437_0_1,
                                        v437_0_2,
                                        v437_0_3,
                                        v437_0_4,
                                        v437_0_5,
                                    ) => {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                            Documents::UH2::UH2_1((v437_0_0)(), v1_1.get().clone()),
                                        );
                                        let v2_temp: i32 = v437_0_1.clone();
                                        let v3_temp: i32 = v437_0_2.clone();
                                        let v4_temp: i32 = v437_0_3.clone();
                                        let v5_temp: i32 = v437_0_4.clone();
                                        let v6_temp: i32 = v437_0_5.clone();
                                        v0_1.set(v0_1_temp);
                                        v1_1.set(v1_1_temp);
                                        v2.set(v2_temp);
                                        v3.set(v3_temp);
                                        v4.set(v4_temp);
                                        v5.set(v5_temp);
                                        v6.set(v6_temp);
                                        continue '_method155;
                                    }
                                    _ => Documents::US29::US29_0(
                                        Func0::new({
                                            let v1_1 = v1_1.clone();
                                            move || Documents::closure119(v1_1.get().clone(), ())
                                        }),
                                        v2.get().clone(),
                                        v3.get().clone(),
                                        v4.get().clone(),
                                        v5.get().clone(),
                                        v6.get().clone(),
                                    ),
                                }
                            }
                        }
                        _ => Documents::US29::US29_0(
                            Func0::new({
                                let v1_1 = v1_1.clone();
                                move || Documents::closure117(v1_1.get().clone(), ())
                            }),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method156(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method156(
                        match v0_1.as_ref() {
                            Documents::UH2::UH2_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn method141(v0_1: string) -> Documents::US28 {
            let v1_1: i32 = length(v0_1.clone());
            fn v2(arg10_0040: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
                Documents::closure75((), arg10_0040)
            }
            fn v3(arg10_0040_1: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
                Documents::closure79((), arg10_0040_1)
            }
            let v7: Documents::US19 = Documents::method119(
                v1_1,
                v0_1.clone(),
                LrcPtr::new(Documents::UH0::UH0_1(
                    Func1::from(v2),
                    LrcPtr::new(Documents::UH0::UH0_1(
                        Func1::from(v3),
                        LrcPtr::new(Documents::UH0::UH0_0),
                    )),
                )),
            );
            let v127: Documents::US20 = match &v7 {
                Documents::US19::US19_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4, v7_0_5) => {
                    let v9: i32 = v7_0_1.clone();
                    let v13: i32 = v7_0_5.clone();
                    let v12: i32 = v7_0_4.clone();
                    let v11: i32 = v7_0_3.clone();
                    let v10: i32 = v7_0_2.clone();
                    let v35: Documents::US19 = if (v9) >= (v13) {
                        Documents::US19::US19_1(Func0::new({
                            let v10 = v10.clone();
                            let v11 = v11.clone();
                            let v12 = v12.clone();
                            let v13 = v13.clone();
                            move || Documents::closure82(v10, v11, v12, v13, ())
                        }))
                    } else {
                        let v17: char = getCharAt(v0_1.clone(), v9);
                        if (Documents::method142(v17, 0_i64)) == false {
                            let patternInput: (i32, i32, i32, i32) = if '\n' == (v17) {
                                ((v10) + (v12), (v11) + 1_i32, 1_i32, v13)
                            } else {
                                (v10, v11, (v12) + 1_i32, v13)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v17 = v17.clone();
                                    move || Documents::closure52(v17, ())
                                }),
                                (v9) + 1_i32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                                patternInput.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v10 = v10.clone();
                                let v11 = v11.clone();
                                let v12 = v12.clone();
                                let v13 = v13.clone();
                                let v17 = v17.clone();
                                move || Documents::closure83(v10, v11, v12, v13, v17, ())
                            }))
                        }
                    };
                    let v47: Documents::US20 = match &v35 {
                        Documents::US19::US19_0(
                            v35_0_0,
                            v35_0_1,
                            v35_0_2,
                            v35_0_3,
                            v35_0_4,
                            v35_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new({
                                let v35 = v35.clone();
                                move || {
                                    Documents::closure84(
                                        match &v35 {
                                            Documents::US19::US19_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v35_0_1.clone(),
                            v35_0_2.clone(),
                            v35_0_3.clone(),
                            v35_0_4.clone(),
                            v35_0_5.clone(),
                        ),
                        Documents::US19::US19_1(v35_1_0) => {
                            Documents::US20::US20_1(v35_1_0.clone())
                        }
                    };
                    let v62: Documents::US20 = match &v47 {
                        Documents::US20::US20_0(
                            v47_0_0,
                            v47_0_1,
                            v47_0_2,
                            v47_0_3,
                            v47_0_4,
                            v47_0_5,
                        ) => v47.clone(),
                        _ => Documents::method144(
                            v10,
                            v11,
                            v12,
                            v13,
                            v9,
                            v0_1.clone(),
                            LrcPtr::new(Documents::UH1::UH1_1(
                                Func1::new(
                                    move |arg10_0040_6: (string, i32, i32, i32, i32, i32)| {
                                        Documents::closure85((), arg10_0040_6)
                                    },
                                ),
                                LrcPtr::new(Documents::UH1::UH1_1(
                                    Func1::new(
                                        move |arg10_0040_7: (string, i32, i32, i32, i32, i32)| {
                                            Documents::closure89((), arg10_0040_7)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH1::UH1_0),
                                )),
                            )),
                        ),
                    };
                    let v81: Documents::US20 = match &v62 {
                        Documents::US20::US20_0(
                            v62_0_0,
                            v62_0_1,
                            v62_0_2,
                            v62_0_3,
                            v62_0_4,
                            v62_0_5,
                        ) => {
                            let v67: i32 = v62_0_1.clone();
                            if (v67) == (v9) {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure92((), ())
                                }))
                            } else {
                                Documents::method145(
                                    v0_1.clone(),
                                    v62_0_0.clone(),
                                    LrcPtr::new(Documents::UH2::UH2_0),
                                    v67,
                                    ((v13) - (v67)) + 2_i32,
                                    v62_0_2.clone(),
                                    v62_0_3.clone(),
                                    v62_0_4.clone(),
                                    v62_0_5.clone(),
                                )
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new(move || Documents::closure91((), ())),
                            v9,
                            v10,
                            v11,
                            v12,
                            v13,
                        ),
                    };
                    match &v81 {
                        Documents::US20::US20_0(
                            v81_0_0,
                            v81_0_1,
                            v81_0_2,
                            v81_0_3,
                            v81_0_4,
                            v81_0_5,
                        ) => {
                            let v83: i32 = v81_0_1.clone();
                            let v91: Documents::US19 = Documents::method128(
                                v81_0_2.clone(),
                                v81_0_3.clone(),
                                v81_0_4.clone(),
                                v81_0_5.clone(),
                                v83,
                                v0_1.clone(),
                                LrcPtr::new(Documents::UH0::UH0_1(
                                    Func1::from(v2),
                                    LrcPtr::new(Documents::UH0::UH0_1(
                                        Func1::from(v3),
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    )),
                                )),
                            );
                            match &v91 {
                                Documents::US19::US19_0(
                                    v91_0_0,
                                    v91_0_1,
                                    v91_0_2,
                                    v91_0_3,
                                    v91_0_4,
                                    v91_0_5,
                                ) => Documents::US20::US20_0(
                                    v81_0_0.clone(),
                                    v91_0_1.clone(),
                                    v91_0_2.clone(),
                                    v91_0_3.clone(),
                                    v91_0_4.clone(),
                                    v91_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v91_1_0) => {
                                    Documents::US20::US20_1(Func0::new({
                                        let v0_1 = v0_1.clone();
                                        let v83 = v83.clone();
                                        let v9 = v9.clone();
                                        let v91 = v91.clone();
                                        move || {
                                            Documents::closure59(
                                                v0_1.clone(),
                                                v9,
                                                v83,
                                                match &v91 {
                                                    Documents::US19::US19_1(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                                (),
                                            )
                                        }
                                    }))
                                }
                            }
                        }
                        _ => {
                            let v108: Documents::US19 = Documents::method128(
                                v10,
                                v11,
                                v12,
                                v13,
                                v9,
                                v0_1.clone(),
                                LrcPtr::new(Documents::UH0::UH0_1(
                                    Func1::from(v2),
                                    LrcPtr::new(Documents::UH0::UH0_1(
                                        Func1::from(v3),
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    )),
                                )),
                            );
                            match &v108 {
                                Documents::US19::US19_0(
                                    v108_0_0,
                                    v108_0_1,
                                    v108_0_2,
                                    v108_0_3,
                                    v108_0_4,
                                    v108_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new(move || Documents::closure58((), ())),
                                    v108_0_1.clone(),
                                    v108_0_2.clone(),
                                    v108_0_3.clone(),
                                    v108_0_4.clone(),
                                    v108_0_5.clone(),
                                ),
                                _ => Documents::US20::US20_1(Func0::new({
                                    let v0_1 = v0_1.clone();
                                    let v9 = v9.clone();
                                    move || Documents::closure57(v0_1.clone(), v9, ())
                                })),
                            }
                        }
                    }
                }
                Documents::US19::US19_1(v7_1_0) => Documents::US20::US20_1(v7_1_0.clone()),
            };
            let v303: Documents::US20 = match &v127 {
                Documents::US20::US20_0(
                    v127_0_0,
                    v127_0_1,
                    v127_0_2,
                    v127_0_3,
                    v127_0_4,
                    v127_0_5,
                ) => v127.clone(),
                _ => {
                    let v150: Documents::US19 = if 0_i32 >= (v1_1) {
                        Documents::US19::US19_1(Func0::new({
                            let v1_1 = v1_1.clone();
                            move || Documents::closure96(v1_1, ())
                        }))
                    } else {
                        let v138: char = getCharAt(v0_1.clone(), 0_i32);
                        if (v138) == '\"' {
                            let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v138) {
                                (1_i32, 2_i32, 1_i32, v1_1)
                            } else {
                                (0_i32, 1_i32, 2_i32, v1_1)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v138 = v138.clone();
                                    move || Documents::closure44(v138, ())
                                }),
                                1_i32,
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v0_1 = v0_1.clone();
                                move || Documents::closure97(v0_1.clone(), ())
                            }))
                        }
                    };
                    match &v150 {
                        Documents::US19::US19_0(
                            v150_0_0,
                            v150_0_1,
                            v150_0_2,
                            v150_0_3,
                            v150_0_4,
                            v150_0_5,
                        ) => {
                            let v156: i32 = v150_0_5.clone();
                            let v155: i32 = v150_0_4.clone();
                            let v154: i32 = v150_0_3.clone();
                            let v153: i32 = v150_0_2.clone();
                            let v152: i32 = v150_0_1.clone();
                            let v157: bool = (v152) >= (v156);
                            let v178: Documents::US19 = if v157 {
                                Documents::US19::US19_1(Func0::new({
                                    let v153 = v153.clone();
                                    let v154 = v154.clone();
                                    let v155 = v155.clone();
                                    let v156 = v156.clone();
                                    move || Documents::closure82(v153, v154, v155, v156, ())
                                }))
                            } else {
                                let v160: char = getCharAt(v0_1.clone(), v152);
                                if (Documents::method142(v160, 0_i64)) == false {
                                    let patternInput_2: (i32, i32, i32, i32) = if '\n' == (v160) {
                                        ((v153) + (v155), (v154) + 1_i32, 1_i32, v156)
                                    } else {
                                        (v153, v154, (v155) + 1_i32, v156)
                                    };
                                    Documents::US19::US19_0(
                                        Func0::new({
                                            let v160 = v160.clone();
                                            move || Documents::closure52(v160, ())
                                        }),
                                        (v152) + 1_i32,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                        patternInput_2.3.clone(),
                                    )
                                } else {
                                    Documents::US19::US19_1(Func0::new({
                                        let v153 = v153.clone();
                                        let v154 = v154.clone();
                                        let v155 = v155.clone();
                                        let v156 = v156.clone();
                                        let v160 = v160.clone();
                                        move || {
                                            Documents::closure83(v153, v154, v155, v156, v160, ())
                                        }
                                    }))
                                }
                            };
                            let v190: Documents::US20 = match &v178 {
                                Documents::US19::US19_0(
                                    v178_0_0,
                                    v178_0_1,
                                    v178_0_2,
                                    v178_0_3,
                                    v178_0_4,
                                    v178_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new({
                                        let v178 = v178.clone();
                                        move || {
                                            Documents::closure84(
                                                match &v178 {
                                                    Documents::US19::US19_0(x, _, _, _, _, _) => {
                                                        x.clone()
                                                    }
                                                    _ => unreachable!(),
                                                }
                                                .clone(),
                                                (),
                                            )
                                        }
                                    }),
                                    v178_0_1.clone(),
                                    v178_0_2.clone(),
                                    v178_0_3.clone(),
                                    v178_0_4.clone(),
                                    v178_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v178_1_0) => {
                                    Documents::US20::US20_1(v178_1_0.clone())
                                }
                            };
                            let v205: Documents::US20 = match &v190 {
                                Documents::US20::US20_0(
                                    v190_0_0,
                                    v190_0_1,
                                    v190_0_2,
                                    v190_0_3,
                                    v190_0_4,
                                    v190_0_5,
                                ) => v190.clone(),
                                _ => Documents::method144(
                                    v153,
                                    v154,
                                    v155,
                                    v156,
                                    v152,
                                    v0_1.clone(),
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::new(
                                            move |arg10_0040_20: (
                                                string,
                                                i32,
                                                i32,
                                                i32,
                                                i32,
                                                i32,
                                            )| {
                                                Documents::closure98((), arg10_0040_20)
                                            },
                                        ),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            Func1::new(
                                                move |arg10_0040_21: (
                                                    string,
                                                    i32,
                                                    i32,
                                                    i32,
                                                    i32,
                                                    i32,
                                                )| {
                                                    Documents::closure102((), arg10_0040_21)
                                                },
                                            ),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                ),
                            };
                            let v224: Documents::US20 = match &v205 {
                                Documents::US20::US20_0(
                                    v205_0_0,
                                    v205_0_1,
                                    v205_0_2,
                                    v205_0_3,
                                    v205_0_4,
                                    v205_0_5,
                                ) => {
                                    let v210: i32 = v205_0_1.clone();
                                    if (v210) == (v152) {
                                        Documents::US20::US20_1(Func0::new(move || {
                                            Documents::closure92((), ())
                                        }))
                                    } else {
                                        Documents::method149(
                                            v0_1.clone(),
                                            v205_0_0.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v210,
                                            ((v156) - (v210)) + 2_i32,
                                            v205_0_2.clone(),
                                            v205_0_3.clone(),
                                            v205_0_4.clone(),
                                            v205_0_5.clone(),
                                        )
                                    }
                                }
                                _ => Documents::US20::US20_0(
                                    Func0::new(move || Documents::closure91((), ())),
                                    v152,
                                    v153,
                                    v154,
                                    v155,
                                    v156,
                                ),
                            };
                            match &v224 {
                                Documents::US20::US20_0(
                                    v224_0_0,
                                    v224_0_1,
                                    v224_0_2,
                                    v224_0_3,
                                    v224_0_4,
                                    v224_0_5,
                                ) => {
                                    let v230: i32 = v224_0_5.clone();
                                    let v229: i32 = v224_0_4.clone();
                                    let v228: i32 = v224_0_3.clone();
                                    let v227: i32 = v224_0_2.clone();
                                    let v226: i32 = v224_0_1.clone();
                                    let v250: Documents::US19 = if (v226) >= (v230) {
                                        Documents::US19::US19_1(Func0::new({
                                            let v227 = v227.clone();
                                            let v228 = v228.clone();
                                            let v229 = v229.clone();
                                            let v230 = v230.clone();
                                            move || Documents::closure43(v227, v228, v229, v230, ())
                                        }))
                                    } else {
                                        let v234: char = getCharAt(v0_1.clone(), v226);
                                        if (v234) == '\"' {
                                            let patternInput_4: (i32, i32, i32, i32) =
                                                if '\n' == (v234) {
                                                    ((v227) + (v229), (v228) + 1_i32, 1_i32, v230)
                                                } else {
                                                    (v227, v228, (v229) + 1_i32, v230)
                                                };
                                            Documents::US19::US19_0(
                                                Func0::new({
                                                    let v234 = v234.clone();
                                                    move || Documents::closure44(v234, ())
                                                }),
                                                (v226) + 1_i32,
                                                patternInput_4.0.clone(),
                                                patternInput_4.1.clone(),
                                                patternInput_4.2.clone(),
                                                patternInput_4.3.clone(),
                                            )
                                        } else {
                                            Documents::US19::US19_1(Func0::new({
                                                let v0_1 = v0_1.clone();
                                                let v226 = v226.clone();
                                                let v227 = v227.clone();
                                                let v228 = v228.clone();
                                                let v229 = v229.clone();
                                                move || {
                                                    Documents::closure45(
                                                        v229,
                                                        v228,
                                                        v227,
                                                        v226,
                                                        v0_1.clone(),
                                                        (),
                                                    )
                                                }
                                            }))
                                        }
                                    };
                                    match &v250 {
                                        Documents::US19::US19_0(
                                            v250_0_0,
                                            v250_0_1,
                                            v250_0_2,
                                            v250_0_3,
                                            v250_0_4,
                                            v250_0_5,
                                        ) => Documents::US20::US20_0(
                                            v224_0_0.clone(),
                                            v250_0_1.clone(),
                                            v250_0_2.clone(),
                                            v250_0_3.clone(),
                                            v250_0_4.clone(),
                                            v250_0_5.clone(),
                                        ),
                                        Documents::US19::US19_1(v250_1_0) => {
                                            Documents::US20::US20_1(Func0::new({
                                                let v0_1 = v0_1.clone();
                                                let v152 = v152.clone();
                                                let v226 = v226.clone();
                                                let v250 = v250.clone();
                                                move || {
                                                    Documents::closure59(
                                                        v0_1.clone(),
                                                        v152,
                                                        v226,
                                                        match &v250 {
                                                            Documents::US19::US19_1(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        }
                                                        .clone(),
                                                        (),
                                                    )
                                                }
                                            }))
                                        }
                                    }
                                }
                                _ => {
                                    let v282: Documents::US19 = if v157 {
                                        Documents::US19::US19_1(Func0::new({
                                            let v153 = v153.clone();
                                            let v154 = v154.clone();
                                            let v155 = v155.clone();
                                            let v156 = v156.clone();
                                            move || Documents::closure43(v153, v154, v155, v156, ())
                                        }))
                                    } else {
                                        let v266: char = getCharAt(v0_1.clone(), v152);
                                        if (v266) == '\"' {
                                            let patternInput_3: (i32, i32, i32, i32) =
                                                if '\n' == (v266) {
                                                    ((v153) + (v155), (v154) + 1_i32, 1_i32, v156)
                                                } else {
                                                    (v153, v154, (v155) + 1_i32, v156)
                                                };
                                            Documents::US19::US19_0(
                                                Func0::new({
                                                    let v266 = v266.clone();
                                                    move || Documents::closure44(v266, ())
                                                }),
                                                (v152) + 1_i32,
                                                patternInput_3.0.clone(),
                                                patternInput_3.1.clone(),
                                                patternInput_3.2.clone(),
                                                patternInput_3.3.clone(),
                                            )
                                        } else {
                                            Documents::US19::US19_1(Func0::new({
                                                let v0_1 = v0_1.clone();
                                                let v152 = v152.clone();
                                                let v153 = v153.clone();
                                                let v154 = v154.clone();
                                                let v155 = v155.clone();
                                                move || {
                                                    Documents::closure45(
                                                        v155,
                                                        v154,
                                                        v153,
                                                        v152,
                                                        v0_1.clone(),
                                                        (),
                                                    )
                                                }
                                            }))
                                        }
                                    };
                                    match &v282 {
                                        Documents::US19::US19_0(
                                            v282_0_0,
                                            v282_0_1,
                                            v282_0_2,
                                            v282_0_3,
                                            v282_0_4,
                                            v282_0_5,
                                        ) => Documents::US20::US20_0(
                                            Func0::new(move || Documents::closure58((), ())),
                                            v282_0_1.clone(),
                                            v282_0_2.clone(),
                                            v282_0_3.clone(),
                                            v282_0_4.clone(),
                                            v282_0_5.clone(),
                                        ),
                                        _ => Documents::US20::US20_1(Func0::new({
                                            let v0_1 = v0_1.clone();
                                            let v152 = v152.clone();
                                            move || Documents::closure57(v0_1.clone(), v152, ())
                                        })),
                                    }
                                }
                            }
                        }
                        Documents::US19::US19_1(v150_1_0) => {
                            Documents::US20::US20_1(v150_1_0.clone())
                        }
                    }
                }
            };
            let v341: Documents::US20 = match &v303 {
                Documents::US20::US20_0(
                    v303_0_0,
                    v303_0_1,
                    v303_0_2,
                    v303_0_3,
                    v303_0_4,
                    v303_0_5,
                ) => v303.clone(),
                _ => {
                    let v328: Documents::US19 = if 0_i32 >= (v1_1) {
                        Documents::US19::US19_1(Func0::new({
                            let v1_1 = v1_1.clone();
                            move || Documents::closure104(v1_1, ())
                        }))
                    } else {
                        let v314: char = getCharAt(v0_1.clone(), 0_i32);
                        if (Documents::method150(v314, 0_i64)) == false {
                            let patternInput_5: (i32, i32, i32, i32) = if '\n' == (v314) {
                                (1_i32, 2_i32, 1_i32, v1_1)
                            } else {
                                (0_i32, 1_i32, 2_i32, v1_1)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v314 = v314.clone();
                                    move || Documents::closure52(v314, ())
                                }),
                                1_i32,
                                patternInput_5.0.clone(),
                                patternInput_5.1.clone(),
                                patternInput_5.2.clone(),
                                patternInput_5.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v1_1 = v1_1.clone();
                                let v314 = v314.clone();
                                move || Documents::closure105(v1_1, v314, ())
                            }))
                        }
                    };
                    match &v328 {
                        Documents::US19::US19_0(
                            v328_0_0,
                            v328_0_1,
                            v328_0_2,
                            v328_0_3,
                            v328_0_4,
                            v328_0_5,
                        ) => Documents::method151(
                            v0_1.clone(),
                            v328_0_1.clone(),
                            v328_0_2.clone(),
                            v328_0_3.clone(),
                            v328_0_4.clone(),
                            v328_0_5.clone(),
                        ),
                        Documents::US19::US19_1(v328_1_0) => {
                            Documents::US20::US20_1(v328_1_0.clone())
                        }
                    }
                }
            };
            let v369: Documents::US20 = match &v341 {
                Documents::US20::US20_0(
                    v341_0_0,
                    v341_0_1,
                    v341_0_2,
                    v341_0_3,
                    v341_0_4,
                    v341_0_5,
                ) => v341.clone(),
                _ => {
                    let v355: Documents::US29 = Documents::method152(
                        v0_1.clone(),
                        LrcPtr::new(Documents::UH2::UH2_0),
                        0_i32,
                        (v1_1) + 2_i32,
                        0_i32,
                        1_i32,
                        1_i32,
                        v1_1,
                    );
                    match &v355 {
                        Documents::US29::US29_0(
                            v355_0_0,
                            v355_0_1,
                            v355_0_2,
                            v355_0_3,
                            v355_0_4,
                            v355_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new({
                                let v355 = v355.clone();
                                move || {
                                    Documents::closure111(
                                        match &v355 {
                                            Documents::US29::US29_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v355_0_1.clone(),
                            v355_0_2.clone(),
                            v355_0_3.clone(),
                            v355_0_4.clone(),
                            v355_0_5.clone(),
                        ),
                        Documents::US29::US29_1(v355_1_0) => {
                            Documents::US20::US20_1(v355_1_0.clone())
                        }
                    }
                }
            };
            let v380: Documents::US20 = if let Documents::US20::US20_0(
                v369_0_0,
                v369_0_1,
                v369_0_2,
                v369_0_3,
                v369_0_4,
                v369_0_5,
            ) = &v369
            {
                if (v369_0_1.clone()) == 0_i32 {
                    Documents::US20::US20_1(Func0::new(move || Documents::closure112((), ())))
                } else {
                    v369.clone()
                }
            } else {
                v369.clone()
            };
            let v406: Documents::US20 = match &v380 {
                Documents::US20::US20_0(
                    v380_0_0,
                    v380_0_1,
                    v380_0_2,
                    v380_0_3,
                    v380_0_4,
                    v380_0_5,
                ) => {
                    let v384: i32 = v380_0_1.clone();
                    let v390: i32 = ((v1_1) - (v384)) + 2_i32;
                    Documents::method153(
                        v0_1.clone(),
                        LrcPtr::new(Documents::UH2::UH2_1(
                            (v380_0_0)(),
                            LrcPtr::new(Documents::UH2::UH2_0),
                        )),
                        v384,
                        v390,
                        v380_0_2.clone(),
                        v380_0_3.clone(),
                        v380_0_4.clone(),
                        v380_0_5.clone(),
                    )
                }
                Documents::US20::US20_1(v380_1_0) => Documents::US20::US20_1(v380_1_0.clone()),
            };
            let v421: Documents::US29 = match &v406 {
                Documents::US20::US20_0(
                    v406_0_0,
                    v406_0_1,
                    v406_0_2,
                    v406_0_3,
                    v406_0_4,
                    v406_0_5,
                ) => Documents::method155(
                    v0_1.clone(),
                    LrcPtr::new(Documents::UH2::UH2_1(
                        (v406_0_0)(),
                        LrcPtr::new(Documents::UH2::UH2_0),
                    )),
                    v406_0_1.clone(),
                    v406_0_2.clone(),
                    v406_0_3.clone(),
                    v406_0_4.clone(),
                    v406_0_5.clone(),
                ),
                _ => Documents::US29::US29_0(
                    Func0::new(move || Documents::closure116((), ())),
                    0_i32,
                    0_i32,
                    1_i32,
                    1_i32,
                    v1_1,
                ),
            };
            let v433: Documents::US30 = match &v421 {
                Documents::US29::US29_0(
                    v421_0_0,
                    v421_0_1,
                    v421_0_2,
                    v421_0_3,
                    v421_0_4,
                    v421_0_5,
                ) => {
                    let v427: i32 = v421_0_5.clone();
                    let v426: i32 = v421_0_4.clone();
                    let v425: i32 = v421_0_3.clone();
                    let v424: i32 = v421_0_2.clone();
                    Documents::US30::US30_0(
                        v421_0_0.clone(),
                        Func0::new({
                            let v0_1 = v0_1.clone();
                            let v421 = v421.clone();
                            let v424 = v424.clone();
                            let v425 = v425.clone();
                            let v426 = v426.clone();
                            let v427 = v427.clone();
                            move || {
                                Documents::closure74(
                                    v0_1.clone(),
                                    v424,
                                    v425,
                                    v426,
                                    v427,
                                    match &v421 {
                                        Documents::US29::US29_0(_, x, _, _, _, _) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    (),
                                )
                            }
                        }),
                        v424,
                        v425,
                        v426,
                        v427,
                    )
                }
                Documents::US29::US29_1(v421_1_0) => Documents::US30::US30_1(v421_1_0.clone()),
            };
            let v446: Documents::US31 = match &v433 {
                Documents::US30::US30_0(
                    v433_0_0,
                    v433_0_1,
                    v433_0_2,
                    v433_0_3,
                    v433_0_4,
                    v433_0_5,
                ) => Documents::US31::US31_0(
                    (v433_0_0)(),
                    (v433_0_1)(),
                    v433_0_2.clone(),
                    v433_0_3.clone(),
                    v433_0_4.clone(),
                    v433_0_5.clone(),
                ),
                Documents::US30::US30_1(v433_1_0) => Documents::US31::US31_1(v433_1_0.clone()),
            };
            let v487: Documents::US32 = match &v446 {
                Documents::US31::US31_0(
                    v446_0_0,
                    v446_0_1,
                    v446_0_2,
                    v446_0_3,
                    v446_0_4,
                    v446_0_5,
                ) => Documents::US32::US32_0(toArray_1(Documents::method156(
                    v446_0_0.clone(),
                    empty::<string>(),
                ))),
                Documents::US31::US31_1(v446_1_0) => Documents::US32::US32_1(v446_1_0.clone()),
            };
            match &v487 {
                Documents::US32::US32_0(v487_0_0) => Documents::US28::US28_0(v487_0_0.clone()),
                Documents::US32::US32_1(v487_1_0) => Documents::US28::US28_1((v487_1_0)()),
            }
        }
        pub fn method159(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("file_name"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method160(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("arguments"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method161(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("options"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method162(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("command"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method163(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("cancellation_token"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method164(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("environment_variables"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method165(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("on_line"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method166(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("stdin"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method167(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("trace"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method168(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("working_directory"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method169(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("stderr"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method158(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
            v9: bool,
        ) -> string {
            let v19: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v19.clone());
            Documents::method159(v19.clone());
            Documents::method20(v19.clone());
            Documents::method15(v19.clone(), v0_1);
            Documents::method50(v19.clone());
            Documents::method160(v19.clone());
            Documents::method20(v19.clone());
            Documents::method15(v19.clone(), v1_1);
            Documents::method50(v19.clone());
            Documents::method161(v19.clone());
            Documents::method20(v19.clone());
            Documents::method18(v19.clone());
            Documents::method162(v19.clone());
            Documents::method20(v19.clone());
            Documents::method15(v19.clone(), v2);
            Documents::method50(v19.clone());
            Documents::method163(v19.clone());
            Documents::method20(v19.clone());
            {
                let v822: std::string::String = format!("{:#?}", v3);
                Documents::method15(v19.clone(), fable_library_rust::String_::fromString(v822));
                Documents::method50(v19.clone());
                Documents::method164(v19.clone());
                Documents::method20(v19.clone());
                Documents::method15(v19.clone(), sprintf!("{:?}", v4));
                Documents::method50(v19.clone());
                Documents::method165(v19.clone());
                Documents::method20(v19.clone());
                {
                    let v1275: std::string::String = format!("{:#?}", v5);
                    Documents::method15(
                        v19.clone(),
                        fable_library_rust::String_::fromString(v1275),
                    );
                    Documents::method50(v19.clone());
                    Documents::method166(v19.clone());
                    Documents::method20(v19.clone());
                    {
                        let v1541: std::string::String = format!("{:#?}", v6);
                        Documents::method15(
                            v19.clone(),
                            fable_library_rust::String_::fromString(v1541),
                        );
                        Documents::method50(v19.clone());
                        Documents::method167(v19.clone());
                        Documents::method20(v19.clone());
                        Documents::method15(
                            v19.clone(),
                            if v7 { string("true") } else { string("false") },
                        );
                        Documents::method50(v19.clone());
                        Documents::method168(v19.clone());
                        Documents::method20(v19.clone());
                        {
                            let v1985: std::string::String = format!("{:#?}", v8);
                            Documents::method15(
                                v19.clone(),
                                fable_library_rust::String_::fromString(v1985),
                            );
                            Documents::method50(v19.clone());
                            Documents::method169(v19.clone());
                            Documents::method20(v19.clone());
                            Documents::method15(
                                v19.clone(),
                                if v9 { string("true") } else { string("false") },
                            );
                            Documents::method21(v19.clone());
                            Documents::method21(v19.clone());
                            v19.l0.get().clone()
                        }
                    }
                }
            }
        }
        pub fn method157(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
            v17: bool,
        ) -> string {
            let v18: string = Documents::method158(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options"),
                    )),
                    string(" / "),
                )),
                (v18),
            ))
        }
        pub fn closure120(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: string,
            v9: Vec<std::string::String>,
            unitVar: (),
        ) {
            fn v40() {
                Documents::closure10((), ());
            }
            let v41: () = {
                v40();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v119: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v533: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v119,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v157: () = {
                    v40();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v200: Option<i64> = patternInput_1.5.clone();
                let v199: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v198: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v197: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v196: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v195: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v248: string = Documents::method157(
                    v195.clone(),
                    v196.clone(),
                    v197.clone(),
                    v198.clone(),
                    v199.clone(),
                    v200.clone(),
                    Documents::method8(v195, v196, v197, v198, v199, v200),
                    Documents::method80(),
                    v8,
                    sprintf!("{:?}", v9),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                    v7,
                );
                let v279: () = {
                    v40();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v318: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v317: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v361: () = {
                    Documents::closure12(v317.clone(), ());
                    ()
                };
                println!("{}", v248.clone());
                (v318.l0.get().clone())(v248);
                Documents::US7::US7_0(
                    v317,
                    v318,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure121(
            unitVar: (),
            v0_1: Option<std::process::Child>,
        ) -> Option<std::process::Child> {
            v0_1
        }
        pub fn method170() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Documents::closure121((), v))
        }
        pub fn closure122(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US33 {
            Documents::US33::US33_0(v0_1)
        }
        pub fn method171()
        -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US33>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure122((), v)
                },
            )
        }
        pub fn closure123(unitVar: (), v0_1: std::string::String) -> Documents::US33 {
            Documents::US33::US33_1(v0_1)
        }
        pub fn method172() -> Func1<std::string::String, Documents::US33> {
            Func1::new(move |v: std::string::String| Documents::closure123((), v))
        }
        pub fn method174(
            v0_1: std::string::String,
            v1_1: string,
            v2: string,
            v3: string,
            v4: Option<CancellationToken>,
            v5: Array<(string, string)>,
            v6: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v7: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v8: bool,
            v9: Option<string>,
            v10: bool,
        ) -> string {
            let v20: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v20.clone());
            Documents::method51(v20.clone());
            Documents::method20(v20.clone());
            {
                let v166: std::string::String = format!("{:#?}", v0_1);
                Documents::method15(v20.clone(), fable_library_rust::String_::fromString(v166));
                Documents::method50(v20.clone());
                Documents::method159(v20.clone());
                Documents::method20(v20.clone());
                Documents::method15(v20.clone(), v1_1);
                Documents::method50(v20.clone());
                Documents::method160(v20.clone());
                Documents::method20(v20.clone());
                Documents::method15(v20.clone(), v2);
                Documents::method50(v20.clone());
                Documents::method161(v20.clone());
                Documents::method20(v20.clone());
                Documents::method18(v20.clone());
                Documents::method162(v20.clone());
                Documents::method20(v20.clone());
                Documents::method15(v20.clone(), v3);
                Documents::method50(v20.clone());
                Documents::method163(v20.clone());
                Documents::method20(v20.clone());
                {
                    let v1089: std::string::String = format!("{:#?}", v4);
                    Documents::method15(
                        v20.clone(),
                        fable_library_rust::String_::fromString(v1089),
                    );
                    Documents::method50(v20.clone());
                    Documents::method164(v20.clone());
                    Documents::method20(v20.clone());
                    Documents::method15(v20.clone(), sprintf!("{:?}", v5));
                    Documents::method50(v20.clone());
                    Documents::method165(v20.clone());
                    Documents::method20(v20.clone());
                    {
                        let v1542: std::string::String = format!("{:#?}", v6);
                        Documents::method15(
                            v20.clone(),
                            fable_library_rust::String_::fromString(v1542),
                        );
                        Documents::method50(v20.clone());
                        Documents::method166(v20.clone());
                        Documents::method20(v20.clone());
                        {
                            let v1808: std::string::String = format!("{:#?}", v7);
                            Documents::method15(
                                v20.clone(),
                                fable_library_rust::String_::fromString(v1808),
                            );
                            Documents::method50(v20.clone());
                            Documents::method167(v20.clone());
                            Documents::method20(v20.clone());
                            Documents::method15(
                                v20.clone(),
                                if v8 { string("true") } else { string("false") },
                            );
                            Documents::method50(v20.clone());
                            Documents::method168(v20.clone());
                            Documents::method20(v20.clone());
                            {
                                let v2252: std::string::String = format!("{:#?}", v9);
                                Documents::method15(
                                    v20.clone(),
                                    fable_library_rust::String_::fromString(v2252),
                                );
                                Documents::method50(v20.clone());
                                Documents::method169(v20.clone());
                                Documents::method20(v20.clone());
                                Documents::method15(
                                    v20.clone(),
                                    if v10 { string("true") } else { string("false") },
                                );
                                Documents::method21(v20.clone());
                                Documents::method21(v20.clone());
                                v20.l0.get().clone()
                            }
                        }
                    }
                }
            }
        }
        pub fn method173(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
            v9: string,
            v10: string,
            v11: string,
            v12: Option<CancellationToken>,
            v13: Array<(string, string)>,
            v14: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v15: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v16: bool,
            v17: Option<string>,
            v18: bool,
        ) -> string {
            let v19: string =
                Documents::method174(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options / child error"),
                    )),
                    string(" / "),
                )),
                (v19),
            ))
        }
        pub fn closure124(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: string,
            v9: Vec<std::string::String>,
            v10: std::string::String,
            unitVar: (),
        ) {
            fn v41() {
                Documents::closure10((), ());
            }
            let v42: () = {
                v41();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v120: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v534: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v120,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v158: () = {
                    v41();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v201: Option<i64> = patternInput_1.5.clone();
                let v200: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v199: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v198: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v197: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v196: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v249: string = Documents::method173(
                    v196.clone(),
                    v197.clone(),
                    v198.clone(),
                    v199.clone(),
                    v200.clone(),
                    v201.clone(),
                    Documents::method8(v196, v197, v198, v199, v200, v201),
                    Documents::method96(),
                    v10,
                    v8,
                    sprintf!("{:?}", v9),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                    v7,
                );
                let v280: () = {
                    v41();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v319: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v318: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v362: () = {
                    Documents::closure12(v318.clone(), ());
                    ()
                };
                println!("{}", v249.clone());
                (v319.l0.get().clone())(v249);
                Documents::US7::US7_0(
                    v318,
                    v319,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method175(
            v0_1: std::sync::MutexGuard<Option<std::process::Child>>,
        ) -> std::sync::MutexGuard<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure125(
            unitVar: (),
            v0_1: Option<std::process::ChildStdin>,
        ) -> Option<std::process::ChildStdin> {
            v0_1
        }
        pub fn method176()
        -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Documents::closure125((), v))
        }
        pub fn closure126(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method177() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure126((), v)
            })
        }
        pub fn method178() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure126((), v)
            })
        }
        pub fn closure127(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method179() -> Func1<
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>| {
                    Documents::closure127((), v)
                },
            )
        }
        pub fn closure128(unitVar: (), v0_1: std::string::String) -> Documents::US35 {
            Documents::US35::US35_0(v0_1)
        }
        pub fn method180() -> Func1<std::string::String, Documents::US35> {
            Func1::new(move |v: std::string::String| Documents::closure128((), v))
        }
        pub fn closure129(unitVar: (), v0_1: std::string::String) -> Documents::US35 {
            Documents::US35::US35_1(v0_1)
        }
        pub fn method181() -> Func1<std::string::String, Documents::US35> {
            Func1::new(move |v: std::string::String| Documents::closure129((), v))
        }
        pub fn method184(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("trace\'"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method183(v0_1: bool, v1_1: std::string::String) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v11.clone());
            Documents::method184(v11.clone());
            Documents::method20(v11.clone());
            Documents::method15(
                v11.clone(),
                if v0_1 {
                    string("true")
                } else {
                    string("false")
                },
            );
            Documents::method50(v11.clone());
            Documents::method132(v11.clone());
            Documents::method20(v11.clone());
            {
                let v335: std::string::String = format!("{:#?}", v1_1);
                Documents::method15(v11.clone(), fable_library_rust::String_::fromString(v335));
                Documents::method21(v11.clone());
                v11.l0.get().clone()
            }
        }
        pub fn method182(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: bool,
            v9: std::string::String,
        ) -> string {
            let v10: string = Documents::method183(v8, v9);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.stdio_line"),
                    )),
                    string(" / "),
                )),
                (v10),
            ))
        }
        pub fn closure130(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            fn v32() {
                Documents::closure10((), ());
            }
            let v33: () = {
                v32();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v111: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v514: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v111,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v149: () = {
                    v32();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v192: Option<i64> = patternInput_1.5.clone();
                let v191: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v190: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v189: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v188: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v187: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v229: string = Documents::method182(
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    Documents::method8(v187, v188, v189, v190, v191, v192),
                    Documents::method96(),
                    v0_1,
                    v1_1,
                );
                let v260: () = {
                    v32();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v299: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v298: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v342: () = {
                    Documents::closure12(v298.clone(), ());
                    ()
                };
                println!("{}", v229.clone());
                (v299.l0.get().clone())(v229);
                Documents::US7::US7_0(
                    v298,
                    v299,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method185() -> string {
            let v3: &str = inline_colorization::color_bright_black;
            let v17: std::string::String = String::from(v3);
            let v293: string = append(
                (fable_library_rust::String_::fromString(v17)),
                (Documents::method13(getCharAt(toLower(string("Verbose")), 0_i32))),
            );
            let v306: &str = inline_colorization::color_reset;
            let v320: std::string::String = String::from(v306);
            append((v293), (fable_library_rust::String_::fromString(v320)))
        }
        pub fn method187() -> string {
            let v9: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            v9.l0.get().clone()
        }
        pub fn method186(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
        ) -> string {
            let v9: string = Documents::method187();
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        (v8),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure131(v0_1: string, unitVar: ()) {
            fn v31() {
                Documents::closure10((), ());
            }
            let v32: () = {
                v31();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v110: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v516: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                0_i32
                    >= (find(
                        v110,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v148: () = {
                    v31();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v191: Option<i64> = patternInput_1.5.clone();
                let v190: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v189: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v188: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v187: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v186: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v231: string = if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method186(
                        v186.clone(),
                        v187.clone(),
                        v188.clone(),
                        v189.clone(),
                        v190.clone(),
                        v191.clone(),
                        Documents::method8(v186, v187, v188, v189, v190, v191),
                        Documents::method185(),
                        v0_1,
                    )
                };
                let v262: () = {
                    v31();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v301: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v300: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v344: () = {
                    Documents::closure12(v300.clone(), ());
                    ()
                };
                println!("{}", v231.clone());
                (v301.l0.get().clone())(v231);
                Documents::US7::US7_0(
                    v300,
                    v301,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure132(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method188()
        -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure132((), v)
            })
        }
        pub fn method189(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure133(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Documents::US36 {
            Documents::US36::US36_0(v0_1)
        }
        pub fn method190() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US36,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure133((), v)
                },
            )
        }
        pub fn method191(
            v0_1: std::sync::MutexGuard<Option<std::process::ChildStdin>>,
        ) -> std::sync::MutexGuard<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn closure134(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Documents::US37 {
            Documents::US37::US37_0(v0_1)
        }
        pub fn method192()
        -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US37>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure134((), v)
                },
            )
        }
        pub fn method193(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure135(unitVar: (), v0_1: std::process::Output) -> Documents::US38 {
            Documents::US38::US38_0(v0_1)
        }
        pub fn method194() -> Func1<std::process::Output, Documents::US38> {
            Func1::new(move |v: std::process::Output| Documents::closure135((), v))
        }
        pub fn closure136(unitVar: (), v0_1: std::string::String) -> Documents::US38 {
            Documents::US38::US38_1(v0_1)
        }
        pub fn method195() -> Func1<std::string::String, Documents::US38> {
            Func1::new(move |v: std::string::String| Documents::closure136((), v))
        }
        pub fn method196(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
            v9: string,
            v10: string,
            v11: string,
            v12: Option<CancellationToken>,
            v13: Array<(string, string)>,
            v14: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v15: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v16: bool,
            v17: Option<string>,
            v18: bool,
        ) -> string {
            let v19: string =
                Documents::method174(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options / output error"),
                    )),
                    string(" / "),
                )),
                (v19),
            ))
        }
        pub fn closure137(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: string,
            v9: Vec<std::string::String>,
            v10: std::string::String,
            unitVar: (),
        ) {
            fn v41() {
                Documents::closure10((), ());
            }
            let v42: () = {
                v41();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v120: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v534: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v120,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v158: () = {
                    v41();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v201: Option<i64> = patternInput_1.5.clone();
                let v200: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v199: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v198: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v197: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v196: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v249: string = Documents::method196(
                    v196.clone(),
                    v197.clone(),
                    v198.clone(),
                    v199.clone(),
                    v200.clone(),
                    v201.clone(),
                    Documents::method8(v196, v197, v198, v199, v200, v201),
                    Documents::method96(),
                    v10,
                    v8,
                    sprintf!("{:?}", v9),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                    v7,
                );
                let v280: () = {
                    v41();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v319: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v318: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v362: () = {
                    Documents::closure12(v318.clone(), ());
                    ()
                };
                println!("{}", v249.clone());
                (v319.l0.get().clone())(v249);
                Documents::US7::US7_0(
                    v318,
                    v319,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure138(unitVar: (), v0_1: i32) -> Documents::US39 {
            Documents::US39::US39_0(v0_1)
        }
        pub fn method197() -> Func1<i32, Documents::US39> {
            Func1::new(move |v: i32| Documents::closure138((), v))
        }
        pub fn method198(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method199(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method199: loop {
                break '_method199 (if (v1_1.get().clone()) <= 0_i32 {
                    0_i32
                } else {
                    let v3: i32 = (v1_1.get().clone()) - 1_i32;
                    if Documents::method24(getCharAt(v0_1.get().clone(), v3), 0_i64) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v3;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method199;
                    } else {
                        v3
                    }
                });
            }
        }
        pub fn method200(v0_1: LrcPtr<Documents::UH2>, v1_1: string) -> (string, string) {
            let patternInput_2: (string, string) =
                if let Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) = v0_1.as_ref() {
                    let patternInput: (string, string) =
                        Documents::method200(v0_1_1_1.clone(), v1_1.clone());
                    (
                        append(
                            (append((v0_1_1_0.clone()), (patternInput.1.clone()))),
                            (patternInput.0.clone()),
                        ),
                        string("\n"),
                    )
                } else {
                    let patternInput_1: (string, string) =
                        if let Documents::UH2::UH2_0 = v0_1.as_ref() {
                            (v1_1.clone(), v1_1.clone())
                        } else {
                            (v1_1.clone(), v1_1)
                        };
                    (patternInput_1.0.clone(), patternInput_1.1.clone())
                };
            (patternInput_2.0.clone(), patternInput_2.1.clone())
        }
        pub fn method201() -> string {
            string("\n")
        }
        pub fn method204(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("exit_code"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method205(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("std_trace_length"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method203(v0_1: string, v1_1: i32, v2: i32) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method159(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), v0_1);
            Documents::method50(v12.clone());
            Documents::method204(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), sprintf!("{}", v1_1));
            Documents::method50(v12.clone());
            Documents::method205(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), sprintf!("{}", v2));
            Documents::method21(v12.clone());
            v12.l0.get().clone()
        }
        pub fn method202(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: i32,
            v10: i32,
        ) -> string {
            let v11: string = Documents::method203(v8, v9, v10);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options / result"),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure139(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            fn v33() {
                Documents::closure10((), ());
            }
            let v34: () = {
                v33();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v112: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v516: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                0_i32
                    >= (find(
                        v112,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v150: () = {
                    v33();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v193: Option<i64> = patternInput_1.5.clone();
                let v192: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v191: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v190: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v189: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v188: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v231: string = Documents::method202(
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    Documents::method8(v188, v189, v190, v191, v192, v193),
                    Documents::method185(),
                    v0_1,
                    v1_1,
                    length(v2),
                );
                let v262: () = {
                    v33();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v301: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v300: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v344: () = {
                    Documents::closure12(v300.clone(), ());
                    ()
                };
                println!("{}", v231.clone());
                (v301.l0.get().clone())(v231);
                Documents::US7::US7_0(
                    v300,
                    v301,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method104(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
        ) -> (i32, string) {
            let v9: Documents::US18 = Documents::method106(Documents::method105(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
                v7,
            ));
            let patternInput: (string, Documents::US5) = match &v9 {
                Documents::US18::US18_0(v9_0_0, v9_0_1) => (v9_0_0.clone(), v9_0_1.clone()),
                Documents::US18::US18_1(v9_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Error x: "),
                        v9_1_0.clone()
                    ])),
                ),
            };
            let v29: Documents::US5 = patternInput.1.clone();
            let v28: string = patternInput.0.clone();
            let v34: Documents::US28 = Documents::method141(match &v29 {
                Documents::US5::US5_0(v29_0_0) => match &v29 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            });
            let v50: Array<string> = match &v34 {
                Documents::US28::US28_0(v34_0_0) => v34_0_0.clone(),
                Documents::US28::US28_1(v34_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Error x: "),
                        v34_1_0.clone()
                    ])),
                ),
            };
            let v52: Vec<string> = v50.to_vec();
            let v54: bool = true;
            let _vec_map: Vec<_> = v52
                .into_iter()
                .map(|x| {
                    //;
                    let v56: string = x;
                    let v70: &str = &*v56;
                    let v155: std::string::String = String::from(v70);
                    let v228: bool = true;
                    v155
                })
                .collect::<Vec<_>>();
            let v230: Vec<std::string::String> = _vec_map;
            let v793: () = {
                Documents::closure120(
                    v0_1.clone(),
                    v1_1.clone(),
                    v2.clone(),
                    v3.clone(),
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v7,
                    v28.clone(),
                    v230.clone(),
                    (),
                );
                ()
            };
            let _capture_v1366: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_5: LrcPtr<(i32, string)> = (Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v230 = v230.clone();
                    let v28 = v28.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    let v7 = v7.clone();
                    move || {
                        let v1368: std::process::Command =
                            std::process::Command::new(&*v28.clone());
                        let v1370: bool = true;
                        let mut v1368 = v1368;
                        let v1372: bool = true;
                        std::process::Command::args(&mut v1368, &*v230.clone());
                        let v1374: std::process::Command = v1368;
                        let v1376: std::process::Stdio = std::process::Stdio::piped();
                        let v1378: bool = true;
                        let mut v1374 = v1374;
                        let v1380: bool = true;
                        std::process::Command::stdout(&mut v1374, std::process::Stdio::piped());
                        let v1382: std::process::Command = v1374;
                        let v1384: std::process::Stdio = std::process::Stdio::piped();
                        let v1386: bool = true;
                        let mut v1382 = v1382;
                        let v1388: bool = true;
                        std::process::Command::stderr(&mut v1382, std::process::Stdio::piped());
                        let v1390: std::process::Command = v1382;
                        let v1392: std::process::Stdio = std::process::Stdio::piped();
                        let v1394: bool = true;
                        let mut v1390 = v1390;
                        let v1396: bool = true;
                        std::process::Command::stdin(&mut v1390, std::process::Stdio::piped());
                        let v1398: std::process::Command = v1390;
                        let v1460: Documents::US5 = defaultValue(
                            Documents::US5::US5_1,
                            map(Documents::method6(), v6.clone()),
                        );
                        let v1483: std::process::Command = match &v1460 {
                            Documents::US5::US5_0(v1460_0_0) => {
                                let v1473: bool = true;
                                let mut v1398 = v1398;
                                let v1475: bool = true;
                                std::process::Command::current_dir(
                                    &mut v1398,
                                    &*match &v1460 {
                                        Documents::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                );
                                v1398
                            }
                            _ => {
                                let v1479: std::process::Command = v1398;
                                v1479
                            }
                        };
                        let v1505: std::process::Command =
                            if (get_Count(v2.clone()) as u64) == 0_u64 {
                                v1483
                            } else {
                                let v1487: Vec<(string, string)> = v2.clone().to_vec();
                                let v1489: bool = true;
                                let _vec_fold_ = v1487.into_iter().fold(v1483, |acc, x| {
                                    //;
                                    let v1491: std::process::Command = acc;
                                    let patternInput_1: (string, string) = x;
                                    let v1496: bool = true;
                                    let mut v1491 = v1491;
                                    let v1498: bool = true;
                                    std::process::Command::env(
                                        &mut v1491,
                                        &*patternInput_1.0.clone(),
                                        &*patternInput_1.1.clone(),
                                    );
                                    let v1500: std::process::Command = v1491;
                                    let v1502: bool = true;
                                    v1500
                                });
                                _vec_fold_
                            };
                        let v1507: bool = true;
                        let mut v1505 = v1505;
                        let v1509: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(&mut v1505);
                        let v1510 = Documents::method89();
                        let v1514: Result<std::process::Child, std::string::String> =
                            v1509.map_err(|x| v1510(x));
                        let v1526 = Documents::method170();
                        let v1528: bool = true;
                        let _result_map_ = v1514.map(|x| {
                            //;
                            let v1542: Option<std::process::Child> = v1526(Some(x));
                            let v1544: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v1542);
                            let v1546: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v1544);
                            let v1548: bool = true;
                            v1546
                        });
                        let v1550: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v1551 = Documents::method171();
                        let v1552 = Documents::method172();
                        let v1554: Documents::US33 = match v1550 {
                            Ok(x) => v1551(x),
                            Err(e) => v1552(e),
                        };
                        let patternInput_4: (i32, Documents::US9, Documents::US34) = match &v1554 {
                            Documents::US33::US33_0(v1554_0_0) => {
                                let v1555: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v1554_0_0.clone();
                                let v1557: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v1559: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1555.clone();
                                    let v1561: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1559.lock();
                                    let v1577: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method175(v1561.unwrap());
                                    let v1579: bool = true;
                                    let mut v1577 = v1577;
                                    let v1581: &mut Option<std::process::Child> = &mut v1577;
                                    let v1583: Option<&mut std::process::Child> = v1581.as_mut();
                                    let v1585: &mut std::process::Child = v1583.unwrap();
                                    let v1587: &mut Option<std::process::ChildStdout> =
                                        &mut v1585.stdout;
                                    let v1589: Option<std::process::ChildStdout> =
                                        Option::take(v1587);
                                    let v1591: std::process::ChildStdout = v1589.unwrap();
                                    let v1593: bool = true;
                                    v1591
                                })();
                                let v1595: std::process::ChildStdout = _capture;
                                let v1597: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v1599: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1555.clone();
                                    let v1601: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1599.lock();
                                    let v1617: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method175(v1601.unwrap());
                                    let v1619: bool = true;
                                    let mut v1617 = v1617;
                                    let v1621: &mut Option<std::process::Child> = &mut v1617;
                                    let v1623: Option<&mut std::process::Child> = v1621.as_mut();
                                    let v1625: &mut std::process::Child = v1623.unwrap();
                                    let v1627: &mut Option<std::process::ChildStderr> =
                                        &mut v1625.stderr;
                                    let v1629: Option<std::process::ChildStderr> =
                                        Option::take(v1627);
                                    let v1631: std::process::ChildStderr = v1629.unwrap();
                                    let v1633: bool = true;
                                    v1631
                                })();
                                let v1635: std::process::ChildStderr = _capture;
                                let v1637: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v1639: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1555.clone();
                                    let v1641: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v1639.lock();
                                    let v1657: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method175(v1641.unwrap());
                                    let v1659: bool = true;
                                    let mut v1657 = v1657;
                                    let v1661: &mut Option<std::process::Child> = &mut v1657;
                                    let v1663: Option<&mut std::process::Child> = v1661.as_mut();
                                    let v1665: &mut std::process::Child = v1663.unwrap();
                                    let v1667: &mut Option<std::process::ChildStdin> =
                                        &mut v1665.stdin;
                                    let v1669: Option<std::process::ChildStdin> =
                                        Option::take(v1667);
                                    let v1671: std::process::ChildStdin = v1669.unwrap();
                                    let v1684: Option<std::process::ChildStdin> =
                                        (Documents::method176())(Some(v1671));
                                    let v1686: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(v1684);
                                    let v1688: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v1686);
                                    let v1690: bool = true;
                                    v1688
                                })();
                                let v1692: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v1694: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v1697: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method177())(v1694.clone());
                                let v1699: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1697);
                                let v1701: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1699);
                                let v1703: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method178())(v1694);
                                let v1705: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1703);
                                let v1707: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1705);
                                let v1709: std::sync::Arc<
                                    std::sync::mpsc::Receiver<std::string::String>,
                                > = (Documents::method179())(patternInput_2.1.clone());
                                let v1711: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(v1709);
                                let v1713: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v1711);
                                let v1715: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v1717: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v1595);
                                    let v1719: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v1717);
                                    let v1721: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v1719);
                                    let v1723: bool = true;
                                    let mut v1721 = v1721;
                                    let _iter_try_for_each = v1721.try_for_each(|x| {
                                        //;
                                        let v1725: Result<std::string::String, std::io::Error> = x;
                                        let v1727: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1701.clone();
                                        let v1728 = Documents::method89();
                                        let v1732: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v1725.map_err(|x| v1728(x));
                                        let v1744 = Documents::method180();
                                        let v1745 = Documents::method181();
                                        let v1747: Documents::US35 = match v1732 {
                                            Ok(x) => v1744(x),
                                            Err(e) => v1745(e),
                                        };
                                        let v4288: std::string::String = match &v1747 {
                                            Documents::US35::US35_0(v1747_0_0) => {
                                                let v1750: string =
                                                    fable_library_rust::String_::fromString(
                                                        v1747_0_0.clone(),
                                                    );
                                                let v1752: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v1754: std::borrow::Cow<[u8]> =
                                                    v1752.encode(&*v1750).0;
                                                let v1756: &[u8] = v1754.as_ref();
                                                let v1758: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v1756);
                                                let v1762: &str = v1758.unwrap();
                                                let v1836: std::string::String =
                                                    String::from(v1762);
                                                let v1861: string = concat(new_array(&[
                                                    string("> "),
                                                    fable_library_rust::String_::fromString(
                                                        v1836.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v2416: () = {
                                                        Documents::closure131(v1861.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v2997: () = {
                                                        Documents::closure14(v1861, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v1836
                                            }
                                            Documents::US35::US35_1(v1747_1_0) => {
                                                let v3007: std::string::String = v1747_1_0.clone();
                                                let v3559: () = {
                                                    Documents::closure130(v5, v3007.clone(), ());
                                                    ()
                                                };
                                                let v4116: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v3007);
                                                let v4130: &str = &*v4116;
                                                String::from(v4130)
                                            }
                                        };
                                        let v4290: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1727;
                                        let v4292: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v4290.lock();
                                        let v4296: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v4292.unwrap();
                                        let v4309: &std::sync::mpsc::Sender<std::string::String> =
                                            &v4296;
                                        let v4311: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v4309.send(v4288);
                                        let v4312 = Documents::method188();
                                        let v4316: Result<(), std::string::String> =
                                            v4311.map_err(|x| v4312(x));
                                        let v4329: _ = v4316;
                                        let v4331: bool = true;
                                        v4329
                                    }); //;
                                    let v4334: Result<(), string> = Documents::method189(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v4337: string = string("}");
                                    let v4342: bool = true;
                                    let _fix_closure_v4339 = v4334;
                                    let v4348: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v4339 "),
                                                    (v4337),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v4349: bool = true;
                                    _fix_closure_v4339
                                }); // rust.fix_closure';
                                let v4351: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v4353: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v4355: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v1635);
                                    let v4357: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v4355);
                                    let v4359: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v4357);
                                    let v4361: bool = true;
                                    let mut v4359 = v4359;
                                    let _iter_try_for_each = v4359.try_for_each(|x| {
                                        //;
                                        let v4363: Result<std::string::String, std::io::Error> = x;
                                        let v7139: Result<(), std::string::String> = if (v7)
                                            == false
                                        {
                                            Ok::<(), std::string::String>(())
                                        } else {
                                            let v4377: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v1707.clone();
                                            let v4378 = Documents::method89();
                                            let v4382: Result<
                                                std::string::String,
                                                std::string::String,
                                            > = v4363.map_err(|x| v4378(x));
                                            let v4394 = Documents::method180();
                                            let v4395 = Documents::method181();
                                            let v4397: Documents::US35 = match v4382 {
                                                Ok(x) => v4394(x),
                                                Err(e) => v4395(e),
                                            };
                                            let v7099: std::string::String = match &v4397 {
                                                Documents::US35::US35_0(v4397_0_0) => {
                                                    let v4400: string =
                                                        fable_library_rust::String_::fromString(
                                                            v4397_0_0.clone(),
                                                        );
                                                    let v4402: &encoding_rs::Encoding =
                                                        encoding_rs::UTF_8;
                                                    let v4404: std::borrow::Cow<[u8]> =
                                                        v4402.encode(&*v4400).0;
                                                    let v4406: &[u8] = v4404.as_ref();
                                                    let v4408: Result<&str, std::str::Utf8Error> =
                                                        std::str::from_utf8(v4406);
                                                    let v4412: &str = v4408.unwrap();
                                                    let v4486: std::string::String =
                                                        String::from(v4412);
                                                    let v4511: string = concat(new_array(&[
                                                        string("! "),
                                                        fable_library_rust::String_::fromString(
                                                            v4486.clone(),
                                                        ),
                                                    ]));
                                                    if v5 {
                                                        let v5063: () = {
                                                            Documents::closure131(
                                                                v4511.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        ()
                                                    } else {
                                                        let v5641: () = {
                                                            Documents::closure14(v4511, ());
                                                            ()
                                                        };
                                                        ()
                                                    }
                                                    {
                                                        let v5651: string = sprintf!(
                                                            "\u{001b}[4;7m{}\u{001b}[0m",
                                                            v4486
                                                        );
                                                        let v5665: &str = &*v5651;
                                                        String::from(v5665)
                                                    }
                                                }
                                                Documents::US35::US35_1(v4397_1_0) => {
                                                    let v5822: std::string::String =
                                                        v4397_1_0.clone();
                                                    let v6372: () = {
                                                        Documents::closure130(
                                                            v5,
                                                            v5822.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v6927: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v5822
                                                    );
                                                    let v6941: &str = &*v6927;
                                                    String::from(v6941)
                                                }
                                            };
                                            let v7101: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v4377;
                                            let v7103: Result<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                                std::sync::PoisonError<
                                                    std::sync::MutexGuard<
                                                        std::sync::mpsc::Sender<
                                                            std::string::String,
                                                        >,
                                                    >,
                                                >,
                                            > = v7101.lock();
                                            let v7107: std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = v7103.unwrap();
                                            let v7120: &std::sync::mpsc::Sender<
                                                std::string::String,
                                            > = &v7107;
                                            let v7122: Result<
                                                (),
                                                std::sync::mpsc::SendError<std::string::String>,
                                            > = v7120.send(v7099);
                                            let v7123 = Documents::method188();
                                            v7122.map_err(|x| v7123(x))
                                        };
                                        let v7141: _ = v7139;
                                        let v7143: bool = true;
                                        v7141
                                    }); //;
                                    let v7146: Result<(), string> = Documents::method189(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v7147: string = string("}");
                                    let v7152: bool = true;
                                    let _fix_closure_v7149 = v7146;
                                    let v7158: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v7149 "),
                                                    (v7147),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v7159: bool = true;
                                    _fix_closure_v7149
                                }); // rust.fix_closure';
                                let v7161: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v7223: Documents::US36 = defaultValue(
                                    Documents::US36::US36_1,
                                    map(Documents::method190(), v4.clone()),
                                );
                                match &v7223 {
                                    Documents::US36::US36_0(v7223_0_0) => {
                                        let v7236: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v1692.clone();
                                        let v7238: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v7236.lock();
                                        let v7254: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = Documents::method191(v7238.unwrap());
                                        let v7256: bool = true;
                                        let mut v7254 = v7254;
                                        let v7258: &mut Option<std::process::ChildStdin> =
                                            &mut v7254;
                                        let v7260: Option<std::process::ChildStdin> =
                                            Option::take(v7258);
                                        let v7262: bool = true;
                                        let _optionm_map_ = v7260.map(|x| {
                                            //;
                                            let v7264: std::process::ChildStdin = x;
                                            let v7266: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v7264);
                                            let v7268: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v7266);
                                            let v7270: bool = true;
                                            v7268
                                        });
                                        let v7272: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let v7334: Documents::US37 = defaultValue(
                                            Documents::US37::US37_1,
                                            map(Documents::method192(), v7272),
                                        );
                                        match &v7334 {
                                            Documents::US37::US37_0(v7334_0_0) => {
                                                let v7345: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v7334 {
                                                    Documents::US37::US37_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone();
                                                (match &v7223 {
                                                    Documents::US36::US36_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v7345.clone()
                                                );
                                                {
                                                    let v7347: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v7345;
                                                    let v7349: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v7347.lock();
                                                    let v7365: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method193(v7349.unwrap());
                                                    let v7367: bool = true;
                                                    let mut v7365 = v7365;
                                                    let v7369: bool = true;
                                                    std::io::Write::flush(&mut *v7365).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v7371: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v1555;
                                    let v7373: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v7371.lock();
                                    let v7389: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method175(v7373.unwrap());
                                    let v7391: bool = true;
                                    let mut v7389 = v7389;
                                    let v7393: &mut Option<std::process::Child> = &mut v7389;
                                    let v7395: Option<std::process::Child> = Option::take(v7393);
                                    let v7397: std::process::Child = v7395.unwrap();
                                    let v7399: Result<std::process::Output, std::io::Error> =
                                        v7397.wait_with_output();
                                    let v7400 = Documents::method89();
                                    let v7413: Result<std::process::Output, std::string::String> =
                                        v7399.map_err(|x| v7400(x));
                                    let v7423: string = string("vec![v4351, v7161]");
                                    let v7424: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v4351, v7161];
                                    let v7426: bool = true;
                                    v7424.into_iter().for_each(|x| {
                                        //;
                                        let v7428: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v7430: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v7428);
                                        let v7434: Result<(), string> = v7430.unwrap();
                                        v7434.unwrap();
                                        {
                                            let v7451: bool = true;
                                            let v7453: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v7454 = Documents::method194();
                                        let v7455 = Documents::method195();
                                        let v7457: Documents::US38 = match &v7413 {
                                            Err(v7413_1_0) => v7455(v7413_1_0.clone()),
                                            Ok(v7413_0_0) => v7454(v7413_0_0.clone()),
                                        };
                                        match &v7457 {
                                            Documents::US38::US38_0(v7457_0_0) => {
                                                let v7473: std::process::Output = v7457_0_0.clone();
                                                let v7475: std::process::ExitStatus =
                                                    v7473.clone().status;
                                                let v7477: Option<i32> = v7475.code();
                                                let v7539: Documents::US39 = defaultValue(
                                                    Documents::US39::US39_1,
                                                    map(Documents::method197(), v7477),
                                                );
                                                match &v7539 {
                                                    Documents::US39::US39_0(v7539_0_0) => {
                                                        let v7553: Vec<u8> = Documents::method198(
                                                            v7473.clone().stdout,
                                                        );
                                                        let v7555: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v7553);
                                                        let v7559: std::string::String =
                                                            v7555.unwrap();
                                                        let v7573: Vec<u8> = Documents::method198(
                                                            v7473.clone().stderr,
                                                        );
                                                        let v7575: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v7573);
                                                        let v7579: std::string::String =
                                                            v7575.unwrap();
                                                        let v7592: string =
                                                            fable_library_rust::String_::fromString(
                                                                v7579,
                                                            );
                                                        let v7593: i32 = length(v7592.clone());
                                                        let v8083: string = getSlice(
                                                            v7592.clone(),
                                                            Some(Documents::method23(
                                                                v7592, v7593, 0_i32,
                                                            )),
                                                            Some(v7593),
                                                        );
                                                        let v8583: string = getSlice(
                                                            v8083.clone(),
                                                            Some(0_i32),
                                                            Some(Documents::method199(
                                                                v8083.clone(),
                                                                length(v8083),
                                                            )),
                                                        );
                                                        let v8595: string =
                                                            fable_library_rust::String_::fromString(
                                                                v7559,
                                                            );
                                                        let v8596: i32 = length(v8595.clone());
                                                        let v9086: string = getSlice(
                                                            v8595.clone(),
                                                            Some(Documents::method23(
                                                                v8595, v8596, 0_i32,
                                                            )),
                                                            Some(v8596),
                                                        );
                                                        let v9586: string = getSlice(
                                                            v9086.clone(),
                                                            Some(0_i32),
                                                            Some(Documents::method199(
                                                                v9086.clone(),
                                                                length(v9086),
                                                            )),
                                                        );
                                                        let v9603: LrcPtr<Documents::UH2> =
                                                            if ((length(v8583.clone())) == 0_i32)
                                                                == false
                                                            {
                                                                LrcPtr::new(Documents::UH2::UH2_1(
                                                                    v8583,
                                                                    LrcPtr::new(
                                                                        Documents::UH2::UH2_0,
                                                                    ),
                                                                ))
                                                            } else {
                                                                LrcPtr::new(Documents::UH2::UH2_0)
                                                            };
                                                        let patternInput_3: (string, string) =
                                                            Documents::method200(
                                                                if ((length(v9586.clone()))
                                                                    == 0_i32)
                                                                    == false
                                                                {
                                                                    LrcPtr::new(
                                                                        Documents::UH2::UH2_1(
                                                                            v9586,
                                                                            v9603.clone(),
                                                                        ),
                                                                    )
                                                                } else {
                                                                    v9603
                                                                },
                                                                string(""),
                                                            );
                                                        let v9624: &str =
                                                            &*patternInput_3.0.clone();
                                                        (
                                                            match &v7539 {
                                                                Documents::US39::US39_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                            Documents::US9::US9_0(String::from(
                                                                v9624,
                                                            )),
                                                            Documents::US34::US34_0(v1713.clone()),
                                                        )
                                                    }
                                                    _ => {
                                                        let v9797: &str = &*string(
                                                            "runtime.execute_with_options / exit_code=None",
                                                        );
                                                        (
                                                            -1_i32,
                                                            Documents::US9::US9_0(String::from(
                                                                v9797,
                                                            )),
                                                            Documents::US34::US34_0(v1713.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US38::US38_1(v7457_1_0) => {
                                                let v9962: std::string::String = v7457_1_0.clone();
                                                let v10523: () = {
                                                    Documents::closure137(
                                                        v0_1.clone(),
                                                        v1_1.clone(),
                                                        v2.clone(),
                                                        v3.clone(),
                                                        v4.clone(),
                                                        v5,
                                                        v6.clone(),
                                                        v7,
                                                        v28.clone(),
                                                        v230.clone(),
                                                        v9962.clone(),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US9::US9_0(v9962),
                                                    Documents::US34::US34_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US33::US33_1(v1554_1_0) => {
                                let v11097: std::string::String = v1554_1_0.clone();
                                let v11660: () = {
                                    Documents::closure124(
                                        v0_1.clone(),
                                        v1_1.clone(),
                                        v2.clone(),
                                        v3.clone(),
                                        v4.clone(),
                                        v5,
                                        v6.clone(),
                                        v7,
                                        v28.clone(),
                                        v230.clone(),
                                        v11097.clone(),
                                        (),
                                    );
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US9::US9_0(v11097),
                                    Documents::US34::US34_1,
                                )
                            }
                        };
                        let v12235: Documents::US34 = patternInput_4.2.clone();
                        let v12234: Documents::US9 = patternInput_4.1.clone();
                        let v12233: i32 = patternInput_4.0.clone();
                        let v12260: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v12235 {
                            Documents::US34::US34_0(v12235_0_0) => Some(
                                match &v12235 {
                                    Documents::US34::US34_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                None::<
                                    std::sync::Arc<
                                        std::sync::Mutex<
                                            std::sync::Arc<
                                                std::sync::mpsc::Receiver<std::string::String>,
                                            >,
                                        >,
                                    >,
                                >
                            }
                        };
                        let v12262: bool = true;
                        let _optionm_map_ = v12260.map(|x| {
                            //;
                            let v12264: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v12266: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v12264;
                            let v12268: Result<
                                std::sync::MutexGuard<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                                std::sync::PoisonError<
                                    std::sync::MutexGuard<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                >,
                            > = v12266.lock();
                            let v12272: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v12268.unwrap();
                            let v12285 = v12272.iter();
                            let v12287: Vec<std::string::String> = v12285.collect::<Vec<_>>();
                            let v12289: bool = true;
                            let _vec_map: Vec<_> = v12287
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v12291: std::string::String = x;
                                    let v12293: string =
                                        fable_library_rust::String_::fromString(v12291);
                                    let v12295: bool = true;
                                    v12293
                                })
                                .collect::<Vec<_>>();
                            let v12297: Vec<string> = _vec_map;
                            let v12301: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(
                                fable_library_rust::NativeArray_::array_from(v12297.clone()),
                            );
                            let v12316: string = join(Documents::method201(), toArray(v12301));
                            let v12328: bool = true;
                            v12316
                        });
                        let v12330: Option<string> = _optionm_map_;
                        let v12392: Documents::US5 =
                            defaultValue(Documents::US5::US5_1, map(Documents::method6(), v12330));
                        let v13415: Documents::US40 = match &v12392 {
                            Documents::US5::US5_0(v12392_0_0) => {
                                let v12403: string = match &v12392 {
                                    Documents::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                                let v12404: i32 = length(v12403.clone());
                                let v12895: string = getSlice(
                                    v12403.clone(),
                                    Some(Documents::method23(v12403, v12404, 0_i32)),
                                    Some(v12404),
                                );
                                let v13396: string = getSlice(
                                    v12895.clone(),
                                    Some(0_i32),
                                    Some(Documents::method199(v12895.clone(), length(v12895))),
                                );
                                Documents::US40::US40_0(if (length(v13396.clone())) == 0_i32 {
                                    Documents::US5::US5_1
                                } else {
                                    Documents::US5::US5_0(v13396)
                                })
                            }
                            _ => Documents::US40::US40_1,
                        };
                        let v13422: Documents::US5 =
                            if let Documents::US40::US40_0(v13415_0_0) = &v13415 {
                                let v13416: Documents::US5 = v13415_0_0.clone();
                                if let Documents::US5::US5_0(v13416_0_0) = &v13416 {
                                    Documents::US5::US5_0(v13416_0_0.clone())
                                } else {
                                    Documents::US5::US5_1
                                }
                            } else {
                                Documents::US5::US5_1
                            };
                        let v13429: Documents::US5 = match &v12234 {
                            Documents::US9::US9_0(v12234_0_0) => {
                                Documents::US5::US5_0(fable_library_rust::String_::fromString(
                                    match &v12234 {
                                        Documents::US9::US9_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ))
                            }
                            _ => Documents::US5::US5_1,
                        };
                        let v13433: string = match &v13429 {
                            Documents::US5::US5_0(v13429_0_0) => match &v13429 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => string(""),
                        };
                        let v13436: string = match &v13422 {
                            Documents::US5::US5_0(v13422_0_0) => match &v13422 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v13433.clone(),
                        };
                        let v13989: () = {
                            Documents::closure139(v28.clone(), v12233, v13436.clone(), ());
                            ()
                        };
                        LrcPtr::new((v12233, v13436))
                    }
                }))();
                _capture_v1366.set(Some(x_5))
            }
            {
                let v14558: LrcPtr<(i32, string)> = match &_capture_v1366.get().clone() {
                    None => panic!("{}", string("base.capture / _capture_v1366=None"),),
                    Some(_capture_v1366_0_0) => _capture_v1366_0_0.clone(),
                };
                (v14558.0.clone(), v14558.1.clone())
            }
        }
        pub fn method206(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method39(v2, Documents::method61(v1_1.clone()));
            let v496: string = getSlice(
                v1_1.clone(),
                Some(0_i32),
                Some((lastIndexOf(v1_1.clone(), string("."))) - 1_i32),
            );
            let v997: string = getSlice(
                v4.clone(),
                Some(0_i32),
                Some((lastIndexOf(v4.clone(), string("."))) - 1_i32),
            );
            let v1021: bool = (endsWith3(v0_1.clone(), string(".md"), false)) == false;
            (
                if v1021 {
                    concat(new_array(&[v1_1, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v496, string("."), v0_1.clone()]))
                },
                if v1021 {
                    concat(new_array(&[v4, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v997, string("."), v0_1]))
                },
            )
        }
        pub fn closure140(unitVar: (), unitVar_1: ()) -> usize {
            0_i32 as usize
        }
        pub fn closure141(unitVar: (), v0_1: usize) -> Documents::US42 {
            Documents::US42::US42_0(v0_1)
        }
        pub fn closure142(unitVar: (), v0_1: LrcPtr<Exception>) -> Documents::US42 {
            Documents::US42::US42_1(v0_1)
        }
        pub fn method207() -> Documents::US42 {
            try_catch(
                || Documents::closure141((), Documents::closure140((), ())),
                |ex: LrcPtr<Exception>| {
                    Documents::closure142(
                        (),
                        Documents::closure6(
                            (),
                            Func0::new({
                                let ex = ex.clone();
                                move || ex.clone()
                            }),
                        ),
                    )
                },
            )
        }
        pub fn closure143(v0_1: usize, unitVar: ()) -> usize {
            v0_1
        }
        pub fn method208(v0_1: usize) -> Documents::US42 {
            try_catch(
                || Documents::closure141((), Documents::closure143(v0_1, ())),
                |ex: LrcPtr<Exception>| {
                    Documents::closure142(
                        (),
                        Documents::closure6(
                            (),
                            Func0::new({
                                let ex = ex.clone();
                                move || ex.clone()
                            }),
                        ),
                    )
                },
            )
        }
        pub fn closure145(v0_1: string, v1_1: LrcPtr<Documents::UH2>) -> LrcPtr<Documents::UH2> {
            LrcPtr::new(Documents::UH2::UH2_1(v0_1, v1_1))
        }
        pub fn closure144(
            unitVar: (),
            v0_1: string,
        ) -> Func1<LrcPtr<Documents::UH2>, LrcPtr<Documents::UH2>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH2>| Documents::closure145(v0_1.clone(), v)
            })
        }
        pub fn method209() -> Func1<string, Func1<LrcPtr<Documents::UH2>, LrcPtr<Documents::UH2>>> {
            Func1::new(move |v: string| Documents::closure144((), v))
        }
        pub fn method210() -> string {
            string("")
        }
        pub fn method211(
            v0_1: string,
            v1_1: LrcPtr<Documents::UH2>,
            v2: string,
        ) -> (string, string) {
            let patternInput_2: (string, string) =
                if let Documents::UH2::UH2_1(v1_1_1_0, v1_1_1_1) = v1_1.as_ref() {
                    let patternInput: (string, string) =
                        Documents::method211(v0_1.clone(), v1_1_1_1.clone(), v2.clone());
                    (
                        append(
                            (append((v1_1_1_0.clone()), (patternInput.1.clone()))),
                            (patternInput.0.clone()),
                        ),
                        v0_1,
                    )
                } else {
                    let patternInput_1: (string, string) =
                        if let Documents::UH2::UH2_0 = v1_1.as_ref() {
                            (v2.clone(), v2.clone())
                        } else {
                            (v2.clone(), v2)
                        };
                    (patternInput_1.0.clone(), patternInput_1.1.clone())
                };
            (patternInput_2.0.clone(), patternInput_2.1.clone())
        }
        pub fn closure146(unitVar: (), v0_1: string) -> Documents::US44 {
            Documents::US44::US44_0(v0_1)
        }
        pub fn method212() -> Func1<string, Documents::US44> {
            Func1::new(move |v: string| Documents::closure146((), v))
        }
        pub fn closure147(unitVar: (), v0_1: std::string::String) -> Documents::US44 {
            Documents::US44::US44_1(v0_1)
        }
        pub fn method213() -> Func1<std::string::String, Documents::US44> {
            Func1::new(move |v: std::string::String| Documents::closure147((), v))
        }
        pub fn method216(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("file"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method217(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("real_path"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method218(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("relative_path"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method219(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("origin_hash_exit_code"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method220(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("origin_hash"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method221(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("local_git_hash_exit_code"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method222(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("local_git_hash"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method223(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("hash1"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method224(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("hash2"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method225(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("dist_path"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method226(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("cache_path"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method215(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: i32,
            v4: string,
            v5: i32,
            v6: string,
            v7: string,
            v8: Documents::US5,
            v9: string,
            v10: string,
        ) -> string {
            let v20: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v20.clone());
            Documents::method216(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), v0_1);
            Documents::method50(v20.clone());
            Documents::method217(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), v1_1);
            Documents::method50(v20.clone());
            Documents::method218(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), v2);
            Documents::method50(v20.clone());
            Documents::method219(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), sprintf!("{}", v3));
            Documents::method50(v20.clone());
            Documents::method220(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), v4);
            Documents::method50(v20.clone());
            Documents::method221(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), sprintf!("{}", v5));
            Documents::method50(v20.clone());
            Documents::method222(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), v6);
            Documents::method50(v20.clone());
            Documents::method223(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), v7);
            Documents::method50(v20.clone());
            Documents::method224(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), sprintf!("{:?}", v8));
            Documents::method50(v20.clone());
            Documents::method225(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), v9);
            Documents::method50(v20.clone());
            Documents::method226(v20.clone());
            Documents::method20(v20.clone());
            Documents::method15(v20.clone(), v10);
            Documents::method21(v20.clone());
            v20.l0.get().clone()
        }
        pub fn method214(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: string,
            v11: string,
            v12: i32,
            v13: string,
            v14: i32,
            v15: string,
            v16: string,
            v17: Documents::US5,
            v18: string,
            v19: string,
        ) -> string {
            let v20: string =
                Documents::method215(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        (v8),
                    )),
                    string(" / "),
                )),
                (v20),
            ))
        }
        pub fn closure148(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: i32,
            v5: string,
            v6: string,
            v7: i32,
            v8: string,
            v9: string,
            v10: Documents::US5,
            unitVar: (),
        ) {
            fn v41() {
                Documents::closure10((), ());
            }
            let v42: () = {
                v41();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v120: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v531: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v120,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v158: () = {
                    v41();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v201: Option<i64> = patternInput_1.5.clone();
                let v200: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v199: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v198: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v197: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v196: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v242: string = string(
                    "documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / Some hash2 when hash1 = hash2",
                );
                let v246: string = if (v242.clone()) == string("") {
                    string("")
                } else {
                    Documents::method214(
                        v196.clone(),
                        v197.clone(),
                        v198.clone(),
                        v199.clone(),
                        v200.clone(),
                        v201.clone(),
                        Documents::method8(v196, v197, v198, v199, v200, v201),
                        Documents::method12(),
                        v242,
                        v1_1,
                        v2,
                        v0_1,
                        v4,
                        v3,
                        v7,
                        v6,
                        v9,
                        v10,
                        v5,
                        v8,
                    )
                };
                let v277: () = {
                    v41();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v316: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v315: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v359: () = {
                    Documents::closure12(v315.clone(), ());
                    ()
                };
                println!("{}", v246.clone());
                (v316.l0.get().clone())(v246);
                Documents::US7::US7_0(
                    v315,
                    v316,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure149(unitVar: (), v0_1: u64) -> Documents::US45 {
            Documents::US45::US45_0(v0_1)
        }
        pub fn method228() -> Func1<u64, Documents::US45> {
            Func1::new(move |v: u64| Documents::closure149((), v))
        }
        pub fn closure150(unitVar: (), v0_1: std::string::String) -> Documents::US45 {
            Documents::US45::US45_1(v0_1)
        }
        pub fn method229() -> Func1<std::string::String, Documents::US45> {
            Func1::new(move |v: std::string::String| Documents::closure150((), v))
        }
        pub fn method232(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("old_path"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method233(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("new_path"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method231(v0_1: string, v1_1: string, v2: std::string::String) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method232(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), v0_1);
            Documents::method50(v12.clone());
            Documents::method233(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), v1_1);
            Documents::method50(v12.clone());
            Documents::method51(v12.clone());
            Documents::method20(v12.clone());
            {
                let v508: std::string::String = format!("{:#?}", v2);
                Documents::method15(v12.clone(), fable_library_rust::String_::fromString(v508));
                Documents::method21(v12.clone());
                v12.l0.get().clone()
            }
        }
        pub fn method230(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: std::string::String,
        ) -> string {
            let v11: string = Documents::method231(v8, v9, v10);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("file_system.file_copy"),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure151(v0_1: string, v1_1: string, v2: std::string::String, unitVar: ()) {
            fn v33() {
                Documents::closure10((), ());
            }
            let v34: () = {
                v33();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v112: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v515: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v112,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v150: () = {
                    v33();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v193: Option<i64> = patternInput_1.5.clone();
                let v192: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v191: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v190: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v189: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v188: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v230: string = Documents::method230(
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    Documents::method8(v188, v189, v190, v191, v192, v193),
                    Documents::method46(),
                    v1_1,
                    v0_1,
                    v2,
                );
                let v261: () = {
                    v33();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v300: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v299: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v343: () = {
                    Documents::closure12(v299.clone(), ());
                    ()
                };
                println!("{}", v230.clone());
                (v300.l0.get().clone())(v230);
                Documents::US7::US7_0(
                    v299,
                    v300,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method236(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("result"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method235(v0_1: string, v1_1: string, v2: u64) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method232(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), v0_1);
            Documents::method50(v12.clone());
            Documents::method233(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), v1_1);
            Documents::method50(v12.clone());
            Documents::method236(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), sprintf!("{}", v2));
            Documents::method21(v12.clone());
            v12.l0.get().clone()
        }
        pub fn method234(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
            v10: u64,
        ) -> string {
            let v11: string = Documents::method235(v8, v9, v10);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("file_system.file_copy"),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure152(v0_1: string, v1_1: string, v2: u64, unitVar: ()) {
            fn v33() {
                Documents::closure10((), ());
            }
            let v34: () = {
                v33();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v112: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v515: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v112,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v150: () = {
                    v33();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v193: Option<i64> = patternInput_1.5.clone();
                let v192: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v191: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v190: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v189: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v188: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v230: string = Documents::method234(
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    Documents::method8(v188, v189, v190, v191, v192, v193),
                    Documents::method80(),
                    v1_1,
                    v0_1,
                    v2,
                );
                let v261: () = {
                    v33();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v300: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v299: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v343: () = {
                    Documents::closure12(v299.clone(), ());
                    ()
                };
                println!("{}", v230.clone());
                (v300.l0.get().clone())(v230);
                Documents::US7::US7_0(
                    v299,
                    v300,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method227(v0_1: string, v1_1: string) {
            let v4: Result<u64, std::io::Error> = std::fs::copy(&*v1_1.clone(), &*v0_1.clone());
            let v5 = Documents::method89();
            let v18: Result<u64, std::string::String> = v4.map_err(|x| v5(x));
            let v21 = Documents::method228();
            let v22 = Documents::method229();
            let v24: Documents::US45 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v24 {
                Documents::US45::US45_0(v24_0_0) => {
                    let v592: () = {
                        Documents::closure152(v0_1.clone(), v1_1.clone(), v24_0_0.clone(), ());
                        ()
                    };
                    ()
                }
                Documents::US45::US45_1(v24_1_0) => {
                    let v1701: () = {
                        Documents::closure151(v0_1.clone(), v1_1.clone(), v24_1_0.clone(), ());
                        ()
                    };
                    ()
                }
            }
            ()
        }
        pub fn method238(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method239(v0_1: string) -> string {
            v0_1
        }
        pub fn method240(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure155(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v9: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v21: string = Documents::method239(v0_1);
            let v23: &[u8] = v21.as_bytes();
            let v24: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method240(v9);
            let v26: bool = true;
            let mut v24 = v24;
            let v28: bool = true;
            std::io::Write::write_all(&mut *v24, v23).unwrap();
            ()
        }
        pub fn method241(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method244(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("result_len"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method245(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("output_path"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method243(v0_1: i32, v1_1: i32, v2: string) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method204(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), sprintf!("{}", v0_1));
            Documents::method50(v12.clone());
            Documents::method244(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), sprintf!("{}", v1_1));
            Documents::method50(v12.clone());
            Documents::method245(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), v2);
            Documents::method21(v12.clone());
            v12.l0.get().clone()
        }
        pub fn method242(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: i32,
            v10: string,
        ) -> string {
            let v11: string = Documents::method243(v8, v9, v10);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.hangul"),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure156(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            fn v33() {
                Documents::closure10((), ());
            }
            let v34: () = {
                v33();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v112: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v516: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v112,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v150: () = {
                    v33();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v193: Option<i64> = patternInput_1.5.clone();
                let v192: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v191: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v190: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v189: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v188: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v231: string = Documents::method242(
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    Documents::method8(v188, v189, v190, v191, v192, v193),
                    Documents::method12(),
                    v1_1,
                    length(v2),
                    v0_1,
                );
                let v262: () = {
                    v33();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v301: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v300: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v344: () = {
                    Documents::closure12(v300.clone(), ());
                    ()
                };
                println!("{}", v231.clone());
                (v301.l0.get().clone())(v231);
                Documents::US7::US7_0(
                    v300,
                    v301,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method237(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US46 {
            let v30: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v4);
            let v127: Vec<u8> = Documents::method198(v30.unwrap());
            let v129: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v127);
            let v133: std::string::String = v129.unwrap();
            let v257: Array<string> = split(
                fable_library_rust::String_::fromString(v133),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v267: i32 = get_Count(v257.clone());
            let v268: Array<string> = new_init(&string(""), v267);
            let v269: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method27(v267, v269.clone()) {
                let v271: i32 = v269.l0.get().clone();
                let v272: string = v257[v271].clone();
                let v273: i32 = length(v272.clone());
                let v764: string = getSlice(
                    v272.clone(),
                    Some(Documents::method23(v272, v273, 0_i32)),
                    Some(v273),
                );
                let v1265: string = getSlice(
                    v764.clone(),
                    Some(0_i32),
                    Some(Documents::method199(v764.clone(), length(v764))),
                );
                v268.get_mut()[v271 as usize] = v1265;
                {
                    let v1276: i32 = (v271) + 1_i32;
                    v269.l0.set(v1276);
                    ()
                }
            }
            {
                let v1277: i32 = get_Count(v268.clone());
                let v1278: Array<string> = new_init(&string(""), v1277);
                let v1279: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method238(v1277, v1279.clone()) {
                    let v1281: i32 = v1279.l0.get().clone();
                    let v1282: i32 = v1279.l1.get().clone();
                    let v1283: string = v268[v1281].clone();
                    let v1298: i32 = if (v1283.clone()) != string("") {
                        v1278.get_mut()[v1282 as usize] = v1283;
                        (v1282) + 1_i32
                    } else {
                        v1282
                    };
                    let v1299: i32 = (v1281) + 1_i32;
                    v1279.l0.set(v1299);
                    v1279.l1.set(v1298);
                    ()
                }
                {
                    let v1300: i32 = v1279.l1.get().clone();
                    let v1301: Array<string> = new_init(&string(""), v1300);
                    let v1302: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method27(v1300, v1302.clone()) {
                        let v1304: i32 = v1302.l0.get().clone();
                        let v1305: string = v1278[v1304].clone();
                        v1301.get_mut()[v1304 as usize] = v1305;
                        {
                            let v1306: i32 = (v1304) + 1_i32;
                            v1302.l0.set(v1306);
                            ()
                        }
                    }
                    {
                        let _let__v1311: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v1301 = v1301.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v1301 = v1301.clone();
                                        move |i: i32| v1301[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, (get_Count(v1301.clone())) - 1_i32),
                                )
                            }
                        }));
                        let v1407: string = concat(new_array(&[
                            join(Documents::method201(), toArray(_let__v1311)),
                            string("\n\n"),
                        ]));
                        let v1436: string = if if contains(v1407.clone(), string(" the ")) {
                            contains(v1407.clone(), string(" and "))
                        } else {
                            false
                        } {
                            string("eng")
                        } else {
                            v1_1
                        };
                        let patternInput: (i32, string) = Documents::method104(
                            concat(new_array(&[
                                Documents::method39(
                                    v0_1,
                                    concat(new_array(&[
                                        string(
                                            "../alphabet/deps/hangulize/cmd/hangulize/hangulize",
                                        ),
                                        if cfg!(windows) {
                                            string(".exe")
                                        } else {
                                            string("")
                                        },
                                    ])),
                                ),
                                string(" "),
                                v1436,
                            ])),
                            None::<CancellationToken>,
                            new_empty::<(string, string)>(),
                            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                            Some(Func1::new({
                                let v1407 = v1407.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure155(v1407.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                            true,
                        );
                        let v1544: i32 = patternInput.0.clone();
                        let v1575: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v1585: i32 = get_Count(v1575.clone());
                        let v1587: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method241(v1277, v1587.clone()) {
                            let v1589: i32 = v1587.l0.get().clone();
                            let matchValue: string = v1587.l1.get().clone();
                            let matchValue_1: i32 = v1587.l2.get().clone();
                            let v1592: i32 = v1587.l3.get().clone();
                            let v1591: i32 = matchValue_1;
                            let v1590: string = matchValue;
                            let v1593: string = v268[v1589].clone();
                            let patternInput_2: (string, i32, i32) =
                                if (v1593.clone()) == string("") {
                                    (
                                        append((v1590.clone()), string("\n")),
                                        (v1591) + 1_i32,
                                        (v1592) + 1_i32,
                                    )
                                } else {
                                    let v1608: i32 = (v1591) - (v1592);
                                    (
                                        if (v1608) >= (v1585) {
                                            v1590.clone()
                                        } else {
                                            let v1611: string = v1575[v1608].clone();
                                            let v1636: string = append(
                                                (v1590),
                                                (if contains(v1611.clone(), string("://")) {
                                                    v1593.clone()
                                                } else {
                                                    v1611
                                                }),
                                            );
                                            let v1668: string = if v2 {
                                                v1636.clone()
                                            } else {
                                                append((append((v1636), string("\n"))), (v1593))
                                            };
                                            if (v1608) == ((v1585) - 1_i32) {
                                                v1668.clone()
                                            } else {
                                                append((v1668), string("\n"))
                                            }
                                        },
                                        (v1591) + 1_i32,
                                        v1592,
                                    )
                                };
                            let v1688: i32 = (v1589) + 1_i32;
                            v1587.l0.set(v1688);
                            v1587.l1.set(patternInput_2.0.clone());
                            v1587.l2.set(patternInput_2.1.clone());
                            v1587.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v1587.l1.get().clone();
                            let matchValue_4: i32 = v1587.l2.get().clone();
                            let matchValue_5: i32 = v1587.l3.get().clone();
                            let v1689: string = matchValue_3;
                            std::fs::write(&*v3.clone(), &*v1689.clone()).unwrap();
                            {
                                let v2242: () = {
                                    Documents::closure156(v3, v1544, v1689.clone(), ());
                                    ()
                                };
                                Documents::US46::US46_0(v1544, v1689)
                            }
                        }
                    }
                }
            }
        }
        pub fn method247(v0_1: i32, v1_1: string) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v11.clone());
            Documents::method204(v11.clone());
            Documents::method20(v11.clone());
            Documents::method15(v11.clone(), sprintf!("{}", v0_1));
            Documents::method50(v11.clone());
            Documents::method236(v11.clone());
            Documents::method20(v11.clone());
            Documents::method15(v11.clone(), v1_1);
            Documents::method21(v11.clone());
            v11.l0.get().clone()
        }
        pub fn method246(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
        ) -> string {
            let v10: string = Documents::method247(v8, v9);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.files_fn / error"),
                    )),
                    string(" / "),
                )),
                (v10),
            ))
        }
        pub fn closure157(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v32() {
                Documents::closure10((), ());
            }
            let v33: () = {
                v32();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v111: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v514: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v111,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v149: () = {
                    v32();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v192: Option<i64> = patternInput_1.5.clone();
                let v191: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v190: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v189: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v188: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v187: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v229: string = Documents::method246(
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    Documents::method8(v187, v188, v189, v190, v191, v192),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                );
                let v260: () = {
                    v32();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v299: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v298: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v342: () = {
                    Documents::closure12(v298.clone(), ());
                    ()
                };
                println!("{}", v229.clone());
                (v299.l0.get().clone())(v229);
                Documents::US7::US7_0(
                    v298,
                    v299,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure154(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: bool,
            v5: string,
            v6: string,
        ) -> Documents::US41 {
            let patternInput: (string, string) = Documents::method206(v6, v5.clone(), v0_1);
            let v8: string = patternInput.1.clone();
            let v7: string = patternInput.0.clone();
            if if if (Documents::method41(v7.clone())) == false {
                true
            } else {
                (Documents::method41(v8.clone())) == false
            } {
                false
            } else {
                let v14: string = Documents::method52(v7.clone());
                let v16: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v14);
                let v20: std::fs::File = v16.unwrap();
                let v33: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v20);
                let v35: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v33);
                let v37: bool = true;
                let mut v35 = v35;
                let v39: bool = true;
                let result: sha2::Sha256 = sha2::Digest::new();
                let v41: sha2::Sha256 = result;
                let v43: bool = true;
                let mut v41 = v41;
                let v50: Documents::US42 = Documents::method207();
                let v69: Documents::US43 = match &v50 {
                    Documents::US42::US42_0(v50_0_0) => Documents::US43::US43_0(v50_0_0.clone()),
                    _ => Documents::US43::US43_1,
                };
                let v106: usize = match &v69 {
                    Documents::US43::US43_0(v69_0_0) => match &v69 {
                        Documents::US43::US43_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v108: _ = [0_u8; 1024];
                let v110: bool = true;
                loop {
                    // rust.loop 1;
                    let v112: bool = true;
                    let mut v108 = v108;
                    let v114: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v35, &mut v108);
                    let v127: usize = v114.unwrap();
                    let v143: bool = if (v127) == (v106) {
                        let v142: bool = true;
                        break ();
                        true
                    } else {
                        false
                    };
                    let v150: Documents::US42 = Documents::method208(v127);
                    let v169: Documents::US43 = match &v150 {
                        Documents::US42::US42_0(v150_0_0) => {
                            Documents::US43::US43_0(v150_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v206: usize = match &v169 {
                        Documents::US43::US43_0(v169_0_0) => match &v169 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v233: &_ = if (v206) == (v108.len()) {
                        &v108[v106..]
                    } else {
                        &v108[v106..v206]
                    };
                    let v235: bool = true;
                    sha2::Digest::update(&mut v41, v233);
                    let v237: bool = true;
                } // rust.loop 3;
                let v239: &[u8] = &sha2::Digest::finalize(v41);
                let v241: Vec<u8> = v239.iter().map(|x| *x).collect::<Vec<_>>();
                let v243: bool = true;
                let _vec_map: Vec<_> = v241
                    .into_iter()
                    .map(|x| {
                        //;
                        let v245: u8 = x;
                        let v247: std::string::String = format!("{:02x}", v245);
                        let v249: string = fable_library_rust::String_::fromString(v247);
                        let v251: bool = true;
                        v249
                    })
                    .collect::<Vec<_>>();
                let v253: Vec<string> = _vec_map;
                let v257: List<string> =
                    ofArray(fable_library_rust::NativeArray_::array_from(v253.clone()));
                let v277: LrcPtr<Documents::UH2> = foldBack(
                    Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                        (Documents::method209())(b0)(b1)
                    }),
                    v257,
                    LrcPtr::new(Documents::UH2::UH2_0),
                );
                let patternInput_1: (string, string) =
                    Documents::method211(Documents::method210(), v277, string(""));
                let v349 = Documents::method89();
                let v353: Result<string, std::string::String> =
                    Ok::<string, std::io::Error>(patternInput_1.0.clone()).map_err(|x| v349(x));
                let v365 = Documents::method212();
                let v366 = Documents::method213();
                let v368: Documents::US44 = match v353 {
                    Ok(x) => v365(x),
                    Err(e) => v366(e),
                };
                let v384: string = match &v368 {
                    Documents::US44::US44_0(v368_0_0) => v368_0_0.clone(),
                    Documents::US44::US44_1(v368_1_0) => panic!(
                        "{}",
                        sprintf!("resultm.get / Error x: {}", v368_1_0.clone()),
                    ),
                };
                let v385: string = Documents::method52(v8.clone());
                let v387: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v385);
                let v391: std::fs::File = v387.unwrap();
                let v404: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v391);
                let v406: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v404);
                let v408: bool = true;
                let mut v406 = v406;
                let v410: bool = true;
                let result: sha2::Sha256 = sha2::Digest::new();
                let v412: sha2::Sha256 = result;
                let v414: bool = true;
                let mut v412 = v412;
                let v421: Documents::US42 = Documents::method207();
                let v440: Documents::US43 = match &v421 {
                    Documents::US42::US42_0(v421_0_0) => Documents::US43::US43_0(v421_0_0.clone()),
                    _ => Documents::US43::US43_1,
                };
                let v477: usize = match &v440 {
                    Documents::US43::US43_0(v440_0_0) => match &v440 {
                        Documents::US43::US43_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v479: _ = [0_u8; 1024];
                let v481: bool = true;
                loop {
                    // rust.loop 1;
                    let v483: bool = true;
                    let mut v479 = v479;
                    let v485: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v406, &mut v479);
                    let v498: usize = v485.unwrap();
                    let v514: bool = if (v498) == (v477) {
                        let v513: bool = true;
                        break ();
                        true
                    } else {
                        false
                    };
                    let v521: Documents::US42 = Documents::method208(v498);
                    let v540: Documents::US43 = match &v521 {
                        Documents::US42::US42_0(v521_0_0) => {
                            Documents::US43::US43_0(v521_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v577: usize = match &v540 {
                        Documents::US43::US43_0(v540_0_0) => match &v540 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v604: &_ = if (v577) == (v479.len()) {
                        &v479[v477..]
                    } else {
                        &v479[v477..v577]
                    };
                    let v606: bool = true;
                    sha2::Digest::update(&mut v412, v604);
                    let v608: bool = true;
                } // rust.loop 3;
                let v610: &[u8] = &sha2::Digest::finalize(v412);
                let v612: Vec<u8> = v610.iter().map(|x| *x).collect::<Vec<_>>();
                let v614: bool = true;
                let _vec_map: Vec<_> = v612
                    .into_iter()
                    .map(|x| {
                        //;
                        let v616: u8 = x;
                        let v618: std::string::String = format!("{:02x}", v616);
                        let v620: string = fable_library_rust::String_::fromString(v618);
                        let v622: bool = true;
                        v620
                    })
                    .collect::<Vec<_>>();
                let v624: Vec<string> = _vec_map;
                let v628: List<string> =
                    ofArray(fable_library_rust::NativeArray_::array_from(v624.clone()));
                let v648: LrcPtr<Documents::UH2> = foldBack(
                    Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                        (Documents::method209())(b0)(b1)
                    }),
                    v628,
                    LrcPtr::new(Documents::UH2::UH2_0),
                );
                let patternInput_2: (string, string) =
                    Documents::method211(Documents::method210(), v648, string(""));
                let v719 = Documents::method89();
                let v723: Result<string, std::string::String> =
                    Ok::<string, std::io::Error>(patternInput_2.0.clone()).map_err(|x| v719(x));
                let v735 = Documents::method212();
                let v736 = Documents::method213();
                let v738: Documents::US44 = match v723 {
                    Ok(x) => v735(x),
                    Err(e) => v736(e),
                };
                (v384)
                    == (match &v738 {
                        Documents::US44::US44_0(v738_0_0) => v738_0_0.clone(),
                        Documents::US44::US44_1(v738_1_0) => panic!(
                            "{}",
                            sprintf!("resultm.get / Error x: {}", v738_1_0.clone()),
                        ),
                    })
            } {
                Documents::US41::US41_1
            } else {
                let v758: Documents::US46 = Documents::method237(v2, v3, v4, v7.clone(), v5);
                match &v758 {
                    Documents::US46::US46_0(v758_0_0, v758_0_1) => {
                        let v760: string = v758_0_1.clone();
                        let v759: i32 = v758_0_0.clone();
                        if (v759) != 0_i32 {
                            let v1323: () = {
                                Documents::closure157(v760.clone(), v759, ());
                                ()
                            };
                            Documents::US41::US41_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v7.clone(), v760)),
                            ))
                        } else {
                            if Documents::method41(v7.clone()) {
                                Documents::method227(v8.clone(), v7.clone())
                            } else {
                                panic!(
                                    "{}",
                                    concat(new_array(&[
                                        string("documents.files_fn / "),
                                        v7.clone(),
                                        string(" should exist")
                                    ])),
                                )
                            }
                            Documents::US41::US41_0(Ok::<string, LrcPtr<(string, string)>>(
                                v7.clone(),
                            ))
                        }
                    }
                    Documents::US46::US46_1(v758_1_0, v758_1_1) => {
                        Documents::US41::US41_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v7.clone(), v758_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure153(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: bool,
            v5: string,
        ) -> Func1<string, Documents::US41> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                let v5 = v5.clone();
                move |v: string| {
                    Documents::closure154(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4,
                        v5.clone(),
                        v,
                    )
                }
            })
        }
        pub fn method250(v0_1: i32, v1_1: string, v2: string) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method204(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), sprintf!("{}", v0_1));
            Documents::method50(v12.clone());
            Documents::method245(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), v1_1);
            Documents::method50(v12.clone());
            Documents::method236(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), v2);
            Documents::method21(v12.clone());
            v12.l0.get().clone()
        }
        pub fn method249(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: i32,
            v9: string,
            v10: string,
        ) -> string {
            let v11: string = Documents::method250(v8, v9, v10);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.crowbook / result contains ERROR"),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure160(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            fn v33() {
                Documents::closure10((), ());
            }
            let v34: () = {
                v33();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v112: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v515: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v112,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v150: () = {
                    v33();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v193: Option<i64> = patternInput_1.5.clone();
                let v192: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v191: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v190: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v189: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v188: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v230: string = Documents::method249(
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    v193.clone(),
                    Documents::method8(v188, v189, v190, v191, v192, v193),
                    Documents::method46(),
                    v2,
                    v0_1,
                    v1_1,
                );
                let v261: () = {
                    v33();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v300: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v299: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v343: () = {
                    Documents::closure12(v299.clone(), ());
                    ()
                };
                println!("{}", v230.clone());
                (v300.l0.get().clone())(v230);
                Documents::US7::US7_0(
                    v299,
                    v300,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method248(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US46 {
            let v61: string = if string("html") == (v4.clone()) {
                string(
                    "--set html.css.add \\\"\' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"",
                )
            } else {
                if string("pdf") == (v4.clone()) {
                    append(
                        (append(
                            string(
                                "--set tex.paper.size a4paper tex.template.add \"\\pagenumbering{gobble}\"",
                            ),
                            (if (v0_1) == false {
                                string("")
                            } else {
                                string(
                                    " tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 13",
                                )
                            }),
                        )),
                        string(
                            " rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"",
                        ),
                    )
                } else {
                    if string("epub") == (v4.clone()) {
                        string(
                            "--set epub.version 3 html.css.add \\\"\'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  \'\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\"",
                        )
                    } else {
                        string("")
                    }
                }
            };
            let patternInput: (i32, string) = Documents::method104(
                append(
                    (concat(new_array(&[string("crowbook --verbose --to "), v4]))),
                    sprintf!(" --single \"{}\" --output \"{}\" {}", v2, v1_1.clone(), v61),
                ),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3),
                true,
            );
            let v124: string = patternInput.1.clone();
            let v123: i32 = patternInput.0.clone();
            if (contains(v124.clone(), string("ERROR"))) == false {
                Documents::US46::US46_0(v123, v124.clone())
            } else {
                let v691: () = {
                    Documents::closure160(v1_1, v124.clone(), v123, ());
                    ()
                };
                Documents::US46::US46_1(v123, v124)
            }
        }
        pub fn closure159(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US41 {
            let patternInput: (string, string) = Documents::method206(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if if if (Documents::method41(v5.clone())) == false {
                true
            } else {
                (Documents::method41(v6.clone())) == false
            } {
                false
            } else {
                let v12: string = Documents::method52(v5.clone());
                let v14: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v12);
                let v18: std::fs::File = v14.unwrap();
                let v31: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v18);
                let v33: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v31);
                let v35: bool = true;
                let mut v33 = v33;
                let v37: bool = true;
                let result: sha2::Sha256 = sha2::Digest::new();
                let v39: sha2::Sha256 = result;
                let v41: bool = true;
                let mut v39 = v39;
                let v48: Documents::US42 = Documents::method207();
                let v67: Documents::US43 = match &v48 {
                    Documents::US42::US42_0(v48_0_0) => Documents::US43::US43_0(v48_0_0.clone()),
                    _ => Documents::US43::US43_1,
                };
                let v104: usize = match &v67 {
                    Documents::US43::US43_0(v67_0_0) => match &v67 {
                        Documents::US43::US43_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v106: _ = [0_u8; 1024];
                let v108: bool = true;
                loop {
                    // rust.loop 1;
                    let v110: bool = true;
                    let mut v106 = v106;
                    let v112: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v33, &mut v106);
                    let v125: usize = v112.unwrap();
                    let v141: bool = if (v125) == (v104) {
                        let v140: bool = true;
                        break ();
                        true
                    } else {
                        false
                    };
                    let v148: Documents::US42 = Documents::method208(v125);
                    let v167: Documents::US43 = match &v148 {
                        Documents::US42::US42_0(v148_0_0) => {
                            Documents::US43::US43_0(v148_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v204: usize = match &v167 {
                        Documents::US43::US43_0(v167_0_0) => match &v167 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v231: &_ = if (v204) == (v106.len()) {
                        &v106[v104..]
                    } else {
                        &v106[v104..v204]
                    };
                    let v233: bool = true;
                    sha2::Digest::update(&mut v39, v231);
                    let v235: bool = true;
                } // rust.loop 3;
                let v237: &[u8] = &sha2::Digest::finalize(v39);
                let v239: Vec<u8> = v237.iter().map(|x| *x).collect::<Vec<_>>();
                let v241: bool = true;
                let _vec_map: Vec<_> = v239
                    .into_iter()
                    .map(|x| {
                        //;
                        let v243: u8 = x;
                        let v245: std::string::String = format!("{:02x}", v243);
                        let v247: string = fable_library_rust::String_::fromString(v245);
                        let v249: bool = true;
                        v247
                    })
                    .collect::<Vec<_>>();
                let v251: Vec<string> = _vec_map;
                let v255: List<string> =
                    ofArray(fable_library_rust::NativeArray_::array_from(v251.clone()));
                let v275: LrcPtr<Documents::UH2> = foldBack(
                    Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                        (Documents::method209())(b0)(b1)
                    }),
                    v255,
                    LrcPtr::new(Documents::UH2::UH2_0),
                );
                let patternInput_1: (string, string) =
                    Documents::method211(Documents::method210(), v275, string(""));
                let v347 = Documents::method89();
                let v351: Result<string, std::string::String> =
                    Ok::<string, std::io::Error>(patternInput_1.0.clone()).map_err(|x| v347(x));
                let v363 = Documents::method212();
                let v364 = Documents::method213();
                let v366: Documents::US44 = match v351 {
                    Ok(x) => v363(x),
                    Err(e) => v364(e),
                };
                let v382: string = match &v366 {
                    Documents::US44::US44_0(v366_0_0) => v366_0_0.clone(),
                    Documents::US44::US44_1(v366_1_0) => panic!(
                        "{}",
                        sprintf!("resultm.get / Error x: {}", v366_1_0.clone()),
                    ),
                };
                let v383: string = Documents::method52(v6.clone());
                let v385: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v383);
                let v389: std::fs::File = v385.unwrap();
                let v402: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v389);
                let v404: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v402);
                let v406: bool = true;
                let mut v404 = v404;
                let v408: bool = true;
                let result: sha2::Sha256 = sha2::Digest::new();
                let v410: sha2::Sha256 = result;
                let v412: bool = true;
                let mut v410 = v410;
                let v419: Documents::US42 = Documents::method207();
                let v438: Documents::US43 = match &v419 {
                    Documents::US42::US42_0(v419_0_0) => Documents::US43::US43_0(v419_0_0.clone()),
                    _ => Documents::US43::US43_1,
                };
                let v475: usize = match &v438 {
                    Documents::US43::US43_0(v438_0_0) => match &v438 {
                        Documents::US43::US43_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v477: _ = [0_u8; 1024];
                let v479: bool = true;
                loop {
                    // rust.loop 1;
                    let v481: bool = true;
                    let mut v477 = v477;
                    let v483: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v404, &mut v477);
                    let v496: usize = v483.unwrap();
                    let v512: bool = if (v496) == (v475) {
                        let v511: bool = true;
                        break ();
                        true
                    } else {
                        false
                    };
                    let v519: Documents::US42 = Documents::method208(v496);
                    let v538: Documents::US43 = match &v519 {
                        Documents::US42::US42_0(v519_0_0) => {
                            Documents::US43::US43_0(v519_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v575: usize = match &v538 {
                        Documents::US43::US43_0(v538_0_0) => match &v538 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v602: &_ = if (v575) == (v477.len()) {
                        &v477[v475..]
                    } else {
                        &v477[v475..v575]
                    };
                    let v604: bool = true;
                    sha2::Digest::update(&mut v410, v602);
                    let v606: bool = true;
                } // rust.loop 3;
                let v608: &[u8] = &sha2::Digest::finalize(v410);
                let v610: Vec<u8> = v608.iter().map(|x| *x).collect::<Vec<_>>();
                let v612: bool = true;
                let _vec_map: Vec<_> = v610
                    .into_iter()
                    .map(|x| {
                        //;
                        let v614: u8 = x;
                        let v616: std::string::String = format!("{:02x}", v614);
                        let v618: string = fable_library_rust::String_::fromString(v616);
                        let v620: bool = true;
                        v618
                    })
                    .collect::<Vec<_>>();
                let v622: Vec<string> = _vec_map;
                let v626: List<string> =
                    ofArray(fable_library_rust::NativeArray_::array_from(v622.clone()));
                let v646: LrcPtr<Documents::UH2> = foldBack(
                    Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                        (Documents::method209())(b0)(b1)
                    }),
                    v626,
                    LrcPtr::new(Documents::UH2::UH2_0),
                );
                let patternInput_2: (string, string) =
                    Documents::method211(Documents::method210(), v646, string(""));
                let v717 = Documents::method89();
                let v721: Result<string, std::string::String> =
                    Ok::<string, std::io::Error>(patternInput_2.0.clone()).map_err(|x| v717(x));
                let v733 = Documents::method212();
                let v734 = Documents::method213();
                let v736: Documents::US44 = match v721 {
                    Ok(x) => v733(x),
                    Err(e) => v734(e),
                };
                (v382)
                    == (match &v736 {
                        Documents::US44::US44_0(v736_0_0) => v736_0_0.clone(),
                        Documents::US44::US44_1(v736_1_0) => panic!(
                            "{}",
                            sprintf!("resultm.get / Error x: {}", v736_1_0.clone()),
                        ),
                    })
            } {
                Documents::US41::US41_1
            } else {
                let v756: Documents::US46 = Documents::method248(v2, v5.clone(), v3, v1_1, v4);
                match &v756 {
                    Documents::US46::US46_0(v756_0_0, v756_0_1) => {
                        let v758: string = v756_0_1.clone();
                        let v757: i32 = v756_0_0.clone();
                        if (v757) != 0_i32 {
                            let v1321: () = {
                                Documents::closure157(v758.clone(), v757, ());
                                ()
                            };
                            Documents::US41::US41_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v758)),
                            ))
                        } else {
                            if Documents::method41(v5.clone()) {
                                Documents::method227(v6.clone(), v5.clone())
                            } else {
                                panic!(
                                    "{}",
                                    concat(new_array(&[
                                        string("documents.files_fn / "),
                                        v5.clone(),
                                        string(" should exist")
                                    ])),
                                )
                            }
                            Documents::US41::US41_0(Ok::<string, LrcPtr<(string, string)>>(
                                v5.clone(),
                            ))
                        }
                    }
                    Documents::US46::US46_1(v756_1_0, v756_1_1) => {
                        Documents::US41::US41_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v756_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure158(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US41> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |v: string| {
                    Documents::closure159(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
                }
            })
        }
        pub fn method253(v0_1: LrcPtr<Documents::Mut3>) {
            let v5: string = append((v0_1.l0.get().clone()), string("output_cache_path"));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method252(v0_1: string, v1_1: string) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v11.clone());
            Documents::method245(v11.clone());
            Documents::method20(v11.clone());
            Documents::method15(v11.clone(), v0_1);
            Documents::method50(v11.clone());
            Documents::method253(v11.clone());
            Documents::method20(v11.clone());
            Documents::method15(v11.clone(), v1_1);
            Documents::method21(v11.clone());
            v11.l0.get().clone()
        }
        pub fn method251(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: string,
        ) -> string {
            let v10: string = Documents::method252(v8, v9);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.run / par_map / files\' = [] / listm.iter"),
                    )),
                    string(" / "),
                )),
                (v10),
            ))
        }
        pub fn closure161(v0_1: string, v1_1: string, unitVar: ()) {
            fn v32() {
                Documents::closure10((), ());
            }
            let v33: () = {
                v32();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v111: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v514: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v111,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v149: () = {
                    v32();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v192: Option<i64> = patternInput_1.5.clone();
                let v191: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v190: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v189: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v188: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v187: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v229: string = Documents::method251(
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    v192.clone(),
                    Documents::method8(v187, v188, v189, v190, v191, v192),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                );
                let v260: () = {
                    v32();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v299: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v298: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v342: () = {
                    Documents::closure12(v298.clone(), ());
                    ()
                };
                println!("{}", v229.clone());
                (v299.l0.get().clone())(v229);
                Documents::US7::US7_0(
                    v298,
                    v299,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method254(
            v0_1: LrcPtr<Documents::UH3>,
            v1_1: List<LrcPtr<Documents::UH4>>,
        ) -> List<LrcPtr<Documents::UH4>> {
            match v0_1.as_ref() {
                Documents::UH3::UH3_0 => v1_1.clone(),
                Documents::UH3::UH3_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH3::UH3_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method254(
                        match v0_1.as_ref() {
                            Documents::UH3::UH3_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure163(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: LrcPtr<Documents::UH3>,
        ) -> LrcPtr<Documents::UH3> {
            LrcPtr::new(Documents::UH3::UH3_1(v0_1, v1_1))
        }
        pub fn closure162(
            unitVar: (),
            v0_1: LrcPtr<Documents::UH4>,
        ) -> Func1<LrcPtr<Documents::UH3>, LrcPtr<Documents::UH3>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH3>| Documents::closure163(v0_1.clone(), v)
            })
        }
        pub fn method255()
        -> Func1<LrcPtr<Documents::UH4>, Func1<LrcPtr<Documents::UH3>, LrcPtr<Documents::UH3>>>
        {
            Func1::new(move |v: LrcPtr<Documents::UH4>| Documents::closure162((), v))
        }
        pub fn method257(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US41>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US41>>,
        )> {
            match v0_1.as_ref() {
                Documents::UH4::UH4_0 => v1_1.clone(),
                Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1, v0_1_1_2, v0_1_1_3) => cons(
                    (
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(x, _, _, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x, _, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        Func1::new({
                            let v0_1 = v0_1.clone();
                            move |a0: string| {
                                Func1::new({
                                    let a0 = a0.clone();
                                    let v0_1 = v0_1.clone();
                                    move |a1: string| {
                                        (match v0_1.as_ref() {
                                            Documents::UH4::UH4_1(_, _, x, _) => x.clone(),
                                            _ => unreachable!(),
                                        })(a0.clone(), a1)
                                    }
                                })
                            }
                        }),
                    ),
                    Documents::method257(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure164(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US41>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US41 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US41::US41_0(v4_0_0) => Some(
                    match &v4 {
                        Documents::US41::US41_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method258(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method259(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method256(
            v0_1: LrcPtr<Documents::UH3>,
            v1_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            let v0_1: MutCell<LrcPtr<Documents::UH3>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<Vec<Option<Result<string, LrcPtr<(string, string)>>>>> =
                MutCell::new(v1_1.clone());
            '_method256: loop {
                break '_method256 (match v0_1.get().clone().as_ref() {
                    Documents::UH3::UH3_0 => v1_1.get().clone(),
                    Documents::UH3::UH3_1(v0_1_1_0, v0_1_1_1) => {
                        let v45 = toArray_1(Documents::method257(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH3::UH3_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            empty::<(
                                string,
                                string,
                                Func1<string, Func1<string, Documents::US41>>,
                            )>(),
                        ));
                        let v56 = v45.to_vec();
                        let v58 = rayon::iter::IntoParallelIterator::into_par_iter(v56);
                        let v61 = rayon::iter::ParallelIterator::map(v58, |x| {
                            Func1::new(
                                move |arg10_0040: (
                                    string,
                                    string,
                                    Func1<string, Func1<string, Documents::US41>>,
                                )| {
                                    Documents::closure164((), arg10_0040)
                                },
                            )(x)
                        });
                        let v64: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method258(rayon::iter::ParallelIterator::collect(v61));
                        let v65: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method259(v1_1.get().clone());
                        let v67: bool = true;
                        let mut v65 = v65;
                        let v69: bool = true;
                        v65.extend(v64);
                        {
                            let v0_1_temp: LrcPtr<Documents::UH3> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH3::UH3_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v1_1_temp: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                v65;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method256;
                        }
                    }
                });
            }
        }
        pub fn closure41(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
            v6: string,
        ) -> Result<
            LrcPtr<(
                string,
                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
            )>,
            std::string::String,
        > {
            let v7: string = Documents::method76(v6);
            let v21: &str = &*v7.clone();
            let v106: std::string::String = String::from(v21);
            let v275: std::path::PathBuf = Documents::method37(std::path::PathBuf::from(v106));
            let v277: std::path::Display = v275.display();
            let v364: std::string::String = format!("{}", v277);
            let v465: string = concat(new_array(&[
                string("."),
                replace(
                    replace(
                        fable_library_rust::String_::fromString(v364),
                        v4.clone(),
                        Documents::method102(),
                    ),
                    string("\\"),
                    string("/"),
                ),
            ]));
            let v466: string = Documents::method52(v7);
            let v468: string = Documents::method103(Documents::method39(v3.clone(), v465.clone()));
            let patternInput: (i32, string) = Documents::method104(
                concat(new_array(&[
                    string("git ls-tree --format=\'%(objectname)\' origin/gh-pages \""),
                    v468.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3),
                true,
            );
            let v529: string = patternInput.1.clone();
            let v528: i32 = patternInput.0.clone();
            let v531: string = Documents::method103(Documents::method39(v4.clone(), v465.clone()));
            let patternInput_1: (i32, string) = Documents::method104(
                concat(new_array(&[
                    string("git hash-object \""),
                    v531.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v4.clone()),
                true,
            );
            let v592: string = patternInput_1.1.clone();
            let v591: i32 = patternInput_1.0.clone();
            let v594: string = Documents::method103(Documents::method39(v5.clone(), v465.clone()));
            let v596: string =
                (Documents::method206(string("hangul.md"), v531.clone(), v5.clone()))
                    .0
                    .clone();
            let v3636: LrcPtr<Documents::UH3> = if contains(v529.clone(), v592.clone()) {
                LrcPtr::new(Documents::UH3::UH3_0)
            } else {
                let v616: string = Documents::method52(v531.clone());
                let v618: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v616);
                let v622: std::fs::File = v618.unwrap();
                let v635: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v622);
                let v637: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v635);
                let v639: bool = true;
                let mut v637 = v637;
                let v641: bool = true;
                let result: sha2::Sha256 = sha2::Digest::new();
                let v643: sha2::Sha256 = result;
                let v645: bool = true;
                let mut v643 = v643;
                let v652: Documents::US42 = Documents::method207();
                let v671: Documents::US43 = match &v652 {
                    Documents::US42::US42_0(v652_0_0) => Documents::US43::US43_0(v652_0_0.clone()),
                    _ => Documents::US43::US43_1,
                };
                let v708: usize = match &v671 {
                    Documents::US43::US43_0(v671_0_0) => match &v671 {
                        Documents::US43::US43_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v710: _ = [0_u8; 1024];
                let v712: bool = true;
                loop {
                    // rust.loop 1;
                    let v714: bool = true;
                    let mut v710 = v710;
                    let v716: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v637, &mut v710);
                    let v729: usize = v716.unwrap();
                    let v745: bool = if (v729) == (v708) {
                        let v744: bool = true;
                        break ();
                        true
                    } else {
                        false
                    };
                    let v752: Documents::US42 = Documents::method208(v729);
                    let v771: Documents::US43 = match &v752 {
                        Documents::US42::US42_0(v752_0_0) => {
                            Documents::US43::US43_0(v752_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v808: usize = match &v771 {
                        Documents::US43::US43_0(v771_0_0) => match &v771 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v835: &_ = if (v808) == (v710.len()) {
                        &v710[v708..]
                    } else {
                        &v710[v708..v808]
                    };
                    let v837: bool = true;
                    sha2::Digest::update(&mut v643, v835);
                    let v839: bool = true;
                } // rust.loop 3;
                let v841: &[u8] = &sha2::Digest::finalize(v643);
                let v843: Vec<u8> = v841.iter().map(|x| *x).collect::<Vec<_>>();
                let v845: bool = true;
                let _vec_map: Vec<_> = v843
                    .into_iter()
                    .map(|x| {
                        //;
                        let v847: u8 = x;
                        let v849: std::string::String = format!("{:02x}", v847);
                        let v851: string = fable_library_rust::String_::fromString(v849);
                        let v853: bool = true;
                        v851
                    })
                    .collect::<Vec<_>>();
                let v855: Vec<string> = _vec_map;
                let v859: List<string> =
                    ofArray(fable_library_rust::NativeArray_::array_from(v855.clone()));
                let v879: LrcPtr<Documents::UH2> = foldBack(
                    Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                        (Documents::method209())(b0)(b1)
                    }),
                    v859,
                    LrcPtr::new(Documents::UH2::UH2_0),
                );
                let patternInput_3: (string, string) =
                    Documents::method211(Documents::method210(), v879, string(""));
                let v951 = Documents::method89();
                let v955: Result<string, std::string::String> =
                    Ok::<string, std::io::Error>(patternInput_3.0.clone()).map_err(|x| v951(x));
                let v967 = Documents::method212();
                let v968 = Documents::method213();
                let v970: Documents::US44 = match v955 {
                    Ok(x) => v967(x),
                    Err(e) => v968(e),
                };
                let v986: string = match &v970 {
                    Documents::US44::US44_0(v970_0_0) => v970_0_0.clone(),
                    Documents::US44::US44_1(v970_1_0) => panic!(
                        "{}",
                        sprintf!("resultm.get / Error x: {}", v970_1_0.clone()),
                    ),
                };
                let v1350: Documents::US5 = if (Documents::method41(v594.clone())) == false {
                    Documents::US5::US5_1
                } else {
                    let v990: string = Documents::method52(v594.clone());
                    let v992: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v990);
                    let v996: std::fs::File = v992.unwrap();
                    let v1009: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v996);
                    let v1011: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                        std::io::BufReader::new(v1009);
                    let v1013: bool = true;
                    let mut v1011 = v1011;
                    let v1015: bool = true;
                    let result: sha2::Sha256 = sha2::Digest::new();
                    let v1017: sha2::Sha256 = result;
                    let v1019: bool = true;
                    let mut v1017 = v1017;
                    let v1026: Documents::US42 = Documents::method207();
                    let v1045: Documents::US43 = match &v1026 {
                        Documents::US42::US42_0(v1026_0_0) => {
                            Documents::US43::US43_0(v1026_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v1082: usize = match &v1045 {
                        Documents::US43::US43_0(v1045_0_0) => match &v1045 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v1084: _ = [0_u8; 1024];
                    let v1086: bool = true;
                    loop {
                        // rust.loop 1;
                        let v1088: bool = true;
                        let mut v1084 = v1084;
                        let v1090: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v1011, &mut v1084);
                        let v1103: usize = v1090.unwrap();
                        let v1119: bool = if (v1103) == (v1082) {
                            let v1118: bool = true;
                            break ();
                            true
                        } else {
                            false
                        };
                        let v1126: Documents::US42 = Documents::method208(v1103);
                        let v1145: Documents::US43 = match &v1126 {
                            Documents::US42::US42_0(v1126_0_0) => {
                                Documents::US43::US43_0(v1126_0_0.clone())
                            }
                            _ => Documents::US43::US43_1,
                        };
                        let v1182: usize = match &v1145 {
                            Documents::US43::US43_0(v1145_0_0) => match &v1145 {
                                Documents::US43::US43_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v1209: &_ = if (v1182) == (v1084.len()) {
                            &v1084[v1082..]
                        } else {
                            &v1084[v1082..v1182]
                        };
                        let v1211: bool = true;
                        sha2::Digest::update(&mut v1017, v1209);
                        let v1213: bool = true;
                    } // rust.loop 3;
                    let v1215: &[u8] = &sha2::Digest::finalize(v1017);
                    let v1217: Vec<u8> = v1215.iter().map(|x| *x).collect::<Vec<_>>();
                    let v1219: bool = true;
                    let _vec_map: Vec<_> = v1217
                        .into_iter()
                        .map(|x| {
                            //;
                            let v1221: u8 = x;
                            let v1223: std::string::String = format!("{:02x}", v1221);
                            let v1225: string = fable_library_rust::String_::fromString(v1223);
                            let v1227: bool = true;
                            v1225
                        })
                        .collect::<Vec<_>>();
                    let v1229: Vec<string> = _vec_map;
                    let v1233: List<string> =
                        ofArray(fable_library_rust::NativeArray_::array_from(v1229.clone()));
                    let v1253: LrcPtr<Documents::UH2> = foldBack(
                        Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                            (Documents::method209())(b0)(b1)
                        }),
                        v1233,
                        LrcPtr::new(Documents::UH2::UH2_0),
                    );
                    let patternInput_4: (string, string) =
                        Documents::method211(Documents::method210(), v1253, string(""));
                    let v1324 = Documents::method89();
                    let v1328: Result<string, std::string::String> =
                        Ok::<string, std::io::Error>(patternInput_4.0.clone())
                            .map_err(|x| v1324(x));
                    let v1340 = Documents::method212();
                    let v1341 = Documents::method213();
                    let v1343: Documents::US44 = match v1328 {
                        Ok(x) => v1340(x),
                        Err(e) => v1341(e),
                    };
                    match &v1343 {
                        Documents::US44::US44_0(v1343_0_0) => {
                            Documents::US5::US5_0(v1343_0_0.clone())
                        }
                        _ => Documents::US5::US5_1,
                    }
                };
                if let Documents::US5::US5_0(v1350_0_0) = &v1350 {
                    if (v986.clone()) == (v1350_0_0.clone()) {
                        LrcPtr::new(Documents::UH3::UH3_0)
                    } else {
                        let v1910: () = {
                            Documents::closure148(
                                v465.clone(),
                                v466.clone(),
                                v468.clone(),
                                v529.clone(),
                                v528,
                                v531.clone(),
                                v592.clone(),
                                v591,
                                v594.clone(),
                                v986.clone(),
                                v1350.clone(),
                                (),
                            );
                            ()
                        };
                        Documents::method227(v594.clone(), v531.clone());
                        LrcPtr::new(Documents::UH3::UH3_1(
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("hangul.md"),
                                v531.clone(),
                                Func2::new({
                                    let v0_1 = v0_1.clone();
                                    let v1_1 = v1_1.clone();
                                    let v2 = v2.clone();
                                    let v4 = v4.clone();
                                    let v5 = v5.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v1_1 = v1_1.clone();
                                            let v2 = v2.clone();
                                            let v4 = v4.clone();
                                            let v5 = v5.clone();
                                            move |v: string| {
                                                Documents::closure153(
                                                    v5.clone(),
                                                    v4.clone(),
                                                    v2.clone(),
                                                    v1_1.clone(),
                                                    v0_1,
                                                    v,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                LrcPtr::new(Documents::UH4::UH4_0),
                            )),
                            LrcPtr::new(Documents::UH3::UH3_1(
                                LrcPtr::new(Documents::UH4::UH4_1(
                                    string("html"),
                                    v531.clone(),
                                    Func2::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |b0: string, b1: string| {
                                            (Func1::new({
                                                let v4 = v4.clone();
                                                let v5 = v5.clone();
                                                move |v_1: string| {
                                                    Documents::closure158(
                                                        v5.clone(),
                                                        v4.clone(),
                                                        false,
                                                        v_1,
                                                    )
                                                }
                                            }))(b0)(b1)
                                        }
                                    }),
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        string("pdf"),
                                        v531.clone(),
                                        Func2::new({
                                            let v4 = v4.clone();
                                            let v5 = v5.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v4 = v4.clone();
                                                    let v5 = v5.clone();
                                                    move |v_2: string| {
                                                        Documents::closure158(
                                                            v5.clone(),
                                                            v4.clone(),
                                                            false,
                                                            v_2,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        LrcPtr::new(Documents::UH4::UH4_1(
                                            string("epub"),
                                            v531.clone(),
                                            Func2::new({
                                                let v4 = v4.clone();
                                                let v5 = v5.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v4 = v4.clone();
                                                        let v5 = v5.clone();
                                                        move |v_3: string| {
                                                            Documents::closure158(
                                                                v5.clone(),
                                                                v4.clone(),
                                                                false,
                                                                v_3,
                                                            )
                                                        }
                                                    }))(
                                                        b0
                                                    )(
                                                        b1
                                                    )
                                                }
                                            }),
                                            LrcPtr::new(Documents::UH4::UH4_1(
                                                string("html"),
                                                v596.clone(),
                                                Func2::new({
                                                    let v4 = v4.clone();
                                                    let v5 = v5.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v4 = v4.clone();
                                                            let v5 = v5.clone();
                                                            move |v_4: string| {
                                                                Documents::closure158(
                                                                    v5.clone(),
                                                                    v4.clone(),
                                                                    true,
                                                                    v_4,
                                                                )
                                                            }
                                                        }))(
                                                            b0
                                                        )(
                                                            b1
                                                        )
                                                    }
                                                }),
                                                LrcPtr::new(Documents::UH4::UH4_1(
                                                    string("pdf"),
                                                    v596.clone(),
                                                    Func2::new({
                                                        let v4 = v4.clone();
                                                        let v5 = v5.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v4 = v4.clone();
                                                                let v5 = v5.clone();
                                                                move |v_5: string| {
                                                                    Documents::closure158(
                                                                        v5.clone(),
                                                                        v4.clone(),
                                                                        true,
                                                                        v_5,
                                                                    )
                                                                }
                                                            }))(
                                                                b0
                                                            )(
                                                                b1
                                                            )
                                                        }
                                                    }),
                                                    LrcPtr::new(Documents::UH4::UH4_1(
                                                        string("epub"),
                                                        v596.clone(),
                                                        Func2::new({
                                                            let v4 = v4.clone();
                                                            let v5 = v5.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v4 = v4.clone();
                                                                    let v5 = v5.clone();
                                                                    move |v_6: string| {
                                                                        Documents::closure158(
                                                                            v5.clone(),
                                                                            v4.clone(),
                                                                            true,
                                                                            v_6,
                                                                        )
                                                                    }
                                                                }))(
                                                                    b0
                                                                )(
                                                                    b1
                                                                )
                                                            }
                                                        }),
                                                        LrcPtr::new(Documents::UH4::UH4_0),
                                                    )),
                                                )),
                                            )),
                                        )),
                                    )),
                                )),
                                LrcPtr::new(Documents::UH3::UH3_0),
                            )),
                        ))
                    }
                } else {
                    let v3051: () = {
                        Documents::closure148(
                            v465,
                            v466.clone(),
                            v468,
                            v529,
                            v528,
                            v531.clone(),
                            v592,
                            v591,
                            v594.clone(),
                            v986,
                            v1350.clone(),
                            (),
                        );
                        ()
                    };
                    Documents::method227(v594, v531.clone());
                    LrcPtr::new(Documents::UH3::UH3_1(
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("hangul.md"),
                            v531.clone(),
                            Func2::new({
                                let v0_1 = v0_1.clone();
                                let v1_1 = v1_1.clone();
                                let v2 = v2.clone();
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v1_1 = v1_1.clone();
                                        let v2 = v2.clone();
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_7: string| {
                                            Documents::closure153(
                                                v5.clone(),
                                                v4.clone(),
                                                v2.clone(),
                                                v1_1.clone(),
                                                v0_1,
                                                v_7,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                        LrcPtr::new(Documents::UH3::UH3_1(
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("html"),
                                v531.clone(),
                                Func2::new({
                                    let v4 = v4.clone();
                                    let v5 = v5.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v4 = v4.clone();
                                            let v5 = v5.clone();
                                            move |v_8: string| {
                                                Documents::closure158(
                                                    v5.clone(),
                                                    v4.clone(),
                                                    false,
                                                    v_8,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                LrcPtr::new(Documents::UH4::UH4_1(
                                    string("pdf"),
                                    v531.clone(),
                                    Func2::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |b0: string, b1: string| {
                                            (Func1::new({
                                                let v4 = v4.clone();
                                                let v5 = v5.clone();
                                                move |v_9: string| {
                                                    Documents::closure158(
                                                        v5.clone(),
                                                        v4.clone(),
                                                        false,
                                                        v_9,
                                                    )
                                                }
                                            }))(b0)(b1)
                                        }
                                    }),
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        string("epub"),
                                        v531.clone(),
                                        Func2::new({
                                            let v4 = v4.clone();
                                            let v5 = v5.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v4 = v4.clone();
                                                    let v5 = v5.clone();
                                                    move |v_10: string| {
                                                        Documents::closure158(
                                                            v5.clone(),
                                                            v4.clone(),
                                                            false,
                                                            v_10,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        LrcPtr::new(Documents::UH4::UH4_1(
                                            string("html"),
                                            v596.clone(),
                                            Func2::new({
                                                let v4 = v4.clone();
                                                let v5 = v5.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v4 = v4.clone();
                                                        let v5 = v5.clone();
                                                        move |v_11: string| {
                                                            Documents::closure158(
                                                                v5.clone(),
                                                                v4.clone(),
                                                                true,
                                                                v_11,
                                                            )
                                                        }
                                                    }))(
                                                        b0
                                                    )(
                                                        b1
                                                    )
                                                }
                                            }),
                                            LrcPtr::new(Documents::UH4::UH4_1(
                                                string("pdf"),
                                                v596.clone(),
                                                Func2::new({
                                                    let v4 = v4.clone();
                                                    let v5 = v5.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v4 = v4.clone();
                                                            let v5 = v5.clone();
                                                            move |v_12: string| {
                                                                Documents::closure158(
                                                                    v5.clone(),
                                                                    v4.clone(),
                                                                    true,
                                                                    v_12,
                                                                )
                                                            }
                                                        }))(
                                                            b0
                                                        )(
                                                            b1
                                                        )
                                                    }
                                                }),
                                                LrcPtr::new(Documents::UH4::UH4_1(
                                                    string("epub"),
                                                    v596.clone(),
                                                    Func2::new({
                                                        let v4 = v4.clone();
                                                        let v5 = v5.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v4 = v4.clone();
                                                                let v5 = v5.clone();
                                                                move |v_13: string| {
                                                                    Documents::closure158(
                                                                        v5.clone(),
                                                                        v4.clone(),
                                                                        true,
                                                                        v_13,
                                                                    )
                                                                }
                                                            }))(
                                                                b0
                                                            )(
                                                                b1
                                                            )
                                                        }
                                                    }),
                                                    LrcPtr::new(Documents::UH4::UH4_0),
                                                )),
                                            )),
                                        )),
                                    )),
                                )),
                            )),
                            LrcPtr::new(Documents::UH3::UH3_0),
                        )),
                    ))
                }
            };
            let v11497: Array<LrcPtr<Documents::UH4>> = toArray_1(Documents::method254(
                if (if let Documents::UH3::UH3_0 = v3636.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v3636
                } else {
                    let patternInput_5: (string, string) =
                        Documents::method206(string("epub"), v596.clone(), v5.clone());
                    let v3641: string = patternInput_5.1.clone();
                    let v3640: string = patternInput_5.0.clone();
                    let v4759: LrcPtr<Documents::UH4> = if if Documents::method41(v3640.clone()) {
                        true
                    } else {
                        if (Documents::method41(v3641.clone())) == false {
                            true
                        } else {
                            let v4196: () = {
                                Documents::closure161(v3641.clone(), v3640.clone(), ());
                                ()
                            };
                            Documents::method227(v3640, v3641);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("epub"),
                            v596.clone(),
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_14: string| {
                                            Documents::closure158(
                                                v5.clone(),
                                                v4.clone(),
                                                true,
                                                v_14,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            LrcPtr::new(Documents::UH4::UH4_0),
                        ))
                    } else {
                        LrcPtr::new(Documents::UH4::UH4_0)
                    };
                    let patternInput_6: (string, string) =
                        Documents::method206(string("pdf"), v596.clone(), v5.clone());
                    let v4762: string = patternInput_6.1.clone();
                    let v4761: string = patternInput_6.0.clone();
                    let v5878: LrcPtr<Documents::UH4> = if if Documents::method41(v4761.clone()) {
                        true
                    } else {
                        if (Documents::method41(v4762.clone())) == false {
                            true
                        } else {
                            let v5317: () = {
                                Documents::closure161(v4762.clone(), v4761.clone(), ());
                                ()
                            };
                            Documents::method227(v4761, v4762);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("pdf"),
                            v596.clone(),
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_15: string| {
                                            Documents::closure158(
                                                v5.clone(),
                                                v4.clone(),
                                                true,
                                                v_15,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v4759.clone(),
                        ))
                    } else {
                        v4759
                    };
                    let patternInput_7: (string, string) =
                        Documents::method206(string("html"), v596.clone(), v5.clone());
                    let v5881: string = patternInput_7.1.clone();
                    let v5880: string = patternInput_7.0.clone();
                    let v6997: LrcPtr<Documents::UH4> = if if Documents::method41(v5880.clone()) {
                        true
                    } else {
                        if (Documents::method41(v5881.clone())) == false {
                            true
                        } else {
                            let v6436: () = {
                                Documents::closure161(v5881.clone(), v5880.clone(), ());
                                ()
                            };
                            Documents::method227(v5880, v5881);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("html"),
                            v596,
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_16: string| {
                                            Documents::closure158(
                                                v5.clone(),
                                                v4.clone(),
                                                true,
                                                v_16,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v5878.clone(),
                        ))
                    } else {
                        v5878
                    };
                    let patternInput_8: (string, string) =
                        Documents::method206(string("epub"), v531.clone(), v5.clone());
                    let v6999: string = patternInput_8.1.clone();
                    let v6998: string = patternInput_8.0.clone();
                    let v8115: LrcPtr<Documents::UH4> = if if Documents::method41(v6998.clone()) {
                        true
                    } else {
                        if (Documents::method41(v6999.clone())) == false {
                            true
                        } else {
                            let v7554: () = {
                                Documents::closure161(v6999.clone(), v6998.clone(), ());
                                ()
                            };
                            Documents::method227(v6998, v6999);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("epub"),
                            v531.clone(),
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_17: string| {
                                            Documents::closure158(
                                                v5.clone(),
                                                v4.clone(),
                                                false,
                                                v_17,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v6997.clone(),
                        ))
                    } else {
                        v6997
                    };
                    let patternInput_9: (string, string) =
                        Documents::method206(string("pdf"), v531.clone(), v5.clone());
                    let v8117: string = patternInput_9.1.clone();
                    let v8116: string = patternInput_9.0.clone();
                    let v9233: LrcPtr<Documents::UH4> = if if Documents::method41(v8116.clone()) {
                        true
                    } else {
                        if (Documents::method41(v8117.clone())) == false {
                            true
                        } else {
                            let v8672: () = {
                                Documents::closure161(v8117.clone(), v8116.clone(), ());
                                ()
                            };
                            Documents::method227(v8116, v8117);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("pdf"),
                            v531.clone(),
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_18: string| {
                                            Documents::closure158(
                                                v5.clone(),
                                                v4.clone(),
                                                false,
                                                v_18,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v8115.clone(),
                        ))
                    } else {
                        v8115
                    };
                    let patternInput_10: (string, string) =
                        Documents::method206(string("html"), v531.clone(), v5.clone());
                    let v9235: string = patternInput_10.1.clone();
                    let v9234: string = patternInput_10.0.clone();
                    let v10351: LrcPtr<Documents::UH4> = if if Documents::method41(v9234.clone()) {
                        true
                    } else {
                        if (Documents::method41(v9235.clone())) == false {
                            true
                        } else {
                            let v9790: () = {
                                Documents::closure161(v9235.clone(), v9234.clone(), ());
                                ()
                            };
                            Documents::method227(v9234, v9235);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("html"),
                            v531.clone(),
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_19: string| {
                                            Documents::closure158(
                                                v5.clone(),
                                                v4.clone(),
                                                false,
                                                v_19,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v9233.clone(),
                        ))
                    } else {
                        v9233
                    };
                    let patternInput_11: (string, string) =
                        Documents::method206(string("hangul.md"), v531.clone(), v5.clone());
                    let v10353: string = patternInput_11.1.clone();
                    let v10352: string = patternInput_11.0.clone();
                    LrcPtr::new(Documents::UH3::UH3_1(
                        if if Documents::method41(v10352.clone()) {
                            true
                        } else {
                            if (Documents::method41(v10353.clone())) == false {
                                true
                            } else {
                                let v10908: () = {
                                    Documents::closure161(v10353.clone(), v10352.clone(), ());
                                    ()
                                };
                                Documents::method227(v10352, v10353);
                                false
                            }
                        } {
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("hangul.md"),
                                v531,
                                Func2::new({
                                    let v0_1 = v0_1.clone();
                                    let v1_1 = v1_1.clone();
                                    let v2 = v2.clone();
                                    let v4 = v4.clone();
                                    let v5 = v5.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v1_1 = v1_1.clone();
                                            let v2 = v2.clone();
                                            let v4 = v4.clone();
                                            let v5 = v5.clone();
                                            move |v_20: string| {
                                                Documents::closure153(
                                                    v5.clone(),
                                                    v4.clone(),
                                                    v2.clone(),
                                                    v1_1.clone(),
                                                    v0_1,
                                                    v_20,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                LrcPtr::new(Documents::UH4::UH4_0),
                            ))
                        } else {
                            LrcPtr::new(Documents::UH4::UH4_0)
                        },
                        LrcPtr::new(Documents::UH3::UH3_1(
                            v10351,
                            LrcPtr::new(Documents::UH3::UH3_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH4>>(),
            ));
            let v11508: Vec<LrcPtr<Documents::UH4>> = v11497.to_vec();
            let v11511: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v11515: List<LrcPtr<Documents::UH4>> =
                ofArray(fable_library_rust::NativeArray_::array_from(v11508.clone()));
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((
                v466,
                Documents::method256(
                    foldBack(
                        Func2::new(
                            move |b0: LrcPtr<Documents::UH4>, b1: LrcPtr<Documents::UH3>| {
                                (Documents::method255())(b0)(b1)
                            },
                        ),
                        v11515,
                        LrcPtr::new(Documents::UH3::UH3_0),
                    ),
                    v11511,
                ),
            )))
        }
        pub fn method35(
            v0_1: bool,
            v1_1: Documents::US5,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> std::pin::Pin<
            Box<
                dyn std::future::Future<
                        Output = Result<
                            Vec<
                                Result<
                                    LrcPtr<(
                                        string,
                                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                    )>,
                                    std::string::String,
                                >,
                            >,
                            std::string::String,
                        >,
                    >,
            >,
        > {
            let v7: Documents::US5 = Documents::method38(Documents::method36());
            let v13: Documents::US5 = match &v7 {
                Documents::US5::US5_0(v7_0_0) => Documents::US5::US5_0(
                    match &v7 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => Documents::method38(string(
                    "c:\\home\\git\\polyglot\\target\\Builder\\documents",
                )),
            };
            let v19: Documents::US5 = match &v13 {
                Documents::US5::US5_0(v13_0_0) => Documents::US5::US5_0(
                    match &v13 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => Documents::method38(string("/workspaces")),
            };
            let v23: string = match &v19 {
                Documents::US5::US5_0(v19_0_0) => match &v19 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v54: string = Documents::method39(
                if string("deps") == (Documents::method61(v23.clone())) {
                    let v47: Documents::US5 =
                        Documents::method38(Documents::method44(v23.clone()).clone().unwrap());
                    match &v47 {
                        Documents::US5::US5_0(v47_0_0) => match &v47 {
                            Documents::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => panic!("{}", string("Option does not have a value."),),
                    }
                } else {
                    v23
                },
                string("polyglot"),
            );
            let v55: string = Documents::method76(v5);
            let v56: string = Documents::method76(v4);
            let v57: string = Documents::method76(v3);
            let v609: () = {
                Documents::closure30(
                    v0_1,
                    v1_1.clone(),
                    v2.clone(),
                    v55.clone(),
                    v56.clone(),
                    v57.clone(),
                    (),
                );
                ()
            };
            let v1167: bool = true;
            let __future_init = Box::pin(
                /*;
                let v1169: bool = */
                async move {
                    /*;
                    let v1171: bool = */
                    ();
                    let v1173: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v56.clone());
                    let v1176: async_walkdir::WalkDir =
                        async_walkdir::WalkDir::filter(v1173, move |x| {
                            Func1::new({
                                let v1_1 = v1_1.clone();
                                move |v: async_walkdir::DirEntry| {
                                    Documents::closure31(v1_1.clone(), v)
                                }
                            })(x)
                        });
                    let v1177 = Documents::method92();
                    let v1179 =
                        futures::stream::StreamExt::filter_map(v1176, |x| async { v1177(x) });
                    let v1181: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                        Box::pin(futures::stream::StreamExt::collect(v1179));
                    let v1183: Vec<string> = v1181.await;
                    let v1737: () = {
                        Documents::closure40(v1183.clone(), ());
                        ()
                    };
                    let v2297: rayon::vec::IntoIter<string> =
                        rayon::iter::IntoParallelIterator::into_par_iter(v1183);
                    let v2300: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                        rayon::iter::ParallelIterator::map(v2297, |x| {
                            Func1::new({
                                let v0_1 = v0_1.clone();
                                let v2 = v2.clone();
                                let v54 = v54.clone();
                                let v55 = v55.clone();
                                let v56 = v56.clone();
                                let v57 = v57.clone();
                                move |v_1: string| {
                                    Documents::closure41(
                                        v0_1,
                                        v2.clone(),
                                        v54.clone(),
                                        v55.clone(),
                                        v56.clone(),
                                        v57.clone(),
                                        v_1,
                                    )
                                }
                            })(x)
                        });
                    let v2302: Vec<
                        Result<
                            LrcPtr<(
                                string,
                                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                            )>,
                            std::string::String,
                        >,
                    > = rayon::iter::ParallelIterator::collect(v2300);
                    let v2316: string = string("}");
                    let v2321: bool = true;
                    let _fix_closure_v2318 = Ok::<
                        Vec<
                            Result<
                                LrcPtr<(
                                    string,
                                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                )>,
                                std::string::String,
                            >,
                        >,
                        std::string::String,
                    >(v2302);
                    let v2327: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v2318 "), (v2316))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v2328: bool = true;
                    _fix_closure_v2318
                },
            ); // rust.fix_closure';
            let v2330 = __future_init;
            v2330
        }
        pub fn closure165(
            unitVar: (),
            v0_1: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
        ) -> Documents::US47 {
            Documents::US47::US47_0(v0_1)
        }
        pub fn method260() -> Func1<
            Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            Documents::US47,
        > {
            Func1::new(
                move |v: Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >| Documents::closure165((), v),
            )
        }
        pub fn closure166(unitVar: (), v0_1: std::string::String) -> Documents::US47 {
            Documents::US47::US47_1(v0_1)
        }
        pub fn method261() -> Func1<std::string::String, Documents::US47> {
            Func1::new(move |v: std::string::String| Documents::closure166((), v))
        }
        pub fn method262(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: std::string::String,
        ) -> string {
            let v9: string = Documents::method98(v8);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.main"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure167(v0_1: std::string::String, unitVar: ()) {
            fn v31() {
                Documents::closure10((), ());
            }
            let v32: () = {
                v31();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v110: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v513: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v110,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v148: () = {
                    v31();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v191: Option<i64> = patternInput_1.5.clone();
                let v190: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v189: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v188: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v187: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v186: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v228: string = Documents::method262(
                    v186.clone(),
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    Documents::method8(v186, v187, v188, v189, v190, v191),
                    Documents::method96(),
                    v0_1,
                );
                let v259: () = {
                    v31();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v298: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v297: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v341: () = {
                    Documents::closure12(v297.clone(), ());
                    ()
                };
                println!("{}", v228.clone());
                (v298.l0.get().clone())(v228);
                Documents::US7::US7_0(
                    v297,
                    v298,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method264(v0_1: usize) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v10.clone());
            Documents::method244(v10.clone());
            Documents::method20(v10.clone());
            {
                let v156: std::string::String = format!("{:#?}", v0_1);
                Documents::method15(v10.clone(), fable_library_rust::String_::fromString(v156));
                Documents::method21(v10.clone());
                v10.l0.get().clone()
            }
        }
        pub fn method263(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: usize,
        ) -> string {
            let v9: string = Documents::method264(v8);
            Documents::method22(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("documents.main"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure168(
            v0_1: Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            unitVar: (),
        ) {
            fn v31() {
                Documents::closure10((), ());
            }
            let v32: () = {
                v31();
                ()
            };
            let patternInput: (
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ) = Documents::TraceState::trace_state().get().clone().unwrap();
            let v110: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v515: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v110,
                        ofSeq(ofList(ofArray(new_array(&[
                            LrcPtr::new((Documents::US0::US0_0, 0_i32)),
                            LrcPtr::new((Documents::US0::US0_1, 1_i32)),
                            LrcPtr::new((Documents::US0::US0_2, 2_i32)),
                            LrcPtr::new((Documents::US0::US0_3, 3_i32)),
                            LrcPtr::new((Documents::US0::US0_4, 4_i32)),
                        ])))),
                    ))
            }) == false
            {
                Documents::US7::US7_1
            } else {
                let v148: () = {
                    v31();
                    ()
                };
                let patternInput_1: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v191: Option<i64> = patternInput_1.5.clone();
                let v190: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v189: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v188: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v187: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v186: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v230: string = Documents::method263(
                    v186.clone(),
                    v187.clone(),
                    v188.clone(),
                    v189.clone(),
                    v190.clone(),
                    v191.clone(),
                    Documents::method8(v186, v187, v188, v189, v190, v191),
                    Documents::method12(),
                    v0_1.len(),
                );
                let v261: () = {
                    v31();
                    ()
                };
                let patternInput_2: (
                    LrcPtr<Documents::Mut0>,
                    LrcPtr<Documents::Mut1>,
                    LrcPtr<Documents::Mut2>,
                    LrcPtr<Documents::Mut3>,
                    LrcPtr<Documents::Mut4>,
                    Option<i64>,
                ) = Documents::TraceState::trace_state().get().clone().unwrap();
                let v300: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v299: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v343: () = {
                    Documents::closure12(v299.clone(), ());
                    ()
                };
                println!("{}", v230.clone());
                (v300.l0.get().clone())(v230);
                Documents::US7::US7_0(
                    v299,
                    v300,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v32: () = {
                Documents::closure2((), ());
                ()
            };
            let v613: () = {
                Documents::closure9(v0_1, ());
                ()
            };
            let v1170: clap::Command = Documents::method0();
            let v1172: clap::ArgMatches = clap::Command::get_matches(v1170);
            let v1173: string = Documents::method28();
            let v1187: &str = &*v1173;
            let v1260: Option<std::string::String> =
                clap::ArgMatches::get_one(&v1172.clone(), v1187).cloned();
            let v1322: Documents::US9 =
                defaultValue(Documents::US9::US9_1, map(Documents::method29(), v1260));
            let v1336: std::string::String = match &v1322 {
                Documents::US9::US9_0(v1322_0_0) => match &v1322 {
                    Documents::US9::US9_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v1338: string = fable_library_rust::String_::fromString(v1336);
            let v1339: string = Documents::method30();
            let v1353: &str = &*v1339;
            let v1426: Option<std::string::String> =
                clap::ArgMatches::get_one(&v1172.clone(), v1353).cloned();
            let v1488: Documents::US9 =
                defaultValue(Documents::US9::US9_1, map(Documents::method29(), v1426));
            let v1502: std::string::String = match &v1488 {
                Documents::US9::US9_0(v1488_0_0) => match &v1488 {
                    Documents::US9::US9_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v1504: string = fable_library_rust::String_::fromString(v1502);
            let v1505: string = Documents::method31();
            let v1519: &str = &*v1505;
            let v1592: Option<std::string::String> =
                clap::ArgMatches::get_one(&v1172.clone(), v1519).cloned();
            let v1654: Documents::US9 =
                defaultValue(Documents::US9::US9_1, map(Documents::method29(), v1592));
            let v1668: std::string::String = match &v1654 {
                Documents::US9::US9_0(v1654_0_0) => match &v1654 {
                    Documents::US9::US9_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v1670: string = fable_library_rust::String_::fromString(v1668);
            let v1671: string = Documents::method32();
            let v1685: &str = &*v1671;
            let v1758: Option<std::string::String> =
                clap::ArgMatches::get_one(&v1172.clone(), v1685).cloned();
            let v1820: Documents::US9 =
                defaultValue(Documents::US9::US9_1, map(Documents::method29(), v1758));
            let v1837: Documents::US5 = match &v1820 {
                Documents::US9::US9_0(v1820_0_0) => {
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(
                        match &v1820 {
                            Documents::US9::US9_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ))
                }
                _ => Documents::US5::US5_1,
            };
            let v1841: string = match &v1837 {
                Documents::US5::US5_0(v1837_0_0) => match &v1837 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string("por-br"),
            };
            let v1842: string = Documents::method33();
            let v1856: &str = &*v1842;
            let v1929: Option<std::string::String> =
                clap::ArgMatches::get_one(&v1172.clone(), v1856).cloned();
            let v1991: Documents::US9 =
                defaultValue(Documents::US9::US9_1, map(Documents::method29(), v1929));
            let v2008: Documents::US5 = match &v1991 {
                Documents::US9::US9_0(v1991_0_0) => {
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(
                        match &v1991 {
                            Documents::US9::US9_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ))
                }
                _ => Documents::US5::US5_1,
            };
            let v2009: string = Documents::method34();
            let v2023: &str = &*v2009;
            let v2097: std::pin::Pin<
                Box<
                    dyn std::future::Future<
                            Output = Result<
                                Vec<
                                    Result<
                                        LrcPtr<(
                                            string,
                                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                                        )>,
                                        std::string::String,
                                    >,
                                >,
                                std::string::String,
                            >,
                        >,
                >,
            > = Documents::method35(
                clap::ArgMatches::get_flag(&v1172, v2023),
                v2008,
                v1841,
                v1670,
                v1504,
                v1338,
            );
            let v2099: Result<
                Vec<
                    Result<
                        LrcPtr<(
                            string,
                            Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                        )>,
                        std::string::String,
                    >,
                >,
                std::string::String,
            > = futures::executor::block_on(v2097);
            let v2100 = Documents::method260();
            let v2101 = Documents::method261();
            let v2103: Documents::US47 = match &v2099 {
                Err(v2099_1_0) => v2101(v2099_1_0.clone()),
                Ok(v2099_0_0) => v2100(v2099_0_0.clone()),
            };
            match &v2103 {
                Documents::US47::US47_0(v2103_0_0) => {
                    let v2673: () = {
                        Documents::closure168(v2103_0_0.clone(), ());
                        ()
                    };
                    0_i32
                }
                Documents::US47::US47_1(v2103_1_0) => {
                    let v3784: () = {
                        Documents::closure167(v2103_1_0.clone(), ());
                        ()
                    };
                    1_i32
                }
            }
        }
        pub fn v0() -> Func0<()> {
            static v0: OnceInit<Func0<()>> = OnceInit::new();
            v0.get_or_init(|| Func0::new(move || Documents::closure0((), ())))
                .clone()
        }
        pub fn tests() {
            (Documents::v0())();
        }
        pub fn v1() -> Func1<Array<string>, i32> {
            static v1: OnceInit<Func1<Array<string>, i32>> = OnceInit::new();
            v1.get_or_init(|| Func1::new(move |v: Array<string>| Documents::closure1((), v)))
                .clone()
        }
        pub fn main(args: Array<string>) -> i32 {
            (Documents::v1())(args)
        }
    }
}
pub use module_b8cdef03::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/async_.rs"]
mod module_763b9e6c;
pub use module_763b9e6c::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/common.rs"]
mod module_18f1c018;
pub use module_18f1c018::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/crypto.rs"]
mod module_c0301e36;
pub use module_c0301e36::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/date_time.rs"]
mod module_e5abed0b;
pub use module_e5abed0b::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/file_system.rs"]
mod module_336d1dc9;
pub use module_336d1dc9::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/lib.rs"]
mod module_12dde172;
pub use module_12dde172::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/networking.rs"]
mod module_7e35832b;
pub use module_7e35832b::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/platform.rs"]
mod module_afd02cca;
pub use module_afd02cca::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/runtime.rs"]
mod module_a3c64389;
pub use module_a3c64389::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/sm.rs"]
mod module_8f227ecb;
pub use module_8f227ecb::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/threading.rs"]
mod module_e08c16fb;
pub use module_e08c16fb::*;
#[path = "../../deps/polyglot/deps/spiral/lib/spiral/trace.rs"]
mod module_702ddcb4;
pub use module_702ddcb4::*;
#[path = "../../deps/polyglot/lib/fsharp/Common.rs"]
mod module_eb7e4788;
pub use module_eb7e4788::*;
pub mod Polyglot {
    pub use crate::module_eb7e4788::Polyglot::*;
}
pub fn main() {
    let args = std::env::args().skip(1).map(fromString).collect();
    Documents::main(array_from(args));
}
