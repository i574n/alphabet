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
        use fable_library_rust::List_::List;
        use fable_library_rust::List_::cons;
        use fable_library_rust::List_::empty;
        use fable_library_rust::List_::foldBack;
        use fable_library_rust::List_::ofArray;
        use fable_library_rust::List_::toArray;
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
        use fable_library_rust::Seq_::toArray as toArray_1;
        use fable_library_rust::String_::append;
        use fable_library_rust::String_::concat;
        use fable_library_rust::String_::contains;
        use fable_library_rust::String_::endsWith3;
        use fable_library_rust::String_::getCharAt;
        use fable_library_rust::String_::getSlice;
        use fable_library_rust::String_::indexOf;
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
        use fable_library_rust::String_::trim;
        use fable_library_rust::String_::trimEndChars;
        use fable_library_rust::String_::trimStartChars;
        use fable_library_rust::TimeSpan_::TimeSpan;
        type ConcurrentStack_1<T> = T;
        use fable_library_rust::System::Collections::Generic::IEnumerable_1;
        use fable_library_rust::System::Text::StringBuilder;
        use fable_library_rust::System::Threading::CancellationToken;
        type TaskCanceledException = ();
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
            US6_0(
                LrcPtr<Documents::Mut0>,
                LrcPtr<Documents::Mut1>,
                LrcPtr<Documents::Mut2>,
                LrcPtr<Documents::Mut3>,
                LrcPtr<Documents::Mut4>,
                Option<i64>,
            ),
            US6_1,
        }
        impl core::fmt::Display for US6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US7 {
            US7_0(std::string::String),
            US7_1,
        }
        impl core::fmt::Display for US7 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US8 {
            US8_0,
            US8_1,
        }
        impl core::fmt::Display for US8 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US9 {
            US9_0(string),
            US9_1(string),
        }
        impl core::fmt::Display for US9 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US10 {
            US10_0(std::path::PathBuf),
            US10_1(string),
        }
        impl core::fmt::Display for US10 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US11 {
            US11_0(std::path::PathBuf),
            US11_1,
        }
        impl core::fmt::Display for US11 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut5 {
            pub l0: MutCell<i32>,
            pub l1: MutCell<i32>,
            pub l2: MutCell<Array<string>>,
        }
        impl core::fmt::Display for Mut5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub struct Mut6 {
            pub l0: MutCell<i32>,
        }
        impl core::fmt::Display for Mut6 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US12 {
            US12_0(std::fs::FileType),
            US12_1(std::string::String),
        }
        impl core::fmt::Display for US12 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US13 {
            US13_0,
            US13_1,
            US13_2,
        }
        impl core::fmt::Display for US13 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US14 {
            US14_0(async_walkdir::DirEntry),
            US14_1(std::string::String),
        }
        impl core::fmt::Display for US14 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US15 {
            US15_0(string, Documents::US5),
            US15_1(string),
        }
        impl core::fmt::Display for US15 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US16 {
            US16_0(char, string, LrcPtr<StringBuilder>, i32, i32),
            US16_1(string),
        }
        impl core::fmt::Display for US16 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum UH0 {
            UH0_0,
            UH0_1(char, LrcPtr<Documents::UH0>),
        }
        impl core::fmt::Display for UH0 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH1 {
            UH1_0,
            UH1_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US16>,
                LrcPtr<Documents::UH1>,
            ),
        }
        impl core::fmt::Display for UH1 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US17 {
            US17_0(string, string, LrcPtr<StringBuilder>, i32, i32),
            US17_1(string),
        }
        impl core::fmt::Display for US17 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US18 {
            US18_0(char),
            US18_1,
        }
        impl core::fmt::Display for US18 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US19 {
            US19_0(string, LrcPtr<StringBuilder>, i32, i32),
            US19_1(string),
        }
        impl core::fmt::Display for US19 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US20 {
            US20_0(
                string,
                Documents::US5,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US20_1(string),
        }
        impl core::fmt::Display for US20 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US21 {
            US21_0(Documents::US18, string, LrcPtr<StringBuilder>, i32, i32),
            US21_1(string),
        }
        impl core::fmt::Display for US21 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US22 {
            US22_0(Documents::US5, string, LrcPtr<StringBuilder>, i32, i32),
            US22_1(string),
        }
        impl core::fmt::Display for US22 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US23 {
            US23_0(Array<string>),
            US23_1(string),
        }
        impl core::fmt::Display for US23 {
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
        pub enum US24 {
            US24_0(
                LrcPtr<Documents::UH2>,
                string,
                LrcPtr<StringBuilder>,
                i32,
                i32,
            ),
            US24_1(string),
        }
        impl core::fmt::Display for US24 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH3 {
            UH3_0,
            UH3_1(
                Func1<(string, LrcPtr<StringBuilder>, i32, i32), Documents::US17>,
                LrcPtr<Documents::UH3>,
            ),
        }
        impl core::fmt::Display for UH3 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US25 {
            US25_0(std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>),
            US25_1(std::string::String),
        }
        impl core::fmt::Display for US25 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US26 {
            US26_0(
                std::sync::Arc<
                    std::sync::Mutex<
                        std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                    >,
                >,
            ),
            US26_1,
        }
        impl core::fmt::Display for US26 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US27 {
            US27_0(std::string::String),
            US27_1(std::string::String),
        }
        impl core::fmt::Display for US27 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US28 {
            US28_0(Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>),
            US28_1,
        }
        impl core::fmt::Display for US28 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US29 {
            US29_0(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>),
            US29_1,
        }
        impl core::fmt::Display for US29 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US30 {
            US30_0(std::process::Output),
            US30_1(std::string::String),
        }
        impl core::fmt::Display for US30 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US31 {
            US31_0(i32),
            US31_1,
        }
        impl core::fmt::Display for US31 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US32 {
            US32_0(Func1<(i32, string, bool), Arc<Async<()>>>),
            US32_1,
        }
        impl core::fmt::Display for US32 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US33 {
            US33_0(CancellationToken),
            US33_1,
        }
        impl core::fmt::Display for US33 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US34 {
            US34_0(Result<string, LrcPtr<(string, string)>>),
            US34_1,
        }
        impl core::fmt::Display for US34 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH5 {
            UH5_0,
            UH5_1(
                string,
                string,
                Func2<string, string, Documents::US34>,
                LrcPtr<Documents::UH5>,
            ),
        }
        impl core::fmt::Display for UH5 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum UH4 {
            UH4_0,
            UH4_1(LrcPtr<Documents::UH5>, LrcPtr<Documents::UH4>),
        }
        impl core::fmt::Display for UH4 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US35 {
            US35_0(string),
            US35_1(std::string::String),
        }
        impl core::fmt::Display for US35 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug)]
        pub enum US36 {
            US36_0(u64),
            US36_1(std::string::String),
        }
        impl core::fmt::Display for US36 {
            fn fmt(&self, f: &mut core::fmt::Formatter) -> core::fmt::Result {
                write!(f, "{}", core::any::type_name::<Self>())
            }
        }
        #[derive(Clone, Debug, Hash, PartialEq, PartialOrd)]
        pub enum US37 {
            US37_0(i32, string),
            US37_1(i32, string),
        }
        impl core::fmt::Display for US37 {
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
        pub enum US38 {
            US38_0(
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
            US38_1(std::string::String),
        }
        impl core::fmt::Display for US38 {
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
            let v62: clap::Arg = v60.required(true);
            clap::Command::arg(v49, v62)
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
            let v3: string = Documents::method4(v0_1);
            let v5: Result<std::string::String, std::env::VarError> = std::env::var(&*v3);
            let v7: bool = true;
            let _result_map_ = v5.map(|x| {
                //;
                let v9: std::string::String = x;
                let v11: string = fable_library_rust::String_::fromString(v9);
                let v13: bool = true;
                v11
            });
            let v15: Result<string, std::env::VarError> = _result_map_;
            let v16: string = Documents::method5();
            v15.unwrap_or(v16)
        }
        pub fn method2() -> (Documents::US1, Documents::US2) {
            let v1_1: string = Documents::method3(string("TRACE_LEVEL"));
            let v6: string = toLower(string("Critical"));
            let v13: string = toLower(string("Warning"));
            let v20: string = toLower(string("Info"));
            let v27: string = toLower(string("Debug"));
            let v34: string = toLower(string("Verbose"));
            let v41: Documents::US1 = if string("Verbose") == (v1_1.clone()) {
                Documents::US1::US1_0(Documents::US0::US0_0)
            } else {
                Documents::US1::US1_1
            };
            (
                match &v41 {
                    Documents::US1::US1_0(v41_0_0) => Documents::US1::US1_0(
                        match &v41 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => {
                        let v48: Documents::US1 = if string("Debug") == (v1_1.clone()) {
                            Documents::US1::US1_0(Documents::US0::US0_1)
                        } else {
                            Documents::US1::US1_1
                        };
                        match &v48 {
                            Documents::US1::US1_0(v48_0_0) => Documents::US1::US1_0(
                                match &v48 {
                                    Documents::US1::US1_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                            ),
                            _ => {
                                let v55: Documents::US1 = if string("Info") == (v1_1.clone()) {
                                    Documents::US1::US1_0(Documents::US0::US0_2)
                                } else {
                                    Documents::US1::US1_1
                                };
                                match &v55 {
                                    Documents::US1::US1_0(v55_0_0) => Documents::US1::US1_0(
                                        match &v55 {
                                            Documents::US1::US1_0(x) => x.clone(),
                                            _ => unreachable!(),
                                        }
                                        .clone(),
                                    ),
                                    _ => {
                                        let v62: Documents::US1 =
                                            if string("Warning") == (v1_1.clone()) {
                                                Documents::US1::US1_0(Documents::US0::US0_3)
                                            } else {
                                                Documents::US1::US1_1
                                            };
                                        match &v62 {
                                            Documents::US1::US1_0(v62_0_0) => {
                                                Documents::US1::US1_0(
                                                    match &v62 {
                                                        Documents::US1::US1_0(x) => x.clone(),
                                                        _ => unreachable!(),
                                                    }
                                                    .clone(),
                                                )
                                            }
                                            _ => {
                                                let v69: Documents::US1 =
                                                    if string("Critical") == (v1_1.clone()) {
                                                        Documents::US1::US1_0(Documents::US0::US0_4)
                                                    } else {
                                                        Documents::US1::US1_1
                                                    };
                                                match &v69 {
                                                    Documents::US1::US1_0(v69_0_0) => {
                                                        Documents::US1::US1_0(
                                                            match &v69 {
                                                                Documents::US1::US1_0(x) => {
                                                                    x.clone()
                                                                }
                                                                _ => unreachable!(),
                                                            }
                                                            .clone(),
                                                        )
                                                    }
                                                    _ => {
                                                        let v76: Documents::US1 =
                                                            if (v34.clone()) == (v1_1.clone()) {
                                                                Documents::US1::US1_0(
                                                                    Documents::US0::US0_0,
                                                                )
                                                            } else {
                                                                Documents::US1::US1_1
                                                            };
                                                        match &v76 {
                                                            Documents::US1::US1_0(v76_0_0) => {
                                                                Documents::US1::US1_0(
                                                                    match &v76 {
                                                                        Documents::US1::US1_0(
                                                                            x,
                                                                        ) => x.clone(),
                                                                        _ => unreachable!(),
                                                                    }
                                                                    .clone(),
                                                                )
                                                            }
                                                            _ => {
                                                                let v83: Documents::US1 = if (v27
                                                                    .clone())
                                                                    == (v1_1.clone())
                                                                {
                                                                    Documents::US1::US1_0(
                                                                        Documents::US0::US0_1,
                                                                    )
                                                                } else {
                                                                    Documents::US1::US1_1
                                                                };
                                                                match &v83 {
                                                                 Documents::US1::US1_0(v83_0_0)
                                                                 =>
                                                                 Documents::US1::US1_0(match &v83
                                                                                           {
                                                                                           Documents::US1::US1_0(x)
                                                                                           =>
                                                                                           x.clone(),
                                                                                           _
                                                                                           =>
                                                                                           unreachable!(),
                                                                                       }.clone()),
                                                                 _ => {
                                                                     let v90:
                                                                             Documents::US1 =
                                                                         if (v20.clone())
                                                                                ==
                                                                                (v1_1.clone())
                                                                            {
                                                                             Documents::US1::US1_0(Documents::US0::US0_2)
                                                                         } else {
                                                                             Documents::US1::US1_1
                                                                         };
                                                                     match &v90
                                                                         {
                                                                         Documents::US1::US1_0(v90_0_0)
                                                                         =>
                                                                         Documents::US1::US1_0(match &v90
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
                                                                             let v97:
                                                                                     Documents::US1 =
                                                                                 if (v13.clone())
                                                                                        ==
                                                                                        (v1_1.clone())
                                                                                    {
                                                                                     Documents::US1::US1_0(Documents::US0::US0_3)
                                                                                 } else {
                                                                                     Documents::US1::US1_1
                                                                                 };
                                                                             match &v97
                                                                                 {
                                                                                 Documents::US1::US1_0(v97_0_0)
                                                                                 =>
                                                                                 Documents::US1::US1_0(match &v97
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
                                                                                     let v104:
                                                                                             Documents::US1 =
                                                                                         if (v6.clone())
                                                                                                ==
                                                                                                (v1_1.clone())
                                                                                            {
                                                                                             Documents::US1::US1_0(Documents::US0::US0_4)
                                                                                         } else {
                                                                                             Documents::US1::US1_1
                                                                                         };
                                                                                     match &v104
                                                                                         {
                                                                                         Documents::US1::US1_0(v104_0_0)
                                                                                         =>
                                                                                         Documents::US1::US1_0(match &v104
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
                    Documents::US2::US2_0({
                        let _arg: DateTime = DateTime::now();
                        _arg.ticks()
                    })
                },
            )
        }
        pub fn closure4(unitVar: (), v0_1: string) {
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
            let v185: Documents::US2 = _run_target_args__v3.1.clone();
            let v184: Documents::US1 = _run_target_args__v3.0.clone();
            (
                LrcPtr::new(Documents::Mut0 {
                    l0: MutCell::new(1_i64),
                }),
                LrcPtr::new(Documents::Mut1 {
                    l0: MutCell::new(Func1::new(move |v: string| Documents::closure4((), v))),
                }),
                LrcPtr::new(Documents::Mut2 {
                    l0: MutCell::new(true),
                }),
                LrcPtr::new(Documents::Mut3 {
                    l0: MutCell::new(string("")),
                }),
                LrcPtr::new(Documents::Mut4 {
                    l0: MutCell::new(match &v184 {
                        Documents::US1::US1_0(v184_0_0) => match &v184 {
                            Documents::US1::US1_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => v0_1.clone(),
                    }),
                }),
                match &v185 {
                    Documents::US2::US2_0(v185_0_0) => Some(match &v185 {
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
        pub fn closure6(unitVar: (), unitVar_1: ()) {
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
        pub fn closure7(unitVar: (), v0_1: i64) -> Documents::US2 {
            Documents::US2::US2_0(v0_1)
        }
        pub fn method8() -> Func1<i64, Documents::US2> {
            Func1::new(move |v: i64| Documents::closure7((), v))
        }
        pub fn method9() -> string {
            string("hh:mm:ss")
        }
        pub fn method10() -> string {
            string("HH:mm:ss")
        }
        pub fn method7(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
        ) -> string {
            let v220: Documents::US2 =
                defaultValue(Documents::US2::US2_1, map(Documents::method8(), v5));
            let v360: DateTime = match &v220 {
                Documents::US2::US2_0(v220_0_0) => {
                    let v303: TimeSpan = TimeSpan::new_ticks(
                        ({
                            let _arg: DateTime = DateTime::now();
                            _arg.ticks()
                        }) - (match &v220 {
                            Documents::US2::US2_0(x) => x.clone(),
                            _ => unreachable!(),
                        }),
                    );
                    DateTime::new_ymdhms_milli(
                        1_i32,
                        1_i32,
                        1_i32,
                        v303.hours(),
                        v303.minutes(),
                        v303.seconds(),
                        v303.milliseconds(),
                    )
                }
                _ => DateTime::now(),
            };
            let v361: string = Documents::method9();
            let provider: string = if (v361.clone()) == string("") {
                string("M-d-y hh:mm:ss tt")
            } else {
                v361
            };
            v360.toString(provider)
        }
        pub fn method13() -> string {
            string("")
        }
        pub fn closure8(v0_1: LrcPtr<Documents::Mut3>, v1_1: string, unitVar: ()) {
            let v4: string = append((v0_1.l0.get().clone()), (v1_1));
            v0_1.l0.set(v4);
            ()
        }
        pub fn method12(v0_1: char) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v2.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method14() -> string {
            string("\u{001b}[0m")
        }
        pub fn method11() -> string {
            let v8: string = Documents::method12(getCharAt(toLower(string("Info")), 0_i32));
            let v27: &str = inline_colorization::color_bright_green;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method16(v0_1: Array<string>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("args"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v75: () = {
                Documents::closure8(v2.clone(), sprintf!("{:?}", v0_1), ());
                ()
            };
            let v94: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method17(v0_1: string) -> string {
            trimEndChars(
                trimStartChars(v0_1, toArray(empty::<char>())),
                toArray(ofArray(new_array(&[' ', '/']))),
            )
        }
        pub fn method15(
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
            let v9: string = Documents::method16(v8);
            Documents::method17(append(
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
        pub fn closure9(v0_1: LrcPtr<Documents::Mut0>, unitVar: ()) {
            let v2: i64 = (v0_1.l0.get().clone()) + 1_i64;
            v0_1.l0.set(v2);
            ()
        }
        pub fn closure11(v0_1: string, unitVar: ()) {
            printfn!("{0}", v0_1);
        }
        pub fn closure10(unitVar: (), v0_1: string) {
            let v4: () = {
                Documents::closure11(v0_1, ());
                ()
            };
            ()
        }
        pub fn closure5(v0_1: Array<string>, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v298: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v58,
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
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
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
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v124: string = Documents::method15(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method11(),
                    v0_1,
                );
                let v140: () = {
                    v16();
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
                let v164: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v163: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v185: () = {
                    Documents::closure9(v163.clone(), ());
                    ()
                };
                println!("{}", v124.clone());
                (v164.l0.get().clone())(v124);
                Documents::US6::US6_0(
                    v163,
                    v164,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method18() -> string {
            string("source-dir")
        }
        pub fn closure12(unitVar: (), v0_1: std::string::String) -> Documents::US7 {
            Documents::US7::US7_0(v0_1)
        }
        pub fn method19() -> Func1<std::string::String, Documents::US7> {
            Func1::new(move |v: std::string::String| Documents::closure12((), v))
        }
        pub fn method20() -> string {
            string("dist-dir")
        }
        pub fn method21() -> string {
            string("cache-dir")
        }
        pub fn method22() -> string {
            string("hangul-spec")
        }
        pub fn method24() -> string {
            let v6: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
            let v10: std::path::PathBuf = v6.unwrap();
            let v28: std::path::Display = v10.display();
            let v64: std::string::String = format!("{}", v28);
            fable_library_rust::String_::fromString(v64)
        }
        pub fn method26(v0_1: string, v1_1: string) -> string {
            let v13: &str = &*v0_1;
            let v49: std::string::String = String::from(v13);
            let v85: std::path::PathBuf = std::path::PathBuf::from(v49);
            let v121: &str = &*v1_1;
            let v157: std::string::String = String::from(v121);
            let v188: std::path::PathBuf = v85.join(v157);
            let v195: std::path::Display = v188.display();
            let v231: std::string::String = format!("{}", v195);
            fable_library_rust::String_::fromString(v231)
        }
        pub fn method28(v0_1: string) -> bool {
            let v12: &str = &*v0_1;
            let v48: std::string::String = String::from(v12);
            let v105: std::path::PathBuf = std::path::PathBuf::from(v48);
            if v105.clone().exists() {
                v105.is_file()
            } else {
                false
            }
        }
        pub fn closure13(unitVar: (), v0_1: string) -> bool {
            Documents::method28(v0_1)
        }
        pub fn method29(v0_1: string) -> bool {
            let v12: &str = &*v0_1;
            let v48: std::string::String = String::from(v12);
            let v105: std::path::PathBuf = std::path::PathBuf::from(v48);
            if v105.clone().exists() {
                v105.is_dir()
            } else {
                false
            }
        }
        pub fn closure14(unitVar: (), v0_1: string) -> bool {
            Documents::method29(v0_1)
        }
        pub fn method31(v0_1: string) -> Option<string> {
            let v12: &str = &*v0_1;
            let v48: std::string::String = String::from(v12);
            let v84: std::path::PathBuf = std::path::PathBuf::from(v48);
            let v115: Option<std::path::PathBuf> = v84.parent().map(std::path::PathBuf::from);
            let v117: bool = true;
            let _optionm_map_ = v115.map(|x| {
                //;
                let v119: std::path::PathBuf = x;
                let v126: std::path::Display = v119.display();
                let v162: std::string::String = format!("{}", v126);
                let v193: string = fable_library_rust::String_::fromString(v162);
                let v195: bool = true;
                v193
            });
            _optionm_map_
        }
        pub fn method32(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
            v4: string,
        ) -> Documents::US9 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<bool> = MutCell::new(v2);
            let v3 = MutCell::new(v3.clone());
            let v4: MutCell<string> = MutCell::new(v4.clone());
            '_method32: loop {
                break '_method32 (if v3(Documents::method26(v4.get().clone(), v0_1.get().clone())) {
                    Documents::US9::US9_0(v4.get().clone())
                } else {
                    let v8: Option<string> = Documents::method31(v4.get().clone());
                    let v33: Documents::US5 =
                        defaultValue(Documents::US5::US5_1, map(Documents::method6(), v8));
                    match &v33 {
                        Documents::US5::US5_0(v33_0_0) => {
                            let v0_1_temp: string = v0_1.get().clone();
                            let v1_1_temp: string = v1_1.get().clone();
                            let v2_temp: bool = v2.get().clone();
                            let v3_temp = v3.get().clone();
                            let v4_temp: string = match &v33 {
                                Documents::US5::US5_0(x) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method32;
                        }
                        _ => Documents::US9::US9_1(append(
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
        pub fn method30(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: Func1<string, bool>,
        ) -> Documents::US9 {
            if v3(Documents::method26(v1_1.clone(), v0_1.clone())) {
                Documents::US9::US9_0(v1_1.clone())
            } else {
                let v7: Option<string> = Documents::method31(v1_1.clone());
                let v32: Documents::US5 =
                    defaultValue(Documents::US5::US5_1, map(Documents::method6(), v7));
                match &v32 {
                    Documents::US5::US5_0(v32_0_0) => Documents::method32(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2,
                        v3.clone(),
                        match &v32 {
                            Documents::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                    ),
                    _ => Documents::US9::US9_1(append(
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
        pub fn method27(v0_1: Documents::US8, v1_1: string, v2: string) -> Documents::US9 {
            let v3: bool = if let Documents::US8::US8_0 = &v0_1 {
                true
            } else {
                false
            };
            Documents::method30(
                v1_1,
                v2,
                v3,
                if v3 {
                    Func1::new(move |v: string| Documents::closure13((), v))
                } else {
                    Func1::new(move |v_1: string| Documents::closure14((), v_1))
                },
            )
        }
        pub fn method33() -> string {
            let v8: string = Documents::method12(getCharAt(toLower(string("Warning")), 0_i32));
            let v27: &str = inline_colorization::color_yellow;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method35(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), string("dir"), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Documents::closure8(v3.clone(), v0_1, ());
                ()
            };
            let v91: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v110: () = {
                Documents::closure8(v3.clone(), string("error"), ());
                ()
            };
            let v127: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v144: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v163: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method34(
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
            let v10: string = Documents::method35(v8, v9);
            Documents::method17(append(
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
        pub fn closure15(v0_1: string, v1_1: string, unitVar: ()) {
            fn v17() {
                Documents::closure6((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v299: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v59,
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
                Documents::US6::US6_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v108: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v107: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v106: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v105: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v125: string = Documents::method34(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Documents::method7(v105, v106, v107, v108, v109, v110),
                    Documents::method33(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v164: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v186: () = {
                    Documents::closure9(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Documents::US6::US6_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method40(v0_1: std::io::Error) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v9: std::string::String = format!("{:#?}", v0_1);
            let v56: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v9), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn closure16(unitVar: (), v0_1: std::io::Error) -> string {
            Documents::method40(v0_1)
        }
        pub fn method39() -> Func1<std::io::Error, string> {
            Func1::new(move |v: std::io::Error| Documents::closure16((), v))
        }
        pub fn closure17(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US10 {
            Documents::US10::US10_0(v0_1)
        }
        pub fn method41() -> Func1<std::path::PathBuf, Documents::US10> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure17((), v))
        }
        pub fn closure18(unitVar: (), v0_1: string) -> Documents::US10 {
            Documents::US10::US10_1(v0_1)
        }
        pub fn method42() -> Func1<string, Documents::US10> {
            Func1::new(move |v: string| Documents::closure18((), v))
        }
        pub fn method45(v0_1: string) -> string {
            let v12: &str = &*v0_1;
            let v48: std::string::String = String::from(v12);
            let v84: std::path::PathBuf = std::path::PathBuf::from(v48);
            let v115: Option<&std::ffi::OsStr> = v84.file_name();
            let v117: bool = true;
            let _optionm_map_ = v115.map(|x| {
                //;
                let v119: &std::ffi::OsStr = x;
                let v121: std::ffi::OsString = v119.to_os_string();
                let v123: Option<&str> = v121.to_str();
                let v125: &str = v123.unwrap();
                let v132: std::string::String = String::from(v125);
                let v163: string = fable_library_rust::String_::fromString(v132);
                let v165: bool = true;
                v163
            });
            let v167: Option<string> = _optionm_map_;
            let v192: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v167));
            match &v192 {
                Documents::US5::US5_0(v192_0_0) => match &v192 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            }
        }
        pub fn method46(v0_1: string) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v14: () = {
                Documents::closure8(v2.clone(), v0_1, ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method44(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method45(v4.clone());
            let v6: Option<string> = Documents::method31(v4.clone());
            let v31: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v35: string = Documents::method46(v3);
            if (v2) >= 11_u8 {
                let v39: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v46: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v39);
                Err(v46)
            } else {
                if let Documents::US5::US5_0(v31_0_0) = &v31 {
                    if (v4.clone()) != string("") {
                        let v100: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v31_0_0.clone());
                        let v101 = Documents::method39();
                        let v114: Result<std::path::PathBuf, string> = v100.map_err(|x| v101(x));
                        let v117 = Documents::method41();
                        let v118 = Documents::method42();
                        let v120: Documents::US10 = match &v114 {
                            Err(v114_1_0) => v118(v114_1_0.clone()),
                            Ok(v114_0_0) => v117(v114_0_0.clone()),
                        };
                        match &v120 {
                            Documents::US10::US10_0(v120_0_0) => {
                                let v164: string = Documents::method26(
                                    toString(v120_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v171: &str = &*v164;
                                let v207: std::string::String = String::from(v171);
                                let v243: std::path::PathBuf = std::path::PathBuf::from(v207);
                                Ok(v243)
                            }
                            Documents::US10::US10_1(v120_1_0) => {
                                let v291: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v120_1_0.clone(),
                                        v35.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v298: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v291);
                                Err(v298)
                            }
                        }
                    } else {
                        let v347: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v35.clone(),
                                v4.clone(),
                                v5.clone()
                            ),
                        );
                        let v354: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v347);
                        Err(v354)
                    }
                } else {
                    let v402: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1,
                            v35.clone(),
                            v4,
                            v5.clone()
                        ),
                    );
                    let v409: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v402);
                    Err(v409)
                }
            }
        }
        pub fn method43(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v9: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2.clone());
            let v10 = Documents::method39();
            let v23: Result<std::path::PathBuf, string> = v9.map_err(|x| v10(x));
            let v26 = Documents::method41();
            let v27 = Documents::method42();
            let v29: Documents::US10 = match &v23 {
                Err(v23_1_0) => v27(v23_1_0.clone()),
                Ok(v23_0_0) => v26(v23_0_0.clone()),
            };
            match &v29 {
                Documents::US10::US10_0(v29_0_0) => Ok(v29_0_0.clone()),
                Documents::US10::US10_1(v29_1_0) => Documents::method44(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure19(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v29_1_0.clone(),
                    v2.clone(),
                ),
            }
        }
        pub fn closure20(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method43(v0_1, v1_1, v2)
        }
        pub fn closure19(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure20(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method47(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method45(v0_1.clone());
            let v5: Option<string> = Documents::method31(v0_1.clone());
            let v30: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v34: string = Documents::method46(v3);
            if (v2) >= 11_u8 {
                let v38: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v45: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v38);
                Err(v45)
            } else {
                if let Documents::US5::US5_0(v30_0_0) = &v30 {
                    if (v0_1.clone()) != string("") {
                        let v99: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v30_0_0.clone());
                        let v100 = Documents::method39();
                        let v113: Result<std::path::PathBuf, string> = v99.map_err(|x| v100(x));
                        let v116 = Documents::method41();
                        let v117 = Documents::method42();
                        let v119: Documents::US10 = match &v113 {
                            Err(v113_1_0) => v117(v113_1_0.clone()),
                            Ok(v113_0_0) => v116(v113_0_0.clone()),
                        };
                        match &v119 {
                            Documents::US10::US10_0(v119_0_0) => {
                                let v163: string = Documents::method26(
                                    toString(v119_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v170: &str = &*v163;
                                let v206: std::string::String = String::from(v170);
                                let v242: std::path::PathBuf = std::path::PathBuf::from(v206);
                                Ok(v242)
                            }
                            Documents::US10::US10_1(v119_1_0) => {
                                let v290: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v119_1_0.clone(),
                                        v34.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v297: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v290);
                                Err(v297)
                            }
                        }
                    } else {
                        let v346: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v34.clone(),
                                v0_1.clone(),
                                v4.clone()
                            ),
                        );
                        let v353: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v346);
                        Err(v353)
                    }
                } else {
                    let v401: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1.clone(),
                            v34.clone(),
                            v0_1,
                            v4.clone()
                        ),
                    );
                    let v408: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v401);
                    Err(v408)
                }
            }
        }
        pub fn method38(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v8: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0_1.clone());
            let v9 = Documents::method39();
            let v22: Result<std::path::PathBuf, string> = v8.map_err(|x| v9(x));
            let v25 = Documents::method41();
            let v26 = Documents::method42();
            let v28: Documents::US10 = match &v22 {
                Err(v22_1_0) => v26(v22_1_0.clone()),
                Ok(v22_0_0) => v25(v22_0_0.clone()),
            };
            match &v28 {
                Documents::US10::US10_0(v28_0_0) => Ok(v28_0_0.clone()),
                Documents::US10::US10_1(v28_1_0) => Documents::method47(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure19(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    v28_1_0.clone(),
                ),
            }
        }
        pub fn method49(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method50() -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn method51(v0_1: i32, v1_1: i32) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method53(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
            v4: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v5: string = Documents::method45(v4.clone());
            let v6: Option<string> = Documents::method31(v4.clone());
            let v31: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v6));
            let v35: string = Documents::method40(v3);
            if (v2) >= 11_u8 {
                let v39: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v4.clone(),
                        v5.clone()
                    ),
                );
                let v46: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v39);
                Err(v46)
            } else {
                if let Documents::US5::US5_0(v31_0_0) = &v31 {
                    if (v4.clone()) != string("") {
                        let v100: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v31_0_0.clone());
                        let v101 = Documents::method39();
                        let v114: Result<std::path::PathBuf, string> = v100.map_err(|x| v101(x));
                        let v117 = Documents::method41();
                        let v118 = Documents::method42();
                        let v120: Documents::US10 = match &v114 {
                            Err(v114_1_0) => v118(v114_1_0.clone()),
                            Ok(v114_0_0) => v117(v114_0_0.clone()),
                        };
                        match &v120 {
                            Documents::US10::US10_0(v120_0_0) => {
                                let v164: string = Documents::method26(
                                    toString(v120_0_0.clone().display()),
                                    v5.clone(),
                                );
                                let v171: &str = &*v164;
                                let v207: std::string::String = String::from(v171);
                                let v243: std::path::PathBuf = std::path::PathBuf::from(v207);
                                Ok(v243)
                            }
                            Documents::US10::US10_1(v120_1_0) => {
                                let v291: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v120_1_0.clone(),
                                        v35.clone(),
                                        v5.clone()
                                    ),
                                );
                                let v298: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v291);
                                Err(v298)
                            }
                        }
                    } else {
                        let v347: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v35.clone(),
                                v4.clone(),
                                v5.clone()
                            ),
                        );
                        let v354: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v347);
                        Err(v354)
                    }
                } else {
                    let v402: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1,
                            v35.clone(),
                            v4,
                            v5.clone()
                        ),
                    );
                    let v409: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v402);
                    Err(v409)
                }
            }
        }
        pub fn method52(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v45: i32 =
                Documents::method49(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v47: bool = Documents::method51(Documents::method50(), v45);
            if v47 {
                let v54: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v131: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v131)
            } else {
                let v153: string = append(
                    string(
                        "file_system.read_link / Fsharp / The file or directory is not a reparse point. / ",
                    ),
                    sprintf!(
                        "path: {} / result: {} / path\': {} / n: {}",
                        v0_1.clone(),
                        v47,
                        v2.clone(),
                        v1_1
                    ),
                );
                Documents::method53(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure21(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v153),
                    v2,
                )
            }
        }
        pub fn closure22(
            v0_1: string,
            v1_1: u8,
            v2: string,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            Documents::method52(v0_1, v1_1, v2)
        }
        pub fn closure21(
            v0_1: string,
            v1_1: u8,
        ) -> Func1<string, Result<std::path::PathBuf, std::io::Error>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure22(v0_1.clone(), v1_1, v)
            })
        }
        pub fn method54(
            v0_1: string,
            v1_1: Func2<u8, string, Result<std::path::PathBuf, std::io::Error>>,
            v2: u8,
            v3: std::io::Error,
        ) -> Result<std::path::PathBuf, std::io::Error> {
            let v4: string = Documents::method45(v0_1.clone());
            let v5: Option<string> = Documents::method31(v0_1.clone());
            let v30: Documents::US5 =
                defaultValue(Documents::US5::US5_1, map(Documents::method6(), v5));
            let v34: string = Documents::method40(v3);
            if (v2) >= 11_u8 {
                let v38: string = append(
                    string("file_system.read_link / "),
                    sprintf!(
                        "path: {} / n: {} / path\': {} / name: {}",
                        v0_1.clone(),
                        v2,
                        v0_1.clone(),
                        v4.clone()
                    ),
                );
                let v45: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v38);
                Err(v45)
            } else {
                if let Documents::US5::US5_0(v30_0_0) = &v30 {
                    if (v0_1.clone()) != string("") {
                        let v99: Result<std::path::PathBuf, std::io::Error> =
                            v1_1((v2) + 1_u8, v30_0_0.clone());
                        let v100 = Documents::method39();
                        let v113: Result<std::path::PathBuf, string> = v99.map_err(|x| v100(x));
                        let v116 = Documents::method41();
                        let v117 = Documents::method42();
                        let v119: Documents::US10 = match &v113 {
                            Err(v113_1_0) => v117(v113_1_0.clone()),
                            Ok(v113_0_0) => v116(v113_0_0.clone()),
                        };
                        match &v119 {
                            Documents::US10::US10_0(v119_0_0) => {
                                let v163: string = Documents::method26(
                                    toString(v119_0_0.clone().display()),
                                    v4.clone(),
                                );
                                let v170: &str = &*v163;
                                let v206: std::string::String = String::from(v170);
                                let v242: std::path::PathBuf = std::path::PathBuf::from(v206);
                                Ok(v242)
                            }
                            Documents::US10::US10_1(v119_1_0) => {
                                let v290: string = append(
                                    string("file_system.read_link / "),
                                    sprintf!(
                                        "error\': {} / error: {} / name: {}",
                                        v119_1_0.clone(),
                                        v34.clone(),
                                        v4.clone()
                                    ),
                                );
                                let v297: std::io::Error =
                                    std::io::Error::new(std::io::ErrorKind::Other, &*v290);
                                Err(v297)
                            }
                        }
                    } else {
                        let v346: string = append(
                            string(
                                "file_system.read_link / run / The file or directory is not a reparse point. / ",
                            ),
                            sprintf!(
                                "path: {} / error: {} / path\': {} / name: {}",
                                v0_1.clone(),
                                v34.clone(),
                                v0_1.clone(),
                                v4.clone()
                            ),
                        );
                        let v353: std::io::Error =
                            std::io::Error::new(std::io::ErrorKind::Other, &*v346);
                        Err(v353)
                    }
                } else {
                    let v401: string = append(
                        string(
                            "file_system.read_link / run / The file or directory is not a reparse point. / ",
                        ),
                        sprintf!(
                            "path: {} / error: {} / path\': {} / name: {}",
                            v0_1.clone(),
                            v34.clone(),
                            v0_1,
                            v4.clone()
                        ),
                    );
                    let v408: std::io::Error =
                        std::io::Error::new(std::io::ErrorKind::Other, &*v401);
                    Err(v408)
                }
            }
        }
        pub fn method48(v0_1: string, v1_1: u8) -> Result<std::path::PathBuf, std::io::Error> {
            let v44: i32 =
                Documents::method49(unbox::<bool>(fable_library_rust::Native_::getZero()));
            let v46: bool = Documents::method51(Documents::method50(), v44);
            if v46 {
                let v53: bool = unbox::<bool>(fable_library_rust::Native_::getZero());
                let v130: std::path::PathBuf = fable_library_rust::Native_::getZero();
                Ok(v130)
            } else {
                let v152: string = append(
                    string(
                        "file_system.read_link / Fsharp / The file or directory is not a reparse point. / ",
                    ),
                    sprintf!(
                        "path: {} / result: {} / path\': {} / n: {}",
                        v0_1.clone(),
                        v46,
                        v0_1.clone(),
                        v1_1
                    ),
                );
                Documents::method54(
                    v0_1.clone(),
                    Func2::new({
                        let v0_1 = v0_1.clone();
                        move |b0: u8, b1: string| {
                            (Func1::new({
                                let v0_1 = v0_1.clone();
                                move |v: u8| Documents::closure21(v0_1.clone(), v)
                            }))(b0)(b1)
                        }
                    }),
                    v1_1,
                    std::io::Error::new(std::io::ErrorKind::Other, &*v152),
                )
            }
        }
        pub fn method37(v0_1: string) -> Result<std::path::PathBuf, std::io::Error> {
            if Documents::method29(v0_1.clone()) {
                std::fs::read_link(&*v0_1.clone())
            } else {
                Documents::method38(v0_1, 0_u8)
            }
        }
        pub fn closure23(unitVar: (), v0_1: std::path::PathBuf) -> Documents::US11 {
            Documents::US11::US11_0(v0_1)
        }
        pub fn method55() -> Func1<std::path::PathBuf, Documents::US11> {
            Func1::new(move |v: std::path::PathBuf| Documents::closure23((), v))
        }
        pub fn method57(v0_1: string) -> string {
            v0_1
        }
        pub fn method58() -> string {
            string("")
        }
        pub fn method56(v0_1: string, v1_1: string, v2: string) -> string {
            let v6: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0_1);
            let v10: regex::Regex = v6.unwrap();
            let v22: string = Documents::method57(v2);
            let v24: std::borrow::Cow<str> = v10.replace_all(&*v22, &*v1_1);
            let v26: std::string::String = String::from(v24);
            fable_library_rust::String_::fromString(v26)
        }
        pub fn method36(v0_1: string) -> string {
            if (v0_1.clone()) == string("") {
                string("")
            } else {
                let v3: Result<std::path::PathBuf, std::io::Error> =
                    Documents::method37(v0_1.clone());
                let v7: Option<std::path::PathBuf> = v3.ok();
                let v43: Documents::US11 =
                    defaultValue(Documents::US11::US11_1, map(Documents::method55(), v7));
                let v89: string = match &v43 {
                    Documents::US11::US11_0(v43_0_0) => toString(
                        match &v43 {
                            Documents::US11::US11_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone()
                        .display(),
                    ),
                    _ => v0_1.clone(),
                };
                let v94: string = Documents::method56(
                    string("^\\\\\\\\\\?\\\\"),
                    string(""),
                    if (v89.clone()) == string("") {
                        v0_1.clone()
                    } else {
                        v89
                    },
                );
                if (length(v94.clone())) < 2_i32 {
                    v0_1.clone()
                } else {
                    replace(
                        concat(new_array(&[
                            toLower(ofChar(getCharAt(v94.clone(), 0_i32))),
                            getSlice(v94, Some(1_i32), None::<i32>),
                        ])),
                        string("\\"),
                        string("/"),
                    )
                }
            }
        }
        pub fn method25(v0_1: string) -> Documents::US5 {
            let v5: Documents::US9 = Documents::method27(
                Documents::US8::US8_1,
                Documents::method26(string("spiral"), string("workspace")),
                v0_1.clone(),
            );
            match &v5 {
                Documents::US9::US9_0(v5_0_0) => {
                    Documents::US5::US5_0(Documents::method36(v5_0_0.clone()))
                }
                Documents::US9::US9_1(v5_1_0) => {
                    let v323: () = {
                        Documents::closure15(v0_1.clone(), v5_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            }
        }
        pub fn method60(v0_1: i32, v1_1: LrcPtr<Documents::Mut5>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method61(v0_1: i32, v1_1: LrcPtr<Documents::Mut6>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method62() -> char {
            std::path::MAIN_SEPARATOR
        }
        pub fn method63(v0_1: string) -> string {
            v0_1
        }
        pub fn method59(v0_1: string) -> string {
            let v12: &str = &*v0_1.clone();
            let v48: std::string::String = String::from(v12);
            let v84: std::path::PathBuf = std::path::PathBuf::from(v48);
            if (v84.exists()) == false {
                let v117: string = Documents::method24();
                let v128: Array<string> = split(
                    Documents::method36(Documents::method26(v117.clone(), v0_1.clone())),
                    string("/"),
                    -1_i32,
                    0_i32,
                );
                let v132: i32 = get_Count(v128.clone());
                let v133: LrcPtr<Documents::Mut5> = LrcPtr::new(Documents::Mut5 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                    l2: MutCell::new(new_empty::<string>()),
                });
                while Documents::method60(v132, v133.clone()) {
                    let v135: i32 = v133.l0.get().clone();
                    let v138: i32 = ((v135.wrapping_neg()) + (v132)) - 1_i32;
                    let matchValue: i32 = v133.l1.get().clone();
                    let v140: Array<string> = v133.l2.get().clone();
                    let v139: i32 = matchValue;
                    let v141: string = v128[v138].clone();
                    let patternInput_1: (i32, Array<string>) = if string("..") == (v141.clone()) {
                        ((v139) + 1_i32, v140.clone())
                    } else {
                        if string(".") == (v141.clone()) {
                            (v139, v140.clone())
                        } else {
                            if 0_i32 == (v139) {
                                if endsWith3(v141.clone(), string(":"), false) {
                                    let v153: Array<string> = new_array(&[sprintf!(
                                        "{}:",
                                        getCharAt(v117.clone(), 0_i32)
                                    )]);
                                    let v154: i32 = get_Count(v153.clone());
                                    let v156: i32 = (v154) + (get_Count(v140.clone()));
                                    let v157: Array<string> = new_init(&string(""), v156);
                                    let v158: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method61(v156, v158.clone()) {
                                        let v160: i32 = v158.l0.get().clone();
                                        let v165: string = if (v160) < (v154) {
                                            v153[v160].clone()
                                        } else {
                                            let v163: i32 = (v160) - (v154);
                                            v140[v163].clone()
                                        };
                                        v157.get_mut()[v160 as usize] = v165;
                                        {
                                            let v166: i32 = (v160) + 1_i32;
                                            v158.l0.set(v166);
                                            ()
                                        }
                                    }
                                    (0_i32, v157.clone())
                                } else {
                                    let v167: Array<string> = new_array(&[v141]);
                                    let v168: i32 = get_Count(v167.clone());
                                    let v170: i32 = (v168) + (get_Count(v140.clone()));
                                    let v171: Array<string> = new_init(&string(""), v170);
                                    let v172: LrcPtr<Documents::Mut6> =
                                        LrcPtr::new(Documents::Mut6 {
                                            l0: MutCell::new(0_i32),
                                        });
                                    while Documents::method61(v170, v172.clone()) {
                                        let v174: i32 = v172.l0.get().clone();
                                        let v179: string = if (v174) < (v168) {
                                            v167[v174].clone()
                                        } else {
                                            let v177: i32 = (v174) - (v168);
                                            v140[v177].clone()
                                        };
                                        v171.get_mut()[v174 as usize] = v179;
                                        {
                                            let v180: i32 = (v174) + 1_i32;
                                            v172.l0.set(v180);
                                            ()
                                        }
                                    }
                                    (0_i32, v171.clone())
                                }
                            } else {
                                ((v139) - 1_i32, v140.clone())
                            }
                        }
                    };
                    let v190: i32 = (v135) + 1_i32;
                    v133.l0.set(v190);
                    v133.l1.set(patternInput_1.0.clone());
                    v133.l2.set(patternInput_1.1.clone());
                    ()
                }
                {
                    let matchValue_2: i32 = v133.l1.get().clone();
                    let v192: Array<string> = v133.l2.get().clone();
                    let _let__v197: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                        let v192 = v192.clone();
                        move || {
                            map_1(
                                Func1::new({
                                    let v192 = v192.clone();
                                    move |i: i32| v192[i].clone()
                                }),
                                rangeNumeric(0_i32, 1_i32, (get_Count(v192.clone())) - 1_i32),
                            )
                        }
                    }));
                    let v209: string = ofChar(Documents::method62());
                    join(
                        if (v209.clone()) == string("\n") {
                            Documents::method63(v209.clone())
                        } else {
                            v209
                        },
                        toArray_1(_let__v197),
                    )
                }
            } else {
                let v222: Result<std::path::PathBuf, std::io::Error> =
                    std::fs::canonicalize(&*v0_1);
                let v226: std::path::PathBuf = v222.unwrap();
                let v244: std::path::Display = v226.display();
                let v280: std::string::String = format!("{}", v244);
                fable_library_rust::String_::fromString(v280)
            }
        }
        pub fn method64() -> string {
            let v8: string = Documents::method12(getCharAt(toLower(string("Debug")), 0_i32));
            let v27: &str = inline_colorization::color_bright_blue;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method66(v0_1: string, v1_1: string, v2: string, v3: string) -> string {
            let v5: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v19: () = {
                Documents::closure8(v5.clone(), string("{ "), ());
                ()
            };
            let v38: () = {
                Documents::closure8(v5.clone(), string("source_dir"), ());
                ()
            };
            let v57: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v74: () = {
                Documents::closure8(v5.clone(), v0_1, ());
                ()
            };
            let v93: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v112: () = {
                Documents::closure8(v5.clone(), string("dist_dir"), ());
                ()
            };
            let v129: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v146: () = {
                Documents::closure8(v5.clone(), v1_1, ());
                ()
            };
            let v163: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v182: () = {
                Documents::closure8(v5.clone(), string("cache_dir"), ());
                ()
            };
            let v199: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v216: () = {
                Documents::closure8(v5.clone(), v2, ());
                ()
            };
            let v233: () = {
                Documents::closure8(v5.clone(), string("; "), ());
                ()
            };
            let v252: () = {
                Documents::closure8(v5.clone(), string("hangul_spec"), ());
                ()
            };
            let v269: () = {
                Documents::closure8(v5.clone(), string(" = "), ());
                ()
            };
            let v286: () = {
                Documents::closure8(v5.clone(), v3, ());
                ()
            };
            let v305: () = {
                Documents::closure8(v5.clone(), string(" }"), ());
                ()
            };
            v5.l0.get().clone()
        }
        pub fn method65(
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
        ) -> string {
            let v12: string = Documents::method66(v8, v9, v10, v11);
            Documents::method17(append(
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
                (v12),
            ))
        }
        pub fn closure24(v0_1: string, v1_1: string, v2: string, v3: string, unitVar: ()) {
            fn v19() {
                Documents::closure6((), ());
            }
            let v20: () = {
                v19();
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
            let v61: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v301: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v61,
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
                Documents::US6::US6_1
            } else {
                let v84: () = {
                    v19();
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
                let v112: Option<i64> = patternInput_1.5.clone();
                let v111: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v110: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v109: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v108: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v107: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v127: string = Documents::method65(
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    v112.clone(),
                    Documents::method7(v107, v108, v109, v110, v111, v112),
                    Documents::method64(),
                    v1_1,
                    v2,
                    v3,
                    v0_1,
                );
                let v143: () = {
                    v19();
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
                let v167: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v166: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v188: () = {
                    Documents::closure9(v166.clone(), ());
                    ()
                };
                println!("{}", v127.clone());
                (v167.l0.get().clone())(v127);
                Documents::US6::US6_0(
                    v166,
                    v167,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure26(unitVar: (), v0_1: std::io::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method67() -> Func1<std::io::Error, std::string::String> {
            Func1::new(move |v: std::io::Error| Documents::closure26((), v))
        }
        pub fn closure27(unitVar: (), v0_1: std::fs::FileType) -> Documents::US12 {
            Documents::US12::US12_0(v0_1)
        }
        pub fn method68() -> Func1<std::fs::FileType, Documents::US12> {
            Func1::new(move |v: std::fs::FileType| Documents::closure27((), v))
        }
        pub fn closure28(unitVar: (), v0_1: std::string::String) -> Documents::US12 {
            Documents::US12::US12_1(v0_1)
        }
        pub fn method69() -> Func1<std::string::String, Documents::US12> {
            Func1::new(move |v: std::string::String| Documents::closure28((), v))
        }
        pub fn closure25(
            unitVar: (),
            v0_1: async_walkdir::DirEntry,
        ) -> std::pin::Pin<Box<dyn std::future::Future<Output = async_walkdir::Filtering> + Send>>
        {
            let v2: bool = true;
            let __future_init = Box::pin(
                /*;
                let v4: bool = */
                async {
                    /*;
                    let v6: bool = */
                    ();
                    let v8: bool = true;
                    let __future_init = Box::pin(
                        /*;
                        let v10: bool = */
                        async move {
                            /*;
                            let v12: bool = */
                            ();
                            let v14: async_walkdir::DirEntry = v0_1.clone();
                            let v16: std::pin::Pin<
                                Box<
                                    dyn std::future::Future<
                                            Output = Result<std::fs::FileType, std::io::Error>,
                                        > + Send,
                                >,
                            > = Box::pin(async_walkdir::DirEntry::file_type(&v14));
                            let v18: Result<std::fs::FileType, std::io::Error> = v16.await;
                            let v19 = Documents::method67();
                            let v32: Result<std::fs::FileType, std::string::String> =
                                v18.map_err(|x| v19(x));
                            let v35 = Documents::method68();
                            let v36 = Documents::method69();
                            let v38: Documents::US12 = match &v32 {
                                Err(v32_1_0) => v36(v32_1_0.clone()),
                                Ok(v32_0_0) => v35(v32_0_0.clone()),
                            };
                            let v232: Documents::US13 = if let Documents::US12::US12_0(v38_0_0) =
                                &v38
                            {
                                if std::fs::FileType::is_dir(&v38_0_0.clone()) {
                                    Documents::US13::US13_0
                                } else {
                                    let v46: std::path::PathBuf =
                                        async_walkdir::DirEntry::path(&v0_1.clone());
                                    let v53: std::path::Display = v46.display();
                                    let v89: std::string::String = format!("{}", v53);
                                    let v120: string = fable_library_rust::String_::fromString(v89);
                                    if if (endsWith3(v120.clone(), string(".md"), false)) == false {
                                        true
                                    } else {
                                        endsWith3(v120, string(".hangul.md"), false)
                                    } {
                                        Documents::US13::US13_0
                                    } else {
                                        Documents::US13::US13_2
                                    }
                                }
                            } else {
                                let v140: std::path::PathBuf = async_walkdir::DirEntry::path(&v0_1);
                                let v147: std::path::Display = v140.display();
                                let v183: std::string::String = format!("{}", v147);
                                let v214: string = fable_library_rust::String_::fromString(v183);
                                if if (endsWith3(v214.clone(), string(".md"), false)) == false {
                                    true
                                } else {
                                    endsWith3(v214, string(".hangul.md"), false)
                                } {
                                    Documents::US13::US13_0
                                } else {
                                    Documents::US13::US13_2
                                }
                            };
                            let v235: string = string("}");
                            let v240: bool = true;
                            let _fix_closure_v237 = v232;
                            let v246: string = append(
                                (append(
                                    (append(
                                        (append(string("true; _fix_closure_v237 "), (v235))),
                                        string("); "),
                                    )),
                                    string(""),
                                )),
                                string(" // rust.fix_closure\'"),
                            );
                            let v247: bool = true;
                            _fix_closure_v237
                        },
                    ); // rust.fix_closure';
                    let v249 = __future_init;
                    let v251: std::pin::Pin<
                        Box<dyn std::future::Future<Output = Documents::US13> + Send>,
                    > = v249;
                    let v253: Documents::US13 = v251.await;
                    let v262: async_walkdir::Filtering = match &v253 {
                        Documents::US13::US13_0 => async_walkdir::Filtering::Ignore,
                        Documents::US13::US13_1 => async_walkdir::Filtering::IgnoreDir,
                        _ => async_walkdir::Filtering::Continue,
                    };
                    let v263: string = string("}");
                    let v268: bool = true;
                    let _fix_closure_v265 = v262;
                    let v274: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v265 "), (v263))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v275: bool = true;
                    _fix_closure_v265
                },
            ); // rust.fix_closure';
            let v277 = __future_init;
            v277
        }
        pub fn closure30(unitVar: (), v0_1: async_walkdir::Error) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method71() -> Func1<async_walkdir::Error, std::string::String> {
            Func1::new(move |v: async_walkdir::Error| Documents::closure30((), v))
        }
        pub fn closure31(unitVar: (), v0_1: async_walkdir::DirEntry) -> Documents::US14 {
            Documents::US14::US14_0(v0_1)
        }
        pub fn method72() -> Func1<async_walkdir::DirEntry, Documents::US14> {
            Func1::new(move |v: async_walkdir::DirEntry| Documents::closure31((), v))
        }
        pub fn closure32(unitVar: (), v0_1: std::string::String) -> Documents::US14 {
            Documents::US14::US14_1(v0_1)
        }
        pub fn method73() -> Func1<std::string::String, Documents::US14> {
            Func1::new(move |v: std::string::String| Documents::closure32((), v))
        }
        pub fn method74() -> string {
            let v8: string = Documents::method12(getCharAt(toLower(string("Critical")), 0_i32));
            let v27: &str = inline_colorization::color_bright_red;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method76(v0_1: std::string::String) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("error"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v66: std::string::String = format!("{:#?}", v0_1);
            let v113: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v66), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method75(
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
            let v9: string = Documents::method76(v8);
            Documents::method17(append(
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
        pub fn closure33(v0_1: std::string::String, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v298: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v58,
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
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
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
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v124: string = Documents::method75(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method74(),
                    v0_1,
                );
                let v140: () = {
                    v16();
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
                let v164: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v163: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v185: () = {
                    Documents::closure9(v163.clone(), ());
                    ()
                };
                println!("{}", v124.clone());
                (v164.l0.get().clone())(v124);
                Documents::US6::US6_0(
                    v163,
                    v164,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure29(
            unitVar: (),
            v0_1: Result<async_walkdir::DirEntry, async_walkdir::Error>,
        ) -> Option<string> {
            let v1_1 = Documents::method71();
            let v14: Result<async_walkdir::DirEntry, std::string::String> =
                v0_1.map_err(|x| v1_1(x));
            let v17 = Documents::method72();
            let v18 = Documents::method73();
            let v20: Documents::US14 = match &v14 {
                Err(v14_1_0) => v18(v14_1_0.clone()),
                Ok(v14_0_0) => v17(v14_0_0.clone()),
            };
            let v732: Documents::US5 = match &v20 {
                Documents::US14::US14_0(v20_0_0) => {
                    let v25: std::path::PathBuf = async_walkdir::DirEntry::path(&v20_0_0.clone());
                    let v32: std::path::Display = v25.display();
                    let v68: std::string::String = format!("{}", v32);
                    Documents::US5::US5_0(fable_library_rust::String_::fromString(v68))
                }
                Documents::US14::US14_1(v20_1_0) => {
                    let v415: () = {
                        Documents::closure33(v20_1_0.clone(), ());
                        ()
                    };
                    Documents::US5::US5_1
                }
            };
            match &v732 {
                Documents::US5::US5_0(v732_0_0) => Some(
                    match &v732 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<string>,
            }
        }
        pub fn method70()
        -> Func1<Result<async_walkdir::DirEntry, async_walkdir::Error>, Option<string>> {
            Func1::new(
                move |v: Result<async_walkdir::DirEntry, async_walkdir::Error>| {
                    Documents::closure29((), v)
                },
            )
        }
        pub fn method78(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("files_len"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v66: std::string::String = format!("{:#?}", v0_1);
            let v113: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v66), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method77(
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
            let v9: string = Documents::method78(v8);
            Documents::method17(append(
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
        pub fn closure34(v0_1: Vec<string>, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v58,
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
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
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
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method77(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method64(),
                    v0_1.len(),
                );
                let v142: () = {
                    v16();
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
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method79() -> string {
            string("")
        }
        pub fn method80(v0_1: string) -> string {
            Documents::method36(Documents::method59(v0_1))
        }
        pub fn method82(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> string {
            v0_1
        }
        pub fn method84() -> string {
            string("")
        }
        pub fn method85(v0_1: i64, v1_1: string, v2: i64) -> LrcPtr<Documents::UH0> {
            if (v2) < (v0_1) {
                LrcPtr::new(Documents::UH0::UH0_1(
                    getCharAt(v1_1.clone(), v2 as i32),
                    Documents::method85(v0_1, v1_1, (v2) + 1_i64),
                ))
            } else {
                LrcPtr::new(Documents::UH0::UH0_0)
            }
        }
        pub fn method86(
            v0_1: LrcPtr<Documents::UH0>,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
        ) -> (LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<LrcPtr<Documents::UH0>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            '_method86: loop {
                break '_method86 (match v0_1.get().clone().as_ref() {
                    Documents::UH0::UH0_0 => {
                        (v1_1.get().clone(), v2.get().clone(), v3.get().clone())
                    }
                    Documents::UH0::UH0_1(v0_1_1_0, v0_1_1_1) => {
                        let v4: char = match v0_1.get().clone().as_ref() {
                            Documents::UH0::UH0_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        };
                        let v6: bool = '\n' == (v4);
                        let patternInput: (i32, i32) = if v6 {
                            ((v2.get().clone()) + 1_i32, 1_i32)
                        } else {
                            (v2.get().clone(), (v3.get().clone()) + 1_i32)
                        };
                        {
                            let v0_1_temp: LrcPtr<Documents::UH0> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH0::UH0_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v1_1_temp: LrcPtr<StringBuilder> = if v6 {
                                let v13: LrcPtr<StringBuilder> = v1_1.get().clone().Clear();
                                v1_1.get().clone()
                            } else {
                                let v24: LrcPtr<StringBuilder> = {
                                    let value: string = ofChar(v4);
                                    v1_1.get().clone().Append_Z721C83C5(value)
                                };
                                v1_1.get().clone()
                            };
                            let v2_temp: i32 = patternInput.0.clone();
                            let v3_temp: i32 = patternInput.1.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            continue '_method86;
                        }
                    }
                });
            }
        }
        pub fn closure37(v0_1: i32, v1_1: i32, v2: string) -> string {
            if (v1_1) >= (v0_1) {
                v2.clone()
            } else {
                (Documents::method87(v0_1, (v1_1) + 1_i32))(append((v2), string(" ")))
            }
        }
        pub fn method87(v0_1: i32, v1_1: i32) -> Func1<string, string> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                move |v: string| Documents::closure37(v0_1, v1_1, v)
            })
        }
        pub fn closure36(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Documents::US16::US16_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\"',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '\"' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method86(
                        Documents::method85(length(v51.clone()) as i64, v51, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US16::US16_0(
                        v10,
                        v45,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v66: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US16::US16_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\"',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v66) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v66) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method87((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            }
        }
        pub fn closure38(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US16 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            if string("") == (v0_1.clone()) {
                Documents::US16::US16_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\'',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '\'' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method86(
                        Documents::method85(length(v51.clone()) as i64, v51, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US16::US16_0(
                        v10,
                        v45,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v66: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US16::US16_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\'',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v66) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v66) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method87((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            }
        }
        pub fn method88(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: LrcPtr<Documents::UH1>,
        ) -> Documents::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v2.clone());
            '_method88: loop {
                break '_method88 (match v2.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US16::US16_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v2_1_0, v2_1_1) => {
                        let v7: Documents::US16 = (match v2.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            1_i32,
                            1_i32,
                        ));
                        match &v7 {
                            Documents::US16::US16_0(v7_0_0, v7_0_1, v7_0_2, v7_0_3, v7_0_4) => {
                                v7.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: LrcPtr<Documents::UH1> =
                                    match v2.get().clone().as_ref() {
                                        Documents::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                continue '_method88;
                            }
                        }
                    }
                });
            }
        }
        pub fn method89(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method89: loop {
                break '_method89 (if (v1_1.get().clone()) >= 2_i64 {
                    false
                } else {
                    let v11: Documents::US18 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US18::US18_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US18::US18_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            Documents::US18::US18_1
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v11 {
                            Documents::US18::US18_0(v11_0_0) => match &v11 {
                                Documents::US18::US18_0(x) => x.clone(),
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
                        continue '_method89;
                    }
                });
            }
        }
        pub fn method90(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method90: loop {
                break '_method90 ({
                    let v98: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v25: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method89(v25, 0_i64)) == false {
                            let v62: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v68: string = ofChar(v25);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method86(
                                    Documents::method85(length(v68.clone()) as i64, v68, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v25,
                                v62,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v25,
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v110: Documents::US16 = match &v98 {
                        Documents::US16::US16_0(v98_0_0, v98_0_1, v98_0_2, v98_0_3, v98_0_4) => {
                            let v99: char = v98_0_0.clone();
                            Documents::US16::US16_0(
                                if '\\' == (v99) { '/' } else { v99 },
                                v98_0_1.clone(),
                                v98_0_2.clone(),
                                v98_0_3.clone(),
                                v98_0_4.clone(),
                            )
                        }
                        Documents::US16::US16_1(v98_1_0) => {
                            Documents::US16::US16_1(v98_1_0.clone())
                        }
                    };
                    match &v110 {
                        Documents::US16::US16_0(
                            v110_0_0,
                            v110_0_1,
                            v110_0_2,
                            v110_0_3,
                            v110_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v110_0_0.clone())));
                            let v1_1_temp: string = v110_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v110_0_2.clone();
                            let v3_temp: i32 = v110_0_3.clone();
                            let v4_temp: i32 = v110_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method90;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method91(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH1>,
        ) -> Documents::US16 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH1>> = MutCell::new(v4.clone());
            '_method91: loop {
                break '_method91 (match v4.get().clone().as_ref() {
                    Documents::UH1::UH1_0 => {
                        Documents::US16::US16_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH1::UH1_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US16 = (match v4.get().clone().as_ref() {
                            Documents::UH1::UH1_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US16::US16_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
                                v9.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Documents::UH1> =
                                    match v4.get().clone().as_ref() {
                                        Documents::UH1::UH1_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method91;
                            }
                        }
                    }
                });
            }
        }
        pub fn method92(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method92: loop {
                break '_method92 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US18 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US18::US18_0('\"')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US18::US18_0('\'')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US18::US18_0(' ')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US18::US18_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US18::US18_0(v15_0_0) => match &v15 {
                                Documents::US18::US18_0(x) => x.clone(),
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
                        continue '_method92;
                    }
                });
            }
        }
        pub fn method93(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method93: loop {
                break '_method93 ({
                    let v106: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method92(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method86(
                                    Documents::method85(length(v72.clone()) as i64, v72, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v29,
                                v66,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v29,
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v118: Documents::US16 = match &v106 {
                        Documents::US16::US16_0(
                            v106_0_0,
                            v106_0_1,
                            v106_0_2,
                            v106_0_3,
                            v106_0_4,
                        ) => {
                            let v107: char = v106_0_0.clone();
                            Documents::US16::US16_0(
                                if '\\' == (v107) { '/' } else { v107 },
                                v106_0_1.clone(),
                                v106_0_2.clone(),
                                v106_0_3.clone(),
                                v106_0_4.clone(),
                            )
                        }
                        Documents::US16::US16_1(v106_1_0) => {
                            Documents::US16::US16_1(v106_1_0.clone())
                        }
                    };
                    match &v118 {
                        Documents::US16::US16_0(
                            v118_0_0,
                            v118_0_1,
                            v118_0_2,
                            v118_0_3,
                            v118_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v118_0_0.clone())));
                            let v1_1_temp: string = v118_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v118_0_2.clone();
                            let v3_temp: i32 = v118_0_3.clone();
                            let v4_temp: i32 = v118_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method93;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method94(v0_1: string, v1_1: i32) -> i32 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<i32> = MutCell::new(v1_1);
            '_method94: loop {
                break '_method94 (if (v1_1.get().clone()) >= (length(v0_1.get().clone())) {
                    v1_1.get().clone()
                } else {
                    if ' ' == (getCharAt(v0_1.get().clone(), v1_1.get().clone())) {
                        let v0_1_temp: string = v0_1.get().clone();
                        let v1_1_temp: i32 = (v1_1.get().clone()) + 1_i32;
                        v0_1.set(v0_1_temp);
                        v1_1.set(v1_1_temp);
                        continue '_method94;
                    } else {
                        v1_1.get().clone()
                    }
                });
            }
        }
        pub fn method95(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method95: loop {
                break '_method95 ({
                    let v66: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v16: char = getCharAt(v1_1.get().clone(), 0_i32);
                        let v50: string = getSlice(
                            v1_1.get().clone(),
                            Some(1_i32),
                            Some((length(v1_1.get().clone())) - 1_i32),
                        );
                        let v56: string = ofChar(v16);
                        let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method86(
                            Documents::method85(length(v56.clone()) as i64, v56, 0_i64),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        );
                        Documents::US16::US16_0(
                            v16,
                            v50,
                            patternInput.0.clone(),
                            patternInput.1.clone(),
                            patternInput.2.clone(),
                        )
                    };
                    match &v66 {
                        Documents::US16::US16_0(v66_0_0, v66_0_1, v66_0_2, v66_0_3, v66_0_4) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v66_0_0.clone())));
                            let v1_1_temp: string = v66_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v66_0_2.clone();
                            let v3_temp: i32 = v66_0_3.clone();
                            let v4_temp: i32 = v66_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method95;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method83(v0_1: string) -> Documents::US15 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v10: string = defaultValue(
                    string(""),
                    match &_v0.get().clone() {
                        None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                        Some(_v0_0_0) => _v0_0_0.clone(),
                    },
                );
                let v16: LrcPtr<StringBuilder> =
                    StringBuilder::_ctor__Z721C83C5(Documents::method84());
                fn v19(arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US16 {
                    Documents::closure36((), arg10_0040)
                }
                fn v20(arg10_0040_1: (string, LrcPtr<StringBuilder>, i32, i32)) -> Documents::US16 {
                    Documents::closure38((), arg10_0040_1)
                }
                let v24: Documents::US16 = Documents::method88(
                    v10.clone(),
                    v16.clone(),
                    LrcPtr::new(Documents::UH1::UH1_1(
                        Func1::from(v19),
                        LrcPtr::new(Documents::UH1::UH1_1(
                            Func1::from(v20),
                            LrcPtr::new(Documents::UH1::UH1_0),
                        )),
                    )),
                );
                let v197: Documents::US17 = match &v24 {
                    Documents::US16::US16_0(v24_0_0, v24_0_1, v24_0_2, v24_0_3, v24_0_4) => {
                        let v29: i32 = v24_0_4.clone();
                        let v28: i32 = v24_0_3.clone();
                        let v27: LrcPtr<StringBuilder> = v24_0_2.clone();
                        let v26: string = v24_0_1.clone();
                        let v123: Documents::US16 = if string("") == (v26.clone()) {
                            Documents::US16::US16_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'']))),
                                (v27.clone(), v28, v29)
                            ))
                        } else {
                            let v50: char = getCharAt(v26.clone(), 0_i32);
                            if (Documents::method89(v50, 0_i64)) == false {
                                let v87: string = getSlice(
                                    v26.clone(),
                                    Some(1_i32),
                                    Some((length(v26.clone())) - 1_i32),
                                );
                                let v93: string = ofChar(v50);
                                let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method86(
                                        Documents::method85(length(v93.clone()) as i64, v93, 0_i64),
                                        v27.clone(),
                                        v28,
                                        v29,
                                    );
                                Documents::US16::US16_0(
                                    v50,
                                    v87,
                                    patternInput.0.clone(),
                                    patternInput.1.clone(),
                                    patternInput.2.clone(),
                                )
                            } else {
                                Documents::US16::US16_1(sprintf!(
                                    "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                    v50,
                                    toArray(ofArray(new_array(&['\"', '\'']))),
                                    (v27.clone(), v28, v29)
                                ))
                            }
                        };
                        let v135: Documents::US16 = match &v123 {
                            Documents::US16::US16_0(
                                v123_0_0,
                                v123_0_1,
                                v123_0_2,
                                v123_0_3,
                                v123_0_4,
                            ) => {
                                let v124: char = v123_0_0.clone();
                                Documents::US16::US16_0(
                                    if '\\' == (v124) { '/' } else { v124 },
                                    v123_0_1.clone(),
                                    v123_0_2.clone(),
                                    v123_0_3.clone(),
                                    v123_0_4.clone(),
                                )
                            }
                            Documents::US16::US16_1(v123_1_0) => {
                                Documents::US16::US16_1(v123_1_0.clone())
                            }
                        };
                        let v155: Documents::US17 = match &v135 {
                            Documents::US16::US16_0(
                                v135_0_0,
                                v135_0_1,
                                v135_0_2,
                                v135_0_3,
                                v135_0_4,
                            ) => {
                                let patternInput_1: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Documents::method90(
                                    ofChar(v135_0_0.clone()),
                                    v135_0_1.clone(),
                                    v135_0_2.clone(),
                                    v135_0_3.clone(),
                                    v135_0_4.clone(),
                                );
                                Documents::US17::US17_0(
                                    patternInput_1.0.clone(),
                                    patternInput_1.1.clone(),
                                    patternInput_1.2.clone(),
                                    patternInput_1.3.clone(),
                                    patternInput_1.4.clone(),
                                )
                            }
                            Documents::US16::US16_1(v135_1_0) => {
                                Documents::US17::US17_1(v135_1_0.clone())
                            }
                        };
                        let v165: Documents::US17 = match &v155 {
                            Documents::US17::US17_0(
                                v155_0_0,
                                v155_0_1,
                                v155_0_2,
                                v155_0_3,
                                v155_0_4,
                            ) => Documents::US17::US17_0(
                                v155_0_0.clone(),
                                v155_0_1.clone(),
                                v155_0_2.clone(),
                                v155_0_3.clone(),
                                v155_0_4.clone(),
                            ),
                            _ => Documents::US17::US17_0(
                                string(""),
                                v26.clone(),
                                v27.clone(),
                                v28,
                                v29,
                            ),
                        };
                        match &v165 {
                            Documents::US17::US17_0(
                                v165_0_0,
                                v165_0_1,
                                v165_0_2,
                                v165_0_3,
                                v165_0_4,
                            ) => {
                                let v170: i32 = v165_0_4.clone();
                                let v169: i32 = v165_0_3.clone();
                                let v168: LrcPtr<StringBuilder> = v165_0_2.clone();
                                let v167: string = v165_0_1.clone();
                                let v174: Documents::US16 = Documents::method91(
                                    v167.clone(),
                                    v168.clone(),
                                    v169,
                                    v170,
                                    LrcPtr::new(Documents::UH1::UH1_1(
                                        Func1::from(v19),
                                        LrcPtr::new(Documents::UH1::UH1_1(
                                            Func1::from(v20),
                                            LrcPtr::new(Documents::UH1::UH1_0),
                                        )),
                                    )),
                                );
                                match &v174 {
                                    Documents::US16::US16_0(
                                        v174_0_0,
                                        v174_0_1,
                                        v174_0_2,
                                        v174_0_3,
                                        v174_0_4,
                                    ) => Documents::US17::US17_0(
                                        v165_0_0.clone(),
                                        v174_0_1.clone(),
                                        v174_0_2.clone(),
                                        v174_0_3.clone(),
                                        v174_0_4.clone(),
                                    ),
                                    Documents::US16::US16_1(v174_1_0) => {
                                        Documents::US17::US17_1(sprintf!(
                                            "parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                            v174_1_0.clone(),
                                            (v10.clone(), v16.clone(), 1_i32, 1_i32),
                                            (v26.clone(), v27.clone(), v28, v29),
                                            (v167.clone(), v168.clone(), v169, v170)
                                        ))
                                    }
                                }
                            }
                            _ => Documents::US17::US17_1(string(
                                "parsing.between / expected content",
                            )),
                        }
                    }
                    Documents::US16::US16_1(v24_1_0) => Documents::US17::US17_1(v24_1_0.clone()),
                };
                let v416: Documents::US17 = match &v197 {
                    Documents::US17::US17_0(v197_0_0, v197_0_1, v197_0_2, v197_0_3, v197_0_4) => {
                        v197.clone()
                    }
                    _ => {
                        let v307: Documents::US16 = if string("") == (v10.clone()) {
                            Documents::US16::US16_1(sprintf!(
                                "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                                toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                (v16.clone(), 1_i32, 1_i32)
                            ))
                        } else {
                            let v228: char = getCharAt(v10.clone(), 0_i32);
                            if (Documents::method92(v228, 0_i64)) == false {
                                let v265: string = getSlice(
                                    v10.clone(),
                                    Some(1_i32),
                                    Some((length(v10.clone())) - 1_i32),
                                );
                                let v271: string = ofChar(v228);
                                let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method86(
                                        Documents::method85(
                                            length(v271.clone()) as i64,
                                            v271,
                                            0_i64,
                                        ),
                                        v16.clone(),
                                        1_i32,
                                        1_i32,
                                    );
                                Documents::US16::US16_0(
                                    v228,
                                    v265,
                                    patternInput_2.0.clone(),
                                    patternInput_2.1.clone(),
                                    patternInput_2.2.clone(),
                                )
                            } else {
                                Documents::US16::US16_1(sprintf!(
                                    "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                    v228,
                                    toArray(ofArray(new_array(&['\"', '\'', ' ']))),
                                    (v16.clone(), 1_i32, 1_i32)
                                ))
                            }
                        };
                        let v319: Documents::US16 = match &v307 {
                            Documents::US16::US16_0(
                                v307_0_0,
                                v307_0_1,
                                v307_0_2,
                                v307_0_3,
                                v307_0_4,
                            ) => {
                                let v308: char = v307_0_0.clone();
                                Documents::US16::US16_0(
                                    if '\\' == (v308) { '/' } else { v308 },
                                    v307_0_1.clone(),
                                    v307_0_2.clone(),
                                    v307_0_3.clone(),
                                    v307_0_4.clone(),
                                )
                            }
                            Documents::US16::US16_1(v307_1_0) => {
                                Documents::US16::US16_1(v307_1_0.clone())
                            }
                        };
                        let v339: Documents::US17 = match &v319 {
                            Documents::US16::US16_0(
                                v319_0_0,
                                v319_0_1,
                                v319_0_2,
                                v319_0_3,
                                v319_0_4,
                            ) => {
                                let patternInput_3: (
                                    string,
                                    string,
                                    LrcPtr<StringBuilder>,
                                    i32,
                                    i32,
                                ) = Documents::method93(
                                    ofChar(v319_0_0.clone()),
                                    v319_0_1.clone(),
                                    v319_0_2.clone(),
                                    v319_0_3.clone(),
                                    v319_0_4.clone(),
                                );
                                Documents::US17::US17_0(
                                    patternInput_3.0.clone(),
                                    patternInput_3.1.clone(),
                                    patternInput_3.2.clone(),
                                    patternInput_3.3.clone(),
                                    patternInput_3.4.clone(),
                                )
                            }
                            Documents::US16::US16_1(v319_1_0) => {
                                Documents::US17::US17_1(v319_1_0.clone())
                            }
                        };
                        match &v339 {
                            Documents::US17::US17_0(
                                v339_0_0,
                                v339_0_1,
                                v339_0_2,
                                v339_0_3,
                                v339_0_4,
                            ) => v339.clone(),
                            _ => {
                                let v354: Documents::US19 = if (length(v10.clone())) == 0_i32 {
                                    Documents::US19::US19_0(v10.clone(), v16.clone(), 1_i32, 1_i32)
                                } else {
                                    Documents::US19::US19_1(sprintf!(
                                        "parsing.eof / expected end of input / input: {:?}",
                                        v10.clone()
                                    ))
                                };
                                let v363: Documents::US17 = match &v354 {
                                    Documents::US19::US19_0(
                                        v354_0_0,
                                        v354_0_1,
                                        v354_0_2,
                                        v354_0_3,
                                    ) => Documents::US17::US17_0(
                                        string(""),
                                        v354_0_0.clone(),
                                        v354_0_1.clone(),
                                        v354_0_2.clone(),
                                        v354_0_3.clone(),
                                    ),
                                    Documents::US19::US19_1(v354_1_0) => {
                                        Documents::US17::US17_1(v354_1_0.clone())
                                    }
                                };
                                match &v363 {
                                    Documents::US17::US17_0(
                                        v363_0_0,
                                        v363_0_1,
                                        v363_0_2,
                                        v363_0_3,
                                        v363_0_4,
                                    ) => {
                                        let v365: string = v363_0_1.clone();
                                        Documents::US17::US17_0(
                                            v363_0_0.clone(),
                                            getSlice(
                                                v365.clone(),
                                                Some(Documents::method94(v365.clone(), 0_i32)),
                                                Some((length(v365)) - 1_i32),
                                            ),
                                            v363_0_2.clone(),
                                            v363_0_3.clone(),
                                            v363_0_4.clone(),
                                        )
                                    }
                                    Documents::US17::US17_1(v363_1_0) => {
                                        Documents::US17::US17_1(v363_1_0.clone())
                                    }
                                }
                            }
                        }
                    }
                };
                let v671: Documents::US20 = match &v416 {
                    Documents::US17::US17_0(v416_0_0, v416_0_1, v416_0_2, v416_0_3, v416_0_4) => {
                        let v421: i32 = v416_0_4.clone();
                        let v420: i32 = v416_0_3.clone();
                        let v419: LrcPtr<StringBuilder> = v416_0_2.clone();
                        let v418: string = v416_0_1.clone();
                        let v542: Documents::US16 = if string("") == (v418.clone()) {
                            Documents::US16::US16_1(sprintf!(
                                "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                ' ',
                                (v419.clone(), v420, v421)
                            ))
                        } else {
                            let v428: char = getCharAt(v418.clone(), 0_i32);
                            if (v428) == ' ' {
                                let v463: string = getSlice(
                                    v418.clone(),
                                    Some(1_i32),
                                    Some((length(v418.clone())) - 1_i32),
                                );
                                let v469: string = ofChar(v428);
                                let patternInput_4: (LrcPtr<StringBuilder>, i32, i32) =
                                    Documents::method86(
                                        Documents::method85(
                                            length(v469.clone()) as i64,
                                            v469,
                                            0_i64,
                                        ),
                                        v419.clone(),
                                        v420,
                                        v421,
                                    );
                                Documents::US16::US16_0(
                                    v428,
                                    v463,
                                    patternInput_4.0.clone(),
                                    patternInput_4.1.clone(),
                                    patternInput_4.2.clone(),
                                )
                            } else {
                                let v484: i32 = (indexOf(v418.clone(), string("\n"))) - 1_i32;
                                Documents::US16::US16_1(concat(new_array(&[
                                    sprintf!(
                                        "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                        ' ',
                                        v420,
                                        v421,
                                        v419.clone(),
                                        getSlice(
                                            v418.clone(),
                                            Some(0_i32),
                                            Some(
                                                (if -2_i32 == (v484) {
                                                    (length(v418.clone())) + 1_i32
                                                } else {
                                                    (v484) + 1_i32
                                                }) - 1_i32
                                            )
                                        )
                                    ),
                                    string("\n"),
                                    append(
                                        ((Documents::method87((v421) - 1_i32, 0_i32))(string(""))),
                                        string("^"),
                                    ),
                                    string("\n"),
                                ])))
                            }
                        };
                        let v554: Documents::US21 = match &v542 {
                            Documents::US16::US16_0(
                                v542_0_0,
                                v542_0_1,
                                v542_0_2,
                                v542_0_3,
                                v542_0_4,
                            ) => Documents::US21::US21_0(
                                Documents::US18::US18_0(v542_0_0.clone()),
                                v542_0_1.clone(),
                                v542_0_2.clone(),
                                v542_0_3.clone(),
                                v542_0_4.clone(),
                            ),
                            _ => Documents::US21::US21_0(
                                Documents::US18::US18_1,
                                v418.clone(),
                                v419.clone(),
                                v420,
                                v421,
                            ),
                        };
                        let v645: Documents::US17 = match &v554 {
                            Documents::US21::US21_0(
                                v554_0_0,
                                v554_0_1,
                                v554_0_2,
                                v554_0_3,
                                v554_0_4,
                            ) => {
                                let v559: i32 = v554_0_4.clone();
                                let v558: i32 = v554_0_3.clone();
                                let v557: LrcPtr<StringBuilder> = v554_0_2.clone();
                                let v556: string = v554_0_1.clone();
                                let v621: Documents::US16 = if string("") == (v556.clone()) {
                                    Documents::US16::US16_1(sprintf!(
                                        "parsing.any_char / unexpected end of input / s: {:?}",
                                        (v557.clone(), v558, v559)
                                    ))
                                } else {
                                    let v571: char = getCharAt(v556.clone(), 0_i32);
                                    let v605: string = getSlice(
                                        v556.clone(),
                                        Some(1_i32),
                                        Some((length(v556)) - 1_i32),
                                    );
                                    let v611: string = ofChar(v571);
                                    let patternInput_5: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method86(
                                            Documents::method85(
                                                length(v611.clone()) as i64,
                                                v611,
                                                0_i64,
                                            ),
                                            v557,
                                            v558,
                                            v559,
                                        );
                                    Documents::US16::US16_0(
                                        v571,
                                        v605,
                                        patternInput_5.0.clone(),
                                        patternInput_5.1.clone(),
                                        patternInput_5.2.clone(),
                                    )
                                };
                                match &v621 {
                                    Documents::US16::US16_0(
                                        v621_0_0,
                                        v621_0_1,
                                        v621_0_2,
                                        v621_0_3,
                                        v621_0_4,
                                    ) => {
                                        let patternInput_6: (
                                            string,
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        ) = Documents::method95(
                                            ofChar(v621_0_0.clone()),
                                            v621_0_1.clone(),
                                            v621_0_2.clone(),
                                            v621_0_3.clone(),
                                            v621_0_4.clone(),
                                        );
                                        Documents::US17::US17_0(
                                            patternInput_6.0.clone(),
                                            patternInput_6.1.clone(),
                                            patternInput_6.2.clone(),
                                            patternInput_6.3.clone(),
                                            patternInput_6.4.clone(),
                                        )
                                    }
                                    Documents::US16::US16_1(v621_1_0) => {
                                        Documents::US17::US17_1(v621_1_0.clone())
                                    }
                                }
                            }
                            Documents::US21::US21_1(v554_1_0) => {
                                Documents::US17::US17_1(v554_1_0.clone())
                            }
                        };
                        let v657: Documents::US22 = match &v645 {
                            Documents::US17::US17_0(
                                v645_0_0,
                                v645_0_1,
                                v645_0_2,
                                v645_0_3,
                                v645_0_4,
                            ) => Documents::US22::US22_0(
                                Documents::US5::US5_0(v645_0_0.clone()),
                                v645_0_1.clone(),
                                v645_0_2.clone(),
                                v645_0_3.clone(),
                                v645_0_4.clone(),
                            ),
                            _ => Documents::US22::US22_0(
                                Documents::US5::US5_1,
                                v418.clone(),
                                v419.clone(),
                                v420,
                                v421,
                            ),
                        };
                        match &v657 {
                            Documents::US22::US22_0(
                                v657_0_0,
                                v657_0_1,
                                v657_0_2,
                                v657_0_3,
                                v657_0_4,
                            ) => Documents::US20::US20_0(
                                v416_0_0.clone(),
                                v657_0_0.clone(),
                                v657_0_1.clone(),
                                v657_0_2.clone(),
                                v657_0_3.clone(),
                                v657_0_4.clone(),
                            ),
                            Documents::US22::US22_1(v657_1_0) => {
                                Documents::US20::US20_1(v657_1_0.clone())
                            }
                        }
                    }
                    Documents::US17::US17_1(v416_1_0) => Documents::US20::US20_1(v416_1_0.clone()),
                };
                match &v671 {
                    Documents::US20::US20_0(
                        v671_0_0,
                        v671_0_1,
                        v671_0_2,
                        v671_0_3,
                        v671_0_4,
                        v671_0_5,
                    ) => Documents::US15::US15_0(v671_0_0.clone(), v671_0_1.clone()),
                    Documents::US20::US20_1(v671_1_0) => Documents::US15::US15_1(v671_1_0.clone()),
                }
            }
        }
        pub fn method98(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method98: loop {
                break '_method98 (if (v1_1.get().clone()) >= 4_i64 {
                    false
                } else {
                    let v19: Documents::US18 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US18::US18_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US18::US18_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US18::US18_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                if (v11) == 0_i64 {
                                    Documents::US18::US18_0(' ')
                                } else {
                                    let v14: i64 = (v11) - 1_i64;
                                    Documents::US18::US18_1
                                }
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v19 {
                            Documents::US18::US18_0(v19_0_0) => match &v19 {
                                Documents::US18::US18_0(x) => x.clone(),
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
                        continue '_method98;
                    }
                });
            }
        }
        pub fn method99(
            v0_1: string,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> (string, string, LrcPtr<StringBuilder>, i32, i32) {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method99: loop {
                break '_method99 ({
                    let v114: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v33: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method98(v33, 0_i64)) == false {
                            let v70: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v76: string = ofChar(v33);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method86(
                                    Documents::method85(length(v76.clone()) as i64, v76, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v33,
                                v70,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v33,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    match &v114 {
                        Documents::US16::US16_0(
                            v114_0_0,
                            v114_0_1,
                            v114_0_2,
                            v114_0_3,
                            v114_0_4,
                        ) => {
                            let v0_1_temp: string =
                                append((v0_1.get().clone()), (ofChar(v114_0_0.clone())));
                            let v1_1_temp: string = v114_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v114_0_2.clone();
                            let v3_temp: i32 = v114_0_3.clone();
                            let v4_temp: i32 = v114_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method99;
                        }
                        _ => (
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method101(v0_1: char, v1_1: i64) -> bool {
            let v0_1: MutCell<char> = MutCell::new(v0_1);
            let v1_1: MutCell<i64> = MutCell::new(v1_1);
            '_method101: loop {
                break '_method101 (if (v1_1.get().clone()) >= 3_i64 {
                    false
                } else {
                    let v15: Documents::US18 = if (v1_1.get().clone()) == 0_i64 {
                        Documents::US18::US18_0('\\')
                    } else {
                        let v5: i64 = (v1_1.get().clone()) - 1_i64;
                        if (v5) == 0_i64 {
                            Documents::US18::US18_0('`')
                        } else {
                            let v8: i64 = (v5) - 1_i64;
                            if (v8) == 0_i64 {
                                Documents::US18::US18_0('\"')
                            } else {
                                let v11: i64 = (v8) - 1_i64;
                                Documents::US18::US18_1
                            }
                        }
                    };
                    if (v0_1.get().clone())
                        == (match &v15 {
                            Documents::US18::US18_0(v15_0_0) => match &v15 {
                                Documents::US18::US18_0(x) => x.clone(),
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
                        continue '_method101;
                    }
                });
            }
        }
        pub fn closure39(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US17 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v125: Documents::US16 = if string("") == (v0_1.clone()) {
                Documents::US16::US16_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '\\',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '\\' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method86(
                        Documents::method85(length(v51.clone()) as i64, v51, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US16::US16_0(
                        v10,
                        v45,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v66: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US16::US16_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '\\',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v66) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v66) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method87((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            };
            let v196: Documents::US16 = match &v125 {
                Documents::US16::US16_0(v125_0_0, v125_0_1, v125_0_2, v125_0_3, v125_0_4) => {
                    let v130: i32 = v125_0_4.clone();
                    let v129: i32 = v125_0_3.clone();
                    let v128: LrcPtr<StringBuilder> = v125_0_2.clone();
                    let v127: string = v125_0_1.clone();
                    if string("") == (v127.clone()) {
                        Documents::US16::US16_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v128.clone(), v129, v130)
                        ))
                    } else {
                        let v142: char = getCharAt(v127.clone(), 0_i32);
                        let v176: string =
                            getSlice(v127.clone(), Some(1_i32), Some((length(v127)) - 1_i32));
                        let v182: string = ofChar(v142);
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Documents::method86(
                            Documents::method85(length(v182.clone()) as i64, v182, 0_i64),
                            v128,
                            v129,
                            v130,
                        );
                        Documents::US16::US16_0(
                            v142,
                            v176,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
                Documents::US16::US16_1(v125_1_0) => Documents::US16::US16_1(v125_1_0.clone()),
            };
            match &v196 {
                Documents::US16::US16_0(v196_0_0, v196_0_1, v196_0_2, v196_0_3, v196_0_4) => {
                    Documents::US17::US17_0(
                        append((ofChar('\\')), (ofChar(v196_0_0.clone()))),
                        v196_0_1.clone(),
                        v196_0_2.clone(),
                        v196_0_3.clone(),
                        v196_0_4.clone(),
                    )
                }
                Documents::US16::US16_1(v196_1_0) => Documents::US17::US17_1(v196_1_0.clone()),
            }
        }
        pub fn closure40(
            unitVar: (),
            _arg: (string, LrcPtr<StringBuilder>, i32, i32),
        ) -> Documents::US17 {
            let v3: i32 = _arg.3.clone();
            let v2: i32 = _arg.2.clone();
            let v1_1: LrcPtr<StringBuilder> = _arg.1.clone();
            let v0_1: string = _arg.0.clone();
            let v125: Documents::US16 = if string("") == (v0_1.clone()) {
                Documents::US16::US16_1(sprintf!(
                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                    '`',
                    (v1_1.clone(), v2, v3)
                ))
            } else {
                let v10: char = getCharAt(v0_1.clone(), 0_i32);
                if (v10) == '`' {
                    let v45: string = getSlice(
                        v0_1.clone(),
                        Some(1_i32),
                        Some((length(v0_1.clone())) - 1_i32),
                    );
                    let v51: string = ofChar(v10);
                    let patternInput: (LrcPtr<StringBuilder>, i32, i32) = Documents::method86(
                        Documents::method85(length(v51.clone()) as i64, v51, 0_i64),
                        v1_1.clone(),
                        v2,
                        v3,
                    );
                    Documents::US16::US16_0(
                        v10,
                        v45,
                        patternInput.0.clone(),
                        patternInput.1.clone(),
                        patternInput.2.clone(),
                    )
                } else {
                    let v66: i32 = (indexOf(v0_1.clone(), string("\n"))) - 1_i32;
                    Documents::US16::US16_1(concat(new_array(&[
                        sprintf!(
                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                            '`',
                            v2,
                            v3,
                            v1_1,
                            getSlice(
                                v0_1.clone(),
                                Some(0_i32),
                                Some(
                                    (if -2_i32 == (v66) {
                                        (length(v0_1)) + 1_i32
                                    } else {
                                        (v66) + 1_i32
                                    }) - 1_i32
                                )
                            )
                        ),
                        string("\n"),
                        append(
                            ((Documents::method87((v3) - 1_i32, 0_i32))(string(""))),
                            string("^"),
                        ),
                        string("\n"),
                    ])))
                }
            };
            let v196: Documents::US16 = match &v125 {
                Documents::US16::US16_0(v125_0_0, v125_0_1, v125_0_2, v125_0_3, v125_0_4) => {
                    let v130: i32 = v125_0_4.clone();
                    let v129: i32 = v125_0_3.clone();
                    let v128: LrcPtr<StringBuilder> = v125_0_2.clone();
                    let v127: string = v125_0_1.clone();
                    if string("") == (v127.clone()) {
                        Documents::US16::US16_1(sprintf!(
                            "parsing.any_char / unexpected end of input / s: {:?}",
                            (v128.clone(), v129, v130)
                        ))
                    } else {
                        let v142: char = getCharAt(v127.clone(), 0_i32);
                        let v176: string =
                            getSlice(v127.clone(), Some(1_i32), Some((length(v127)) - 1_i32));
                        let v182: string = ofChar(v142);
                        let patternInput_1: (LrcPtr<StringBuilder>, i32, i32) = Documents::method86(
                            Documents::method85(length(v182.clone()) as i64, v182, 0_i64),
                            v128,
                            v129,
                            v130,
                        );
                        Documents::US16::US16_0(
                            v142,
                            v176,
                            patternInput_1.0.clone(),
                            patternInput_1.1.clone(),
                            patternInput_1.2.clone(),
                        )
                    }
                }
                Documents::US16::US16_1(v125_1_0) => Documents::US16::US16_1(v125_1_0.clone()),
            };
            match &v196 {
                Documents::US16::US16_0(v196_0_0, v196_0_1, v196_0_2, v196_0_3, v196_0_4) => {
                    Documents::US17::US17_0(
                        append((ofChar('`')), (ofChar(v196_0_0.clone()))),
                        v196_0_1.clone(),
                        v196_0_2.clone(),
                        v196_0_3.clone(),
                        v196_0_4.clone(),
                    )
                }
                Documents::US16::US16_1(v196_1_0) => Documents::US17::US17_1(v196_1_0.clone()),
            }
        }
        pub fn method102(
            v0_1: string,
            v1_1: LrcPtr<StringBuilder>,
            v2: i32,
            v3: i32,
            v4: LrcPtr<Documents::UH3>,
        ) -> Documents::US17 {
            let v0_1: MutCell<string> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v1_1.clone());
            let v2: MutCell<i32> = MutCell::new(v2);
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<LrcPtr<Documents::UH3>> = MutCell::new(v4.clone());
            '_method102: loop {
                break '_method102 (match v4.get().clone().as_ref() {
                    Documents::UH3::UH3_0 => {
                        Documents::US17::US17_1(string("parsing.choice / no parsers succeeded"))
                    }
                    Documents::UH3::UH3_1(v4_1_0, v4_1_1) => {
                        let v9: Documents::US17 = (match v4.get().clone().as_ref() {
                            Documents::UH3::UH3_1(x, _) => x.clone(),
                            _ => unreachable!(),
                        })((
                            v0_1.get().clone(),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                        ));
                        match &v9 {
                            Documents::US17::US17_0(v9_0_0, v9_0_1, v9_0_2, v9_0_3, v9_0_4) => {
                                v9.clone()
                            }
                            _ => {
                                let v0_1_temp: string = v0_1.get().clone();
                                let v1_1_temp: LrcPtr<StringBuilder> = v1_1.get().clone();
                                let v2_temp: i32 = v2.get().clone();
                                let v3_temp: i32 = v3.get().clone();
                                let v4_temp: LrcPtr<Documents::UH3> =
                                    match v4.get().clone().as_ref() {
                                        Documents::UH3::UH3_1(_, x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone();
                                v0_1.set(v0_1_temp);
                                v1_1.set(v1_1_temp);
                                v2.set(v2_temp);
                                v3.set(v3_temp);
                                v4.set(v4_temp);
                                continue '_method102;
                            }
                        }
                    }
                });
            }
        }
        pub fn method103(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: LrcPtr<Documents::UH2>,
        ) -> LrcPtr<Documents::UH2> {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v1_1.clone());
            '_method103: loop {
                break '_method103 (match v0_1.get().clone().as_ref() {
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
                        continue '_method103;
                    }
                });
            }
        }
        pub fn method100(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US24 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method100: loop {
                break '_method100 ({
                    let v106: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method101(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method86(
                                    Documents::method85(length(v72.clone()) as i64, v72, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v29,
                                v66,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v29,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v121: Documents::US17 = match &v106 {
                        Documents::US16::US16_0(
                            v106_0_0,
                            v106_0_1,
                            v106_0_2,
                            v106_0_3,
                            v106_0_4,
                        ) => Documents::US17::US17_0(
                            ofChar(v106_0_0.clone()),
                            v106_0_1.clone(),
                            v106_0_2.clone(),
                            v106_0_3.clone(),
                            v106_0_4.clone(),
                        ),
                        Documents::US16::US16_1(v106_1_0) => {
                            Documents::US17::US17_1(v106_1_0.clone())
                        }
                    };
                    let v135: Documents::US17 = match &v121 {
                        Documents::US17::US17_0(
                            v121_0_0,
                            v121_0_1,
                            v121_0_2,
                            v121_0_3,
                            v121_0_4,
                        ) => v121.clone(),
                        _ => Documents::method102(
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                            LrcPtr::new(Documents::UH3::UH3_1(
                                Func1::new(
                                    move |arg10_0040: (string, LrcPtr<StringBuilder>, i32, i32)| {
                                        Documents::closure39((), arg10_0040)
                                    },
                                ),
                                LrcPtr::new(Documents::UH3::UH3_1(
                                    Func1::new(
                                        move |arg10_0040_1: (
                                            string,
                                            LrcPtr<StringBuilder>,
                                            i32,
                                            i32,
                                        )| {
                                            Documents::closure40((), arg10_0040_1)
                                        },
                                    ),
                                    LrcPtr::new(Documents::UH3::UH3_0),
                                )),
                            )),
                        ),
                    };
                    match &v135 {
                        Documents::US17::US17_0(
                            v135_0_0,
                            v135_0_1,
                            v135_0_2,
                            v135_0_3,
                            v135_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v135_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v135_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v135_0_2.clone();
                            let v3_temp: i32 = v135_0_3.clone();
                            let v4_temp: i32 = v135_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method100;
                        }
                        _ => Documents::US24::US24_0(
                            Documents::method103(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method104(v0_1: LrcPtr<Documents::UH2>, v1_1: List<string>) -> List<string> {
            match v0_1.as_ref() {
                Documents::UH2::UH2_0 => v1_1.clone(),
                Documents::UH2::UH2_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH2::UH2_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method104(
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
        pub fn method105(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US24 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method105: loop {
                break '_method105 ({
                    let v106: Documents::US16 = if string("") == (v1_1.get().clone()) {
                        Documents::US16::US16_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v29: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method101(v29, 0_i64)) == false {
                            let v66: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v72: string = ofChar(v29);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method86(
                                    Documents::method85(length(v72.clone()) as i64, v72, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v29,
                                v66,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v29,
                                toArray(ofArray(new_array(&['\\', '`', '\"']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v121: Documents::US17 = match &v106 {
                        Documents::US16::US16_0(
                            v106_0_0,
                            v106_0_1,
                            v106_0_2,
                            v106_0_3,
                            v106_0_4,
                        ) => Documents::US17::US17_0(
                            ofChar(v106_0_0.clone()),
                            v106_0_1.clone(),
                            v106_0_2.clone(),
                            v106_0_3.clone(),
                            v106_0_4.clone(),
                        ),
                        Documents::US16::US16_1(v106_1_0) => {
                            Documents::US17::US17_1(v106_1_0.clone())
                        }
                    };
                    match &v121 {
                        Documents::US17::US17_0(
                            v121_0_0,
                            v121_0_1,
                            v121_0_2,
                            v121_0_3,
                            v121_0_4,
                        ) => {
                            let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                Documents::UH2::UH2_1(v121_0_0.clone(), v0_1.get().clone()),
                            );
                            let v1_1_temp: string = v121_0_1.clone();
                            let v2_temp: LrcPtr<StringBuilder> = v121_0_2.clone();
                            let v3_temp: i32 = v121_0_3.clone();
                            let v4_temp: i32 = v121_0_4.clone();
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            v2.set(v2_temp);
                            v3.set(v3_temp);
                            v4.set(v4_temp);
                            continue '_method105;
                        }
                        _ => Documents::US24::US24_0(
                            Documents::method103(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method97(
            v0_1: LrcPtr<Documents::UH2>,
            v1_1: string,
            v2: LrcPtr<StringBuilder>,
            v3: i32,
            v4: i32,
        ) -> Documents::US24 {
            let v0_1: MutCell<LrcPtr<Documents::UH2>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<string> = MutCell::new(v1_1.clone());
            let v2: MutCell<LrcPtr<StringBuilder>> = MutCell::new(v2.clone());
            let v3: MutCell<i32> = MutCell::new(v3);
            let v4: MutCell<i32> = MutCell::new(v4);
            '_method97: loop {
                break '_method97 ({
                    let v5: bool = string("") == (v1_1.get().clone());
                    let v114: Documents::US16 = if v5 {
                        Documents::US16::US16_1(sprintf!(
                            "parsing.none_of / unexpected end of input / chars: {:?} / s: {:?}",
                            toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                            (v2.get().clone(), v3.get().clone(), v4.get().clone())
                        ))
                    } else {
                        let v33: char = getCharAt(v1_1.get().clone(), 0_i32);
                        if (Documents::method98(v33, 0_i64)) == false {
                            let v70: string = getSlice(
                                v1_1.get().clone(),
                                Some(1_i32),
                                Some((length(v1_1.get().clone())) - 1_i32),
                            );
                            let v76: string = ofChar(v33);
                            let patternInput: (LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method86(
                                    Documents::method85(length(v76.clone()) as i64, v76, 0_i64),
                                    v2.get().clone(),
                                    v3.get().clone(),
                                    v4.get().clone(),
                                );
                            Documents::US16::US16_0(
                                v33,
                                v70,
                                patternInput.0.clone(),
                                patternInput.1.clone(),
                                patternInput.2.clone(),
                            )
                        } else {
                            Documents::US16::US16_1(sprintf!(
                                "parsing.none_of / unexpected char: \'{}\' / chars: {:?} / s: {:?}",
                                v33,
                                toArray(ofArray(new_array(&['\\', '`', '\"', ' ']))),
                                (v2.get().clone(), v3.get().clone(), v4.get().clone())
                            ))
                        }
                    };
                    let v134: Documents::US17 = match &v114 {
                        Documents::US16::US16_0(
                            v114_0_0,
                            v114_0_1,
                            v114_0_2,
                            v114_0_3,
                            v114_0_4,
                        ) => {
                            let patternInput_1: (string, string, LrcPtr<StringBuilder>, i32, i32) =
                                Documents::method99(
                                    ofChar(v114_0_0.clone()),
                                    v114_0_1.clone(),
                                    v114_0_2.clone(),
                                    v114_0_3.clone(),
                                    v114_0_4.clone(),
                                );
                            Documents::US17::US17_0(
                                patternInput_1.0.clone(),
                                patternInput_1.1.clone(),
                                patternInput_1.2.clone(),
                                patternInput_1.3.clone(),
                                patternInput_1.4.clone(),
                            )
                        }
                        Documents::US16::US16_1(v114_1_0) => {
                            Documents::US17::US17_1(v114_1_0.clone())
                        }
                    };
                    let v522: Documents::US17 = match &v134 {
                        Documents::US17::US17_0(
                            v134_0_0,
                            v134_0_1,
                            v134_0_2,
                            v134_0_3,
                            v134_0_4,
                        ) => v134.clone(),
                        _ => {
                            let v261: Documents::US16 = if v5 {
                                Documents::US16::US16_1(sprintf!(
                                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                    '\"',
                                    (v2.get().clone(), v3.get().clone(), v4.get().clone())
                                ))
                            } else {
                                let v146: char = getCharAt(v1_1.get().clone(), 0_i32);
                                if (v146) == '\"' {
                                    let v181: string = getSlice(
                                        v1_1.get().clone(),
                                        Some(1_i32),
                                        Some((length(v1_1.get().clone())) - 1_i32),
                                    );
                                    let v187: string = ofChar(v146);
                                    let patternInput_2: (LrcPtr<StringBuilder>, i32, i32) =
                                        Documents::method86(
                                            Documents::method85(
                                                length(v187.clone()) as i64,
                                                v187,
                                                0_i64,
                                            ),
                                            v2.get().clone(),
                                            v3.get().clone(),
                                            v4.get().clone(),
                                        );
                                    Documents::US16::US16_0(
                                        v146,
                                        v181,
                                        patternInput_2.0.clone(),
                                        patternInput_2.1.clone(),
                                        patternInput_2.2.clone(),
                                    )
                                } else {
                                    let v202: i32 =
                                        (indexOf(v1_1.get().clone(), string("\n"))) - 1_i32;
                                    Documents::US16::US16_1(concat(new_array(&[
                                        sprintf!(
                                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                            '\"',
                                            v3.get().clone(),
                                            v4.get().clone(),
                                            v2.get().clone(),
                                            getSlice(
                                                v1_1.get().clone(),
                                                Some(0_i32),
                                                Some(
                                                    (if -2_i32 == (v202) {
                                                        (length(v1_1.get().clone())) + 1_i32
                                                    } else {
                                                        (v202) + 1_i32
                                                    }) - 1_i32
                                                )
                                            )
                                        ),
                                        string("\n"),
                                        append(
                                            ((Documents::method87(
                                                (v4.get().clone()) - 1_i32,
                                                0_i32,
                                            ))(
                                                string("")
                                            )),
                                            string("^"),
                                        ),
                                        string("\n"),
                                    ])))
                                }
                            };
                            let v451: Documents::US17 = match &v261 {
                                Documents::US16::US16_0(
                                    v261_0_0,
                                    v261_0_1,
                                    v261_0_2,
                                    v261_0_3,
                                    v261_0_4,
                                ) => {
                                    let v266: i32 = v261_0_4.clone();
                                    let v265: i32 = v261_0_3.clone();
                                    let v264: LrcPtr<StringBuilder> = v261_0_2.clone();
                                    let v263: string = v261_0_1.clone();
                                    let v268: Documents::US24 = Documents::method100(
                                        LrcPtr::new(Documents::UH2::UH2_0),
                                        v263.clone(),
                                        v264.clone(),
                                        v265,
                                        v266,
                                    );
                                    let v301: Documents::US17 = match &v268 {
                                        Documents::US24::US24_0(
                                            v268_0_0,
                                            v268_0_1,
                                            v268_0_2,
                                            v268_0_3,
                                            v268_0_4,
                                        ) => {
                                            let v275: List<string> = Documents::method104(
                                                v268_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US17::US17_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v275 = v275.clone();
                                                        move || ofList(v275.clone()).clone()
                                                    }))),
                                                ),
                                                v268_0_1.clone(),
                                                v268_0_2.clone(),
                                                v268_0_3.clone(),
                                                v268_0_4.clone(),
                                            )
                                        }
                                        Documents::US24::US24_1(v268_1_0) => {
                                            Documents::US17::US17_1(v268_1_0.clone())
                                        }
                                    };
                                    match &v301 {
                                        Documents::US17::US17_0(
                                            v301_0_0,
                                            v301_0_1,
                                            v301_0_2,
                                            v301_0_3,
                                            v301_0_4,
                                        ) => {
                                            let v306: i32 = v301_0_4.clone();
                                            let v305: i32 = v301_0_3.clone();
                                            let v304: LrcPtr<StringBuilder> = v301_0_2.clone();
                                            let v303: string = v301_0_1.clone();
                                            let v428: Documents::US16 = if string("")
                                                == (v303.clone())
                                            {
                                                Documents::US16::US16_1(sprintf!(
                                                    "parsing.p_char / unexpected end of input / c: \'{}\' / s: {:?}",
                                                    '\"',
                                                    (v304.clone(), v305, v306)
                                                ))
                                            } else {
                                                let v313: char = getCharAt(v303.clone(), 0_i32);
                                                if (v313) == '\"' {
                                                    let v348: string = getSlice(
                                                        v303.clone(),
                                                        Some(1_i32),
                                                        Some((length(v303.clone())) - 1_i32),
                                                    );
                                                    let v354: string = ofChar(v313);
                                                    let patternInput_3: (
                                                        LrcPtr<StringBuilder>,
                                                        i32,
                                                        i32,
                                                    ) = Documents::method86(
                                                        Documents::method85(
                                                            length(v354.clone()) as i64,
                                                            v354,
                                                            0_i64,
                                                        ),
                                                        v304.clone(),
                                                        v305,
                                                        v306,
                                                    );
                                                    Documents::US16::US16_0(
                                                        v313,
                                                        v348,
                                                        patternInput_3.0.clone(),
                                                        patternInput_3.1.clone(),
                                                        patternInput_3.2.clone(),
                                                    )
                                                } else {
                                                    let v369: i32 =
                                                        (indexOf(v303.clone(), string("\n")))
                                                            - 1_i32;
                                                    Documents::US16::US16_1(concat(new_array(&[
                                                        sprintf!(
                                                            "parsing.p_char / expected: \'{}\' / line: {} / col: {}\n{}{}",
                                                            '\"',
                                                            v305,
                                                            v306,
                                                            v304.clone(),
                                                            getSlice(
                                                                v303.clone(),
                                                                Some(0_i32),
                                                                Some(
                                                                    (if -2_i32 == (v369) {
                                                                        (length(v303.clone()))
                                                                            + 1_i32
                                                                    } else {
                                                                        (v369) + 1_i32
                                                                    }) - 1_i32
                                                                )
                                                            )
                                                        ),
                                                        string("\n"),
                                                        append(
                                                            ((Documents::method87(
                                                                (v306) - 1_i32,
                                                                0_i32,
                                                            ))(
                                                                string("")
                                                            )),
                                                            string("^"),
                                                        ),
                                                        string("\n"),
                                                    ])))
                                                }
                                            };
                                            match &v428 {
                                                Documents::US16::US16_0(
                                                    v428_0_0,
                                                    v428_0_1,
                                                    v428_0_2,
                                                    v428_0_3,
                                                    v428_0_4,
                                                ) => Documents::US17::US17_0(
                                                    v301_0_0.clone(),
                                                    v428_0_1.clone(),
                                                    v428_0_2.clone(),
                                                    v428_0_3.clone(),
                                                    v428_0_4.clone(),
                                                ),
                                                Documents::US16::US16_1(v428_1_0) => {
                                                    Documents::US17::US17_1(sprintf!(
                                                        "parsing.between / expected closing delimiter / e: {:?} / input: {:?} / rest1: {:?} / rest2: {:?}",
                                                        v428_1_0.clone(),
                                                        (
                                                            v1_1.get().clone(),
                                                            v2.get().clone(),
                                                            v3.get().clone(),
                                                            v4.get().clone()
                                                        ),
                                                        (v263.clone(), v264.clone(), v265, v266),
                                                        (v303.clone(), v304.clone(), v305, v306)
                                                    ))
                                                }
                                            }
                                        }
                                        _ => Documents::US17::US17_1(string(
                                            "parsing.between / expected content",
                                        )),
                                    }
                                }
                                Documents::US16::US16_1(v261_1_0) => {
                                    Documents::US17::US17_1(v261_1_0.clone())
                                }
                            };
                            match &v451 {
                                Documents::US17::US17_0(
                                    v451_0_0,
                                    v451_0_1,
                                    v451_0_2,
                                    v451_0_3,
                                    v451_0_4,
                                ) => v451.clone(),
                                _ => {
                                    let v463: Documents::US17 =
                                                     Documents::method102(v1_1.get().clone(),
                                                                          v2.get().clone(),
                                                                          v3.get().clone(),
                                                                          v4.get().clone(),
                                                                          LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                           |arg10_0040:
                                                                                                                                (string,
                                                                                                                                 LrcPtr<StringBuilder>,
                                                                                                                                 i32,
                                                                                                                                 i32)|
                                                                                                                           Documents::closure39((),
                                                                                                                                                arg10_0040)),
                                                                                                            LrcPtr::new(Documents::UH3::UH3_1(Func1::new(move
                                                                                                                                                             |arg10_0040_1:
                                                                                                                                                                  (string,
                                                                                                                                                                   LrcPtr<StringBuilder>,
                                                                                                                                                                   i32,
                                                                                                                                                                   i32)|
                                                                                                                                                             Documents::closure40((),
                                                                                                                                                                                  arg10_0040_1)),
                                                                                                                                              LrcPtr::new(Documents::UH3::UH3_0))))));
                                    let v474: Documents::US17 = match &v463 {
                                        Documents::US17::US17_0(
                                            v463_0_0,
                                            v463_0_1,
                                            v463_0_2,
                                            v463_0_3,
                                            v463_0_4,
                                        ) => Documents::US17::US17_0(
                                            string(""),
                                            v463_0_1.clone(),
                                            v463_0_2.clone(),
                                            v463_0_3.clone(),
                                            v463_0_4.clone(),
                                        ),
                                        Documents::US17::US17_1(v463_1_0) => {
                                            Documents::US17::US17_1(v463_1_0.clone())
                                        }
                                    };
                                    let v485: Documents::US24 = match &v474 {
                                        Documents::US17::US17_0(
                                            v474_0_0,
                                            v474_0_1,
                                            v474_0_2,
                                            v474_0_3,
                                            v474_0_4,
                                        ) => Documents::method105(
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                            v474_0_1.clone(),
                                            v474_0_2.clone(),
                                            v474_0_3.clone(),
                                            v474_0_4.clone(),
                                        ),
                                        Documents::US17::US17_1(v474_1_0) => {
                                            Documents::US24::US24_1(v474_1_0.clone())
                                        }
                                    };
                                    match &v485 {
                                        Documents::US24::US24_0(
                                            v485_0_0,
                                            v485_0_1,
                                            v485_0_2,
                                            v485_0_3,
                                            v485_0_4,
                                        ) => {
                                            let v492: List<string> = Documents::method104(
                                                v485_0_0.clone(),
                                                empty::<string>(),
                                            );
                                            Documents::US17::US17_0(
                                                join(
                                                    string(""),
                                                    toArray_1(delay(Func0::new({
                                                        let v492 = v492.clone();
                                                        move || ofList(v492.clone()).clone()
                                                    }))),
                                                ),
                                                v485_0_1.clone(),
                                                v485_0_2.clone(),
                                                v485_0_3.clone(),
                                                v485_0_4.clone(),
                                            )
                                        }
                                        Documents::US24::US24_1(v485_1_0) => {
                                            Documents::US17::US17_1(v485_1_0.clone())
                                        }
                                    }
                                }
                            }
                        }
                    };
                    match &v522 {
                        Documents::US17::US17_0(
                            v522_0_0,
                            v522_0_1,
                            v522_0_2,
                            v522_0_3,
                            v522_0_4,
                        ) => {
                            let v527: i32 = v522_0_4.clone();
                            let v526: i32 = v522_0_3.clone();
                            let v525: LrcPtr<StringBuilder> = v522_0_2.clone();
                            let v524: string = v522_0_1.clone();
                            let v523: string = v522_0_0.clone();
                            let v529: i32 = Documents::method94(v524.clone(), 0_i32);
                            let v571: Documents::US19 = if 0_i32 == (v529) {
                                Documents::US19::US19_1(string(
                                    "parsing.spaces1 / expected at least one space",
                                ))
                            } else {
                                Documents::US19::US19_0(
                                    getSlice(
                                        v524.clone(),
                                        Some(v529),
                                        Some((length(v524.clone())) - 1_i32),
                                    ),
                                    v525.clone(),
                                    v526,
                                    v527,
                                )
                            };
                            match &v571 {
                                Documents::US19::US19_0(v571_0_0, v571_0_1, v571_0_2, v571_0_3) => {
                                    let v0_1_temp: LrcPtr<Documents::UH2> = LrcPtr::new(
                                        Documents::UH2::UH2_1(v523.clone(), v0_1.get().clone()),
                                    );
                                    let v1_1_temp: string = v571_0_0.clone();
                                    let v2_temp: LrcPtr<StringBuilder> = v571_0_1.clone();
                                    let v3_temp: i32 = v571_0_2.clone();
                                    let v4_temp: i32 = v571_0_3.clone();
                                    v0_1.set(v0_1_temp);
                                    v1_1.set(v1_1_temp);
                                    v2.set(v2_temp);
                                    v3.set(v3_temp);
                                    v4.set(v4_temp);
                                    continue '_method97;
                                }
                                _ => Documents::US24::US24_0(
                                    Documents::method103(
                                        v0_1.get().clone(),
                                        LrcPtr::new(Documents::UH2::UH2_1(
                                            v523.clone(),
                                            LrcPtr::new(Documents::UH2::UH2_0),
                                        )),
                                    ),
                                    v524.clone(),
                                    v525.clone(),
                                    v526,
                                    v527,
                                ),
                            }
                        }
                        _ => Documents::US24::US24_0(
                            Documents::method103(
                                v0_1.get().clone(),
                                LrcPtr::new(Documents::UH2::UH2_0),
                            ),
                            v1_1.get().clone(),
                            v2.get().clone(),
                            v3.get().clone(),
                            v4.get().clone(),
                        ),
                    }
                });
            }
        }
        pub fn method96(v0_1: string) -> Documents::US23 {
            let _v0: MutCell<Option<Option<string>>> = MutCell::new(None::<Option<string>>);
            _v0.set(Some(Some(v0_1)));
            {
                let v22: Documents::US24 = Documents::method97(
                    LrcPtr::new(Documents::UH2::UH2_0),
                    defaultValue(
                        string(""),
                        match &_v0.get().clone() {
                            None => panic!("{}", string("optionm\'.of_obj / _v0=None"),),
                            Some(_v0_0_0) => _v0_0_0.clone(),
                        },
                    ),
                    StringBuilder::_ctor__Z721C83C5(Documents::method84()),
                    1_i32,
                    1_i32,
                );
                match &v22 {
                    Documents::US24::US24_0(v22_0_0, v22_0_1, v22_0_2, v22_0_3, v22_0_4) => {
                        Documents::US23::US23_0(toArray(Documents::method104(
                            v22_0_0.clone(),
                            empty::<string>(),
                        )))
                    }
                    Documents::US24::US24_1(v22_1_0) => Documents::US23::US23_1(v22_1_0.clone()),
                }
            }
        }
        pub fn method107(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), string("file_name"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v10.clone(), v0_1, ());
                ()
            };
            let v98: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v117: () = {
                Documents::closure8(v10.clone(), string("arguments"), ());
                ()
            };
            let v134: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v151: () = {
                Documents::closure8(v10.clone(), v1_1, ());
                ()
            };
            let v168: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v187: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v204: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v221: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v240: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v257: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v274: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v291: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v310: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v327: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v339: std::string::String = format!("{:#?}", v3);
            let v386: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v339),
                    (),
                );
                ()
            };
            let v403: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v422: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v439: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v460: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v477: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v496: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v513: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v525: std::string::String = format!("{:#?}", v5);
            let v572: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v525),
                    (),
                );
                ()
            };
            let v589: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v608: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v625: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v637: std::string::String = format!("{:#?}", v6);
            let v684: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v637),
                    (),
                );
                ()
            };
            let v701: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v720: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v737: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v757: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v774: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v793: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v810: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v822: std::string::String = format!("{:#?}", v8);
            let v869: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v822),
                    (),
                );
                ()
            };
            let v888: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v905: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method106(
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
        ) -> string {
            let v17: string = Documents::method107(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method17(append(
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
                (v17),
            ))
        }
        pub fn closure41(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            unitVar: (),
        ) {
            fn v24() {
                Documents::closure6((), ());
            }
            let v25: () = {
                v24();
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
            let v66: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v310: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v66,
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
                Documents::US6::US6_1
            } else {
                let v89: () = {
                    v24();
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
                let v117: Option<i64> = patternInput_1.5.clone();
                let v116: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v115: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v114: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v113: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v112: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v136: string = Documents::method106(
                    v112.clone(),
                    v113.clone(),
                    v114.clone(),
                    v115.clone(),
                    v116.clone(),
                    v117.clone(),
                    Documents::method7(v112, v113, v114, v115, v116, v117),
                    Documents::method64(),
                    v7,
                    sprintf!("{:?}", v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                );
                let v152: () = {
                    v24();
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
                let v176: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v175: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v197: () = {
                    Documents::closure9(v175.clone(), ());
                    ()
                };
                println!("{}", v136.clone());
                (v176.l0.get().clone())(v136);
                Documents::US6::US6_0(
                    v175,
                    v176,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure42(
            unitVar: (),
            v0_1: Option<std::process::Child>,
        ) -> Option<std::process::Child> {
            v0_1
        }
        pub fn method108() -> Func1<Option<std::process::Child>, Option<std::process::Child>> {
            Func1::new(move |v: Option<std::process::Child>| Documents::closure42((), v))
        }
        pub fn closure43(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
        ) -> Documents::US25 {
            Documents::US25::US25_0(v0_1)
        }
        pub fn method109()
        -> Func1<std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>, Documents::US25>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>| {
                    Documents::closure43((), v)
                },
            )
        }
        pub fn closure44(unitVar: (), v0_1: std::string::String) -> Documents::US25 {
            Documents::US25::US25_1(v0_1)
        }
        pub fn method110() -> Func1<std::string::String, Documents::US25> {
            Func1::new(move |v: std::string::String| Documents::closure44((), v))
        }
        pub fn method112(
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
        ) -> string {
            let v11: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v25: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v44: () = {
                Documents::closure8(v11.clone(), string("error"), ());
                ()
            };
            let v63: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v75: std::string::String = format!("{:#?}", v0_1);
            let v122: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v75),
                    (),
                );
                ()
            };
            let v141: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v160: () = {
                Documents::closure8(v11.clone(), string("file_name"), ());
                ()
            };
            let v177: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v194: () = {
                Documents::closure8(v11.clone(), v1_1, ());
                ()
            };
            let v211: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v230: () = {
                Documents::closure8(v11.clone(), string("arguments"), ());
                ()
            };
            let v247: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v264: () = {
                Documents::closure8(v11.clone(), v2, ());
                ()
            };
            let v281: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v300: () = {
                Documents::closure8(v11.clone(), string("options"), ());
                ()
            };
            let v317: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v334: () = {
                Documents::closure8(v11.clone(), string("{ "), ());
                ()
            };
            let v353: () = {
                Documents::closure8(v11.clone(), string("command"), ());
                ()
            };
            let v370: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v387: () = {
                Documents::closure8(v11.clone(), v3, ());
                ()
            };
            let v404: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v423: () = {
                Documents::closure8(v11.clone(), string("cancellation_token"), ());
                ()
            };
            let v440: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v452: std::string::String = format!("{:#?}", v4);
            let v499: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v452),
                    (),
                );
                ()
            };
            let v516: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v535: () = {
                Documents::closure8(v11.clone(), string("environment_variables"), ());
                ()
            };
            let v552: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v573: () = {
                Documents::closure8(v11.clone(), sprintf!("{:?}", v5), ());
                ()
            };
            let v590: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v609: () = {
                Documents::closure8(v11.clone(), string("on_line"), ());
                ()
            };
            let v626: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v638: std::string::String = format!("{:#?}", v6);
            let v685: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v638),
                    (),
                );
                ()
            };
            let v702: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v721: () = {
                Documents::closure8(v11.clone(), string("stdin"), ());
                ()
            };
            let v738: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v750: std::string::String = format!("{:#?}", v7);
            let v797: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v750),
                    (),
                );
                ()
            };
            let v814: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v833: () = {
                Documents::closure8(v11.clone(), string("trace"), ());
                ()
            };
            let v850: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v870: () = {
                Documents::closure8(
                    v11.clone(),
                    if v8 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v887: () = {
                Documents::closure8(v11.clone(), string("; "), ());
                ()
            };
            let v906: () = {
                Documents::closure8(v11.clone(), string("working_directory"), ());
                ()
            };
            let v923: () = {
                Documents::closure8(v11.clone(), string(" = "), ());
                ()
            };
            let v935: std::string::String = format!("{:#?}", v9);
            let v982: () = {
                Documents::closure8(
                    v11.clone(),
                    fable_library_rust::String_::fromString(v935),
                    (),
                );
                ()
            };
            let v1001: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            let v1018: () = {
                Documents::closure8(v11.clone(), string(" }"), ());
                ()
            };
            v11.l0.get().clone()
        }
        pub fn method111(
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
        ) -> string {
            let v18: string = Documents::method112(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17);
            Documents::method17(append(
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
                (v18),
            ))
        }
        pub fn closure45(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            v9: std::string::String,
            unitVar: (),
        ) {
            fn v25() {
                Documents::closure6((), ());
            }
            let v26: () = {
                v25();
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
            let v67: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v311: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v67,
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
                Documents::US6::US6_1
            } else {
                let v90: () = {
                    v25();
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
                let v118: Option<i64> = patternInput_1.5.clone();
                let v117: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v116: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v115: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v114: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v113: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v137: string = Documents::method111(
                    v113.clone(),
                    v114.clone(),
                    v115.clone(),
                    v116.clone(),
                    v117.clone(),
                    v118.clone(),
                    Documents::method7(v113, v114, v115, v116, v117, v118),
                    Documents::method74(),
                    v9,
                    v7,
                    sprintf!("{:?}", v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                );
                let v153: () = {
                    v25();
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
                let v177: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v176: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v198: () = {
                    Documents::closure9(v176.clone(), ());
                    ()
                };
                println!("{}", v137.clone());
                (v177.l0.get().clone())(v137);
                Documents::US6::US6_0(
                    v176,
                    v177,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method113(
            v0_1: std::sync::MutexGuard<Option<std::process::Child>>,
        ) -> std::sync::MutexGuard<Option<std::process::Child>> {
            v0_1
        }
        pub fn closure46(
            unitVar: (),
            v0_1: Option<std::process::ChildStdin>,
        ) -> Option<std::process::ChildStdin> {
            v0_1
        }
        pub fn method114()
        -> Func1<Option<std::process::ChildStdin>, Option<std::process::ChildStdin>> {
            Func1::new(move |v: Option<std::process::ChildStdin>| Documents::closure46((), v))
        }
        pub fn closure47(
            unitVar: (),
            v0_1: std::sync::mpsc::Sender<std::string::String>,
        ) -> std::sync::mpsc::Sender<std::string::String> {
            v0_1
        }
        pub fn method115() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure47((), v)
            })
        }
        pub fn method116() -> Func1<
            std::sync::mpsc::Sender<std::string::String>,
            std::sync::mpsc::Sender<std::string::String>,
        > {
            Func1::new(move |v: std::sync::mpsc::Sender<std::string::String>| {
                Documents::closure47((), v)
            })
        }
        pub fn closure48(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        ) -> std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>> {
            v0_1
        }
        pub fn method117() -> Func1<
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
            std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
        > {
            Func1::new(
                move |v: std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>| {
                    Documents::closure48((), v)
                },
            )
        }
        pub fn closure49(unitVar: (), v0_1: std::string::String) -> Documents::US27 {
            Documents::US27::US27_0(v0_1)
        }
        pub fn method118() -> Func1<std::string::String, Documents::US27> {
            Func1::new(move |v: std::string::String| Documents::closure49((), v))
        }
        pub fn closure50(unitVar: (), v0_1: std::string::String) -> Documents::US27 {
            Documents::US27::US27_1(v0_1)
        }
        pub fn method119() -> Func1<std::string::String, Documents::US27> {
            Func1::new(move |v: std::string::String| Documents::closure50((), v))
        }
        pub fn method121(v0_1: bool, v1_1: std::string::String) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), string("trace\'"), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v75: () = {
                Documents::closure8(
                    v3.clone(),
                    if v0_1 {
                        string("true")
                    } else {
                        string("false")
                    },
                    (),
                );
                ()
            };
            let v94: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v3.clone(), string("e"), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v142: std::string::String = format!("{:#?}", v1_1);
            let v189: () = {
                Documents::closure8(
                    v3.clone(),
                    fable_library_rust::String_::fromString(v142),
                    (),
                );
                ()
            };
            let v208: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method120(
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
            let v10: string = Documents::method121(v8, v9);
            Documents::method17(append(
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
        pub fn closure51(v0_1: bool, v1_1: std::string::String, unitVar: ()) {
            fn v17() {
                Documents::closure6((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v299: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v59,
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
                Documents::US6::US6_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v108: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v107: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v106: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v105: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v125: string = Documents::method120(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Documents::method7(v105, v106, v107, v108, v109, v110),
                    Documents::method74(),
                    v0_1,
                    v1_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v164: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v186: () = {
                    Documents::closure9(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Documents::US6::US6_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method122() -> string {
            let v8: string = Documents::method12(getCharAt(toLower(string("Verbose")), 0_i32));
            let v27: &str = inline_colorization::color_bright_black;
            let v34: &str = &*v8;
            let v65: &str = inline_colorization::color_reset;
            let v67: std::string::String = format!("{}{}{}", v27, v34, v65);
            fable_library_rust::String_::fromString(v67)
        }
        pub fn method124() -> string {
            let v1_1: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            v1_1.l0.get().clone()
        }
        pub fn method123(
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
            let v9: string = Documents::method124();
            Documents::method17(append(
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
        pub fn closure52(v0_1: string, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v301: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                0_i32
                    >= (find(
                        v58,
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
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
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
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v127: string = if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method123(
                        v104.clone(),
                        v105.clone(),
                        v106.clone(),
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        Documents::method7(v104, v105, v106, v107, v108, v109),
                        Documents::method122(),
                        v0_1,
                    )
                };
                let v143: () = {
                    v16();
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
                let v167: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v166: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v188: () = {
                    Documents::closure9(v166.clone(), ());
                    ()
                };
                println!("{}", v127.clone());
                (v167.l0.get().clone())(v127);
                Documents::US6::US6_0(
                    v166,
                    v167,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure53(
            unitVar: (),
            v0_1: std::sync::mpsc::SendError<std::string::String>,
        ) -> std::string::String {
            format!("{}", v0_1)
        }
        pub fn method125()
        -> Func1<std::sync::mpsc::SendError<std::string::String>, std::string::String> {
            Func1::new(move |v: std::sync::mpsc::SendError<std::string::String>| {
                Documents::closure53((), v)
            })
        }
        pub fn method126(v0_1: Result<(), string>) -> Result<(), string> {
            v0_1
        }
        pub fn closure54(
            unitVar: (),
            v0_1: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
        ) -> Documents::US28 {
            Documents::US28::US28_0(v0_1)
        }
        pub fn method127() -> Func1<
            Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>,
            Documents::US28,
        > {
            Func1::new(
                move |v: Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>| {
                    Documents::closure54((), v)
                },
            )
        }
        pub fn method128(
            v0_1: std::sync::MutexGuard<Option<std::process::ChildStdin>>,
        ) -> std::sync::MutexGuard<Option<std::process::ChildStdin>> {
            v0_1
        }
        pub fn closure55(
            unitVar: (),
            v0_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) -> Documents::US29 {
            Documents::US29::US29_0(v0_1)
        }
        pub fn method129()
        -> Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, Documents::US29>
        {
            Func1::new(
                move |v: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| {
                    Documents::closure55((), v)
                },
            )
        }
        pub fn method130(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure56(unitVar: (), v0_1: std::process::Output) -> Documents::US30 {
            Documents::US30::US30_0(v0_1)
        }
        pub fn method131() -> Func1<std::process::Output, Documents::US30> {
            Func1::new(move |v: std::process::Output| Documents::closure56((), v))
        }
        pub fn closure57(unitVar: (), v0_1: std::string::String) -> Documents::US30 {
            Documents::US30::US30_1(v0_1)
        }
        pub fn method132() -> Func1<std::string::String, Documents::US30> {
            Func1::new(move |v: std::string::String| Documents::closure57((), v))
        }
        pub fn method133(
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
        ) -> string {
            let v18: string = Documents::method112(v8, v9, v10, v11, v12, v13, v14, v15, v16, v17);
            Documents::method17(append(
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
                (v18),
            ))
        }
        pub fn closure58(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: string,
            v8: Vec<std::string::String>,
            v9: std::string::String,
            unitVar: (),
        ) {
            fn v25() {
                Documents::closure6((), ());
            }
            let v26: () = {
                v25();
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
            let v67: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v311: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v67,
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
                Documents::US6::US6_1
            } else {
                let v90: () = {
                    v25();
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
                let v118: Option<i64> = patternInput_1.5.clone();
                let v117: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v116: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v115: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v114: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v113: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v137: string = Documents::method133(
                    v113.clone(),
                    v114.clone(),
                    v115.clone(),
                    v116.clone(),
                    v117.clone(),
                    v118.clone(),
                    Documents::method7(v113, v114, v115, v116, v117, v118),
                    Documents::method74(),
                    v9,
                    v7,
                    sprintf!("{:?}", v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                );
                let v153: () = {
                    v25();
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
                let v177: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v176: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v198: () = {
                    Documents::closure9(v176.clone(), ());
                    ()
                };
                println!("{}", v137.clone());
                (v177.l0.get().clone())(v137);
                Documents::US6::US6_0(
                    v176,
                    v177,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure59(unitVar: (), v0_1: i32) -> Documents::US31 {
            Documents::US31::US31_0(v0_1)
        }
        pub fn method134() -> Func1<i32, Documents::US31> {
            Func1::new(move |v: i32| Documents::closure59((), v))
        }
        pub fn method135() -> string {
            string("\n")
        }
        pub fn method137(v0_1: i32, v1_1: i32) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v75: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v94: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v3.clone(), string("std_trace_length"), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v150: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v169: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method136(
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
        ) -> string {
            let v10: string = Documents::method137(v8, v9);
            Documents::method17(append(
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
                (v10),
            ))
        }
        pub fn closure60(v0_1: i32, v1_1: string, unitVar: ()) {
            fn v17() {
                Documents::closure6((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                0_i32
                    >= (find(
                        v59,
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
                Documents::US6::US6_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v108: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v107: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v106: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v105: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method136(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Documents::method7(v105, v106, v107, v108, v109, v110),
                    Documents::method122(),
                    v0_1,
                    length(v1_1),
                );
                let v142: () = {
                    v17();
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
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method141(
            v0_1: string,
            v1_1: Documents::US5,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), string("file_name"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v79: () = {
                Documents::closure8(v10.clone(), v0_1, ());
                ()
            };
            let v98: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v117: () = {
                Documents::closure8(v10.clone(), string("arguments"), ());
                ()
            };
            let v134: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v155: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v1_1), ());
                ()
            };
            let v172: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v191: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v208: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v225: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v244: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v261: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v278: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v295: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v314: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v331: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v343: std::string::String = format!("{:#?}", v3);
            let v390: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v343),
                    (),
                );
                ()
            };
            let v407: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v426: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v443: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v464: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v481: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v500: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v517: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v529: std::string::String = format!("{:#?}", v5);
            let v576: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v529),
                    (),
                );
                ()
            };
            let v593: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v612: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v629: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v641: std::string::String = format!("{:#?}", v6);
            let v688: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v641),
                    (),
                );
                ()
            };
            let v705: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v724: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v741: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v761: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v778: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v797: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v814: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v826: std::string::String = format!("{:#?}", v8);
            let v873: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v826),
                    (),
                );
                ()
            };
            let v892: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v909: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method140(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: string,
            v9: Documents::US5,
            v10: string,
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Documents::method141(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options_async"),
                    )),
                    string(" / "),
                )),
                (v17),
            ))
        }
        pub fn closure61(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: Documents::US5,
            v8: string,
            unitVar: (),
        ) {
            fn v24() {
                Documents::closure6((), ());
            }
            let v25: () = {
                v24();
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
            let v66: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v306: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v66,
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
                Documents::US6::US6_1
            } else {
                let v89: () = {
                    v24();
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
                let v117: Option<i64> = patternInput_1.5.clone();
                let v116: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v115: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v114: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v113: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v112: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v132: string = Documents::method140(
                    v112.clone(),
                    v113.clone(),
                    v114.clone(),
                    v115.clone(),
                    v116.clone(),
                    v117.clone(),
                    Documents::method7(v112, v113, v114, v115, v116, v117),
                    Documents::method64(),
                    v8,
                    v7,
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                );
                let v148: () = {
                    v24();
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
                let v172: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v171: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v193: () = {
                    Documents::closure9(v171.clone(), ());
                    ()
                };
                println!("{}", v132.clone());
                (v172.l0.get().clone())(v132);
                Documents::US6::US6_0(
                    v171,
                    v172,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method142(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Array<(string, string)> {
            v2
        }
        pub fn method145(v0_1: bool) -> string {
            unbox::<string>(fable_library_rust::Native_::getZero())
        }
        pub fn closure63(
            unitVar: (),
            v0_1: Func1<(i32, string, bool), Arc<Async<()>>>,
        ) -> Documents::US32 {
            Documents::US32::US32_0(v0_1)
        }
        pub fn method146() -> Func1<Func1<(i32, string, bool), Arc<Async<()>>>, Documents::US32> {
            Func1::new(move |v: Func1<(i32, string, bool), Arc<Async<()>>>| {
                Documents::closure63((), v)
            })
        }
        pub fn method147(v0_1: bool) -> i32 {
            unbox::<i32>(fable_library_rust::Native_::getZero())
        }
        pub fn closure64(v0_1: string, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v301: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                0_i32
                    >= (find(
                        v58,
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
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
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
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v127: string = if (v0_1.clone()) == string("") {
                    string("")
                } else {
                    Documents::method123(
                        v104.clone(),
                        v105.clone(),
                        v106.clone(),
                        v107.clone(),
                        v108.clone(),
                        v109.clone(),
                        Documents::method7(v104, v105, v106, v107, v108, v109),
                        Documents::method122(),
                        v0_1,
                    )
                };
                let v143: () = {
                    v16();
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
                let v167: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v166: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v188: () = {
                    Documents::closure9(v166.clone(), ());
                    ()
                };
                println!("{}", v127.clone());
                (v167.l0.get().clone())(v127);
                Documents::US6::US6_0(
                    v166,
                    v167,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method144(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) -> Arc<Async<()>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method143(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) -> Arc<Async<()>> {
            Documents::method144(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10)
        }
        pub fn closure62(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: bool,
            v8: LrcPtr<ConcurrentStack_1<string>>,
            v9: bool,
            v10: bool,
        ) {
            let v11: Arc<Async<()>> =
                Documents::method143(v0_1, v1_1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
            fable_library_rust::Native_::getZero::<()>();
            ()
        }
        pub fn closure65(unitVar: (), v0_1: CancellationToken) -> Documents::US33 {
            Documents::US33::US33_0(v0_1)
        }
        pub fn method148() -> Func1<CancellationToken, Documents::US33> {
            Func1::new(move |v: CancellationToken| Documents::closure65((), v))
        }
        pub fn method149(v0_1: CancellationToken) -> Arc<Async<CancellationToken>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method150(v0_1: bool) -> bool {
            unbox::<bool>(fable_library_rust::Native_::getZero())
        }
        pub fn method151(v0_1: bool) {
            ();
        }
        pub fn closure66(v0_1: bool, unitVar: ()) {
            if (Documents::method150(v0_1)) == false {
                Documents::method151(v0_1);
            };
        }
        pub fn method154(v0_1: LrcPtr<TaskCanceledException>) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("ex"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v66: std::string::String = format!("{:#?}", v0_1);
            let v113: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v66), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method153(
            v0_1: LrcPtr<Documents::Mut0>,
            v1_1: LrcPtr<Documents::Mut1>,
            v2: LrcPtr<Documents::Mut2>,
            v3: LrcPtr<Documents::Mut3>,
            v4: LrcPtr<Documents::Mut4>,
            v5: Option<i64>,
            v6: string,
            v7: string,
            v8: LrcPtr<TaskCanceledException>,
        ) -> string {
            let v9: string = Documents::method154(v8);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options_async / WaitForExitAsync"),
                    )),
                    string(" / "),
                )),
                (v9),
            ))
        }
        pub fn closure67(v0_1: LrcPtr<TaskCanceledException>, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v298: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v58,
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
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
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
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v124: string = Documents::method153(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method33(),
                    v0_1,
                );
                let v140: () = {
                    v16();
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
                let v164: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v163: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v185: () = {
                    Documents::closure9(v163.clone(), ());
                    ()
                };
                println!("{}", v124.clone());
                (v164.l0.get().clone())(v124);
                Documents::US6::US6_0(
                    v163,
                    v164,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method152(
            v0_1: bool,
            v1_1: LrcPtr<ConcurrentStack_1<string>>,
            v2: CancellationToken,
        ) -> Arc<Async<i32>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method156(
            v0_1: i32,
            v1_1: i32,
            v2: string,
            v3: Option<CancellationToken>,
            v4: Array<(string, string)>,
            v5: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v6: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v7: bool,
            v8: Option<string>,
        ) -> string {
            let v10: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v24: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v43: () = {
                Documents::closure8(v10.clone(), string("exit_code"), ());
                ()
            };
            let v62: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v82: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v101: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v120: () = {
                Documents::closure8(v10.clone(), string("output_length"), ());
                ()
            };
            let v137: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v157: () = {
                Documents::closure8(v10.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v174: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v193: () = {
                Documents::closure8(v10.clone(), string("options"), ());
                ()
            };
            let v210: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v227: () = {
                Documents::closure8(v10.clone(), string("{ "), ());
                ()
            };
            let v246: () = {
                Documents::closure8(v10.clone(), string("command"), ());
                ()
            };
            let v263: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v280: () = {
                Documents::closure8(v10.clone(), v2, ());
                ()
            };
            let v297: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v316: () = {
                Documents::closure8(v10.clone(), string("cancellation_token"), ());
                ()
            };
            let v333: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v345: std::string::String = format!("{:#?}", v3);
            let v392: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v345),
                    (),
                );
                ()
            };
            let v409: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v428: () = {
                Documents::closure8(v10.clone(), string("environment_variables"), ());
                ()
            };
            let v445: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v466: () = {
                Documents::closure8(v10.clone(), sprintf!("{:?}", v4), ());
                ()
            };
            let v483: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v502: () = {
                Documents::closure8(v10.clone(), string("on_line"), ());
                ()
            };
            let v519: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v531: std::string::String = format!("{:#?}", v5);
            let v578: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v531),
                    (),
                );
                ()
            };
            let v595: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v614: () = {
                Documents::closure8(v10.clone(), string("stdin"), ());
                ()
            };
            let v631: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v643: std::string::String = format!("{:#?}", v6);
            let v690: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v643),
                    (),
                );
                ()
            };
            let v707: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v726: () = {
                Documents::closure8(v10.clone(), string("trace"), ());
                ()
            };
            let v743: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v763: () = {
                Documents::closure8(
                    v10.clone(),
                    if v7 { string("true") } else { string("false") },
                    (),
                );
                ()
            };
            let v780: () = {
                Documents::closure8(v10.clone(), string("; "), ());
                ()
            };
            let v799: () = {
                Documents::closure8(v10.clone(), string("working_directory"), ());
                ()
            };
            let v816: () = {
                Documents::closure8(v10.clone(), string(" = "), ());
                ()
            };
            let v828: std::string::String = format!("{:#?}", v8);
            let v875: () = {
                Documents::closure8(
                    v10.clone(),
                    fable_library_rust::String_::fromString(v828),
                    (),
                );
                ()
            };
            let v894: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            let v911: () = {
                Documents::closure8(v10.clone(), string(" }"), ());
                ()
            };
            v10.l0.get().clone()
        }
        pub fn method155(
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
            v11: Option<CancellationToken>,
            v12: Array<(string, string)>,
            v13: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v14: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v15: bool,
            v16: Option<string>,
        ) -> string {
            let v17: string = Documents::method156(v8, v9, v10, v11, v12, v13, v14, v15, v16);
            Documents::method17(append(
                (append(
                    (append(
                        (append(
                            (append(
                                (append((append((append((v6), string(" "))), (v7))), string(" #"))),
                                (toString(v0_1.l0.get().clone())),
                            )),
                            string(" "),
                        )),
                        string("runtime.execute_with_options_async"),
                    )),
                    string(" / "),
                )),
                (v17),
            ))
        }
        pub fn closure68(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
            v7: i32,
            v8: string,
            unitVar: (),
        ) {
            fn v24() {
                Documents::closure6((), ());
            }
            let v25: () = {
                v24();
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
            let v66: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v307: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v66,
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
                Documents::US6::US6_1
            } else {
                let v89: () = {
                    v24();
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
                let v117: Option<i64> = patternInput_1.5.clone();
                let v116: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v115: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v114: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v113: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v112: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v133: string = Documents::method155(
                    v112.clone(),
                    v113.clone(),
                    v114.clone(),
                    v115.clone(),
                    v116.clone(),
                    v117.clone(),
                    Documents::method7(v112, v113, v114, v115, v116, v117),
                    Documents::method64(),
                    v7,
                    length(v8),
                    v0_1,
                    v1_1,
                    v2,
                    v3,
                    v4,
                    v5,
                    v6,
                );
                let v149: () = {
                    v24();
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
                let v173: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v172: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v194: () = {
                    Documents::closure9(v172.clone(), ());
                    ()
                };
                println!("{}", v133.clone());
                (v173.l0.get().clone())(v133);
                Documents::US6::US6_0(
                    v172,
                    v173,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method139(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            fable_library_rust::Native_::getZero()
        }
        pub fn method138(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> Arc<Async<(i32, string)>> {
            Documents::method139(v0_1, v1_1, v2, v3, v4, v5, v6)
        }
        pub fn method81(
            v0_1: string,
            v1_1: Option<CancellationToken>,
            v2: Array<(string, string)>,
            v3: Option<Func1<(i32, string, bool), Arc<Async<()>>>>,
            v4: Option<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
            v5: bool,
            v6: Option<string>,
        ) -> (i32, string) {
            let v17: Documents::US15 = Documents::method83(Documents::method82(
                v0_1.clone(),
                v1_1.clone(),
                v2.clone(),
                v3.clone(),
                v4.clone(),
                v5,
                v6.clone(),
            ));
            let patternInput: (string, Documents::US5) = match &v17 {
                Documents::US15::US15_0(v17_0_0, v17_0_1) => (v17_0_0.clone(), v17_0_1.clone()),
                Documents::US15::US15_1(v17_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Result value was Error: "),
                        v17_1_0.clone()
                    ])),
                ),
            };
            let v30: Documents::US5 = patternInput.1.clone();
            let v29: string = patternInput.0.clone();
            let v35: Documents::US23 = Documents::method96(match &v30 {
                Documents::US5::US5_0(v30_0_0) => match &v30 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => string(""),
            });
            let v44: Array<string> = match &v35 {
                Documents::US23::US23_0(v35_0_0) => v35_0_0.clone(),
                Documents::US23::US23_1(v35_1_0) => panic!(
                    "{}",
                    concat(new_array(&[
                        string("resultm.get / Result value was Error: "),
                        v35_1_0.clone()
                    ])),
                ),
            };
            let v46: Vec<string> = v44.to_vec();
            let v48: bool = true;
            let _vec_map: Vec<_> = v46
                .into_iter()
                .map(|x| {
                    //;
                    let v50: string = x;
                    let v57: &str = &*v50;
                    let v93: std::string::String = String::from(v57);
                    let v124: bool = true;
                    v93
                })
                .collect::<Vec<_>>();
            let v126: Vec<std::string::String> = _vec_map;
            let v444: () = {
                Documents::closure41(
                    v0_1.clone(),
                    v1_1.clone(),
                    v2.clone(),
                    v3.clone(),
                    v4.clone(),
                    v5,
                    v6.clone(),
                    v29.clone(),
                    v126.clone(),
                    (),
                );
                ()
            };
            let _capture_v764: MutCell<Option<LrcPtr<(i32, string)>>> =
                MutCell::new(None::<LrcPtr<(i32, string)>>);
            {
                let x_5: LrcPtr<(i32, string)> = (Func0::new({
                    let v0_1 = v0_1.clone();
                    let v126 = v126.clone();
                    let v1_1 = v1_1.clone();
                    let v2 = v2.clone();
                    let v29 = v29.clone();
                    let v3 = v3.clone();
                    let v4 = v4.clone();
                    let v5 = v5.clone();
                    let v6 = v6.clone();
                    move || {
                        let v766: std::process::Command = std::process::Command::new(&*v29.clone());
                        let v768: bool = true;
                        let mut v766 = v766;
                        let v770: bool = true;
                        std::process::Command::args(&mut v766, &*v126.clone());
                        let v772: std::process::Command = v766;
                        let v774: std::process::Stdio = std::process::Stdio::piped();
                        let v776: bool = true;
                        let mut v772 = v772;
                        let v778: bool = true;
                        std::process::Command::stdout(&mut v772, std::process::Stdio::piped());
                        let v780: std::process::Command = v772;
                        let v782: std::process::Stdio = std::process::Stdio::piped();
                        let v784: bool = true;
                        let mut v780 = v780;
                        let v786: bool = true;
                        std::process::Command::stderr(&mut v780, std::process::Stdio::piped());
                        let v788: std::process::Command = v780;
                        let v790: std::process::Stdio = std::process::Stdio::piped();
                        let v792: bool = true;
                        let mut v788 = v788;
                        let v794: bool = true;
                        std::process::Command::stdin(&mut v788, std::process::Stdio::piped());
                        let v796: std::process::Command = v788;
                        let v821: Documents::US5 = defaultValue(
                            Documents::US5::US5_1,
                            map(Documents::method6(), v6.clone()),
                        );
                        let v835: std::process::Command = match &v821 {
                            Documents::US5::US5_0(v821_0_0) => {
                                let v827: bool = true;
                                let mut v796 = v796;
                                let v829: bool = true;
                                std::process::Command::current_dir(
                                    &mut v796,
                                    &*match &v821 {
                                        Documents::US5::US5_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                );
                                v796
                            }
                            _ => v796,
                        };
                        let v857: std::process::Command = if (get_Count(v2.clone()) as u64) == 0_u64
                        {
                            v835
                        } else {
                            let v839: Vec<(string, string)> = v2.clone().to_vec();
                            let v841: bool = true;
                            let _vec_fold_ = v839.into_iter().fold(v835, |acc, x| {
                                //;
                                let v843: std::process::Command = acc;
                                let patternInput_1: (string, string) = x;
                                let v848: bool = true;
                                let mut v843 = v843;
                                let v850: bool = true;
                                std::process::Command::env(
                                    &mut v843,
                                    &*patternInput_1.0.clone(),
                                    &*patternInput_1.1.clone(),
                                );
                                let v852: std::process::Command = v843;
                                let v854: bool = true;
                                v852
                            });
                            _vec_fold_
                        };
                        let v859: bool = true;
                        let mut v857 = v857;
                        let v861: Result<std::process::Child, std::io::Error> =
                            std::process::Command::spawn(&mut v857);
                        let v862 = Documents::method67();
                        let v866: Result<std::process::Child, std::string::String> =
                            v861.map_err(|x| v862(x));
                        let v878 = Documents::method108();
                        let v880: bool = true;
                        let _result_map_ = v866.map(|x| {
                            //;
                            let v887: Option<std::process::Child> = v878(Some(x));
                            let v889: std::sync::Mutex<Option<std::process::Child>> =
                                std::sync::Mutex::new(v887);
                            let v891: std::sync::Arc<
                                std::sync::Mutex<Option<std::process::Child>>,
                            > = std::sync::Arc::new(v889);
                            let v893: bool = true;
                            v891
                        });
                        let v895: Result<
                            std::sync::Arc<std::sync::Mutex<Option<std::process::Child>>>,
                            std::string::String,
                        > = _result_map_;
                        let v896 = Documents::method109();
                        let v897 = Documents::method110();
                        let v899: Documents::US25 = match v895 {
                            Ok(x) => v896(x),
                            Err(e) => v897(e),
                        };
                        let patternInput_3: (i32, Documents::US7, Documents::US26) = match &v899 {
                            Documents::US25::US25_0(v899_0_0) => {
                                let v900: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::Child>>,
                                > = v899_0_0.clone();
                                let v902: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v904: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v900.clone();
                                    let v906: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v904.lock();
                                    let v922: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method113(v906.unwrap());
                                    let v924: bool = true;
                                    let mut v922 = v922;
                                    let v926: &mut Option<std::process::Child> = &mut v922;
                                    let v928: Option<&mut std::process::Child> = v926.as_mut();
                                    let v930: &mut std::process::Child = v928.unwrap();
                                    let v932: &mut Option<std::process::ChildStdout> =
                                        &mut v930.stdout;
                                    let v934: Option<std::process::ChildStdout> =
                                        Option::take(v932);
                                    let v936: std::process::ChildStdout = v934.unwrap();
                                    let v938: bool = true;
                                    v936
                                })();
                                let v940: std::process::ChildStdout = _capture;
                                let v942: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v944: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v900.clone();
                                    let v946: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v944.lock();
                                    let v962: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method113(v946.unwrap());
                                    let v964: bool = true;
                                    let mut v962 = v962;
                                    let v966: &mut Option<std::process::Child> = &mut v962;
                                    let v968: Option<&mut std::process::Child> = v966.as_mut();
                                    let v970: &mut std::process::Child = v968.unwrap();
                                    let v972: &mut Option<std::process::ChildStderr> =
                                        &mut v970.stderr;
                                    let v974: Option<std::process::ChildStderr> =
                                        Option::take(v972);
                                    let v976: std::process::ChildStderr = v974.unwrap();
                                    let v978: bool = true;
                                    v976
                                })();
                                let v980: std::process::ChildStderr = _capture;
                                let v982: bool = true;
                                let _capture = (|| {
                                    //;
                                    let v984: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v900.clone();
                                    let v986: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v984.lock();
                                    let v1002: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method113(v986.unwrap());
                                    let v1004: bool = true;
                                    let mut v1002 = v1002;
                                    let v1006: &mut Option<std::process::Child> = &mut v1002;
                                    let v1008: Option<&mut std::process::Child> = v1006.as_mut();
                                    let v1010: &mut std::process::Child = v1008.unwrap();
                                    let v1012: &mut Option<std::process::ChildStdin> =
                                        &mut v1010.stdin;
                                    let v1014: Option<std::process::ChildStdin> =
                                        Option::take(v1012);
                                    let v1016: std::process::ChildStdin = v1014.unwrap();
                                    let v1022: Option<std::process::ChildStdin> =
                                        (Documents::method114())(Some(v1016));
                                    let v1024: std::sync::Mutex<Option<std::process::ChildStdin>> =
                                        std::sync::Mutex::new(v1022);
                                    let v1026: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::ChildStdin>>,
                                    > = std::sync::Arc::new(v1024);
                                    let v1028: bool = true;
                                    v1026
                                })();
                                let v1030: std::sync::Arc<
                                    std::sync::Mutex<Option<std::process::ChildStdin>>,
                                > = _capture;
                                let patternInput_2: (
                                    std::sync::mpsc::Sender<std::string::String>,
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                ) = {
                                    let (sender, receiver) = std::sync::mpsc::channel();
                                    (sender, std::sync::Arc::new(receiver))
                                };
                                let v1032: std::sync::mpsc::Sender<std::string::String> =
                                    patternInput_2.0.clone();
                                let v1035: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method115())(v1032.clone());
                                let v1037: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1035);
                                let v1039: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1037);
                                let v1041: std::sync::mpsc::Sender<std::string::String> =
                                    (Documents::method116())(v1032);
                                let v1043: std::sync::Mutex<
                                    std::sync::mpsc::Sender<std::string::String>,
                                > = std::sync::Mutex::new(v1041);
                                let v1045: std::sync::Arc<
                                    std::sync::Mutex<std::sync::mpsc::Sender<std::string::String>>,
                                > = std::sync::Arc::new(v1043);
                                let v1047: std::sync::Arc<
                                    std::sync::mpsc::Receiver<std::string::String>,
                                > = (Documents::method117())(patternInput_2.1.clone());
                                let v1049: std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                > = std::sync::Mutex::new(v1047);
                                let v1051: std::sync::Arc<
                                    std::sync::Mutex<
                                        std::sync::Arc<
                                            std::sync::mpsc::Receiver<std::string::String>,
                                        >,
                                    >,
                                > = std::sync::Arc::new(v1049);
                                let v1053: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v1055: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStdout,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v940);
                                    let v1057: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStdout,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v1055);
                                    let v1059: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStdout,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v1057);
                                    let v1061: bool = true;
                                    let mut v1059 = v1059;
                                    let _iter_try_for_each = v1059.try_for_each(|x| {
                                        //;
                                        let v1063: Result<std::string::String, std::io::Error> = x;
                                        let v1065: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1039.clone();
                                        let v1066 = Documents::method67();
                                        let v1070: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v1063.map_err(|x| v1066(x));
                                        let v1082 = Documents::method118();
                                        let v1083 = Documents::method119();
                                        let v1085: Documents::US27 = match v1070 {
                                            Ok(x) => v1082(x),
                                            Err(e) => v1083(e),
                                        };
                                        let v2493: std::string::String = match &v1085 {
                                            Documents::US27::US27_0(v1085_0_0) => {
                                                let v1088: string =
                                                    fable_library_rust::String_::fromString(
                                                        v1085_0_0.clone(),
                                                    );
                                                let v1090: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v1092: std::borrow::Cow<[u8]> =
                                                    v1090.encode(&*v1088).0;
                                                let v1094: &[u8] = v1092.as_ref();
                                                let v1096: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v1094);
                                                let v1100: &str = v1096.unwrap();
                                                let v1139: std::string::String =
                                                    String::from(v1100);
                                                let v1150: string = concat(new_array(&[
                                                    string("> "),
                                                    fable_library_rust::String_::fromString(
                                                        v1139.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v1467: () = {
                                                        Documents::closure52(v1150.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v1788: () = {
                                                        Documents::closure11(v1150, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                v1139
                                            }
                                            Documents::US27::US27_1(v1085_1_0) => {
                                                let v1790: std::string::String = v1085_1_0.clone();
                                                let v2104: () = {
                                                    Documents::closure51(v5, v1790.clone(), ());
                                                    ()
                                                };
                                                let v2419: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v1790);
                                                let v2426: &str = &*v2419;
                                                String::from(v2426)
                                            }
                                        };
                                        let v2495: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1065;
                                        let v2497: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v2495.lock();
                                        let v2501: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v2497.unwrap();
                                        let v2514: &std::sync::mpsc::Sender<std::string::String> =
                                            &v2501;
                                        let v2516: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v2514.send(v2493);
                                        let v2517 = Documents::method125();
                                        let v2521: Result<(), std::string::String> =
                                            v2516.map_err(|x| v2517(x));
                                        let v2534: _ = v2521;
                                        let v2536: bool = true;
                                        v2534
                                    }); //;
                                    let v2539: Result<(), string> = Documents::method126(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v2542: string = string("}");
                                    let v2547: bool = true;
                                    let _fix_closure_v2544 = v2539;
                                    let v2553: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v2544 "),
                                                    (v2542),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v2554: bool = true;
                                    _fix_closure_v2544
                                }); // rust.fix_closure';
                                let v2556: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v2558: bool = true;
                                let __spawn = std::thread::spawn(move || {
                                    //;
                                    let v2560: encoding_rs_io::DecodeReaderBytes<
                                        std::process::ChildStderr,
                                        Vec<u8>,
                                    > = encoding_rs_io::DecodeReaderBytesBuilder::new()
                                        .utf8_passthru(true)
                                        .build(v980);
                                    let v2562: std::io::BufReader<
                                        encoding_rs_io::DecodeReaderBytes<
                                            std::process::ChildStderr,
                                            Vec<u8>,
                                        >,
                                    > = std::io::BufReader::new(v2560);
                                    let v2564: std::io::Lines<
                                        std::io::BufReader<
                                            encoding_rs_io::DecodeReaderBytes<
                                                std::process::ChildStderr,
                                                Vec<u8>,
                                            >,
                                        >,
                                    > = std::io::BufRead::lines(v2562);
                                    let v2566: bool = true;
                                    let mut v2564 = v2564;
                                    let _iter_try_for_each = v2564.try_for_each(|x| {
                                        //;
                                        let v2568: Result<std::string::String, std::io::Error> = x;
                                        let v2570: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v1045.clone();
                                        let v2571 = Documents::method67();
                                        let v2575: Result<
                                            std::string::String,
                                            std::string::String,
                                        > = v2568.map_err(|x| v2571(x));
                                        let v2587 = Documents::method118();
                                        let v2588 = Documents::method119();
                                        let v2590: Documents::US27 = match v2575 {
                                            Ok(x) => v2587(x),
                                            Err(e) => v2588(e),
                                        };
                                        let v4061: std::string::String = match &v2590 {
                                            Documents::US27::US27_0(v2590_0_0) => {
                                                let v2593: string =
                                                    fable_library_rust::String_::fromString(
                                                        v2590_0_0.clone(),
                                                    );
                                                let v2595: &encoding_rs::Encoding =
                                                    encoding_rs::UTF_8;
                                                let v2597: std::borrow::Cow<[u8]> =
                                                    v2595.encode(&*v2593).0;
                                                let v2599: &[u8] = v2597.as_ref();
                                                let v2601: Result<&str, std::str::Utf8Error> =
                                                    std::str::from_utf8(v2599);
                                                let v2605: &str = v2601.unwrap();
                                                let v2644: std::string::String =
                                                    String::from(v2605);
                                                let v2655: string = concat(new_array(&[
                                                    string("! "),
                                                    fable_library_rust::String_::fromString(
                                                        v2644.clone(),
                                                    ),
                                                ]));
                                                if v5 {
                                                    let v2969: () = {
                                                        Documents::closure52(v2655.clone(), ());
                                                        ()
                                                    };
                                                    ()
                                                } else {
                                                    let v3287: () = {
                                                        Documents::closure11(v2655, ());
                                                        ()
                                                    };
                                                    ()
                                                }
                                                {
                                                    let v3289: string = sprintf!(
                                                        "\u{001b}[4;7m{}\u{001b}[0m",
                                                        v2644
                                                    );
                                                    let v3296: &str = &*v3289;
                                                    String::from(v3296)
                                                }
                                            }
                                            Documents::US27::US27_1(v2590_1_0) => {
                                                let v3362: std::string::String = v2590_1_0.clone();
                                                let v3674: () = {
                                                    Documents::closure51(v5, v3362.clone(), ());
                                                    ()
                                                };
                                                let v3987: string =
                                                    sprintf!("\u{001b}[4;7m{}\u{001b}[0m", v3362);
                                                let v3994: &str = &*v3987;
                                                String::from(v3994)
                                            }
                                        };
                                        let v4063: std::sync::Arc<
                                            std::sync::Mutex<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                        > = v2570;
                                        let v4065: Result<
                                            std::sync::MutexGuard<
                                                std::sync::mpsc::Sender<std::string::String>,
                                            >,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    std::sync::mpsc::Sender<std::string::String>,
                                                >,
                                            >,
                                        > = v4063.lock();
                                        let v4069: std::sync::MutexGuard<
                                            std::sync::mpsc::Sender<std::string::String>,
                                        > = v4065.unwrap();
                                        let v4082: &std::sync::mpsc::Sender<std::string::String> =
                                            &v4069;
                                        let v4084: Result<
                                            (),
                                            std::sync::mpsc::SendError<std::string::String>,
                                        > = v4082.send(v4061);
                                        let v4085 = Documents::method125();
                                        let v4089: Result<(), std::string::String> =
                                            v4084.map_err(|x| v4085(x));
                                        let v4102: _ = v4089;
                                        let v4104: bool = true;
                                        v4102
                                    }); //;
                                    let v4107: Result<(), string> = Documents::method126(
                                        _iter_try_for_each.map_err(|x| x.into()),
                                    );
                                    let v4108: string = string("}");
                                    let v4113: bool = true;
                                    let _fix_closure_v4110 = v4107;
                                    let v4119: string = append(
                                        (append(
                                            (append(
                                                (append(
                                                    string("true; _fix_closure_v4110 "),
                                                    (v4108),
                                                )),
                                                string("); "),
                                            )),
                                            string(""),
                                        )),
                                        string(" // rust.fix_closure\'"),
                                    );
                                    let v4120: bool = true;
                                    _fix_closure_v4110
                                }); // rust.fix_closure';
                                let v4122: std::thread::JoinHandle<Result<(), string>> = __spawn;
                                let v4147: Documents::US28 = defaultValue(
                                    Documents::US28::US28_1,
                                    map(Documents::method127(), v4.clone()),
                                );
                                match &v4147 {
                                    Documents::US28::US28_0(v4147_0_0) => {
                                        let v4153: std::sync::Arc<
                                            std::sync::Mutex<Option<std::process::ChildStdin>>,
                                        > = v1030.clone();
                                        let v4155: Result<
                                            std::sync::MutexGuard<Option<std::process::ChildStdin>>,
                                            std::sync::PoisonError<
                                                std::sync::MutexGuard<
                                                    Option<std::process::ChildStdin>,
                                                >,
                                            >,
                                        > = v4153.lock();
                                        let v4171: std::sync::MutexGuard<
                                            Option<std::process::ChildStdin>,
                                        > = Documents::method128(v4155.unwrap());
                                        let v4173: bool = true;
                                        let mut v4171 = v4171;
                                        let v4175: &mut Option<std::process::ChildStdin> =
                                            &mut v4171;
                                        let v4177: Option<std::process::ChildStdin> =
                                            Option::take(v4175);
                                        let v4179: bool = true;
                                        let _optionm_map_ = v4177.map(|x| {
                                            //;
                                            let v4181: std::process::ChildStdin = x;
                                            let v4183: std::sync::Mutex<std::process::ChildStdin> =
                                                std::sync::Mutex::new(v4181);
                                            let v4185: std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            > = std::sync::Arc::new(v4183);
                                            let v4187: bool = true;
                                            v4185
                                        });
                                        let v4189: Option<
                                            std::sync::Arc<
                                                std::sync::Mutex<std::process::ChildStdin>,
                                            >,
                                        > = _optionm_map_;
                                        let v4214: Documents::US29 = defaultValue(
                                            Documents::US29::US29_1,
                                            map(Documents::method129(), v4189),
                                        );
                                        match &v4214 {
                                            Documents::US29::US29_0(v4214_0_0) => {
                                                let v4218: std::sync::Arc<
                                                    std::sync::Mutex<std::process::ChildStdin>,
                                                > = match &v4214 {
                                                    Documents::US29::US29_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                }
                                                .clone();
                                                (match &v4147 {
                                                    Documents::US28::US28_0(x) => x.clone(),
                                                    _ => unreachable!(),
                                                })(
                                                    v4218.clone()
                                                );
                                                {
                                                    let v4220: std::sync::Arc<
                                                        std::sync::Mutex<std::process::ChildStdin>,
                                                    > = v4218;
                                                    let v4222: Result<
                                                        std::sync::MutexGuard<
                                                            std::process::ChildStdin,
                                                        >,
                                                        std::sync::PoisonError<
                                                            std::sync::MutexGuard<
                                                                std::process::ChildStdin,
                                                            >,
                                                        >,
                                                    > = v4220.lock();
                                                    let v4238: std::sync::MutexGuard<
                                                        std::process::ChildStdin,
                                                    > = Documents::method130(v4222.unwrap());
                                                    let v4240: bool = true;
                                                    let mut v4238 = v4238;
                                                    let v4242: bool = true;
                                                    std::io::Write::flush(&mut *v4238).unwrap();
                                                    ()
                                                }
                                            }
                                            _ => (),
                                        }
                                    }
                                    _ => (),
                                }
                                {
                                    let v4244: std::sync::Arc<
                                        std::sync::Mutex<Option<std::process::Child>>,
                                    > = v900;
                                    let v4246: Result<
                                        std::sync::MutexGuard<Option<std::process::Child>>,
                                        std::sync::PoisonError<
                                            std::sync::MutexGuard<Option<std::process::Child>>,
                                        >,
                                    > = v4244.lock();
                                    let v4262: std::sync::MutexGuard<Option<std::process::Child>> =
                                        Documents::method113(v4246.unwrap());
                                    let v4264: bool = true;
                                    let mut v4262 = v4262;
                                    let v4266: &mut Option<std::process::Child> = &mut v4262;
                                    let v4268: Option<std::process::Child> = Option::take(v4266);
                                    let v4270: std::process::Child = v4268.unwrap();
                                    let v4272: Result<std::process::Output, std::io::Error> =
                                        v4270.wait_with_output();
                                    let v4273 = Documents::method67();
                                    let v4286: Result<std::process::Output, std::string::String> =
                                        v4272.map_err(|x| v4273(x));
                                    let v4296: string = string("vec![v2556, v4122]");
                                    let v4297: Vec<std::thread::JoinHandle<Result<(), string>>> =
                                        vec![v2556, v4122];
                                    let v4299: bool = true;
                                    v4297.into_iter().for_each(|x| {
                                        //;
                                        let v4301: std::thread::JoinHandle<Result<(), string>> = x;
                                        let v4303: Result<
                                            Result<(), string>,
                                            Box<dyn core::any::Any + 'static + Send>,
                                        > = std::thread::JoinHandle::join(v4301);
                                        let v4307: Result<(), string> = v4303.unwrap();
                                        v4307.unwrap();
                                        {
                                            let v4324: bool = true;
                                            let v4326: bool = true;
                                        }
                                    });
                                    {
                                        //;
                                        let v4327 = Documents::method131();
                                        let v4328 = Documents::method132();
                                        let v4330: Documents::US30 = match &v4286 {
                                            Err(v4286_1_0) => v4328(v4286_1_0.clone()),
                                            Ok(v4286_0_0) => v4327(v4286_0_0.clone()),
                                        };
                                        match &v4330 {
                                            Documents::US30::US30_0(v4330_0_0) => {
                                                let v4335: std::process::ExitStatus =
                                                    v4330_0_0.clone().status;
                                                let v4337: Option<i32> = v4335.code();
                                                let v4362: Documents::US31 = defaultValue(
                                                    Documents::US31::US31_1,
                                                    map(Documents::method134(), v4337),
                                                );
                                                match &v4362 {
                                                    Documents::US31::US31_0(v4362_0_0) => (
                                                        match &v4362 {
                                                            Documents::US31::US31_0(x) => x.clone(),
                                                            _ => unreachable!(),
                                                        },
                                                        Documents::US7::US7_1,
                                                        Documents::US26::US26_0(v1051.clone()),
                                                    ),
                                                    _ => {
                                                        let v4376: &str = &*string(
                                                            "runtime.execute_with_options / exit_code=None",
                                                        );
                                                        (
                                                            -1_i32,
                                                            Documents::US7::US7_0(String::from(
                                                                v4376,
                                                            )),
                                                            Documents::US26::US26_0(v1051.clone()),
                                                        )
                                                    }
                                                }
                                            }
                                            Documents::US30::US30_1(v4330_1_0) => {
                                                let v4450: std::string::String = v4330_1_0.clone();
                                                let v4766: () = {
                                                    Documents::closure58(
                                                        v0_1.clone(),
                                                        v1_1.clone(),
                                                        v2.clone(),
                                                        v3.clone(),
                                                        v4.clone(),
                                                        v5,
                                                        v6.clone(),
                                                        v29.clone(),
                                                        v126.clone(),
                                                        v4450.clone(),
                                                        (),
                                                    );
                                                    ()
                                                };
                                                (
                                                    -2_i32,
                                                    Documents::US7::US7_0(v4450),
                                                    Documents::US26::US26_1,
                                                )
                                            }
                                        }
                                    }
                                }
                            }
                            Documents::US25::US25_1(v899_1_0) => {
                                let v5091: std::string::String = v899_1_0.clone();
                                let v5409: () = {
                                    Documents::closure45(
                                        v0_1.clone(),
                                        v1_1.clone(),
                                        v2.clone(),
                                        v3.clone(),
                                        v4.clone(),
                                        v5,
                                        v6.clone(),
                                        v29.clone(),
                                        v126.clone(),
                                        v5091.clone(),
                                        (),
                                    );
                                    ()
                                };
                                (
                                    -1_i32,
                                    Documents::US7::US7_0(v5091),
                                    Documents::US26::US26_1,
                                )
                            }
                        };
                        let v5735: Documents::US26 = patternInput_3.2.clone();
                        let v5734: Documents::US7 = patternInput_3.1.clone();
                        let v5733: i32 = patternInput_3.0.clone();
                        let v5746: Option<
                            std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            >,
                        > = match &v5735 {
                            Documents::US26::US26_0(v5735_0_0) => Some(
                                match &v5735 {
                                    Documents::US26::US26_0(x) => x.clone(),
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
                        let v5748: bool = true;
                        let _optionm_map_ = v5746.map(|x| {
                            //;
                            let v5750: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = x;
                            let v5752: std::sync::Arc<
                                std::sync::Mutex<
                                    std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                                >,
                            > = v5750;
                            let v5754: Result<
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
                            > = v5752.lock();
                            let v5758: std::sync::MutexGuard<
                                std::sync::Arc<std::sync::mpsc::Receiver<std::string::String>>,
                            > = v5754.unwrap();
                            let v5771 = v5758.iter();
                            let v5773: Vec<std::string::String> = v5771.collect::<Vec<_>>();
                            let v5775: bool = true;
                            let _vec_map: Vec<_> = v5773
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v5777: std::string::String = x;
                                    let v5779: string =
                                        fable_library_rust::String_::fromString(v5777);
                                    let v5781: bool = true;
                                    v5779
                                })
                                .collect::<Vec<_>>();
                            let v5783: Vec<string> = _vec_map;
                            let v5787: LrcPtr<dyn IEnumerable_1<string>> = ofArray_1(
                                fable_library_rust::NativeArray_::array_from(v5783.clone()),
                            );
                            let v5795: string = join(Documents::method135(), toArray_1(v5787));
                            let v5800: bool = true;
                            v5795
                        });
                        let v5802: Option<string> = _optionm_map_;
                        let v5809: Documents::US5 = match &v5734 {
                            Documents::US7::US7_0(v5734_0_0) => {
                                Documents::US5::US5_0(fable_library_rust::String_::fromString(
                                    match &v5734 {
                                        Documents::US7::US7_0(x) => x.clone(),
                                        _ => unreachable!(),
                                    }
                                    .clone(),
                                ))
                            }
                            _ => Documents::US5::US5_1,
                        };
                        let v5815: string = defaultValue(
                            match &v5809 {
                                Documents::US5::US5_0(v5809_0_0) => match &v5809 {
                                    Documents::US5::US5_0(x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone(),
                                _ => string(""),
                            },
                            v5802,
                        );
                        let v6132: () = {
                            Documents::closure60(v5733, v5815.clone(), ());
                            ()
                        };
                        LrcPtr::new((v5733, v5815))
                    }
                }))();
                _capture_v764.set(Some(x_5))
            }
            {
                let v6452: LrcPtr<(i32, string)> = match &_capture_v764.get().clone() {
                    None => panic!("{}", string("base.capture / _capture_v764=None"),),
                    Some(_capture_v764_0_0) => _capture_v764_0_0.clone(),
                };
                let _run_target_args__v15: (i32, string) = (v6452.0.clone(), v6452.1.clone());
                (
                    _run_target_args__v15.0.clone(),
                    _run_target_args__v15.1.clone(),
                )
            }
        }
        pub fn method157(v0_1: string, v1_1: string, v2: string) -> (string, string) {
            let v4: string = Documents::method26(v2, Documents::method45(v1_1.clone()));
            let v9: string = getSlice(
                v1_1.clone(),
                Some(0_i32),
                Some((lastIndexOf(v1_1.clone(), string("."))) - 1_i32),
            );
            let v16: string = getSlice(
                v4.clone(),
                Some(0_i32),
                Some((lastIndexOf(v4.clone(), string("."))) - 1_i32),
            );
            let v26: bool = (endsWith3(v0_1.clone(), string(".md"), false)) == false;
            (
                if v26 {
                    concat(new_array(&[v1_1, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v9, string("."), v0_1.clone()]))
                },
                if v26 {
                    concat(new_array(&[v4, string("."), v0_1.clone()]))
                } else {
                    concat(new_array(&[v16, string("."), v0_1]))
                },
            )
        }
        pub fn method158() -> string {
            string("")
        }
        pub fn closure69(unitVar: (), v0_1: string) -> Documents::US35 {
            Documents::US35::US35_0(v0_1)
        }
        pub fn method159() -> Func1<string, Documents::US35> {
            Func1::new(move |v: string| Documents::closure69((), v))
        }
        pub fn closure70(unitVar: (), v0_1: std::string::String) -> Documents::US35 {
            Documents::US35::US35_1(v0_1)
        }
        pub fn method160() -> Func1<std::string::String, Documents::US35> {
            Func1::new(move |v: std::string::String| Documents::closure70((), v))
        }
        pub fn method162(
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
            let v12: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v26: () = {
                Documents::closure8(v12.clone(), string("{ "), ());
                ()
            };
            let v45: () = {
                Documents::closure8(v12.clone(), string("file"), ());
                ()
            };
            let v64: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v81: () = {
                Documents::closure8(v12.clone(), v0_1, ());
                ()
            };
            let v100: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v119: () = {
                Documents::closure8(v12.clone(), string("real_path"), ());
                ()
            };
            let v136: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v153: () = {
                Documents::closure8(v12.clone(), v1_1, ());
                ()
            };
            let v170: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v189: () = {
                Documents::closure8(v12.clone(), string("relative_path"), ());
                ()
            };
            let v206: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v223: () = {
                Documents::closure8(v12.clone(), v2, ());
                ()
            };
            let v240: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v259: () = {
                Documents::closure8(v12.clone(), string("origin_hash_exit_code"), ());
                ()
            };
            let v276: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v296: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v3), ());
                ()
            };
            let v313: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v332: () = {
                Documents::closure8(v12.clone(), string("origin_hash"), ());
                ()
            };
            let v349: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v366: () = {
                Documents::closure8(v12.clone(), v4, ());
                ()
            };
            let v383: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v402: () = {
                Documents::closure8(v12.clone(), string("local_git_hash_exit_code"), ());
                ()
            };
            let v419: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v439: () = {
                Documents::closure8(v12.clone(), sprintf!("{}", v5), ());
                ()
            };
            let v456: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v475: () = {
                Documents::closure8(v12.clone(), string("local_git_hash"), ());
                ()
            };
            let v492: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v509: () = {
                Documents::closure8(v12.clone(), v6, ());
                ()
            };
            let v526: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v545: () = {
                Documents::closure8(v12.clone(), string("hash1"), ());
                ()
            };
            let v562: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v579: () = {
                Documents::closure8(v12.clone(), v7, ());
                ()
            };
            let v596: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v615: () = {
                Documents::closure8(v12.clone(), string("hash2"), ());
                ()
            };
            let v632: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v653: () = {
                Documents::closure8(v12.clone(), sprintf!("{:?}", v8), ());
                ()
            };
            let v670: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v689: () = {
                Documents::closure8(v12.clone(), string("dist_path"), ());
                ()
            };
            let v706: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v723: () = {
                Documents::closure8(v12.clone(), v9, ());
                ()
            };
            let v740: () = {
                Documents::closure8(v12.clone(), string("; "), ());
                ()
            };
            let v759: () = {
                Documents::closure8(v12.clone(), string("cache_path"), ());
                ()
            };
            let v776: () = {
                Documents::closure8(v12.clone(), string(" = "), ());
                ()
            };
            let v793: () = {
                Documents::closure8(v12.clone(), v10, ());
                ()
            };
            let v812: () = {
                Documents::closure8(v12.clone(), string(" }"), ());
                ()
            };
            v12.l0.get().clone()
        }
        pub fn method161(
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
                Documents::method162(v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19);
            Documents::method17(append(
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
        pub fn closure71(
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
            fn v26() {
                Documents::closure6((), ());
            }
            let v27: () = {
                v26();
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
            let v68: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v316: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v68,
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
                Documents::US6::US6_1
            } else {
                let v91: () = {
                    v26();
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
                let v119: Option<i64> = patternInput_1.5.clone();
                let v118: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v117: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v116: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v115: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v114: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v138: string = string(
                    "documents.run / par_map / origin_hash |> sm\'.contains local_git_hash |> not / Some hash2 when hash1 = hash2",
                );
                let v142: string = if (v138.clone()) == string("") {
                    string("")
                } else {
                    Documents::method161(
                        v114.clone(),
                        v115.clone(),
                        v116.clone(),
                        v117.clone(),
                        v118.clone(),
                        v119.clone(),
                        Documents::method7(v114, v115, v116, v117, v118, v119),
                        Documents::method11(),
                        v138,
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
                let v158: () = {
                    v26();
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
                let v182: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v181: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v203: () = {
                    Documents::closure9(v181.clone(), ());
                    ()
                };
                println!("{}", v142.clone());
                (v182.l0.get().clone())(v142);
                Documents::US6::US6_0(
                    v181,
                    v182,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure72(unitVar: (), v0_1: u64) -> Documents::US36 {
            Documents::US36::US36_0(v0_1)
        }
        pub fn method164() -> Func1<u64, Documents::US36> {
            Func1::new(move |v: u64| Documents::closure72((), v))
        }
        pub fn closure73(unitVar: (), v0_1: std::string::String) -> Documents::US36 {
            Documents::US36::US36_1(v0_1)
        }
        pub fn method165() -> Func1<std::string::String, Documents::US36> {
            Func1::new(move |v: std::string::String| Documents::closure73((), v))
        }
        pub fn method167(v0_1: string, v1_1: string, v2: std::string::String) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v18: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), string("old_path"), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v73: () = {
                Documents::closure8(v4.clone(), v0_1, ());
                ()
            };
            let v92: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v111: () = {
                Documents::closure8(v4.clone(), string("new_path"), ());
                ()
            };
            let v128: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v145: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v162: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v181: () = {
                Documents::closure8(v4.clone(), string("error"), ());
                ()
            };
            let v198: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v210: std::string::String = format!("{:#?}", v2);
            let v257: () = {
                Documents::closure8(
                    v4.clone(),
                    fable_library_rust::String_::fromString(v210),
                    (),
                );
                ()
            };
            let v276: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method166(
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
            let v11: string = Documents::method167(v8, v9, v10);
            Documents::method17(append(
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
        pub fn closure74(v0_1: string, v1_1: string, v2: std::string::String, unitVar: ()) {
            fn v18() {
                Documents::closure6((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v60,
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
                Documents::US6::US6_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v109: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v108: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v107: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v106: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method166(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Documents::method7(v106, v107, v108, v109, v110, v111),
                    Documents::method33(),
                    v1_1,
                    v0_1,
                    v2,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method169(v0_1: string, v1_1: string, v2: u64) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v18: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), string("old_path"), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v73: () = {
                Documents::closure8(v4.clone(), v0_1, ());
                ()
            };
            let v92: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v111: () = {
                Documents::closure8(v4.clone(), string("new_path"), ());
                ()
            };
            let v128: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v145: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v162: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v181: () = {
                Documents::closure8(v4.clone(), string("result"), ());
                ()
            };
            let v198: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v218: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v2), ());
                ()
            };
            let v237: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method168(
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
            let v11: string = Documents::method169(v8, v9, v10);
            Documents::method17(append(
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
        pub fn closure75(v0_1: string, v1_1: string, v2: u64, unitVar: ()) {
            fn v18() {
                Documents::closure6((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                1_i32
                    >= (find(
                        v60,
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
                Documents::US6::US6_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v109: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v108: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v107: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v106: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method168(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Documents::method7(v106, v107, v108, v109, v110, v111),
                    Documents::method64(),
                    v1_1,
                    v0_1,
                    v2,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method163(v0_1: string, v1_1: string) {
            let v4: Result<u64, std::io::Error> = std::fs::copy(&*v1_1.clone(), &*v0_1.clone());
            let v5 = Documents::method67();
            let v18: Result<u64, std::string::String> = v4.map_err(|x| v5(x));
            let v21 = Documents::method164();
            let v22 = Documents::method165();
            let v24: Documents::US36 = match &v18 {
                Err(v18_1_0) => v22(v18_1_0.clone()),
                Ok(v18_0_0) => v21(v18_0_0.clone()),
            };
            match &v24 {
                Documents::US36::US36_0(v24_0_0) => {
                    let v341: () = {
                        Documents::closure75(v0_1.clone(), v1_1.clone(), v24_0_0.clone(), ());
                        ()
                    };
                    ()
                }
                Documents::US36::US36_1(v24_1_0) => {
                    let v970: () = {
                        Documents::closure74(v0_1.clone(), v1_1.clone(), v24_1_0.clone(), ());
                        ()
                    };
                    ()
                }
            }
            ()
        }
        pub fn method171(v0_1: Vec<u8>) -> Vec<u8> {
            v0_1
        }
        pub fn method172(v0_1: i32, v1_1: LrcPtr<Documents::Mut7>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method173(v0_1: string) -> string {
            v0_1
        }
        pub fn method174(
            v0_1: std::sync::MutexGuard<std::process::ChildStdin>,
        ) -> std::sync::MutexGuard<std::process::ChildStdin> {
            v0_1
        }
        pub fn closure78(
            v0_1: string,
            v1_1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>,
        ) {
            let v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1_1;
            let v5: Result<
                std::sync::MutexGuard<std::process::ChildStdin>,
                std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>,
            > = v3.lock();
            let v9: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
            let v21: string = Documents::method173(v0_1);
            let v23: &[u8] = v21.as_bytes();
            let v24: std::sync::MutexGuard<std::process::ChildStdin> = Documents::method174(v9);
            let v26: bool = true;
            let mut v24 = v24;
            let v28: bool = true;
            std::io::Write::write_all(&mut *v24, v23).unwrap();
            ()
        }
        pub fn method175(v0_1: i32, v1_1: LrcPtr<Documents::Mut8>) -> bool {
            (v1_1.l0.get().clone()) < (v0_1)
        }
        pub fn method177(v0_1: i32, v1_1: i32, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v18: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), string("exit_code"), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Documents::closure8(v4.clone(), string("result_len"), ());
                ()
            };
            let v131: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v151: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v1_1), ());
                ()
            };
            let v168: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v187: () = {
                Documents::closure8(v4.clone(), string("output_path"), ());
                ()
            };
            let v204: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v221: () = {
                Documents::closure8(v4.clone(), v2, ());
                ()
            };
            let v240: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method176(
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
            let v11: string = Documents::method177(v8, v9, v10);
            Documents::method17(append(
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
        pub fn closure79(v0_1: string, v1_1: i32, v2: string, unitVar: ()) {
            fn v18() {
                Documents::closure6((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v301: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v60,
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
                Documents::US6::US6_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v109: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v108: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v107: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v106: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v127: string = Documents::method176(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Documents::method7(v106, v107, v108, v109, v110, v111),
                    Documents::method11(),
                    v1_1,
                    length(v2),
                    v0_1,
                );
                let v143: () = {
                    v18();
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
                let v167: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v166: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v188: () = {
                    Documents::closure9(v166.clone(), ());
                    ()
                };
                println!("{}", v127.clone());
                (v167.l0.get().clone())(v127);
                Documents::US6::US6_0(
                    v166,
                    v167,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method170(v0_1: string, v1_1: string, v2: string, v3: string) -> Documents::US37 {
            let v15: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v3);
            let v63: Vec<u8> = Documents::method171(v15.unwrap());
            let v65: Result<std::string::String, std::string::FromUtf8Error> =
                std::string::String::from_utf8(v63);
            let v69: std::string::String = v65.unwrap();
            let v121: Array<string> = split(
                fable_library_rust::String_::fromString(v69),
                string("\n"),
                -1_i32,
                0_i32,
            );
            let v124: i32 = get_Count(v121.clone());
            let v125: Array<string> = new_init(&string(""), v124);
            let v126: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                l0: MutCell::new(0_i32),
            });
            while Documents::method61(v124, v126.clone()) {
                let v128: i32 = v126.l0.get().clone();
                let v132: string = trim(v121[v128].clone());
                v125.get_mut()[v128 as usize] = v132;
                {
                    let v135: i32 = (v128) + 1_i32;
                    v126.l0.set(v135);
                    ()
                }
            }
            {
                let v136: i32 = get_Count(v125.clone());
                let v137: Array<string> = new_init(&string(""), v136);
                let v138: LrcPtr<Documents::Mut7> = LrcPtr::new(Documents::Mut7 {
                    l0: MutCell::new(0_i32),
                    l1: MutCell::new(0_i32),
                });
                while Documents::method172(v136, v138.clone()) {
                    let v140: i32 = v138.l0.get().clone();
                    let v141: i32 = v138.l1.get().clone();
                    let v142: string = v125[v140].clone();
                    let v150: i32 = if (v142.clone()) != string("") {
                        v137.get_mut()[v141 as usize] = v142;
                        (v141) + 1_i32
                    } else {
                        v141
                    };
                    let v151: i32 = (v140) + 1_i32;
                    v138.l0.set(v151);
                    v138.l1.set(v150);
                    ()
                }
                {
                    let v152: i32 = v138.l1.get().clone();
                    let v153: Array<string> = new_init(&string(""), v152);
                    let v154: LrcPtr<Documents::Mut6> = LrcPtr::new(Documents::Mut6 {
                        l0: MutCell::new(0_i32),
                    });
                    while Documents::method61(v152, v154.clone()) {
                        let v156: i32 = v154.l0.get().clone();
                        let v157: string = v137[v156].clone();
                        v153.get_mut()[v156 as usize] = v157;
                        {
                            let v158: i32 = (v156) + 1_i32;
                            v154.l0.set(v158);
                            ()
                        }
                    }
                    {
                        let _let__v163: LrcPtr<dyn IEnumerable_1<string>> = delay(Func0::new({
                            let v153 = v153.clone();
                            move || {
                                map_1(
                                    Func1::new({
                                        let v153 = v153.clone();
                                        move |i: i32| v153[i].clone()
                                    }),
                                    rangeNumeric(0_i32, 1_i32, (get_Count(v153.clone())) - 1_i32),
                                )
                            }
                        }));
                        let v179: string = concat(new_array(&[
                            join(Documents::method135(), toArray_1(_let__v163)),
                            string("\n\n"),
                        ]));
                        let patternInput: (i32, string) = Documents::method81(
                            concat(new_array(&[
                                Documents::method26(
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
                                v1_1,
                            ])),
                            None::<CancellationToken>,
                            new_empty::<(string, string)>(),
                            None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                            Some(Func1::new({
                                let v179 = v179.clone();
                                move |v: std::sync::Arc<
                                    std::sync::Mutex<std::process::ChildStdin>,
                                >| {
                                    Documents::closure78(v179.clone(), v)
                                }
                            })),
                            true,
                            None::<string>,
                        );
                        let v242: i32 = patternInput.0.clone();
                        let v250: Array<string> =
                            split(patternInput.1.clone(), string("\n"), -1_i32, 0_i32);
                        let v253: i32 = get_Count(v250.clone());
                        let v255: LrcPtr<Documents::Mut8> = LrcPtr::new(Documents::Mut8 {
                            l0: MutCell::new(0_i32),
                            l1: MutCell::new(string("")),
                            l2: MutCell::new(0_i32),
                            l3: MutCell::new(0_i32),
                        });
                        while Documents::method175(v136, v255.clone()) {
                            let v257: i32 = v255.l0.get().clone();
                            let matchValue: string = v255.l1.get().clone();
                            let matchValue_1: i32 = v255.l2.get().clone();
                            let v260: i32 = v255.l3.get().clone();
                            let v259: i32 = matchValue_1;
                            let v258: string = matchValue;
                            let v261: string = v125[v257].clone();
                            let patternInput_2: (string, i32, i32) = if (v261.clone()) == string("")
                            {
                                (
                                    concat(new_array(&[v258.clone(), string("\n")])),
                                    (v259) + 1_i32,
                                    (v260) + 1_i32,
                                )
                            } else {
                                let v266: i32 = (v259) - (v260);
                                (
                                    if (v266) >= (v253) {
                                        v258.clone()
                                    } else {
                                        let v269: string = v250[v266].clone();
                                        let v278: string = if contains(v269.clone(), string("://"))
                                        {
                                            v261
                                        } else {
                                            v269
                                        };
                                        if (v266) == ((v253) - 1_i32) {
                                            concat(new_array(&[v258.clone(), v278.clone()]))
                                        } else {
                                            concat(new_array(&[v258, v278, string("\n")]))
                                        }
                                    },
                                    (v259) + 1_i32,
                                    v260,
                                )
                            };
                            let v289: i32 = (v257) + 1_i32;
                            v255.l0.set(v289);
                            v255.l1.set(patternInput_2.0.clone());
                            v255.l2.set(patternInput_2.1.clone());
                            v255.l3.set(patternInput_2.2.clone());
                            ()
                        }
                        {
                            let matchValue_3: string = v255.l1.get().clone();
                            let matchValue_4: i32 = v255.l2.get().clone();
                            let matchValue_5: i32 = v255.l3.get().clone();
                            let v290: string = matchValue_3;
                            std::fs::write(&*v2.clone(), &*v290.clone()).unwrap();
                            {
                                let v605: () = {
                                    Documents::closure79(v2, v242, v290.clone(), ());
                                    ()
                                };
                                Documents::US37::US37_0(v242, v290)
                            }
                        }
                    }
                }
            }
        }
        pub fn method179(v0_1: i32, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), string("exit_code"), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v75: () = {
                Documents::closure8(v3.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v94: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v113: () = {
                Documents::closure8(v3.clone(), string("result"), ());
                ()
            };
            let v130: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v147: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v166: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method178(
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
            let v10: string = Documents::method179(v8, v9);
            Documents::method17(append(
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
        pub fn closure80(v0_1: string, v1_1: i32, unitVar: ()) {
            fn v17() {
                Documents::closure6((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v299: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v59,
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
                Documents::US6::US6_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v108: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v107: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v106: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v105: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v125: string = Documents::method178(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Documents::method7(v105, v106, v107, v108, v109, v110),
                    Documents::method11(),
                    v1_1,
                    v0_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v164: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v186: () = {
                    Documents::closure9(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Documents::US6::US6_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure77(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Documents::US34 {
            let patternInput: (string, string) = Documents::method157(v5, v4.clone(), v0_1);
            let v7: string = patternInput.1.clone();
            let v6: string = patternInput.0.clone();
            if if if (Documents::method28(v6.clone())) == false {
                true
            } else {
                (Documents::method28(v7.clone())) == false
            } {
                false
            } else {
                let v13: string = Documents::method36(v6.clone());
                let v15: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v13);
                let v19: std::fs::File = v15.unwrap();
                let v32: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v19);
                let v34: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v32);
                let v36: bool = true;
                let mut v34 = v34;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v39: sha2::Sha256 = result;
                    let v41: bool = true;
                    let mut v39 = v39;
                    let v43: usize = 0_i32 as usize;
                    let v47: _ = [0_u8; 1024];
                    let v49: bool = true;
                    loop {
                        // rust.loop;
                        let v51: bool = true;
                        let mut v47 = v47;
                        let v53: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v34, &mut v47);
                        let v66: usize = v53.unwrap();
                        if (v66) == (v43) {
                            let v74: bool = true;
                            break;
                            ()
                        }
                        {
                            let v76: usize = v66;
                            let v93: &_ = if (v76) == (v47.len()) {
                                &v47[v43..]
                            } else {
                                &v47[v43..v76]
                            };
                            sha2::Digest::update(&mut v39, v93);
                            {
                                let v96: bool = true;
                            } // rust.loop;
                            let v98: bool = true;
                        } // rust.loop;
                        let v100: bool = true;
                    } // rust.loop;
                    let v102: bool = true;
                    {
                        // rust.loop;
                        let v104: bool = true;
                        {
                            // rust.loop;
                            let v106: &[u8] = &sha2::Digest::finalize(v39);
                            let v108: Vec<u8> = v106.iter().map(|x| *x).collect::<Vec<_>>();
                            let v110: bool = true;
                            let _vec_map: Vec<_> = v108
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v112: u8 = x;
                                    let v114: std::string::String = format!("{:02x}", v112);
                                    let v116: string =
                                        fable_library_rust::String_::fromString(v114);
                                    let v118: bool = true;
                                    v116
                                })
                                .collect::<Vec<_>>();
                            let v120: Vec<string> = _vec_map;
                            let v122: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v120.clone());
                            let _let__v127: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v122 = v122.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v122 = v122.clone();
                                                move |i: i32| v122[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v122.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v136: string = Documents::method158();
                            let v143: string = join(
                                if (v136.clone()) == string("\n") {
                                    Documents::method63(v136.clone())
                                } else {
                                    v136
                                },
                                toArray_1(_let__v127),
                            );
                            let v150 = Documents::method67();
                            let v154: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v143).map_err(|x| v150(x));
                            let v166 = Documents::method159();
                            let v167 = Documents::method160();
                            let v169: Documents::US35 = match v154 {
                                Ok(x) => v166(x),
                                Err(e) => v167(e),
                            };
                            let v178: string = match &v169 {
                                Documents::US35::US35_0(v169_0_0) => v169_0_0.clone(),
                                Documents::US35::US35_1(v169_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v169_1_0.clone()
                                    ),
                                ),
                            };
                            let v179: string = Documents::method36(v7.clone());
                            let v181: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v179);
                            let v185: std::fs::File = v181.unwrap();
                            let v198: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v185);
                            let v200: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v198);
                            let v202: bool = true;
                            let mut v200 = v200;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v205: sha2::Sha256 = result;
                                let v207: bool = true;
                                let mut v205 = v205;
                                let v209: usize = 0_i32 as usize;
                                let v213: _ = [0_u8; 1024];
                                let v215: bool = true;
                                loop {
                                    // rust.loop;
                                    let v217: bool = true;
                                    let mut v213 = v213;
                                    let v219: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v200, &mut v213);
                                    let v232: usize = v219.unwrap();
                                    if (v232) == (v209) {
                                        let v240: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v242: usize = v232;
                                        let v259: &_ = if (v242) == (v213.len()) {
                                            &v213[v209..]
                                        } else {
                                            &v213[v209..v242]
                                        };
                                        sha2::Digest::update(&mut v205, v259);
                                        {
                                            let v262: bool = true;
                                        } // rust.loop;
                                        let v264: bool = true;
                                    } // rust.loop;
                                    let v266: bool = true;
                                } // rust.loop;
                                let v268: bool = true;
                                {
                                    // rust.loop;
                                    let v270: bool = true;
                                    {
                                        // rust.loop;
                                        let v272: &[u8] = &sha2::Digest::finalize(v205);
                                        let v274: Vec<u8> =
                                            v272.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v276: bool = true;
                                        let _vec_map: Vec<_> = v274
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v278: u8 = x;
                                                let v280: std::string::String =
                                                    format!("{:02x}", v278);
                                                let v282: string =
                                                    fable_library_rust::String_::fromString(v280);
                                                let v284: bool = true;
                                                v282
                                            })
                                            .collect::<Vec<_>>();
                                        let v286: Vec<string> = _vec_map;
                                        let v288: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(
                                                v286.clone(),
                                            );
                                        let _let__v293: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v288 = v288.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v288 = v288.clone();
                                                            move |i_1: i32| v288[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            (get_Count(v288.clone())) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v302: string = Documents::method158();
                                        let v309: string = join(
                                            if (v302.clone()) == string("\n") {
                                                Documents::method63(v302.clone())
                                            } else {
                                                v302
                                            },
                                            toArray_1(_let__v293),
                                        );
                                        let v316 = Documents::method67();
                                        let v320: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v309).map_err(|x| v316(x));
                                        let v332 = Documents::method159();
                                        let v333 = Documents::method160();
                                        let v335: Documents::US35 = match v320 {
                                            Ok(x) => v332(x),
                                            Err(e) => v333(e),
                                        };
                                        (v178)
                                            == (match &v335 {
                                                Documents::US35::US35_0(v335_0_0) => {
                                                    v335_0_0.clone()
                                                }
                                                Documents::US35::US35_1(v335_1_0) => panic!(
                                                    "{}",
                                                    sprintf!(
                                                        "resultm.get / Result value was Error: {}",
                                                        v335_1_0.clone()
                                                    ),
                                                ),
                                            })
                                    }
                                }
                            }
                        }
                    }
                }
            } {
                Documents::US34::US34_1
            } else {
                let v348: Documents::US37 = Documents::method170(v2, v3, v6.clone(), v4);
                match &v348 {
                    Documents::US37::US37_0(v348_0_0, v348_0_1) => {
                        let v350: string = v348_0_1.clone();
                        let v349: i32 = v348_0_0.clone();
                        if (v349) != 0_i32 {
                            let v668: () = {
                                Documents::closure80(v350.clone(), v349, ());
                                ()
                            };
                            Documents::US34::US34_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v6.clone(), v350)),
                            ))
                        } else {
                            if Documents::method28(v6.clone()) {
                                Documents::method163(v7.clone(), v6.clone())
                            } else {
                                panic!(
                                    "{}",
                                    concat(new_array(&[
                                        string("documents.files_fn / "),
                                        v6.clone(),
                                        string(" should exist")
                                    ])),
                                )
                            }
                            Documents::US34::US34_0(Ok::<string, LrcPtr<(string, string)>>(
                                v6.clone(),
                            ))
                        }
                    }
                    Documents::US37::US37_1(v348_1_0, v348_1_1) => {
                        Documents::US34::US34_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v6.clone(), v348_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure76(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Func1<string, Documents::US34> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                let v4 = v4.clone();
                move |v: string| {
                    Documents::closure77(
                        v0_1.clone(),
                        v1_1.clone(),
                        v2.clone(),
                        v3.clone(),
                        v4.clone(),
                        v,
                    )
                }
            })
        }
        pub fn method182(v0_1: i32, v1_1: string, v2: string) -> string {
            let v4: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v18: () = {
                Documents::closure8(v4.clone(), string("{ "), ());
                ()
            };
            let v37: () = {
                Documents::closure8(v4.clone(), string("exit_code"), ());
                ()
            };
            let v56: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v76: () = {
                Documents::closure8(v4.clone(), sprintf!("{}", v0_1), ());
                ()
            };
            let v95: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v114: () = {
                Documents::closure8(v4.clone(), string("output_path"), ());
                ()
            };
            let v131: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v148: () = {
                Documents::closure8(v4.clone(), v1_1, ());
                ()
            };
            let v165: () = {
                Documents::closure8(v4.clone(), string("; "), ());
                ()
            };
            let v184: () = {
                Documents::closure8(v4.clone(), string("result"), ());
                ()
            };
            let v201: () = {
                Documents::closure8(v4.clone(), string(" = "), ());
                ()
            };
            let v218: () = {
                Documents::closure8(v4.clone(), v2, ());
                ()
            };
            let v237: () = {
                Documents::closure8(v4.clone(), string(" }"), ());
                ()
            };
            v4.l0.get().clone()
        }
        pub fn method181(
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
            let v11: string = Documents::method182(v8, v9, v10);
            Documents::method17(append(
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
        pub fn closure83(v0_1: string, v1_1: string, v2: i32, unitVar: ()) {
            fn v18() {
                Documents::closure6((), ());
            }
            let v19: () = {
                v18();
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
            let v60: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                3_i32
                    >= (find(
                        v60,
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
                Documents::US6::US6_1
            } else {
                let v83: () = {
                    v18();
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
                let v111: Option<i64> = patternInput_1.5.clone();
                let v110: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v109: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v108: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v107: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v106: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method181(
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    v111.clone(),
                    Documents::method7(v106, v107, v108, v109, v110, v111),
                    Documents::method33(),
                    v2,
                    v0_1,
                    v1_1,
                );
                let v142: () = {
                    v18();
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
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method180(
            v0_1: bool,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
        ) -> Documents::US37 {
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
            let patternInput: (i32, string) = Documents::method81(
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
            );
            let v88: string = patternInput.1.clone();
            let v87: i32 = patternInput.0.clone();
            if (contains(v88.clone(), string("ERROR"))) == false {
                Documents::US37::US37_0(v87, v88.clone())
            } else {
                let v410: () = {
                    Documents::closure83(v1_1, v88.clone(), v87, ());
                    ()
                };
                Documents::US37::US37_1(v87, v88)
            }
        }
        pub fn closure82(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
            v4: string,
        ) -> Documents::US34 {
            let patternInput: (string, string) = Documents::method157(v4.clone(), v3.clone(), v0_1);
            let v6: string = patternInput.1.clone();
            let v5: string = patternInput.0.clone();
            if if if (Documents::method28(v5.clone())) == false {
                true
            } else {
                (Documents::method28(v6.clone())) == false
            } {
                false
            } else {
                let v12: string = Documents::method36(v5.clone());
                let v14: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v12);
                let v18: std::fs::File = v14.unwrap();
                let v31: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v18);
                let v33: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v31);
                let v35: bool = true;
                let mut v33 = v33;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v38: sha2::Sha256 = result;
                    let v40: bool = true;
                    let mut v38 = v38;
                    let v42: usize = 0_i32 as usize;
                    let v46: _ = [0_u8; 1024];
                    let v48: bool = true;
                    loop {
                        // rust.loop;
                        let v50: bool = true;
                        let mut v46 = v46;
                        let v52: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v33, &mut v46);
                        let v65: usize = v52.unwrap();
                        if (v65) == (v42) {
                            let v73: bool = true;
                            break;
                            ()
                        }
                        {
                            let v75: usize = v65;
                            let v92: &_ = if (v75) == (v46.len()) {
                                &v46[v42..]
                            } else {
                                &v46[v42..v75]
                            };
                            sha2::Digest::update(&mut v38, v92);
                            {
                                let v95: bool = true;
                            } // rust.loop;
                            let v97: bool = true;
                        } // rust.loop;
                        let v99: bool = true;
                    } // rust.loop;
                    let v101: bool = true;
                    {
                        // rust.loop;
                        let v103: bool = true;
                        {
                            // rust.loop;
                            let v105: &[u8] = &sha2::Digest::finalize(v38);
                            let v107: Vec<u8> = v105.iter().map(|x| *x).collect::<Vec<_>>();
                            let v109: bool = true;
                            let _vec_map: Vec<_> = v107
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v111: u8 = x;
                                    let v113: std::string::String = format!("{:02x}", v111);
                                    let v115: string =
                                        fable_library_rust::String_::fromString(v113);
                                    let v117: bool = true;
                                    v115
                                })
                                .collect::<Vec<_>>();
                            let v119: Vec<string> = _vec_map;
                            let v121: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v119.clone());
                            let _let__v126: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v121 = v121.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v121 = v121.clone();
                                                move |i: i32| v121[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v121.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v135: string = Documents::method158();
                            let v142: string = join(
                                if (v135.clone()) == string("\n") {
                                    Documents::method63(v135.clone())
                                } else {
                                    v135
                                },
                                toArray_1(_let__v126),
                            );
                            let v149 = Documents::method67();
                            let v153: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v142).map_err(|x| v149(x));
                            let v165 = Documents::method159();
                            let v166 = Documents::method160();
                            let v168: Documents::US35 = match v153 {
                                Ok(x) => v165(x),
                                Err(e) => v166(e),
                            };
                            let v177: string = match &v168 {
                                Documents::US35::US35_0(v168_0_0) => v168_0_0.clone(),
                                Documents::US35::US35_1(v168_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v168_1_0.clone()
                                    ),
                                ),
                            };
                            let v178: string = Documents::method36(v6.clone());
                            let v180: Result<std::fs::File, std::io::Error> =
                                std::fs::File::open(&*v178);
                            let v184: std::fs::File = v180.unwrap();
                            let v197: std::io::BufReader<std::fs::File> =
                                std::io::BufReader::new(v184);
                            let v199: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                std::io::BufReader::new(v197);
                            let v201: bool = true;
                            let mut v199 = v199;
                            let result: sha2::Sha256 = sha2::Digest::new();
                            {
                                let v204: sha2::Sha256 = result;
                                let v206: bool = true;
                                let mut v204 = v204;
                                let v208: usize = 0_i32 as usize;
                                let v212: _ = [0_u8; 1024];
                                let v214: bool = true;
                                loop {
                                    // rust.loop;
                                    let v216: bool = true;
                                    let mut v212 = v212;
                                    let v218: Result<usize, std::io::Error> =
                                        std::io::Read::read(&mut v199, &mut v212);
                                    let v231: usize = v218.unwrap();
                                    if (v231) == (v208) {
                                        let v239: bool = true;
                                        break;
                                        ()
                                    }
                                    {
                                        let v241: usize = v231;
                                        let v258: &_ = if (v241) == (v212.len()) {
                                            &v212[v208..]
                                        } else {
                                            &v212[v208..v241]
                                        };
                                        sha2::Digest::update(&mut v204, v258);
                                        {
                                            let v261: bool = true;
                                        } // rust.loop;
                                        let v263: bool = true;
                                    } // rust.loop;
                                    let v265: bool = true;
                                } // rust.loop;
                                let v267: bool = true;
                                {
                                    // rust.loop;
                                    let v269: bool = true;
                                    {
                                        // rust.loop;
                                        let v271: &[u8] = &sha2::Digest::finalize(v204);
                                        let v273: Vec<u8> =
                                            v271.iter().map(|x| *x).collect::<Vec<_>>();
                                        let v275: bool = true;
                                        let _vec_map: Vec<_> = v273
                                            .into_iter()
                                            .map(|x| {
                                                //;
                                                let v277: u8 = x;
                                                let v279: std::string::String =
                                                    format!("{:02x}", v277);
                                                let v281: string =
                                                    fable_library_rust::String_::fromString(v279);
                                                let v283: bool = true;
                                                v281
                                            })
                                            .collect::<Vec<_>>();
                                        let v285: Vec<string> = _vec_map;
                                        let v287: Array<string> =
                                            fable_library_rust::NativeArray_::array_from(
                                                v285.clone(),
                                            );
                                        let _let__v292: LrcPtr<dyn IEnumerable_1<string>> =
                                            delay(Func0::new({
                                                let v287 = v287.clone();
                                                move || {
                                                    map_1(
                                                        Func1::new({
                                                            let v287 = v287.clone();
                                                            move |i_1: i32| v287[i_1].clone()
                                                        }),
                                                        rangeNumeric(
                                                            0_i32,
                                                            1_i32,
                                                            (get_Count(v287.clone())) - 1_i32,
                                                        ),
                                                    )
                                                }
                                            }));
                                        let v301: string = Documents::method158();
                                        let v308: string = join(
                                            if (v301.clone()) == string("\n") {
                                                Documents::method63(v301.clone())
                                            } else {
                                                v301
                                            },
                                            toArray_1(_let__v292),
                                        );
                                        let v315 = Documents::method67();
                                        let v319: Result<string, std::string::String> =
                                            Ok::<string, std::io::Error>(v308).map_err(|x| v315(x));
                                        let v331 = Documents::method159();
                                        let v332 = Documents::method160();
                                        let v334: Documents::US35 = match v319 {
                                            Ok(x) => v331(x),
                                            Err(e) => v332(e),
                                        };
                                        (v177)
                                            == (match &v334 {
                                                Documents::US35::US35_0(v334_0_0) => {
                                                    v334_0_0.clone()
                                                }
                                                Documents::US35::US35_1(v334_1_0) => panic!(
                                                    "{}",
                                                    sprintf!(
                                                        "resultm.get / Result value was Error: {}",
                                                        v334_1_0.clone()
                                                    ),
                                                ),
                                            })
                                    }
                                }
                            }
                        }
                    }
                }
            } {
                Documents::US34::US34_1
            } else {
                let v347: Documents::US37 = Documents::method180(v2, v5.clone(), v3, v1_1, v4);
                match &v347 {
                    Documents::US37::US37_0(v347_0_0, v347_0_1) => {
                        let v349: string = v347_0_1.clone();
                        let v348: i32 = v347_0_0.clone();
                        if (v348) != 0_i32 {
                            let v667: () = {
                                Documents::closure80(v349.clone(), v348, ());
                                ()
                            };
                            Documents::US34::US34_0(Err::<string, LrcPtr<(string, string)>>(
                                LrcPtr::new((v5.clone(), v349)),
                            ))
                        } else {
                            if Documents::method28(v5.clone()) {
                                Documents::method163(v6.clone(), v5.clone())
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
                            Documents::US34::US34_0(Ok::<string, LrcPtr<(string, string)>>(
                                v5.clone(),
                            ))
                        }
                    }
                    Documents::US37::US37_1(v347_1_0, v347_1_1) => {
                        Documents::US34::US34_0(Err::<string, LrcPtr<(string, string)>>(
                            LrcPtr::new((v5.clone(), v347_1_1.clone())),
                        ))
                    }
                }
            }
        }
        pub fn closure81(
            v0_1: string,
            v1_1: string,
            v2: bool,
            v3: string,
        ) -> Func1<string, Documents::US34> {
            Func1::new({
                let v0_1 = v0_1.clone();
                let v1_1 = v1_1.clone();
                let v2 = v2.clone();
                let v3 = v3.clone();
                move |v: string| Documents::closure82(v0_1.clone(), v1_1.clone(), v2, v3.clone(), v)
            })
        }
        pub fn method184(v0_1: string, v1_1: string) -> string {
            let v3: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v17: () = {
                Documents::closure8(v3.clone(), string("{ "), ());
                ()
            };
            let v36: () = {
                Documents::closure8(v3.clone(), string("output_path"), ());
                ()
            };
            let v55: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v72: () = {
                Documents::closure8(v3.clone(), v0_1, ());
                ()
            };
            let v91: () = {
                Documents::closure8(v3.clone(), string("; "), ());
                ()
            };
            let v110: () = {
                Documents::closure8(v3.clone(), string("output_cache_path"), ());
                ()
            };
            let v127: () = {
                Documents::closure8(v3.clone(), string(" = "), ());
                ()
            };
            let v144: () = {
                Documents::closure8(v3.clone(), v1_1, ());
                ()
            };
            let v163: () = {
                Documents::closure8(v3.clone(), string(" }"), ());
                ()
            };
            v3.l0.get().clone()
        }
        pub fn method183(
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
            let v10: string = Documents::method184(v8, v9);
            Documents::method17(append(
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
        pub fn closure84(v0_1: string, v1_1: string, unitVar: ()) {
            fn v17() {
                Documents::closure6((), ());
            }
            let v18: () = {
                v17();
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
            let v59: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v299: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v59,
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
                Documents::US6::US6_1
            } else {
                let v82: () = {
                    v17();
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
                let v110: Option<i64> = patternInput_1.5.clone();
                let v109: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v108: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v107: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v106: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v105: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v125: string = Documents::method183(
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    v110.clone(),
                    Documents::method7(v105, v106, v107, v108, v109, v110),
                    Documents::method11(),
                    v1_1,
                    v0_1,
                );
                let v141: () = {
                    v17();
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
                let v165: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v164: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v186: () = {
                    Documents::closure9(v164.clone(), ());
                    ()
                };
                println!("{}", v125.clone());
                (v165.l0.get().clone())(v125);
                Documents::US6::US6_0(
                    v164,
                    v165,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method185(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: List<LrcPtr<Documents::UH5>>,
        ) -> List<LrcPtr<Documents::UH5>> {
            match v0_1.as_ref() {
                Documents::UH4::UH4_0 => v1_1.clone(),
                Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => cons(
                    match v0_1.as_ref() {
                        Documents::UH4::UH4_1(x, _) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                    Documents::method185(
                        match v0_1.as_ref() {
                            Documents::UH4::UH4_1(_, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure86(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: LrcPtr<Documents::UH4>,
        ) -> LrcPtr<Documents::UH4> {
            LrcPtr::new(Documents::UH4::UH4_1(v0_1, v1_1))
        }
        pub fn closure85(
            unitVar: (),
            v0_1: LrcPtr<Documents::UH5>,
        ) -> Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>> {
            Func1::new({
                let v0_1 = v0_1.clone();
                move |v: LrcPtr<Documents::UH4>| Documents::closure86(v0_1.clone(), v)
            })
        }
        pub fn method186()
        -> Func1<LrcPtr<Documents::UH5>, Func1<LrcPtr<Documents::UH4>, LrcPtr<Documents::UH4>>>
        {
            Func1::new(move |v: LrcPtr<Documents::UH5>| Documents::closure85((), v))
        }
        pub fn method188(
            v0_1: LrcPtr<Documents::UH5>,
            v1_1: List<(
                string,
                string,
                Func1<string, Func1<string, Documents::US34>>,
            )>,
        ) -> List<(
            string,
            string,
            Func1<string, Func1<string, Documents::US34>>,
        )> {
            match v0_1.as_ref() {
                Documents::UH5::UH5_0 => v1_1.clone(),
                Documents::UH5::UH5_1(v0_1_1_0, v0_1_1_1, v0_1_1_2, v0_1_1_3) => cons(
                    (
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(x, _, _, _) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, x, _, _) => x.clone(),
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
                                            Documents::UH5::UH5_1(_, _, x, _) => x.clone(),
                                            _ => unreachable!(),
                                        })(a0.clone(), a1)
                                    }
                                })
                            }
                        }),
                    ),
                    Documents::method188(
                        match v0_1.as_ref() {
                            Documents::UH5::UH5_1(_, _, _, x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        v1_1.clone(),
                    ),
                ),
            }
        }
        pub fn closure87(
            unitVar: (),
            _arg: (
                string,
                string,
                Func1<string, Func1<string, Documents::US34>>,
            ),
        ) -> Option<Result<string, LrcPtr<(string, string)>>> {
            let v4: Documents::US34 = (_arg.2.clone())(_arg.1.clone())(_arg.0.clone());
            match &v4 {
                Documents::US34::US34_0(v4_0_0) => Some(
                    match &v4 {
                        Documents::US34::US34_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => None::<Result<string, LrcPtr<(string, string)>>>,
            }
        }
        pub fn method189(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method190(
            v0_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            v0_1
        }
        pub fn method187(
            v0_1: LrcPtr<Documents::UH4>,
            v1_1: Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
        ) -> Vec<Option<Result<string, LrcPtr<(string, string)>>>> {
            let v0_1: MutCell<LrcPtr<Documents::UH4>> = MutCell::new(v0_1.clone());
            let v1_1: MutCell<Vec<Option<Result<string, LrcPtr<(string, string)>>>>> =
                MutCell::new(v1_1.clone());
            '_method187: loop {
                break '_method187 (match v0_1.get().clone().as_ref() {
                    Documents::UH4::UH4_0 => v1_1.get().clone(),
                    Documents::UH4::UH4_1(v0_1_1_0, v0_1_1_1) => {
                        let v8 = toArray(Documents::method188(
                            match v0_1.get().clone().as_ref() {
                                Documents::UH4::UH4_1(x, _) => x.clone(),
                                _ => unreachable!(),
                            }
                            .clone(),
                            empty::<(
                                string,
                                string,
                                Func1<string, Func1<string, Documents::US34>>,
                            )>(),
                        ));
                        let v12 = v8.to_vec();
                        let v14 = rayon::iter::IntoParallelIterator::into_par_iter(v12);
                        let v17 = rayon::iter::ParallelIterator::map(v14, |x| {
                            Func1::new(
                                move |arg10_0040: (
                                    string,
                                    string,
                                    Func1<string, Func1<string, Documents::US34>>,
                                )| {
                                    Documents::closure87((), arg10_0040)
                                },
                            )(x)
                        });
                        let v20: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method189(rayon::iter::ParallelIterator::collect(v17));
                        let v21: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                            Documents::method190(v1_1.get().clone());
                        let v23: bool = true;
                        let mut v21 = v21;
                        let v25: bool = true;
                        v21.extend(v20);
                        {
                            let v0_1_temp: LrcPtr<Documents::UH4> =
                                match v0_1.get().clone().as_ref() {
                                    Documents::UH4::UH4_1(_, x) => x.clone(),
                                    _ => unreachable!(),
                                }
                                .clone();
                            let v1_1_temp: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                                v21;
                            v0_1.set(v0_1_temp);
                            v1_1.set(v1_1_temp);
                            continue '_method187;
                        }
                    }
                });
            }
        }
        pub fn closure35(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
            v4: string,
            v5: string,
        ) -> Result<
            LrcPtr<(
                string,
                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
            )>,
            std::string::String,
        > {
            let v6: string = Documents::method59(v5);
            let v13: &str = &*v6.clone();
            let v49: std::string::String = String::from(v13);
            let v85: std::path::PathBuf = std::path::PathBuf::from(v49);
            let v121: std::path::Display = v85.display();
            let v157: std::string::String = format!("{}", v121);
            let v194: string = concat(new_array(&[
                string("."),
                replace(
                    replace(
                        fable_library_rust::String_::fromString(v157),
                        v3.clone(),
                        Documents::method79(),
                    ),
                    string("\\"),
                    string("/"),
                ),
            ]));
            let v195: string = Documents::method36(v6);
            let v197: string = Documents::method80(Documents::method26(v2.clone(), v194.clone()));
            let patternInput: (i32, string) = Documents::method81(
                concat(new_array(&[
                    string("git ls-tree --format=\'%(objectname)\' origin/gh-pages \""),
                    v197.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v2),
            );
            let v222: string = patternInput.1.clone();
            let v221: i32 = patternInput.0.clone();
            let v224: string = Documents::method80(Documents::method26(v3.clone(), v194.clone()));
            let patternInput_1: (i32, string) = Documents::method81(
                concat(new_array(&[
                    string("git hash-object \""),
                    v224.clone(),
                    string("\""),
                ])),
                None::<CancellationToken>,
                new_empty::<(string, string)>(),
                None::<Func1<(i32, string, bool), Arc<Async<()>>>>,
                None::<Func1<std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>, ()>>,
                true,
                Some(v3.clone()),
            );
            let v249: string = patternInput_1.1.clone();
            let v248: i32 = patternInput_1.0.clone();
            let v251: string = Documents::method80(Documents::method26(v4.clone(), v194.clone()));
            let v253: string =
                (Documents::method157(string("hangul.md"), v224.clone(), v4.clone()))
                    .0
                    .clone();
            let v1936: LrcPtr<Documents::UH4> = if contains(v222.clone(), v249.clone()) {
                LrcPtr::new(Documents::UH4::UH4_0)
            } else {
                let v266: string = Documents::method36(v224.clone());
                let v268: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v266);
                let v272: std::fs::File = v268.unwrap();
                let v285: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v272);
                let v287: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                    std::io::BufReader::new(v285);
                let v289: bool = true;
                let mut v287 = v287;
                let result: sha2::Sha256 = sha2::Digest::new();
                {
                    let v292: sha2::Sha256 = result;
                    let v294: bool = true;
                    let mut v292 = v292;
                    let v296: usize = 0_i32 as usize;
                    let v300: _ = [0_u8; 1024];
                    let v302: bool = true;
                    loop {
                        // rust.loop;
                        let v304: bool = true;
                        let mut v300 = v300;
                        let v306: Result<usize, std::io::Error> =
                            std::io::Read::read(&mut v287, &mut v300);
                        let v319: usize = v306.unwrap();
                        if (v319) == (v296) {
                            let v327: bool = true;
                            break;
                            ()
                        }
                        {
                            let v329: usize = v319;
                            let v346: &_ = if (v329) == (v300.len()) {
                                &v300[v296..]
                            } else {
                                &v300[v296..v329]
                            };
                            sha2::Digest::update(&mut v292, v346);
                            {
                                let v349: bool = true;
                            } // rust.loop;
                            let v351: bool = true;
                        } // rust.loop;
                        let v353: bool = true;
                    } // rust.loop;
                    let v355: bool = true;
                    {
                        // rust.loop;
                        let v357: bool = true;
                        {
                            // rust.loop;
                            let v359: &[u8] = &sha2::Digest::finalize(v292);
                            let v361: Vec<u8> = v359.iter().map(|x| *x).collect::<Vec<_>>();
                            let v363: bool = true;
                            let _vec_map: Vec<_> = v361
                                .into_iter()
                                .map(|x| {
                                    //;
                                    let v365: u8 = x;
                                    let v367: std::string::String = format!("{:02x}", v365);
                                    let v369: string =
                                        fable_library_rust::String_::fromString(v367);
                                    let v371: bool = true;
                                    v369
                                })
                                .collect::<Vec<_>>();
                            let v373: Vec<string> = _vec_map;
                            let v375: Array<string> =
                                fable_library_rust::NativeArray_::array_from(v373.clone());
                            let _let__v380: LrcPtr<dyn IEnumerable_1<string>> =
                                delay(Func0::new({
                                    let v375 = v375.clone();
                                    move || {
                                        map_1(
                                            Func1::new({
                                                let v375 = v375.clone();
                                                move |i: i32| v375[i].clone()
                                            }),
                                            rangeNumeric(
                                                0_i32,
                                                1_i32,
                                                (get_Count(v375.clone())) - 1_i32,
                                            ),
                                        )
                                    }
                                }));
                            let v389: string = Documents::method158();
                            let v396: string = join(
                                if (v389.clone()) == string("\n") {
                                    Documents::method63(v389.clone())
                                } else {
                                    v389
                                },
                                toArray_1(_let__v380),
                            );
                            let v403 = Documents::method67();
                            let v407: Result<string, std::string::String> =
                                Ok::<string, std::io::Error>(v396).map_err(|x| v403(x));
                            let v419 = Documents::method159();
                            let v420 = Documents::method160();
                            let v422: Documents::US35 = match v407 {
                                Ok(x) => v419(x),
                                Err(e) => v420(e),
                            };
                            let v431: string = match &v422 {
                                Documents::US35::US35_0(v422_0_0) => v422_0_0.clone(),
                                Documents::US35::US35_1(v422_1_0) => panic!(
                                    "{}",
                                    sprintf!(
                                        "resultm.get / Result value was Error: {}",
                                        v422_1_0.clone()
                                    ),
                                ),
                            };
                            let v598: Documents::US5 = if (Documents::method28(v251.clone()))
                                == false
                            {
                                Documents::US5::US5_1
                            } else {
                                let v435: string = Documents::method36(v251.clone());
                                let v437: Result<std::fs::File, std::io::Error> =
                                    std::fs::File::open(&*v435);
                                let v441: std::fs::File = v437.unwrap();
                                let v454: std::io::BufReader<std::fs::File> =
                                    std::io::BufReader::new(v441);
                                let v456: std::io::BufReader<std::io::BufReader<std::fs::File>> =
                                    std::io::BufReader::new(v454);
                                let v458: bool = true;
                                let mut v456 = v456;
                                let result: sha2::Sha256 = sha2::Digest::new();
                                {
                                    let v461: sha2::Sha256 = result;
                                    let v463: bool = true;
                                    let mut v461 = v461;
                                    let v465: usize = 0_i32 as usize;
                                    let v469: _ = [0_u8; 1024];
                                    let v471: bool = true;
                                    loop {
                                        // rust.loop;
                                        let v473: bool = true;
                                        let mut v469 = v469;
                                        let v475: Result<usize, std::io::Error> =
                                            std::io::Read::read(&mut v456, &mut v469);
                                        let v488: usize = v475.unwrap();
                                        if (v488) == (v465) {
                                            let v496: bool = true;
                                            break;
                                            ()
                                        }
                                        {
                                            let v498: usize = v488;
                                            let v515: &_ = if (v498) == (v469.len()) {
                                                &v469[v465..]
                                            } else {
                                                &v469[v465..v498]
                                            };
                                            sha2::Digest::update(&mut v461, v515);
                                            {
                                                let v518: bool = true;
                                            } // rust.loop;
                                            let v520: bool = true;
                                        } // rust.loop;
                                        let v522: bool = true;
                                    } // rust.loop;
                                    let v524: bool = true;
                                    {
                                        // rust.loop;
                                        let v526: bool = true;
                                        {
                                            // rust.loop;
                                            let v528: &[u8] = &sha2::Digest::finalize(v461);
                                            let v530: Vec<u8> =
                                                v528.iter().map(|x| *x).collect::<Vec<_>>();
                                            let v532: bool = true;
                                            let _vec_map: Vec<_> = v530
                                                .into_iter()
                                                .map(|x| {
                                                    //;
                                                    let v534: u8 = x;
                                                    let v536: std::string::String =
                                                        format!("{:02x}", v534);
                                                    let v538: string =
                                                        fable_library_rust::String_::fromString(
                                                            v536,
                                                        );
                                                    let v540: bool = true;
                                                    v538
                                                })
                                                .collect::<Vec<_>>();
                                            let v542: Vec<string> = _vec_map;
                                            let v544: Array<string> =
                                                fable_library_rust::NativeArray_::array_from(
                                                    v542.clone(),
                                                );
                                            let _let__v549: LrcPtr<dyn IEnumerable_1<string>> =
                                                delay(Func0::new({
                                                    let v544 = v544.clone();
                                                    move || {
                                                        map_1(
                                                            Func1::new({
                                                                let v544 = v544.clone();
                                                                move |i_1: i32| v544[i_1].clone()
                                                            }),
                                                            rangeNumeric(
                                                                0_i32,
                                                                1_i32,
                                                                (get_Count(v544.clone())) - 1_i32,
                                                            ),
                                                        )
                                                    }
                                                }));
                                            let v558: string = Documents::method158();
                                            let v565: string = join(
                                                if (v558.clone()) == string("\n") {
                                                    Documents::method63(v558.clone())
                                                } else {
                                                    v558
                                                },
                                                toArray_1(_let__v549),
                                            );
                                            let v572 = Documents::method67();
                                            let v576: Result<string, std::string::String> =
                                                Ok::<string, std::io::Error>(v565)
                                                    .map_err(|x| v572(x));
                                            let v588 = Documents::method159();
                                            let v589 = Documents::method160();
                                            let v591: Documents::US35 = match v576 {
                                                Ok(x) => v588(x),
                                                Err(e) => v589(e),
                                            };
                                            match &v591 {
                                                Documents::US35::US35_0(v591_0_0) => {
                                                    Documents::US5::US5_0(v591_0_0.clone())
                                                }
                                                _ => Documents::US5::US5_1,
                                            }
                                        }
                                    }
                                }
                            };
                            if let Documents::US5::US5_0(v598_0_0) = &v598 {
                                if (v431.clone()) == (v598_0_0.clone()) {
                                    LrcPtr::new(Documents::UH4::UH4_0)
                                } else {
                                    let v923: () = {
                                        Documents::closure71(
                                            v194.clone(),
                                            v195.clone(),
                                            v197.clone(),
                                            v222.clone(),
                                            v221,
                                            v224.clone(),
                                            v249.clone(),
                                            v248,
                                            v251.clone(),
                                            v431.clone(),
                                            v598.clone(),
                                            (),
                                        );
                                        ()
                                    };
                                    Documents::method163(v251.clone(), v224.clone());
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("hangul.md"),
                                            v224.clone(),
                                            Func2::new({
                                                let v0_1 = v0_1.clone();
                                                let v1_1 = v1_1.clone();
                                                let v3 = v3.clone();
                                                let v4 = v4.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v0_1 = v0_1.clone();
                                                        let v1_1 = v1_1.clone();
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |v: string| {
                                                            Documents::closure76(
                                                                v4.clone(),
                                                                v3.clone(),
                                                                v1_1.clone(),
                                                                v0_1.clone(),
                                                                v,
                                                            )
                                                        }
                                                    }))(
                                                        b0
                                                    )(
                                                        b1
                                                    )
                                                }
                                            }),
                                            LrcPtr::new(Documents::UH5::UH5_0),
                                        )),
                                        LrcPtr::new(Documents::UH4::UH4_1(
                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                string("html"),
                                                v224.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_1: string| {
                                                                Documents::closure81(
                                                                    v4.clone(),
                                                                    v3.clone(),
                                                                    false,
                                                                    v_1,
                                                                )
                                                            }
                                                        }))(
                                                            b0
                                                        )(
                                                            b1
                                                        )
                                                    }
                                                }),
                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                    string("pdf"),
                                                    v224.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_2: string| {
                                                                    Documents::closure81(
                                                                        v4.clone(),
                                                                        v3.clone(),
                                                                        false,
                                                                        v_2,
                                                                    )
                                                                }
                                                            }))(
                                                                b0
                                                            )(
                                                                b1
                                                            )
                                                        }
                                                    }),
                                                    LrcPtr::new(Documents::UH5::UH5_1(
                                                        string("epub"),
                                                        v224.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_3: string| {
                                                                        Documents::closure81(
                                                                            v4.clone(),
                                                                            v3.clone(),
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
                                                        LrcPtr::new(Documents::UH5::UH5_1(
                                                            string("html"),
                                                            v253.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_4: string| {
                                                                            Documents::closure81(
                                                                                v4.clone(),
                                                                                v3.clone(),
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
                                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                                string("pdf"),
                                                                v253.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_5: string| {
                                                                                Documents::closure81(
                                                                                    v4.clone(),
                                                                                    v3.clone(),
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
                                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                                    string("epub"),
                                                                    v253.clone(),
                                                                    Func2::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move
                                                                                                                                                                                                                                                                                                                                           |b0:
                                                                                                                                                                                                                                                                                                                                                string,
                                                                                                                                                                                                                                                                                                                                            b1:
                                                                                                                                                                                                                                                                                                                                                string|
                                                                                                                                                                                                                                                                                                                                           (Func1::new({
                                                                                                                                                                                                                                                                                                                                                           let v3
                                                                                                                                                                                                                                                                                                                                                               =
                                                                                                                                                                                                                                                                                                                                                               v3.clone();
                                                                                                                                                                                                                                                                                                                                                           let v4
                                                                                                                                                                                                                                                                                                                                                               =
                                                                                                                                                                                                                                                                                                                                                               v4.clone();
                                                                                                                                                                                                                                                                                                                                                           move
                                                                                                                                                                                                                                                                                                                                                               |v_6:
                                                                                                                                                                                                                                                                                                                                                                    string|
                                                                                                                                                                                                                                                                                                                                                               Documents::closure81(v4.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    v3.clone(),
                                                                                                                                                                                                                                                                                                                                                                                    true,
                                                                                                                                                                                                                                                                                                                                                                                    v_6)
                                                                                                                                                                                                                                                                                                                                                       }))(b0)(b1)
                                                                    }),
                                                                    LrcPtr::new(
                                                                        Documents::UH5::UH5_0,
                                                                    ),
                                                                )),
                                                            )),
                                                        )),
                                                    )),
                                                )),
                                            )),
                                            LrcPtr::new(Documents::UH4::UH4_0),
                                        )),
                                    ))
                                }
                            } else {
                                let v1590: () = {
                                    Documents::closure71(
                                        v194,
                                        v195.clone(),
                                        v197,
                                        v222,
                                        v221,
                                        v224.clone(),
                                        v249,
                                        v248,
                                        v251.clone(),
                                        v431,
                                        v598.clone(),
                                        (),
                                    );
                                    ()
                                };
                                Documents::method163(v251, v224.clone());
                                LrcPtr::new(Documents::UH4::UH4_1(
                                    LrcPtr::new(Documents::UH5::UH5_1(
                                        string("hangul.md"),
                                        v224.clone(),
                                        Func2::new({
                                            let v0_1 = v0_1.clone();
                                            let v1_1 = v1_1.clone();
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |b0: string, b1: string| {
                                                (Func1::new({
                                                    let v0_1 = v0_1.clone();
                                                    let v1_1 = v1_1.clone();
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |v_7: string| {
                                                        Documents::closure76(
                                                            v4.clone(),
                                                            v3.clone(),
                                                            v1_1.clone(),
                                                            v0_1.clone(),
                                                            v_7,
                                                        )
                                                    }
                                                }))(
                                                    b0
                                                )(b1)
                                            }
                                        }),
                                        LrcPtr::new(Documents::UH5::UH5_0),
                                    )),
                                    LrcPtr::new(Documents::UH4::UH4_1(
                                        LrcPtr::new(Documents::UH5::UH5_1(
                                            string("html"),
                                            v224.clone(),
                                            Func2::new({
                                                let v3 = v3.clone();
                                                let v4 = v4.clone();
                                                move |b0: string, b1: string| {
                                                    (Func1::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |v_8: string| {
                                                            Documents::closure81(
                                                                v4.clone(),
                                                                v3.clone(),
                                                                false,
                                                                v_8,
                                                            )
                                                        }
                                                    }))(
                                                        b0
                                                    )(
                                                        b1
                                                    )
                                                }
                                            }),
                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                string("pdf"),
                                                v224.clone(),
                                                Func2::new({
                                                    let v3 = v3.clone();
                                                    let v4 = v4.clone();
                                                    move |b0: string, b1: string| {
                                                        (Func1::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |v_9: string| {
                                                                Documents::closure81(
                                                                    v4.clone(),
                                                                    v3.clone(),
                                                                    false,
                                                                    v_9,
                                                                )
                                                            }
                                                        }))(
                                                            b0
                                                        )(
                                                            b1
                                                        )
                                                    }
                                                }),
                                                LrcPtr::new(Documents::UH5::UH5_1(
                                                    string("epub"),
                                                    v224.clone(),
                                                    Func2::new({
                                                        let v3 = v3.clone();
                                                        let v4 = v4.clone();
                                                        move |b0: string, b1: string| {
                                                            (Func1::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |v_10: string| {
                                                                    Documents::closure81(
                                                                        v4.clone(),
                                                                        v3.clone(),
                                                                        false,
                                                                        v_10,
                                                                    )
                                                                }
                                                            }))(
                                                                b0
                                                            )(
                                                                b1
                                                            )
                                                        }
                                                    }),
                                                    LrcPtr::new(Documents::UH5::UH5_1(
                                                        string("html"),
                                                        v253.clone(),
                                                        Func2::new({
                                                            let v3 = v3.clone();
                                                            let v4 = v4.clone();
                                                            move |b0: string, b1: string| {
                                                                (Func1::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |v_11: string| {
                                                                        Documents::closure81(
                                                                            v4.clone(),
                                                                            v3.clone(),
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
                                                        LrcPtr::new(Documents::UH5::UH5_1(
                                                            string("pdf"),
                                                            v253.clone(),
                                                            Func2::new({
                                                                let v3 = v3.clone();
                                                                let v4 = v4.clone();
                                                                move |b0: string, b1: string| {
                                                                    (Func1::new({
                                                                        let v3 = v3.clone();
                                                                        let v4 = v4.clone();
                                                                        move |v_12: string| {
                                                                            Documents::closure81(
                                                                                v4.clone(),
                                                                                v3.clone(),
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
                                                            LrcPtr::new(Documents::UH5::UH5_1(
                                                                string("epub"),
                                                                v253.clone(),
                                                                Func2::new({
                                                                    let v3 = v3.clone();
                                                                    let v4 = v4.clone();
                                                                    move |b0: string, b1: string| {
                                                                        (Func1::new({
                                                                            let v3 = v3.clone();
                                                                            let v4 = v4.clone();
                                                                            move |v_13: string| {
                                                                                Documents::closure81(
                                                                                    v4.clone(),
                                                                                    v3.clone(),
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
                                                                LrcPtr::new(Documents::UH5::UH5_0),
                                                            )),
                                                        )),
                                                    )),
                                                )),
                                            )),
                                        )),
                                        LrcPtr::new(Documents::UH4::UH4_0),
                                    )),
                                ))
                            }
                        }
                    }
                }
            };
            let v6420: Array<LrcPtr<Documents::UH5>> = toArray(Documents::method185(
                if (if let Documents::UH4::UH4_0 = v1936.as_ref() {
                    true
                } else {
                    false
                }) != true
                {
                    v1936
                } else {
                    let patternInput_3: (string, string) =
                        Documents::method157(string("epub"), v253.clone(), v4.clone());
                    let v1941: string = patternInput_3.1.clone();
                    let v1940: string = patternInput_3.0.clone();
                    let v2579: LrcPtr<Documents::UH5> = if if Documents::method28(v1940.clone()) {
                        true
                    } else {
                        if (Documents::method28(v1941.clone())) == false {
                            true
                        } else {
                            let v2258: () = {
                                Documents::closure84(v1941.clone(), v1940.clone(), ());
                                ()
                            };
                            Documents::method163(v1940, v1941);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v253.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_14: string| {
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_14)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            LrcPtr::new(Documents::UH5::UH5_0),
                        ))
                    } else {
                        LrcPtr::new(Documents::UH5::UH5_0)
                    };
                    let patternInput_4: (string, string) =
                        Documents::method157(string("pdf"), v253.clone(), v4.clone());
                    let v2582: string = patternInput_4.1.clone();
                    let v2581: string = patternInput_4.0.clone();
                    let v3218: LrcPtr<Documents::UH5> = if if Documents::method28(v2581.clone()) {
                        true
                    } else {
                        if (Documents::method28(v2582.clone())) == false {
                            true
                        } else {
                            let v2899: () = {
                                Documents::closure84(v2582.clone(), v2581.clone(), ());
                                ()
                            };
                            Documents::method163(v2581, v2582);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v253.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_15: string| {
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_15)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v2579.clone(),
                        ))
                    } else {
                        v2579
                    };
                    let patternInput_5: (string, string) =
                        Documents::method157(string("html"), v253.clone(), v4.clone());
                    let v3221: string = patternInput_5.1.clone();
                    let v3220: string = patternInput_5.0.clone();
                    let v3857: LrcPtr<Documents::UH5> = if if Documents::method28(v3220.clone()) {
                        true
                    } else {
                        if (Documents::method28(v3221.clone())) == false {
                            true
                        } else {
                            let v3538: () = {
                                Documents::closure84(v3221.clone(), v3220.clone(), ());
                                ()
                            };
                            Documents::method163(v3220, v3221);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v253,
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_16: string| {
                                            Documents::closure81(v4.clone(), v3.clone(), true, v_16)
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v3218.clone(),
                        ))
                    } else {
                        v3218
                    };
                    let patternInput_6: (string, string) =
                        Documents::method157(string("epub"), v224.clone(), v4.clone());
                    let v3859: string = patternInput_6.1.clone();
                    let v3858: string = patternInput_6.0.clone();
                    let v4495: LrcPtr<Documents::UH5> = if if Documents::method28(v3858.clone()) {
                        true
                    } else {
                        if (Documents::method28(v3859.clone())) == false {
                            true
                        } else {
                            let v4176: () = {
                                Documents::closure84(v3859.clone(), v3858.clone(), ());
                                ()
                            };
                            Documents::method163(v3858, v3859);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("epub"),
                            v224.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_17: string| {
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_17,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v3857.clone(),
                        ))
                    } else {
                        v3857
                    };
                    let patternInput_7: (string, string) =
                        Documents::method157(string("pdf"), v224.clone(), v4.clone());
                    let v4497: string = patternInput_7.1.clone();
                    let v4496: string = patternInput_7.0.clone();
                    let v5133: LrcPtr<Documents::UH5> = if if Documents::method28(v4496.clone()) {
                        true
                    } else {
                        if (Documents::method28(v4497.clone())) == false {
                            true
                        } else {
                            let v4814: () = {
                                Documents::closure84(v4497.clone(), v4496.clone(), ());
                                ()
                            };
                            Documents::method163(v4496, v4497);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("pdf"),
                            v224.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_18: string| {
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_18,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v4495.clone(),
                        ))
                    } else {
                        v4495
                    };
                    let patternInput_8: (string, string) =
                        Documents::method157(string("html"), v224.clone(), v4.clone());
                    let v5135: string = patternInput_8.1.clone();
                    let v5134: string = patternInput_8.0.clone();
                    let v5771: LrcPtr<Documents::UH5> = if if Documents::method28(v5134.clone()) {
                        true
                    } else {
                        if (Documents::method28(v5135.clone())) == false {
                            true
                        } else {
                            let v5452: () = {
                                Documents::closure84(v5135.clone(), v5134.clone(), ());
                                ()
                            };
                            Documents::method163(v5134, v5135);
                            false
                        }
                    } {
                        LrcPtr::new(Documents::UH5::UH5_1(
                            string("html"),
                            v224.clone(),
                            Func2::new({
                                let v3 = v3.clone();
                                let v4 = v4.clone();
                                move |b0: string, b1: string| {
                                    (Func1::new({
                                        let v3 = v3.clone();
                                        let v4 = v4.clone();
                                        move |v_19: string| {
                                            Documents::closure81(
                                                v4.clone(),
                                                v3.clone(),
                                                false,
                                                v_19,
                                            )
                                        }
                                    }))(b0)(b1)
                                }
                            }),
                            v5133.clone(),
                        ))
                    } else {
                        v5133
                    };
                    let patternInput_9: (string, string) =
                        Documents::method157(string("hangul.md"), v224.clone(), v4.clone());
                    let v5773: string = patternInput_9.1.clone();
                    let v5772: string = patternInput_9.0.clone();
                    LrcPtr::new(Documents::UH4::UH4_1(
                        if if Documents::method28(v5772.clone()) {
                            true
                        } else {
                            if (Documents::method28(v5773.clone())) == false {
                                true
                            } else {
                                let v6090: () = {
                                    Documents::closure84(v5773.clone(), v5772.clone(), ());
                                    ()
                                };
                                Documents::method163(v5772, v5773);
                                false
                            }
                        } {
                            LrcPtr::new(Documents::UH5::UH5_1(
                                string("hangul.md"),
                                v224,
                                Func2::new({
                                    let v0_1 = v0_1.clone();
                                    let v1_1 = v1_1.clone();
                                    let v3 = v3.clone();
                                    let v4 = v4.clone();
                                    move |b0: string, b1: string| {
                                        (Func1::new({
                                            let v0_1 = v0_1.clone();
                                            let v1_1 = v1_1.clone();
                                            let v3 = v3.clone();
                                            let v4 = v4.clone();
                                            move |v_20: string| {
                                                Documents::closure76(
                                                    v4.clone(),
                                                    v3.clone(),
                                                    v1_1.clone(),
                                                    v0_1.clone(),
                                                    v_20,
                                                )
                                            }
                                        }))(b0)(b1)
                                    }
                                }),
                                LrcPtr::new(Documents::UH5::UH5_0),
                            ))
                        } else {
                            LrcPtr::new(Documents::UH5::UH5_0)
                        },
                        LrcPtr::new(Documents::UH4::UH4_1(
                            v5771,
                            LrcPtr::new(Documents::UH4::UH4_0),
                        )),
                    ))
                },
                empty::<LrcPtr<Documents::UH5>>(),
            ));
            let v6424: Vec<LrcPtr<Documents::UH5>> = v6420.to_vec();
            let v6427: Vec<Option<Result<string, LrcPtr<(string, string)>>>> =
                new_empty::<Option<Result<string, LrcPtr<(string, string)>>>>().to_vec();
            let v6431: List<LrcPtr<Documents::UH5>> =
                ofArray(fable_library_rust::NativeArray_::array_from(v6424.clone()));
            Ok::<
                LrcPtr<(
                    string,
                    Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                )>,
                std::string::String,
            >(LrcPtr::new((
                v195,
                Documents::method187(
                    foldBack(
                        Func2::new(
                            move |b0: LrcPtr<Documents::UH5>, b1: LrcPtr<Documents::UH4>| {
                                (Documents::method186())(b0)(b1)
                            },
                        ),
                        v6431,
                        LrcPtr::new(Documents::UH4::UH4_0),
                    ),
                    v6427,
                ),
            )))
        }
        pub fn method23(
            v0_1: string,
            v1_1: string,
            v2: string,
            v3: string,
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
            let v5: Documents::US5 = Documents::method25(Documents::method24());
            let v11: Documents::US5 = match &v5 {
                Documents::US5::US5_0(v5_0_0) => Documents::US5::US5_0(
                    match &v5 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => Documents::method25(string(
                    "c:\\home\\git\\polyglot\\target\\Builder\\documents",
                )),
            };
            let v17: Documents::US5 = match &v11 {
                Documents::US5::US5_0(v11_0_0) => Documents::US5::US5_0(
                    match &v11 {
                        Documents::US5::US5_0(x) => x.clone(),
                        _ => unreachable!(),
                    }
                    .clone(),
                ),
                _ => Documents::method25(string("/workspaces")),
            };
            let v21: string = match &v17 {
                Documents::US5::US5_0(v17_0_0) => match &v17 {
                    Documents::US5::US5_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v36: string = Documents::method26(
                if string("deps") == (Documents::method45(v21.clone())) {
                    let v29: Documents::US5 =
                        Documents::method25(Documents::method31(v21.clone()).clone().unwrap());
                    match &v29 {
                        Documents::US5::US5_0(v29_0_0) => match &v29 {
                            Documents::US5::US5_0(x) => x.clone(),
                            _ => unreachable!(),
                        }
                        .clone(),
                        _ => panic!("{}", string("Option does not have a value."),),
                    }
                } else {
                    v21
                },
                string("polyglot"),
            );
            let v37: string = Documents::method59(v3);
            let v38: string = Documents::method59(v2);
            let v39: string = Documents::method59(v1_1);
            let v353: () = {
                Documents::closure24(v0_1.clone(), v37.clone(), v38.clone(), v39.clone(), ());
                ()
            };
            let v669: bool = true;
            let __future_init = Box::pin(
                /*;
                let v671: bool = */
                async move {
                    /*;
                    let v673: bool = */
                    ();
                    let v675: async_walkdir::WalkDir = async_walkdir::WalkDir::new(&*v38.clone());
                    let v678: async_walkdir::WalkDir =
                        async_walkdir::WalkDir::filter(v675, move |x| {
                            Func1::new(move |v: async_walkdir::DirEntry| {
                                Documents::closure25((), v)
                            })(x)
                        });
                    let v679 = Documents::method70();
                    let v681 = futures::stream::StreamExt::filter_map(v678, |x| async { v679(x) });
                    let v683: std::pin::Pin<Box<dyn std::future::Future<Output = Vec<string>>>> =
                        Box::pin(futures::stream::StreamExt::collect(v681));
                    let v685: Vec<string> = v683.await;
                    let v1001: () = {
                        Documents::closure34(v685.clone(), ());
                        ()
                    };
                    let v1319: rayon::vec::IntoIter<string> =
                        rayon::iter::IntoParallelIterator::into_par_iter(v685);
                    let v1322: rayon::iter::Map<rayon::vec::IntoIter<string>, _> =
                        rayon::iter::ParallelIterator::map(v1319, |x| {
                            Func1::new({
                                let v0_1 = v0_1.clone();
                                let v36 = v36.clone();
                                let v37 = v37.clone();
                                let v38 = v38.clone();
                                let v39 = v39.clone();
                                move |v_1: string| {
                                    Documents::closure35(
                                        v0_1.clone(),
                                        v36.clone(),
                                        v37.clone(),
                                        v38.clone(),
                                        v39.clone(),
                                        v_1,
                                    )
                                }
                            })(x)
                        });
                    let v1324: Vec<
                        Result<
                            LrcPtr<(
                                string,
                                Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                            )>,
                            std::string::String,
                        >,
                    > = rayon::iter::ParallelIterator::collect(v1322);
                    let v1331: string = string("}");
                    let v1336: bool = true;
                    let _fix_closure_v1333 = Ok::<
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
                    >(v1324);
                    let v1342: string = append(
                        (append(
                            (append(
                                (append(string("true; _fix_closure_v1333 "), (v1331))),
                                string("); "),
                            )),
                            string(""),
                        )),
                        string(" // rust.fix_closure\'"),
                    );
                    let v1343: bool = true;
                    _fix_closure_v1333
                },
            ); // rust.fix_closure';
            let v1345 = __future_init;
            v1345
        }
        pub fn closure88(
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
        ) -> Documents::US38 {
            Documents::US38::US38_0(v0_1)
        }
        pub fn method191() -> Func1<
            Vec<
                Result<
                    LrcPtr<(
                        string,
                        Vec<Option<Result<string, LrcPtr<(string, string)>>>>,
                    )>,
                    std::string::String,
                >,
            >,
            Documents::US38,
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
                >| Documents::closure88((), v),
            )
        }
        pub fn closure89(unitVar: (), v0_1: std::string::String) -> Documents::US38 {
            Documents::US38::US38_1(v0_1)
        }
        pub fn method192() -> Func1<std::string::String, Documents::US38> {
            Func1::new(move |v: std::string::String| Documents::closure89((), v))
        }
        pub fn method193(
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
            let v9: string = Documents::method76(v8);
            Documents::method17(append(
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
        pub fn closure90(v0_1: std::string::String, unitVar: ()) {
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v298: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                4_i32
                    >= (find(
                        v58,
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
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
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
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v124: string = Documents::method193(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method74(),
                    v0_1,
                );
                let v140: () = {
                    v16();
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
                let v164: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v163: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v185: () = {
                    Documents::closure9(v163.clone(), ());
                    ()
                };
                println!("{}", v124.clone());
                (v164.l0.get().clone())(v124);
                Documents::US6::US6_0(
                    v163,
                    v164,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn method195(v0_1: usize) -> string {
            let v2: LrcPtr<Documents::Mut3> = LrcPtr::new(Documents::Mut3 {
                l0: MutCell::new(Documents::method13()),
            });
            let v16: () = {
                Documents::closure8(v2.clone(), string("{ "), ());
                ()
            };
            let v35: () = {
                Documents::closure8(v2.clone(), string("result_len"), ());
                ()
            };
            let v54: () = {
                Documents::closure8(v2.clone(), string(" = "), ());
                ()
            };
            let v66: std::string::String = format!("{:#?}", v0_1);
            let v113: () = {
                Documents::closure8(v2.clone(), fable_library_rust::String_::fromString(v66), ());
                ()
            };
            let v132: () = {
                Documents::closure8(v2.clone(), string(" }"), ());
                ()
            };
            v2.l0.get().clone()
        }
        pub fn method194(
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
            let v9: string = Documents::method195(v8);
            Documents::method17(append(
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
        pub fn closure91(
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
            fn v16() {
                Documents::closure6((), ());
            }
            let v17: () = {
                v16();
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
            let v58: Documents::US0 = (patternInput.4.clone()).l0.get().clone();
            let v300: Documents::US6 = if (if ((patternInput.2.clone()).l0.get().clone()) == false {
                false
            } else {
                2_i32
                    >= (find(
                        v58,
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
                Documents::US6::US6_1
            } else {
                let v81: () = {
                    v16();
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
                let v109: Option<i64> = patternInput_1.5.clone();
                let v108: LrcPtr<Documents::Mut4> = patternInput_1.4.clone();
                let v107: LrcPtr<Documents::Mut3> = patternInput_1.3.clone();
                let v106: LrcPtr<Documents::Mut2> = patternInput_1.2.clone();
                let v105: LrcPtr<Documents::Mut1> = patternInput_1.1.clone();
                let v104: LrcPtr<Documents::Mut0> = patternInput_1.0.clone();
                let v126: string = Documents::method194(
                    v104.clone(),
                    v105.clone(),
                    v106.clone(),
                    v107.clone(),
                    v108.clone(),
                    v109.clone(),
                    Documents::method7(v104, v105, v106, v107, v108, v109),
                    Documents::method11(),
                    v0_1.len(),
                );
                let v142: () = {
                    v16();
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
                let v166: LrcPtr<Documents::Mut1> = patternInput_2.1.clone();
                let v165: LrcPtr<Documents::Mut0> = patternInput_2.0.clone();
                let v187: () = {
                    Documents::closure9(v165.clone(), ());
                    ()
                };
                println!("{}", v126.clone());
                (v166.l0.get().clone())(v126);
                Documents::US6::US6_0(
                    v165,
                    v166,
                    patternInput_2.2.clone(),
                    patternInput_2.3.clone(),
                    patternInput_2.4.clone(),
                    patternInput_2.5.clone(),
                )
            };
            ()
        }
        pub fn closure1(unitVar: (), v0_1: Array<string>) -> i32 {
            let v17: () = {
                Documents::closure2((), ());
                ()
            };
            let v345: () = {
                Documents::closure5(v0_1, ());
                ()
            };
            let v660: clap::Command = Documents::method0();
            let v662: clap::ArgMatches = clap::Command::get_matches(v660);
            let v663: string = Documents::method18();
            let v670: &str = &*v663;
            let v701: Option<std::string::String> =
                clap::ArgMatches::get_one(&v662.clone(), v670).cloned();
            let v726: Documents::US7 =
                defaultValue(Documents::US7::US7_1, map(Documents::method19(), v701));
            let v733: std::string::String = match &v726 {
                Documents::US7::US7_0(v726_0_0) => match &v726 {
                    Documents::US7::US7_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v735: string = fable_library_rust::String_::fromString(v733);
            let v736: string = Documents::method20();
            let v743: &str = &*v736;
            let v774: Option<std::string::String> =
                clap::ArgMatches::get_one(&v662.clone(), v743).cloned();
            let v799: Documents::US7 =
                defaultValue(Documents::US7::US7_1, map(Documents::method19(), v774));
            let v806: std::string::String = match &v799 {
                Documents::US7::US7_0(v799_0_0) => match &v799 {
                    Documents::US7::US7_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v808: string = fable_library_rust::String_::fromString(v806);
            let v809: string = Documents::method21();
            let v816: &str = &*v809;
            let v847: Option<std::string::String> =
                clap::ArgMatches::get_one(&v662.clone(), v816).cloned();
            let v872: Documents::US7 =
                defaultValue(Documents::US7::US7_1, map(Documents::method19(), v847));
            let v879: std::string::String = match &v872 {
                Documents::US7::US7_0(v872_0_0) => match &v872 {
                    Documents::US7::US7_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v881: string = fable_library_rust::String_::fromString(v879);
            let v882: string = Documents::method22();
            let v889: &str = &*v882;
            let v920: Option<std::string::String> = clap::ArgMatches::get_one(&v662, v889).cloned();
            let v945: Documents::US7 =
                defaultValue(Documents::US7::US7_1, map(Documents::method19(), v920));
            let v952: std::string::String = match &v945 {
                Documents::US7::US7_0(v945_0_0) => match &v945 {
                    Documents::US7::US7_0(x) => x.clone(),
                    _ => unreachable!(),
                }
                .clone(),
                _ => panic!("{}", string("Option does not have a value."),),
            };
            let v955: std::pin::Pin<
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
            > = Documents::method23(
                fable_library_rust::String_::fromString(v952),
                v881,
                v808,
                v735,
            );
            let v957: Result<
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
            > = futures::executor::block_on(v955);
            let v958 = Documents::method191();
            let v959 = Documents::method192();
            let v961: Documents::US38 = match &v957 {
                Err(v957_1_0) => v959(v957_1_0.clone()),
                Ok(v957_0_0) => v958(v957_0_0.clone()),
            };
            match &v961 {
                Documents::US38::US38_0(v961_0_0) => {
                    let v1280: () = {
                        Documents::closure91(v961_0_0.clone(), ());
                        ()
                    };
                    0_i32
                }
                Documents::US38::US38_1(v961_1_0) => {
                    let v1911: () = {
                        Documents::closure90(v961_1_0.clone(), ());
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
