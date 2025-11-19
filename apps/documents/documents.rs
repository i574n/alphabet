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
            US4_7(Documents::US3),
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
            let v35: string = Documents::method4(v0_1);
            let v37: Result<std::string::String, std::env::VarError> = std::env::var(&*v35);
            let v39: bool = true;
            let _result_map_ = v37.map(|x| {
                //;
                let v41: std::string::String = x;
                let v43: string = fable_library_rust::String_::fromString(v41);
                let v45: bool = true;
                v43
            });
            let v47: Result<string, std::env::VarError> = _result_map_;
            let v48: string = Documents::method5();
            v47.unwrap_or(v48)
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
            let v13: string = toLower(string("Critical"));
            let v36: string = toLower(string("Warning"));
            let v59: string = toLower(string("Info"));
            let v82: string = toLower(string("Debug"));
            let v105: string = toLower(string("Verbose"));
            let v121: Documents::US1 = if string("Verbose") == (v1_1.clone()) {
                Documents::US1::US1_0(Documents::US0::US0_0)
            } else {
                Documents::US1::US1_1
            };
            (
                match &v121 {
                    Documents::US1::US1_0(v121_0_0) => Documents::US1::US1_0(
                        match &v121 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v128: Documents::US1 = if string("Debug") == (v1_1.clone()) {
                            Documents::US1::US1_0(Documents::US0::US0_1)
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v128 {
                            Documents::US1::US1_0(v128_0_0) => Documents::US1::US1_0(
                                match &v128 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v135: Documents::US1 = if string("Info") == (v1_1.clone()) {
                                    Documents::US1::US1_0(Documents::US0::US0_2)
                                } else {
                                    Documents::US1::US1_1
                                };
                                match &v135 {
                                    Documents::US1::US1_0(v135_0_0) => Documents::US1::US1_0(
                                        match &v135 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v142: Documents::US1 =
                                            if string("Warning") == (v1_1.clone()) {
                                                Documents::US1::US1_0(Documents::US0::US0_3)
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v142 {
                                            Documents::US1::US1_0(v142_0_0) => {
                                                Documents::US1::US1_0(
                                                    match &v142 {
                                                        Documents::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v149: Documents::US1 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Documents::US1::US1_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US1::US1_1
                                                    };
                                                match &v149 {
                                                    Documents::US1::US1_0(v149_0_0) => {
                                                        Documents::US1::US1_0(
                                                            match &v149 {
                                                                Documents::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => {
                                                        let v156: Documents::US1 =
                                                            if (v105.clone()) == (v1_1.clone()) {
                                                                Documents::US1::US1_0(
                                                                    Documents::US0::US0_0,
                                                                )
                                                            } else {
                                                                Documents::US1::US1_1
                                                            };
                                                        match &v156 {
                                                            Documents::US1::US1_0(v156_0_0) => {
                                                                Documents::US1::US1_0(
                                                                    match &v156 {
                                                                        Documents::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    }
                                                                    .clone(),
                                                                )
                                                            }
                                                            _ => {
                                                                let v163: Documents::US1 = if (v82
                                                                    .clone())
                                                                    == (v1_1.clone())
                                                                {
                                                                    Documents::US1::US1_0(
                                                                        Documents::US0::US0_1,
                                                                    )
                                                                } else {
                                                                    Documents::US1::US1_1
                                                                };
                                                                match &v163 {
                                                                 Documents::US1::US1_0(v163_0_0)
                                                                 =>
                                                                 Documents::US1::US1_0(match &v163
                                                                                           {
                                                                                           Documents::US1::US1_0(x)
                                                                                           =>
                                                                                           x.clone(),
                                                                                           _
                                                                                           =>
                                                                                           unreachable!(),
                                                                                       }.clone()),
                                                                 _ => {
                                                                     let v170:
                                                                             Documents::US1 =
                                                                         if (v59.clone())
                                                                                ==
                                                                                (v1_1.clone())
                                                                            {
                                                                             Documents::US1::US1_0(Documents::US0::US0_2)
                                                                         } else {
                                                                             Documents::US1::US1_1
                                                                         };
                                                                     match &v170
                                                                         {
                                                                         Documents::US1::US1_0(v170_0_0)
                                                                         =>
                                                                         Documents::US1::US1_0(match &v170
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
                                                                             let v177:
                                                                                     Documents::US1 =
                                                                                 if (v36.clone())
                                                                                        ==
                                                                                        (v1_1.clone())
                                                                                    {
                                                                                     Documents::US1::US1_0(Documents::US0::US0_3)
                                                                                 } else {
                                                                                     Documents::US1::US1_1
                                                                                 };
                                                                             match &v177
                                                                                 {
                                                                                 Documents::US1::US1_0(v177_0_0)
                                                                                 =>
                                                                                 Documents::US1::US1_0(match &v177
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
                                                                                     let v184:
                                                                                             Documents::US1 =
                                                                                         if (v13.clone())
                                                                                                ==
                                                                                                (v1_1.clone())
                                                                                            {
                                                                                             Documents::US1::US1_0(Documents::US0::US0_4)
                                                                                         } else {
                                                                                             Documents::US1::US1_1
                                                                                         };
                                                                                     match &v184
                                                                                         {
                                                                                         Documents::US1::US1_0(v184_0_0)
                                                                                         =>
                                                                                         Documents::US1::US1_0(match &v184
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
                    let v526: Documents::US6 = Documents::method7({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    });
                    let v547: Documents::US2 = match &v526 {
                        Documents::US6::US6_0(v526_0_0) => Documents::US2::US2_0(v526_0_0.clone()),
                        _ => Documents::US2::US2_1,
                    };
                    Documents::US2::US2_0(match &v547 {
                        Documents::US2::US2_0(v547_0_0) => match &v547 {
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
            let _run_target_args__v5: (Documents::US1, Documents::US2) =
                (patternInput.0.clone(), patternInput.1.clone());
            let v747: Documents::US2 = _run_target_args__v5.1.clone();
            let v746: Documents::US1 = _run_target_args__v5.0.clone();
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
                    l0: MutCell::new(match &v746 {
                        Documents::US1::US1_0(v746_0_0) => match &v746 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v747 {
                    Documents::US2::US2_0(v747_0_0) => Some(match &v747 {
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
            let v1863: Documents::US2 =
                defaultValue(Documents::US2::US2_1, map(Documents::method9(), v5));
            let v2600: DateTime = match &v1863 {
                Documents::US2::US2_0(v1863_0_0) => {
                    let v2170: Documents::US6 = Documents::method7({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    });
                    let v2191: Documents::US2 = match &v2170 {
                        Documents::US6::US6_0(v2170_0_0) => {
                            Documents::US2::US2_0(v2170_0_0.clone())
                        }
                        _ => Documents::US2::US2_1,
                    };
                    let v2355: TimeSpan = TimeSpan::new_ticks(
                        (match &v2191 {
                            Documents::US2::US2_0(v2191_0_0) => match &v2191 {
                                Documents::US2::US2_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        }) - (match &v1863 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v2355.hours(),
                        v2355.minutes(),
                        v2355.seconds(),
                        v2355.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v2608: string = Documents::method10();
            let provider: string = if (v2608.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v2608
            };
            v2600.toString(provider)
        }
        pub fn method14() -> string {
            string("")
        }
        pub fn method15(v0_1: LrcPtr<Documents::Mut3>, v1_1: string) {
            let v5: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v5);
            ()
        }
        pub fn method13(v0_1: char) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method15(v12.clone(), sprintf!("{}", v0_1));
            v12.l0.get().clone()
        }
        pub fn method12() -> string {
            let v4: &str = inline_colorization::color_bright_green;
            let v47: std::string::String = String::from(v4);
            let v553: string = append(
                (fable_library_rust::String_::fromString(v47)),
                (Documents::method13(getCharAt(toLower(string("Info")), 0_i32))),
            );
            let v569: &str = inline_colorization::color_reset;
            let v612: std::string::String = String::from(v569);
            append((v553), (fable_library_rust::String_::fromString(v612)))
        }
        pub fn method18(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("{ "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method19(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("args"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method20(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string(" = "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method21(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string(" }"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method17(v0_1: Array<string>) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method19(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), sprintf!("{:?}", v0_1));
            Documents::method21(v12.clone());
            v12.l0.get().clone()
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
            let v716: string = getSlice(
                v0_1.clone(),
                Some(Documents::method23(v0_1, v1_1, 0_i32)),
                Some(v1_1),
            );
            getSlice(
                v716.clone(),
                Some(0_i32),
                Some(Documents::method25(v716.clone(), length(v716))),
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
            let v33: () = {
                Documents::closure14(v0_1, ());
                ()
            };
            ()
        }
        pub fn method27(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn closure9(v0_1: Array<string>, unitVar: ()) {
            fn v74() {
                Documents::closure10((), ());
            }
            let v75: () = {
                v74();
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
            let v203: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v894: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v203,
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
                let v284: () = {
                    v74();
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
                let v370: Option<i64> = patternInput_1.5.clone();
                let v369: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v368: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v367: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v366: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v365: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v414: string = Documents::method16(
                    v365.clone(),
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    Documents::method8(v365, v366, v367, v368, v369, v370),
                    Documents::method12(),
                    v0_1,
                );
                let v488: () = {
                    v74();
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
                let v570: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v569: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v622: () = {
                    Documents::closure12(v569.clone(), ());
                    ()
                };
                println!("{}", v414.clone());
                (v570.l0.get().clone())(v414);
                Documents::US7::US7_0(
                    v569,
                    v570,
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
            let v42: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v100: std::path::PathBuf = Documents::method37(v42.unwrap());
            let v102: std::path::Display = v100.display();
            let v272: std::string::String = format!("{}", v102);
            fable_library_rust::String_::fromString(v272)
        }
        pub fn method39(v0_1: string, v1_1: string) -> string {
            let v53: &str = &*v0_1;
            let v221: std::string::String = String::from(v53);
            let v389: std::path::PathBuf = std::path::PathBuf::from(v221);
            let v557: &str = &*v1_1;
            let v725: std::string::String = String::from(v557);
            let v894: std::path::PathBuf = Documents::method37(v389.join(v725));
            let v896: std::path::Display = v894.display();
            let v1066: std::string::String = format!("{}", v896);
            fable_library_rust::String_::fromString(v1066)
        }
        pub fn method41(v0_1: string) -> bool {
            let v84: &str = &*v0_1;
            let v252: std::string::String = String::from(v84);
            let v505: std::path::PathBuf = std::path::PathBuf::from(v252);
            if v505.clone().exists() {
                v505.is_file()
            } else {
                false
            }
        }
        pub fn closure16(unitVar: (), v0_1: string) -> bool {
            Documents::method41(v0_1)
        }
        pub fn method42(v0_1: string) -> bool {
            let v84: &str = &*v0_1;
            let v252: std::string::String = String::from(v84);
            let v505: std::path::PathBuf = std::path::PathBuf::from(v252);
            if v505.clone().exists() {
                v505.is_dir()
            } else {
                false
            }
        }
        pub fn closure17(unitVar: (), v0_1: string) -> bool {
            Documents::method42(v0_1)
        }
        pub fn method44(v0_1: string) -> Option<string> {
            let v84: &str = &*v0_1;
            let v252: std::string::String = String::from(v84);
            let v420: std::path::PathBuf = std::path::PathBuf::from(v252);
            let v547: Option<std::path::PathBuf> = v420.parent().map(std::path::PathBuf::from);
            let v549: bool = true;
            let _optionm_map_ = v547.map(|x| {
                //;
                let v593: std::path::PathBuf = Documents::method37(x);
                let v595: std::path::Display = v593.display();
                let v765: std::string::String = format!("{}", v595);
                let v892: string = fable_library_rust::String_::fromString(v765);
                let v894: bool = true;
                v892
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
                    let v118: Documents::US5 =
                        defaultValue(Documents::US5::US5_1, map(Documents::method6(), v8));
                    match &v118 {
                        Documents::US5::US5_0(v118_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: bool = v2.get().clone();
                            let v3_temp = v3.get().clone();
                            let v4_temp: string = match &v118 {
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
                let v117: Documents::US5 =
                    defaultValue(Documents::US5::US5_1, map(Documents::method6(), v7));
                match &v117 {
                    Documents::US5::US5_0(v117_0_0) => Documents::method45(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2,
                        v3.clone(),
                        match &v117 {
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
            let v4: &str = inline_colorization::color_yellow;
            let v47: std::string::String = String::from(v4);
            let v553: string = append(
                (fable_library_rust::String_::fromString(v47)),
                (Documents::method13(getCharAt(toLower(string("Warning")), 0_i32))),
            );
            let v569: &str = inline_colorization::color_reset;
            let v612: std::string::String = String::from(v569);
            append((v553), (fable_library_rust::String_::fromString(v612)))
        }
        pub fn method49(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("dir"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method50(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("; "));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method51(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("error"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method48(v0_1: string, v1_1: string) -> string {
            let v13: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v13.clone());
            Documents::method49(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(v13.clone(), v0_1);
            Documents::method50(v13.clone());
            Documents::method51(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(v13.clone(), v1_1);
            Documents::method21(v13.clone());
            v13.l0.get().clone()
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
            fn v75() {
                Documents::closure10((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v895: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v204,
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
                let v285: () = {
                    v75();
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
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v369: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v368: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v367: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v366: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v415: string = Documents::method47(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Documents::method8(v366, v367, v368, v369, v370, v371),
                    Documents::method46(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
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
                let v571: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v570: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v623: () = {
                    Documents::closure12(v570.clone(), ());
                    ()
                };
                println!("{}", v415.clone());
                (v571.l0.get().clone())(v415);
                Documents::US7::US7_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method56(v0_1: std::io::Error) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            let v43: std::string::String = format!("{:#?}", v0_1);
            Documents::method15(v12.clone(), fable_library_rust::String_::fromString(v43));
            v12.l0.get().clone()
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
            let v52: &str = &*v0_1;
            let v220: std::string::String = String::from(v52);
            let v388: std::path::PathBuf = std::path::PathBuf::from(v220);
            let v515: Option<&std::ffi::OsStr> = v388.file_name();
            let v517: bool = true;
            let _optionm_map_ = v515.map(|x| {
                //;
                let v519: &std::ffi::OsStr = x;
                let v521: std::ffi::OsString = v519.to_os_string();
                let v523: Option<&str> = v521.to_str();
                let v525: &str = v523.unwrap();
                let v568: std::string::String = String::from(v525);
                let v695: string = fable_library_rust::String_::fromString(v568);
                let v697: bool = true;
                v695
            });
            let v699: Option<string> = _optionm_map_;
            let v809: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v699));
            match &v809 {
                Documents::US5::US5_0(v809_0_0) => match &v809 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            }
        }
        pub fn method62(v0_1: string) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method15(v12.clone(), v0_1);
            v12.l0.get().clone()
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
            let v116: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v129: string = Documents::method62(v3);
            if (v2) >= 11_u8 {
                let v133: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v176: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v133);
                Err(v176)
            } else {
                if let Documents::US5::US5_0(v116_0_0) = &v116 {
                    if (v4.clone()) != string("") {
                        let v343: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v116_0_0.clone());
                        let v344 = Documents::method55();
                        let v358: Result<std::path::PathBuf, string> = v343.map_err(|x| v344(x));
                        let v361 = Documents::method57();
                        let v362 = Documents::method58();
                        let v371: Documents::US12 = match &v358 {
                            Err(v358_1_0) => v362(v358_1_0.clone()),
                            Ok(v358_0_0) => v361(v358_0_0.clone()),
                        };
                        match &v371 {
                            Documents::US12::US12_0(v371_0_0) => {
                                let v433: std::path::PathBuf =
                                    Documents::method37(v371_0_0.clone());
                                let v584: Documents::US13 = Documents::method63(v433.display());
                                let v605: Documents::US5 = match &v584 {
                                    Documents::US13::US13_0(v584_0_0) => {
                                        Documents::US5::US5_0(v584_0_0.clone())
                                    }
                                    _ => Documents::US5::US5_1,
                                };
                                let v655: string = Documents::method39(
                                    match &v605 {
                                        Documents::US5::US5_0(v605_0_0) => match &v605 {
                                            Documents::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    },
                                    v5.clone(),
                                );
                                let v698: &str = &*v655;
                                let v866: std::string::String = String::from(v698);
                                let v1034: std::path::PathBuf = std::path::PathBuf::from(v866);
                                Ok(v1034)
                            }
                            Documents::US12::US12_1(v371_1_0) => {
                                let v1179: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v371_1_0.clone(),
                                        v129.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v1222: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1179);
                                Err(v1222)
                            }
                        }
                    } else {
                        let v1368: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v129.clone(),
                                v4.clone(),
                                v5.clone()
                            ),
                        );
                        let v1411: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v1368);
                        Err(v1411)
                    }
                } else {
                    let v1556: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1,
                            v129.clone(),
                            v4,
                            v5.clone()
                        ),
                    );
                    let v1599: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v1556);
                    Err(v1599)
                }
            }
        }
        pub fn method59(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v45: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v46 = Documents::method55();
            let v60: Result<std::path::PathBuf, string> = v45.map_err(|x| v46(x));
            let v63 = Documents::method57();
            let v64 = Documents::method58();
            let v73: Documents::US12 = match &v60 {
                Err(v60_1_0) => v64(v60_1_0.clone()),
                Ok(v60_0_0) => v63(v60_0_0.clone()),
            };
            match &v73 {
                Documents::US12::US12_0(v73_0_0) => Ok(v73_0_0.clone()),
                Documents::US12::US12_1(v73_1_0) => Documents::method60(
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
                    v73_1_0.clone(),
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
            let v115: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v128: string = Documents::method62(v3);
            if (v2) >= 11_u8 {
                let v132: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v175: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v132);
                Err(v175)
            } else {
                if let Documents::US5::US5_0(v115_0_0) = &v115 {
                    if (v0_1.clone()) != string("") {
                        let v342: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v115_0_0.clone());
                        let v343 = Documents::method55();
                        let v357: Result<std::path::PathBuf, string> = v342.map_err(|x| v343(x));
                        let v360 = Documents::method57();
                        let v361 = Documents::method58();
                        let v370: Documents::US12 = match &v357 {
                            Err(v357_1_0) => v361(v357_1_0.clone()),
                            Ok(v357_0_0) => v360(v357_0_0.clone()),
                        };
                        match &v370 {
                            Documents::US12::US12_0(v370_0_0) => {
                                let v432: std::path::PathBuf =
                                    Documents::method37(v370_0_0.clone());
                                let v583: Documents::US13 = Documents::method63(v432.display());
                                let v604: Documents::US5 = match &v583 {
                                    Documents::US13::US13_0(v583_0_0) => {
                                        Documents::US5::US5_0(v583_0_0.clone())
                                    }
                                    _ => Documents::US5::US5_1,
                                };
                                let v654: string = Documents::method39(
                                    match &v604 {
                                        Documents::US5::US5_0(v604_0_0) => match &v604 {
                                            Documents::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    },
                                    v4.clone(),
                                );
                                let v697: &str = &*v654;
                                let v865: std::string::String = String::from(v697);
                                let v1033: std::path::PathBuf = std::path::PathBuf::from(v865);
                                Ok(v1033)
                            }
                            Documents::US12::US12_1(v370_1_0) => {
                                let v1178: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v370_1_0.clone(),
                                        v128.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v1221: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1178);
                                Err(v1221)
                            }
                        }
                    } else {
                        let v1367: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v128.clone(),
                                v0_1.clone(),
                                v4.clone()
                            ),
                        );
                        let v1410: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v1367);
                        Err(v1410)
                    }
                } else {
                    let v1555: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1.clone(),
                            v128.clone(),
                            v0_1,
                            v4.clone()
                        ),
                    );
                    let v1598: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v1555);
                    Err(v1598)
                }
            }
        }
        pub fn method54(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v44: Result<std::path::PathBuf, std::io::Error> =
                std::fs::read_link(&*v0_1.clone());
            let v45 = Documents::method55();
            let v59: Result<std::path::PathBuf, string> = v44.map_err(|x| v45(x));
            let v62 = Documents::method57();
            let v63 = Documents::method58();
            let v72: Documents::US12 = match &v59 {
                Err(v59_1_0) => v63(v59_1_0.clone()),
                Ok(v59_0_0) => v62(v59_0_0.clone()),
            };
            match &v72 {
                Documents::US12::US12_0(v72_0_0) => Ok(v72_0_0.clone()),
                Documents::US12::US12_1(v72_1_0) => Documents::method64(
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
                    v72_1_0.clone(),
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
            let v116: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v129: string = Documents::method56(v3);
            if (v2) >= 11_u8 {
                let v133: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v176: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v133);
                Err(v176)
            } else {
                if let Documents::US5::US5_0(v116_0_0) = &v116 {
                    if (v4.clone()) != string("") {
                        let v343: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v116_0_0.clone());
                        let v344 = Documents::method55();
                        let v358: Result<std::path::PathBuf, string> = v343.map_err(|x| v344(x));
                        let v361 = Documents::method57();
                        let v362 = Documents::method58();
                        let v371: Documents::US12 = match &v358 {
                            Err(v358_1_0) => v362(v358_1_0.clone()),
                            Ok(v358_0_0) => v361(v358_0_0.clone()),
                        };
                        match &v371 {
                            Documents::US12::US12_0(v371_0_0) => {
                                let v433: std::path::PathBuf =
                                    Documents::method37(v371_0_0.clone());
                                let v584: Documents::US13 = Documents::method63(v433.display());
                                let v605: Documents::US5 = match &v584 {
                                    Documents::US13::US13_0(v584_0_0) => {
                                        Documents::US5::US5_0(v584_0_0.clone())
                                    }
                                    _ => Documents::US5::US5_1,
                                };
                                let v655: string = Documents::method39(
                                    match &v605 {
                                        Documents::US5::US5_0(v605_0_0) => match &v605 {
                                            Documents::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    },
                                    v5.clone(),
                                );
                                let v698: &str = &*v655;
                                let v866: std::string::String = String::from(v698);
                                let v1034: std::path::PathBuf = std::path::PathBuf::from(v866);
                                Ok(v1034)
                            }
                            Documents::US12::US12_1(v371_1_0) => {
                                let v1179: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v371_1_0.clone(),
                                        v129.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v1222: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1179);
                                Err(v1222)
                            }
                        }
                    } else {
                        let v1368: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v129.clone(),
                                v4.clone(),
                                v5.clone()
                            ),
                        );
                        let v1411: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v1368);
                        Err(v1411)
                    }
                } else {
                    let v1556: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1,
                            v129.clone(),
                            v4,
                            v5.clone()
                        ),
                    );
                    let v1599: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v1556);
                    Err(v1599)
                }
            }
        }
        pub fn method69(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v206: i32 =
                Documents::method66(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v208: bool = Documents::method68(Documents::method67(), v206);
            if v208 {
                let v258: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v624: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v624)
            } else {
                let v656: string = append(
                    string(
                        "file_system.read_link / Fsharp / The file or directory is not a reparse point. / ",
                    ),
                    sprintf!(
                        "path: {} / result: {} / path\': {} / n: {}",
                        v0_1.clone(),
                        v208,
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
                    std::io::Error::new(std::io::ErrorKind::Other, &*v656),
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
            let v115: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v128: string = Documents::method56(v3);
            if (v2) >= 11_u8 {
                let v132: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v175: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v132);
                Err(v175)
            } else {
                if let Documents::US5::US5_0(v115_0_0) = &v115 {
                    if (v0_1.clone()) != string("") {
                        let v342: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v115_0_0.clone());
                        let v343 = Documents::method55();
                        let v357: Result<std::path::PathBuf, string> = v342.map_err(|x| v343(x));
                        let v360 = Documents::method57();
                        let v361 = Documents::method58();
                        let v370: Documents::US12 = match &v357 {
                            Err(v357_1_0) => v361(v357_1_0.clone()),
                            Ok(v357_0_0) => v360(v357_0_0.clone()),
                        };
                        match &v370 {
                            Documents::US12::US12_0(v370_0_0) => {
                                let v432: std::path::PathBuf =
                                    Documents::method37(v370_0_0.clone());
                                let v583: Documents::US13 = Documents::method63(v432.display());
                                let v604: Documents::US5 = match &v583 {
                                    Documents::US13::US13_0(v583_0_0) => {
                                        Documents::US5::US5_0(v583_0_0.clone())
                                    }
                                    _ => Documents::US5::US5_1,
                                };
                                let v654: string = Documents::method39(
                                    match &v604 {
                                        Documents::US5::US5_0(v604_0_0) => match &v604 {
                                            Documents::US5::US5_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        _ => panic!("{}", string("Option does not have a value."),),
                                    },
                                    v4.clone(),
                                );
                                let v697: &str = &*v654;
                                let v865: std::string::String = String::from(v697);
                                let v1033: std::path::PathBuf = std::path::PathBuf::from(v865);
                                Ok(v1033)
                            }
                            Documents::US12::US12_1(v370_1_0) => {
                                let v1178: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v370_1_0.clone(),
                                        v128.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v1221: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v1178);
                                Err(v1221)
                            }
                        }
                    } else {
                        let v1367: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v128.clone(),
                                v0_1.clone(),
                                v4.clone()
                            ),
                        );
                        let v1410: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v1367);
                        Err(v1410)
                    }
                } else {
                    let v1555: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1.clone(),
                            v128.clone(),
                            v0_1,
                            v4.clone()
                        ),
                    );
                    let v1598: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v1555);
                    Err(v1598)
                }
            }
        }
        pub fn method65(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v205: i32 =
                Documents::method66(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v207: bool = Documents::method68(Documents::method67(), v205);
            if v207 {
                let v257: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v623: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v623)
            } else {
                let v655: string = append(
                    string(
                        "file_system.read_link / Fsharp / The file or directory is not a reparse point. / ",
                    ),
                    sprintf!(
                        "path: {} / result: {} / path\': {} / n: {}",
                        v0_1.clone(),
                        v207,
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
                    std::io::Error::new(std::io::ErrorKind::Other, &*v655),
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
            let v7: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v12: regex::Regex = v7.unwrap();
            let v24: string = Documents::method74(v2);
            let v26: std::borrow::Cow<str> = v12.replace_all(&*v24, &*v1_1);
            let v28: std::string::String = String::from(v26);
            fable_library_rust::String_::fromString(v28)
        }
        pub fn method52(v0_1: string) -> string {
            if (v0_1.clone()) == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Documents::method53(v0_1.clone());
                let v8: Option<std::path::PathBuf> = v3.ok();
                let v129: Documents::US14 =
                    defaultValue(Documents::US14::US14_1, map(Documents::method72(), v8));
                let v407: string = match &v129 {
                    Documents::US14::US14_0(v129_0_0) => {
                        let v184: std::path::PathBuf = Documents::method37(
                            match &v129 {
                                Documents::US14::US14_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                        );
                        let v335: Documents::US13 = Documents::method63(v184.display());
                        let v356: Documents::US5 = match &v335 {
                            Documents::US13::US13_0(v335_0_0) => {
                                Documents::US5::US5_0(v335_0_0.clone())
                            }
                            _ => Documents::US5::US5_1,
                        };
                        match &v356 {
                            Documents::US5::US5_0(v356_0_0) => match &v356 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => panic!("{}", string("Option does not have a value."),),
                        }
                    }
                    _ => v0_1.clone(),
                };
                let v412: string = Documents::method73(
                    string("^\\\\\\\\\\?\\\\"),
                    string(""),
                    if (v407.clone()) == string("") {
                        v0_1.clone()
                    } else {
                        v407
                    },
                );
                if (length(v412.clone())) < 2_i32 {
                    v0_1.clone()
                } else {
                    replace(
                        concat(new_array(&[
                            toLower(ofChar(getCharAt(v412.clone(), 0_i32))),
                            getSlice(v412, Some(1_i32), None::<i32>),
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
                    let v1865: () = {
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
            let v84: &str = &*v0_1.clone();
            let v252: std::string::String = String::from(v84);
            let v420: std::path::PathBuf = std::path::PathBuf::from(v252);
            if (v420.exists()) == false {
                let v549: string = Documents::method36();
                let v610: Array<string> = split(
                    Documents::method52(Documents::method39(v549.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v623: i32 = get_Count(v610.clone());
                let v624: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method77(v623, v624.clone()) {
                    let v626: i32 = v624.l0.get().clone();
                    let v629: i32 = ((v626.wrapping_neg()) + (v623)) - 1_i32;
                    let matchValue: i32 = v624.l1.get().clone();
                    let v631: Array<string> = v624.l2.get().clone();
                    let v630: i32 = matchValue;
                    let v632: string = v610[v629].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == (v632.clone()) {
                        ((v630) + 1_i32, v631.clone())
                    } else {
                        if string(".") == (v632.clone()) {
                            (v630, v631.clone())
                        } else {
                            if 0_i32 == (v630) {
                                if endsWith3(v632.clone(), string(":"), false) {
                                    let v655: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v549.clone(), 0_i32)
                                    )]);
                                    let v656: i32 = get_Count(v655.clone());
                                    let v658: i32 = (v656) + (get_Count(v631.clone()));
                                    let v659: Array<string> = new_init(&string(""), v658);
                                    let v660: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method27(v658, v660.clone()) {
                                        let v662: i32 = v660.l0.get().clone();
                                        let v667: string = if (v662) < (v656) {
                                            v655[v662].clone()
                                        } else {
                                            let v665: i32 = (v662) - (v656);
                                            v631[v665].clone()
                                        };
                                        v659.get_mut()[v662 as usize] = v667;
                                        {
                                            let v668: i32 = (v662) + 1_i32;
                                            v660.l0.set(v668);
                                            ()
                                        }
                                    }
                                    (0_i32, v659.clone())
                                } else {
                                    let v669: Array<string> = new_array(&[v632]);
                                    let v670: i32 = get_Count(v669.clone());
                                    let v672: i32 = (v670) + (get_Count(v631.clone()));
                                    let v673: Array<string> = new_init(&string(""), v672);
                                    let v674: LrcPtr<Documents::Mut5> =
                                        LrcPtr::new(Documents::Mut5 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method27(v672, v674.clone()) {
                                        let v676: i32 = v674.l0.get().clone();
                                        let v681: string = if (v676) < (v670) {
                                            v669[v676].clone()
                                        } else {
                                            let v679: i32 = (v676) - (v670);
                                            v631[v679].clone()
                                        };
                                        v673.get_mut()[v676 as usize] = v681;
                                        {
                                            let v682: i32 = (v676) + 1_i32;
                                            v674.l0.set(v682);
                                            ()
                                        }
                                    }
                                    (0_i32, v673.clone())
                                }
                            } else {
                                ((v630) - 1_i32, v631.clone())
                            }
                        }
                    };
                    let v692: i32 = (v626) + 1_i32;
                    v624.l0.set(v692);
                    v624.l1.set(patternInput_1.0.clone());
                    v624.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v624.l1.get().clone();
                    let v694: Array<string> = v624.l2.get().clone();
                    let _let__v714: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v694 = v694.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v694 = v694.clone();
                                    move |i: i32| v694[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, (get_Count(v694.clone())) - 1_i32),
                            )
                        }
                    }));
                    let v884: string = ofChar(Documents::method78());
                    join(
                        if (v884.clone()) == string("\n") {
                            Documents::method79(v884.clone())
                        } else {
                            v884
                        },
                        toArray(_let__v714),
                    )
                }
            } else {
                let v916: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v974: std::path::PathBuf = Documents::method37(v916.unwrap());
                let v976: std::path::Display = v974.display();
                let v1146: std::string::String = format!("{}", v976);
                fable_library_rust::String_::fromString(v1146)
            }
        }
        pub fn method80() -> string {
            let v4: &str = inline_colorization::color_bright_blue;
            let v47: std::string::String = String::from(v4);
            let v553: string = append(
                (fable_library_rust::String_::fromString(v47)),
                (Documents::method13(getCharAt(toLower(string("Debug")), 0_i32))),
            );
            let v569: &str = inline_colorization::color_reset;
            let v612: std::string::String = String::from(v569);
            append((v553), (fable_library_rust::String_::fromString(v612)))
        }
        pub fn method83(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("source_dir"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method84(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("dist_dir"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method85(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("cache_dir"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method86(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("hangul_spec"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method87(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("filter"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method88(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("transcribe_only"));
            v0_1.l0.set(v7);
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
            let v17: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v17.clone());
            Documents::method83(v17.clone());
            Documents::method20(v17.clone());
            Documents::method15(v17.clone(), v0_1);
            Documents::method50(v17.clone());
            Documents::method84(v17.clone());
            Documents::method20(v17.clone());
            Documents::method15(v17.clone(), v1_1);
            Documents::method50(v17.clone());
            Documents::method85(v17.clone());
            Documents::method20(v17.clone());
            Documents::method15(v17.clone(), v2);
            Documents::method50(v17.clone());
            Documents::method86(v17.clone());
            Documents::method20(v17.clone());
            Documents::method15(v17.clone(), v3);
            Documents::method50(v17.clone());
            Documents::method87(v17.clone());
            Documents::method20(v17.clone());
            Documents::method15(v17.clone(), sprintf!("{:?}", v4));
            Documents::method50(v17.clone());
            Documents::method88(v17.clone());
            Documents::method20(v17.clone());
            Documents::method15(
                v17.clone(),
                if v5 { string("true") } else { string("false") },
            );
            Documents::method21(v17.clone());
            v17.l0.get().clone()
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
            fn v79() {
                Documents::closure10((), ());
            }
            let v80: () = {
                v79();
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
            let v208: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v899: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v208,
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
                let v289: () = {
                    v79();
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
                let v375: Option<i64> = patternInput_1.5.clone();
                let v374: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v373: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v372: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v371: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v370: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v419: string = Documents::method81(
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    v373.clone(),
                    v374.clone(),
                    v375.clone(),
                    Documents::method8(v370, v371, v372, v373, v374, v375),
                    Documents::method80(),
                    v3,
                    v4,
                    v5,
                    v2,
                    v1_1,
                    v0_1,
                );
                let v493: () = {
                    v79();
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
                let v575: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v574: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v627: () = {
                    Documents::closure12(v574.clone(), ());
                    ()
                };
                println!("{}", v419.clone());
                (v575.l0.get().clone())(v419);
                Documents::US7::US7_0(
                    v574,
                    v575,
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
                            let v34: Result<std::fs::FileType, std::string::String> =
                                v19.map_err(|x| v20(x));
                            let v37 = Documents::method90();
                            let v38 = Documents::method91();
                            let v47: Documents::US15 = match &v34 {
                                Err(v34_1_0) => v38(v34_1_0.clone()),
                                Ok(v34_0_0) => v37(v34_0_0.clone()),
                            };
                            let v874: Documents::US16 = if let Documents::US15::US15_0(v47_0_0) =
                                &v47
                            {
                                if std::fs::FileType::is_dir(&v47_0_0.clone()) {
                                    Documents::US16::US16_0
                                } else {
                                    let v114: std::path::PathBuf = Documents::method37(
                                        async_walkdir::DirEntry::path(&v1_1.clone()),
                                    );
                                    let v116: std::path::Display = v114.display();
                                    let v286: std::string::String = format!("{}", v116);
                                    let v413: string =
                                        fable_library_rust::String_::fromString(v286);
                                    if if if (endsWith3(v413.clone(), string(".md"), false))
                                        == false
                                    {
                                        true
                                    } else {
                                        match &v0_1 {
                                            Documents::US5::US5_0(v0_1_0_0) => {
                                                (contains(
                                                    v413.clone(),
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
                                        endsWith3(v413.clone(), string(".hangul.md"), false)
                                    } {
                                        Documents::US16::US16_0
                                    } else {
                                        Documents::US16::US16_2
                                    }
                                }
                            } else {
                                let v516: std::path::PathBuf =
                                    Documents::method37(async_walkdir::DirEntry::path(&v1_1));
                                let v518: std::path::Display = v516.display();
                                let v688: std::string::String = format!("{}", v518);
                                let v815: string = fable_library_rust::String_::fromString(v688);
                                if if if (endsWith3(v815.clone(), string(".md"), false)) == false {
                                    true
                                } else {
                                    match &v0_1 {
                                        Documents::US5::US5_0(v0_1_0_0) => {
                                            (contains(
                                                v815.clone(),
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
                                    endsWith3(v815.clone(), string(".hangul.md"), false)
                                } {
                                    Documents::US16::US16_0
                                } else {
                                    Documents::US16::US16_2
                                }
                            };
                            let v877: string = string("}");
                            let v882: bool = true;
                            let _fix_closure_v879 = v874;
                            let v888: string = append(
                                (append(
                                    (append(
                                        (append(string("true; _fix_closure_v879 "), (v877))),
                                        string("); "),
                                    )),
                                    string(""),
                                )),
                                string(" // rust.fix_closure\'"),
                            );
                            let v889: bool = true;
                            _fix_closure_v879
                        },
                    ); // rust.fix_closure';
                    let v891 = __future_init;
                    let v893: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US16> + Send>,
                    > = v891;
                    let v895: Documents::US16 = v893.await;
                    let v904: async_walkdir::Filtering = match &v895 {
                        Documents::US16::US16_0 => async_walkdir::Filtering::Ignore,
                        Documents::US16::US16_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    };
                    let v905: string = string("}");
                    let v910: bool = true;
                    let _fix_closure_v907 = v904;
                    let v916: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v907 "), (v905))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v917: bool = true;
                    _fix_closure_v907
                },
            ); // rust.fix_closure';
            let v919 = __future_init;
            v919
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
            let v4: &str = inline_colorization::color_bright_red;
            let v47: std::string::String = String::from(v4);
            let v553: string = append(
                (fable_library_rust::String_::fromString(v47)),
                (Documents::method13(getCharAt(toLower(string("Critical")), 0_i32))),
            );
            let v569: &str = inline_colorization::color_reset;
            let v612: std::string::String = String::from(v569);
            append((v553), (fable_library_rust::String_::fromString(v612)))
        }
        pub fn method98(v0_1: std::string::String) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method51(v12.clone());
            Documents::method20(v12.clone());
            {
                let v418: std::string::String = format!("{:#?}", v0_1);
                Documents::method15(v12.clone(), fable_library_rust::String_::fromString(v418));
                Documents::method21(v12.clone());
                v12.l0.get().clone()
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
            fn v74() {
                Documents::closure10((), ());
            }
            let v75: () = {
                v74();
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
            let v203: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v894: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v203,
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
                let v284: () = {
                    v74();
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
                let v370: Option<i64> = patternInput_1.5.clone();
                let v369: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v368: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v367: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v366: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v365: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v414: string = Documents::method97(
                    v365.clone(),
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    Documents::method8(v365, v366, v367, v368, v369, v370),
                    Documents::method96(),
                    v0_1,
                );
                let v488: () = {
                    v74();
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
                let v570: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v569: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v622: () = {
                    Documents::closure12(v569.clone(), ());
                    ()
                };
                println!("{}", v414.clone());
                (v570.l0.get().clone())(v414);
                Documents::US7::US7_0(
                    v569,
                    v570,
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
            let v15: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v18 = Documents::method94();
            let v19 = Documents::method95();
            let v28: Documents::US17 = match &v15 {
                Err(v15_1_0) => v19(v15_1_0.clone()),
                Ok(v15_0_0) => v18(v15_0_0.clone()),
            };
            let v3213: Documents::US5 = match &v28 {
                Documents::US17::US17_0(v28_0_0) => {
                    let v92: std::path::PathBuf =
                        Documents::method37(async_walkdir::DirEntry::path(&v28_0_0.clone()));
                    let v94: std::path::Display = v92.display();
                    let v264: std::string::String = format!("{}", v94);
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(v264))
                }
                Documents::US17::US17_1(v28_1_0) => {
                    let v2249: () = {
                        Documents::closure39(v28_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            match &v3213 {
                Documents::US5::US5_0(v3213_0_0) => Some(
                    match &v3213 {
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
            let v7: string = append((v0_1.l0.get().clone()), string("files_len"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method100(v0_1: usize) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method101(v12.clone());
            Documents::method20(v12.clone());
            {
                let v418: std::string::String = format!("{:#?}", v0_1);
                Documents::method15(v12.clone(), fable_library_rust::String_::fromString(v418));
                Documents::method21(v12.clone());
                v12.l0.get().clone()
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
            fn v74() {
                Documents::closure10((), ());
            }
            let v75: () = {
                v74();
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
            let v203: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v896: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v203,
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
                let v284: () = {
                    v74();
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
                let v370: Option<i64> = patternInput_1.5.clone();
                let v369: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v368: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v367: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v366: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v365: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v416: string = Documents::method99(
                    v365.clone(),
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    Documents::method8(v365, v366, v367, v368, v369, v370),
                    Documents::method80(),
                    v0_1.len(),
                );
                let v490: () = {
                    v74();
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
                let v572: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v571: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v624: () = {
                    Documents::closure12(v571.clone(), ());
                    ()
                };
                println!("{}", v416.clone());
                (v572.l0.get().clone())(v416);
                Documents::US7::US7_0(
                    v571,
                    v572,
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
            let v7: string = append((v0_1.l0.get().clone()), string("c"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method109(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("st"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method110(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("line_start"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method111(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("position"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method112(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("line"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method113(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("col"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method114(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("input_len"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method107(v0_1: char, v1_1: i32, v2: i32, v3: i32, v4: i32) -> string {
            let v16: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v16.clone());
            Documents::method108(v16.clone());
            Documents::method20(v16.clone());
            Documents::method15(v16.clone(), sprintf!("{}", v0_1));
            Documents::method50(v16.clone());
            Documents::method109(v16.clone());
            Documents::method20(v16.clone());
            Documents::method18(v16.clone());
            Documents::method110(v16.clone());
            Documents::method20(v16.clone());
            Documents::method15(v16.clone(), sprintf!("{}", v1_1));
            Documents::method50(v16.clone());
            Documents::method111(v16.clone());
            Documents::method20(v16.clone());
            Documents::method18(v16.clone());
            Documents::method112(v16.clone());
            Documents::method20(v16.clone());
            Documents::method15(v16.clone(), sprintf!("{}", v2));
            Documents::method50(v16.clone());
            Documents::method113(v16.clone());
            Documents::method20(v16.clone());
            Documents::method15(v16.clone(), sprintf!("{}", v3));
            Documents::method21(v16.clone());
            Documents::method50(v16.clone());
            Documents::method114(v16.clone());
            Documents::method20(v16.clone());
            Documents::method15(v16.clone(), sprintf!("{}", v4));
            Documents::method21(v16.clone());
            Documents::method21(v16.clone());
            v16.l0.get().clone()
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
            let v7: string = append((v0_1.l0.get().clone()), string("expected"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method117(v0_1: char, v1_1: i32, v2: i32) -> string {
            let v14: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v14.clone());
            Documents::method118(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v0_1));
            Documents::method50(v14.clone());
            Documents::method112(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v1_1));
            Documents::method50(v14.clone());
            Documents::method113(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v2));
            Documents::method21(v14.clone());
            v14.l0.get().clone()
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
            let v1471: string = getSlice(v4, Some(v2), Some((v9) - 1_i32));
            let v1484: i32 = length(v1471.clone());
            let v1492: string = if if (v1484) > 0_i32 {
                (getCharAt(v1471.clone(), (v1484) - 1_i32)) == '\n'
            } else {
                false
            } {
                string("")
            } else {
                string("\n")
            };
            let v1503: string = append(
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
                            (v1471),
                        )),
                        (v1492),
                    )),
                    (v1503),
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
            let v1471: string = getSlice(v4, Some(v2), Some((v9) - 1_i32));
            let v1484: i32 = length(v1471.clone());
            let v1492: string = if if (v1484) > 0_i32 {
                (getCharAt(v1471.clone(), (v1484) - 1_i32)) == '\n'
            } else {
                false
            } {
                string("")
            } else {
                string("\n")
            };
            let v1503: string = append(
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
                            (v1471),
                        )),
                        (v1492),
                    )),
                    (v1503),
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
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method15(v12.clone(), sprintf!("{:?}", v0_1));
            v12.l0.get().clone()
        }
        pub fn method122(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("chars\'"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method123(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("s"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method121(v0_1: string, v1_1: i32, v2: i32, v3: i32, v4: i32) -> string {
            let v16: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v16.clone());
            Documents::method122(v16.clone());
            Documents::method20(v16.clone());
            Documents::method15(v16.clone(), v0_1);
            Documents::method50(v16.clone());
            Documents::method123(v16.clone());
            Documents::method20(v16.clone());
            {
                let v918: std::string::String = format!("{:#?}", v1_1);
                Documents::method15(v16.clone(), fable_library_rust::String_::fromString(v918));
                Documents::method21(v16.clone());
                v16.l0.get().clone()
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
            let v7: string = append((v0_1.l0.get().clone()), string("first_char"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method125(v0_1: char, v1_1: string, v2: i32, v3: i32, v4: i32, v5: i32) -> string {
            let v17: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v17.clone());
            Documents::method126(v17.clone());
            Documents::method20(v17.clone());
            Documents::method15(v17.clone(), sprintf!("{}", v0_1));
            Documents::method50(v17.clone());
            Documents::method122(v17.clone());
            Documents::method20(v17.clone());
            Documents::method15(v17.clone(), v1_1);
            Documents::method50(v17.clone());
            Documents::method123(v17.clone());
            Documents::method20(v17.clone());
            {
                let v1445: std::string::String = format!("{:#?}", v2);
                Documents::method15(v17.clone(), fable_library_rust::String_::fromString(v1445));
                Documents::method21(v17.clone());
                v17.l0.get().clone()
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
                            let v33: i32 = v28_0_1.clone();
                            if ((v33) == (v2.get().clone())) != true {
                                let v0_1_temp: i32 = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: i32 = v33;
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
                            } else {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure55((), ())
                                }))
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
            let v7: string = append((v0_1.l0.get().clone()), string("rest\'"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method129(v0_1: string) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method130(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), v0_1);
            Documents::method21(v12.clone());
            v12.l0.get().clone()
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
            let v7: string = append((v0_1.l0.get().clone()), string("e"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method133(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("input"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method134(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("rest\'\'"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method131(v0_1: Func0<string>, v1_1: string, v2: string, v3: string) -> string {
            let v15: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v15.clone());
            Documents::method132(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), v0_1());
            Documents::method50(v15.clone());
            Documents::method133(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), v1_1);
            Documents::method50(v15.clone());
            Documents::method130(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), v2);
            Documents::method50(v15.clone());
            Documents::method134(v15.clone());
            Documents::method20(v15.clone());
            Documents::method15(v15.clone(), v3);
            Documents::method21(v15.clone());
            v15.l0.get().clone()
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
            let v1485: bool = (v2) == (v10);
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
                            let v32: i32 = v27_0_1.clone();
                            if ((v32) == (v1_1.get().clone())) != true {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: i32 = v32;
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
                            } else {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure55((), ())
                                }))
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
            let v7: string = append((v0_1.l0.get().clone()), string("rest"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method137(v0_1: string) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method138(v12.clone());
            Documents::method20(v12.clone());
            Documents::method15(v12.clone(), v0_1);
            Documents::method21(v12.clone());
            v12.l0.get().clone()
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
        pub fn method139(v0_1: string, v1_1: i32, v2: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2: MutCell<i32> = MutCell::new(v2);
            '_method139: loop {
                break '_method139 (if (v2.get().clone()) >= (v1_1.get().clone()) {
                    v2.get().clone()
                } else {
                    let v4: char = getCharAt(v0_1.get().clone(), v2.get().clone());
                    if if if (v4) == ' ' { true } else { (v4) == '\t' } {
                        true
                    } else {
                        (v4) == '\r'
                    } {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone();
                        let v2_temp: i32 = (v2.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2.set(v2_temp);
                        continue '_method139;
                    } else {
                        v2.get().clone()
                    }
                });
            }
        }
        pub fn method140(v0_1: string, v1_1: i32, v2: i32, v3: i32, v4: i32) -> (i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method140: loop {
                break '_method140 (if (v2.get().clone()) >= (v1_1.get().clone()) {
                    (v3.get().clone(), v4.get().clone())
                } else {
                    if '\n' == (getCharAt(v0_1.get().clone(), v2.get().clone())) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone();
                        let v2_temp: i32 = (v2.get().clone()) + 1_i32;
                        let v3_temp: i32 = v2.get().clone();
                        let v4_temp: i32 = (v4.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2.set(v2_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method140;
                    } else {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = v1_1.get().clone();
                        let v2_temp: i32 = (v2.get().clone()) + 1_i32;
                        let v3_temp: i32 = v3.get().clone();
                        let v4_temp: i32 = v4.get().clone();
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        v2.set(v2_temp);
                        v3.set(v3_temp);
                        v4.set(v4_temp);
                        continue '_method140;
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
            let v307: Documents::US22 = match &v193 {
                Documents::US20::US20_0(
                    v193_0_0,
                    v193_0_1,
                    v193_0_2,
                    v193_0_3,
                    v193_0_4,
                    v193_0_5,
                ) => {
                    let v201: i32 = v193_0_5.clone();
                    let v200: i32 = v193_0_4.clone();
                    let v199: i32 = v193_0_3.clone();
                    let v198: i32 = v193_0_2.clone();
                    let v197: i32 = v193_0_1.clone();
                    let patternInput_4: (i32, i32, i32, i32, i32) = if (v197) >= (v201) {
                        (v197, v198, v199, v200, v201)
                    } else {
                        let v203: i32 = Documents::method139(v0_1.clone(), v1_1, v197);
                        let v205: i32 = if (v203) > (v201) { v201 } else { v203 };
                        let v206: i32 = (v205) - (v197);
                        if (v206) == 0_i32 {
                            (v197, v198, v199, v200, v201)
                        } else {
                            let v208: i32 = (v197) + (v206);
                            let patternInput_2: (i32, i32) =
                                Documents::method140(v0_1.clone(), v208, v197, -1_i32, 0_i32);
                            let v212: i32 = patternInput_2.1.clone();
                            let v211: i32 = patternInput_2.0.clone();
                            let patternInput_3: (i32, i32, i32, i32) = if (v212) == 0_i32 {
                                (v198, v199, (v200) + (v206), v201)
                            } else {
                                ((v211) + 1_i32, (v199) + (v212), (v208) - (v211), v201)
                            };
                            (
                                v205,
                                patternInput_3.0.clone(),
                                patternInput_3.1.clone(),
                                patternInput_3.2.clone(),
                                patternInput_3.3.clone(),
                            )
                        }
                    };
                    let v227: i32 = patternInput_4.0.clone();
                    let v238: Documents::US21 = if ((v227) == (v197)) != true {
                        Documents::US21::US21_0(
                            Func0::new(move || Documents::closure66((), ())),
                            v227,
                            patternInput_4.1.clone(),
                            patternInput_4.2.clone(),
                            patternInput_4.3.clone(),
                            patternInput_4.4.clone(),
                        )
                    } else {
                        Documents::US21::US21_1(Func0::new({
                            let v0_1 = v0_1.clone();
                            let v197 = v197.clone();
                            let v198 = v198.clone();
                            let v199 = v199.clone();
                            let v200 = v200.clone();
                            let v201 = v201.clone();
                            move || {
                                Documents::closure69(v198, v199, v200, v201, v197, v0_1.clone(), ())
                            }
                        }))
                    };
                    let v280: Documents::US20 = match &v238 {
                        Documents::US21::US21_0(
                            v238_0_0,
                            v238_0_1,
                            v238_0_2,
                            v238_0_3,
                            v238_0_4,
                            v238_0_5,
                        ) => {
                            let v244: i32 = v238_0_5.clone();
                            let v243: i32 = v238_0_4.clone();
                            let v242: i32 = v238_0_3.clone();
                            let v241: i32 = v238_0_2.clone();
                            let v240: i32 = v238_0_1.clone();
                            let patternInput_7: (i32, i32, i32, i32, i32) = if (v240) >= (v244) {
                                (v240, v241, v242, v243, v244)
                            } else {
                                let v246: i32 = Documents::method115(v0_1.clone(), v1_1, v240);
                                let v248: i32 = if (v246) > (v244) { v244 } else { v246 };
                                let v249: i32 = (v248) - (v240);
                                if (v249) == 0_i32 {
                                    (v240, v241, v242, v243, v244)
                                } else {
                                    let v251: i32 = (v240) + (v249);
                                    let patternInput_5: (i32, i32) = Documents::method140(
                                        v0_1.clone(),
                                        v251,
                                        v240,
                                        -1_i32,
                                        0_i32,
                                    );
                                    let v255: i32 = patternInput_5.1.clone();
                                    let v254: i32 = patternInput_5.0.clone();
                                    let patternInput_6: (i32, i32, i32, i32) = if (v255) == 0_i32 {
                                        (v241, v242, (v243) + (v249), v244)
                                    } else {
                                        ((v254) + 1_i32, (v242) + (v255), (v251) - (v254), v244)
                                    };
                                    (
                                        v248,
                                        patternInput_6.0.clone(),
                                        patternInput_6.1.clone(),
                                        patternInput_6.2.clone(),
                                        patternInput_6.3.clone(),
                                    )
                                }
                            };
                            let v270: i32 = patternInput_7.0.clone();
                            Documents::US20::US20_0(
                                Func0::new({
                                    let v0_1 = v0_1.clone();
                                    let v240 = v240.clone();
                                    let v270 = v270.clone();
                                    move || Documents::closure70(v240, v0_1.clone(), v270, ())
                                }),
                                v270,
                                patternInput_7.1.clone(),
                                patternInput_7.2.clone(),
                                patternInput_7.3.clone(),
                                patternInput_7.4.clone(),
                            )
                        }
                        Documents::US21::US21_1(v238_1_0) => {
                            Documents::US20::US20_1(v238_1_0.clone())
                        }
                    };
                    let v293: Documents::US24 = match &v280 {
                        Documents::US20::US20_0(
                            v280_0_0,
                            v280_0_1,
                            v280_0_2,
                            v280_0_3,
                            v280_0_4,
                            v280_0_5,
                        ) => Documents::US24::US24_0(
                            Func0::new({
                                let v280 = v280.clone();
                                move || {
                                    Documents::closure72(
                                        match &v280 {
                                            Documents::US20::US20_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v280_0_1.clone(),
                            v280_0_2.clone(),
                            v280_0_3.clone(),
                            v280_0_4.clone(),
                            v280_0_5.clone(),
                        ),
                        _ => Documents::US24::US24_0(
                            Func0::new(move || Documents::closure71((), ())),
                            v197,
                            v198,
                            v199,
                            v200,
                            v201,
                        ),
                    };
                    match &v293 {
                        Documents::US24::US24_0(
                            v293_0_0,
                            v293_0_1,
                            v293_0_2,
                            v293_0_3,
                            v293_0_4,
                            v293_0_5,
                        ) => Documents::US22::US22_0(
                            Func0::new({
                                let v193 = v193.clone();
                                let v293 = v293.clone();
                                move || {
                                    Documents::closure73(
                                        match &v193 {
                                            Documents::US20::US20_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        match &v293 {
                                            Documents::US24::US24_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v293_0_1.clone(),
                            v293_0_2.clone(),
                            v293_0_3.clone(),
                            v293_0_4.clone(),
                            v293_0_5.clone(),
                        ),
                        Documents::US24::US24_1(v293_1_0) => {
                            Documents::US22::US22_1(v293_1_0.clone())
                        }
                    }
                }
                Documents::US20::US20_1(v193_1_0) => Documents::US22::US22_1(v193_1_0.clone()),
            };
            let v319: Documents::US25 = match &v307 {
                Documents::US22::US22_0(
                    v307_0_0,
                    v307_0_1,
                    v307_0_2,
                    v307_0_3,
                    v307_0_4,
                    v307_0_5,
                ) => {
                    let v313: i32 = v307_0_5.clone();
                    let v312: i32 = v307_0_4.clone();
                    let v311: i32 = v307_0_3.clone();
                    let v310: i32 = v307_0_2.clone();
                    Documents::US25::US25_0(
                        v307_0_0.clone(),
                        Func0::new({
                            let v0_1 = v0_1.clone();
                            let v307 = v307.clone();
                            let v310 = v310.clone();
                            let v311 = v311.clone();
                            let v312 = v312.clone();
                            let v313 = v313.clone();
                            move || {
                                Documents::closure74(
                                    v0_1.clone(),
                                    v310,
                                    v311,
                                    v312,
                                    v313,
                                    match &v307 {
                                        Documents::US22::US22_0(_, x, _, _, _, _) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    (),
                                )
                            }
                        }),
                        v310,
                        v311,
                        v312,
                        v313,
                    )
                }
                Documents::US22::US22_1(v307_1_0) => Documents::US25::US25_1(v307_1_0.clone()),
            };
            let v333: Documents::US26 = match &v319 {
                Documents::US25::US25_0(
                    v319_0_0,
                    v319_0_1,
                    v319_0_2,
                    v319_0_3,
                    v319_0_4,
                    v319_0_5,
                ) => {
                    let patternInput_8 = (v319_0_0)();
                    Documents::US26::US26_0(
                        patternInput_8.0.clone(),
                        patternInput_8.1.clone(),
                        (v319_0_1)(),
                        v319_0_2.clone(),
                        v319_0_3.clone(),
                        v319_0_4.clone(),
                        v319_0_5.clone(),
                    )
                }
                Documents::US25::US25_1(v319_1_0) => Documents::US26::US26_1(v319_1_0.clone()),
            };
            let v353: Documents::US27 = match &v333 {
                Documents::US26::US26_0(
                    v333_0_0,
                    v333_0_1,
                    v333_0_2,
                    v333_0_3,
                    v333_0_4,
                    v333_0_5,
                    v333_0_6,
                ) => {
                    let v341: string = (v333_0_0)();
                    let v342: Documents::US23 = (v333_0_1)();
                    Documents::US27::US27_0(
                        v341,
                        match &v342 {
                            Documents::US23::US23_0(v342_0_0) => {
                                Documents::US5::US5_0((match &v342 {
                                    Documents::US23::US23_0(x) => x.clone(),
                                    _ => unreachable!(),
                                })())
                            }
                            _ => Documents::US5::US5_1,
                        },
                    )
                }
                Documents::US26::US26_1(v333_1_0) => Documents::US27::US27_1(v333_1_0.clone()),
            };
            match &v353 {
                Documents::US27::US27_0(v353_0_0, v353_0_1) => {
                    Documents::US18::US18_0(v353_0_0.clone(), v353_0_1.clone())
                }
                Documents::US27::US27_1(v353_1_0) => Documents::US18::US18_1((v353_1_0)()),
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
            let v1471: string = getSlice(v4, Some(v2), Some((v9) - 1_i32));
            let v1484: i32 = length(v1471.clone());
            let v1492: string = if if (v1484) > 0_i32 {
                (getCharAt(v1471.clone(), (v1484) - 1_i32)) == '\n'
            } else {
                false
            } {
                string("")
            } else {
                string("\n")
            };
            let v1503: string = append(
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
                            (v1471),
                        )),
                        (v1492),
                    )),
                    (v1503),
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
            let v1471: string = getSlice(v4, Some(v2), Some((v9) - 1_i32));
            let v1484: i32 = length(v1471.clone());
            let v1492: string = if if (v1484) > 0_i32 {
                (getCharAt(v1471.clone(), (v1484) - 1_i32)) == '\n'
            } else {
                false
            } {
                string("")
            } else {
                string("\n")
            };
            let v1503: string = append(
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
                            (v1471),
                        )),
                        (v1492),
                    )),
                    (v1503),
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
        pub fn closure93(v0_1: Func0<string>, v1_1: LrcPtr<Documents::UH2>, unitVar: ()) -> string {
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
        pub fn closure94(unitVar: (), unitVar_1: ()) -> string {
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
        ) -> Documents::US20 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1 = LrcPtr::new(MutCell::new(v1_1.clone()));
            let v2: LrcPtr<MutCell<LrcPtr<Documents::UH2>>> = LrcPtr::new(MutCell::new(v2.clone()));
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v4));
            let v5: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v5));
            let v6: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v6));
            let v7: MutCell<i32> = MutCell::new(v7);
            '_method145: loop {
                break '_method145 ({
                    let v29: Documents::US19 = if (v3.get().clone()) >= (v7.get().clone()) {
                        Documents::US19::US19_1(Func0::new({
                            let v4 = v4.clone();
                            let v5 = v5.clone();
                            let v6 = v6.clone();
                            let v7 = v7.clone();
                            move || {
                                Documents::closure82(
                                    v4.get().clone(),
                                    v5.get().clone(),
                                    v6.get().clone(),
                                    v7.get().clone(),
                                    (),
                                )
                            }
                        }))
                    } else {
                        let v11: char = getCharAt(v0_1.get().clone(), v3.get().clone());
                        if (Documents::method142(v11, 0_i64)) == false {
                            let patternInput: (i32, i32, i32, i32) = if '\n' == (v11) {
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
                                    let v11 = v11.clone();
                                    move || Documents::closure52(v11, ())
                                }),
                                (v3.get().clone()) + 1_i32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                                patternInput.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v11 = v11.clone();
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                let v6 = v6.clone();
                                let v7 = v7.clone();
                                move || {
                                    Documents::closure83(
                                        v4.get().clone(),
                                        v5.get().clone(),
                                        v6.get().clone(),
                                        v7.get().clone(),
                                        v11,
                                        (),
                                    )
                                }
                            }))
                        }
                    };
                    let v41: Documents::US20 = match &v29 {
                        Documents::US19::US19_0(
                            v29_0_0,
                            v29_0_1,
                            v29_0_2,
                            v29_0_3,
                            v29_0_4,
                            v29_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new({
                                let v29 = v29.clone();
                                move || {
                                    Documents::closure84(
                                        match &v29 {
                                            Documents::US19::US19_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v29_0_1.clone(),
                            v29_0_2.clone(),
                            v29_0_3.clone(),
                            v29_0_4.clone(),
                            v29_0_5.clone(),
                        ),
                        Documents::US19::US19_1(v29_1_0) => {
                            Documents::US20::US20_1(v29_1_0.clone())
                        }
                    };
                    let v56: Documents::US20 = match &v41 {
                        Documents::US20::US20_0(
                            v41_0_0,
                            v41_0_1,
                            v41_0_2,
                            v41_0_3,
                            v41_0_4,
                            v41_0_5,
                        ) => v41.clone(),
                        _ => Documents::method144(
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            v7.get().clone(),
                            v3.get().clone(),
                            v0_1.get().clone(),
                            LrcPtr::new(Documents::UH1::UH1_1(
                                Func1::new(
                                    move |arg10_0040_4: (string, i32, i32, i32, i32, i32)| {
                                        Documents::closure85((), arg10_0040_4)
                                    },
                                ),
                                LrcPtr::new(Documents::UH1::UH1_1(
                                    Func1::new(
                                        move |arg10_0040_5: (string, i32, i32, i32, i32, i32)| {
                                            Documents::closure89((), arg10_0040_5)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH1::UH1_0),
                                )),
                            )),
                        ),
                    };
                    match &v56 {
                        Documents::US20::US20_0(
                            v56_0_0,
                            v56_0_1,
                            v56_0_2,
                            v56_0_3,
                            v56_0_4,
                            v56_0_5,
                        ) => {
                            let v61: i32 = v56_0_1.clone();
                            if (v61) > (v3.get().clone()) {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                    Documents::UH2::UH2_1((v56_0_0)(), v2.get().clone()),
                                );
                                let v3_temp: i32 = v61;
                                let v4_temp: i32 = v56_0_2.clone();
                                let v5_temp: i32 = v56_0_3.clone();
                                let v6_temp: i32 = v56_0_4.clone();
                                let v7_temp: i32 = v56_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                v7.set(v7_temp);
                                continue '_method145;
                            } else {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure94((), ())
                                }))
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new({
                                let v1_1 = v1_1.clone();
                                let v2 = v2.clone();
                                move || {
                                    Documents::closure93(v1_1.get().clone(), v2.get().clone(), ())
                                }
                            }),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            v7.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure95(v0_1: i32, unitVar: ()) -> string {
            append(
                string("parsing.p_char / unexpected end of input / "),
                (Documents::method107('\"', 0_i32, 1_i32, 1_i32, v0_1)),
            )
        }
        pub fn closure96(v0_1: string, unitVar: ()) -> string {
            let v3: i32 = Documents::method115(v0_1.clone(), length(v0_1.clone()), 0_i32);
            let v5: i32 = if (v3) < 80_i32 { v3 } else { 80_i32 };
            let v6: bool = 0_i32 == (v5);
            let v1467: string = getSlice(v0_1, Some(0_i32), Some((v5) - 1_i32));
            let v1480: i32 = length(v1467.clone());
            let v1488: string = if if (v1480) > 0_i32 {
                (getCharAt(v1467.clone(), (v1480) - 1_i32)) == '\n'
            } else {
                false
            } {
                string("")
            } else {
                string("\n")
            };
            let v1497: string = string("^");
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
                            (v1467),
                        )),
                        (v1488),
                    )),
                    (v1497),
                )),
                string("\n"),
            )
        }
        pub fn method148(v0_1: i32, v1_1: i32, v2: i32, v3: i32) -> string {
            let v15: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v15.clone());
            Documents::method123(v15.clone());
            Documents::method20(v15.clone());
            {
                let v421: std::string::String = format!("{:#?}", v0_1);
                Documents::method15(v15.clone(), fable_library_rust::String_::fromString(v421));
                Documents::method21(v15.clone());
                v15.l0.get().clone()
            }
        }
        pub fn closure98(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
            append(
                string("parsing.any_char / unexpected end of input / "),
                (Documents::method148(v0_1, v1_1, v2, v3)),
            )
        }
        pub fn closure99(v0_1: char, unitVar: ()) -> char {
            v0_1
        }
        pub fn closure100(v0_1: Func0<char>, unitVar: ()) -> string {
            append((ofChar('\\')), (ofChar(v0_1())))
        }
        pub fn closure97(unitVar: (), _arg: (string, i32, i32, i32, i32, i32)) -> Documents::US20 {
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
                            move || Documents::closure98(v28, v29, v30, v31, ())
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
                                move || Documents::closure99(v35, ())
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
                                Documents::closure100(
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
        pub fn closure102(v0_1: Func0<char>, unitVar: ()) -> string {
            append((ofChar('`')), (ofChar(v0_1())))
        }
        pub fn closure101(unitVar: (), _arg: (string, i32, i32, i32, i32, i32)) -> Documents::US20 {
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
                            move || Documents::closure98(v28, v29, v30, v31, ())
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
                                move || Documents::closure99(v35, ())
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
                                Documents::closure102(
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
        ) -> Documents::US20 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1 = LrcPtr::new(MutCell::new(v1_1.clone()));
            let v2: LrcPtr<MutCell<LrcPtr<Documents::UH2>>> = LrcPtr::new(MutCell::new(v2.clone()));
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v4));
            let v5: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v5));
            let v6: LrcPtr<MutCell<i32>> = LrcPtr::new(MutCell::new(v6));
            let v7: MutCell<i32> = MutCell::new(v7);
            '_method149: loop {
                break '_method149 ({
                    let v29: Documents::US19 = if (v3.get().clone()) >= (v7.get().clone()) {
                        Documents::US19::US19_1(Func0::new({
                            let v4 = v4.clone();
                            let v5 = v5.clone();
                            let v6 = v6.clone();
                            let v7 = v7.clone();
                            move || {
                                Documents::closure82(
                                    v4.get().clone(),
                                    v5.get().clone(),
                                    v6.get().clone(),
                                    v7.get().clone(),
                                    (),
                                )
                            }
                        }))
                    } else {
                        let v11: char = getCharAt(v0_1.get().clone(), v3.get().clone());
                        if (Documents::method142(v11, 0_i64)) == false {
                            let patternInput: (i32, i32, i32, i32) = if '\n' == (v11) {
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
                                    let v11 = v11.clone();
                                    move || Documents::closure52(v11, ())
                                }),
                                (v3.get().clone()) + 1_i32,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                                patternInput.3.clone(),
                            )
                        } else {
                            Documents::US19::US19_1(Func0::new({
                                let v11 = v11.clone();
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                let v6 = v6.clone();
                                let v7 = v7.clone();
                                move || {
                                    Documents::closure83(
                                        v4.get().clone(),
                                        v5.get().clone(),
                                        v6.get().clone(),
                                        v7.get().clone(),
                                        v11,
                                        (),
                                    )
                                }
                            }))
                        }
                    };
                    let v41: Documents::US20 = match &v29 {
                        Documents::US19::US19_0(
                            v29_0_0,
                            v29_0_1,
                            v29_0_2,
                            v29_0_3,
                            v29_0_4,
                            v29_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new({
                                let v29 = v29.clone();
                                move || {
                                    Documents::closure84(
                                        match &v29 {
                                            Documents::US19::US19_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v29_0_1.clone(),
                            v29_0_2.clone(),
                            v29_0_3.clone(),
                            v29_0_4.clone(),
                            v29_0_5.clone(),
                        ),
                        Documents::US19::US19_1(v29_1_0) => {
                            Documents::US20::US20_1(v29_1_0.clone())
                        }
                    };
                    let v56: Documents::US20 = match &v41 {
                        Documents::US20::US20_0(
                            v41_0_0,
                            v41_0_1,
                            v41_0_2,
                            v41_0_3,
                            v41_0_4,
                            v41_0_5,
                        ) => v41.clone(),
                        _ => Documents::method144(
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            v7.get().clone(),
                            v3.get().clone(),
                            v0_1.get().clone(),
                            LrcPtr::new(Documents::UH1::UH1_1(
                                Func1::new(
                                    move |arg10_0040_4: (string, i32, i32, i32, i32, i32)| {
                                        Documents::closure97((), arg10_0040_4)
                                    },
                                ),
                                LrcPtr::new(Documents::UH1::UH1_1(
                                    Func1::new(
                                        move |arg10_0040_5: (string, i32, i32, i32, i32, i32)| {
                                            Documents::closure101((), arg10_0040_5)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH1::UH1_0),
                                )),
                            )),
                        ),
                    };
                    match &v56 {
                        Documents::US20::US20_0(
                            v56_0_0,
                            v56_0_1,
                            v56_0_2,
                            v56_0_3,
                            v56_0_4,
                            v56_0_5,
                        ) => {
                            let v61: i32 = v56_0_1.clone();
                            if (v61) > (v3.get().clone()) {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                    Documents::UH2::UH2_1((v56_0_0)(), v2.get().clone()),
                                );
                                let v3_temp: i32 = v61;
                                let v4_temp: i32 = v56_0_2.clone();
                                let v5_temp: i32 = v56_0_3.clone();
                                let v6_temp: i32 = v56_0_4.clone();
                                let v7_temp: i32 = v56_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                v7.set(v7_temp);
                                continue '_method149;
                            } else {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure94((), ())
                                }))
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new({
                                let v1_1 = v1_1.clone();
                                let v2 = v2.clone();
                                move || {
                                    Documents::closure93(v1_1.get().clone(), v2.get().clone(), ())
                                }
                            }),
                            v3.get().clone(),
                            v4.get().clone(),
                            v5.get().clone(),
                            v6.get().clone(),
                            v7.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn closure103(v0_1: i32, unitVar: ()) -> string {
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
        pub fn closure104(v0_1: i32, v1_1: char, unitVar: ()) -> string {
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
        pub fn closure105(v0_1: i32, v1_1: i32, v2: i32, v3: i32, unitVar: ()) -> string {
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
        pub fn closure106(v0_1: i32, v1_1: i32, v2: i32, v3: i32, v4: char, unitVar: ()) -> string {
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
                                Documents::closure105(
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
                                    Documents::closure106(
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
                            let v32: i32 = v27_0_1.clone();
                            if ((v32) == (v1_1.get().clone())) != true {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: i32 = v32;
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
                            } else {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure55((), ())
                                }))
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
        pub fn closure107(v0_1: LrcPtr<Documents::UH2>, unitVar: ()) -> LrcPtr<Documents::UH2> {
            Documents::method146(v0_1, LrcPtr::new(Documents::UH2::UH2_0))
        }
        pub fn closure108(unitVar: (), unitVar_1: ()) -> string {
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
        ) -> Documents::US29 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: LrcPtr<MutCell<LrcPtr<Documents::UH2>>> =
                LrcPtr::new(MutCell::new(v1_1.clone()));
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: MutCell<i32> = MutCell::new(v5);
            let v6: MutCell<i32> = MutCell::new(v6);
            '_method152: loop {
                break '_method152 ({
                    let v12: Documents::US20 = Documents::method144(
                        v3.get().clone(),
                        v4.get().clone(),
                        v5.get().clone(),
                        v6.get().clone(),
                        v2.get().clone(),
                        v0_1.get().clone(),
                        LrcPtr::new(Documents::UH1::UH1_1(
                            Func1::new(move |arg10_0040: (string, i32, i32, i32, i32, i32)| {
                                Documents::closure97((), arg10_0040)
                            }),
                            LrcPtr::new(Documents::UH1::UH1_1(
                                Func1::new(
                                    move |arg10_0040_1: (string, i32, i32, i32, i32, i32)| {
                                        Documents::closure101((), arg10_0040_1)
                                    },
                                ),
                                LrcPtr::new(Documents::UH1::UH1_0),
                            )),
                        )),
                    );
                    let v24: Documents::US20 = match &v12 {
                        Documents::US20::US20_0(
                            v12_0_0,
                            v12_0_1,
                            v12_0_2,
                            v12_0_3,
                            v12_0_4,
                            v12_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new(move || Documents::closure68((), ())),
                            v12_0_1.clone(),
                            v12_0_2.clone(),
                            v12_0_3.clone(),
                            v12_0_4.clone(),
                            v12_0_5.clone(),
                        ),
                        Documents::US20::US20_1(v12_1_0) => {
                            Documents::US20::US20_1(v12_1_0.clone())
                        }
                    };
                    let v68: Documents::US20 = match &v24 {
                        Documents::US20::US20_0(
                            v24_0_0,
                            v24_0_1,
                            v24_0_2,
                            v24_0_3,
                            v24_0_4,
                            v24_0_5,
                        ) => {
                            let v30: i32 = v24_0_5.clone();
                            let v29: i32 = v24_0_4.clone();
                            let v28: i32 = v24_0_3.clone();
                            let v27: i32 = v24_0_2.clone();
                            let v26: i32 = v24_0_1.clone();
                            let v52: Documents::US19 = if (v26) >= (v30) {
                                Documents::US19::US19_1(Func0::new({
                                    let v27 = v27.clone();
                                    let v28 = v28.clone();
                                    let v29 = v29.clone();
                                    let v30 = v30.clone();
                                    move || Documents::closure82(v27, v28, v29, v30, ())
                                }))
                            } else {
                                let v34: char = getCharAt(v0_1.get().clone(), v26);
                                if (Documents::method142(v34, 0_i64)) == false {
                                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v34) {
                                        ((v27) + (v29), (v28) + 1_i32, 1_i32, v30)
                                    } else {
                                        (v27, v28, (v29) + 1_i32, v30)
                                    };
                                    Documents::US19::US19_0(
                                        Func0::new({
                                            let v34 = v34.clone();
                                            move || Documents::closure52(v34, ())
                                        }),
                                        (v26) + 1_i32,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                        patternInput.3.clone(),
                                    )
                                } else {
                                    Documents::US19::US19_1(Func0::new({
                                        let v27 = v27.clone();
                                        let v28 = v28.clone();
                                        let v29 = v29.clone();
                                        let v30 = v30.clone();
                                        let v34 = v34.clone();
                                        move || Documents::closure83(v27, v28, v29, v30, v34, ())
                                    }))
                                }
                            };
                            match &v52 {
                                Documents::US19::US19_0(
                                    v52_0_0,
                                    v52_0_1,
                                    v52_0_2,
                                    v52_0_3,
                                    v52_0_4,
                                    v52_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new({
                                        let v52 = v52.clone();
                                        move || {
                                            Documents::closure84(
                                                match &v52 {
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
                                    v52_0_1.clone(),
                                    v52_0_2.clone(),
                                    v52_0_3.clone(),
                                    v52_0_4.clone(),
                                    v52_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v52_1_0) => {
                                    Documents::US20::US20_1(v52_1_0.clone())
                                }
                            }
                        }
                        Documents::US20::US20_1(v24_1_0) => {
                            Documents::US20::US20_1(v24_1_0.clone())
                        }
                    };
                    match &v68 {
                        Documents::US20::US20_0(
                            v68_0_0,
                            v68_0_1,
                            v68_0_2,
                            v68_0_3,
                            v68_0_4,
                            v68_0_5,
                        ) => {
                            let v73: i32 = v68_0_1.clone();
                            if (v73) > (v2.get().clone()) {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                    Documents::UH2::UH2_1((v68_0_0)(), v1_1.get().clone()),
                                );
                                let v2_temp: i32 = v73;
                                let v3_temp: i32 = v68_0_2.clone();
                                let v4_temp: i32 = v68_0_3.clone();
                                let v5_temp: i32 = v68_0_4.clone();
                                let v6_temp: i32 = v68_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                continue '_method152;
                            } else {
                                Documents::US29::US29_1(Func0::new(move || {
                                    Documents::closure108((), ())
                                }))
                            }
                        }
                        _ => Documents::US29::US29_0(
                            Func0::new({
                                let v1_1 = v1_1.clone();
                                move || Documents::closure107(v1_1.get().clone(), ())
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
        pub fn closure109(v0_1: Func0<LrcPtr<Documents::UH2>>, unitVar: ()) -> string {
            (Documents::method147(v0_1(), string(""))).0.clone()
        }
        pub fn closure110(unitVar: (), unitVar_1: ()) -> string {
            string("runtime.split_args / segment zero-length success")
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
                                Documents::closure105(
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
                                    Documents::closure106(
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
                            let v33: i32 = v28_0_1.clone();
                            if ((v33) == (v2.get().clone())) != true {
                                let v0_1_temp: i32 = v0_1.get().clone();
                                let v1_1_temp: string = v1_1.get().clone();
                                let v2_temp: i32 = v33;
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
                            } else {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure55((), ())
                                }))
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
        pub fn closure111(v0_1: LrcPtr<Documents::UH2>, unitVar: ()) -> string {
            (Documents::method147(
                Documents::method146(v0_1, LrcPtr::new(Documents::UH2::UH2_0)),
                string(""),
            ))
            .0
            .clone()
        }
        pub fn closure112(unitVar: (), unitVar_1: ()) -> string {
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
        ) -> Documents::US20 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: LrcPtr<MutCell<LrcPtr<Documents::UH2>>> =
                LrcPtr::new(MutCell::new(v1_1.clone()));
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            let v5: MutCell<i32> = MutCell::new(v5);
            let v6: MutCell<i32> = MutCell::new(v6);
            '_method153: loop {
                break '_method153 ({
                    fn v7(arg10_0040: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
                        Documents::closure75((), arg10_0040)
                    }
                    fn v8(arg10_0040_1: (string, i32, i32, i32, i32, i32)) -> Documents::US19 {
                        Documents::closure79((), arg10_0040_1)
                    }
                    let v12: Documents::US19 = Documents::method128(
                        v3.get().clone(),
                        v4.get().clone(),
                        v5.get().clone(),
                        v6.get().clone(),
                        v2.get().clone(),
                        v0_1.get().clone(),
                        LrcPtr::new(Documents::UH0::UH0_1(
                            Func1::from(v7),
                            LrcPtr::new(Documents::UH0::UH0_1(
                                Func1::from(v8),
                                LrcPtr::new(Documents::UH0::UH0_0),
                            )),
                        )),
                    );
                    let v130: Documents::US20 = match &v12 {
                        Documents::US19::US19_0(
                            v12_0_0,
                            v12_0_1,
                            v12_0_2,
                            v12_0_3,
                            v12_0_4,
                            v12_0_5,
                        ) => {
                            let v18: i32 = v12_0_5.clone();
                            let v17: i32 = v12_0_4.clone();
                            let v16: i32 = v12_0_3.clone();
                            let v15: i32 = v12_0_2.clone();
                            let v14: i32 = v12_0_1.clone();
                            let v40: Documents::US19 = if (v14) >= (v18) {
                                Documents::US19::US19_1(Func0::new({
                                    let v15 = v15.clone();
                                    let v16 = v16.clone();
                                    let v17 = v17.clone();
                                    let v18 = v18.clone();
                                    move || Documents::closure82(v15, v16, v17, v18, ())
                                }))
                            } else {
                                let v22: char = getCharAt(v0_1.get().clone(), v14);
                                if (Documents::method142(v22, 0_i64)) == false {
                                    let patternInput: (i32, i32, i32, i32) = if '\n' == (v22) {
                                        ((v15) + (v17), (v16) + 1_i32, 1_i32, v18)
                                    } else {
                                        (v15, v16, (v17) + 1_i32, v18)
                                    };
                                    Documents::US19::US19_0(
                                        Func0::new({
                                            let v22 = v22.clone();
                                            move || Documents::closure52(v22, ())
                                        }),
                                        (v14) + 1_i32,
                                        patternInput.0.clone(),
                                        patternInput.1.clone(),
                                        patternInput.2.clone(),
                                        patternInput.3.clone(),
                                    )
                                } else {
                                    Documents::US19::US19_1(Func0::new({
                                        let v15 = v15.clone();
                                        let v16 = v16.clone();
                                        let v17 = v17.clone();
                                        let v18 = v18.clone();
                                        let v22 = v22.clone();
                                        move || Documents::closure83(v15, v16, v17, v18, v22, ())
                                    }))
                                }
                            };
                            let v52: Documents::US20 = match &v40 {
                                Documents::US19::US19_0(
                                    v40_0_0,
                                    v40_0_1,
                                    v40_0_2,
                                    v40_0_3,
                                    v40_0_4,
                                    v40_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new({
                                        let v40 = v40.clone();
                                        move || {
                                            Documents::closure84(
                                                match &v40 {
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
                                    v40_0_1.clone(),
                                    v40_0_2.clone(),
                                    v40_0_3.clone(),
                                    v40_0_4.clone(),
                                    v40_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v40_1_0) => {
                                    Documents::US20::US20_1(v40_1_0.clone())
                                }
                            };
                            let v67: Documents::US20 = match &v52 {
                                Documents::US20::US20_0(
                                    v52_0_0,
                                    v52_0_1,
                                    v52_0_2,
                                    v52_0_3,
                                    v52_0_4,
                                    v52_0_5,
                                ) => v52.clone(),
                                _ => Documents::method144(
                                    v15,
                                    v16,
                                    v17,
                                    v18,
                                    v14,
                                    v0_1.get().clone(),
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::new(
                                            move |arg10_0040_6: (
                                                string,
                                                i32,
                                                i32,
                                                i32,
                                                i32,
                                                i32,
                                            )| {
                                                Documents::closure85((), arg10_0040_6)
                                            },
                                        ),
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
                                                    Documents::closure89((), arg10_0040_7)
                                                },
                                            ),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                ),
                            };
                            let v84: Documents::US20 = match &v67 {
                                Documents::US20::US20_0(
                                    v67_0_0,
                                    v67_0_1,
                                    v67_0_2,
                                    v67_0_3,
                                    v67_0_4,
                                    v67_0_5,
                                ) => {
                                    let v72: i32 = v67_0_1.clone();
                                    if (v72) == (v14) {
                                        Documents::US20::US20_1(Func0::new(move || {
                                            Documents::closure92((), ())
                                        }))
                                    } else {
                                        Documents::method145(
                                            v0_1.get().clone(),
                                            v67_0_0.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v72,
                                            v67_0_2.clone(),
                                            v67_0_3.clone(),
                                            v67_0_4.clone(),
                                            v67_0_5.clone(),
                                        )
                                    }
                                }
                                _ => Documents::US20::US20_0(
                                    Func0::new(move || Documents::closure91((), ())),
                                    v14,
                                    v15,
                                    v16,
                                    v17,
                                    v18,
                                ),
                            };
                            match &v84 {
                                Documents::US20::US20_0(
                                    v84_0_0,
                                    v84_0_1,
                                    v84_0_2,
                                    v84_0_3,
                                    v84_0_4,
                                    v84_0_5,
                                ) => {
                                    let v86: i32 = v84_0_1.clone();
                                    let v94: Documents::US19 = Documents::method128(
                                        v84_0_2.clone(),
                                        v84_0_3.clone(),
                                        v84_0_4.clone(),
                                        v84_0_5.clone(),
                                        v86,
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH0::UH0_1(
                                            Func1::from(v7),
                                            LrcPtr::new(Documents::UH0::UH0_1(
                                                Func1::from(v8),
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            )),
                                        )),
                                    );
                                    match &v94 {
                                        Documents::US19::US19_0(
                                            v94_0_0,
                                            v94_0_1,
                                            v94_0_2,
                                            v94_0_3,
                                            v94_0_4,
                                            v94_0_5,
                                        ) => Documents::US20::US20_0(
                                            v84_0_0.clone(),
                                            v94_0_1.clone(),
                                            v94_0_2.clone(),
                                            v94_0_3.clone(),
                                            v94_0_4.clone(),
                                            v94_0_5.clone(),
                                        ),
                                        Documents::US19::US19_1(v94_1_0) => {
                                            Documents::US20::US20_1(Func0::new({
                                                let v0_1 = v0_1.clone();
                                                let v14 = v14.clone();
                                                let v86 = v86.clone();
                                                let v94 = v94.clone();
                                                move || {
                                                    Documents::closure59(
                                                        v0_1.get().clone(),
                                                        v14,
                                                        v86,
                                                        match &v94 {
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
                                    let v111: Documents::US19 = Documents::method128(
                                        v15,
                                        v16,
                                        v17,
                                        v18,
                                        v14,
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH0::UH0_1(
                                            Func1::from(v7),
                                            LrcPtr::new(Documents::UH0::UH0_1(
                                                Func1::from(v8),
                                                LrcPtr::new(Documents::UH0::UH0_0),
                                            )),
                                        )),
                                    );
                                    match &v111 {
                                        Documents::US19::US19_0(
                                            v111_0_0,
                                            v111_0_1,
                                            v111_0_2,
                                            v111_0_3,
                                            v111_0_4,
                                            v111_0_5,
                                        ) => Documents::US20::US20_0(
                                            Func0::new(move || Documents::closure58((), ())),
                                            v111_0_1.clone(),
                                            v111_0_2.clone(),
                                            v111_0_3.clone(),
                                            v111_0_4.clone(),
                                            v111_0_5.clone(),
                                        ),
                                        _ => Documents::US20::US20_1(Func0::new({
                                            let v0_1 = v0_1.clone();
                                            let v14 = v14.clone();
                                            move || {
                                                Documents::closure57(v0_1.get().clone(), v14, ())
                                            }
                                        })),
                                    }
                                }
                            }
                        }
                        Documents::US19::US19_1(v12_1_0) => {
                            Documents::US20::US20_1(v12_1_0.clone())
                        }
                    };
                    let v308: Documents::US20 = match &v130 {
                        Documents::US20::US20_0(
                            v130_0_0,
                            v130_0_1,
                            v130_0_2,
                            v130_0_3,
                            v130_0_4,
                            v130_0_5,
                        ) => v130.clone(),
                        _ => {
                            let v157: Documents::US19 = if (v2.get().clone()) >= (v6.get().clone())
                            {
                                Documents::US19::US19_1(Func0::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    let v5 = v5.clone();
                                    let v6 = v6.clone();
                                    move || {
                                        Documents::closure43(
                                            v3.get().clone(),
                                            v4.get().clone(),
                                            v5.get().clone(),
                                            v6.get().clone(),
                                            (),
                                        )
                                    }
                                }))
                            } else {
                                let v141: char = getCharAt(v0_1.get().clone(), v2.get().clone());
                                if (v141) == '\"' {
                                    let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v141) {
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
                                            let v141 = v141.clone();
                                            move || Documents::closure44(v141, ())
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
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move || {
                                            Documents::closure45(
                                                v5.get().clone(),
                                                v4.get().clone(),
                                                v3.get().clone(),
                                                v2.get().clone(),
                                                v0_1.get().clone(),
                                                (),
                                            )
                                        }
                                    }))
                                }
                            };
                            match &v157 {
                                Documents::US19::US19_0(
                                    v157_0_0,
                                    v157_0_1,
                                    v157_0_2,
                                    v157_0_3,
                                    v157_0_4,
                                    v157_0_5,
                                ) => {
                                    let v163: i32 = v157_0_5.clone();
                                    let v162: i32 = v157_0_4.clone();
                                    let v161: i32 = v157_0_3.clone();
                                    let v160: i32 = v157_0_2.clone();
                                    let v159: i32 = v157_0_1.clone();
                                    let v164: bool = (v159) >= (v163);
                                    let v185: Documents::US19 = if v164 {
                                        Documents::US19::US19_1(Func0::new({
                                            let v160 = v160.clone();
                                            let v161 = v161.clone();
                                            let v162 = v162.clone();
                                            let v163 = v163.clone();
                                            move || Documents::closure82(v160, v161, v162, v163, ())
                                        }))
                                    } else {
                                        let v167: char = getCharAt(v0_1.get().clone(), v159);
                                        if (Documents::method142(v167, 0_i64)) == false {
                                            let patternInput_2: (i32, i32, i32, i32) =
                                                if '\n' == (v167) {
                                                    ((v160) + (v162), (v161) + 1_i32, 1_i32, v163)
                                                } else {
                                                    (v160, v161, (v162) + 1_i32, v163)
                                                };
                                            Documents::US19::US19_0(
                                                Func0::new({
                                                    let v167 = v167.clone();
                                                    move || Documents::closure52(v167, ())
                                                }),
                                                (v159) + 1_i32,
                                                patternInput_2.0.clone(),
                                                patternInput_2.1.clone(),
                                                patternInput_2.2.clone(),
                                                patternInput_2.3.clone(),
                                            )
                                        } else {
                                            Documents::US19::US19_1(Func0::new({
                                                let v160 = v160.clone();
                                                let v161 = v161.clone();
                                                let v162 = v162.clone();
                                                let v163 = v163.clone();
                                                let v167 = v167.clone();
                                                move || {
                                                    Documents::closure83(
                                                        v160,
                                                        v161,
                                                        v162,
                                                        v163,
                                                        v167,
                                                        (),
                                                    )
                                                }
                                            }))
                                        }
                                    };
                                    let v197: Documents::US20 = match &v185 {
                                        Documents::US19::US19_0(
                                            v185_0_0,
                                            v185_0_1,
                                            v185_0_2,
                                            v185_0_3,
                                            v185_0_4,
                                            v185_0_5,
                                        ) => Documents::US20::US20_0(
                                            Func0::new({
                                                let v185 = v185.clone();
                                                move || {
                                                    Documents::closure84(
                                                        match &v185 {
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
                                            v185_0_1.clone(),
                                            v185_0_2.clone(),
                                            v185_0_3.clone(),
                                            v185_0_4.clone(),
                                            v185_0_5.clone(),
                                        ),
                                        Documents::US19::US19_1(v185_1_0) => {
                                            Documents::US20::US20_1(v185_1_0.clone())
                                        }
                                    };
                                    let v212: Documents::US20 =
                                                     match &v197 {
                                                         Documents::US20::US20_0(v197_0_0,
                                                                                 v197_0_1,
                                                                                 v197_0_2,
                                                                                 v197_0_3,
                                                                                 v197_0_4,
                                                                                 v197_0_5)
                                                         => v197.clone(),
                                                         _ =>
                                                         Documents::method144(v160,
                                                                              v161,
                                                                              v162,
                                                                              v163,
                                                                              v159,
                                                                              v0_1.get().clone(),
                                                                              LrcPtr::new(Documents::UH1::UH1_1(Func1::new(move
                                                                                                                               |arg10_0040_20:
                                                                                                                                    (string,
                                                                                                                                     i32,
                                                                                                                                     i32,
                                                                                                                                     i32,
                                                                                                                                     i32,
                                                                                                                                     i32)|
                                                                                                                               Documents::closure97((),
                                                                                                                                                    arg10_0040_20)),
                                                                                                                LrcPtr::new(Documents::UH1::UH1_1(Func1::new(move
                                                                                                                                                                 |arg10_0040_21:
                                                                                                                                                                      (string,
                                                                                                                                                                       i32,
                                                                                                                                                                       i32,
                                                                                                                                                                       i32,
                                                                                                                                                                       i32,
                                                                                                                                                                       i32)|
                                                                                                                                                                 Documents::closure101((),
                                                                                                                                                                                       arg10_0040_21)),
                                                                                                                                                  LrcPtr::new(Documents::UH1::UH1_0)))))),
                                                     };
                                    let v229: Documents::US20 = match &v212 {
                                        Documents::US20::US20_0(
                                            v212_0_0,
                                            v212_0_1,
                                            v212_0_2,
                                            v212_0_3,
                                            v212_0_4,
                                            v212_0_5,
                                        ) => {
                                            let v217: i32 = v212_0_1.clone();
                                            if (v217) == (v159) {
                                                Documents::US20::US20_1(Func0::new(move || {
                                                    Documents::closure92((), ())
                                                }))
                                            } else {
                                                Documents::method149(
                                                    v0_1.get().clone(),
                                                    v212_0_0.clone(),
                                                    LrcPtr::new(Documents::UH2::UH2_0),
                                                    v217,
                                                    v212_0_2.clone(),
                                                    v212_0_3.clone(),
                                                    v212_0_4.clone(),
                                                    v212_0_5.clone(),
                                                )
                                            }
                                        }
                                        _ => Documents::US20::US20_0(
                                            Func0::new(move || Documents::closure91((), ())),
                                            v159,
                                            v160,
                                            v161,
                                            v162,
                                            v163,
                                        ),
                                    };
                                    match &v229 {
                                        Documents::US20::US20_0(
                                            v229_0_0,
                                            v229_0_1,
                                            v229_0_2,
                                            v229_0_3,
                                            v229_0_4,
                                            v229_0_5,
                                        ) => {
                                            let v235: i32 = v229_0_5.clone();
                                            let v234: i32 = v229_0_4.clone();
                                            let v233: i32 = v229_0_3.clone();
                                            let v232: i32 = v229_0_2.clone();
                                            let v231: i32 = v229_0_1.clone();
                                            let v255: Documents::US19 = if (v231) >= (v235) {
                                                Documents::US19::US19_1(Func0::new({
                                                    let v232 = v232.clone();
                                                    let v233 = v233.clone();
                                                    let v234 = v234.clone();
                                                    let v235 = v235.clone();
                                                    move || {
                                                        Documents::closure43(
                                                            v232,
                                                            v233,
                                                            v234,
                                                            v235,
                                                            (),
                                                        )
                                                    }
                                                }))
                                            } else {
                                                let v239: char =
                                                    getCharAt(v0_1.get().clone(), v231);
                                                if (v239) == '\"' {
                                                    let patternInput_4: (i32, i32, i32, i32) =
                                                        if '\n' == (v239) {
                                                            (
                                                                (v232) + (v234),
                                                                (v233) + 1_i32,
                                                                1_i32,
                                                                v235,
                                                            )
                                                        } else {
                                                            (v232, v233, (v234) + 1_i32, v235)
                                                        };
                                                    Documents::US19::US19_0(
                                                        Func0::new({
                                                            let v239 = v239.clone();
                                                            move || Documents::closure44(v239, ())
                                                        }),
                                                        (v231) + 1_i32,
                                                        patternInput_4.0.clone(),
                                                        patternInput_4.1.clone(),
                                                        patternInput_4.2.clone(),
                                                        patternInput_4.3.clone(),
                                                    )
                                                } else {
                                                    Documents::US19::US19_1(Func0::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v231 = v231.clone();
                                                        let v232 = v232.clone();
                                                        let v233 = v233.clone();
                                                        let v234 = v234.clone();
                                                        move || {
                                                            Documents::closure45(
                                                                v234,
                                                                v233,
                                                                v232,
                                                                v231,
                                                                v0_1.get().clone(),
                                                                (),
                                                            )
                                                        }
                                                    }))
                                                }
                                            };
                                            match &v255 {
                                                Documents::US19::US19_0(
                                                    v255_0_0,
                                                    v255_0_1,
                                                    v255_0_2,
                                                    v255_0_3,
                                                    v255_0_4,
                                                    v255_0_5,
                                                ) => Documents::US20::US20_0(
                                                    v229_0_0.clone(),
                                                    v255_0_1.clone(),
                                                    v255_0_2.clone(),
                                                    v255_0_3.clone(),
                                                    v255_0_4.clone(),
                                                    v255_0_5.clone(),
                                                ),
                                                Documents::US19::US19_1(v255_1_0) => {
                                                    Documents::US20::US20_1(Func0::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v159 = v159.clone();
                                                        let v231 = v231.clone();
                                                        let v255 = v255.clone();
                                                        move || {
                                                            Documents::closure59(
                                                                v0_1.get().clone(),
                                                                v159,
                                                                v231,
                                                                match &v255 {
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
                                            let v287: Documents::US19 = if v164 {
                                                Documents::US19::US19_1(Func0::new({
                                                    let v160 = v160.clone();
                                                    let v161 = v161.clone();
                                                    let v162 = v162.clone();
                                                    let v163 = v163.clone();
                                                    move || {
                                                        Documents::closure43(
                                                            v160,
                                                            v161,
                                                            v162,
                                                            v163,
                                                            (),
                                                        )
                                                    }
                                                }))
                                            } else {
                                                let v271: char =
                                                    getCharAt(v0_1.get().clone(), v159);
                                                if (v271) == '\"' {
                                                    let patternInput_3: (i32, i32, i32, i32) =
                                                        if '\n' == (v271) {
                                                            (
                                                                (v160) + (v162),
                                                                (v161) + 1_i32,
                                                                1_i32,
                                                                v163,
                                                            )
                                                        } else {
                                                            (v160, v161, (v162) + 1_i32, v163)
                                                        };
                                                    Documents::US19::US19_0(
                                                        Func0::new({
                                                            let v271 = v271.clone();
                                                            move || Documents::closure44(v271, ())
                                                        }),
                                                        (v159) + 1_i32,
                                                        patternInput_3.0.clone(),
                                                        patternInput_3.1.clone(),
                                                        patternInput_3.2.clone(),
                                                        patternInput_3.3.clone(),
                                                    )
                                                } else {
                                                    Documents::US19::US19_1(Func0::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v159 = v159.clone();
                                                        let v160 = v160.clone();
                                                        let v161 = v161.clone();
                                                        let v162 = v162.clone();
                                                        move || {
                                                            Documents::closure45(
                                                                v162,
                                                                v161,
                                                                v160,
                                                                v159,
                                                                v0_1.get().clone(),
                                                                (),
                                                            )
                                                        }
                                                    }))
                                                }
                                            };
                                            match &v287 {
                                                Documents::US19::US19_0(
                                                    v287_0_0,
                                                    v287_0_1,
                                                    v287_0_2,
                                                    v287_0_3,
                                                    v287_0_4,
                                                    v287_0_5,
                                                ) => Documents::US20::US20_0(
                                                    Func0::new(move || {
                                                        Documents::closure58((), ())
                                                    }),
                                                    v287_0_1.clone(),
                                                    v287_0_2.clone(),
                                                    v287_0_3.clone(),
                                                    v287_0_4.clone(),
                                                    v287_0_5.clone(),
                                                ),
                                                _ => Documents::US20::US20_1(Func0::new({
                                                    let v0_1 = v0_1.clone();
                                                    let v159 = v159.clone();
                                                    move || {
                                                        Documents::closure57(
                                                            v0_1.get().clone(),
                                                            v159,
                                                            (),
                                                        )
                                                    }
                                                })),
                                            }
                                        }
                                    }
                                }
                                Documents::US19::US19_1(v157_1_0) => {
                                    Documents::US20::US20_1(v157_1_0.clone())
                                }
                            }
                        }
                    };
                    let v350: Documents::US20 = match &v308 {
                        Documents::US20::US20_0(
                            v308_0_0,
                            v308_0_1,
                            v308_0_2,
                            v308_0_3,
                            v308_0_4,
                            v308_0_5,
                        ) => v308.clone(),
                        _ => {
                            let v337: Documents::US19 = if (v2.get().clone()) >= (v6.get().clone())
                            {
                                Documents::US19::US19_1(Func0::new({
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    let v5 = v5.clone();
                                    let v6 = v6.clone();
                                    move || {
                                        Documents::closure105(
                                            v3.get().clone(),
                                            v4.get().clone(),
                                            v5.get().clone(),
                                            v6.get().clone(),
                                            (),
                                        )
                                    }
                                }))
                            } else {
                                let v319: char = getCharAt(v0_1.get().clone(), v2.get().clone());
                                if (Documents::method150(v319, 0_i64)) == false {
                                    let patternInput_5: (i32, i32, i32, i32) = if '\n' == (v319) {
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
                                            let v319 = v319.clone();
                                            move || Documents::closure52(v319, ())
                                        }),
                                        (v2.get().clone()) + 1_i32,
                                        patternInput_5.0.clone(),
                                        patternInput_5.1.clone(),
                                        patternInput_5.2.clone(),
                                        patternInput_5.3.clone(),
                                    )
                                } else {
                                    Documents::US19::US19_1(Func0::new({
                                        let v3 = v3.clone();
                                        let v319 = v319.clone();
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        let v6 = v6.clone();
                                        move || {
                                            Documents::closure106(
                                                v3.get().clone(),
                                                v4.get().clone(),
                                                v5.get().clone(),
                                                v6.get().clone(),
                                                v319,
                                                (),
                                            )
                                        }
                                    }))
                                }
                            };
                            match &v337 {
                                Documents::US19::US19_0(
                                    v337_0_0,
                                    v337_0_1,
                                    v337_0_2,
                                    v337_0_3,
                                    v337_0_4,
                                    v337_0_5,
                                ) => Documents::method154(
                                    v2.get().clone(),
                                    v0_1.get().clone(),
                                    v337_0_1.clone(),
                                    v337_0_2.clone(),
                                    v337_0_3.clone(),
                                    v337_0_4.clone(),
                                    v337_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v337_1_0) => {
                                    Documents::US20::US20_1(v337_1_0.clone())
                                }
                            }
                        }
                    };
                    let v373: Documents::US20 = match &v350 {
                        Documents::US20::US20_0(
                            v350_0_0,
                            v350_0_1,
                            v350_0_2,
                            v350_0_3,
                            v350_0_4,
                            v350_0_5,
                        ) => v350.clone(),
                        _ => {
                            let v359: Documents::US29 = Documents::method152(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                                v5.get().clone(),
                                v6.get().clone(),
                            );
                            match &v359 {
                                Documents::US29::US29_0(
                                    v359_0_0,
                                    v359_0_1,
                                    v359_0_2,
                                    v359_0_3,
                                    v359_0_4,
                                    v359_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new({
                                        let v359 = v359.clone();
                                        move || {
                                            Documents::closure109(
                                                match &v359 {
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
                                    v359_0_1.clone(),
                                    v359_0_2.clone(),
                                    v359_0_3.clone(),
                                    v359_0_4.clone(),
                                    v359_0_5.clone(),
                                ),
                                Documents::US29::US29_1(v359_1_0) => {
                                    Documents::US20::US20_1(v359_1_0.clone())
                                }
                            }
                        }
                    };
                    let v384: Documents::US20 = if let Documents::US20::US20_0(
                        v373_0_0,
                        v373_0_1,
                        v373_0_2,
                        v373_0_3,
                        v373_0_4,
                        v373_0_5,
                    ) = &v373
                    {
                        if (v373_0_1.clone()) == (v2.get().clone()) {
                            Documents::US20::US20_1(Func0::new(move || {
                                Documents::closure110((), ())
                            }))
                        } else {
                            v373.clone()
                        }
                    } else {
                        v373.clone()
                    };
                    match &v384 {
                        Documents::US20::US20_0(
                            v384_0_0,
                            v384_0_1,
                            v384_0_2,
                            v384_0_3,
                            v384_0_4,
                            v384_0_5,
                        ) => {
                            let v389: i32 = v384_0_1.clone();
                            if (v389) > (v2.get().clone()) {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                    Documents::UH2::UH2_1((v384_0_0)(), v1_1.get().clone()),
                                );
                                let v2_temp: i32 = v389;
                                let v3_temp: i32 = v384_0_2.clone();
                                let v4_temp: i32 = v384_0_3.clone();
                                let v5_temp: i32 = v384_0_4.clone();
                                let v6_temp: i32 = v384_0_5.clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                v5.set(v5_temp);
                                v6.set(v6_temp);
                                continue '_method153;
                            } else {
                                Documents::US20::US20_1(Func0::new(move || {
                                    Documents::closure112((), ())
                                }))
                            }
                        }
                        _ => Documents::US20::US20_0(
                            Func0::new({
                                let v1_1 = v1_1.clone();
                                move || Documents::closure111(v1_1.get().clone(), ())
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
        pub fn closure113(unitVar: (), unitVar_1: ()) -> LrcPtr<Documents::UH2> {
            LrcPtr::new(Documents::UH2::UH2_0)
        }
        pub fn closure114(v0_1: LrcPtr<Documents::UH2>, unitVar: ()) -> LrcPtr<Documents::UH2> {
            Documents::method146(v0_1, LrcPtr::new(Documents::UH2::UH2_0))
        }
        pub fn closure115(unitVar: (), unitVar_1: ()) -> string {
            string("parsing.sep_by / separator consumed no input")
        }
        pub fn closure116(v0_1: LrcPtr<Documents::UH2>, unitVar: ()) -> LrcPtr<Documents::UH2> {
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
                    let patternInput_2: (i32, i32, i32, i32, i32) =
                        if (v2.get().clone()) >= (v6.get().clone()) {
                            (
                                v2.get().clone(),
                                v3.get().clone(),
                                v4.get().clone(),
                                v5.get().clone(),
                                v6.get().clone(),
                            )
                        } else {
                            let v9: i32 = Documents::method139(
                                v0_1.get().clone(),
                                length(v0_1.get().clone()),
                                v2.get().clone(),
                            );
                            let v11: i32 = if (v9) > (v6.get().clone()) {
                                v6.get().clone()
                            } else {
                                v9
                            };
                            let v12: i32 = (v11) - (v2.get().clone());
                            if (v12) == 0_i32 {
                                (
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                    v5.get().clone(),
                                    v6.get().clone(),
                                )
                            } else {
                                let v14: i32 = (v2.get().clone()) + (v12);
                                let patternInput: (i32, i32) = Documents::method140(
                                    v0_1.get().clone(),
                                    v14,
                                    v2.get().clone(),
                                    -1_i32,
                                    0_i32,
                                );
                                let v18: i32 = patternInput.1.clone();
                                let v17: i32 = patternInput.0.clone();
                                let patternInput_1: (i32, i32, i32, i32) = if (v18) == 0_i32 {
                                    (
                                        v3.get().clone(),
                                        v4.get().clone(),
                                        (v5.get().clone()) + (v12),
                                        v6.get().clone(),
                                    )
                                } else {
                                    (
                                        (v17) + 1_i32,
                                        (v4.get().clone()) + (v18),
                                        (v14) - (v17),
                                        v6.get().clone(),
                                    )
                                };
                                (
                                    v11,
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                    patternInput_1.3.clone(),
                                )
                            }
                        };
                    let v33: i32 = patternInput_2.0.clone();
                    let v44: Documents::US21 = if ((v33) == (v2.get().clone())) != true {
                        Documents::US21::US21_0(
                            Func0::new(move || Documents::closure66((), ())),
                            v33,
                            patternInput_2.1.clone(),
                            patternInput_2.2.clone(),
                            patternInput_2.3.clone(),
                            patternInput_2.4.clone(),
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
                    match &v44 {
                        Documents::US21::US21_0(
                            v44_0_0,
                            v44_0_1,
                            v44_0_2,
                            v44_0_3,
                            v44_0_4,
                            v44_0_5,
                        ) => {
                            let v53: i32 = v44_0_5.clone();
                            let v52: i32 = v44_0_4.clone();
                            let v51: i32 = v44_0_3.clone();
                            let v50: i32 = v44_0_2.clone();
                            let v49: i32 = v44_0_1.clone();
                            if (v49) == (v2.get().clone()) {
                                Documents::US29::US29_1(Func0::new(move || {
                                    Documents::closure115((), ())
                                }))
                            } else {
                                fn v57(
                                    arg10_0040_4: (string, i32, i32, i32, i32, i32),
                                ) -> Documents::US19 {
                                    Documents::closure75((), arg10_0040_4)
                                }
                                fn v58(
                                    arg10_0040_5: (string, i32, i32, i32, i32, i32),
                                ) -> Documents::US19 {
                                    Documents::closure79((), arg10_0040_5)
                                }
                                let v62: Documents::US19 = Documents::method128(
                                    v50,
                                    v51,
                                    v52,
                                    v53,
                                    v49,
                                    v0_1.get().clone(),
                                    LrcPtr::new(Documents::UH0::UH0_1(
                                        Func1::from(v57),
                                        LrcPtr::new(Documents::UH0::UH0_1(
                                            Func1::from(v58),
                                            LrcPtr::new(Documents::UH0::UH0_0),
                                        )),
                                    )),
                                );
                                let v180: Documents::US20 = match &v62 {
                                    Documents::US19::US19_0(
                                        v62_0_0,
                                        v62_0_1,
                                        v62_0_2,
                                        v62_0_3,
                                        v62_0_4,
                                        v62_0_5,
                                    ) => {
                                        let v68: i32 = v62_0_5.clone();
                                        let v67: i32 = v62_0_4.clone();
                                        let v66: i32 = v62_0_3.clone();
                                        let v65: i32 = v62_0_2.clone();
                                        let v64: i32 = v62_0_1.clone();
                                        let v90: Documents::US19 = if (v64) >= (v68) {
                                            Documents::US19::US19_1(Func0::new({
                                                let v65 = v65.clone();
                                                let v66 = v66.clone();
                                                let v67 = v67.clone();
                                                let v68 = v68.clone();
                                                move || Documents::closure82(v65, v66, v67, v68, ())
                                            }))
                                        } else {
                                            let v72: char = getCharAt(v0_1.get().clone(), v64);
                                            if (Documents::method142(v72, 0_i64)) == false {
                                                let patternInput_3: (i32, i32, i32, i32) =
                                                    if '\n' == (v72) {
                                                        ((v65) + (v67), (v66) + 1_i32, 1_i32, v68)
                                                    } else {
                                                        (v65, v66, (v67) + 1_i32, v68)
                                                    };
                                                Documents::US19::US19_0(
                                                    Func0::new({
                                                        let v72 = v72.clone();
                                                        move || Documents::closure52(v72, ())
                                                    }),
                                                    (v64) + 1_i32,
                                                    patternInput_3.0.clone(),
                                                    patternInput_3.1.clone(),
                                                    patternInput_3.2.clone(),
                                                    patternInput_3.3.clone(),
                                                )
                                            } else {
                                                Documents::US19::US19_1(Func0::new({
                                                    let v65 = v65.clone();
                                                    let v66 = v66.clone();
                                                    let v67 = v67.clone();
                                                    let v68 = v68.clone();
                                                    let v72 = v72.clone();
                                                    move || {
                                                        Documents::closure83(
                                                            v65,
                                                            v66,
                                                            v67,
                                                            v68,
                                                            v72,
                                                            (),
                                                        )
                                                    }
                                                }))
                                            }
                                        };
                                        let v102: Documents::US20 = match &v90 {
                                            Documents::US19::US19_0(
                                                v90_0_0,
                                                v90_0_1,
                                                v90_0_2,
                                                v90_0_3,
                                                v90_0_4,
                                                v90_0_5,
                                            ) => Documents::US20::US20_0(
                                                Func0::new({
                                                    let v90 = v90.clone();
                                                    move || {
                                                        Documents::closure84(
                                                            match &v90 {
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
                                                v90_0_1.clone(),
                                                v90_0_2.clone(),
                                                v90_0_3.clone(),
                                                v90_0_4.clone(),
                                                v90_0_5.clone(),
                                            ),
                                            Documents::US19::US19_1(v90_1_0) => {
                                                Documents::US20::US20_1(v90_1_0.clone())
                                            }
                                        };
                                        let v117:
                                                             Documents::US20 =
                                                         match &v102 {
                                                             Documents::US20::US20_0(v102_0_0,
                                                                                     v102_0_1,
                                                                                     v102_0_2,
                                                                                     v102_0_3,
                                                                                     v102_0_4,
                                                                                     v102_0_5)
                                                             => v102.clone(),
                                                             _ =>
                                                             Documents::method144(v65,
                                                                                  v66,
                                                                                  v67,
                                                                                  v68,
                                                                                  v64,
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
                                        let v134: Documents::US20 = match &v117 {
                                            Documents::US20::US20_0(
                                                v117_0_0,
                                                v117_0_1,
                                                v117_0_2,
                                                v117_0_3,
                                                v117_0_4,
                                                v117_0_5,
                                            ) => {
                                                let v122: i32 = v117_0_1.clone();
                                                if (v122) == (v64) {
                                                    Documents::US20::US20_1(Func0::new(move || {
                                                        Documents::closure92((), ())
                                                    }))
                                                } else {
                                                    Documents::method145(
                                                        v0_1.get().clone(),
                                                        v117_0_0.clone(),
                                                        LrcPtr::new(Documents::UH2::UH2_0),
                                                        v122,
                                                        v117_0_2.clone(),
                                                        v117_0_3.clone(),
                                                        v117_0_4.clone(),
                                                        v117_0_5.clone(),
                                                    )
                                                }
                                            }
                                            _ => Documents::US20::US20_0(
                                                Func0::new(move || Documents::closure91((), ())),
                                                v64,
                                                v65,
                                                v66,
                                                v67,
                                                v68,
                                            ),
                                        };
                                        match &v134 {
                                            Documents::US20::US20_0(
                                                v134_0_0,
                                                v134_0_1,
                                                v134_0_2,
                                                v134_0_3,
                                                v134_0_4,
                                                v134_0_5,
                                            ) => {
                                                let v136: i32 = v134_0_1.clone();
                                                let v144: Documents::US19 = Documents::method128(
                                                    v134_0_2.clone(),
                                                    v134_0_3.clone(),
                                                    v134_0_4.clone(),
                                                    v134_0_5.clone(),
                                                    v136,
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH0::UH0_1(
                                                        Func1::from(v57),
                                                        LrcPtr::new(Documents::UH0::UH0_1(
                                                            Func1::from(v58),
                                                            LrcPtr::new(Documents::UH0::UH0_0),
                                                        )),
                                                    )),
                                                );
                                                match &v144 {
                                                    Documents::US19::US19_0(
                                                        v144_0_0,
                                                        v144_0_1,
                                                        v144_0_2,
                                                        v144_0_3,
                                                        v144_0_4,
                                                        v144_0_5,
                                                    ) => Documents::US20::US20_0(
                                                        v134_0_0.clone(),
                                                        v144_0_1.clone(),
                                                        v144_0_2.clone(),
                                                        v144_0_3.clone(),
                                                        v144_0_4.clone(),
                                                        v144_0_5.clone(),
                                                    ),
                                                    Documents::US19::US19_1(v144_1_0) => {
                                                        Documents::US20::US20_1(Func0::new({
                                                            let v0_1 = v0_1.clone();
                                                            let v136 = v136.clone();
                                                            let v144 = v144.clone();
                                                            let v64 = v64.clone();
                                                            move || {
                                                                Documents::closure59(
                                                                    v0_1.get().clone(),
                                                                    v64,
                                                                    v136,
                                                                    match &v144 {
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
                                                let v161: Documents::US19 = Documents::method128(
                                                    v65,
                                                    v66,
                                                    v67,
                                                    v68,
                                                    v64,
                                                    v0_1.get().clone(),
                                                    LrcPtr::new(Documents::UH0::UH0_1(
                                                        Func1::from(v57),
                                                        LrcPtr::new(Documents::UH0::UH0_1(
                                                            Func1::from(v58),
                                                            LrcPtr::new(Documents::UH0::UH0_0),
                                                        )),
                                                    )),
                                                );
                                                match &v161 {
                                                    Documents::US19::US19_0(
                                                        v161_0_0,
                                                        v161_0_1,
                                                        v161_0_2,
                                                        v161_0_3,
                                                        v161_0_4,
                                                        v161_0_5,
                                                    ) => Documents::US20::US20_0(
                                                        Func0::new(move || {
                                                            Documents::closure58((), ())
                                                        }),
                                                        v161_0_1.clone(),
                                                        v161_0_2.clone(),
                                                        v161_0_3.clone(),
                                                        v161_0_4.clone(),
                                                        v161_0_5.clone(),
                                                    ),
                                                    _ => Documents::US20::US20_1(Func0::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v64 = v64.clone();
                                                        move || {
                                                            Documents::closure57(
                                                                v0_1.get().clone(),
                                                                v64,
                                                                (),
                                                            )
                                                        }
                                                    })),
                                                }
                                            }
                                        }
                                    }
                                    Documents::US19::US19_1(v62_1_0) => {
                                        Documents::US20::US20_1(v62_1_0.clone())
                                    }
                                };
                                let v358: Documents::US20 = match &v180 {
                                    Documents::US20::US20_0(
                                        v180_0_0,
                                        v180_0_1,
                                        v180_0_2,
                                        v180_0_3,
                                        v180_0_4,
                                        v180_0_5,
                                    ) => v180.clone(),
                                    _ => {
                                        let v207: Documents::US19 = if (v49) >= (v53) {
                                            Documents::US19::US19_1(Func0::new({
                                                let v50 = v50.clone();
                                                let v51 = v51.clone();
                                                let v52 = v52.clone();
                                                let v53 = v53.clone();
                                                move || Documents::closure43(v50, v51, v52, v53, ())
                                            }))
                                        } else {
                                            let v191: char = getCharAt(v0_1.get().clone(), v49);
                                            if (v191) == '\"' {
                                                let patternInput_4: (i32, i32, i32, i32) =
                                                    if '\n' == (v191) {
                                                        ((v50) + (v52), (v51) + 1_i32, 1_i32, v53)
                                                    } else {
                                                        (v50, v51, (v52) + 1_i32, v53)
                                                    };
                                                Documents::US19::US19_0(
                                                    Func0::new({
                                                        let v191 = v191.clone();
                                                        move || Documents::closure44(v191, ())
                                                    }),
                                                    (v49) + 1_i32,
                                                    patternInput_4.0.clone(),
                                                    patternInput_4.1.clone(),
                                                    patternInput_4.2.clone(),
                                                    patternInput_4.3.clone(),
                                                )
                                            } else {
                                                Documents::US19::US19_1(Func0::new({
                                                    let v0_1 = v0_1.clone();
                                                    let v49 = v49.clone();
                                                    let v50 = v50.clone();
                                                    let v51 = v51.clone();
                                                    let v52 = v52.clone();
                                                    move || {
                                                        Documents::closure45(
                                                            v52,
                                                            v51,
                                                            v50,
                                                            v49,
                                                            v0_1.get().clone(),
                                                            (),
                                                        )
                                                    }
                                                }))
                                            }
                                        };
                                        match &v207 {
                                            Documents::US19::US19_0(
                                                v207_0_0,
                                                v207_0_1,
                                                v207_0_2,
                                                v207_0_3,
                                                v207_0_4,
                                                v207_0_5,
                                            ) => {
                                                let v213: i32 = v207_0_5.clone();
                                                let v212: i32 = v207_0_4.clone();
                                                let v211: i32 = v207_0_3.clone();
                                                let v210: i32 = v207_0_2.clone();
                                                let v209: i32 = v207_0_1.clone();
                                                let v214: bool = (v209) >= (v213);
                                                let v235: Documents::US19 = if v214 {
                                                    Documents::US19::US19_1(Func0::new({
                                                        let v210 = v210.clone();
                                                        let v211 = v211.clone();
                                                        let v212 = v212.clone();
                                                        let v213 = v213.clone();
                                                        move || {
                                                            Documents::closure82(
                                                                v210,
                                                                v211,
                                                                v212,
                                                                v213,
                                                                (),
                                                            )
                                                        }
                                                    }))
                                                } else {
                                                    let v217: char =
                                                        getCharAt(v0_1.get().clone(), v209);
                                                    if (Documents::method142(v217, 0_i64)) == false
                                                    {
                                                        let patternInput_5: (i32, i32, i32, i32) =
                                                            if '\n' == (v217) {
                                                                (
                                                                    (v210) + (v212),
                                                                    (v211) + 1_i32,
                                                                    1_i32,
                                                                    v213,
                                                                )
                                                            } else {
                                                                (v210, v211, (v212) + 1_i32, v213)
                                                            };
                                                        Documents::US19::US19_0(
                                                            Func0::new({
                                                                let v217 = v217.clone();
                                                                move || {
                                                                    Documents::closure52(v217, ())
                                                                }
                                                            }),
                                                            (v209) + 1_i32,
                                                            patternInput_5.0.clone(),
                                                            patternInput_5.1.clone(),
                                                            patternInput_5.2.clone(),
                                                            patternInput_5.3.clone(),
                                                        )
                                                    } else {
                                                        Documents::US19::US19_1(Func0::new({
                                                            let v210 = v210.clone();
                                                            let v211 = v211.clone();
                                                            let v212 = v212.clone();
                                                            let v213 = v213.clone();
                                                            let v217 = v217.clone();
                                                            move || {
                                                                Documents::closure83(
                                                                    v210,
                                                                    v211,
                                                                    v212,
                                                                    v213,
                                                                    v217,
                                                                    (),
                                                                )
                                                            }
                                                        }))
                                                    }
                                                };
                                                let v247: Documents::US20 = match &v235 {
                                                    Documents::US19::US19_0(
                                                        v235_0_0,
                                                        v235_0_1,
                                                        v235_0_2,
                                                        v235_0_3,
                                                        v235_0_4,
                                                        v235_0_5,
                                                    ) => Documents::US20::US20_0(
                                                        Func0::new({
                                                            let v235 = v235.clone();
                                                            move || {
                                                                Documents::closure84(
                                                                    match &v235 {
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
                                                        v235_0_1.clone(),
                                                        v235_0_2.clone(),
                                                        v235_0_3.clone(),
                                                        v235_0_4.clone(),
                                                        v235_0_5.clone(),
                                                    ),
                                                    Documents::US19::US19_1(v235_1_0) => {
                                                        Documents::US20::US20_1(v235_1_0.clone())
                                                    }
                                                };
                                                let v262:
                                                                     Documents::US20 =
                                                                 match &v247 {
                                                                     Documents::US20::US20_0(v247_0_0,
                                                                                             v247_0_1,
                                                                                             v247_0_2,
                                                                                             v247_0_3,
                                                                                             v247_0_4,
                                                                                             v247_0_5)
                                                                     =>
                                                                     v247.clone(),
                                                                     _ =>
                                                                     Documents::method144(v210,
                                                                                          v211,
                                                                                          v212,
                                                                                          v213,
                                                                                          v209,
                                                                                          v0_1.get().clone(),
                                                                                          LrcPtr::new(Documents::UH1::UH1_1(Func1::new(move
                                                                                                                                           |arg10_0040_24:
                                                                                                                                                (string,
                                                                                                                                                 i32,
                                                                                                                                                 i32,
                                                                                                                                                 i32,
                                                                                                                                                 i32,
                                                                                                                                                 i32)|
                                                                                                                                           Documents::closure97((),
                                                                                                                                                                arg10_0040_24)),
                                                                                                                            LrcPtr::new(Documents::UH1::UH1_1(Func1::new(move
                                                                                                                                                                             |arg10_0040_25:
                                                                                                                                                                                  (string,
                                                                                                                                                                                   i32,
                                                                                                                                                                                   i32,
                                                                                                                                                                                   i32,
                                                                                                                                                                                   i32,
                                                                                                                                                                                   i32)|
                                                                                                                                                                             Documents::closure101((),
                                                                                                                                                                                                   arg10_0040_25)),
                                                                                                                                                              LrcPtr::new(Documents::UH1::UH1_0)))))),
                                                                 };
                                                let v279: Documents::US20 = match &v262 {
                                                    Documents::US20::US20_0(
                                                        v262_0_0,
                                                        v262_0_1,
                                                        v262_0_2,
                                                        v262_0_3,
                                                        v262_0_4,
                                                        v262_0_5,
                                                    ) => {
                                                        let v267: i32 = v262_0_1.clone();
                                                        if (v267) == (v209) {
                                                            Documents::US20::US20_1(Func0::new(
                                                                move || {
                                                                    Documents::closure92((), ())
                                                                },
                                                            ))
                                                        } else {
                                                            Documents::method149(
                                                                v0_1.get().clone(),
                                                                v262_0_0.clone(),
                                                                LrcPtr::new(Documents::UH2::UH2_0),
                                                                v267,
                                                                v262_0_2.clone(),
                                                                v262_0_3.clone(),
                                                                v262_0_4.clone(),
                                                                v262_0_5.clone(),
                                                            )
                                                        }
                                                    }
                                                    _ => Documents::US20::US20_0(
                                                        Func0::new(move || {
                                                            Documents::closure91((), ())
                                                        }),
                                                        v209,
                                                        v210,
                                                        v211,
                                                        v212,
                                                        v213,
                                                    ),
                                                };
                                                match &v279 {
                                                    Documents::US20::US20_0(
                                                        v279_0_0,
                                                        v279_0_1,
                                                        v279_0_2,
                                                        v279_0_3,
                                                        v279_0_4,
                                                        v279_0_5,
                                                    ) => {
                                                        let v285: i32 = v279_0_5.clone();
                                                        let v284: i32 = v279_0_4.clone();
                                                        let v283: i32 = v279_0_3.clone();
                                                        let v282: i32 = v279_0_2.clone();
                                                        let v281: i32 = v279_0_1.clone();
                                                        let v305: Documents::US19 = if (v281)
                                                            >= (v285)
                                                        {
                                                            Documents::US19::US19_1(Func0::new({
                                                                let v282 = v282.clone();
                                                                let v283 = v283.clone();
                                                                let v284 = v284.clone();
                                                                let v285 = v285.clone();
                                                                move || {
                                                                    Documents::closure43(
                                                                        v282,
                                                                        v283,
                                                                        v284,
                                                                        v285,
                                                                        (),
                                                                    )
                                                                }
                                                            }))
                                                        } else {
                                                            let v289: char =
                                                                getCharAt(v0_1.get().clone(), v281);
                                                            if (v289) == '\"' {
                                                                let patternInput_7: (
                                                                    i32,
                                                                    i32,
                                                                    i32,
                                                                    i32,
                                                                ) = if '\n' == (v289) {
                                                                    (
                                                                        (v282) + (v284),
                                                                        (v283) + 1_i32,
                                                                        1_i32,
                                                                        v285,
                                                                    )
                                                                } else {
                                                                    (
                                                                        v282,
                                                                        v283,
                                                                        (v284) + 1_i32,
                                                                        v285,
                                                                    )
                                                                };
                                                                Documents::US19::US19_0(
                                                                    Func0::new({
                                                                        let v289 = v289.clone();
                                                                        move || {
                                                                            Documents::closure44(
                                                                                v289,
                                                                                (),
                                                                            )
                                                                        }
                                                                    }),
                                                                    (v281) + 1_i32,
                                                                    patternInput_7.0.clone(),
                                                                    patternInput_7.1.clone(),
                                                                    patternInput_7.2.clone(),
                                                                    patternInput_7.3.clone(),
                                                                )
                                                            } else {
                                                                Documents::US19::US19_1(Func0::new(
                                                                    {
                                                                        let v0_1 = v0_1.clone();
                                                                        let v281 = v281.clone();
                                                                        let v282 = v282.clone();
                                                                        let v283 = v283.clone();
                                                                        let v284 = v284.clone();
                                                                        move || {
                                                                            Documents::closure45(
                                                                                v284,
                                                                                v283,
                                                                                v282,
                                                                                v281,
                                                                                v0_1.get().clone(),
                                                                                (),
                                                                            )
                                                                        }
                                                                    },
                                                                ))
                                                            }
                                                        };
                                                        match &v305 {
                                                            Documents::US19::US19_0(
                                                                v305_0_0,
                                                                v305_0_1,
                                                                v305_0_2,
                                                                v305_0_3,
                                                                v305_0_4,
                                                                v305_0_5,
                                                            ) => Documents::US20::US20_0(
                                                                v279_0_0.clone(),
                                                                v305_0_1.clone(),
                                                                v305_0_2.clone(),
                                                                v305_0_3.clone(),
                                                                v305_0_4.clone(),
                                                                v305_0_5.clone(),
                                                            ),
                                                            Documents::US19::US19_1(v305_1_0) => {
                                                                Documents::US20::US20_1(Func0::new(
                                                                    {
                                                                        let v0_1 = v0_1.clone();
                                                                        let v209 = v209.clone();
                                                                        let v281 = v281.clone();
                                                                        let v305 = v305.clone();
                                                                        move || {
                                                                            Documents::closure59(v0_1.get().clone(),
                                                                                                                                         v209,
                                                                                                                                         v281,
                                                                                                                                         match &v305
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
                                                        let v337: Documents::US19 = if v214 {
                                                            Documents::US19::US19_1(Func0::new({
                                                                let v210 = v210.clone();
                                                                let v211 = v211.clone();
                                                                let v212 = v212.clone();
                                                                let v213 = v213.clone();
                                                                move || {
                                                                    Documents::closure43(
                                                                        v210,
                                                                        v211,
                                                                        v212,
                                                                        v213,
                                                                        (),
                                                                    )
                                                                }
                                                            }))
                                                        } else {
                                                            let v321: char =
                                                                getCharAt(v0_1.get().clone(), v209);
                                                            if (v321) == '\"' {
                                                                let patternInput_6: (
                                                                    i32,
                                                                    i32,
                                                                    i32,
                                                                    i32,
                                                                ) = if '\n' == (v321) {
                                                                    (
                                                                        (v210) + (v212),
                                                                        (v211) + 1_i32,
                                                                        1_i32,
                                                                        v213,
                                                                    )
                                                                } else {
                                                                    (
                                                                        v210,
                                                                        v211,
                                                                        (v212) + 1_i32,
                                                                        v213,
                                                                    )
                                                                };
                                                                Documents::US19::US19_0(
                                                                    Func0::new({
                                                                        let v321 = v321.clone();
                                                                        move || {
                                                                            Documents::closure44(
                                                                                v321,
                                                                                (),
                                                                            )
                                                                        }
                                                                    }),
                                                                    (v209) + 1_i32,
                                                                    patternInput_6.0.clone(),
                                                                    patternInput_6.1.clone(),
                                                                    patternInput_6.2.clone(),
                                                                    patternInput_6.3.clone(),
                                                                )
                                                            } else {
                                                                Documents::US19::US19_1(Func0::new(
                                                                    {
                                                                        let v0_1 = v0_1.clone();
                                                                        let v209 = v209.clone();
                                                                        let v210 = v210.clone();
                                                                        let v211 = v211.clone();
                                                                        let v212 = v212.clone();
                                                                        move || {
                                                                            Documents::closure45(
                                                                                v212,
                                                                                v211,
                                                                                v210,
                                                                                v209,
                                                                                v0_1.get().clone(),
                                                                                (),
                                                                            )
                                                                        }
                                                                    },
                                                                ))
                                                            }
                                                        };
                                                        match &v337 {
                                                            Documents::US19::US19_0(
                                                                v337_0_0,
                                                                v337_0_1,
                                                                v337_0_2,
                                                                v337_0_3,
                                                                v337_0_4,
                                                                v337_0_5,
                                                            ) => Documents::US20::US20_0(
                                                                Func0::new(move || {
                                                                    Documents::closure58((), ())
                                                                }),
                                                                v337_0_1.clone(),
                                                                v337_0_2.clone(),
                                                                v337_0_3.clone(),
                                                                v337_0_4.clone(),
                                                                v337_0_5.clone(),
                                                            ),
                                                            _ => Documents::US20::US20_1(
                                                                Func0::new({
                                                                    let v0_1 = v0_1.clone();
                                                                    let v209 = v209.clone();
                                                                    move || {
                                                                        Documents::closure57(
                                                                            v0_1.get().clone(),
                                                                            v209,
                                                                            (),
                                                                        )
                                                                    }
                                                                }),
                                                            ),
                                                        }
                                                    }
                                                }
                                            }
                                            Documents::US19::US19_1(v207_1_0) => {
                                                Documents::US20::US20_1(v207_1_0.clone())
                                            }
                                        }
                                    }
                                };
                                let v400: Documents::US20 = match &v358 {
                                    Documents::US20::US20_0(
                                        v358_0_0,
                                        v358_0_1,
                                        v358_0_2,
                                        v358_0_3,
                                        v358_0_4,
                                        v358_0_5,
                                    ) => v358.clone(),
                                    _ => {
                                        let v387: Documents::US19 = if (v49) >= (v53) {
                                            Documents::US19::US19_1(Func0::new({
                                                let v50 = v50.clone();
                                                let v51 = v51.clone();
                                                let v52 = v52.clone();
                                                let v53 = v53.clone();
                                                move || {
                                                    Documents::closure105(v50, v51, v52, v53, ())
                                                }
                                            }))
                                        } else {
                                            let v369: char = getCharAt(v0_1.get().clone(), v49);
                                            if (Documents::method150(v369, 0_i64)) == false {
                                                let patternInput_8: (i32, i32, i32, i32) =
                                                    if '\n' == (v369) {
                                                        ((v50) + (v52), (v51) + 1_i32, 1_i32, v53)
                                                    } else {
                                                        (v50, v51, (v52) + 1_i32, v53)
                                                    };
                                                Documents::US19::US19_0(
                                                    Func0::new({
                                                        let v369 = v369.clone();
                                                        move || Documents::closure52(v369, ())
                                                    }),
                                                    (v49) + 1_i32,
                                                    patternInput_8.0.clone(),
                                                    patternInput_8.1.clone(),
                                                    patternInput_8.2.clone(),
                                                    patternInput_8.3.clone(),
                                                )
                                            } else {
                                                Documents::US19::US19_1(Func0::new({
                                                    let v369 = v369.clone();
                                                    let v50 = v50.clone();
                                                    let v51 = v51.clone();
                                                    let v52 = v52.clone();
                                                    let v53 = v53.clone();
                                                    move || {
                                                        Documents::closure106(
                                                            v50,
                                                            v51,
                                                            v52,
                                                            v53,
                                                            v369,
                                                            (),
                                                        )
                                                    }
                                                }))
                                            }
                                        };
                                        match &v387 {
                                            Documents::US19::US19_0(
                                                v387_0_0,
                                                v387_0_1,
                                                v387_0_2,
                                                v387_0_3,
                                                v387_0_4,
                                                v387_0_5,
                                            ) => Documents::method154(
                                                v49,
                                                v0_1.get().clone(),
                                                v387_0_1.clone(),
                                                v387_0_2.clone(),
                                                v387_0_3.clone(),
                                                v387_0_4.clone(),
                                                v387_0_5.clone(),
                                            ),
                                            Documents::US19::US19_1(v387_1_0) => {
                                                Documents::US20::US20_1(v387_1_0.clone())
                                            }
                                        }
                                    }
                                };
                                let v423: Documents::US20 = match &v400 {
                                    Documents::US20::US20_0(
                                        v400_0_0,
                                        v400_0_1,
                                        v400_0_2,
                                        v400_0_3,
                                        v400_0_4,
                                        v400_0_5,
                                    ) => v400.clone(),
                                    _ => {
                                        let v409: Documents::US29 = Documents::method152(
                                            v0_1.get().clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v49,
                                            v50,
                                            v51,
                                            v52,
                                            v53,
                                        );
                                        match &v409 {
                                            Documents::US29::US29_0(
                                                v409_0_0,
                                                v409_0_1,
                                                v409_0_2,
                                                v409_0_3,
                                                v409_0_4,
                                                v409_0_5,
                                            ) => Documents::US20::US20_0(
                                                Func0::new({
                                                    let v409 = v409.clone();
                                                    move || {
                                                        Documents::closure109(
                                                            match &v409 {
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
                                                v409_0_1.clone(),
                                                v409_0_2.clone(),
                                                v409_0_3.clone(),
                                                v409_0_4.clone(),
                                                v409_0_5.clone(),
                                            ),
                                            Documents::US29::US29_1(v409_1_0) => {
                                                Documents::US20::US20_1(v409_1_0.clone())
                                            }
                                        }
                                    }
                                };
                                let v434: Documents::US20 = if let Documents::US20::US20_0(
                                    v423_0_0,
                                    v423_0_1,
                                    v423_0_2,
                                    v423_0_3,
                                    v423_0_4,
                                    v423_0_5,
                                ) = &v423
                                {
                                    if (v423_0_1.clone()) == (v49) {
                                        Documents::US20::US20_1(Func0::new(move || {
                                            Documents::closure110((), ())
                                        }))
                                    } else {
                                        v423.clone()
                                    }
                                } else {
                                    v423.clone()
                                };
                                let v460: Documents::US20 = match &v434 {
                                    Documents::US20::US20_0(
                                        v434_0_0,
                                        v434_0_1,
                                        v434_0_2,
                                        v434_0_3,
                                        v434_0_4,
                                        v434_0_5,
                                    ) => Documents::method153(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH2::UH2_1(
                                            (v434_0_0)(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                        )),
                                        v434_0_1.clone(),
                                        v434_0_2.clone(),
                                        v434_0_3.clone(),
                                        v434_0_4.clone(),
                                        v434_0_5.clone(),
                                    ),
                                    Documents::US20::US20_1(v434_1_0) => {
                                        Documents::US20::US20_1(v434_1_0.clone())
                                    }
                                };
                                match &v460 {
                                    Documents::US20::US20_0(
                                        v460_0_0,
                                        v460_0_1,
                                        v460_0_2,
                                        v460_0_3,
                                        v460_0_4,
                                        v460_0_5,
                                    ) => {
                                        let v0_1_temp: string = v0_1.get().clone();
                                        let v1_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                            Documents::UH2::UH2_1((v460_0_0)(), v1_1.get().clone()),
                                        );
                                        let v2_temp: i32 = v460_0_1.clone();
                                        let v3_temp: i32 = v460_0_2.clone();
                                        let v4_temp: i32 = v460_0_3.clone();
                                        let v5_temp: i32 = v460_0_4.clone();
                                        let v6_temp: i32 = v460_0_5.clone();
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
                                            move || Documents::closure116(v1_1.get().clone(), ())
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
                                move || Documents::closure114(v1_1.get().clone(), ())
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
            let v125: Documents::US20 = match &v7 {
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
                    let v79: Documents::US20 = match &v62 {
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
                    match &v79 {
                        Documents::US20::US20_0(
                            v79_0_0,
                            v79_0_1,
                            v79_0_2,
                            v79_0_3,
                            v79_0_4,
                            v79_0_5,
                        ) => {
                            let v81: i32 = v79_0_1.clone();
                            let v89: Documents::US19 = Documents::method128(
                                v79_0_2.clone(),
                                v79_0_3.clone(),
                                v79_0_4.clone(),
                                v79_0_5.clone(),
                                v81,
                                v0_1.clone(),
                                LrcPtr::new(Documents::UH0::UH0_1(
                                    Func1::from(v2),
                                    LrcPtr::new(Documents::UH0::UH0_1(
                                        Func1::from(v3),
                                        LrcPtr::new(Documents::UH0::UH0_0),
                                    )),
                                )),
                            );
                            match &v89 {
                                Documents::US19::US19_0(
                                    v89_0_0,
                                    v89_0_1,
                                    v89_0_2,
                                    v89_0_3,
                                    v89_0_4,
                                    v89_0_5,
                                ) => Documents::US20::US20_0(
                                    v79_0_0.clone(),
                                    v89_0_1.clone(),
                                    v89_0_2.clone(),
                                    v89_0_3.clone(),
                                    v89_0_4.clone(),
                                    v89_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v89_1_0) => {
                                    Documents::US20::US20_1(Func0::new({
                                        let v0_1 = v0_1.clone();
                                        let v81 = v81.clone();
                                        let v89 = v89.clone();
                                        let v9 = v9.clone();
                                        move || {
                                            Documents::closure59(
                                                v0_1.clone(),
                                                v9,
                                                v81,
                                                match &v89 {
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
                            let v106: Documents::US19 = Documents::method128(
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
                            match &v106 {
                                Documents::US19::US19_0(
                                    v106_0_0,
                                    v106_0_1,
                                    v106_0_2,
                                    v106_0_3,
                                    v106_0_4,
                                    v106_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new(move || Documents::closure58((), ())),
                                    v106_0_1.clone(),
                                    v106_0_2.clone(),
                                    v106_0_3.clone(),
                                    v106_0_4.clone(),
                                    v106_0_5.clone(),
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
            let v299: Documents::US20 = match &v125 {
                Documents::US20::US20_0(
                    v125_0_0,
                    v125_0_1,
                    v125_0_2,
                    v125_0_3,
                    v125_0_4,
                    v125_0_5,
                ) => v125.clone(),
                _ => {
                    let v148: Documents::US19 = if 0_i32 >= (v1_1) {
                        Documents::US19::US19_1(Func0::new({
                            let v1_1 = v1_1.clone();
                            move || Documents::closure95(v1_1, ())
                        }))
                    } else {
                        let v136: char = getCharAt(v0_1.clone(), 0_i32);
                        if (v136) == '\"' {
                            let patternInput_1: (i32, i32, i32, i32) = if '\n' == (v136) {
                                (1_i32, 2_i32, 1_i32, v1_1)
                            } else {
                                (0_i32, 1_i32, 2_i32, v1_1)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v136 = v136.clone();
                                    move || Documents::closure44(v136, ())
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
                                move || Documents::closure96(v0_1.clone(), ())
                            }))
                        }
                    };
                    match &v148 {
                        Documents::US19::US19_0(
                            v148_0_0,
                            v148_0_1,
                            v148_0_2,
                            v148_0_3,
                            v148_0_4,
                            v148_0_5,
                        ) => {
                            let v154: i32 = v148_0_5.clone();
                            let v153: i32 = v148_0_4.clone();
                            let v152: i32 = v148_0_3.clone();
                            let v151: i32 = v148_0_2.clone();
                            let v150: i32 = v148_0_1.clone();
                            let v155: bool = (v150) >= (v154);
                            let v176: Documents::US19 = if v155 {
                                Documents::US19::US19_1(Func0::new({
                                    let v151 = v151.clone();
                                    let v152 = v152.clone();
                                    let v153 = v153.clone();
                                    let v154 = v154.clone();
                                    move || Documents::closure82(v151, v152, v153, v154, ())
                                }))
                            } else {
                                let v158: char = getCharAt(v0_1.clone(), v150);
                                if (Documents::method142(v158, 0_i64)) == false {
                                    let patternInput_2: (i32, i32, i32, i32) = if '\n' == (v158) {
                                        ((v151) + (v153), (v152) + 1_i32, 1_i32, v154)
                                    } else {
                                        (v151, v152, (v153) + 1_i32, v154)
                                    };
                                    Documents::US19::US19_0(
                                        Func0::new({
                                            let v158 = v158.clone();
                                            move || Documents::closure52(v158, ())
                                        }),
                                        (v150) + 1_i32,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                        patternInput_2.3.clone(),
                                    )
                                } else {
                                    Documents::US19::US19_1(Func0::new({
                                        let v151 = v151.clone();
                                        let v152 = v152.clone();
                                        let v153 = v153.clone();
                                        let v154 = v154.clone();
                                        let v158 = v158.clone();
                                        move || {
                                            Documents::closure83(v151, v152, v153, v154, v158, ())
                                        }
                                    }))
                                }
                            };
                            let v188: Documents::US20 = match &v176 {
                                Documents::US19::US19_0(
                                    v176_0_0,
                                    v176_0_1,
                                    v176_0_2,
                                    v176_0_3,
                                    v176_0_4,
                                    v176_0_5,
                                ) => Documents::US20::US20_0(
                                    Func0::new({
                                        let v176 = v176.clone();
                                        move || {
                                            Documents::closure84(
                                                match &v176 {
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
                                    v176_0_1.clone(),
                                    v176_0_2.clone(),
                                    v176_0_3.clone(),
                                    v176_0_4.clone(),
                                    v176_0_5.clone(),
                                ),
                                Documents::US19::US19_1(v176_1_0) => {
                                    Documents::US20::US20_1(v176_1_0.clone())
                                }
                            };
                            let v203: Documents::US20 = match &v188 {
                                Documents::US20::US20_0(
                                    v188_0_0,
                                    v188_0_1,
                                    v188_0_2,
                                    v188_0_3,
                                    v188_0_4,
                                    v188_0_5,
                                ) => v188.clone(),
                                _ => Documents::method144(
                                    v151,
                                    v152,
                                    v153,
                                    v154,
                                    v150,
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
                                                Documents::closure97((), arg10_0040_20)
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
                                                    Documents::closure101((), arg10_0040_21)
                                                },
                                            ),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                ),
                            };
                            let v220: Documents::US20 = match &v203 {
                                Documents::US20::US20_0(
                                    v203_0_0,
                                    v203_0_1,
                                    v203_0_2,
                                    v203_0_3,
                                    v203_0_4,
                                    v203_0_5,
                                ) => {
                                    let v208: i32 = v203_0_1.clone();
                                    if (v208) == (v150) {
                                        Documents::US20::US20_1(Func0::new(move || {
                                            Documents::closure92((), ())
                                        }))
                                    } else {
                                        Documents::method149(
                                            v0_1.clone(),
                                            v203_0_0.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v208,
                                            v203_0_2.clone(),
                                            v203_0_3.clone(),
                                            v203_0_4.clone(),
                                            v203_0_5.clone(),
                                        )
                                    }
                                }
                                _ => Documents::US20::US20_0(
                                    Func0::new(move || Documents::closure91((), ())),
                                    v150,
                                    v151,
                                    v152,
                                    v153,
                                    v154,
                                ),
                            };
                            match &v220 {
                                Documents::US20::US20_0(
                                    v220_0_0,
                                    v220_0_1,
                                    v220_0_2,
                                    v220_0_3,
                                    v220_0_4,
                                    v220_0_5,
                                ) => {
                                    let v226: i32 = v220_0_5.clone();
                                    let v225: i32 = v220_0_4.clone();
                                    let v224: i32 = v220_0_3.clone();
                                    let v223: i32 = v220_0_2.clone();
                                    let v222: i32 = v220_0_1.clone();
                                    let v246: Documents::US19 = if (v222) >= (v226) {
                                        Documents::US19::US19_1(Func0::new({
                                            let v223 = v223.clone();
                                            let v224 = v224.clone();
                                            let v225 = v225.clone();
                                            let v226 = v226.clone();
                                            move || Documents::closure43(v223, v224, v225, v226, ())
                                        }))
                                    } else {
                                        let v230: char = getCharAt(v0_1.clone(), v222);
                                        if (v230) == '\"' {
                                            let patternInput_4: (i32, i32, i32, i32) =
                                                if '\n' == (v230) {
                                                    ((v223) + (v225), (v224) + 1_i32, 1_i32, v226)
                                                } else {
                                                    (v223, v224, (v225) + 1_i32, v226)
                                                };
                                            Documents::US19::US19_0(
                                                Func0::new({
                                                    let v230 = v230.clone();
                                                    move || Documents::closure44(v230, ())
                                                }),
                                                (v222) + 1_i32,
                                                patternInput_4.0.clone(),
                                                patternInput_4.1.clone(),
                                                patternInput_4.2.clone(),
                                                patternInput_4.3.clone(),
                                            )
                                        } else {
                                            Documents::US19::US19_1(Func0::new({
                                                let v0_1 = v0_1.clone();
                                                let v222 = v222.clone();
                                                let v223 = v223.clone();
                                                let v224 = v224.clone();
                                                let v225 = v225.clone();
                                                move || {
                                                    Documents::closure45(
                                                        v225,
                                                        v224,
                                                        v223,
                                                        v222,
                                                        v0_1.clone(),
                                                        (),
                                                    )
                                                }
                                            }))
                                        }
                                    };
                                    match &v246 {
                                        Documents::US19::US19_0(
                                            v246_0_0,
                                            v246_0_1,
                                            v246_0_2,
                                            v246_0_3,
                                            v246_0_4,
                                            v246_0_5,
                                        ) => Documents::US20::US20_0(
                                            v220_0_0.clone(),
                                            v246_0_1.clone(),
                                            v246_0_2.clone(),
                                            v246_0_3.clone(),
                                            v246_0_4.clone(),
                                            v246_0_5.clone(),
                                        ),
                                        Documents::US19::US19_1(v246_1_0) => {
                                            Documents::US20::US20_1(Func0::new({
                                                let v0_1 = v0_1.clone();
                                                let v150 = v150.clone();
                                                let v222 = v222.clone();
                                                let v246 = v246.clone();
                                                move || {
                                                    Documents::closure59(
                                                        v0_1.clone(),
                                                        v150,
                                                        v222,
                                                        match &v246 {
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
                                    let v278: Documents::US19 = if v155 {
                                        Documents::US19::US19_1(Func0::new({
                                            let v151 = v151.clone();
                                            let v152 = v152.clone();
                                            let v153 = v153.clone();
                                            let v154 = v154.clone();
                                            move || Documents::closure43(v151, v152, v153, v154, ())
                                        }))
                                    } else {
                                        let v262: char = getCharAt(v0_1.clone(), v150);
                                        if (v262) == '\"' {
                                            let patternInput_3: (i32, i32, i32, i32) =
                                                if '\n' == (v262) {
                                                    ((v151) + (v153), (v152) + 1_i32, 1_i32, v154)
                                                } else {
                                                    (v151, v152, (v153) + 1_i32, v154)
                                                };
                                            Documents::US19::US19_0(
                                                Func0::new({
                                                    let v262 = v262.clone();
                                                    move || Documents::closure44(v262, ())
                                                }),
                                                (v150) + 1_i32,
                                                patternInput_3.0.clone(),
                                                patternInput_3.1.clone(),
                                                patternInput_3.2.clone(),
                                                patternInput_3.3.clone(),
                                            )
                                        } else {
                                            Documents::US19::US19_1(Func0::new({
                                                let v0_1 = v0_1.clone();
                                                let v150 = v150.clone();
                                                let v151 = v151.clone();
                                                let v152 = v152.clone();
                                                let v153 = v153.clone();
                                                move || {
                                                    Documents::closure45(
                                                        v153,
                                                        v152,
                                                        v151,
                                                        v150,
                                                        v0_1.clone(),
                                                        (),
                                                    )
                                                }
                                            }))
                                        }
                                    };
                                    match &v278 {
                                        Documents::US19::US19_0(
                                            v278_0_0,
                                            v278_0_1,
                                            v278_0_2,
                                            v278_0_3,
                                            v278_0_4,
                                            v278_0_5,
                                        ) => Documents::US20::US20_0(
                                            Func0::new(move || Documents::closure58((), ())),
                                            v278_0_1.clone(),
                                            v278_0_2.clone(),
                                            v278_0_3.clone(),
                                            v278_0_4.clone(),
                                            v278_0_5.clone(),
                                        ),
                                        _ => Documents::US20::US20_1(Func0::new({
                                            let v0_1 = v0_1.clone();
                                            let v150 = v150.clone();
                                            move || Documents::closure57(v0_1.clone(), v150, ())
                                        })),
                                    }
                                }
                            }
                        }
                        Documents::US19::US19_1(v148_1_0) => {
                            Documents::US20::US20_1(v148_1_0.clone())
                        }
                    }
                }
            };
            let v337: Documents::US20 = match &v299 {
                Documents::US20::US20_0(
                    v299_0_0,
                    v299_0_1,
                    v299_0_2,
                    v299_0_3,
                    v299_0_4,
                    v299_0_5,
                ) => v299.clone(),
                _ => {
                    let v324: Documents::US19 = if 0_i32 >= (v1_1) {
                        Documents::US19::US19_1(Func0::new({
                            let v1_1 = v1_1.clone();
                            move || Documents::closure103(v1_1, ())
                        }))
                    } else {
                        let v310: char = getCharAt(v0_1.clone(), 0_i32);
                        if (Documents::method150(v310, 0_i64)) == false {
                            let patternInput_5: (i32, i32, i32, i32) = if '\n' == (v310) {
                                (1_i32, 2_i32, 1_i32, v1_1)
                            } else {
                                (0_i32, 1_i32, 2_i32, v1_1)
                            };
                            Documents::US19::US19_0(
                                Func0::new({
                                    let v310 = v310.clone();
                                    move || Documents::closure52(v310, ())
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
                                let v310 = v310.clone();
                                move || Documents::closure104(v1_1, v310, ())
                            }))
                        }
                    };
                    match &v324 {
                        Documents::US19::US19_0(
                            v324_0_0,
                            v324_0_1,
                            v324_0_2,
                            v324_0_3,
                            v324_0_4,
                            v324_0_5,
                        ) => Documents::method151(
                            v0_1.clone(),
                            v324_0_1.clone(),
                            v324_0_2.clone(),
                            v324_0_3.clone(),
                            v324_0_4.clone(),
                            v324_0_5.clone(),
                        ),
                        Documents::US19::US19_1(v324_1_0) => {
                            Documents::US20::US20_1(v324_1_0.clone())
                        }
                    }
                }
            };
            let v364: Documents::US20 = match &v337 {
                Documents::US20::US20_0(
                    v337_0_0,
                    v337_0_1,
                    v337_0_2,
                    v337_0_3,
                    v337_0_4,
                    v337_0_5,
                ) => v337.clone(),
                _ => {
                    let v350: Documents::US29 = Documents::method152(
                        v0_1.clone(),
                        LrcPtr::new(Documents::UH2::UH2_0),
                        0_i32,
                        0_i32,
                        1_i32,
                        1_i32,
                        v1_1,
                    );
                    match &v350 {
                        Documents::US29::US29_0(
                            v350_0_0,
                            v350_0_1,
                            v350_0_2,
                            v350_0_3,
                            v350_0_4,
                            v350_0_5,
                        ) => Documents::US20::US20_0(
                            Func0::new({
                                let v350 = v350.clone();
                                move || {
                                    Documents::closure109(
                                        match &v350 {
                                            Documents::US29::US29_0(x, _, _, _, _, _) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                        (),
                                    )
                                }
                            }),
                            v350_0_1.clone(),
                            v350_0_2.clone(),
                            v350_0_3.clone(),
                            v350_0_4.clone(),
                            v350_0_5.clone(),
                        ),
                        Documents::US29::US29_1(v350_1_0) => {
                            Documents::US20::US20_1(v350_1_0.clone())
                        }
                    }
                }
            };
            let v375: Documents::US20 = if let Documents::US20::US20_0(
                v364_0_0,
                v364_0_1,
                v364_0_2,
                v364_0_3,
                v364_0_4,
                v364_0_5,
            ) = &v364
            {
                if (v364_0_1.clone()) == 0_i32 {
                    Documents::US20::US20_1(Func0::new(move || Documents::closure110((), ())))
                } else {
                    v364.clone()
                }
            } else {
                v364.clone()
            };
            let v401: Documents::US20 = match &v375 {
                Documents::US20::US20_0(
                    v375_0_0,
                    v375_0_1,
                    v375_0_2,
                    v375_0_3,
                    v375_0_4,
                    v375_0_5,
                ) => Documents::method153(
                    v0_1.clone(),
                    LrcPtr::new(Documents::UH2::UH2_1(
                        (v375_0_0)(),
                        LrcPtr::new(Documents::UH2::UH2_0),
                    )),
                    v375_0_1.clone(),
                    v375_0_2.clone(),
                    v375_0_3.clone(),
                    v375_0_4.clone(),
                    v375_0_5.clone(),
                ),
                Documents::US20::US20_1(v375_1_0) => Documents::US20::US20_1(v375_1_0.clone()),
            };
            let v416: Documents::US29 = match &v401 {
                Documents::US20::US20_0(
                    v401_0_0,
                    v401_0_1,
                    v401_0_2,
                    v401_0_3,
                    v401_0_4,
                    v401_0_5,
                ) => Documents::method155(
                    v0_1.clone(),
                    LrcPtr::new(Documents::UH2::UH2_1(
                        (v401_0_0)(),
                        LrcPtr::new(Documents::UH2::UH2_0),
                    )),
                    v401_0_1.clone(),
                    v401_0_2.clone(),
                    v401_0_3.clone(),
                    v401_0_4.clone(),
                    v401_0_5.clone(),
                ),
                _ => Documents::US29::US29_0(
                    Func0::new(move || Documents::closure113((), ())),
                    0_i32,
                    0_i32,
                    1_i32,
                    1_i32,
                    v1_1,
                ),
            };
            let v428: Documents::US30 = match &v416 {
                Documents::US29::US29_0(
                    v416_0_0,
                    v416_0_1,
                    v416_0_2,
                    v416_0_3,
                    v416_0_4,
                    v416_0_5,
                ) => {
                    let v422: i32 = v416_0_5.clone();
                    let v421: i32 = v416_0_4.clone();
                    let v420: i32 = v416_0_3.clone();
                    let v419: i32 = v416_0_2.clone();
                    Documents::US30::US30_0(
                        v416_0_0.clone(),
                        Func0::new({
                            let v0_1 = v0_1.clone();
                            let v416 = v416.clone();
                            let v419 = v419.clone();
                            let v420 = v420.clone();
                            let v421 = v421.clone();
                            let v422 = v422.clone();
                            move || {
                                Documents::closure74(
                                    v0_1.clone(),
                                    v419,
                                    v420,
                                    v421,
                                    v422,
                                    match &v416 {
                                        Documents::US29::US29_0(_, x, _, _, _, _) => x.clone(),
                                        _ => unreachable!(),
                                    },
                                    (),
                                )
                            }
                        }),
                        v419,
                        v420,
                        v421,
                        v422,
                    )
                }
                Documents::US29::US29_1(v416_1_0) => Documents::US30::US30_1(v416_1_0.clone()),
            };
            let v441: Documents::US31 = match &v428 {
                Documents::US30::US30_0(
                    v428_0_0,
                    v428_0_1,
                    v428_0_2,
                    v428_0_3,
                    v428_0_4,
                    v428_0_5,
                ) => Documents::US31::US31_0(
                    (v428_0_0)(),
                    (v428_0_1)(),
                    v428_0_2.clone(),
                    v428_0_3.clone(),
                    v428_0_4.clone(),
                    v428_0_5.clone(),
                ),
                Documents::US30::US30_1(v428_1_0) => Documents::US31::US31_1(v428_1_0.clone()),
            };
            let v502: Documents::US32 = match &v441 {
                Documents::US31::US31_0(
                    v441_0_0,
                    v441_0_1,
                    v441_0_2,
                    v441_0_3,
                    v441_0_4,
                    v441_0_5,
                ) => Documents::US32::US32_0(toArray_1(Documents::method156(
                    v441_0_0.clone(),
                    empty::<string>(),
                ))),
                Documents::US31::US31_1(v441_1_0) => Documents::US32::US32_1(v441_1_0.clone()),
            };
            match &v502 {
                Documents::US32::US32_0(v502_0_0) => Documents::US28::US28_0(v502_0_0.clone()),
                Documents::US32::US32_1(v502_1_0) => Documents::US28::US28_1((v502_1_0)()),
            }
        }
        pub fn method159(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("file_name"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method160(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("arguments"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method161(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("options"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method162(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("command"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method163(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("cancellation_token"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method164(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("environment_variables"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method165(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("on_line"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method166(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("stdin"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method167(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("trace"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method168(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("working_directory"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method169(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("stderr"));
            v0_1.l0.set(v7);
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
            let v21: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v21.clone());
            Documents::method159(v21.clone());
            Documents::method20(v21.clone());
            Documents::method15(v21.clone(), v0_1);
            Documents::method50(v21.clone());
            Documents::method160(v21.clone());
            Documents::method20(v21.clone());
            Documents::method15(v21.clone(), v1_1);
            Documents::method50(v21.clone());
            Documents::method161(v21.clone());
            Documents::method20(v21.clone());
            Documents::method18(v21.clone());
            Documents::method162(v21.clone());
            Documents::method20(v21.clone());
            Documents::method15(v21.clone(), v2);
            Documents::method50(v21.clone());
            Documents::method163(v21.clone());
            Documents::method20(v21.clone());
            {
                let v2290: std::string::String = format!("{:#?}", v3);
                Documents::method15(v21.clone(), fable_library_rust::String_::fromString(v2290));
                Documents::method50(v21.clone());
                Documents::method164(v21.clone());
                Documents::method20(v21.clone());
                Documents::method15(v21.clone(), sprintf!("{:?}", v4));
                Documents::method50(v21.clone());
                Documents::method165(v21.clone());
                Documents::method20(v21.clone());
                {
                    let v3423: std::string::String = format!("{:#?}", v5);
                    Documents::method15(
                        v21.clone(),
                        fable_library_rust::String_::fromString(v3423),
                    );
                    Documents::method50(v21.clone());
                    Documents::method166(v21.clone());
                    Documents::method20(v21.clone());
                    {
                        let v4045: std::string::String = format!("{:#?}", v6);
                        Documents::method15(
                            v21.clone(),
                            fable_library_rust::String_::fromString(v4045),
                        );
                        Documents::method50(v21.clone());
                        Documents::method167(v21.clone());
                        Documents::method20(v21.clone());
                        Documents::method15(
                            v21.clone(),
                            if v7 { string("true") } else { string("false") },
                        );
                        Documents::method50(v21.clone());
                        Documents::method168(v21.clone());
                        Documents::method20(v21.clone());
                        {
                            let v5166: std::string::String = format!("{:#?}", v8);
                            Documents::method15(
                                v21.clone(),
                                fable_library_rust::String_::fromString(v5166),
                            );
                            Documents::method50(v21.clone());
                            Documents::method169(v21.clone());
                            Documents::method20(v21.clone());
                            Documents::method15(
                                v21.clone(),
                                if v9 { string("true") } else { string("false") },
                            );
                            Documents::method21(v21.clone());
                            Documents::method21(v21.clone());
                            v21.l0.get().clone()
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
        pub fn closure117(
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
            fn v83() {
                Documents::closure10((), ());
            }
            let v84: () = {
                v83();
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
            let v212: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v917: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v212,
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
                let v293: () = {
                    v83();
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
                let v379: Option<i64> = patternInput_1.5.clone();
                let v378: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v377: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v376: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v375: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v374: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v437: string = Documents::method157(
                    v374.clone(),
                    v375.clone(),
                    v376.clone(),
                    v377.clone(),
                    v378.clone(),
                    v379.clone(),
                    Documents::method8(v374, v375, v376, v377, v378, v379),
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
                let v511: () = {
                    v83();
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
                let v593: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v592: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v645: () = {
                    Documents::closure12(v592.clone(), ());
                    ()
                };
                println!("{}", v437.clone());
                (v593.l0.get().clone())(v437);
                Documents::US7::US7_0(
                    v592,
                    v593,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure118(
            unitVar: (),
            v0_1: Option<std::process::Child>,
        ) -> Option<std::process::Child> {
            v0_1
        }
        pub fn method170() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Documents::closure118((), v))
        }
        pub fn closure119(
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
                    Documents::closure119((), v)
                },
            )
        }
        pub fn closure120(unitVar: (), v0_1: std::string::String) -> Documents::US33 {
            Documents::US33::US33_1(v0_1)
        }
        pub fn method172() -> Func1<std::string::String, Documents::US33> {
            Func1::new(move |v: std::string::String| Documents::closure120((), v))
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
            let v22: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v22.clone());
            Documents::method51(v22.clone());
            Documents::method20(v22.clone());
            {
                let v428: std::string::String = format!("{:#?}", v0_1);
                Documents::method15(v22.clone(), fable_library_rust::String_::fromString(v428));
                Documents::method50(v22.clone());
                Documents::method159(v22.clone());
                Documents::method20(v22.clone());
                Documents::method15(v22.clone(), v1_1);
                Documents::method50(v22.clone());
                Documents::method160(v22.clone());
                Documents::method20(v22.clone());
                Documents::method15(v22.clone(), v2);
                Documents::method50(v22.clone());
                Documents::method161(v22.clone());
                Documents::method20(v22.clone());
                Documents::method18(v22.clone());
                Documents::method162(v22.clone());
                Documents::method20(v22.clone());
                Documents::method15(v22.clone(), v3);
                Documents::method50(v22.clone());
                Documents::method163(v22.clone());
                Documents::method20(v22.clone());
                {
                    let v2913: std::string::String = format!("{:#?}", v4);
                    Documents::method15(
                        v22.clone(),
                        fable_library_rust::String_::fromString(v2913),
                    );
                    Documents::method50(v22.clone());
                    Documents::method164(v22.clone());
                    Documents::method20(v22.clone());
                    Documents::method15(v22.clone(), sprintf!("{:?}", v5));
                    Documents::method50(v22.clone());
                    Documents::method165(v22.clone());
                    Documents::method20(v22.clone());
                    {
                        let v4046: std::string::String = format!("{:#?}", v6);
                        Documents::method15(
                            v22.clone(),
                            fable_library_rust::String_::fromString(v4046),
                        );
                        Documents::method50(v22.clone());
                        Documents::method166(v22.clone());
                        Documents::method20(v22.clone());
                        {
                            let v4668: std::string::String = format!("{:#?}", v7);
                            Documents::method15(
                                v22.clone(),
                                fable_library_rust::String_::fromString(v4668),
                            );
                            Documents::method50(v22.clone());
                            Documents::method167(v22.clone());
                            Documents::method20(v22.clone());
                            Documents::method15(
                                v22.clone(),
                                if v8 { string("true") } else { string("false") },
                            );
                            Documents::method50(v22.clone());
                            Documents::method168(v22.clone());
                            Documents::method20(v22.clone());
                            {
                                let v5789: std::string::String = format!("{:#?}", v9);
                                Documents::method15(
                                    v22.clone(),
                                    fable_library_rust::String_::fromString(v5789),
                                );
                                Documents::method50(v22.clone());
                                Documents::method169(v22.clone());
                                Documents::method20(v22.clone());
                                Documents::method15(
                                    v22.clone(),
                                    if v10 { string("true") } else { string("false") },
                                );
                                Documents::method21(v22.clone());
                                Documents::method21(v22.clone());
                                v22.l0.get().clone()
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
        pub fn closure121(
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
            fn v84() {
                Documents::closure10((), ());
            }
            let v85: () = {
                v84();
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
            let v213: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v918: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v213,
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
                let v294: () = {
                    v84();
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
                let v380: Option<i64> = patternInput_1.5.clone();
                let v379: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v378: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v377: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v376: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v375: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v438: string = Documents::method173(
                    v375.clone(),
                    v376.clone(),
                    v377.clone(),
                    v378.clone(),
                    v379.clone(),
                    v380.clone(),
                    Documents::method8(v375, v376, v377, v378, v379, v380),
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
                let v512: () = {
                    v84();
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
                let v594: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v593: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v646: () = {
                    Documents::closure12(v593.clone(), ());
                    ()
                };
                println!("{}", v438.clone());
                (v594.l0.get().clone())(v438);
                Documents::US7::US7_0(
                    v593,
                    v594,
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
        pub fn closure122(
            unitVar: (),
            v0_1: Option<std::process::ChildStdin>,
        ) -> Option<std::process::ChildStdin> {
            v0_1
        }
        pub fn method176()
        -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Documents::closure122((), v))
        }
        pub fn closure123(
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
                Documents::closure123((), v)
            })
        }
        pub fn method178() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure123((), v)
            })
        }
        pub fn closure124(
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
                    Documents::closure124((), v)
                },
            )
        }
        pub fn closure125(unitVar: (), v0_1: std::string::String) -> Documents::US35 {
            Documents::US35::US35_0(v0_1)
        }
        pub fn method180() -> Func1<std::string::String, Documents::US35> {
            Func1::new(move |v: std::string::String| Documents::closure125((), v))
        }
        pub fn closure126(unitVar: (), v0_1: std::string::String) -> Documents::US35 {
            Documents::US35::US35_1(v0_1)
        }
        pub fn method181() -> Func1<std::string::String, Documents::US35> {
            Func1::new(move |v: std::string::String| Documents::closure126((), v))
        }
        pub fn method184(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("trace\'"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method183(v0_1: bool, v1_1: std::string::String) -> string {
            let v13: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v13.clone());
            Documents::method184(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(
                v13.clone(),
                if v0_1 {
                    string("true")
                } else {
                    string("false")
                },
            );
            Documents::method50(v13.clone());
            Documents::method132(v13.clone());
            Documents::method20(v13.clone());
            {
                let v918: std::string::String = format!("{:#?}", v1_1);
                Documents::method15(v13.clone(), fable_library_rust::String_::fromString(v918));
                Documents::method21(v13.clone());
                v13.l0.get().clone()
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
        pub fn closure127(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            fn v75() {
                Documents::closure10((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v895: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v204,
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
                let v285: () = {
                    v75();
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
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v369: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v368: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v367: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v366: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v415: string = Documents::method182(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Documents::method8(v366, v367, v368, v369, v370, v371),
                    Documents::method96(),
                    v0_1,
                    v1_1,
                );
                let v489: () = {
                    v75();
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
                let v571: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v570: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v623: () = {
                    Documents::closure12(v570.clone(), ());
                    ()
                };
                println!("{}", v415.clone());
                (v571.l0.get().clone())(v415);
                Documents::US7::US7_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method185() -> string {
            let v4: &str = inline_colorization::color_bright_black;
            let v47: std::string::String = String::from(v4);
            let v553: string = append(
                (fable_library_rust::String_::fromString(v47)),
                (Documents::method13(getCharAt(toLower(string("Verbose")), 0_i32))),
            );
            let v569: &str = inline_colorization::color_reset;
            let v612: std::string::String = String::from(v569);
            append((v553), (fable_library_rust::String_::fromString(v612)))
        }
        pub fn method187() -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            v11.l0.get().clone()
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
        pub fn closure128(v0_1: string, unitVar: ()) {
            fn v74() {
                Documents::closure10((), ());
            }
            let v75: () = {
                v74();
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
            let v203: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v897: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                0_i32
                    >= (find(
                        v203,
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
                let v284: () = {
                    v74();
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
                let v370: Option<i64> = patternInput_1.5.clone();
                let v369: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v368: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v367: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v366: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v365: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v417: string = if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method186(
                        v365.clone(),
                        v366.clone(),
                        v367.clone(),
                        v368.clone(),
                        v369.clone(),
                        v370.clone(),
                        Documents::method8(v365, v366, v367, v368, v369, v370),
                        Documents::method185(),
                        v0_1,
                    )
                };
                let v491: () = {
                    v74();
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
                let v573: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v572: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v625: () = {
                    Documents::closure12(v572.clone(), ());
                    ()
                };
                println!("{}", v417.clone());
                (v573.l0.get().clone())(v417);
                Documents::US7::US7_0(
                    v572,
                    v573,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure129(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method188()
        -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure129((), v)
            })
        }
        pub fn method189(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure130(
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
                    Documents::closure130((), v)
                },
            )
        }
        pub fn method191(
            v0_1: std::sync::MutexGuard<Option<std::process::ChildStdin>>,
        ) -> std::sync::MutexGuard<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn closure131(
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
                    Documents::closure131((), v)
                },
            )
        }
        pub fn method193(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure132(unitVar: (), v0_1: std::process::Output) -> Documents::US38 {
            Documents::US38::US38_0(v0_1)
        }
        pub fn method194() -> Func1<std::process::Output, Documents::US38> {
            Func1::new(move |v: std::process::Output| Documents::closure132((), v))
        }
        pub fn closure133(unitVar: (), v0_1: std::string::String) -> Documents::US38 {
            Documents::US38::US38_1(v0_1)
        }
        pub fn method195() -> Func1<std::string::String, Documents::US38> {
            Func1::new(move |v: std::string::String| Documents::closure133((), v))
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
        pub fn closure134(
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
            fn v84() {
                Documents::closure10((), ());
            }
            let v85: () = {
                v84();
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
            let v213: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v918: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v213,
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
                let v294: () = {
                    v84();
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
                let v380: Option<i64> = patternInput_1.5.clone();
                let v379: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v378: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v377: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v376: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v375: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v438: string = Documents::method196(
                    v375.clone(),
                    v376.clone(),
                    v377.clone(),
                    v378.clone(),
                    v379.clone(),
                    v380.clone(),
                    Documents::method8(v375, v376, v377, v378, v379, v380),
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
                let v512: () = {
                    v84();
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
                let v594: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v593: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v646: () = {
                    Documents::closure12(v593.clone(), ());
                    ()
                };
                println!("{}", v438.clone());
                (v594.l0.get().clone())(v438);
                Documents::US7::US7_0(
                    v593,
                    v594,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure135(unitVar: (), v0_1: i32) -> Documents::US39 {
            Documents::US39::US39_0(v0_1)
        }
        pub fn method197() -> Func1<i32, Documents::US39> {
            Func1::new(move |v: i32| Documents::closure135((), v))
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
            let v7: string = append((v0_1.l0.get().clone()), string("exit_code"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method205(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("std_trace_length"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method203(v0_1: string, v1_1: i32, v2: i32) -> string {
            let v14: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v14.clone());
            Documents::method159(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), v0_1);
            Documents::method50(v14.clone());
            Documents::method204(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v1_1));
            Documents::method50(v14.clone());
            Documents::method205(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v2));
            Documents::method21(v14.clone());
            v14.l0.get().clone()
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
        pub fn closure136(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            fn v76() {
                Documents::closure10((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v897: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                0_i32
                    >= (find(
                        v205,
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
                let v286: () = {
                    v76();
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
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v370: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v369: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v368: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v367: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v417: string = Documents::method202(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Documents::method8(v367, v368, v369, v370, v371, v372),
                    Documents::method185(),
                    v0_1,
                    v1_1,
                    length(v2),
                );
                let v491: () = {
                    v76();
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
                let v573: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v572: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v625: () = {
                    Documents::closure12(v572.clone(), ());
                    ()
                };
                println!("{}", v417.clone());
                (v573.l0.get().clone())(v417);
                Documents::US7::US7_0(
                    v572,
                    v573,
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
            let v38: Documents::US5 = patternInput.1.clone();
            let v37: string = patternInput.0.clone();
            let v43: Documents::US28 = Documents::method141(match &v38 {
                Documents::US5::US5_0(v38_0_0) => match &v38 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            });
            let v68: Array<string> = match &v43 {
                Documents::US28::US28_0(v43_0_0) => v43_0_0.clone(),
                Documents::US28::US28_1(v43_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Error x: "),
                        v43_1_0.clone()
                    ])),
                ),
            };
            let v70: Vec<string> = v68.to_vec();
            let v72: bool = true;
            let _vec_map: Vec<_> = v70
                .into_iter()
                .map(|x| {
                    //;
                    let v74: string = x;
                    let v117: &str = &*v74;
                    let v285: std::string::String = String::from(v117);
                    let v412: bool = true;
                    v285
                })
                .collect::<Vec<_>>();
            let v414: Vec<std::string::String> = _vec_map;
            let v2298: () = {
                Documents::closure117(
                    v0_1.clone(),
                    v1_1.clone(),
                    v2.clone(),
                    v3.clone(),
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v7,
                    v37.clone(),
                    v414.clone(),
                    (),
                );
                ()
            };
            let _capture_v3287: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_5: LrcPtr<(i32, string)> = (Func0::new({
                    let v0_1 = v0_1.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v3 = v3.clone();
                    let v37 = v37.clone();
                    let v4 = v4.clone();
                    let v414 = v414.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    let v7 = v7.clone();
                    move || {
                        let v3289: std::process::Command =
                            std::process::Command::new(&*v37.clone());
                        let v3291: bool = true;
                        let mut v3289 = v3289;
                        let v3293: bool = true;
                        std::process::Command::args(&mut v3289, &*v414.clone());
                        let v3295: std::process::Command = v3289;
                        let v3297: std::process::Stdio = std::process::Stdio::piped();
                        let v3299: bool = true;
                        let mut v3295 = v3295;
                        let v3301: bool = true;
                        std::process::Command::stdout(&mut v3295, std::process::Stdio::piped());
                        let v3303: std::process::Command = v3295;
                        let v3305: std::process::Stdio = std::process::Stdio::piped();
                        let v3307: bool = true;
                        let mut v3303 = v3303;
                        let v3309: bool = true;
                        std::process::Command::stderr(&mut v3303, std::process::Stdio::piped());
                        let v3311: std::process::Command = v3303;
                        let v3313: std::process::Stdio = std::process::Stdio::piped();
                        let v3315: bool = true;
                        let mut v3311 = v3311;
                        let v3317: bool = true;
                        std::process::Command::stdin(&mut v3311, std::process::Stdio::piped());
                        let v3319: std::process::Command = v3311;
                        let v3429: Documents::US5 = defaultValue(
                            Documents::US5::US5_1,
                            map(Documents::method6(), v6.clone()),
                        );
                        let v3454: std::process::Command = match &v3429 {
                            Documents::US5::US5_0(v3429_0_0) => {
                                let v3444: bool = true;
                                let mut v3319 = v3319;
                                let v3446: bool = true;
                                std::process::Command::current_dir(
                                    &mut v3319,
                                    &*match &v3429 {
                                        Documents::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                );
                                v3319
                            }
                            _ => {
                                let v3450: std::process::Command = v3319;
                                v3450
                            }
                        };
                        let v3476: std::process::Command =
                            if (get_Count(v2.clone()) as u64) == 0_u64 {
                                v3454
                            } else {
                                let v3458: Vec<(string, string)> = v2.clone().to_vec();
                                let v3460: bool = true;
                                let _vec_fold_ = v3458.into_iter().fold(v3454, |acc, x| {
                                    //;
                                    let v3462: std::process::Command = acc;
                                    let patternInput_1: (string, string) = x;
                                    let v3467: bool = true;
                                    let mut v3462 = v3462;
                                    let v3469: bool = true;
                                    std::process::Command::env(
                                        &mut v3462,
                                        &*patternInput_1.0.clone(),
                                        &*patternInput_1.1.clone(),
                                    );
                                    let v3471: std::process::Command = v3462;
                                    let v3473: bool = true;
                                    v3471
                                });
                                _vec_fold_
                            };
                        let v3478: bool = true;
                        let mut v3476 = v3476;
                        let v3480: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(&mut v3476);
                        let v3481 = Documents::method89();
                        let v3486: Result<std::process::Child, std::string::String> =
                            v3480.map_err(|x| v3481(x));
                        let v3498 = Documents::method170();
                        let v3500: bool = true;
                        let _result_map_ = v3486.map(|x| {
                            //;
                            let v3523: Option<std::process::Child> = v3498(Some(x));
                            let v3525: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v3523);
                            let v3527: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v3525);
                            let v3529: bool = true;
                            v3527
                        });
                        let v3531: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v3532 = Documents::method171();
                        let v3533 = Documents::method172();
                        let v3535: Documents::US33 = match v3531 {
                            Ok(x) => v3532(x),
                            Err(e) => v3533(e),
                        };
                        let patternInput_4: (i32, Documents::US9, Documents::US34) = match &v3535 {
                            Documents::US33::US33_0(v3535_0_0) => {
                                let v3536: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v3535_0_0.clone();
                                let v3538: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v3540: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v3536.clone();
                                    let v3542: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v3540.lock();
                                    let v3559: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method175(v3542.unwrap());
                                    let v3561: bool = true;
                                    let mut v3559 = v3559;
                                    let v3563: &mut Option<std::process::Child> = &mut v3559;
                                    let v3565: Option<&mut std::process::Child> = v3563.as_mut();
                                    let v3567: &mut std::process::Child = v3565.unwrap();
                                    let v3569: &mut Option<std::process::ChildStdout> =
                                        &mut v3567.stdout;
                                    let v3571: Option<std::process::ChildStdout> =
                                        Option::take(v3569);
                                    let v3573: std::process::ChildStdout = v3571.unwrap();
                                    let v3575: bool = true;
                                    v3573
                                })();
                                let v3577: std::process::ChildStdout = _capture;
                                let v3579: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v3581: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v3536.clone();
                                    let v3583: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v3581.lock();
                                    let v3600: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method175(v3583.unwrap());
                                    let v3602: bool = true;
                                    let mut v3600 = v3600;
                                    let v3604: &mut Option<std::process::Child> = &mut v3600;
                                    let v3606: Option<&mut std::process::Child> = v3604.as_mut();
                                    let v3608: &mut std::process::Child = v3606.unwrap();
                                    let v3610: &mut Option<std::process::ChildStderr> =
                                        &mut v3608.stderr;
                                    let v3612: Option<std::process::ChildStderr> =
                                        Option::take(v3610);
                                    let v3614: std::process::ChildStderr = v3612.unwrap();
                                    let v3616: bool = true;
                                    v3614
                                })();
                                let v3618: std::process::ChildStderr = _capture;
                                let v3620: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v3622: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v3536.clone();
                                    let v3624: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v3622.lock();
                                    let v3641: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method175(v3624.unwrap());
                                    let v3643: bool = true;
                                    let mut v3641 = v3641;
                                    let v3645: &mut Option<std::process::Child> = &mut v3641;
                                    let v3647: Option<&mut std::process::Child> = v3645.as_mut();
                                    let v3649: &mut std::process::Child = v3647.unwrap();
                                    let v3651: &mut Option<std::process::ChildStdin> =
                                        &mut v3649.stdin;
                                    let v3653: Option<std::process::ChildStdin> =
                                        Option::take(v3651);
                                    let v3655: std::process::ChildStdin = v3653.unwrap();
                                    let v3677: Option<std::process::ChildStdin> =
                                        (Documents::method176())(Some(v3655));
                                    let v3679: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(v3677);
                                    let v3681: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v3679);
                                    let v3683: bool = true;
                                    v3681
                                })();
                                let v3685: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v3687: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v3690: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method177())(v3687.clone());
                                let v3692: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v3690);
                                let v3694: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v3692);
                                let v3696: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method178())(v3687);
                                let v3698: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v3696);
                                let v3700: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v3698);
                                let v3702: std::sync::Arc<
                                    std::sync::mpsc::Receiver<std::string::String>,
                                > = (Documents::method179())(patternInput_2.1.clone());
                                let v3704: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(v3702);
                                let v3706: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v3704);
                                let v3708: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v3710: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v3577);
                                    let v3712: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v3710);
                                    let v3714: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v3712);
                                    let v3716: bool = true;
                                    let mut v3714 = v3714;
                                    let _iter_try_for_each = v3714.try_for_each(|x| {
                                        //;
                                        let v3718: Result<std::string::String, std::io::Error> = x;
                                        let v3720: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v3694.clone();
                                        let v3721 = Documents::method89();
                                        let v3726: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v3718.map_err(|x| v3721(x));
                                        let v3738 = Documents::method180();
                                        let v3739 = Documents::method181();
                                        let v3741: Documents::US35 = match v3726 {
                                            Ok(x) => v3738(x),
                                            Err(e) => v3739(e),
                                        };
                                        let v9966: std::string::String = match &v3741 {
                                            Documents::US35::US35_0(v3741_0_0) => {
                                                let v3744: string =
                                                    fable_library_rust::String_::fromString(
                                                        v3741_0_0.clone(),
                                                    );
                                                let v3746: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v3748: std::borrow::Cow<[u8]> =
                                                    v3746.encode(&*v3744).0;
                                                let v3750: &[u8] = v3748.as_ref();
                                                let v3752: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v3750);
                                                let v3757: &str = v3752.unwrap();
                                                let v3896: std::string::String =
                                                    String::from(v3757);
                                                let v3939: string = concat(new_array(&[
                                                    string("> "),
                                                    fable_library_rust::String_::fromString(
                                                        v3896.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v5801: () = {
                                                        Documents::closure128(v3939.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v6798: () = {
                                                        Documents::closure14(v3939, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v3896
                                            }
                                            Documents::US35::US35_1(v3741_1_0) => {
                                                let v6810: std::string::String = v3741_1_0.clone();
                                                let v8666: () = {
                                                    Documents::closure127(v5, v6810.clone(), ());
                                                    ()
                                                };
                                                let v9628: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v6810);
                                                let v9671: &str = &*v9628;
                                                String::from(v9671)
                                            }
                                        };
                                        let v9968: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v3720;
                                        let v9970: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v9968.lock();
                                        let v9975: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v9970.unwrap();
                                        let v9988: &std::sync::mpsc::Sender<std::string::String> =
                                            &v9975;
                                        let v9990: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v9988.send(v9966);
                                        let v9991 = Documents::method188();
                                        let v9996: Result<(), std::string::String> =
                                            v9990.map_err(|x| v9991(x));
                                        let v10009: _ = v9996;
                                        let v10011: bool = true;
                                        v10009
                                    }); //;
                                    let v10014: Result<(), string> = Documents::method189(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v10017: string = string("}");
                                    let v10022: bool = true;
                                    let _fix_closure_v10019 = v10014;
                                    let v10028: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v10019 "),
                                                    (v10017),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v10029: bool = true;
                                    _fix_closure_v10019
                                }); // rust.fix_closure';
                                let v10031: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v10033: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v10035: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v3618);
                                    let v10037: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v10035);
                                    let v10039: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v10037);
                                    let v10041: bool = true;
                                    let mut v10039 = v10039;
                                    let _iter_try_for_each = v10039.try_for_each(|x| {
                                        //;
                                        let v10043: Result<std::string::String, std::io::Error> = x;
                                        let v16676: Result<(), std::string::String> = if (v7)
                                            == false
                                        {
                                            Ok::<(), std::string::String>(())
                                        } else {
                                            let v10066: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v3700.clone();
                                            let v10067 = Documents::method89();
                                            let v10072: Result<
                                                std::string::String,
                                                std::string::String,
                                            > = v10043.map_err(|x| v10067(x));
                                            let v10084 = Documents::method180();
                                            let v10085 = Documents::method181();
                                            let v10087: Documents::US35 = match v10072 {
                                                Ok(x) => v10084(x),
                                                Err(e) => v10085(e),
                                            };
                                            let v16634: std::string::String = match &v10087 {
                                                Documents::US35::US35_0(v10087_0_0) => {
                                                    let v10090: string =
                                                        fable_library_rust::String_::fromString(
                                                            v10087_0_0.clone(),
                                                        );
                                                    let v10092: &encoding_rs::Encoding =
                                                        encoding_rs::UTF_8;
                                                    let v10094: std::borrow::Cow<[u8]> =
                                                        v10092.encode(&*v10090).0;
                                                    let v10096: &[u8] = v10094.as_ref();
                                                    let v10098: Result<&str, std::str::Utf8Error> =
                                                        std::str::from_utf8(v10096);
                                                    let v10103: &str = v10098.unwrap();
                                                    let v10242: std::string::String =
                                                        String::from(v10103);
                                                    let v10285: string = concat(new_array(&[
                                                        string("! "),
                                                        fable_library_rust::String_::fromString(
                                                            v10242.clone(),
                                                        ),
                                                    ]));
                                                    if v5 {
                                                        let v12141: () = {
                                                            Documents::closure128(
                                                                v10285.clone(),
                                                                (),
                                                            );
                                                            ()
                                                        };
                                                        ()
                                                    } else {
                                                        let v13135: () = {
                                                            Documents::closure14(v10285, ());
                                                            ()
                                                        };
                                                        ()
                                                    }
                                                    {
                                                        let v13147: string = sprintf!(
                                                            "\u{001b}[4;7m{}\u{001b}[0m",
                                                            v10242
                                                        );
                                                        let v13190: &str = &*v13147;
                                                        String::from(v13190)
                                                    }
                                                }
                                                Documents::US35::US35_1(v10087_1_0) => {
                                                    let v13484: std::string::String =
                                                        v10087_1_0.clone();
                                                    let v15336: () = {
                                                        Documents::closure127(
                                                            v5,
                                                            v13484.clone(),
                                                            (),
                                                        );
                                                        ()
                                                    };
                                                    let v16296: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v13484
                                                    );
                                                    let v16339: &str = &*v16296;
                                                    String::from(v16339)
                                                }
                                            };
                                            let v16636: std::sync::Arc<
                                                std::sync::Mutex<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            > = v10066;
                                            let v16638: Result<
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
                                            > = v16636.lock();
                                            let v16643: std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            > = v16638.unwrap();
                                            let v16656: &std::sync::mpsc::Sender<
                                                std::string::String,
                                            > = &v16643;
                                            let v16658: Result<
                                                (),
                                                std::sync::mpsc::SendError<std::string::String>,
                                            > = v16656.send(v16634);
                                            let v16659 = Documents::method188();
                                            v16658.map_err(|x| v16659(x))
                                        };
                                        let v16678: _ = v16676;
                                        let v16680: bool = true;
                                        v16678
                                    }); //;
                                    let v16683: Result<(), string> = Documents::method189(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v16684: string = string("}");
                                    let v16689: bool = true;
                                    let _fix_closure_v16686 = v16683;
                                    let v16695: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v16686 "),
                                                    (v16684),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v16696: bool = true;
                                    _fix_closure_v16686
                                }); // rust.fix_closure';
                                let v16698: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v16808: Documents::US36 = defaultValue(
                                    Documents::US36::US36_1,
                                    map(Documents::method190(), v4.clone()),
                                );
                                match &v16808 {
                                    Documents::US36::US36_0(v16808_0_0) => {
                                        let v16823: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v3685.clone();
                                        let v16825: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v16823.lock();
                                        let v16842: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = Documents::method191(v16825.unwrap());
                                        let v16844: bool = true;
                                        let mut v16842 = v16842;
                                        let v16846: &mut Option<std::process::ChildStdin> =
                                            &mut v16842;
                                        let v16848: Option<std::process::ChildStdin> =
                                            Option::take(v16846);
                                        let v16850: bool = true;
                                        let _optionm_map_ = v16848.map(|x| {
                                            //;
                                            let v16852: std::process::ChildStdin = x;
                                            let v16854: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v16852);
                                            let v16856: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v16854);
                                            let v16858: bool = true;
                                            v16856
                                        });
                                        let v16860: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let v16970: Documents::US37 = defaultValue(
                                            Documents::US37::US37_1,
                                            map(Documents::method192(), v16860),
                                        );
                                        match &v16970 {
                                            Documents::US37::US37_0(v16970_0_0) => {
                                                let v16983: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v16970 {
                                                    Documents::US37::US37_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone();
                                                (match &v16808 {
                                                    Documents::US36::US36_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v16983.clone()
                                                );
                                                {
                                                    let v16985: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v16983;
                                                    let v16987: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v16985.lock();
                                                    let v17004: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method193(v16987.unwrap());
                                                    let v17006: bool = true;
                                                    let mut v17004 = v17004;
                                                    let v17008: bool = true;
                                                    std::io::Write::flush(&mut *v17004).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v17010: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v3536;
                                    let v17012: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v17010.lock();
                                    let v17029: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method175(v17012.unwrap());
                                    let v17031: bool = true;
                                    let mut v17029 = v17029;
                                    let v17033: &mut Option<std::process::Child> = &mut v17029;
                                    let v17035: Option<std::process::Child> = Option::take(v17033);
                                    let v17037: std::process::Child = v17035.unwrap();
                                    let v17039: Result<std::process::Output, std::io::Error> =
                                        v17037.wait_with_output();
                                    let v17040 = Documents::method89();
                                    let v17054: Result<std::process::Output, std::string::String> =
                                        v17039.map_err(|x| v17040(x));
                                    let v17064: string = string("vec![v10031, v16698]");
                                    let v17065: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v10031, v16698];
                                    let v17067: bool = true;
                                    v17065.into_iter().for_each(|x| {
                                        //;
                                        let v17069: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v17071: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v17069);
                                        let v17076: Result<(), string> = v17071.unwrap();
                                        v17076.unwrap();
                                        {
                                            let v17093: bool = true;
                                            let v17095: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v17096 = Documents::method194();
                                        let v17097 = Documents::method195();
                                        let v17106: Documents::US38 = match &v17054 {
                                            Err(v17054_1_0) => v17097(v17054_1_0.clone()),
                                            Ok(v17054_0_0) => v17096(v17054_0_0.clone()),
                                        };
                                        match &v17106 {
                                            Documents::US38::US38_0(v17106_0_0) => {
                                                let v17126: std::process::Output =
                                                    v17106_0_0.clone();
                                                let v17128: std::process::ExitStatus =
                                                    v17126.clone().status;
                                                let v17130: Option<i32> = v17128.code();
                                                let v17240: Documents::US39 = defaultValue(
                                                    Documents::US39::US39_1,
                                                    map(Documents::method197(), v17130),
                                                );
                                                match &v17240 {
                                                    Documents::US39::US39_0(v17240_0_0) => {
                                                        let v17256: Vec<u8> = Documents::method198(
                                                            v17126.clone().stdout,
                                                        );
                                                        let v17258: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v17256);
                                                        let v17263: std::string::String =
                                                            v17258.unwrap();
                                                        let v17277: Vec<u8> = Documents::method198(
                                                            v17126.clone().stderr,
                                                        );
                                                        let v17279: Result<
                                                            std::string::String,
                                                            std::string::FromUtf8Error,
                                                        > = std::string::String::from_utf8(v17277);
                                                        let v17284: std::string::String =
                                                            v17279.unwrap();
                                                        let v17297: string =
                                                            fable_library_rust::String_::fromString(
                                                                v17284,
                                                            );
                                                        let v17298: i32 = length(v17297.clone());
                                                        let v18012: string = getSlice(
                                                            v17297.clone(),
                                                            Some(Documents::method23(
                                                                v17297, v17298, 0_i32,
                                                            )),
                                                            Some(v17298),
                                                        );
                                                        let v18738: string = getSlice(
                                                            v18012.clone(),
                                                            Some(0_i32),
                                                            Some(Documents::method199(
                                                                v18012.clone(),
                                                                length(v18012),
                                                            )),
                                                        );
                                                        let v18752: string =
                                                            fable_library_rust::String_::fromString(
                                                                v17263,
                                                            );
                                                        let v18753: i32 = length(v18752.clone());
                                                        let v19467: string = getSlice(
                                                            v18752.clone(),
                                                            Some(Documents::method23(
                                                                v18752, v18753, 0_i32,
                                                            )),
                                                            Some(v18753),
                                                        );
                                                        let v20193: string = getSlice(
                                                            v19467.clone(),
                                                            Some(0_i32),
                                                            Some(Documents::method199(
                                                                v19467.clone(),
                                                                length(v19467),
                                                            )),
                                                        );
                                                        let v20212: LrcPtr<Documents::UH2> =
                                                            if ((length(v18738.clone())) == 0_i32)
                                                                == false
                                                            {
                                                                LrcPtr::new(Documents::UH2::UH2_1(
                                                                    v18738,
                                                                    LrcPtr::new(
                                                                        Documents::UH2::UH2_0,
                                                                    ),
                                                                ))
                                                            } else {
                                                                LrcPtr::new(Documents::UH2::UH2_0)
                                                            };
                                                        let patternInput_3: (string, string) =
                                                            Documents::method200(
                                                                if ((length(v20193.clone()))
                                                                    == 0_i32)
                                                                    == false
                                                                {
                                                                    LrcPtr::new(
                                                                        Documents::UH2::UH2_1(
                                                                            v20193,
                                                                            v20212.clone(),
                                                                        ),
                                                                    )
                                                                } else {
                                                                    v20212
                                                                },
                                                                string(""),
                                                            );
                                                        let v20262: &str =
                                                            &*patternInput_3.0.clone();
                                                        (
                                                            match &v17240 {
                                                                Documents::US39::US39_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            },
                                                            Documents::US9::US9_0(String::from(
                                                                v20262,
                                                            )),
                                                            Documents::US34::US34_0(v3706.clone()),
                                                        )
                                                    }
                                                    _ => {
                                                        let v20601: &str = &*string(
                                                            "runtime.execute_with_options / exit_code=None",
                                                        );
                                                        (
                                                            -1_i32,
                                                            Documents::US9::US9_0(String::from(
                                                                v20601,
                                                            )),
                                                            Documents::US34::US34_0(v3706.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US38::US38_1(v17106_1_0) => {
                                                let v20903: std::string::String =
                                                    v17106_1_0.clone();
                                                let v22783: () = {
                                                    Documents::closure134(
                                                        v0_1.clone(),
                                                        v1_1.clone(),
                                                        v2.clone(),
                                                        v3.clone(),
                                                        v4.clone(),
                                                        v5,
                                                        v6.clone(),
                                                        v7,
                                                        v37.clone(),
                                                        v414.clone(),
                                                        v20903.clone(),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US9::US9_0(v20903),
                                                    Documents::US34::US34_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US33::US33_1(v3535_1_0) => {
                                let v23765: std::string::String = v3535_1_0.clone();
                                let v25649: () = {
                                    Documents::closure121(
                                        v0_1.clone(),
                                        v1_1.clone(),
                                        v2.clone(),
                                        v3.clone(),
                                        v4.clone(),
                                        v5,
                                        v6.clone(),
                                        v7,
                                        v37.clone(),
                                        v414.clone(),
                                        v23765.clone(),
                                        (),
                                    );
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US9::US9_0(v23765),
                                    Documents::US34::US34_1,
                                )
                            }
                        };
                        let v26632: Documents::US34 = patternInput_4.2.clone();
                        let v26631: Documents::US9 = patternInput_4.1.clone();
                        let v26630: i32 = patternInput_4.0.clone();
                        let v26675: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v26632 {
                            Documents::US34::US34_0(v26632_0_0) => Some(
                                match &v26632 {
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
                        let v26677: bool = true;
                        let _optionm_map_ = v26675.map(|x| {
                            //;
                            let v26679: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v26681: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v26679;
                            let v26683: Result<
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
                            > = v26681.lock();
                            let v26688: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v26683.unwrap();
                            let v26701 = v26688.iter();
                            let v26703: Vec<std::string::String> = v26701.collect::<Vec<_>>();
                            let v26705: bool = true;
                            let _vec_map: Vec<_> = v26703
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v26707: std::string::String = x;
                                    let v26709: string =
                                        fable_library_rust::String_::fromString(v26707);
                                    let v26711: bool = true;
                                    v26709
                                })
                                .collect::<Vec<_>>();
                            let v26713: Vec<string> = _vec_map;
                            let v26724: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(
                                fable_library_rust::NativeArray_::array_from(v26713.clone()),
                            );
                            let v26743: string = join(Documents::method201(), toArray(v26724));
                            let v26757: bool = true;
                            v26743
                        });
                        let v26759: Option<string> = _optionm_map_;
                        let v26869: Documents::US5 =
                            defaultValue(Documents::US5::US5_1, map(Documents::method6(), v26759));
                        let v28346: Documents::US40 = match &v26869 {
                            Documents::US5::US5_0(v26869_0_0) => {
                                let v26882: string = match &v26869 {
                                    Documents::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                                let v26883: i32 = length(v26882.clone());
                                let v27598: string = getSlice(
                                    v26882.clone(),
                                    Some(Documents::method23(v26882, v26883, 0_i32)),
                                    Some(v26883),
                                );
                                let v28325: string = getSlice(
                                    v27598.clone(),
                                    Some(0_i32),
                                    Some(Documents::method199(v27598.clone(), length(v27598))),
                                );
                                Documents::US40::US40_0(if (length(v28325.clone())) == 0_i32 {
                                    Documents::US5::US5_1
                                } else {
                                    Documents::US5::US5_0(v28325)
                                })
                            }
                            _ => Documents::US40::US40_1,
                        };
                        let v28353: Documents::US5 =
                            if let Documents::US40::US40_0(v28346_0_0) = &v28346 {
                                let v28347: Documents::US5 = v28346_0_0.clone();
                                if let Documents::US5::US5_0(v28347_0_0) = &v28347 {
                                    Documents::US5::US5_0(v28347_0_0.clone())
                                } else {
                                    Documents::US5::US5_1
                                }
                            } else {
                                Documents::US5::US5_1
                            };
                        let v28360: Documents::US5 = match &v26631 {
                            Documents::US9::US9_0(v26631_0_0) => {
                                Documents::US5::US5_0(fable_library_rust::String_::fromString(
                                    match &v26631 {
                                        Documents::US9::US9_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ))
                            }
                            _ => Documents::US5::US5_1,
                        };
                        let v28364: string = match &v28360 {
                            Documents::US5::US5_0(v28360_0_0) => match &v28360 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => string(""),
                        };
                        let v28367: string = match &v28353 {
                            Documents::US5::US5_0(v28353_0_0) => match &v28353 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            _ => v28364.clone(),
                        };
                        let v30225: () = {
                            Documents::closure136(v37.clone(), v26630, v28367.clone(), ());
                            ()
                        };
                        LrcPtr::new((v26630, v28367))
                    }
                }))();
                _capture_v3287.set(Some(x_5))
            }
            {
                let v31208: LrcPtr<(i32, string)> = match &_capture_v3287.get().clone() {
                    None => panic!("{}", string("base.capture / _capture_v3287=None"),),
                    Some(_capture_v3287_0_0) => _capture_v3287_0_0.clone(),
                };
                (v31208.0.clone(), v31208.1.clone())
            }
        }
        pub fn method206(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method39(v2, Documents::method61(v1_1.clone()));
            let v720: string = getSlice(
                v1_1.clone(),
                Some(0_i32),
                Some((lastIndexOf(v1_1.clone(), string("."))) - 1_i32),
            );
            let v1447: string = getSlice(
                v4.clone(),
                Some(0_i32),
                Some((lastIndexOf(v4.clone(), string("."))) - 1_i32),
            );
            let v1477: bool = (endsWith3(v0_1.clone(), string(".md"), false)) == false;
            (
                if v1477 {
                    concat(new_array(&[v1_1, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v720, string("."), v0_1.clone()]))
                },
                if v1477 {
                    concat(new_array(&[v4, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v1447, string("."), v0_1]))
                },
            )
        }
        pub fn closure137(unitVar: (), unitVar_1: ()) -> usize {
            0_i32 as usize
        }
        pub fn closure138(unitVar: (), v0_1: usize) -> Documents::US42 {
            Documents::US42::US42_0(v0_1)
        }
        pub fn closure139(unitVar: (), v0_1: LrcPtr<Exception>) -> Documents::US42 {
            Documents::US42::US42_1(v0_1)
        }
        pub fn method207() -> Documents::US42 {
            try_catch(
                || Documents::closure138((), Documents::closure137((), ())),
                |ex: LrcPtr<Exception>| {
                    Documents::closure139(
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
        pub fn closure140(v0_1: usize, unitVar: ()) -> usize {
            v0_1
        }
        pub fn method208(v0_1: usize) -> Documents::US42 {
            try_catch(
                || Documents::closure138((), Documents::closure140(v0_1, ())),
                |ex: LrcPtr<Exception>| {
                    Documents::closure139(
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
        pub fn closure142(v0_1: string, v1_1: LrcPtr<Documents::UH2>) -> LrcPtr<Documents::UH2> {
            LrcPtr::new(Documents::UH2::UH2_1(v0_1, v1_1))
        }
        pub fn closure141(
            unitVar: (),
            v0_1: string,
        ) -> Func1<LrcPtr<Documents::UH2>, LrcPtr<Documents::UH2>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH2>| Documents::closure142(v0_1.clone(), v)
            })
        }
        pub fn method209() -> Func1<string, Func1<LrcPtr<Documents::UH2>, LrcPtr<Documents::UH2>>> {
            Func1::new(move |v: string| Documents::closure141((), v))
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
        pub fn closure143(unitVar: (), v0_1: string) -> Documents::US44 {
            Documents::US44::US44_0(v0_1)
        }
        pub fn method212() -> Func1<string, Documents::US44> {
            Func1::new(move |v: string| Documents::closure143((), v))
        }
        pub fn closure144(unitVar: (), v0_1: std::string::String) -> Documents::US44 {
            Documents::US44::US44_1(v0_1)
        }
        pub fn method213() -> Func1<std::string::String, Documents::US44> {
            Func1::new(move |v: std::string::String| Documents::closure144((), v))
        }
        pub fn method216(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("file"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method217(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("real_path"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method218(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("relative_path"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method219(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("origin_hash_exit_code"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method220(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("origin_hash"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method221(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("local_git_hash_exit_code"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method222(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("local_git_hash"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method223(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("hash1"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method224(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("hash2"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method225(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("dist_path"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method226(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("cache_path"));
            v0_1.l0.set(v7);
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
            let v22: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v22.clone());
            Documents::method216(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), v0_1);
            Documents::method50(v22.clone());
            Documents::method217(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), v1_1);
            Documents::method50(v22.clone());
            Documents::method218(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), v2);
            Documents::method50(v22.clone());
            Documents::method219(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), sprintf!("{}", v3));
            Documents::method50(v22.clone());
            Documents::method220(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), v4);
            Documents::method50(v22.clone());
            Documents::method221(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), sprintf!("{}", v5));
            Documents::method50(v22.clone());
            Documents::method222(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), v6);
            Documents::method50(v22.clone());
            Documents::method223(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), v7);
            Documents::method50(v22.clone());
            Documents::method224(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), sprintf!("{:?}", v8));
            Documents::method50(v22.clone());
            Documents::method225(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), v9);
            Documents::method50(v22.clone());
            Documents::method226(v22.clone());
            Documents::method20(v22.clone());
            Documents::method15(v22.clone(), v10);
            Documents::method21(v22.clone());
            v22.l0.get().clone()
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
        pub fn closure145(
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
            fn v84() {
                Documents::closure10((), ());
            }
            let v85: () = {
                v84();
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
            let v213: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v912: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v213,
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
                let v294: () = {
                    v84();
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
                let v380: Option<i64> = patternInput_1.5.clone();
                let v379: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v378: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v377: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v376: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v375: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v428: string = string(
                    "documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / Some hash2 when hash1 = hash2",
                );
                let v432: string = if (v428.clone()) == string("") {
                    string("")
                } else {
                    Documents::method214(
                        v375.clone(),
                        v376.clone(),
                        v377.clone(),
                        v378.clone(),
                        v379.clone(),
                        v380.clone(),
                        Documents::method8(v375, v376, v377, v378, v379, v380),
                        Documents::method12(),
                        v428,
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
                let v506: () = {
                    v84();
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
                let v588: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v587: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v640: () = {
                    Documents::closure12(v587.clone(), ());
                    ()
                };
                println!("{}", v432.clone());
                (v588.l0.get().clone())(v432);
                Documents::US7::US7_0(
                    v587,
                    v588,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure146(unitVar: (), v0_1: u64) -> Documents::US45 {
            Documents::US45::US45_0(v0_1)
        }
        pub fn method228() -> Func1<u64, Documents::US45> {
            Func1::new(move |v: u64| Documents::closure146((), v))
        }
        pub fn closure147(unitVar: (), v0_1: std::string::String) -> Documents::US45 {
            Documents::US45::US45_1(v0_1)
        }
        pub fn method229() -> Func1<std::string::String, Documents::US45> {
            Func1::new(move |v: std::string::String| Documents::closure147((), v))
        }
        pub fn method232(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("old_path"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method233(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("new_path"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method231(v0_1: string, v1_1: string, v2: std::string::String) -> string {
            let v14: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v14.clone());
            Documents::method232(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), v0_1);
            Documents::method50(v14.clone());
            Documents::method233(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), v1_1);
            Documents::method50(v14.clone());
            Documents::method51(v14.clone());
            Documents::method20(v14.clone());
            {
                let v1412: std::string::String = format!("{:#?}", v2);
                Documents::method15(v14.clone(), fable_library_rust::String_::fromString(v1412));
                Documents::method21(v14.clone());
                v14.l0.get().clone()
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
        pub fn closure148(v0_1: string, v1_1: string, v2: std::string::String, unitVar: ()) {
            fn v76() {
                Documents::closure10((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v896: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v205,
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
                let v286: () = {
                    v76();
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
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v370: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v369: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v368: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v367: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v416: string = Documents::method230(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Documents::method8(v367, v368, v369, v370, v371, v372),
                    Documents::method46(),
                    v1_1,
                    v0_1,
                    v2,
                );
                let v490: () = {
                    v76();
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
                let v572: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v571: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v624: () = {
                    Documents::closure12(v571.clone(), ());
                    ()
                };
                println!("{}", v416.clone());
                (v572.l0.get().clone())(v416);
                Documents::US7::US7_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method236(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("result"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method235(v0_1: string, v1_1: string, v2: u64) -> string {
            let v14: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v14.clone());
            Documents::method232(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), v0_1);
            Documents::method50(v14.clone());
            Documents::method233(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), v1_1);
            Documents::method50(v14.clone());
            Documents::method236(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v2));
            Documents::method21(v14.clone());
            v14.l0.get().clone()
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
        pub fn closure149(v0_1: string, v1_1: string, v2: u64, unitVar: ()) {
            fn v76() {
                Documents::closure10((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v896: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v205,
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
                let v286: () = {
                    v76();
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
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v370: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v369: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v368: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v367: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v416: string = Documents::method234(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Documents::method8(v367, v368, v369, v370, v371, v372),
                    Documents::method80(),
                    v1_1,
                    v0_1,
                    v2,
                );
                let v490: () = {
                    v76();
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
                let v572: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v571: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v624: () = {
                    Documents::closure12(v571.clone(), ());
                    ()
                };
                println!("{}", v416.clone());
                (v572.l0.get().clone())(v416);
                Documents::US7::US7_0(
                    v571,
                    v572,
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
            let v19: Result<u64, std::string::String> = v4.map_err(|x| v5(x));
            let v22 = Documents::method228();
            let v23 = Documents::method229();
            let v32: Documents::US45 = match &v19 {
                Err(v19_1_0) => v23(v19_1_0.clone()),
                Ok(v19_0_0) => v22(v19_0_0.clone()),
            };
            match &v32 {
                Documents::US45::US45_0(v32_0_0) => {
                    let v1908: () = {
                        Documents::closure149(v0_1.clone(), v1_1.clone(), v32_0_0.clone(), ());
                        ()
                    };
                    ()
                }
                Documents::US45::US45_1(v32_1_0) => {
                    let v4726: () = {
                        Documents::closure148(v0_1.clone(), v1_1.clone(), v32_1_0.clone(), ());
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
        pub fn closure152(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v10: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v22: string = Documents::method239(v0_1);
            let v24: &[u8] = v22.as_bytes();
            let v25: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method240(v10);
            let v27: bool = true;
            let mut v25 = v25;
            let v29: bool = true;
            std::io::Write::write_all(&mut *v25, v24).unwrap();
            ()
        }
        pub fn method241(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method244(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("result_len"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method245(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("output_path"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method243(v0_1: i32, v1_1: i32, v2: string) -> string {
            let v14: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v14.clone());
            Documents::method204(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v0_1));
            Documents::method50(v14.clone());
            Documents::method244(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v1_1));
            Documents::method50(v14.clone());
            Documents::method245(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), v2);
            Documents::method21(v14.clone());
            v14.l0.get().clone()
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
        pub fn closure153(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            fn v76() {
                Documents::closure10((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v897: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v205,
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
                let v286: () = {
                    v76();
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
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v370: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v369: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v368: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v367: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v417: string = Documents::method242(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Documents::method8(v367, v368, v369, v370, v371, v372),
                    Documents::method12(),
                    v1_1,
                    length(v2),
                    v0_1,
                );
                let v491: () = {
                    v76();
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
                let v573: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v572: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v625: () = {
                    Documents::closure12(v572.clone(), ());
                    ()
                };
                println!("{}", v417.clone());
                (v573.l0.get().clone())(v417);
                Documents::US7::US7_0(
                    v572,
                    v573,
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
            let v88: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v4);
            let v249: Vec<u8> = Documents::method198(v88.unwrap());
            let v251: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v249);
            let v256: std::string::String = v251.unwrap();
            let v470: Array<string> = split(
                fable_library_rust::String_::fromString(v256),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v482: i32 = get_Count(v470.clone());
            let v483: Array<string> = new_init(&string(""), v482);
            let v484: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method27(v482, v484.clone()) {
                let v486: i32 = v484.l0.get().clone();
                let v487: string = v470[v486].clone();
                let v488: i32 = length(v487.clone());
                let v1203: string = getSlice(
                    v487.clone(),
                    Some(Documents::method23(v487, v488, 0_i32)),
                    Some(v488),
                );
                let v1930: string = getSlice(
                    v1203.clone(),
                    Some(0_i32),
                    Some(Documents::method199(v1203.clone(), length(v1203))),
                );
                v483.get_mut()[v486 as usize] = v1930;
                {
                    let v1943: i32 = (v486) + 1_i32;
                    v484.l0.set(v1943);
                    ()
                }
            }
            {
                let v1944: i32 = get_Count(v483.clone());
                let v1945: Array<string> = new_init(&string(""), v1944);
                let v1946: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method238(v1944, v1946.clone()) {
                    let v1948: i32 = v1946.l0.get().clone();
                    let v1949: i32 = v1946.l1.get().clone();
                    let v1950: string = v483[v1948].clone();
                    let v1974: i32 = if (v1950.clone()) != string("") {
                        v1945.get_mut()[v1949 as usize] = v1950;
                        (v1949) + 1_i32
                    } else {
                        v1949
                    };
                    let v1975: i32 = (v1948) + 1_i32;
                    v1946.l0.set(v1975);
                    v1946.l1.set(v1974);
                    ()
                }
                {
                    let v1976: i32 = v1946.l1.get().clone();
                    let v1977: Array<string> = new_init(&string(""), v1976);
                    let v1978: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method27(v1976, v1978.clone()) {
                        let v1980: i32 = v1978.l0.get().clone();
                        let v1981: string = v1945[v1980].clone();
                        v1977.get_mut()[v1980 as usize] = v1981;
                        {
                            let v1982: i32 = (v1980) + 1_i32;
                            v1978.l0.set(v1982);
                            ()
                        }
                    }
                    {
                        let _let__v2002: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v1977 = v1977.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v1977 = v1977.clone();
                                        move |i: i32| v1977[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, (get_Count(v1977.clone())) - 1_i32),
                                )
                            }
                        }));
                        let v2160: string = concat(new_array(&[
                            join(Documents::method201(), toArray(_let__v2002)),
                            string("\n\n"),
                        ]));
                        let v2197: string = if if contains(v2160.clone(), string(" the ")) {
                            contains(v2160.clone(), string(" and "))
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
                                v2197,
                            ])),
                            None::<CancellationToken>,
                            new_empty::<(string, string)>(),
                            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                            Some(Func1::new({
                                let v2160 = v2160.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure152(v2160.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                            true,
                        );
                        let v2359: i32 = patternInput.0.clone();
                        let v2417: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v2429: i32 = get_Count(v2417.clone());
                        let v2431: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method241(v1944, v2431.clone()) {
                            let v2433: i32 = v2431.l0.get().clone();
                            let matchValue: string = v2431.l1.get().clone();
                            let matchValue_1: i32 = v2431.l2.get().clone();
                            let v2436: i32 = v2431.l3.get().clone();
                            let v2435: i32 = matchValue_1;
                            let v2434: string = matchValue;
                            let v2437: string = v483[v2433].clone();
                            let patternInput_2: (string, i32, i32) =
                                if (v2437.clone()) == string("") {
                                    (
                                        append((v2434.clone()), string("\n")),
                                        (v2435) + 1_i32,
                                        (v2436) + 1_i32,
                                    )
                                } else {
                                    let v2455: i32 = (v2435) - (v2436);
                                    (
                                        if (v2455) >= (v2429) {
                                            v2434.clone()
                                        } else {
                                            let v2465: string = v2417[v2455].clone();
                                            let v2497: string = append(
                                                (v2434),
                                                (if contains(v2465.clone(), string("://")) {
                                                    v2437.clone()
                                                } else {
                                                    v2465
                                                }),
                                            );
                                            let v2537: string = if v2 {
                                                v2497.clone()
                                            } else {
                                                append((append((v2497), string("\n"))), (v2437))
                                            };
                                            if (v2455) == ((v2429) - 1_i32) {
                                                v2537.clone()
                                            } else {
                                                append((v2537), string("\n"))
                                            }
                                        },
                                        (v2435) + 1_i32,
                                        v2436,
                                    )
                                };
                            let v2560: i32 = (v2433) + 1_i32;
                            v2431.l0.set(v2560);
                            v2431.l1.set(patternInput_2.0.clone());
                            v2431.l2.set(patternInput_2.1.clone());
                            v2431.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v2431.l1.get().clone();
                            let matchValue_4: i32 = v2431.l2.get().clone();
                            let matchValue_5: i32 = v2431.l3.get().clone();
                            let v2561: string = matchValue_3;
                            std::fs::write(&*v3.clone(), &*v2561.clone()).unwrap();
                            {
                                let v4413: () = {
                                    Documents::closure153(v3, v2359, v2561.clone(), ());
                                    ()
                                };
                                Documents::US46::US46_0(v2359, v2561)
                            }
                        }
                    }
                }
            }
        }
        pub fn method247(v0_1: i32, v1_1: string) -> string {
            let v13: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v13.clone());
            Documents::method204(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(v13.clone(), sprintf!("{}", v0_1));
            Documents::method50(v13.clone());
            Documents::method236(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(v13.clone(), v1_1);
            Documents::method21(v13.clone());
            v13.l0.get().clone()
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
        pub fn closure154(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v75() {
                Documents::closure10((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v895: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v204,
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
                let v285: () = {
                    v75();
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
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v369: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v368: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v367: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v366: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v415: string = Documents::method246(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Documents::method8(v366, v367, v368, v369, v370, v371),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                );
                let v489: () = {
                    v75();
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
                let v571: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v570: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v623: () = {
                    Documents::closure12(v570.clone(), ());
                    ()
                };
                println!("{}", v415.clone());
                (v571.l0.get().clone())(v415);
                Documents::US7::US7_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure151(
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
                let v21: std::fs::File = v16.unwrap();
                let v34: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v21);
                let v36: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v34);
                let v38: bool = true;
                let mut v36 = v36;
                let v40: bool = true;
                let result: sha2::Sha256 = sha2::Digest::new();
                let v42: sha2::Sha256 = result;
                let v44: bool = true;
                let mut v42 = v42;
                let v66: Documents::US42 = Documents::method207();
                let v87: Documents::US43 = match &v66 {
                    Documents::US42::US42_0(v66_0_0) => Documents::US43::US43_0(v66_0_0.clone()),
                    _ => Documents::US43::US43_1,
                };
                let v136: usize = match &v87 {
                    Documents::US43::US43_0(v87_0_0) => match &v87 {
                        Documents::US43::US43_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v138: _ = [0_u8; 1024];
                let v140: bool = true;
                loop {
                    // rust.loop 1;
                    let v142: bool = true;
                    let mut v138 = v138;
                    let v144: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v36, &mut v138);
                    let v158: usize = v144.unwrap();
                    let v183: bool = if (v158) == (v136) {
                        let v182: bool = true;
                        break ();
                        true
                    } else {
                        false
                    };
                    let v205: Documents::US42 = Documents::method208(v158);
                    let v226: Documents::US43 = match &v205 {
                        Documents::US42::US42_0(v205_0_0) => {
                            Documents::US43::US43_0(v205_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v275: usize = match &v226 {
                        Documents::US43::US43_0(v226_0_0) => match &v226 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v320: &_ = if (v275) == (v138.len()) {
                        &v138[v136..]
                    } else {
                        &v138[v136..v275]
                    };
                    let v322: bool = true;
                    sha2::Digest::update(&mut v42, v320);
                    let v324: bool = true;
                } // rust.loop 3;
                let v326: &[u8] = &sha2::Digest::finalize(v42);
                let v328: Vec<u8> = v326.iter().map(|x| *x).collect::<Vec<_>>();
                let v330: bool = true;
                let _vec_map: Vec<_> = v328
                    .into_iter()
                    .map(|x| {
                        //;
                        let v332: u8 = x;
                        let v334: std::string::String = format!("{:02x}", v332);
                        let v336: string = fable_library_rust::String_::fromString(v334);
                        let v338: bool = true;
                        v336
                    })
                    .collect::<Vec<_>>();
                let v340: Vec<string> = _vec_map;
                let v351: List<string> =
                    ofArray(fable_library_rust::NativeArray_::array_from(v340.clone()));
                let v380: LrcPtr<Documents::UH2> = foldBack(
                    Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                        (Documents::method209())(b0)(b1)
                    }),
                    v351,
                    LrcPtr::new(Documents::UH2::UH2_0),
                );
                let patternInput_1: (string, string) =
                    Documents::method211(Documents::method210(), v380, string(""));
                let v490 = Documents::method89();
                let v495: Result<string, std::string::String> =
                    Ok::<string, std::io::Error>(patternInput_1.0.clone()).map_err(|x| v490(x));
                let v507 = Documents::method212();
                let v508 = Documents::method213();
                let v510: Documents::US44 = match v495 {
                    Ok(x) => v507(x),
                    Err(e) => v508(e),
                };
                let v535: string = match &v510 {
                    Documents::US44::US44_0(v510_0_0) => v510_0_0.clone(),
                    Documents::US44::US44_1(v510_1_0) => panic!(
                        "{}",
                        sprintf!("resultm.get / Error x: {}", v510_1_0.clone()),
                    ),
                };
                let v536: string = Documents::method52(v8.clone());
                let v538: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v536);
                let v543: std::fs::File = v538.unwrap();
                let v556: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v543);
                let v558: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v556);
                let v560: bool = true;
                let mut v558 = v558;
                let v562: bool = true;
                let result: sha2::Sha256 = sha2::Digest::new();
                let v564: sha2::Sha256 = result;
                let v566: bool = true;
                let mut v564 = v564;
                let v588: Documents::US42 = Documents::method207();
                let v609: Documents::US43 = match &v588 {
                    Documents::US42::US42_0(v588_0_0) => Documents::US43::US43_0(v588_0_0.clone()),
                    _ => Documents::US43::US43_1,
                };
                let v658: usize = match &v609 {
                    Documents::US43::US43_0(v609_0_0) => match &v609 {
                        Documents::US43::US43_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v660: _ = [0_u8; 1024];
                let v662: bool = true;
                loop {
                    // rust.loop 1;
                    let v664: bool = true;
                    let mut v660 = v660;
                    let v666: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v558, &mut v660);
                    let v680: usize = v666.unwrap();
                    let v705: bool = if (v680) == (v658) {
                        let v704: bool = true;
                        break ();
                        true
                    } else {
                        false
                    };
                    let v727: Documents::US42 = Documents::method208(v680);
                    let v748: Documents::US43 = match &v727 {
                        Documents::US42::US42_0(v727_0_0) => {
                            Documents::US43::US43_0(v727_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v797: usize = match &v748 {
                        Documents::US43::US43_0(v748_0_0) => match &v748 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v842: &_ = if (v797) == (v660.len()) {
                        &v660[v658..]
                    } else {
                        &v660[v658..v797]
                    };
                    let v844: bool = true;
                    sha2::Digest::update(&mut v564, v842);
                    let v846: bool = true;
                } // rust.loop 3;
                let v848: &[u8] = &sha2::Digest::finalize(v564);
                let v850: Vec<u8> = v848.iter().map(|x| *x).collect::<Vec<_>>();
                let v852: bool = true;
                let _vec_map: Vec<_> = v850
                    .into_iter()
                    .map(|x| {
                        //;
                        let v854: u8 = x;
                        let v856: std::string::String = format!("{:02x}", v854);
                        let v858: string = fable_library_rust::String_::fromString(v856);
                        let v860: bool = true;
                        v858
                    })
                    .collect::<Vec<_>>();
                let v862: Vec<string> = _vec_map;
                let v873: List<string> =
                    ofArray(fable_library_rust::NativeArray_::array_from(v862.clone()));
                let v902: LrcPtr<Documents::UH2> = foldBack(
                    Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                        (Documents::method209())(b0)(b1)
                    }),
                    v873,
                    LrcPtr::new(Documents::UH2::UH2_0),
                );
                let patternInput_2: (string, string) =
                    Documents::method211(Documents::method210(), v902, string(""));
                let v1011 = Documents::method89();
                let v1016: Result<string, std::string::String> =
                    Ok::<string, std::io::Error>(patternInput_2.0.clone()).map_err(|x| v1011(x));
                let v1028 = Documents::method212();
                let v1029 = Documents::method213();
                let v1031: Documents::US44 = match v1016 {
                    Ok(x) => v1028(x),
                    Err(e) => v1029(e),
                };
                (v535)
                    == (match &v1031 {
                        Documents::US44::US44_0(v1031_0_0) => v1031_0_0.clone(),
                        Documents::US44::US44_1(v1031_1_0) => panic!(
                            "{}",
                            sprintf!("resultm.get / Error x: {}", v1031_1_0.clone()),
                        ),
                    })
            } {
                Documents::US41::US41_1
            } else {
                let v1060: Documents::US46 = Documents::method237(v2, v3, v4, v7.clone(), v5);
                match &v1060 {
                    Documents::US46::US46_0(v1060_0_0, v1060_0_1) => {
                        let v1062: string = v1060_0_1.clone();
                        let v1061: i32 = v1060_0_0.clone();
                        if (v1061) != 0_i32 {
                            let v2938: () = {
                                Documents::closure154(v1062.clone(), v1061, ());
                                ()
                            };
                            Documents::US41::US41_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v7.clone(), v1062)),
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
                    Documents::US46::US46_1(v1060_1_0, v1060_1_1) => {
                        Documents::US41::US41_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v7.clone(), v1060_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure150(
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
                    Documents::closure151(
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
            let v14: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v14.clone());
            Documents::method204(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), sprintf!("{}", v0_1));
            Documents::method50(v14.clone());
            Documents::method245(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), v1_1);
            Documents::method50(v14.clone());
            Documents::method236(v14.clone());
            Documents::method20(v14.clone());
            Documents::method15(v14.clone(), v2);
            Documents::method21(v14.clone());
            v14.l0.get().clone()
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
                        string("documents.crowbook / attempt error"),
                    )),
                    string(" / "),
                )),
                (v11),
            ))
        }
        pub fn closure157(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            fn v76() {
                Documents::closure10((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v896: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v205,
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
                let v286: () = {
                    v76();
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
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v370: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v369: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v368: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v367: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v416: string = Documents::method249(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Documents::method8(v367, v368, v369, v370, v371, v372),
                    Documents::method46(),
                    v2,
                    v0_1,
                    v1_1,
                );
                let v490: () = {
                    v76();
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
                let v572: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v571: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v624: () = {
                    Documents::closure12(v571.clone(), ());
                    ()
                };
                println!("{}", v416.clone());
                (v572.l0.get().clone())(v416);
                Documents::US7::US7_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
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
        pub fn closure158(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            fn v76() {
                Documents::closure10((), ());
            }
            let v77: () = {
                v76();
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
            let v205: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v896: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v205,
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
                let v286: () = {
                    v76();
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
                let v372: Option<i64> = patternInput_1.5.clone();
                let v371: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v370: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v369: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v368: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v367: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v416: string = Documents::method251(
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    v372.clone(),
                    Documents::method8(v367, v368, v369, v370, v371, v372),
                    Documents::method46(),
                    v2,
                    v0_1,
                    v1_1,
                );
                let v490: () = {
                    v76();
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
                let v572: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v571: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v624: () = {
                    Documents::closure12(v571.clone(), ());
                    ()
                };
                println!("{}", v416.clone());
                (v572.l0.get().clone())(v416);
                Documents::US7::US7_0(
                    v571,
                    v572,
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
                    (concat(new_array(&[string("crowbook --verbose --to "), v4.clone()]))),
                    sprintf!(
                        " --single \"{}\" --output \"{}\" {}",
                        v2.clone(),
                        v1_1.clone(),
                        v61
                    ),
                ),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3.clone()),
                true,
            );
            let v169: string = patternInput.1.clone();
            let v168: i32 = patternInput.0.clone();
            let patternInput_1: (i32, string) = if (v168) == 0_i32 {
                (v168, v169.clone())
            } else {
                let v2026: () = {
                    Documents::closure157(v1_1.clone(), v169, v168, ());
                    ()
                };
                Documents::method104(
                    append(
                        (concat(new_array(&[string("crowbook --verbose --to "), v4]))),
                        sprintf!(" --single \"{}\" --output \"{}\"", v2, v1_1.clone()),
                    ),
                    None::<CancellationToken>,
                    new_empty::<(string, string)>(),
                    None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                    None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                    true,
                    Some(v3),
                    true,
                )
            };
            let v3097: string = patternInput_1.1.clone();
            let v3096: i32 = patternInput_1.0.clone();
            if (contains(v3097.clone(), string("ERROR"))) == false {
                Documents::US46::US46_0(v3096, v3097.clone())
            } else {
                let v4972: () = {
                    Documents::closure158(v1_1, v3097.clone(), v3096, ());
                    ()
                };
                Documents::US46::US46_1(v3096, v3097)
            }
        }
        pub fn closure156(
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
                let v19: std::fs::File = v14.unwrap();
                let v32: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v19);
                let v34: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v32);
                let v36: bool = true;
                let mut v34 = v34;
                let v38: bool = true;
                let result: sha2::Sha256 = sha2::Digest::new();
                let v40: sha2::Sha256 = result;
                let v42: bool = true;
                let mut v40 = v40;
                let v64: Documents::US42 = Documents::method207();
                let v85: Documents::US43 = match &v64 {
                    Documents::US42::US42_0(v64_0_0) => Documents::US43::US43_0(v64_0_0.clone()),
                    _ => Documents::US43::US43_1,
                };
                let v134: usize = match &v85 {
                    Documents::US43::US43_0(v85_0_0) => match &v85 {
                        Documents::US43::US43_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v136: _ = [0_u8; 1024];
                let v138: bool = true;
                loop {
                    // rust.loop 1;
                    let v140: bool = true;
                    let mut v136 = v136;
                    let v142: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v34, &mut v136);
                    let v156: usize = v142.unwrap();
                    let v181: bool = if (v156) == (v134) {
                        let v180: bool = true;
                        break ();
                        true
                    } else {
                        false
                    };
                    let v203: Documents::US42 = Documents::method208(v156);
                    let v224: Documents::US43 = match &v203 {
                        Documents::US42::US42_0(v203_0_0) => {
                            Documents::US43::US43_0(v203_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v273: usize = match &v224 {
                        Documents::US43::US43_0(v224_0_0) => match &v224 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v318: &_ = if (v273) == (v136.len()) {
                        &v136[v134..]
                    } else {
                        &v136[v134..v273]
                    };
                    let v320: bool = true;
                    sha2::Digest::update(&mut v40, v318);
                    let v322: bool = true;
                } // rust.loop 3;
                let v324: &[u8] = &sha2::Digest::finalize(v40);
                let v326: Vec<u8> = v324.iter().map(|x| *x).collect::<Vec<_>>();
                let v328: bool = true;
                let _vec_map: Vec<_> = v326
                    .into_iter()
                    .map(|x| {
                        //;
                        let v330: u8 = x;
                        let v332: std::string::String = format!("{:02x}", v330);
                        let v334: string = fable_library_rust::String_::fromString(v332);
                        let v336: bool = true;
                        v334
                    })
                    .collect::<Vec<_>>();
                let v338: Vec<string> = _vec_map;
                let v349: List<string> =
                    ofArray(fable_library_rust::NativeArray_::array_from(v338.clone()));
                let v378: LrcPtr<Documents::UH2> = foldBack(
                    Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                        (Documents::method209())(b0)(b1)
                    }),
                    v349,
                    LrcPtr::new(Documents::UH2::UH2_0),
                );
                let patternInput_1: (string, string) =
                    Documents::method211(Documents::method210(), v378, string(""));
                let v488 = Documents::method89();
                let v493: Result<string, std::string::String> =
                    Ok::<string, std::io::Error>(patternInput_1.0.clone()).map_err(|x| v488(x));
                let v505 = Documents::method212();
                let v506 = Documents::method213();
                let v508: Documents::US44 = match v493 {
                    Ok(x) => v505(x),
                    Err(e) => v506(e),
                };
                let v533: string = match &v508 {
                    Documents::US44::US44_0(v508_0_0) => v508_0_0.clone(),
                    Documents::US44::US44_1(v508_1_0) => panic!(
                        "{}",
                        sprintf!("resultm.get / Error x: {}", v508_1_0.clone()),
                    ),
                };
                let v534: string = Documents::method52(v6.clone());
                let v536: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v534);
                let v541: std::fs::File = v536.unwrap();
                let v554: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v541);
                let v556: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v554);
                let v558: bool = true;
                let mut v556 = v556;
                let v560: bool = true;
                let result: sha2::Sha256 = sha2::Digest::new();
                let v562: sha2::Sha256 = result;
                let v564: bool = true;
                let mut v562 = v562;
                let v586: Documents::US42 = Documents::method207();
                let v607: Documents::US43 = match &v586 {
                    Documents::US42::US42_0(v586_0_0) => Documents::US43::US43_0(v586_0_0.clone()),
                    _ => Documents::US43::US43_1,
                };
                let v656: usize = match &v607 {
                    Documents::US43::US43_0(v607_0_0) => match &v607 {
                        Documents::US43::US43_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v658: _ = [0_u8; 1024];
                let v660: bool = true;
                loop {
                    // rust.loop 1;
                    let v662: bool = true;
                    let mut v658 = v658;
                    let v664: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v556, &mut v658);
                    let v678: usize = v664.unwrap();
                    let v703: bool = if (v678) == (v656) {
                        let v702: bool = true;
                        break ();
                        true
                    } else {
                        false
                    };
                    let v725: Documents::US42 = Documents::method208(v678);
                    let v746: Documents::US43 = match &v725 {
                        Documents::US42::US42_0(v725_0_0) => {
                            Documents::US43::US43_0(v725_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v795: usize = match &v746 {
                        Documents::US43::US43_0(v746_0_0) => match &v746 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v840: &_ = if (v795) == (v658.len()) {
                        &v658[v656..]
                    } else {
                        &v658[v656..v795]
                    };
                    let v842: bool = true;
                    sha2::Digest::update(&mut v562, v840);
                    let v844: bool = true;
                } // rust.loop 3;
                let v846: &[u8] = &sha2::Digest::finalize(v562);
                let v848: Vec<u8> = v846.iter().map(|x| *x).collect::<Vec<_>>();
                let v850: bool = true;
                let _vec_map: Vec<_> = v848
                    .into_iter()
                    .map(|x| {
                        //;
                        let v852: u8 = x;
                        let v854: std::string::String = format!("{:02x}", v852);
                        let v856: string = fable_library_rust::String_::fromString(v854);
                        let v858: bool = true;
                        v856
                    })
                    .collect::<Vec<_>>();
                let v860: Vec<string> = _vec_map;
                let v871: List<string> =
                    ofArray(fable_library_rust::NativeArray_::array_from(v860.clone()));
                let v900: LrcPtr<Documents::UH2> = foldBack(
                    Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                        (Documents::method209())(b0)(b1)
                    }),
                    v871,
                    LrcPtr::new(Documents::UH2::UH2_0),
                );
                let patternInput_2: (string, string) =
                    Documents::method211(Documents::method210(), v900, string(""));
                let v1009 = Documents::method89();
                let v1014: Result<string, std::string::String> =
                    Ok::<string, std::io::Error>(patternInput_2.0.clone()).map_err(|x| v1009(x));
                let v1026 = Documents::method212();
                let v1027 = Documents::method213();
                let v1029: Documents::US44 = match v1014 {
                    Ok(x) => v1026(x),
                    Err(e) => v1027(e),
                };
                (v533)
                    == (match &v1029 {
                        Documents::US44::US44_0(v1029_0_0) => v1029_0_0.clone(),
                        Documents::US44::US44_1(v1029_1_0) => panic!(
                            "{}",
                            sprintf!("resultm.get / Error x: {}", v1029_1_0.clone()),
                        ),
                    })
            } {
                Documents::US41::US41_1
            } else {
                let v1058: Documents::US46 = Documents::method248(v2, v5.clone(), v3, v1_1, v4);
                match &v1058 {
                    Documents::US46::US46_0(v1058_0_0, v1058_0_1) => {
                        let v1060: string = v1058_0_1.clone();
                        let v1059: i32 = v1058_0_0.clone();
                        if (v1059) != 0_i32 {
                            let v2936: () = {
                                Documents::closure154(v1060.clone(), v1059, ());
                                ()
                            };
                            Documents::US41::US41_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v1060)),
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
                    Documents::US46::US46_1(v1058_1_0, v1058_1_1) => {
                        Documents::US41::US41_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v1058_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure155(
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
                    Documents::closure156(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
                }
            })
        }
        pub fn method254(v0_1: LrcPtr<Documents::Mut3>) {
            let v7: string = append((v0_1.l0.get().clone()), string("output_cache_path"));
            v0_1.l0.set(v7);
            ()
        }
        pub fn method253(v0_1: string, v1_1: string) -> string {
            let v13: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v13.clone());
            Documents::method245(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(v13.clone(), v0_1);
            Documents::method50(v13.clone());
            Documents::method254(v13.clone());
            Documents::method20(v13.clone());
            Documents::method15(v13.clone(), v1_1);
            Documents::method21(v13.clone());
            v13.l0.get().clone()
        }
        pub fn method252(
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
            let v10: string = Documents::method253(v8, v9);
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
        pub fn closure159(v0_1: string, v1_1: string, unitVar: ()) {
            fn v75() {
                Documents::closure10((), ());
            }
            let v76: () = {
                v75();
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
            let v204: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v895: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v204,
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
                let v285: () = {
                    v75();
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
                let v371: Option<i64> = patternInput_1.5.clone();
                let v370: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v369: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v368: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v367: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v366: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v415: string = Documents::method252(
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    v371.clone(),
                    Documents::method8(v366, v367, v368, v369, v370, v371),
                    Documents::method12(),
                    v1_1,
                    v0_1,
                );
                let v489: () = {
                    v75();
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
                let v571: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v570: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v623: () = {
                    Documents::closure12(v570.clone(), ());
                    ()
                };
                println!("{}", v415.clone());
                (v571.l0.get().clone())(v415);
                Documents::US7::US7_0(
                    v570,
                    v571,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method255(
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
                    Documents::method255(
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
        pub fn closure161(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: LrcPtr<Documents::UH3>,
        ) -> LrcPtr<Documents::UH3> {
            LrcPtr::new(Documents::UH3::UH3_1(v0_1, v1_1))
        }
        pub fn closure160(
            unitVar: (),
            v0_1: LrcPtr<Documents::UH4>,
        ) -> Func1<LrcPtr<Documents::UH3>, LrcPtr<Documents::UH3>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH3>| Documents::closure161(v0_1.clone(), v)
            })
        }
        pub fn method256()
        -> Func1<LrcPtr<Documents::UH4>, Func1<LrcPtr<Documents::UH3>, LrcPtr<Documents::UH3>>>
        {
            Func1::new(move |v: LrcPtr<Documents::UH4>| Documents::closure160((), v))
        }
        pub fn method258(
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
                    Documents::method258(
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
        pub fn closure162(
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
        pub fn method259(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method260(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method257(
            v0_1: LrcPtr<Documents::UH3>,
            v1_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            let v0_1: MutCell<LrcPtr<Documents::UH3>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<Vec<Option<Result<string, LrcPtr<(string, string)>>>>> =
                MutCell::new(v1_1.clone());
            '_method257: loop {
                break '_method257 (match v0_1.get().clone().as_ref() {
                    Documents::UH3::UH3_0 => v1_1.get().clone(),
                    Documents::UH3::UH3_1(v0_1_1_0, v0_1_1_1) => {
                        let v77 = toArray_1(Documents::method258(
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
                        let v90 = v77.to_vec();
                        let v92 = rayon::iter::IntoParallelIterator::into_par_iter(v90);
                        let v95 = rayon::iter::ParallelIterator::map(v92, |x| {
                            Func1::new(
                                move |arg10_0040: (
                                    string,
                                    string,
                                    Func1<string, Func1<string, Documents::US41>>,
                                )| {
                                    Documents::closure162((), arg10_0040)
                                },
                            )(x)
                        });
                        let v98: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method259(rayon::iter::ParallelIterator::collect(v95));
                        let v99: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method260(v1_1.get().clone());
                        let v101: bool = true;
                        let mut v99 = v99;
                        let v103: bool = true;
                        v99.extend(v98);
                        {
                            let v0_1_temp: LrcPtr<Documents::UH3> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH3::UH3_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v1_1_temp: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                v99;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method257;
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
            let v50: &str = &*v7.clone();
            let v218: std::string::String = String::from(v50);
            let v553: std::path::PathBuf = Documents::method37(std::path::PathBuf::from(v218));
            let v555: std::path::Display = v553.display();
            let v725: std::string::String = format!("{}", v555);
            let v888: string = concat(new_array(&[
                string("."),
                replace(
                    replace(
                        fable_library_rust::String_::fromString(v725),
                        v4.clone(),
                        Documents::method102(),
                    ),
                    string("\\"),
                    string("/"),
                ),
            ]));
            let v889: string = Documents::method52(v7);
            let v891: string = Documents::method103(Documents::method39(v3.clone(), v888.clone()));
            let patternInput: (i32, string) = Documents::method104(
                concat(new_array(&[
                    string("git ls-tree --format=\'%(objectname)\' origin/gh-pages \""),
                    v891.clone(),
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
            let v997: string = patternInput.1.clone();
            let v996: i32 = patternInput.0.clone();
            let v999: string = Documents::method103(Documents::method39(v4.clone(), v888.clone()));
            let patternInput_1: (i32, string) = Documents::method104(
                concat(new_array(&[
                    string("git hash-object \""),
                    v999.clone(),
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
            let v1105: string = patternInput_1.1.clone();
            let v1104: i32 = patternInput_1.0.clone();
            let v1107: string = Documents::method103(Documents::method39(v5.clone(), v888.clone()));
            let v1109: string =
                (Documents::method206(string("hangul.md"), v999.clone(), v5.clone()))
                    .0
                    .clone();
            let v7873: LrcPtr<Documents::UH3> = if contains(v997.clone(), v1105.clone()) {
                LrcPtr::new(Documents::UH3::UH3_0)
            } else {
                let v1132: string = Documents::method52(v999.clone());
                let v1134: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v1132);
                let v1139: std::fs::File = v1134.unwrap();
                let v1152: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v1139);
                let v1154: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v1152);
                let v1156: bool = true;
                let mut v1154 = v1154;
                let v1158: bool = true;
                let result: sha2::Sha256 = sha2::Digest::new();
                let v1160: sha2::Sha256 = result;
                let v1162: bool = true;
                let mut v1160 = v1160;
                let v1184: Documents::US42 = Documents::method207();
                let v1205: Documents::US43 = match &v1184 {
                    Documents::US42::US42_0(v1184_0_0) => {
                        Documents::US43::US43_0(v1184_0_0.clone())
                    }
                    _ => Documents::US43::US43_1,
                };
                let v1254: usize = match &v1205 {
                    Documents::US43::US43_0(v1205_0_0) => match &v1205 {
                        Documents::US43::US43_0(x) => x.clone(),
                        _ => unreachable!(),
                    },
                    _ => panic!("{}", string("Option does not have a value."),),
                };
                let v1256: _ = [0_u8; 1024];
                let v1258: bool = true;
                loop {
                    // rust.loop 1;
                    let v1260: bool = true;
                    let mut v1256 = v1256;
                    let v1262: Result<usize, std::io::Error> =
                        std::io::Read::read(&mut v1154, &mut v1256);
                    let v1276: usize = v1262.unwrap();
                    let v1301: bool = if (v1276) == (v1254) {
                        let v1300: bool = true;
                        break ();
                        true
                    } else {
                        false
                    };
                    let v1323: Documents::US42 = Documents::method208(v1276);
                    let v1344: Documents::US43 = match &v1323 {
                        Documents::US42::US42_0(v1323_0_0) => {
                            Documents::US43::US43_0(v1323_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v1393: usize = match &v1344 {
                        Documents::US43::US43_0(v1344_0_0) => match &v1344 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v1438: &_ = if (v1393) == (v1256.len()) {
                        &v1256[v1254..]
                    } else {
                        &v1256[v1254..v1393]
                    };
                    let v1440: bool = true;
                    sha2::Digest::update(&mut v1160, v1438);
                    let v1442: bool = true;
                } // rust.loop 3;
                let v1444: &[u8] = &sha2::Digest::finalize(v1160);
                let v1446: Vec<u8> = v1444.iter().map(|x| *x).collect::<Vec<_>>();
                let v1448: bool = true;
                let _vec_map: Vec<_> = v1446
                    .into_iter()
                    .map(|x| {
                        //;
                        let v1450: u8 = x;
                        let v1452: std::string::String = format!("{:02x}", v1450);
                        let v1454: string = fable_library_rust::String_::fromString(v1452);
                        let v1456: bool = true;
                        v1454
                    })
                    .collect::<Vec<_>>();
                let v1458: Vec<string> = _vec_map;
                let v1469: List<string> =
                    ofArray(fable_library_rust::NativeArray_::array_from(v1458.clone()));
                let v1498: LrcPtr<Documents::UH2> = foldBack(
                    Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                        (Documents::method209())(b0)(b1)
                    }),
                    v1469,
                    LrcPtr::new(Documents::UH2::UH2_0),
                );
                let patternInput_3: (string, string) =
                    Documents::method211(Documents::method210(), v1498, string(""));
                let v1608 = Documents::method89();
                let v1613: Result<string, std::string::String> =
                    Ok::<string, std::io::Error>(patternInput_3.0.clone()).map_err(|x| v1608(x));
                let v1625 = Documents::method212();
                let v1626 = Documents::method213();
                let v1628: Documents::US44 = match v1613 {
                    Ok(x) => v1625(x),
                    Err(e) => v1626(e),
                };
                let v1653: string = match &v1628 {
                    Documents::US44::US44_0(v1628_0_0) => v1628_0_0.clone(),
                    Documents::US44::US44_1(v1628_1_0) => panic!(
                        "{}",
                        sprintf!("resultm.get / Error x: {}", v1628_1_0.clone()),
                    ),
                };
                let v2159: Documents::US5 = if (Documents::method41(v1107.clone())) == false {
                    Documents::US5::US5_1
                } else {
                    let v1657: string = Documents::method52(v1107.clone());
                    let v1659: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v1657);
                    let v1664: std::fs::File = v1659.unwrap();
                    let v1677: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v1664);
                    let v1679: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                        std::io::BufReader::new(v1677);
                    let v1681: bool = true;
                    let mut v1679 = v1679;
                    let v1683: bool = true;
                    let result: sha2::Sha256 = sha2::Digest::new();
                    let v1685: sha2::Sha256 = result;
                    let v1687: bool = true;
                    let mut v1685 = v1685;
                    let v1709: Documents::US42 = Documents::method207();
                    let v1730: Documents::US43 = match &v1709 {
                        Documents::US42::US42_0(v1709_0_0) => {
                            Documents::US43::US43_0(v1709_0_0.clone())
                        }
                        _ => Documents::US43::US43_1,
                    };
                    let v1779: usize = match &v1730 {
                        Documents::US43::US43_0(v1730_0_0) => match &v1730 {
                            Documents::US43::US43_0(x) => x.clone(),
                            _ => unreachable!(),
                        },
                        _ => panic!("{}", string("Option does not have a value."),),
                    };
                    let v1781: _ = [0_u8; 1024];
                    let v1783: bool = true;
                    loop {
                        // rust.loop 1;
                        let v1785: bool = true;
                        let mut v1781 = v1781;
                        let v1787: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v1679, &mut v1781);
                        let v1801: usize = v1787.unwrap();
                        let v1826: bool = if (v1801) == (v1779) {
                            let v1825: bool = true;
                            break ();
                            true
                        } else {
                            false
                        };
                        let v1848: Documents::US42 = Documents::method208(v1801);
                        let v1869: Documents::US43 = match &v1848 {
                            Documents::US42::US42_0(v1848_0_0) => {
                                Documents::US43::US43_0(v1848_0_0.clone())
                            }
                            _ => Documents::US43::US43_1,
                        };
                        let v1918: usize = match &v1869 {
                            Documents::US43::US43_0(v1869_0_0) => match &v1869 {
                                Documents::US43::US43_0(x) => x.clone(),
                                _ => unreachable!(),
                            },
                            _ => panic!("{}", string("Option does not have a value."),),
                        };
                        let v1963: &_ = if (v1918) == (v1781.len()) {
                            &v1781[v1779..]
                        } else {
                            &v1781[v1779..v1918]
                        };
                        let v1965: bool = true;
                        sha2::Digest::update(&mut v1685, v1963);
                        let v1967: bool = true;
                    } // rust.loop 3;
                    let v1969: &[u8] = &sha2::Digest::finalize(v1685);
                    let v1971: Vec<u8> = v1969.iter().map(|x| *x).collect::<Vec<_>>();
                    let v1973: bool = true;
                    let _vec_map: Vec<_> = v1971
                        .into_iter()
                        .map(|x| {
                            //;
                            let v1975: u8 = x;
                            let v1977: std::string::String = format!("{:02x}", v1975);
                            let v1979: string = fable_library_rust::String_::fromString(v1977);
                            let v1981: bool = true;
                            v1979
                        })
                        .collect::<Vec<_>>();
                    let v1983: Vec<string> = _vec_map;
                    let v1994: List<string> =
                        ofArray(fable_library_rust::NativeArray_::array_from(v1983.clone()));
                    let v2023: LrcPtr<Documents::UH2> = foldBack(
                        Func2::new(move |b0: string, b1: LrcPtr<Documents::UH2>| {
                            (Documents::method209())(b0)(b1)
                        }),
                        v1994,
                        LrcPtr::new(Documents::UH2::UH2_0),
                    );
                    let patternInput_4: (string, string) =
                        Documents::method211(Documents::method210(), v2023, string(""));
                    let v2132 = Documents::method89();
                    let v2137: Result<string, std::string::String> =
                        Ok::<string, std::io::Error>(patternInput_4.0.clone())
                            .map_err(|x| v2132(x));
                    let v2149 = Documents::method212();
                    let v2150 = Documents::method213();
                    let v2152: Documents::US44 = match v2137 {
                        Ok(x) => v2149(x),
                        Err(e) => v2150(e),
                    };
                    match &v2152 {
                        Documents::US44::US44_0(v2152_0_0) => {
                            Documents::US5::US5_0(v2152_0_0.clone())
                        }
                        _ => Documents::US5::US5_1,
                    }
                };
                if let Documents::US5::US5_0(v2159_0_0) = &v2159 {
                    if (v1653.clone()) == (v2159_0_0.clone()) {
                        LrcPtr::new(Documents::UH3::UH3_0)
                    } else {
                        let v4028: () = {
                            Documents::closure145(
                                v888.clone(),
                                v889.clone(),
                                v891.clone(),
                                v997.clone(),
                                v996,
                                v999.clone(),
                                v1105.clone(),
                                v1104,
                                v1107.clone(),
                                v1653.clone(),
                                v2159.clone(),
                                (),
                            );
                            ()
                        };
                        Documents::method227(v1107.clone(), v999.clone());
                        LrcPtr::new(Documents::UH3::UH3_1(
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("hangul.md"),
                                v999.clone(),
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
                                                Documents::closure150(
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
                                    v999.clone(),
                                    Func2::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |b0: string, b1: string| {
                                            (Func1::new({
                                                let v4 = v4.clone();
                                                let v5 = v5.clone();
                                                move |v_1: string| {
                                                    Documents::closure155(
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
                                        v999.clone(),
                                        Func2::new({
                                            let v4 = v4.clone();
                                            let v5 = v5.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v4 = v4.clone();
                                                    let v5 = v5.clone();
                                                    move |v_2: string| {
                                                        Documents::closure155(
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
                                            v999.clone(),
                                            Func2::new({
                                                let v4 = v4.clone();
                                                let v5 = v5.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v4 = v4.clone();
                                                        let v5 = v5.clone();
                                                        move |v_3: string| {
                                                            Documents::closure155(
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
                                                v1109.clone(),
                                                Func2::new({
                                                    let v4 = v4.clone();
                                                    let v5 = v5.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v4 = v4.clone();
                                                            let v5 = v5.clone();
                                                            move |v_4: string| {
                                                                Documents::closure155(
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
                                                    v1109.clone(),
                                                    Func2::new({
                                                        let v4 = v4.clone();
                                                        let v5 = v5.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v4 = v4.clone();
                                                                let v5 = v5.clone();
                                                                move |v_5: string| {
                                                                    Documents::closure155(
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
                                                        v1109.clone(),
                                                        Func2::new({
                                                            let v4 = v4.clone();
                                                            let v5 = v5.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v4 = v4.clone();
                                                                    let v5 = v5.clone();
                                                                    move |v_6: string| {
                                                                        Documents::closure155(
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
                    let v6883: () = {
                        Documents::closure145(
                            v888,
                            v889.clone(),
                            v891,
                            v997,
                            v996,
                            v999.clone(),
                            v1105,
                            v1104,
                            v1107.clone(),
                            v1653,
                            v2159.clone(),
                            (),
                        );
                        ()
                    };
                    Documents::method227(v1107, v999.clone());
                    LrcPtr::new(Documents::UH3::UH3_1(
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("hangul.md"),
                            v999.clone(),
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
                                            Documents::closure150(
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
                                v999.clone(),
                                Func2::new({
                                    let v4 = v4.clone();
                                    let v5 = v5.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v4 = v4.clone();
                                            let v5 = v5.clone();
                                            move |v_8: string| {
                                                Documents::closure155(
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
                                    v999.clone(),
                                    Func2::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |b0: string, b1: string| {
                                            (Func1::new({
                                                let v4 = v4.clone();
                                                let v5 = v5.clone();
                                                move |v_9: string| {
                                                    Documents::closure155(
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
                                        v999.clone(),
                                        Func2::new({
                                            let v4 = v4.clone();
                                            let v5 = v5.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v4 = v4.clone();
                                                    let v5 = v5.clone();
                                                    move |v_10: string| {
                                                        Documents::closure155(
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
                                            v1109.clone(),
                                            Func2::new({
                                                let v4 = v4.clone();
                                                let v5 = v5.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v4 = v4.clone();
                                                        let v5 = v5.clone();
                                                        move |v_11: string| {
                                                            Documents::closure155(
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
                                                v1109.clone(),
                                                Func2::new({
                                                    let v4 = v4.clone();
                                                    let v5 = v5.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v4 = v4.clone();
                                                            let v5 = v5.clone();
                                                            move |v_12: string| {
                                                                Documents::closure155(
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
                                                    v1109.clone(),
                                                    Func2::new({
                                                        let v4 = v4.clone();
                                                        let v5 = v5.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v4 = v4.clone();
                                                                let v5 = v5.clone();
                                                                move |v_13: string| {
                                                                    Documents::closure155(
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
            let v27715: Array<LrcPtr<Documents::UH4>> = toArray_1(Documents::method255(
                if (if let Documents::UH3::UH3_0 = v7873.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v7873
                } else {
                    let patternInput_5: (string, string) =
                        Documents::method206(string("epub"), v1109.clone(), v5.clone());
                    let v7878: string = patternInput_5.1.clone();
                    let v7877: string = patternInput_5.0.clone();
                    let v10705: LrcPtr<Documents::UH4> = if if Documents::method41(v7877.clone()) {
                        true
                    } else {
                        if (Documents::method41(v7878.clone())) == false {
                            true
                        } else {
                            let v9737: () = {
                                Documents::closure159(v7878.clone(), v7877.clone(), ());
                                ()
                            };
                            Documents::method227(v7877, v7878);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("epub"),
                            v1109.clone(),
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_14: string| {
                                            Documents::closure155(
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
                        Documents::method206(string("pdf"), v1109.clone(), v5.clone());
                    let v10708: string = patternInput_6.1.clone();
                    let v10707: string = patternInput_6.0.clone();
                    let v13533: LrcPtr<Documents::UH4> = if if Documents::method41(v10707.clone()) {
                        true
                    } else {
                        if (Documents::method41(v10708.clone())) == false {
                            true
                        } else {
                            let v12567: () = {
                                Documents::closure159(v10708.clone(), v10707.clone(), ());
                                ()
                            };
                            Documents::method227(v10707, v10708);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("pdf"),
                            v1109.clone(),
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_15: string| {
                                            Documents::closure155(
                                                v5.clone(),
                                                v4.clone(),
                                                true,
                                                v_15,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v10705.clone(),
                        ))
                    } else {
                        v10705
                    };
                    let patternInput_7: (string, string) =
                        Documents::method206(string("html"), v1109.clone(), v5.clone());
                    let v13536: string = patternInput_7.1.clone();
                    let v13535: string = patternInput_7.0.clone();
                    let v16361: LrcPtr<Documents::UH4> = if if Documents::method41(v13535.clone()) {
                        true
                    } else {
                        if (Documents::method41(v13536.clone())) == false {
                            true
                        } else {
                            let v15395: () = {
                                Documents::closure159(v13536.clone(), v13535.clone(), ());
                                ()
                            };
                            Documents::method227(v13535, v13536);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("html"),
                            v1109,
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_16: string| {
                                            Documents::closure155(
                                                v5.clone(),
                                                v4.clone(),
                                                true,
                                                v_16,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v13533.clone(),
                        ))
                    } else {
                        v13533
                    };
                    let patternInput_8: (string, string) =
                        Documents::method206(string("epub"), v999.clone(), v5.clone());
                    let v16363: string = patternInput_8.1.clone();
                    let v16362: string = patternInput_8.0.clone();
                    let v19188: LrcPtr<Documents::UH4> = if if Documents::method41(v16362.clone()) {
                        true
                    } else {
                        if (Documents::method41(v16363.clone())) == false {
                            true
                        } else {
                            let v18222: () = {
                                Documents::closure159(v16363.clone(), v16362.clone(), ());
                                ()
                            };
                            Documents::method227(v16362, v16363);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("epub"),
                            v999.clone(),
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_17: string| {
                                            Documents::closure155(
                                                v5.clone(),
                                                v4.clone(),
                                                false,
                                                v_17,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v16361.clone(),
                        ))
                    } else {
                        v16361
                    };
                    let patternInput_9: (string, string) =
                        Documents::method206(string("pdf"), v999.clone(), v5.clone());
                    let v19190: string = patternInput_9.1.clone();
                    let v19189: string = patternInput_9.0.clone();
                    let v22015: LrcPtr<Documents::UH4> = if if Documents::method41(v19189.clone()) {
                        true
                    } else {
                        if (Documents::method41(v19190.clone())) == false {
                            true
                        } else {
                            let v21049: () = {
                                Documents::closure159(v19190.clone(), v19189.clone(), ());
                                ()
                            };
                            Documents::method227(v19189, v19190);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("pdf"),
                            v999.clone(),
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_18: string| {
                                            Documents::closure155(
                                                v5.clone(),
                                                v4.clone(),
                                                false,
                                                v_18,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v19188.clone(),
                        ))
                    } else {
                        v19188
                    };
                    let patternInput_10: (string, string) =
                        Documents::method206(string("html"), v999.clone(), v5.clone());
                    let v22017: string = patternInput_10.1.clone();
                    let v22016: string = patternInput_10.0.clone();
                    let v24842: LrcPtr<Documents::UH4> = if if Documents::method41(v22016.clone()) {
                        true
                    } else {
                        if (Documents::method41(v22017.clone())) == false {
                            true
                        } else {
                            let v23876: () = {
                                Documents::closure159(v22017.clone(), v22016.clone(), ());
                                ()
                            };
                            Documents::method227(v22016, v22017);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH4::UH4_1(
                            string("html"),
                            v999.clone(),
                            Func2::new({
                                let v4 = v4.clone();
                                let v5 = v5.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v4 = v4.clone();
                                        let v5 = v5.clone();
                                        move |v_19: string| {
                                            Documents::closure155(
                                                v5.clone(),
                                                v4.clone(),
                                                false,
                                                v_19,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v22015.clone(),
                        ))
                    } else {
                        v22015
                    };
                    let patternInput_11: (string, string) =
                        Documents::method206(string("hangul.md"), v999.clone(), v5.clone());
                    let v24844: string = patternInput_11.1.clone();
                    let v24843: string = patternInput_11.0.clone();
                    LrcPtr::new(Documents::UH3::UH3_1(
                        if if Documents::method41(v24843.clone()) {
                            true
                        } else {
                            if (Documents::method41(v24844.clone())) == false {
                                true
                            } else {
                                let v26703: () = {
                                    Documents::closure159(v24844.clone(), v24843.clone(), ());
                                    ()
                                };
                                Documents::method227(v24843, v24844);
                                false
                            }
                        } {
                            LrcPtr::new(Documents::UH4::UH4_1(
                                string("hangul.md"),
                                v999,
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
                                                Documents::closure150(
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
                            v24842,
                            LrcPtr::new(Documents::UH3::UH3_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH4>>(),
            ));
            let v27728: Vec<LrcPtr<Documents::UH4>> = v27715.to_vec();
            let v27731: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v27742: List<LrcPtr<Documents::UH4>> =
                ofArray(fable_library_rust::NativeArray_::array_from(v27728.clone()));
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((
                v889,
                Documents::method257(
                    foldBack(
                        Func2::new(
                            move |b0: LrcPtr<Documents::UH4>, b1: LrcPtr<Documents::UH3>| {
                                (Documents::method256())(b0)(b1)
                            },
                        ),
                        v27742,
                        LrcPtr::new(Documents::UH3::UH3_0),
                    ),
                    v27731,
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
            let v68: string = Documents::method39(
                if string("deps") == (Documents::method61(v23.clone())) {
                    let v61: Documents::US5 =
                        Documents::method38(Documents::method44(v23.clone()).clone().unwrap());
                    match &v61 {
                        Documents::US5::US5_0(v61_0_0) => match &v61 {
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
            let v69: string = Documents::method76(v5);
            let v70: string = Documents::method76(v4);
            let v71: string = Documents::method76(v3);
            let v1927: () = {
                Documents::closure30(
                    v0_1,
                    v1_1.clone(),
                    v2.clone(),
                    v69.clone(),
                    v70.clone(),
                    v71.clone(),
                    (),
                );
                ()
            };
            let v2890: bool = true;
            let __future_init = Box::pin(
                /*;
                let v2892: bool = */
                async move {
                    /*;
                    let v2894: bool = */
                    ();
                    let v2896: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v70.clone());
                    let v2899: async_walkdir::WalkDir =
                        async_walkdir::WalkDir::filter(v2896, move |x| {
                            Func1::new({
                                let v1_1 = v1_1.clone();
                                move |v: async_walkdir::DirEntry| {
                                    Documents::closure31(v1_1.clone(), v)
                                }
                            })(x)
                        });
                    let v2900 = Documents::method92();
                    let v2902 =
                        futures::stream::StreamExt::filter_map(v2899, |x| async { v2900(x) });
                    let v2904: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                        Box::pin(futures::stream::StreamExt::collect(v2902));
                    let v2906: Vec<string> = v2904.await;
                    let v4766: () = {
                        Documents::closure40(v2906.clone(), ());
                        ()
                    };
                    let v5731: rayon::vec::IntoIter<string> =
                        rayon::iter::IntoParallelIterator::into_par_iter(v2906);
                    let v5734: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                        rayon::iter::ParallelIterator::map(v5731, |x| {
                            Func1::new({
                                let v0_1 = v0_1.clone();
                                let v2 = v2.clone();
                                let v68 = v68.clone();
                                let v69 = v69.clone();
                                let v70 = v70.clone();
                                let v71 = v71.clone();
                                move |v_1: string| {
                                    Documents::closure41(
                                        v0_1,
                                        v2.clone(),
                                        v68.clone(),
                                        v69.clone(),
                                        v70.clone(),
                                        v71.clone(),
                                        v_1,
                                    )
                                }
                            })(x)
                        });
                    let v5736: Vec<
                        Result<
                            LrcPtr<(
                                string,
                                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                            )>,
                            std::string::String,
                        >,
                    > = rayon::iter::ParallelIterator::collect(v5734);
                    let v5759: string = string("}");
                    let v5764: bool = true;
                    let _fix_closure_v5761 = Ok::<
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
                    >(v5736);
                    let v5770: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v5761 "), (v5759))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v5771: bool = true;
                    _fix_closure_v5761
                },
            ); // rust.fix_closure';
            let v5773 = __future_init;
            v5773
        }
        pub fn closure163(
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
        pub fn method261() -> Func1<
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
                >| Documents::closure163((), v),
            )
        }
        pub fn closure164(unitVar: (), v0_1: std::string::String) -> Documents::US47 {
            Documents::US47::US47_1(v0_1)
        }
        pub fn method262() -> Func1<std::string::String, Documents::US47> {
            Func1::new(move |v: std::string::String| Documents::closure164((), v))
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
        pub fn closure165(v0_1: std::string::String, unitVar: ()) {
            fn v74() {
                Documents::closure10((), ());
            }
            let v75: () = {
                v74();
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
            let v203: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v894: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v203,
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
                let v284: () = {
                    v74();
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
                let v370: Option<i64> = patternInput_1.5.clone();
                let v369: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v368: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v367: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v366: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v365: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v414: string = Documents::method263(
                    v365.clone(),
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    Documents::method8(v365, v366, v367, v368, v369, v370),
                    Documents::method96(),
                    v0_1,
                );
                let v488: () = {
                    v74();
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
                let v570: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v569: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v622: () = {
                    Documents::closure12(v569.clone(), ());
                    ()
                };
                println!("{}", v414.clone());
                (v570.l0.get().clone())(v414);
                Documents::US7::US7_0(
                    v569,
                    v570,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method265(v0_1: usize) -> string {
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method14()),
            });
            Documents::method18(v12.clone());
            Documents::method244(v12.clone());
            Documents::method20(v12.clone());
            {
                let v418: std::string::String = format!("{:#?}", v0_1);
                Documents::method15(v12.clone(), fable_library_rust::String_::fromString(v418));
                Documents::method21(v12.clone());
                v12.l0.get().clone()
            }
        }
        pub fn method264(
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
            let v9: string = Documents::method265(v8);
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
        pub fn closure166(
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
            fn v74() {
                Documents::closure10((), ());
            }
            let v75: () = {
                v74();
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
            let v203: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v896: Documents::US7 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v203,
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
                let v284: () = {
                    v74();
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
                let v370: Option<i64> = patternInput_1.5.clone();
                let v369: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v368: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v367: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v366: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v365: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v416: string = Documents::method264(
                    v365.clone(),
                    v366.clone(),
                    v367.clone(),
                    v368.clone(),
                    v369.clone(),
                    v370.clone(),
                    Documents::method8(v365, v366, v367, v368, v369, v370),
                    Documents::method12(),
                    v0_1.len(),
                );
                let v490: () = {
                    v74();
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
                let v572: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v571: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v624: () = {
                    Documents::closure12(v571.clone(), ());
                    ()
                };
                println!("{}", v416.clone());
                (v572.l0.get().clone())(v416);
                Documents::US7::US7_0(
                    v571,
                    v572,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v75: () = {
                Documents::closure2((), ());
                ()
            };
            let v1971: () = {
                Documents::closure9(v0_1, ());
                ()
            };
            let v2933: clap::Command = Documents::method0();
            let v2935: clap::ArgMatches = clap::Command::get_matches(v2933);
            let v2936: string = Documents::method28();
            let v2979: &str = &*v2936;
            let v3106: Option<std::string::String> =
                clap::ArgMatches::get_one(&v2935.clone(), v2979).cloned();
            let v3216: Documents::US9 =
                defaultValue(Documents::US9::US9_1, map(Documents::method29(), v3106));
            let v3232: std::string::String = match &v3216 {
                Documents::US9::US9_0(v3216_0_0) => match &v3216 {
                    Documents::US9::US9_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v3234: string = fable_library_rust::String_::fromString(v3232);
            let v3235: string = Documents::method30();
            let v3278: &str = &*v3235;
            let v3405: Option<std::string::String> =
                clap::ArgMatches::get_one(&v2935.clone(), v3278).cloned();
            let v3515: Documents::US9 =
                defaultValue(Documents::US9::US9_1, map(Documents::method29(), v3405));
            let v3531: std::string::String = match &v3515 {
                Documents::US9::US9_0(v3515_0_0) => match &v3515 {
                    Documents::US9::US9_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v3533: string = fable_library_rust::String_::fromString(v3531);
            let v3534: string = Documents::method31();
            let v3577: &str = &*v3534;
            let v3704: Option<std::string::String> =
                clap::ArgMatches::get_one(&v2935.clone(), v3577).cloned();
            let v3814: Documents::US9 =
                defaultValue(Documents::US9::US9_1, map(Documents::method29(), v3704));
            let v3830: std::string::String = match &v3814 {
                Documents::US9::US9_0(v3814_0_0) => match &v3814 {
                    Documents::US9::US9_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v3832: string = fable_library_rust::String_::fromString(v3830);
            let v3833: string = Documents::method32();
            let v3876: &str = &*v3833;
            let v4003: Option<std::string::String> =
                clap::ArgMatches::get_one(&v2935.clone(), v3876).cloned();
            let v4113: Documents::US9 =
                defaultValue(Documents::US9::US9_1, map(Documents::method29(), v4003));
            let v4132: Documents::US5 = match &v4113 {
                Documents::US9::US9_0(v4113_0_0) => {
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(
                        match &v4113 {
                            Documents::US9::US9_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ))
                }
                _ => Documents::US5::US5_1,
            };
            let v4136: string = match &v4132 {
                Documents::US5::US5_0(v4132_0_0) => match &v4132 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string("por-br"),
            };
            let v4137: string = Documents::method33();
            let v4180: &str = &*v4137;
            let v4307: Option<std::string::String> =
                clap::ArgMatches::get_one(&v2935.clone(), v4180).cloned();
            let v4417: Documents::US9 =
                defaultValue(Documents::US9::US9_1, map(Documents::method29(), v4307));
            let v4436: Documents::US5 = match &v4417 {
                Documents::US9::US9_0(v4417_0_0) => {
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(
                        match &v4417 {
                            Documents::US9::US9_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ))
                }
                _ => Documents::US5::US5_1,
            };
            let v4437: string = Documents::method34();
            let v4480: &str = &*v4437;
            let v4608: std::pin::Pin<
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
                clap::ArgMatches::get_flag(&v2935, v4480),
                v4436,
                v4136,
                v3832,
                v3533,
                v3234,
            );
            let v4610: Result<
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
            > = futures::executor::block_on(v4608);
            let v4611 = Documents::method261();
            let v4612 = Documents::method262();
            let v4621: Documents::US47 = match &v4610 {
                Err(v4610_1_0) => v4612(v4610_1_0.clone()),
                Ok(v4610_0_0) => v4611(v4610_0_0.clone()),
            };
            match &v4621 {
                Documents::US47::US47_0(v4621_0_0) => {
                    let v6501: () = {
                        Documents::closure166(v4621_0_0.clone(), ());
                        ()
                    };
                    0_i32
                }
                Documents::US47::US47_1(v4621_1_0) => {
                    let v9321: () = {
                        Documents::closure165(v4621_1_0.clone(), ());
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
