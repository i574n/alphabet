#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_patterns, unreachable_code, while_true)]
#![recursion_limit = "512"]
use std::cell::RefCell;
use std::rc::Rc;
fn spiral_trace_hold<T: Clone>(fresh: &std::rc::Rc<dyn Fn() -> T>) -> T {
    use std::sync::OnceLock;
    static SLOT: OnceLock<usize> = OnceLock::new();
    let raw = *SLOT.get_or_init(|| Box::into_raw(Box::new((*fresh)())) as usize);
    unsafe { (*(raw as *const T)).clone() }
}
#[cfg(target_arch = "wasm32")]
fn spiral_trace_near_log(text: &str) {
    use std::sync::atomic::{AtomicUsize, Ordering};
    static LOGGED: AtomicUsize = AtomicUsize::new(0);
    let cs: Vec<char> = text.chars().collect();
    for c in cs.chunks(15000) {
        let s: String = c.iter().collect();
        let used = LOGGED.load(Ordering::Relaxed);
        let budget = 16000usize.saturating_sub(used);
        if budget < 13 {
            break;
        }
        let s = if s.len() <= budget {
            s
        } else {
            let mut end = budget - 12;
            while !s.is_char_boundary(end) {
                end -= 1;
            }
            format!("{} [truncated]", &s[..end])
        };
        LOGGED.store(used + s.len(), Ordering::Relaxed);
        near_sdk::env::log_str(&s);
    }
}
fn string_slice(value: &str, from: i64, to: i64) -> Rc<str> {
    let bytes = value.as_bytes();
    let length = bytes.len() as i64;
    if from < 0 || from > length || to < from - 1 || to >= length { std::process::abort(); }
    if to < from { return { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) }; }
    // A slice that starts or ends inside a code point fails like the C and Delphi backends (abort / Halt(3)).
    if (bytes[from as usize] & 0xC0) == 0x80 || (to + 1 < length && (bytes[(to + 1) as usize] & 0xC0) == 0x80) { std::process::exit(3); }
    let slice = &bytes[from as usize..(to + 1) as usize];
    match std::str::from_utf8(slice) { Ok(text) => Rc::<str>::from(text), Err(error) => Rc::<str>::from(std::str::from_utf8(&slice[..error.valid_up_to()]).unwrap_or("")) }
}
struct Mut0 { l0: i64 }
struct Mut1 { l0: Rc<dyn Fn(Rc<str>) -> ()> }
struct Mut2 { l0: bool }
struct Mut3 { l0: Rc<str> }
#[derive(Clone)]
enum US0 {
    US0_0,
    US0_1,
    US0_2,
    US0_3,
    US0_4,
}
impl US0 {
    fn tag(&self) -> i32 {
        match self {
            US0::US0_0 => 0,
            US0::US0_1 => 1,
            US0::US0_2 => 2,
            US0::US0_3 => 3,
            US0::US0_4 => 4,
        }
    }
}
struct Mut4 { l0: US0 }
#[derive(Clone)]
enum US1 {
    US1_0(US0),
    US1_1,
}
impl US1 {
    fn tag(&self) -> i32 {
        match self {
            US1::US1_0(..) => 0,
            US1::US1_1 => 1,
        }
    }
}
struct Mut5 { l0: i32, l1: US1 }
#[derive(Clone)]
enum US2 {
    US2_0(Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>),
    US2_1,
}
impl US2 {
    fn tag(&self) -> i32 {
        match self {
            US2::US2_0(..) => 0,
            US2::US2_1 => 1,
        }
    }
}
#[derive(Clone)]
enum US3 {
    US3_0(std::string::String),
    US3_1,
}
impl US3 {
    fn tag(&self) -> i32 {
        match self {
            US3::US3_0(..) => 0,
            US3::US3_1 => 1,
        }
    }
}
#[derive(Clone)]
enum US4 {
    US4_0(Rc<str>),
    US4_1,
}
impl US4 {
    fn tag(&self) -> i32 {
        match self {
            US4::US4_0(..) => 0,
            US4::US4_1 => 1,
        }
    }
}
#[derive(Clone)]
enum US5 {
    US5_0,
    US5_1,
}
impl US5 {
    fn tag(&self) -> i32 {
        match self {
            US5::US5_0 => 0,
            US5::US5_1 => 1,
        }
    }
}
#[derive(Clone)]
enum US6 {
    US6_0(Rc<str>),
    US6_1(Rc<str>),
}
impl US6 {
    fn tag(&self) -> i32 {
        match self {
            US6::US6_0(..) => 0,
            US6::US6_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US7 {
    US7_0(std::path::PathBuf),
    US7_1(Rc<str>),
}
impl US7 {
    fn tag(&self) -> i32 {
        match self {
            US7::US7_0(..) => 0,
            US7::US7_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US8 {
    US8_0(std::path::PathBuf),
    US8_1,
}
impl US8 {
    fn tag(&self) -> i32 {
        match self {
            US8::US8_0(..) => 0,
            US8::US8_1 => 1,
        }
    }
}
struct Mut6 { l0: i32, l1: i32, l2: Rc<RefCell<Vec<Rc<str>>>> }
struct Mut7 { l0: i32 }
#[derive(Clone)]
enum US9 {
    US9_0(Rc<str>, US4),
    US9_1(Rc<str>),
}
impl US9 {
    fn tag(&self) -> i32 {
        match self {
            US9::US9_0(..) => 0,
            US9::US9_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US10 {
    US10_0(u8, i32, i32, i32, i32, i32),
    US10_1(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
impl US10 {
    fn tag(&self) -> i32 {
        match self {
            US10::US10_0(..) => 0,
            US10::US10_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US11 {
    US11_0(Rc<str>, i32, i32, i32, i32, i32),
    US11_1(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
impl US11 {
    fn tag(&self) -> i32 {
        match self {
            US11::US11_0(..) => 0,
            US11::US11_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US12 {
    US12_0(i32, i32, i32, i32, i32),
    US12_1(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
impl US12 {
    fn tag(&self) -> i32 {
        match self {
            US12::US12_0(..) => 0,
            US12::US12_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US14 {
    US14_0(Rc<dyn Fn() -> Rc<str>>),
    US14_1,
}
impl US14 {
    fn tag(&self) -> i32 {
        match self {
            US14::US14_0(..) => 0,
            US14::US14_1 => 1,
        }
    }
}
#[derive(Clone)]
enum US13 {
    US13_0(Rc<dyn Fn() -> Rc<str>>, Rc<dyn Fn() -> US14>, i32, i32, i32, i32, i32),
    US13_1(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
impl US13 {
    fn tag(&self) -> i32 {
        match self {
            US13::US13_0(..) => 0,
            US13::US13_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US15 {
    US15_0(US14, i32, i32, i32, i32, i32),
    US15_1(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
impl US15 {
    fn tag(&self) -> i32 {
        match self {
            US15::US15_0(..) => 0,
            US15::US15_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US16 {
    US16_0(Rc<dyn Fn() -> Rc<str>>, Rc<dyn Fn() -> US14>, Rc<str>, i32, i32, i32, i32),
    US16_1(Rc<dyn Fn() -> Rc<str>>),
}
impl US16 {
    fn tag(&self) -> i32 {
        match self {
            US16::US16_0(..) => 0,
            US16::US16_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US17 {
    US17_0(Rc<str>, US4),
    US17_1(Rc<dyn Fn() -> Rc<str>>),
}
impl US17 {
    fn tag(&self) -> i32 {
        match self {
            US17::US17_0(..) => 0,
            US17::US17_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US18 {
    US18_0(Rc<RefCell<Vec<Rc<str>>>>),
    US18_1(Rc<str>),
}
impl US18 {
    fn tag(&self) -> i32 {
        match self {
            US18::US18_0(..) => 0,
            US18::US18_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum UH0 {
    UH0_0,
    UH0_1(Rc<str>, Rc<UH0>),
}
impl UH0 {
    fn tag(&self) -> i32 {
        match self {
            UH0::UH0_0 => 0,
            UH0::UH0_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US19 {
    US19_0(Rc<UH0>, i32, i32, i32, i32, i32),
    US19_1(Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, i32, i32, i32, i32, i32),
}
impl US19 {
    fn tag(&self) -> i32 {
        match self {
            US19::US19_0(..) => 0,
            US19::US19_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US20 {
    US20_0(Rc<UH0>, Rc<str>, i32, i32, i32, i32),
    US20_1(Rc<dyn Fn() -> Rc<str>>),
}
impl US20 {
    fn tag(&self) -> i32 {
        match self {
            US20::US20_0(..) => 0,
            US20::US20_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US21 {
    US21_0(Rc<RefCell<Vec<Rc<str>>>>),
    US21_1(Rc<dyn Fn() -> Rc<str>>),
}
impl US21 {
    fn tag(&self) -> i32 {
        match self {
            US21::US21_0(..) => 0,
            US21::US21_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US22 {
    US22_0(std::string::String),
    US22_1(std::string::String),
}
impl US22 {
    fn tag(&self) -> i32 {
        match self {
            US22::US22_0(..) => 0,
            US22::US22_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US23 {
    US23_0(i32),
    US23_1,
}
impl US23 {
    fn tag(&self) -> i32 {
        match self {
            US23::US23_0(..) => 0,
            US23::US23_1 => 1,
        }
    }
}
#[derive(Clone)]
enum US24 {
    US24_0(Result<Rc<str>, (Rc<str>, Rc<str>)>),
    US24_1,
}
impl US24 {
    fn tag(&self) -> i32 {
        match self {
            US24::US24_0(..) => 0,
            US24::US24_1 => 1,
        }
    }
}
#[derive(Clone)]
enum UH2 {
    UH2_0,
    UH2_1(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>, Rc<UH2>),
}
impl UH2 {
    fn tag(&self) -> i32 {
        match self {
            UH2::UH2_0 => 0,
            UH2::UH2_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum UH1 {
    UH1_0,
    UH1_1(Rc<UH2>, Rc<UH1>),
}
impl UH1 {
    fn tag(&self) -> i32 {
        match self {
            UH1::UH1_0 => 0,
            UH1::UH1_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US25 {
    US25_0(Rc<str>),
    US25_1(std::string::String),
}
impl US25 {
    fn tag(&self) -> i32 {
        match self {
            US25::US25_0(..) => 0,
            US25::US25_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US26 {
    US26_0(u64),
    US26_1(std::string::String),
}
impl US26 {
    fn tag(&self) -> i32 {
        match self {
            US26::US26_0(..) => 0,
            US26::US26_1(..) => 1,
        }
    }
}
#[derive(Clone)]
enum US27 {
    US27_0(i32, Rc<str>),
    US27_1(i32, Rc<str>),
}
impl US27 {
    fn tag(&self) -> i32 {
        match self {
            US27::US27_0(..) => 0,
            US27::US27_1(..) => 1,
        }
    }
}
struct Mut8 { l0: i32, l1: i32 }
struct Mut9 { l0: i32, l1: Rc<str>, l2: i32, l3: i32 }
#[derive(Clone)]
enum US28 {
    US28_0(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>),
    US28_1(std::string::String),
}
impl US28 {
    fn tag(&self) -> i32 {
        match self {
            US28::US28_0(..) => 0,
            US28::US28_1(..) => 1,
        }
    }
}
fn method1(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = Rc::<str>::from(std::env::var(&*v0).unwrap_or_default());
    v1.clone()
}
fn method2(mut v0: i32, mut v1: Rc<RefCell<Mut5>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn closure1() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        ()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method0(mut v0: US0) -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("TRACE_LEVEL"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = method1(v1.clone());
    ;
    ;
    ;
    ;
    ;
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Critical"); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<str> = Rc::<str>::from(v3.to_lowercase());
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let mut v6: Rc<str> = Rc::<str>::from(v5.to_lowercase());
    let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
    let mut v8: Rc<str> = Rc::<str>::from(v7.to_lowercase());
    let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v10: Rc<str> = Rc::<str>::from(v9.to_lowercase());
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(v11.to_lowercase());
    let mut v13: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new(Vec::new()));
    let mut v14: US0 = US0::US0_0;
    v13.borrow_mut().push((v11.clone(), v14.clone()));
    let mut v15: US0 = US0::US0_1;
    v13.borrow_mut().push((v9.clone(), v15.clone()));
    let mut v16: US0 = US0::US0_2;
    v13.borrow_mut().push((v7.clone(), v16.clone()));
    let mut v17: US0 = US0::US0_3;
    v13.borrow_mut().push((v5.clone(), v17.clone()));
    let mut v18: US0 = US0::US0_4;
    v13.borrow_mut().push((v3.clone(), v18.clone()));
    let mut v19: US0 = US0::US0_0;
    v13.borrow_mut().push((v12.clone(), v19.clone()));
    let mut v20: US0 = US0::US0_1;
    v13.borrow_mut().push((v10.clone(), v20.clone()));
    let mut v21: US0 = US0::US0_2;
    v13.borrow_mut().push((v8.clone(), v21.clone()));
    let mut v22: US0 = US0::US0_3;
    v13.borrow_mut().push((v6.clone(), v22.clone()));
    let mut v23: US0 = US0::US0_4;
    v13.borrow_mut().push((v4.clone(), v23.clone()));
    let mut v24: Rc<Vec<(Rc<str>, US0)>> = Rc::new(v13.borrow().clone());
    let mut v25: Rc<RefCell<Vec<(Rc<str>, US0)>>> = Rc::new(RefCell::new((v24).as_ref().clone()));
    let mut v26: i32 = (v25.clone().borrow().len() as i32);
    let mut v27: US1 = US1::US1_1;
    let mut v28: Rc<RefCell<Mut5>> = Rc::new(RefCell::new(Mut5 { l0: 0i32, l1: v27.clone() }));
    while method2(v26, v28.clone()) {
        let mut v30: i32 = v28.borrow().l0.clone();
        let mut v31: i32 = -(v30);
        let mut v32: i32 = v31 + v26;
        let mut v33: i32 = v32 - 1i32;
        let mut v34: US1 = v28.borrow().l1.clone();
        let (mut v35, mut v36): (Rc<str>, US0) = v25.clone().borrow()[v33 as usize].clone();
        let mut v43: US1 = match &v34 {
            US1::US1_1 => { // None
                let mut v38: bool = v35 == v2 ;
                if v38 {
                    US1::US1_0(v36.clone())
                } else {
                    US1::US1_1
                }
            }
            US1::US1_0(v37) => { // Some
                let mut v37: US0 = v37.clone();
                v34.clone()
            }
            _ => unreachable!(),
        };
        let mut v44: i32 = v30 + 1i32;
        v28.borrow_mut().l0 = v44;
        v28.borrow_mut().l1 = v43.clone();
        ()
    };
    let mut v45: US1 = v28.borrow().l1.clone();
    let mut v46: Rc<RefCell<Mut0>> = Rc::new(RefCell::new(Mut0 { l0: 1i64 }));
    let mut v47: Rc<dyn Fn(Rc<str>) -> ()> = closure1();
    let mut v48: Rc<RefCell<Mut1>> = Rc::new(RefCell::new(Mut1 { l0: v47.clone() }));
    let mut v49: Rc<RefCell<Mut2>> = Rc::new(RefCell::new(Mut2 { l0: true }));
    let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v51: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v50.clone() }));
    let mut v54: US0 = match &v45 {
        US1::US1_1 => { // None
            v0.clone()
        }
        US1::US1_0(v52) => { // Some
            let mut v52: US0 = v52.clone();
            v52.clone()
        }
        _ => unreachable!(),
    };
    let mut v55: Rc<RefCell<Mut4>> = Rc::new(RefCell::new(Mut4 { l0: v54.clone() }));
    let mut v56: Option<i64> = None;
    (v46.clone(), v48.clone(), v49.clone(), v51.clone(), v55.clone(), v56.clone())
}
fn closure0() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_2;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = method0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure2() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_0;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = method0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure3() -> Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> {
    thread_local!{ static CLOSURE: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = Rc::new(move || -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) {
        let mut v0: US0 = US0::US0_0;
        let (mut v1, mut v2, mut v3, mut v4, mut v5, mut v6): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = method0(v0.clone());
        (v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method3(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>) -> Rc<str> {
    let mut v7: Rc<str> = { #[cfg(target_arch = "wasm32")] let (h, m, s) = { let secs = near_sdk::env::block_timestamp() / 1_000_000_000; ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; #[cfg(all(windows, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C)] struct St([u16; 8]); unsafe extern "system" { fn GetLocalTime(t: *mut St); } let mut t = St([0; 8]); unsafe { GetLocalTime(&mut t) }; (t.0[4] as u64, t.0[5] as u64, t.0[6] as u64) }; #[cfg(all(unix, not(target_arch = "wasm32")))] let (h, m, s) = { #[repr(C, align(8))] struct Tm([i32; 16]); unsafe extern "C" { fn localtime_r(t: *const std::os::raw::c_long, tm: *mut Tm) -> *mut Tm; } let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0) as std::os::raw::c_long; let mut tm = Tm([0; 16]); unsafe { localtime_r(&secs, &mut tm) }; (tm.0[2] as u64, tm.0[1] as u64, tm.0[0] as u64) }; #[cfg(not(any(windows, unix, target_arch = "wasm32")))] let (h, m, s) = { let secs = std::time::SystemTime::now().duration_since(std::time::UNIX_EPOCH).map(|d| d.as_secs()).unwrap_or(0); ((secs / 3600) % 24, (secs / 60) % 60, secs % 60) }; let mut buf = String::new(); let push = |buf: &mut String, n: u64| { if n < 10 { buf.push(char::from(48)); } buf.push_str(&n.to_string()); }; push(&mut buf, h); buf.push(char::from(58)); push(&mut buf, m); buf.push(char::from(58)); push(&mut buf, s); Rc::<str>::from(buf) };
    v7.clone()
}
fn method6(mut v0: Rc<RefCell<Mut3>>, mut v1: Rc<str>) -> () {
    let mut v2: Rc<str> = v0.borrow().l0.clone();
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v1));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method5(mut v0: u8) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method4() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[92m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Info"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.clone().as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = method5(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7.clone()
}
fn method9(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v2 >= v1;
        if v3 {
            return v1;
        } else {
            let mut v4: u8 = v0.clone().as_bytes()[v2 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v11: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'\t';
                if v6 {
                    true
                } else {
                    let mut v7: bool = v4 == b'\r';
                    if v7 {
                        true
                    } else {
                        let mut v8: bool = v4 == b'\n';
                        v8
                    }
                }
            };
            if v11 {
                let mut v12: i32 = v2 + 1i32;
                (v0, v1, v2) = (v0.clone(), v1, v12);
                continue;
            } else {
                return v2;
            }
        }
    }
}
fn method10(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: bool = v1 <= 0i32;
        if v2 {
            return -1i32;
        } else {
            let mut v3: i32 = v1 - 1i32;
            let mut v4: u8 = v0.clone().as_bytes()[v3 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v7: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'/';
                v6
            };
            if v7 {
                (v0, v1) = (v0.clone(), v3);
                continue;
            } else {
                return v3;
            }
        }
    }
}
fn method8(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: i32 = 0i32;
    let mut v3: i32 = method9(v0.clone(), v1, v2);
    let mut v4: i32 = v1 - 1i32;
    let mut v5: Rc<str> = string_slice(&v0.clone(), v3 as i64, v4 as i64);
    let mut v6: i32 = (v5.clone().len() as i32);
    let mut v7: i32 = method10(v5.clone(), v6);
    let mut v8: Rc<str> = string_slice(&v5.clone(), 0i32 as i64, v7 as i64);
    v8.clone()
}
fn method11(mut v0: i64) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v2.clone(), v3.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method13(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("{ "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method14(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("args"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method15(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" = "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method16(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" }"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method12(mut v0: Rc<RefCell<Vec<Rc<str>>>>) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    method13(v2.clone());
    method14(v2.clone());
    method15(v2.clone());
    let mut v3: Rc<str> = Rc::<str>::from(format!("{:?}", v0.borrow()));
    method6(v2.clone(), v3.clone());
    method16(v2.clone());
    let mut v4: Rc<str> = v2.borrow().l0.clone();
    v4.clone()
}
fn method7(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<RefCell<Vec<Rc<str>>>>) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = method11(v9);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v10));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.main"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = method12(v8.clone());
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    method8(v21.clone())
}
fn closure4() -> Rc<dyn Fn(Rc<str>) -> ()> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> ()> = Rc::new(move |mut v0: Rc<str>| -> () {
        println!("{}", v0);
        ()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method17() -> clap::Command {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("command"); } LIT.with(|lit| lit.clone()) };
    let mut v4: &'static str = Box::leak(String::from(&*v3).into_boxed_str());
    let mut v6: clap::Command = clap::Command::new(v4);
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("source-dir"); } LIT.with(|lit| lit.clone()) };
    let mut v11: &'static str = Box::leak(String::from(&*v10).into_boxed_str());
    let mut v13: clap::Arg = clap::Arg::new(v11);
    let mut v15: clap::Arg = v13.short(b's' as char);
    let mut v16: &'static str = Box::leak(String::from(&*v10).into_boxed_str());
    let mut v18: clap::Arg = v15.long(v16);
    let mut v20: clap::Arg = v18.required(true);
    let mut v22: clap::Command = clap::Command::arg(v6, v20);
    let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist-dir"); } LIT.with(|lit| lit.clone()) };
    let mut v27: &'static str = Box::leak(String::from(&*v26).into_boxed_str());
    let mut v29: clap::Arg = clap::Arg::new(v27);
    let mut v31: clap::Arg = v29.short(b'd' as char);
    let mut v32: &'static str = Box::leak(String::from(&*v26).into_boxed_str());
    let mut v34: clap::Arg = v31.long(v32);
    let mut v36: clap::Arg = v34.required(true);
    let mut v38: clap::Command = clap::Command::arg(v22, v36);
    let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache-dir"); } LIT.with(|lit| lit.clone()) };
    let mut v43: &'static str = Box::leak(String::from(&*v42).into_boxed_str());
    let mut v45: clap::Arg = clap::Arg::new(v43);
    let mut v47: clap::Arg = v45.short(b'c' as char);
    let mut v48: &'static str = Box::leak(String::from(&*v42).into_boxed_str());
    let mut v50: clap::Arg = v47.long(v48);
    let mut v52: clap::Arg = v50.required(true);
    let mut v54: clap::Command = clap::Command::arg(v38, v52);
    let mut v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul-spec"); } LIT.with(|lit| lit.clone()) };
    let mut v59: &'static str = Box::leak(String::from(&*v58).into_boxed_str());
    let mut v61: clap::Arg = clap::Arg::new(v59);
    let mut v63: clap::Arg = v61.short(b'H' as char);
    let mut v64: &'static str = Box::leak(String::from(&*v58).into_boxed_str());
    let mut v66: clap::Arg = v63.long(v64);
    let mut v68: clap::Command = clap::Command::arg(v54, v66);
    let mut v72: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("filter"); } LIT.with(|lit| lit.clone()) };
    let mut v73: &'static str = Box::leak(String::from(&*v72).into_boxed_str());
    let mut v75: clap::Arg = clap::Arg::new(v73);
    let mut v77: clap::Arg = v75.short(b'f' as char);
    let mut v78: &'static str = Box::leak(String::from(&*v72).into_boxed_str());
    let mut v80: clap::Arg = v77.long(v78);
    let mut v82: clap::Command = clap::Command::arg(v68, v80);
    let mut v86: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("transcribe-only"); } LIT.with(|lit| lit.clone()) };
    let mut v87: &'static str = Box::leak(String::from(&*v86).into_boxed_str());
    let mut v89: clap::Arg = clap::Arg::new(v87);
    let mut v91: clap::Arg = v89.short(b't' as char);
    let mut v92: &'static str = Box::leak(String::from(&*v86).into_boxed_str());
    let mut v94: clap::Arg = v91.long(v92);
    let mut v98: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("false"); } LIT.with(|lit| lit.clone()) };
    let mut v99: &str = (&*v98);
    let mut v101: clap::Arg = v94.default_value(&*Box::leak(String::from(v99).into_boxed_str()));
    let mut v103: clap::ArgAction = clap::ArgAction::SetTrue;
    let mut v105: clap::Arg = v101.action(v103);
    let mut v107: clap::Command = clap::Command::arg(v82, v105);
    v107.clone()
}
fn method18() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("source-dir"); } LIT.with(|lit| lit.clone()) };
    v0.clone()
}
fn method19(mut v0: Option<std::string::String>) -> Option<std::string::String> {
    v0.clone()
}
fn closure5() -> Rc<dyn Fn((std::string::String)) -> US3> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((std::string::String)) -> US3> = Rc::new(move |mut v0: (std::string::String)| -> US3 {
        let mut v1: std::string::String = (v0);
        US3::US3_0(v1.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method20() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist-dir"); } LIT.with(|lit| lit.clone()) };
    v0.clone()
}
fn method21() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache-dir"); } LIT.with(|lit| lit.clone()) };
    v0.clone()
}
fn method22() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul-spec"); } LIT.with(|lit| lit.clone()) };
    v0.clone()
}
fn method23() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("filter"); } LIT.with(|lit| lit.clone()) };
    v0.clone()
}
fn method24() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("transcribe-only"); } LIT.with(|lit| lit.clone()) };
    v0.clone()
}
fn method27(mut v0: std::path::PathBuf) -> std::path::PathBuf {
    v0.clone()
}
fn method26() -> Rc<str> {
    let mut v40: Result<std::path::PathBuf, std::io::Error> = std::env::current_dir();
    let mut v42: std::path::PathBuf = v40.unwrap();
    let mut v43: std::path::PathBuf = method27(v42.clone());
    let mut v45: std::path::Display = v43.display();
    let mut v47: std::string::String = format!("{}", v45);
    let mut v49: Rc<str> = Rc::<str>::from(String::as_str(&v47));
    v49.clone()
}
fn method29(mut v0: Rc<str>, mut v1: Rc<str>) -> Rc<str> {
    let mut v93: &str = &*v0;
    let mut v95: std::string::String = String::from(v93);
    let mut v97: std::path::PathBuf = std::path::PathBuf::from(v95);
    let mut v99: &str = &*v1;
    let mut v101: std::string::String = String::from(v99);
    let mut v103: std::path::PathBuf = v97.join(v101);
    let mut v104: std::path::PathBuf = method27(v103.clone());
    let mut v106: std::path::Display = v104.display();
    let mut v108: std::string::String = format!("{}", v106);
    let mut v110: Rc<str> = Rc::<str>::from(String::as_str(&v108));
    v110.clone()
}
fn method33(mut v0: Rc<str>) -> Option<Rc<str>> {
    let mut v104: &str = &*v0;
    let mut v106: std::string::String = String::from(v104);
    let mut v108: std::path::PathBuf = std::path::PathBuf::from(v106);
    let mut v110: Option<std::path::PathBuf> = v108.parent().map(std::path::PathBuf::from);
    let mut v112: bool = true; let _optionm_map_ = v110.map(|x| { //;
    let mut v114: std::path::PathBuf = x;
    let mut v115: std::path::PathBuf = method27(v114.clone());
    let mut v117: std::path::Display = v115.display();
    let mut v119: std::string::String = format!("{}", v117);
    let mut v121: Rc<str> = Rc::<str>::from(String::as_str(&v119));
    let mut v123: bool = true; v121 });
    let mut v125: Option<Rc<str>> = _optionm_map_;
    v125.clone()
}
fn method34(mut v0: Option<Rc<str>>) -> Option<Rc<str>> {
    v0.clone()
}
fn closure6() -> Rc<dyn Fn((Rc<str>)) -> US4> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((Rc<str>)) -> US4> = Rc::new(move |mut v0: (Rc<str>)| -> US4 {
        let mut v1: Rc<str> = (v0);
        US4::US4_0(v1.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method32(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool, mut v3: Rc<dyn Fn(Rc<str>) -> bool>, mut v4: Rc<str>) -> US6 {
    loop {
        let mut v5: Rc<str> = method29(v4.clone(), v0.clone());
        let mut v6: bool = v3(v5.clone());
        if v6 {
            return US6::US6_0(v4.clone());
        } else {
            let mut v8: Option<Rc<str>> = method33(v4.clone());
            let mut v9: Option<Rc<str>> = method34(v8.clone());
            let mut v10: Rc<dyn Fn((Rc<str>)) -> US4> = closure6();
            let mut v11: Option<US4> = v9.map(|x| v10(x));
            let mut v12: US4 = US4::US4_1;
            let mut v13: US4 = v11.unwrap_or(v12);
            match &v13 {
                US4::US4_1 => { // None
                    let mut v18: Rc<str> = if v2 {
                        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file"); } LIT.with(|lit| lit.clone()) };
                        v16.clone()
                    } else {
                        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dir"); } LIT.with(|lit| lit.clone()) };
                        v17.clone()
                    };
                    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.find_parent / No parent for "); } LIT.with(|lit| lit.clone()) };
                    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v18));
                    let mut v23: Rc<str> = Rc::<str>::from(format!(" '{}' at '{}' (until '{}')", v0, v1, v4));
                    let mut v24: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v23));
                    return US6::US6_1(v24.clone());
                }
                US4::US4_0(v14) => { // Some
                    let mut v14: Rc<str> = v14.clone();
                    (v0, v1, v2, v3, v4) = (v0.clone(), v1.clone(), v2, v3.clone(), v14.clone());
                    continue;
                }
                _ => unreachable!(),
            }
        }
    }
}
fn method31(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool, mut v3: Rc<dyn Fn(Rc<str>) -> bool>) -> US6 {
    let mut v4: Rc<str> = method29(v1.clone(), v0.clone());
    let mut v5: bool = v3(v4.clone());
    if v5 {
        US6::US6_0(v1.clone())
    } else {
        let mut v7: Option<Rc<str>> = method33(v1.clone());
        let mut v8: Option<Rc<str>> = method34(v7.clone());
        let mut v9: Rc<dyn Fn((Rc<str>)) -> US4> = closure6();
        let mut v10: Option<US4> = v8.map(|x| v9(x));
        let mut v11: US4 = US4::US4_1;
        let mut v12: US4 = v10.unwrap_or(v11);
        match &v12 {
            US4::US4_1 => { // None
                let mut v17: Rc<str> = if v2 {
                    let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file"); } LIT.with(|lit| lit.clone()) };
                    v15.clone()
                } else {
                    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dir"); } LIT.with(|lit| lit.clone()) };
                    v16.clone()
                };
                let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.find_parent / No parent for "); } LIT.with(|lit| lit.clone()) };
                let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v17));
                let mut v20: Rc<str> = Rc::<str>::from(format!(" '{}' at '{}' (until '{}')", v0, v1, v1));
                let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
                US6::US6_1(v21.clone())
            }
            US4::US4_0(v13) => { // Some
                let mut v13: Rc<str> = v13.clone();
                method32(v0.clone(), v1.clone(), v2, v3.clone(), v13.clone())
            }
            _ => unreachable!(),
        }
    }
}
fn method35(mut v0: Rc<str>) -> bool {
    let mut v47: &str = &*v0;
    let mut v49: std::string::String = String::from(v47);
    let mut v51: std::path::PathBuf = std::path::PathBuf::from(v49);
    let mut v53: bool = v51.exists();
    if v53 {
        let mut v55: bool = v51.is_file();
        v55
    } else {
        false
    }
}
fn closure7() -> Rc<dyn Fn(Rc<str>) -> bool> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> bool> = Rc::new(move |mut v0: Rc<str>| -> bool {
        method35(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method36(mut v0: Rc<str>) -> bool {
    let mut v47: &str = &*v0;
    let mut v49: std::string::String = String::from(v47);
    let mut v51: std::path::PathBuf = std::path::PathBuf::from(v49);
    let mut v53: bool = v51.exists();
    if v53 {
        let mut v55: bool = v51.is_dir();
        v55
    } else {
        false
    }
}
fn closure8() -> Rc<dyn Fn(Rc<str>) -> bool> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> bool> = Rc::new(move |mut v0: Rc<str>| -> bool {
        method36(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method30(mut v0: US5, mut v1: Rc<str>, mut v2: Rc<str>) -> US6 {
    let mut v3: bool = match &v0 {
        US5::US5_0 => { // File
            true
        }
        _ => {
            false
        }
    };
    let mut v6: Rc<dyn Fn(Rc<str>) -> bool> = if v3 {
        closure7()
    } else {
        closure8()
    };
    method31(v1.clone(), v2.clone(), v3, v6.clone())
}
fn method37() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[93m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Warning"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.clone().as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = method5(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7.clone()
}
fn method40(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dir"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method41(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("; "); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method42(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("error"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method39(mut v0: Rc<str>, mut v1: Rc<str>) -> Rc<str> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v2.clone() }));
    method13(v3.clone());
    method40(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v0.clone());
    method41(v3.clone());
    method42(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v1.clone());
    method16(v3.clone());
    let mut v4: Rc<str> = v3.borrow().l0.clone();
    v4.clone()
}
fn method38(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = method11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.get_workspace_root"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = method39(v8.clone(), v9.clone());
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    method8(v22.clone())
}
fn method47(mut v0: Rc<str>) -> Rc<str> {
    let mut v82: &str = &*v0;
    let mut v84: std::string::String = String::from(v82);
    let mut v86: std::path::PathBuf = std::path::PathBuf::from(v84);
    let mut v88: Option<&std::ffi::OsStr> = v86.file_name();
    let mut v90: bool = true; let _optionm_map_ = v88.map(|x| { //;
    let mut v92: &std::ffi::OsStr = x;
    let mut v94: std::ffi::OsString = v92.to_os_string();
    let mut v96: Option<&str> = v94.to_str();
    let mut v98: &str = v96.unwrap();
    let mut v100: std::string::String = String::from(v98);
    let mut v102: Rc<str> = Rc::<str>::from(String::as_str(&v100));
    let mut v104: bool = true; v102 });
    let mut v106: Option<Rc<str>> = _optionm_map_;
    let mut v107: Option<Rc<str>> = method34(v106.clone());
    let mut v108: Rc<dyn Fn((Rc<str>)) -> US4> = closure6();
    let mut v109: Option<US4> = v107.map(|x| v108(x));
    let mut v110: US4 = US4::US4_1;
    let mut v111: US4 = v109.unwrap_or(v110);
    match &v111 {
        US4::US4_1 => { // None
            let mut v113: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v113.clone()
        }
        US4::US4_0(v112) => { // Some
            let mut v112: Rc<str> = v112.clone();
            v112.clone()
        }
        _ => unreachable!(),
    }
}
fn method48(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    method6(v2.clone(), v0.clone());
    let mut v3: Rc<str> = v2.borrow().l0.clone();
    v3.clone()
}
fn method50(mut v0: std::io::Error) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v20: std::string::String = format!("{:#?}", v0);
    let mut v22: Rc<str> = Rc::<str>::from(v20);
    method6(v2.clone(), v22.clone());
    let mut v23: Rc<str> = v2.borrow().l0.clone();
    v23.clone()
}
fn closure9() -> Rc<dyn Fn(std::io::Error) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::io::Error) -> Rc<str>> = Rc::new(move |mut v0: std::io::Error| -> Rc<str> {
        method50(v0)
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method49() -> Rc<dyn Fn(std::io::Error) -> Rc<str>> {
    closure9()
}
fn closure10() -> Rc<dyn Fn(std::path::PathBuf) -> US7> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::path::PathBuf) -> US7> = Rc::new(move |mut v0: std::path::PathBuf| -> US7 {
        US7::US7_0(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method51() -> Rc<dyn Fn(std::path::PathBuf) -> US7> {
    closure10()
}
fn closure11() -> Rc<dyn Fn(Rc<str>) -> US7> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> US7> = Rc::new(move |mut v0: Rc<str>| -> US7 {
        US7::US7_1(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method52() -> Rc<dyn Fn(Rc<str>) -> US7> {
    closure11()
}
fn method46(mut v0: Rc<str>, mut v1: Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>>, mut v2: u8, mut v3: Rc<str>) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v4: Rc<str> = method47(v0.clone());
    let mut v5: Option<Rc<str>> = method33(v0.clone());
    let mut v6: Option<Rc<str>> = method34(v5.clone());
    let mut v7: Rc<dyn Fn((Rc<str>)) -> US4> = closure6();
    let mut v8: Option<US4> = v6.map(|x| v7(x));
    let mut v9: US4 = US4::US4_1;
    let mut v10: US4 = v8.unwrap_or(v9);
    let mut v11: Rc<str> = method48(v3.clone());
    let mut v12: bool = v2 >= 11u8;
    if v12 {
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / "); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = Rc::<str>::from(format!("path: {} / n: {} / path': {} / name: {}", v0, v2, v0, v4));
        let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
        let mut v17: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v15);
        let mut v19: Result<std::path::PathBuf, std::io::Error> = Err(v17);
        v19
    } else {
        match &v10 {
            US4::US4_0(v20) => { // Some
                let mut v20: Rc<str> = v20.clone();
                let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v22: bool = v0 != v21 ;
                if v22 {
                    let mut v23: u8 = v2 + 1u8;
                    let mut v24: Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>> = v1(v23);
                    let mut v25: Result<std::path::PathBuf, std::io::Error> = v24(v20.clone());
                    let mut v26: Rc<dyn Fn(std::io::Error) -> Rc<str>> = method49();
                    let mut v28: Result<std::path::PathBuf, Rc<str>> = v25.map_err(|x| v26(x));
                    let mut v29: Rc<dyn Fn(std::path::PathBuf) -> US7> = method51();
                    let mut v30: Rc<dyn Fn(Rc<str>) -> US7> = method52();
                    let mut v31: US7 = match v28 { Ok(x) => v29(x), Err(e) => v30(e) };
                    match &v31 {
                        US7::US7_1(v46) => { // Error
                            let mut v46: Rc<str> = v46.clone();
                            let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / "); } LIT.with(|lit| lit.clone()) };
                            let mut v48: Rc<str> = Rc::<str>::from(format!("error': {} / error: {} / name: {}", v46, v11, v4));
                            let mut v49: Rc<str> = Rc::<str>::from(format!("{}{}", v47, v48));
                            let mut v51: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v49);
                            let mut v53: Result<std::path::PathBuf, std::io::Error> = Err(v51);
                            v53
                        }
                        US7::US7_0(v32) => { // Ok
                            let mut v32: std::path::PathBuf = v32.clone();
                            let mut v33: std::path::PathBuf = method27(v32.clone());
                            let mut v35: std::path::Display = v33.display();
                            let mut v36: Rc<str> = Rc::<str>::from(format!("{}", v35));
                            let mut v37: Rc<str> = method29(v36.clone(), v4.clone());
                            let mut v39: &str = &*v37;
                            let mut v41: std::string::String = String::from(v39);
                            let mut v43: std::path::PathBuf = std::path::PathBuf::from(v41);
                            let mut v45: Result<std::path::PathBuf, std::io::Error> = Ok(v43);
                            v45
                        }
                        _ => unreachable!(),
                    }
                } else {
                    let mut v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / run / The file or directory is not a reparse point. / "); } LIT.with(|lit| lit.clone()) };
                    let mut v57: Rc<str> = Rc::<str>::from(format!("path: {} / error: {} / path': {} / name: {}", v0, v11, v0, v4));
                    let mut v58: Rc<str> = Rc::<str>::from(format!("{}{}", v56, v57));
                    let mut v60: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v58);
                    let mut v62: Result<std::path::PathBuf, std::io::Error> = Err(v60);
                    v62
                }
            }
            _ => {
                let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / run / The file or directory is not a reparse point. / "); } LIT.with(|lit| lit.clone()) };
                let mut v65: Rc<str> = Rc::<str>::from(format!("path: {} / error: {} / path': {} / name: {}", v0, v11, v0, v4));
                let mut v66: Rc<str> = Rc::<str>::from(format!("{}{}", v64, v65));
                let mut v68: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v66);
                let mut v70: Result<std::path::PathBuf, std::io::Error> = Err(v68);
                v70
            }
        }
    }
}
fn method54(mut v0: Rc<str>, mut v1: Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>>, mut v2: u8, mut v3: Rc<str>, mut v4: Rc<str>) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v5: Rc<str> = method47(v4.clone());
    let mut v6: Option<Rc<str>> = method33(v4.clone());
    let mut v7: Option<Rc<str>> = method34(v6.clone());
    let mut v8: Rc<dyn Fn((Rc<str>)) -> US4> = closure6();
    let mut v9: Option<US4> = v7.map(|x| v8(x));
    let mut v10: US4 = US4::US4_1;
    let mut v11: US4 = v9.unwrap_or(v10);
    let mut v12: Rc<str> = method48(v3.clone());
    let mut v13: bool = v2 >= 11u8;
    if v13 {
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / "); } LIT.with(|lit| lit.clone()) };
        let mut v15: Rc<str> = Rc::<str>::from(format!("path: {} / n: {} / path': {} / name: {}", v0, v2, v4, v5));
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v15));
        let mut v28: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v16);
        let mut v40: Result<std::path::PathBuf, std::io::Error> = Err(v28);
        v40
    } else {
        match &v11 {
            US4::US4_0(v41) => { // Some
                let mut v41: Rc<str> = v41.clone();
                let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v43: bool = v4 != v42 ;
                if v43 {
                    let mut v44: u8 = v2 + 1u8;
                    let mut v45: Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>> = v1(v44);
                    let mut v46: Result<std::path::PathBuf, std::io::Error> = v45(v41.clone());
                    let mut v47: Rc<dyn Fn(std::io::Error) -> Rc<str>> = method49();
                    let mut v49: Result<std::path::PathBuf, Rc<str>> = v46.map_err(|x| v47(x));
                    let mut v50: Rc<dyn Fn(std::path::PathBuf) -> US7> = method51();
                    let mut v51: Rc<dyn Fn(Rc<str>) -> US7> = method52();
                    let mut v52: US7 = match v49 { Ok(x) => v50(x), Err(e) => v51(e) };
                    match &v52 {
                        US7::US7_1(v74) => { // Error
                            let mut v74: Rc<str> = v74.clone();
                            let mut v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / "); } LIT.with(|lit| lit.clone()) };
                            let mut v76: Rc<str> = Rc::<str>::from(format!("error': {} / error: {} / name: {}", v74, v12, v5));
                            let mut v77: Rc<str> = Rc::<str>::from(format!("{}{}", v75, v76));
                            let mut v79: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v77);
                            let mut v81: Result<std::path::PathBuf, std::io::Error> = Err(v79);
                            v81
                        }
                        US7::US7_0(v53) => { // Ok
                            let mut v53: std::path::PathBuf = v53.clone();
                            let mut v54: std::path::PathBuf = method27(v53.clone());
                            let mut v56: std::path::Display = v54.display();
                            let mut v64: Rc<str> = Rc::<str>::from(format!("{}", v56));
                            let mut v65: Rc<str> = method29(v64.clone(), v5.clone());
                            let mut v67: &str = &*v65;
                            let mut v69: std::string::String = String::from(v67);
                            let mut v71: std::path::PathBuf = std::path::PathBuf::from(v69);
                            let mut v73: Result<std::path::PathBuf, std::io::Error> = Ok(v71);
                            v73
                        }
                        _ => unreachable!(),
                    }
                } else {
                    let mut v84: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / run / The file or directory is not a reparse point. / "); } LIT.with(|lit| lit.clone()) };
                    let mut v85: Rc<str> = Rc::<str>::from(format!("path: {} / error: {} / path': {} / name: {}", v0, v12, v4, v5));
                    let mut v86: Rc<str> = Rc::<str>::from(format!("{}{}", v84, v85));
                    let mut v88: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v86);
                    let mut v90: Result<std::path::PathBuf, std::io::Error> = Err(v88);
                    v90
                }
            }
            _ => {
                let mut v92: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.read_link / run / The file or directory is not a reparse point. / "); } LIT.with(|lit| lit.clone()) };
                let mut v93: Rc<str> = Rc::<str>::from(format!("path: {} / error: {} / path': {} / name: {}", v0, v12, v4, v5));
                let mut v94: Rc<str> = Rc::<str>::from(format!("{}{}", v92, v93));
                let mut v96: std::io::Error = std::io::Error::new(std::io::ErrorKind::Other, &*v94);
                let mut v98: Result<std::path::PathBuf, std::io::Error> = Err(v96);
                v98
            }
        }
    }
}
fn method53(mut v0: Rc<str>, mut v1: u8, mut v2: Rc<str>) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v104: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v2);
    let mut v105: Rc<dyn Fn(std::io::Error) -> Rc<str>> = method49();
    let mut v107: Result<std::path::PathBuf, Rc<str>> = v104.map_err(|x| v105(x));
    let mut v108: Rc<dyn Fn(std::path::PathBuf) -> US7> = method51();
    let mut v109: Rc<dyn Fn(Rc<str>) -> US7> = method52();
    let mut v110: US7 = match v107 { Ok(x) => v108(x), Err(e) => v109(e) };
    match &v110 {
        US7::US7_1(v114) => { // Error
            let mut v114: Rc<str> = v114.clone();
            let mut v115: Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>> = closure12(v0.clone());
            method54(v0.clone(), v115.clone(), v1, v114.clone(), v2.clone())
        }
        US7::US7_0(v111) => { // Ok
            let mut v111: std::path::PathBuf = v111.clone();
            let mut v113: Result<std::path::PathBuf, std::io::Error> = Ok(v111);
            v113
        }
        _ => unreachable!(),
    }
}
fn closure13(mut v0: Rc<str>, mut v1: u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>> {
    Rc::new(move |mut v2: Rc<str>| -> Result<std::path::PathBuf, std::io::Error> {
        method53(v0.clone(), v1, v2.clone())
    })
}
fn closure12(mut v0: Rc<str>) -> Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>> {
    Rc::new(move |mut v1: u8| -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>> {
        closure13(v0.clone(), v1)
    })
}
fn method45(mut v0: Rc<str>, mut v1: u8) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v103: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0);
    let mut v104: Rc<dyn Fn(std::io::Error) -> Rc<str>> = method49();
    let mut v106: Result<std::path::PathBuf, Rc<str>> = v103.map_err(|x| v104(x));
    let mut v107: Rc<dyn Fn(std::path::PathBuf) -> US7> = method51();
    let mut v108: Rc<dyn Fn(Rc<str>) -> US7> = method52();
    let mut v109: US7 = match v106 { Ok(x) => v107(x), Err(e) => v108(e) };
    match &v109 {
        US7::US7_1(v113) => { // Error
            let mut v113: Rc<str> = v113.clone();
            let mut v114: Rc<dyn Fn(u8) -> Rc<dyn Fn(Rc<str>) -> Result<std::path::PathBuf, std::io::Error>>> = closure12(v0.clone());
            method46(v0.clone(), v114.clone(), v1, v113.clone())
        }
        US7::US7_0(v110) => { // Ok
            let mut v110: std::path::PathBuf = v110.clone();
            let mut v112: Result<std::path::PathBuf, std::io::Error> = Ok(v110);
            v112
        }
        _ => unreachable!(),
    }
}
fn method44(mut v0: Rc<str>) -> Result<std::path::PathBuf, std::io::Error> {
    let mut v25: bool = method36(v0.clone());
    if v25 {
        let mut v27: Result<std::path::PathBuf, std::io::Error> = std::fs::read_link(&*v0);
        v27
    } else {
        let mut v28: u8 = 0u8;
        method45(v0.clone(), v28)
    }
}
fn method55(mut v0: Option<std::path::PathBuf>) -> Option<std::path::PathBuf> {
    v0.clone()
}
fn closure14() -> Rc<dyn Fn((std::path::PathBuf)) -> US8> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((std::path::PathBuf)) -> US8> = Rc::new(move |mut v0: (std::path::PathBuf)| -> US8 {
        let mut v1: std::path::PathBuf = (v0);
        US8::US8_0(v1.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method57(mut v0: Rc<str>) -> Rc<str> {
    v0.clone()
}
fn method56(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>) -> Rc<str> {
    let mut v21: Result<regex::Regex, regex::Error> = regex::Regex::new(&v0);
    let mut v23: regex::Regex = v21.unwrap();
    let mut v24: Rc<str> = method57(v2.clone());
    let mut v26: std::borrow::Cow<str> = v23.replace_all(&*v24, &*v1);
    let mut v28: std::string::String = String::from(v26);
    let mut v30: Rc<str> = Rc::<str>::from(String::as_str(&v28));
    v30.clone()
}
fn method43(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: bool = v0.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    if v1 {
        let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v2.clone()
    } else {
        let mut v3: Result<std::path::PathBuf, std::io::Error> = method44(v0.clone());
        let mut v15: Option<std::path::PathBuf> = v3.ok();
        let mut v16: Option<std::path::PathBuf> = method55(v15.clone());
        let mut v17: Rc<dyn Fn((std::path::PathBuf)) -> US8> = closure14();
        let mut v18: Option<US8> = v16.map(|x| v17(x));
        let mut v19: US8 = US8::US8_1;
        let mut v20: US8 = v18.unwrap_or(v19);
        let mut v27: Rc<str> = match &v20 {
            US8::US8_1 => { // None
                v0.clone()
            }
            US8::US8_0(v21) => { // Some
                let mut v21: std::path::PathBuf = v21.clone();
                let mut v22: std::path::PathBuf = method27(v21.clone());
                let mut v24: std::path::Display = v22.display();
                let mut v25: Rc<str> = Rc::<str>::from(format!("{}", v24));
                v25.clone()
            }
            _ => unreachable!(),
        };
        let mut v28: bool = v27.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v29: Rc<str> = if v28 {
            v0.clone()
        } else {
            v27.clone()
        };
        let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^\\\\\\\\\\?\\\\"); } LIT.with(|lit| lit.clone()) };
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = method56(v30.clone(), v31.clone(), v29.clone());
        let mut v33: i32 = (v32.clone().len() as i32);
        let mut v34: bool = v33 < 2i32;
        if v34 {
            v0.clone()
        } else {
            let mut v36: Rc<str> = string_slice(&v32.clone(), 0i32 as i64, 0i32 as i64);
            let mut v39: Rc<str> = Rc::<str>::from(v36.to_lowercase());
            let mut v40: i32 = v33 - 1i32;
            let mut v42: Rc<str> = string_slice(&v32.clone(), 1i32 as i64, v40 as i64);
            let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v42));
            let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
            let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
            let mut v49: Rc<str> = Rc::<str>::from(v43.replace(&*v47, &*v48));
            v49.clone()
        }
    }
}
fn method28(mut v0: Rc<str>) -> US4 {
    let mut v1: US5 = US5::US5_1;
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("spiral"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("workspace"); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<str> = method29(v2.clone(), v3.clone());
    let mut v5: US6 = method30(v1.clone(), v4.clone(), v0.clone());
    match &v5 {
        US6::US6_1(v9) => { // Error
            let mut v9: Rc<str> = v9.clone();
            let mut v14: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
            { let _ = spiral_trace_hold(&v14); };
            let mut v16: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
            let (mut v17, mut v18, mut v19, mut v20, mut v21, mut v22): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v16) };
            let mut v23: US0 = v21.borrow().l0.clone();
            let mut v28: i32 = match &v23 {
                US0::US0_4 => { // Critical
                    50i32
                }
                US0::US0_1 => { // Debug
                    20i32
                }
                US0::US0_2 => { // Info
                    30i32
                }
                US0::US0_0 => { // Verbose
                    10i32
                }
                US0::US0_3 => { // Warning
                    40i32
                }
                _ => unreachable!(),
            };
            let mut v29: bool = v19.borrow().l0.clone();
            let mut v30: bool = v29 == false;
            let mut v32: bool = if v30 {
                false
            } else {
                let mut v31: bool = 40i32 >= v28;
                v31
            };
            let mut v33: bool = v32 == false;
            let mut v78: US2 = if v33 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v14); };
                let (mut v37, mut v38, mut v39, mut v40, mut v41, mut v42): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v16) };
                let mut v43: Rc<str> = method3(v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone());
                let mut v44: Rc<str> = method37();
                let mut v45: Rc<str> = method38(v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v43.clone(), v44.clone(), v0.clone(), v9.clone());
                { let _ = spiral_trace_hold(&v14); };
                let (mut v48, mut v49, mut v50, mut v51, mut v52, mut v53): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v16) };
                let mut v54: i64 = v48.borrow().l0.clone();
                let mut v55: i64 = v54 + 1i64;
                v48.borrow_mut().l0 = v55;
                let mut v56: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                let mut v57: bool = cfg!(target_arch = "wasm32");
                if v57 {
                    let mut v58: Rc<str> = v51.borrow().l0.clone();
                    let mut v59: bool = v58.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v67: Rc<str> = if v59 {
                        v45.clone()
                    } else {
                        let mut v60: bool = v45.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v60 {
                            let mut v61: Rc<str> = v51.borrow().l0.clone();
                            v61.clone()
                        } else {
                            let mut v62: Rc<str> = v51.borrow().l0.clone();
                            let mut v63: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v64: Rc<str> = Rc::<str>::from(format!("{}{}", v62, v63));
                            let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", v64, v45));
                            v65.clone()
                        }
                    };
                    let mut v69: i32 = ((v67.chars().count() + 14999) / 15000) as i32;
                    let mut v70: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v71: bool = v45 != v70 ;
                    let mut v73: bool = if v71 {
                        let mut v72: bool = v69 <= 1i32;
                        v72
                    } else {
                        false
                    };
                    if v73 {
                        v51.borrow_mut().l0 = v67.clone();
                        ()
                    } else {
                        v51.borrow_mut().l0 = v70.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v67); };
                        ()
                    }
                } else {
                    println!("{}", v45);
                    ()
                };
                let mut v76: Rc<dyn Fn(Rc<str>) -> ()> = v49.borrow().l0.clone();
                v76(v45.clone());
                US2::US2_0(v48.clone(), v49.clone(), v50.clone(), v51.clone(), v52.clone(), v53.clone())
            };
            US4::US4_1
        }
        US6::US6_0(v6) => { // Ok
            let mut v6: Rc<str> = v6.clone();
            let mut v7: Rc<str> = method43(v6.clone());
            US4::US4_0(v7.clone())
        }
        _ => unreachable!(),
    }
}
fn method59(mut v0: i32, mut v1: Rc<RefCell<Mut6>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn method60(mut v0: i32, mut v1: Rc<RefCell<Mut7>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn method61() -> u8 {
    let mut v9: u8 = (std::path::MAIN_SEPARATOR as u8);
    v9
}
fn method58(mut v0: Rc<str>) -> Rc<str> {
    let mut v146: &str = &*v0;
    let mut v148: std::string::String = String::from(v146);
    let mut v150: std::path::PathBuf = std::path::PathBuf::from(v148);
    let mut v152: bool = v150.exists();
    let mut v153: bool = v152 == false;
    if v153 {
        let mut v154: Rc<str> = method26();
        let mut v155: Rc<str> = method29(v154.clone(), v0.clone());
        let mut v156: Rc<str> = method43(v155.clone());
        let mut v157: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
        let mut v158: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v156.split(&*v157).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
        let mut v159: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![]));
        let mut v160: i32 = (v158.clone().borrow().len() as i32);
        let mut v161: Rc<RefCell<Mut6>> = Rc::new(RefCell::new(Mut6 { l0: 0i32, l1: 0i32, l2: v159.clone() }));
        while method59(v160, v161.clone()) {
            let mut v163: i32 = v161.borrow().l0.clone();
            let mut v164: i32 = -(v163);
            let mut v165: i32 = v164 + v160;
            let mut v166: i32 = v165 - 1i32;
            let (mut v167, mut v168): (i32, Rc<RefCell<Vec<Rc<str>>>>) = (v161.borrow().l1.clone(), v161.borrow().l2.clone());
            let mut v169: Rc<str> = v158.clone().borrow()[v166 as usize].clone();
            let mut v170: bool = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".."); } LIT.with(|lit| lit.clone()) } == v169.clone();
            let (mut v213, mut v214): (i32, Rc<RefCell<Vec<Rc<str>>>>) = if v170 {
                let mut v171: i32 = v167 + 1i32;
                (v171, v168.clone())
            } else {
                let mut v172: bool = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) } == v169.clone();
                if v172 {
                    (v167, v168.clone())
                } else {
                    let mut v173: bool = 0i32 == v167;
                    if v173 {
                        let mut v174: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(":"); } LIT.with(|lit| lit.clone()) };
                        let mut v175: bool = v169.ends_with(&*v174);
                        if v175 {
                            let mut v176: Rc<str> = string_slice(&v154.clone(), 0i32 as i64, 0i32 as i64);
                            let mut v177: Rc<str> = Rc::<str>::from(format!("{}{}", v176, v174));
                            let mut v178: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![v177.clone()]));
                            let mut v179: i32 = (v178.clone().borrow().len() as i32);
                            let mut v180: i32 = (v168.clone().borrow().len() as i32);
                            let mut v181: i32 = v179 + v180;
                            let mut v182: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v181 as usize]));
                            let mut v183: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: 0i32 }));
                            while method60(v181, v183.clone()) {
                                let mut v185: i32 = v183.borrow().l0.clone();
                                let mut v186: bool = v185 < v179;
                                let mut v190: Rc<str> = if v186 {
                                    let mut v187: Rc<str> = v178.clone().borrow()[v185 as usize].clone();
                                    v187.clone()
                                } else {
                                    let mut v188: i32 = v185 - v179;
                                    let mut v189: Rc<str> = v168.clone().borrow()[v188 as usize].clone();
                                    v189.clone()
                                };
                                v182.clone().borrow_mut()[v185 as usize] = v190.clone();
                                let mut v191: i32 = v185 + 1i32;
                                v183.borrow_mut().l0 = v191;
                                ()
                            };
                            (0i32, v182.clone())
                        } else {
                            let mut v192: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![v169.clone()]));
                            let mut v193: i32 = (v192.clone().borrow().len() as i32);
                            let mut v194: i32 = (v168.clone().borrow().len() as i32);
                            let mut v195: i32 = v193 + v194;
                            let mut v196: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v195 as usize]));
                            let mut v197: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: 0i32 }));
                            while method60(v195, v197.clone()) {
                                let mut v199: i32 = v197.borrow().l0.clone();
                                let mut v200: bool = v199 < v193;
                                let mut v204: Rc<str> = if v200 {
                                    let mut v201: Rc<str> = v192.clone().borrow()[v199 as usize].clone();
                                    v201.clone()
                                } else {
                                    let mut v202: i32 = v199 - v193;
                                    let mut v203: Rc<str> = v168.clone().borrow()[v202 as usize].clone();
                                    v203.clone()
                                };
                                v196.clone().borrow_mut()[v199 as usize] = v204.clone();
                                let mut v205: i32 = v199 + 1i32;
                                v197.borrow_mut().l0 = v205;
                                ()
                            };
                            (0i32, v196.clone())
                        }
                    } else {
                        let mut v208: i32 = v167 - 1i32;
                        (v208, v168.clone())
                    }
                }
            };
            let mut v215: i32 = v163 + 1i32;
            v161.borrow_mut().l0 = v215;
            v161.borrow_mut().l1 = v213;
            v161.borrow_mut().l2 = v214.clone();
            ()
        };
        let (mut v216, mut v217): (i32, Rc<RefCell<Vec<Rc<str>>>>) = (v161.borrow().l1.clone(), v161.borrow().l2.clone());
        let mut v218: Rc<Vec<Rc<str>>> = Rc::new(v217.borrow().clone());
        let mut v219: u8 = method61();
        let mut v220: Rc<str> = Rc::<str>::from((v219 as char).encode_utf8(&mut [0u8; 4]) as &str);
        let mut v221: Rc<str> = Rc::<str>::from(v218.iter().map(|x| x.to_string()).collect::<Vec<_>>().join(&*v220));
        v221.clone()
    } else {
        let mut v223: Result<std::path::PathBuf, std::io::Error> = std::fs::canonicalize(&*v0);
        let mut v225: std::path::PathBuf = v223.unwrap();
        let mut v226: std::path::PathBuf = method27(v225.clone());
        let mut v228: std::path::Display = v226.display();
        let mut v230: std::string::String = format!("{}", v228);
        let mut v232: Rc<str> = Rc::<str>::from(String::as_str(&v230));
        v232.clone()
    }
}
fn method62() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[94m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Debug"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.clone().as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = method5(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7.clone()
}
fn method65(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("source_dir"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method66(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist_dir"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method67(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache_dir"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method68(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul_spec"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method69(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("filter"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method70(mut v0: US4) -> Rc<str> {
    match &v0 {
        US4::US4_1 => { // None
            let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("None"); } LIT.with(|lit| lit.clone()) };
            v8.clone()
        }
        US4::US4_0(v1) => { // Some
            let mut v1: Rc<str> = v1.clone();
            let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(")"); } LIT.with(|lit| lit.clone()) };
            let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
            let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("("); } LIT.with(|lit| lit.clone()) };
            let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v4, v3));
            let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Some"); } LIT.with(|lit| lit.clone()) };
            let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v5));
            v7.clone()
        }
        _ => unreachable!(),
    }
}
fn method71(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("transcribe_only"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method64(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: US4, mut v5: bool) -> Rc<str> {
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v6.clone() }));
    method13(v7.clone());
    method65(v7.clone());
    method15(v7.clone());
    method6(v7.clone(), v0.clone());
    method41(v7.clone());
    method66(v7.clone());
    method15(v7.clone());
    method6(v7.clone(), v1.clone());
    method41(v7.clone());
    method67(v7.clone());
    method15(v7.clone());
    method6(v7.clone(), v2.clone());
    method41(v7.clone());
    method68(v7.clone());
    method15(v7.clone());
    method6(v7.clone(), v3.clone());
    method41(v7.clone());
    method69(v7.clone());
    method15(v7.clone());
    let mut v8: Rc<str> = method70(v4.clone());
    method6(v7.clone(), v8.clone());
    method41(v7.clone());
    method71(v7.clone());
    method15(v7.clone());
    let mut v11: Rc<str> = if v5 {
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("true"); } LIT.with(|lit| lit.clone()) };
        v9.clone()
    } else {
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("false"); } LIT.with(|lit| lit.clone()) };
        v10.clone()
    };
    method6(v7.clone(), v11.clone());
    method16(v7.clone());
    let mut v12: Rc<str> = v7.borrow().l0.clone();
    v12.clone()
}
fn method63(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>, mut v11: Rc<str>, mut v12: US4, mut v13: bool) -> Rc<str> {
    let mut v14: i64 = v0.borrow().l0.clone();
    let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v15));
    let mut v17: Rc<str> = method11(v14);
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v7));
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v15));
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run"); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v24: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v23));
    let mut v25: Rc<str> = method64(v8.clone(), v9.clone(), v10.clone(), v11.clone(), v12.clone(), v13);
    let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v25));
    method8(v26.clone())
}
fn method74(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("files_len"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method73(mut v0: usize) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    method13(v2.clone());
    method74(v2.clone());
    method15(v2.clone());
    let mut v4: std::string::String = format!("{:#?}", v0);
    let mut v6: Rc<str> = Rc::<str>::from(v4);
    method6(v2.clone(), v6.clone());
    method16(v2.clone());
    let mut v7: Rc<str> = v2.borrow().l0.clone();
    v7.clone()
}
fn method72(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: usize) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = method11(v9);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v10));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = method73(v8.clone());
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    method8(v21.clone())
}
fn method76() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    v0.clone()
}
fn method77(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = method58(v0.clone());
    method43(v1.clone())
}
fn method79(mut v0: Rc<str>, mut v1: Option<std::sync::Arc<std::sync::atomic::AtomicBool>>, mut v2: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>>, mut v3: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>>, mut v4: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>>, mut v5: bool, mut v6: Option<Rc<str>>, mut v7: bool) -> Rc<str> {
    v0.clone()
}
fn method82(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("c"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method83(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s'"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method84(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line_start"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method85(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("position"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method86(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("line"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method87(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("col"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method88(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("text_length"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method81(mut v0: u8, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32) -> Rc<str> {
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v6: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v5.clone() }));
    method13(v6.clone());
    method82(v6.clone());
    method15(v6.clone());
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method6(v6.clone(), v7.clone());
    method41(v6.clone());
    method83(v6.clone());
    method15(v6.clone());
    method13(v6.clone());
    method84(v6.clone());
    method15(v6.clone());
    let mut v8: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v6.clone(), v8.clone());
    method41(v6.clone());
    method85(v6.clone());
    method15(v6.clone());
    method13(v6.clone());
    method86(v6.clone());
    method15(v6.clone());
    let mut v9: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v6.clone(), v9.clone());
    method41(v6.clone());
    method87(v6.clone());
    method15(v6.clone());
    let mut v10: Rc<str> = Rc::<str>::from(format!("{}", v3));
    method6(v6.clone(), v10.clone());
    method16(v6.clone());
    method41(v6.clone());
    method88(v6.clone());
    method15(v6.clone());
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}", v4));
    method6(v6.clone(), v11.clone());
    method16(v6.clone());
    method16(v6.clone());
    let mut v12: Rc<str> = v6.borrow().l0.clone();
    v12.clone()
}
fn closure15() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = b'"';
        let mut v7: Rc<str> = method81(v6, v2, v3, v4, v5);
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v10, v7));
        v11.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method89(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v2 >= v1;
        if v3 {
            return v2;
        } else {
            let mut v4: u8 = v0.clone().as_bytes()[v2 as usize];
            let mut v5: bool = b'\n' == v4;
            let mut v6: bool = v5 != true;
            if v6 {
                let mut v7: i32 = v2 + 1i32;
                (v0, v1, v2) = (v0.clone(), v1, v7);
                continue;
            } else {
                return v2;
            }
        }
    }
}
fn closure17(mut v0: i32, mut v1: i32) -> Rc<dyn Fn(Rc<str>) -> Rc<str>> {
    Rc::new(move |mut v2: Rc<str>| -> Rc<str> {
        let mut v3: bool = v1 >= v0;
        if v3 {
            v2.clone()
        } else {
            let mut v4: i32 = v1 + 1i32;
            let mut v5: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method90(v0, v4);
            let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
            let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v6));
            v5(v7.clone())
        }
    })
}
fn method90(mut v0: i32, mut v1: i32) -> Rc<dyn Fn(Rc<str>) -> Rc<str>> {
    closure17(v0, v1)
}
fn method92(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("expected"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method91(mut v0: u8, mut v1: i32, mut v2: i32) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method92(v4.clone());
    method15(v4.clone());
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method6(v4.clone(), v5.clone());
    method41(v4.clone());
    method86(v4.clone());
    method15(v4.clone());
    let mut v6: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v4.clone(), v6.clone());
    method41(v4.clone());
    method87(v4.clone());
    method15(v4.clone());
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v4.clone(), v7.clone());
    method16(v4.clone());
    let mut v8: Rc<str> = v4.borrow().l0.clone();
    v8.clone()
}
fn closure16() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method89(v0.clone(), v6, v1);
        let mut v8: i32 = v1 + 80i32;
        let mut v9: bool = v7 < v8;
        let mut v10: i32 = if v9 {
            v7
        } else {
            v8
        };
        let mut v11: bool = v2 >= v10;
        let mut v16: Rc<str> = if v11 {
            let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v12.clone()
        } else {
            let mut v13: bool = v2 == v10;
            let mut v14: i32 = v10 - 1i32;
            let mut v15: Rc<str> = string_slice(&v0.clone(), v2 as i64, v14 as i64);
            v15.clone()
        };
        let mut v17: i32 = (v16.clone().len() as i32);
        let mut v18: bool = v17 > 0i32;
        let mut v22: bool = if v18 {
            let mut v19: i32 = v17 - 1i32;
            let mut v20: u8 = v16.clone().as_bytes()[v19 as usize];
            let mut v21: bool = v20 == b'\n';
            v21
        } else {
            false
        };
        let mut v25: Rc<str> = if v22 {
            let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v23.clone()
        } else {
            let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            v24.clone()
        };
        let mut v26: i32 = v4 - 1i32;
        let mut v27: i32 = 0i32;
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method90(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v30: Rc<str> = v28(v29.clone());
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v33));
        let mut v35: u8 = b'"';
        let mut v36: Rc<str> = method91(v35, v3, v4);
        let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / "); } LIT.with(|lit| lit.clone()) };
        let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v36));
        let mut v41: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v41));
        let mut v43: Rc<str> = Rc::<str>::from(format!("{}{}", v42, v16));
        let mut v44: Rc<str> = Rc::<str>::from(format!("{}{}", v43, v25));
        let mut v45: Rc<str> = Rc::<str>::from(format!("{}{}", v44, v34));
        let mut v46: Rc<str> = Rc::<str>::from(format!("{}{}", v45, v41));
        v46.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure18() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = b'\'';
        let mut v7: Rc<str> = method81(v6, v2, v3, v4, v5);
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = Rc::<str>::from(format!("{}{}", v8, v7));
        v9.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure19() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method89(v0.clone(), v6, v1);
        let mut v8: i32 = v1 + 80i32;
        let mut v9: bool = v7 < v8;
        let mut v10: i32 = if v9 {
            v7
        } else {
            v8
        };
        let mut v11: bool = v2 >= v10;
        let mut v16: Rc<str> = if v11 {
            let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v12.clone()
        } else {
            let mut v13: bool = v2 == v10;
            let mut v14: i32 = v10 - 1i32;
            let mut v15: Rc<str> = string_slice(&v0.clone(), v2 as i64, v14 as i64);
            v15.clone()
        };
        let mut v17: i32 = (v16.clone().len() as i32);
        let mut v18: bool = v17 > 0i32;
        let mut v22: bool = if v18 {
            let mut v19: i32 = v17 - 1i32;
            let mut v20: u8 = v16.clone().as_bytes()[v19 as usize];
            let mut v21: bool = v20 == b'\n';
            v21
        } else {
            false
        };
        let mut v25: Rc<str> = if v22 {
            let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v23.clone()
        } else {
            let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            v24.clone()
        };
        let mut v26: i32 = v4 - 1i32;
        let mut v27: i32 = 0i32;
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method90(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: u8 = b'\'';
        let mut v34: Rc<str> = method91(v33, v3, v4);
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / "); } LIT.with(|lit| lit.clone()) };
        let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v34));
        let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v37));
        let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v16));
        let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v32));
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v37));
        v42.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure20() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.choice / no parsers succeeded"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method93(mut v0: Rc<RefCell<Vec<u8>>>) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    let mut v4: Rc<str> = Rc::<str>::from(format!("{:?}", v0.borrow()));
    method6(v2.clone(), v4.clone());
    let mut v5: Rc<str> = v2.borrow().l0.clone();
    v5.clone()
}
fn method95(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("chars'"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method96(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("s"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method94(mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32) -> Rc<str> {
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v6: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v5.clone() }));
    method13(v6.clone());
    method95(v6.clone());
    method15(v6.clone());
    method6(v6.clone(), v0.clone());
    method41(v6.clone());
    method96(v6.clone());
    method15(v6.clone());
    let mut v24: std::string::String = format!("{:#?}", (v1, v2, v3, v4));
    let mut v26: Rc<str> = Rc::<str>::from(v24);
    method6(v6.clone(), v26.clone());
    method16(v6.clone());
    let mut v27: Rc<str> = v6.borrow().l0.clone();
    v27.clone()
}
fn closure21() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v23: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v23.borrow_mut().push(b'"');
        v23.borrow_mut().push(b'\'');
        let mut v24: Rc<Vec<u8>> = Rc::new(v23.borrow().clone());
        let mut v27: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v24).as_ref().clone()));
        let mut v28: Rc<str> = method93(v27.clone());
        let mut v29: Rc<str> = method94(v28.clone(), v2, v3, v4, v5);
        let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v33: Rc<str> = Rc::<str>::from(format!("{}{}", v32, v29));
        v33.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method98(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("first_char"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method97(mut v0: u8, mut v1: Rc<str>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32) -> Rc<str> {
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v6.clone() }));
    method13(v7.clone());
    method98(v7.clone());
    method15(v7.clone());
    let mut v8: Rc<str> = Rc::<str>::from(format!("{}", v0 as char));
    method6(v7.clone(), v8.clone());
    method41(v7.clone());
    method95(v7.clone());
    method15(v7.clone());
    method6(v7.clone(), v1.clone());
    method41(v7.clone());
    method96(v7.clone());
    method15(v7.clone());
    let mut v10: std::string::String = format!("{:#?}", (v2, v3, v4, v5));
    let mut v12: Rc<str> = Rc::<str>::from(v10);
    method6(v7.clone(), v12.clone());
    method16(v7.clone());
    let mut v13: Rc<str> = v7.borrow().l0.clone();
    v13.clone()
}
fn closure22() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'"');
        v7.borrow_mut().push(b'\'');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method93(v9.clone());
        let mut v11: Rc<str> = method97(v6, v10.clone(), v2, v3, v4, v5);
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v11));
        v15.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure23() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many1_chars / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method99(mut v0: i32, mut v1: Rc<str>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> US11 {
    loop {
        let mut v7: bool = v2 >= v6;
        let mut v28: US10 = if v7 {
            let mut v8: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure21();
            US10::US10_1(v8.clone(), v2, v3, v4, v5, v6)
        } else {
            let mut v10: u8 = v1.clone().as_bytes()[v2 as usize];
            let mut v11: bool = v10 == b'"';
            let mut v13: bool = if v11 {
                true
            } else {
                let mut v12: bool = v10 == b'\'';
                v12
            };
            let mut v14: bool = v13 == false;
            if v14 {
                let mut v15: i32 = v2 + 1i32;
                let mut v16: bool = b'\n' == v10;
                let (mut v20, mut v21, mut v22, mut v23): (i32, i32, i32, i32) = if v16 {
                    let mut v17: i32 = v3 + v5;
                    let mut v18: i32 = v4 + 1i32;
                    (v17, v18, 1i32, v6)
                } else {
                    let mut v19: i32 = v5 + 1i32;
                    (v3, v4, v19, v6)
                };
                US10::US10_0(v10, v15, v20, v21, v22, v23)
            } else {
                let mut v25: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure22();
                US10::US10_1(v25.clone(), v2, v3, v4, v5, v6)
            }
        };
        match &v28 {
            US10::US10_1(v29, v30, v31, v32, v33, v34) => { // Error
                let mut v29: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v29.clone();
                let mut v30: i32 = v30.clone();
                let mut v31: i32 = v31.clone();
                let mut v32: i32 = v32.clone();
                let mut v33: i32 = v33.clone();
                let mut v34: i32 = v34.clone();
                let mut v35: bool = v0 >= v2;
                let mut v40: Rc<str> = if v35 {
                    let mut v36: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v36.clone()
                } else {
                    let mut v37: bool = v0 == v2;
                    let mut v38: i32 = v2 - 1i32;
                    let mut v39: Rc<str> = string_slice(&v1.clone(), v0 as i64, v38 as i64);
                    v39.clone()
                };
                return US11::US11_0(v40.clone(), v2, v3, v4, v5, v6);
            }
            US10::US10_0(v42, v43, v44, v45, v46, v47) => { // Ok
                let mut v42: u8 = v42.clone();
                let mut v43: i32 = v43.clone();
                let mut v44: i32 = v44.clone();
                let mut v45: i32 = v45.clone();
                let mut v46: i32 = v46.clone();
                let mut v47: i32 = v47.clone();
                let mut v48: bool = v43 == v2;
                let mut v49: bool = v48 != true;
                if v49 {
                    (v0, v1, v2, v3, v4, v5, v6) = (v0, v1.clone(), v43, v44, v45, v46, v47);
                    continue;
                } else {
                    let mut v51: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                    return US11::US11_1(v51.clone(), v2, v3, v4, v5, v6);
                }
            }
            _ => unreachable!(),
        }
    }
}
fn method101(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest'"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method100(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    method13(v2.clone());
    method101(v2.clone());
    method15(v2.clone());
    method6(v2.clone(), v0.clone());
    method16(v2.clone());
    let mut v3: Rc<str> = v2.borrow().l0.clone();
    v3.clone()
}
fn closure24() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = v1 + 80i32;
        let mut v7: i32 = (v0.clone().len() as i32);
        let mut v8: bool = v7 < v6;
        let mut v9: i32 = if v8 {
            v7
        } else {
            v6
        };
        let mut v10: bool = v1 >= v9;
        let mut v15: Rc<str> = if v10 {
            let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v11.clone()
        } else {
            let mut v12: bool = v1 == v9;
            let mut v13: i32 = v9 - 1i32;
            let mut v14: Rc<str> = string_slice(&v0.clone(), v1 as i64, v13 as i64);
            v14.clone()
        };
        let mut v16: Rc<str> = method100(v15.clone());
        let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.between / expected content or closing delimiter / "); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v16));
        v20.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure26(mut v0: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: Rc<str>) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v0(v6.clone(), v1, v2, v3, v4, v5)
    })
}
fn method103(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("e"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method104(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("t"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method105(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest''"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method102(mut v0: Rc<dyn Fn() -> Rc<str>>, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>) -> Rc<str> {
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v4.clone() }));
    method13(v5.clone());
    method103(v5.clone());
    method15(v5.clone());
    let mut v6: Rc<str> = v0();
    method6(v5.clone(), v6.clone());
    method41(v5.clone());
    method104(v5.clone());
    method15(v5.clone());
    method6(v5.clone(), v1.clone());
    method41(v5.clone());
    method101(v5.clone());
    method15(v5.clone());
    method6(v5.clone(), v2.clone());
    method41(v5.clone());
    method105(v5.clone());
    method15(v5.clone());
    method6(v5.clone(), v3.clone());
    method16(v5.clone());
    let mut v7: Rc<str> = v5.borrow().l0.clone();
    v7.clone()
}
fn closure25(mut v0: i32, mut v1: i32, mut v2: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32) -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    Rc::new(move |mut v8: Rc<str>, mut v9: i32, mut v10: i32, mut v11: i32, mut v12: i32, mut v13: i32| -> Rc<str> {
        let mut v14: i32 = (v8.clone().len() as i32);
        let mut v15: i32 = v0 + 80i32;
        let mut v16: bool = v14 < v15;
        let mut v17: i32 = if v16 {
            v14
        } else {
            v15
        };
        let mut v18: i32 = v1 + 80i32;
        let mut v19: bool = v14 < v18;
        let mut v20: i32 = if v19 {
            v14
        } else {
            v18
        };
        let mut v21: bool = v0 >= v17;
        let mut v26: Rc<str> = if v21 {
            let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v22.clone()
        } else {
            let mut v23: bool = v0 == v17;
            let mut v24: i32 = v17 - 1i32;
            let mut v25: Rc<str> = string_slice(&v8.clone(), v0 as i64, v24 as i64);
            v25.clone()
        };
        let mut v27: bool = v1 >= v20;
        let mut v32: Rc<str> = if v27 {
            let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v28.clone()
        } else {
            let mut v29: bool = v1 == v20;
            let mut v30: i32 = v20 - 1i32;
            let mut v31: Rc<str> = string_slice(&v8.clone(), v1 as i64, v30 as i64);
            v31.clone()
        };
        let mut v33: Rc<dyn Fn() -> Rc<str>> = closure26(v2.clone(), v3, v4, v5, v6, v7, v8.clone());
        let mut v34: Rc<str> = method102(v33.clone(), v8.clone(), v26.clone(), v32.clone());
        let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.between / expected closing delimiter / "); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v34));
        v38.clone()
    })
}
fn closure27() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v28: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v28.borrow_mut().push(b'"');
        v28.borrow_mut().push(b'\'');
        v28.borrow_mut().push(b' ');
        let mut v29: Rc<Vec<u8>> = Rc::new(v28.borrow().clone());
        let mut v30: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v29).as_ref().clone()));
        let mut v31: Rc<str> = method93(v30.clone());
        let mut v32: Rc<str> = method94(v31.clone(), v2, v3, v4, v5);
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v32));
        v34.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure28() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'"');
        v7.borrow_mut().push(b'\'');
        v7.borrow_mut().push(b' ');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method93(v9.clone());
        let mut v11: Rc<str> = method97(v6, v10.clone(), v2, v3, v4, v5);
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v11));
        v13.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method106(mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32) -> US11 {
    loop {
        let mut v6: bool = v1 >= v5;
        let mut v29: US10 = if v6 {
            let mut v7: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
            US10::US10_1(v7.clone(), v1, v2, v3, v4, v5)
        } else {
            let mut v9: u8 = v0.clone().as_bytes()[v1 as usize];
            let mut v10: bool = v9 == b'"';
            let mut v14: bool = if v10 {
                true
            } else {
                let mut v11: bool = v9 == b'\'';
                if v11 {
                    true
                } else {
                    let mut v12: bool = v9 == b' ';
                    v12
                }
            };
            let mut v15: bool = v14 == false;
            if v15 {
                let mut v16: i32 = v1 + 1i32;
                let mut v17: bool = b'\n' == v9;
                let (mut v21, mut v22, mut v23, mut v24): (i32, i32, i32, i32) = if v17 {
                    let mut v18: i32 = v2 + v4;
                    let mut v19: i32 = v3 + 1i32;
                    (v18, v19, 1i32, v5)
                } else {
                    let mut v20: i32 = v4 + 1i32;
                    (v2, v3, v20, v5)
                };
                US10::US10_0(v9, v16, v21, v22, v23, v24)
            } else {
                let mut v26: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28();
                US10::US10_1(v26.clone(), v1, v2, v3, v4, v5)
            }
        };
        match &v29 {
            US10::US10_1(v30, v31, v32, v33, v34, v35) => { // Error
                let mut v30: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v30.clone();
                let mut v31: i32 = v31.clone();
                let mut v32: i32 = v32.clone();
                let mut v33: i32 = v33.clone();
                let mut v34: i32 = v34.clone();
                let mut v35: i32 = v35.clone();
                let mut v36: bool = 0i32 >= v1;
                let mut v41: Rc<str> = if v36 {
                    let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v37.clone()
                } else {
                    let mut v38: bool = 0i32 == v1;
                    let mut v39: i32 = v1 - 1i32;
                    let mut v40: Rc<str> = string_slice(&v0.clone(), 0i32 as i64, v39 as i64);
                    v40.clone()
                };
                return US11::US11_0(v41.clone(), v1, v2, v3, v4, v5);
            }
            US10::US10_0(v43, v44, v45, v46, v47, v48) => { // Ok
                let mut v43: u8 = v43.clone();
                let mut v44: i32 = v44.clone();
                let mut v45: i32 = v45.clone();
                let mut v46: i32 = v46.clone();
                let mut v47: i32 = v47.clone();
                let mut v48: i32 = v48.clone();
                let mut v49: bool = v44 == v1;
                let mut v50: bool = v49 != true;
                if v50 {
                    (v0, v1, v2, v3, v4, v5) = (v0.clone(), v44, v45, v46, v47, v48);
                    continue;
                } else {
                    let mut v52: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure23();
                    return US11::US11_1(v52.clone(), v1, v2, v3, v4, v5);
                }
            }
            _ => unreachable!(),
        }
    }
}
fn method108(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("rest"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method107(mut v0: Rc<str>) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    method13(v2.clone());
    method108(v2.clone());
    method15(v2.clone());
    method6(v2.clone(), v0.clone());
    method16(v2.clone());
    let mut v3: Rc<str> = v2.borrow().l0.clone();
    v3.clone()
}
fn closure29() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: bool = v1 >= v5;
        let mut v11: Rc<str> = if v6 {
            let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v7.clone()
        } else {
            let mut v8: bool = v1 == v5;
            let mut v9: i32 = v5 - 1i32;
            let mut v10: Rc<str> = string_slice(&v0.clone(), v1 as i64, v9 as i64);
            v10.clone()
        };
        let mut v12: Rc<str> = method107(v11.clone());
        let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.eof / expected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v12));
        v16.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method109(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> i32 {
    loop {
        let mut v3: bool = v2 >= v1;
        if v3 {
            return v2;
        } else {
            let mut v4: u8 = v0.clone().as_bytes()[v2 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v7: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'\t';
                v6
            };
            let mut v9: bool = if v7 {
                true
            } else {
                let mut v8: bool = v4 == b'\r';
                v8
            };
            if v9 {
                let mut v10: i32 = v2 + 1i32;
                (v0, v1, v2) = (v0.clone(), v1, v10);
                continue;
            } else {
                return v2;
            }
        }
    }
}
fn closure30() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = v1 + 80i32;
        let mut v7: bool = v5 < v6;
        let mut v8: i32 = if v7 {
            v5
        } else {
            v6
        };
        let mut v9: bool = v1 >= v8;
        let mut v14: Rc<str> = if v9 {
            let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v10.clone()
        } else {
            let mut v11: bool = v1 == v8;
            let mut v12: i32 = v8 - 1i32;
            let mut v13: Rc<str> = string_slice(&v0.clone(), v1 as i64, v12 as i64);
            v13.clone()
        };
        let mut v15: Rc<str> = method107(v14.clone());
        let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.spaces1 / expected at least one space / "); } LIT.with(|lit| lit.clone()) };
        let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v15));
        v19.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure31(mut v0: Rc<str>) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v0.clone()
    })
}
fn closure32(mut v0: Rc<str>) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v0.clone()
    })
}
fn closure33(mut v0: US14) -> Rc<dyn Fn() -> US14> {
    Rc::new(move || -> US14 {
        v0.clone()
    })
}
fn closure34(mut v0: Rc<str>, mut v1: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> Rc<dyn Fn() -> Rc<str>> {
    Rc::new(move || -> Rc<str> {
        v1(v0.clone(), v2, v3, v4, v5, v6)
    })
}
fn method80(mut v0: Rc<str>) -> US9 {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: bool = 0i32 >= v1;
    let mut v16: US10 = if v2 {
        let mut v3: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
        US10::US10_1(v3.clone(), 0i32, 0i32, 1i32, 1i32, v1)
    } else {
        let mut v5: u8 = v0.clone().as_bytes()[0i32 as usize];
        let mut v6: bool = v5 == b'"';
        if v6 {
            let mut v7: bool = b'\n' == v5;
            let (mut v8, mut v9, mut v10, mut v11): (i32, i32, i32, i32) = if v7 {
                (1i32, 2i32, 1i32, v1)
            } else {
                (0i32, 1i32, 2i32, v1)
            };
            US10::US10_0(b'"', 1i32, v8, v9, v10, v11)
        } else {
            let mut v13: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
            US10::US10_1(v13.clone(), 0i32, 0i32, 1i32, 1i32, v1)
        }
    };
    let mut v60: US10 = match &v16 {
        US10::US10_1(v23, v24, v25, v26, v27, v28) => { // Error
            let mut v23: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v23.clone();
            let mut v24: i32 = v24.clone();
            let mut v25: i32 = v25.clone();
            let mut v26: i32 = v26.clone();
            let mut v27: i32 = v27.clone();
            let mut v28: i32 = v28.clone();
            let mut v42: US10 = if v2 {
                let mut v29: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                US10::US10_1(v29.clone(), 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let mut v31: u8 = v0.clone().as_bytes()[0i32 as usize];
                let mut v32: bool = v31 == b'\'';
                if v32 {
                    let mut v33: bool = b'\n' == v31;
                    let (mut v34, mut v35, mut v36, mut v37): (i32, i32, i32, i32) = if v33 {
                        (1i32, 2i32, 1i32, v1)
                    } else {
                        (0i32, 1i32, 2i32, v1)
                    };
                    US10::US10_0(b'\'', 1i32, v34, v35, v36, v37)
                } else {
                    let mut v39: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                    US10::US10_1(v39.clone(), 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            match &v42 {
                US10::US10_1(v49, v50, v51, v52, v53, v54) => { // Error
                    let mut v49: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v49.clone();
                    let mut v50: i32 = v50.clone();
                    let mut v51: i32 = v51.clone();
                    let mut v52: i32 = v52.clone();
                    let mut v53: i32 = v53.clone();
                    let mut v54: i32 = v54.clone();
                    let mut v55: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                    US10::US10_1(v55.clone(), 0i32, 0i32, 1i32, 1i32, v1)
                }
                US10::US10_0(v43, v44, v45, v46, v47, v48) => { // Ok
                    let mut v43: u8 = v43.clone();
                    let mut v44: i32 = v44.clone();
                    let mut v45: i32 = v45.clone();
                    let mut v46: i32 = v46.clone();
                    let mut v47: i32 = v47.clone();
                    let mut v48: i32 = v48.clone();
                    v42.clone()
                }
                _ => unreachable!(),
            }
        }
        US10::US10_0(v17, v18, v19, v20, v21, v22) => { // Ok
            let mut v17: u8 = v17.clone();
            let mut v18: i32 = v18.clone();
            let mut v19: i32 = v19.clone();
            let mut v20: i32 = v20.clone();
            let mut v21: i32 = v21.clone();
            let mut v22: i32 = v22.clone();
            v16.clone()
        }
        _ => unreachable!(),
    };
    let mut v312: US11 = match &v60 {
        US10::US10_1(v304, v305, v306, v307, v308, v309) => { // Error
            let mut v304: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v304.clone();
            let mut v305: i32 = v305.clone();
            let mut v306: i32 = v306.clone();
            let mut v307: i32 = v307.clone();
            let mut v308: i32 = v308.clone();
            let mut v309: i32 = v309.clone();
            US11::US11_1(v304.clone(), v305, v306, v307, v308, v309)
        }
        US10::US10_0(v61, v62, v63, v64, v65, v66) => { // Ok
            let mut v61: u8 = v61.clone();
            let mut v62: i32 = v62.clone();
            let mut v63: i32 = v63.clone();
            let mut v64: i32 = v64.clone();
            let mut v65: i32 = v65.clone();
            let mut v66: i32 = v66.clone();
            let mut v67: bool = v62 >= v66;
            let mut v88: US10 = if v67 {
                let mut v68: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure21();
                US10::US10_1(v68.clone(), v62, v63, v64, v65, v66)
            } else {
                let mut v70: u8 = v0.clone().as_bytes()[v62 as usize];
                let mut v71: bool = v70 == b'"';
                let mut v73: bool = if v71 {
                    true
                } else {
                    let mut v72: bool = v70 == b'\'';
                    v72
                };
                let mut v74: bool = v73 == false;
                if v74 {
                    let mut v75: i32 = v62 + 1i32;
                    let mut v76: bool = b'\n' == v70;
                    let (mut v80, mut v81, mut v82, mut v83): (i32, i32, i32, i32) = if v76 {
                        let mut v77: i32 = v63 + v65;
                        let mut v78: i32 = v64 + 1i32;
                        (v77, v78, 1i32, v66)
                    } else {
                        let mut v79: i32 = v65 + 1i32;
                        (v63, v64, v79, v66)
                    };
                    US10::US10_0(v70, v75, v80, v81, v82, v83)
                } else {
                    let mut v85: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure22();
                    US10::US10_1(v85.clone(), v62, v63, v64, v65, v66)
                }
            };
            let mut v104: US11 = match &v88 {
                US10::US10_1(v89, v90, v91, v92, v93, v94) => { // Error
                    let mut v89: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v89.clone();
                    let mut v90: i32 = v90.clone();
                    let mut v91: i32 = v91.clone();
                    let mut v92: i32 = v92.clone();
                    let mut v93: i32 = v93.clone();
                    let mut v94: i32 = v94.clone();
                    US11::US11_1(v89.clone(), v90, v91, v92, v93, v94)
                }
                US10::US10_0(v96, v97, v98, v99, v100, v101) => { // Ok
                    let mut v96: u8 = v96.clone();
                    let mut v97: i32 = v97.clone();
                    let mut v98: i32 = v98.clone();
                    let mut v99: i32 = v99.clone();
                    let mut v100: i32 = v100.clone();
                    let mut v101: i32 = v101.clone();
                    method99(v62, v0.clone(), v97, v98, v99, v100, v101)
                }
                _ => unreachable!(),
            };
            let mut v121: US11 = match &v104 {
                US11::US11_1(v112, v113, v114, v115, v116, v117) => { // Error
                    let mut v112: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v112.clone();
                    let mut v113: i32 = v113.clone();
                    let mut v114: i32 = v114.clone();
                    let mut v115: i32 = v115.clone();
                    let mut v116: i32 = v116.clone();
                    let mut v117: i32 = v117.clone();
                    let mut v118: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    US11::US11_0(v118.clone(), v62, v63, v64, v65, v66)
                }
                US11::US11_0(v105, v106, v107, v108, v109, v110) => { // Ok
                    let mut v105: Rc<str> = v105.clone();
                    let mut v106: i32 = v106.clone();
                    let mut v107: i32 = v107.clone();
                    let mut v108: i32 = v108.clone();
                    let mut v109: i32 = v109.clone();
                    let mut v110: i32 = v110.clone();
                    US11::US11_0(v105.clone(), v106, v107, v108, v109, v110)
                }
                _ => unreachable!(),
            };
            match &v121 {
                US11::US11_1(v212, v213, v214, v215, v216, v217) => { // Error
                    let mut v212: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v212.clone();
                    let mut v213: i32 = v213.clone();
                    let mut v214: i32 = v214.clone();
                    let mut v215: i32 = v215.clone();
                    let mut v216: i32 = v216.clone();
                    let mut v217: i32 = v217.clone();
                    let mut v235: US10 = if v67 {
                        let mut v218: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                        US10::US10_1(v218.clone(), v62, v63, v64, v65, v66)
                    } else {
                        let mut v220: u8 = v0.clone().as_bytes()[v62 as usize];
                        let mut v221: bool = v220 == b'"';
                        if v221 {
                            let mut v222: i32 = v62 + 1i32;
                            let mut v223: bool = b'\n' == v220;
                            let (mut v227, mut v228, mut v229, mut v230): (i32, i32, i32, i32) = if v223 {
                                let mut v224: i32 = v63 + v65;
                                let mut v225: i32 = v64 + 1i32;
                                (v224, v225, 1i32, v66)
                            } else {
                                let mut v226: i32 = v65 + 1i32;
                                (v63, v64, v226, v66)
                            };
                            US10::US10_0(b'"', v222, v227, v228, v229, v230)
                        } else {
                            let mut v232: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                            US10::US10_1(v232.clone(), v62, v63, v64, v65, v66)
                        }
                    };
                    let mut v283: US10 = match &v235 {
                        US10::US10_1(v242, v243, v244, v245, v246, v247) => { // Error
                            let mut v242: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v242.clone();
                            let mut v243: i32 = v243.clone();
                            let mut v244: i32 = v244.clone();
                            let mut v245: i32 = v245.clone();
                            let mut v246: i32 = v246.clone();
                            let mut v247: i32 = v247.clone();
                            let mut v265: US10 = if v67 {
                                let mut v248: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                US10::US10_1(v248.clone(), v62, v63, v64, v65, v66)
                            } else {
                                let mut v250: u8 = v0.clone().as_bytes()[v62 as usize];
                                let mut v251: bool = v250 == b'\'';
                                if v251 {
                                    let mut v252: i32 = v62 + 1i32;
                                    let mut v253: bool = b'\n' == v250;
                                    let (mut v257, mut v258, mut v259, mut v260): (i32, i32, i32, i32) = if v253 {
                                        let mut v254: i32 = v63 + v65;
                                        let mut v255: i32 = v64 + 1i32;
                                        (v254, v255, 1i32, v66)
                                    } else {
                                        let mut v256: i32 = v65 + 1i32;
                                        (v63, v64, v256, v66)
                                    };
                                    US10::US10_0(b'\'', v252, v257, v258, v259, v260)
                                } else {
                                    let mut v262: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                    US10::US10_1(v262.clone(), v62, v63, v64, v65, v66)
                                }
                            };
                            match &v265 {
                                US10::US10_1(v272, v273, v274, v275, v276, v277) => { // Error
                                    let mut v272: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v272.clone();
                                    let mut v273: i32 = v273.clone();
                                    let mut v274: i32 = v274.clone();
                                    let mut v275: i32 = v275.clone();
                                    let mut v276: i32 = v276.clone();
                                    let mut v277: i32 = v277.clone();
                                    let mut v278: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US10::US10_1(v278.clone(), v62, v63, v64, v65, v66)
                                }
                                US10::US10_0(v266, v267, v268, v269, v270, v271) => { // Ok
                                    let mut v266: u8 = v266.clone();
                                    let mut v267: i32 = v267.clone();
                                    let mut v268: i32 = v268.clone();
                                    let mut v269: i32 = v269.clone();
                                    let mut v270: i32 = v270.clone();
                                    let mut v271: i32 = v271.clone();
                                    v265.clone()
                                }
                                _ => unreachable!(),
                            }
                        }
                        US10::US10_0(v236, v237, v238, v239, v240, v241) => { // Ok
                            let mut v236: u8 = v236.clone();
                            let mut v237: i32 = v237.clone();
                            let mut v238: i32 = v238.clone();
                            let mut v239: i32 = v239.clone();
                            let mut v240: i32 = v240.clone();
                            let mut v241: i32 = v241.clone();
                            v235.clone()
                        }
                        _ => unreachable!(),
                    };
                    match &v283 {
                        US10::US10_1(v292, v293, v294, v295, v296, v297) => { // Error
                            let mut v292: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v292.clone();
                            let mut v293: i32 = v293.clone();
                            let mut v294: i32 = v294.clone();
                            let mut v295: i32 = v295.clone();
                            let mut v296: i32 = v296.clone();
                            let mut v297: i32 = v297.clone();
                            let mut v298: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                            US11::US11_1(v298.clone(), v62, v63, v64, v65, v66)
                        }
                        US10::US10_0(v284, v285, v286, v287, v288, v289) => { // Ok
                            let mut v284: u8 = v284.clone();
                            let mut v285: i32 = v285.clone();
                            let mut v286: i32 = v286.clone();
                            let mut v287: i32 = v287.clone();
                            let mut v288: i32 = v288.clone();
                            let mut v289: i32 = v289.clone();
                            let mut v290: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            US11::US11_0(v290.clone(), v285, v286, v287, v288, v289)
                        }
                        _ => unreachable!(),
                    }
                }
                US11::US11_0(v122, v123, v124, v125, v126, v127) => { // Ok
                    let mut v122: Rc<str> = v122.clone();
                    let mut v123: i32 = v123.clone();
                    let mut v124: i32 = v124.clone();
                    let mut v125: i32 = v125.clone();
                    let mut v126: i32 = v126.clone();
                    let mut v127: i32 = v127.clone();
                    let mut v128: bool = v123 >= v127;
                    let mut v146: US10 = if v128 {
                        let mut v129: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                        US10::US10_1(v129.clone(), v123, v124, v125, v126, v127)
                    } else {
                        let mut v131: u8 = v0.clone().as_bytes()[v123 as usize];
                        let mut v132: bool = v131 == b'"';
                        if v132 {
                            let mut v133: i32 = v123 + 1i32;
                            let mut v134: bool = b'\n' == v131;
                            let (mut v138, mut v139, mut v140, mut v141): (i32, i32, i32, i32) = if v134 {
                                let mut v135: i32 = v124 + v126;
                                let mut v136: i32 = v125 + 1i32;
                                (v135, v136, 1i32, v127)
                            } else {
                                let mut v137: i32 = v126 + 1i32;
                                (v124, v125, v137, v127)
                            };
                            US10::US10_0(b'"', v133, v138, v139, v140, v141)
                        } else {
                            let mut v143: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                            US10::US10_1(v143.clone(), v123, v124, v125, v126, v127)
                        }
                    };
                    let mut v194: US10 = match &v146 {
                        US10::US10_1(v153, v154, v155, v156, v157, v158) => { // Error
                            let mut v153: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v153.clone();
                            let mut v154: i32 = v154.clone();
                            let mut v155: i32 = v155.clone();
                            let mut v156: i32 = v156.clone();
                            let mut v157: i32 = v157.clone();
                            let mut v158: i32 = v158.clone();
                            let mut v176: US10 = if v128 {
                                let mut v159: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure18();
                                US10::US10_1(v159.clone(), v123, v124, v125, v126, v127)
                            } else {
                                let mut v161: u8 = v0.clone().as_bytes()[v123 as usize];
                                let mut v162: bool = v161 == b'\'';
                                if v162 {
                                    let mut v163: i32 = v123 + 1i32;
                                    let mut v164: bool = b'\n' == v161;
                                    let (mut v168, mut v169, mut v170, mut v171): (i32, i32, i32, i32) = if v164 {
                                        let mut v165: i32 = v124 + v126;
                                        let mut v166: i32 = v125 + 1i32;
                                        (v165, v166, 1i32, v127)
                                    } else {
                                        let mut v167: i32 = v126 + 1i32;
                                        (v124, v125, v167, v127)
                                    };
                                    US10::US10_0(b'\'', v163, v168, v169, v170, v171)
                                } else {
                                    let mut v173: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure19();
                                    US10::US10_1(v173.clone(), v123, v124, v125, v126, v127)
                                }
                            };
                            match &v176 {
                                US10::US10_1(v183, v184, v185, v186, v187, v188) => { // Error
                                    let mut v183: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v183.clone();
                                    let mut v184: i32 = v184.clone();
                                    let mut v185: i32 = v185.clone();
                                    let mut v186: i32 = v186.clone();
                                    let mut v187: i32 = v187.clone();
                                    let mut v188: i32 = v188.clone();
                                    let mut v189: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US10::US10_1(v189.clone(), v123, v124, v125, v126, v127)
                                }
                                US10::US10_0(v177, v178, v179, v180, v181, v182) => { // Ok
                                    let mut v177: u8 = v177.clone();
                                    let mut v178: i32 = v178.clone();
                                    let mut v179: i32 = v179.clone();
                                    let mut v180: i32 = v180.clone();
                                    let mut v181: i32 = v181.clone();
                                    let mut v182: i32 = v182.clone();
                                    v176.clone()
                                }
                                _ => unreachable!(),
                            }
                        }
                        US10::US10_0(v147, v148, v149, v150, v151, v152) => { // Ok
                            let mut v147: u8 = v147.clone();
                            let mut v148: i32 = v148.clone();
                            let mut v149: i32 = v149.clone();
                            let mut v150: i32 = v150.clone();
                            let mut v151: i32 = v151.clone();
                            let mut v152: i32 = v152.clone();
                            v146.clone()
                        }
                        _ => unreachable!(),
                    };
                    match &v194 {
                        US10::US10_1(v202, v203, v204, v205, v206, v207) => { // Error
                            let mut v202: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v202.clone();
                            let mut v203: i32 = v203.clone();
                            let mut v204: i32 = v204.clone();
                            let mut v205: i32 = v205.clone();
                            let mut v206: i32 = v206.clone();
                            let mut v207: i32 = v207.clone();
                            let mut v208: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v62, v123, v202.clone(), v203, v204, v205, v206, v207);
                            US11::US11_1(v208.clone(), v123, v124, v125, v126, v127)
                        }
                        US10::US10_0(v195, v196, v197, v198, v199, v200) => { // Ok
                            let mut v195: u8 = v195.clone();
                            let mut v196: i32 = v196.clone();
                            let mut v197: i32 = v197.clone();
                            let mut v198: i32 = v198.clone();
                            let mut v199: i32 = v199.clone();
                            let mut v200: i32 = v200.clone();
                            US11::US11_0(v122.clone(), v196, v197, v198, v199, v200)
                        }
                        _ => unreachable!(),
                    }
                }
                _ => unreachable!(),
            }
        }
        _ => unreachable!(),
    };
    let mut v331: US11 = match &v312 {
        US11::US11_1(v323, v324, v325, v326, v327, v328) => { // Error
            let mut v323: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v323.clone();
            let mut v324: i32 = v324.clone();
            let mut v325: i32 = v325.clone();
            let mut v326: i32 = v326.clone();
            let mut v327: i32 = v327.clone();
            let mut v328: i32 = v328.clone();
            US11::US11_1(v323.clone(), v324, v325, v326, v327, v328)
        }
        US11::US11_0(v313, v314, v315, v316, v317, v318) => { // Ok
            let mut v313: Rc<str> = v313.clone();
            let mut v314: i32 = v314.clone();
            let mut v315: i32 = v315.clone();
            let mut v316: i32 = v316.clone();
            let mut v317: i32 = v317.clone();
            let mut v318: i32 = v318.clone();
            let mut v319: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
            let mut v320: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
            let mut v321: Rc<str> = Rc::<str>::from(v313.replace(&*v319, &*v320));
            US11::US11_0(v321.clone(), v314, v315, v316, v317, v318)
        }
        _ => unreachable!(),
    };
    let mut v399: US11 = match &v331 {
        US11::US11_1(v338, v339, v340, v341, v342, v343) => { // Error
            let mut v338: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v338.clone();
            let mut v339: i32 = v339.clone();
            let mut v340: i32 = v340.clone();
            let mut v341: i32 = v341.clone();
            let mut v342: i32 = v342.clone();
            let mut v343: i32 = v343.clone();
            let mut v362: US10 = if v2 {
                let mut v344: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure27();
                US10::US10_1(v344.clone(), 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let mut v346: u8 = v0.clone().as_bytes()[0i32 as usize];
                let mut v347: bool = v346 == b'"';
                let mut v351: bool = if v347 {
                    true
                } else {
                    let mut v348: bool = v346 == b'\'';
                    if v348 {
                        true
                    } else {
                        let mut v349: bool = v346 == b' ';
                        v349
                    }
                };
                let mut v352: bool = v351 == false;
                if v352 {
                    let mut v353: bool = b'\n' == v346;
                    let (mut v354, mut v355, mut v356, mut v357): (i32, i32, i32, i32) = if v353 {
                        (1i32, 2i32, 1i32, v1)
                    } else {
                        (0i32, 1i32, 2i32, v1)
                    };
                    US10::US10_0(v346, 1i32, v354, v355, v356, v357)
                } else {
                    let mut v359: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure28();
                    US10::US10_1(v359.clone(), 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            let mut v378: US11 = match &v362 {
                US10::US10_1(v363, v364, v365, v366, v367, v368) => { // Error
                    let mut v363: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v363.clone();
                    let mut v364: i32 = v364.clone();
                    let mut v365: i32 = v365.clone();
                    let mut v366: i32 = v366.clone();
                    let mut v367: i32 = v367.clone();
                    let mut v368: i32 = v368.clone();
                    US11::US11_1(v363.clone(), v364, v365, v366, v367, v368)
                }
                US10::US10_0(v370, v371, v372, v373, v374, v375) => { // Ok
                    let mut v370: u8 = v370.clone();
                    let mut v371: i32 = v371.clone();
                    let mut v372: i32 = v372.clone();
                    let mut v373: i32 = v373.clone();
                    let mut v374: i32 = v374.clone();
                    let mut v375: i32 = v375.clone();
                    method106(v0.clone(), v371, v372, v373, v374, v375)
                }
                _ => unreachable!(),
            };
            match &v378 {
                US11::US11_1(v389, v390, v391, v392, v393, v394) => { // Error
                    let mut v389: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v389.clone();
                    let mut v390: i32 = v390.clone();
                    let mut v391: i32 = v391.clone();
                    let mut v392: i32 = v392.clone();
                    let mut v393: i32 = v393.clone();
                    let mut v394: i32 = v394.clone();
                    US11::US11_1(v389.clone(), v390, v391, v392, v393, v394)
                }
                US11::US11_0(v379, v380, v381, v382, v383, v384) => { // Ok
                    let mut v379: Rc<str> = v379.clone();
                    let mut v380: i32 = v380.clone();
                    let mut v381: i32 = v381.clone();
                    let mut v382: i32 = v382.clone();
                    let mut v383: i32 = v383.clone();
                    let mut v384: i32 = v384.clone();
                    let mut v385: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
                    let mut v386: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
                    let mut v387: Rc<str> = Rc::<str>::from(v379.replace(&*v385, &*v386));
                    US11::US11_0(v387.clone(), v380, v381, v382, v383, v384)
                }
                _ => unreachable!(),
            }
        }
        US11::US11_0(v332, v333, v334, v335, v336, v337) => { // Ok
            let mut v332: Rc<str> = v332.clone();
            let mut v333: i32 = v333.clone();
            let mut v334: i32 = v334.clone();
            let mut v335: i32 = v335.clone();
            let mut v336: i32 = v336.clone();
            let mut v337: i32 = v337.clone();
            v331.clone()
        }
        _ => unreachable!(),
    };
    let mut v434: US11 = match &v399 {
        US11::US11_1(v406, v407, v408, v409, v410, v411) => { // Error
            let mut v406: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v406.clone();
            let mut v407: i32 = v407.clone();
            let mut v408: i32 = v408.clone();
            let mut v409: i32 = v409.clone();
            let mut v410: i32 = v410.clone();
            let mut v411: i32 = v411.clone();
            let mut v412: bool = v1 == 0i32;
            let mut v416: US12 = if v412 {
                US12::US12_0(0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let mut v414: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure29();
                US12::US12_1(v414.clone(), 0i32, 0i32, 1i32, 1i32, v1)
            };
            match &v416 {
                US12::US12_1(v424, v425, v426, v427, v428, v429) => { // Error
                    let mut v424: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v424.clone();
                    let mut v425: i32 = v425.clone();
                    let mut v426: i32 = v426.clone();
                    let mut v427: i32 = v427.clone();
                    let mut v428: i32 = v428.clone();
                    let mut v429: i32 = v429.clone();
                    US11::US11_1(v424.clone(), v425, v426, v427, v428, v429)
                }
                US12::US12_0(v417, v418, v419, v420, v421) => { // Ok
                    let mut v417: i32 = v417.clone();
                    let mut v418: i32 = v418.clone();
                    let mut v419: i32 = v419.clone();
                    let mut v420: i32 = v420.clone();
                    let mut v421: i32 = v421.clone();
                    let mut v422: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    US11::US11_0(v422.clone(), v417, v418, v419, v420, v421)
                }
                _ => unreachable!(),
            }
        }
        US11::US11_0(v400, v401, v402, v403, v404, v405) => { // Ok
            let mut v400: Rc<str> = v400.clone();
            let mut v401: i32 = v401.clone();
            let mut v402: i32 = v402.clone();
            let mut v403: i32 = v403.clone();
            let mut v404: i32 = v404.clone();
            let mut v405: i32 = v405.clone();
            v399.clone()
        }
        _ => unreachable!(),
    };
    let mut v547: US13 = match &v434 {
        US11::US11_1(v435, v436, v437, v438, v439, v440) => { // Error
            let mut v435: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v435.clone();
            let mut v436: i32 = v436.clone();
            let mut v437: i32 = v437.clone();
            let mut v438: i32 = v438.clone();
            let mut v439: i32 = v439.clone();
            let mut v440: i32 = v440.clone();
            US13::US13_1(v435.clone(), v436, v437, v438, v439, v440)
        }
        US11::US11_0(v442, v443, v444, v445, v446, v447) => { // Ok
            let mut v442: Rc<str> = v442.clone();
            let mut v443: i32 = v443.clone();
            let mut v444: i32 = v444.clone();
            let mut v445: i32 = v445.clone();
            let mut v446: i32 = v446.clone();
            let mut v447: i32 = v447.clone();
            let mut v448: bool = v443 >= v447;
            let (mut v460, mut v461, mut v462, mut v463, mut v464): (i32, i32, i32, i32, i32) = if v448 {
                (v443, v444, v445, v446, v447)
            } else {
                let mut v449: i32 = method109(v0.clone(), v1, v443);
                let mut v450: bool = v449 > v447;
                let mut v451: i32 = if v450 {
                    v447
                } else {
                    v449
                };
                let mut v452: i32 = v451 - v443;
                let mut v453: bool = v452 == 0i32;
                if v453 {
                    (v443, v444, v445, v446, v447)
                } else {
                    let mut v454: i32 = v446 + v452;
                    (v451, v444, v445, v454, v447)
                }
            };
            let mut v465: bool = v460 == v443;
            let mut v466: bool = v465 != true;
            let mut v470: US12 = if v466 {
                US12::US12_0(v460, v461, v462, v463, v464)
            } else {
                let mut v468: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure30();
                US12::US12_1(v468.clone(), v443, v444, v445, v446, v447)
            };
            let mut v508: US11 = match &v470 {
                US12::US12_1(v500, v501, v502, v503, v504, v505) => { // Error
                    let mut v500: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v500.clone();
                    let mut v501: i32 = v501.clone();
                    let mut v502: i32 = v502.clone();
                    let mut v503: i32 = v503.clone();
                    let mut v504: i32 = v504.clone();
                    let mut v505: i32 = v505.clone();
                    US11::US11_1(v500.clone(), v501, v502, v503, v504, v505)
                }
                US12::US12_0(v471, v472, v473, v474, v475) => { // Ok
                    let mut v471: i32 = v471.clone();
                    let mut v472: i32 = v472.clone();
                    let mut v473: i32 = v473.clone();
                    let mut v474: i32 = v474.clone();
                    let mut v475: i32 = v475.clone();
                    let mut v476: bool = v471 >= v475;
                    let (mut v488, mut v489, mut v490, mut v491, mut v492): (i32, i32, i32, i32, i32) = if v476 {
                        (v471, v472, v473, v474, v475)
                    } else {
                        let mut v477: i32 = method89(v0.clone(), v1, v471);
                        let mut v478: bool = v477 > v475;
                        let mut v479: i32 = if v478 {
                            v475
                        } else {
                            v477
                        };
                        let mut v480: i32 = v479 - v471;
                        let mut v481: bool = v480 == 0i32;
                        if v481 {
                            (v471, v472, v473, v474, v475)
                        } else {
                            let mut v482: i32 = v474 + v480;
                            (v479, v472, v473, v482, v475)
                        }
                    };
                    let mut v493: bool = v471 >= v488;
                    let mut v498: Rc<str> = if v493 {
                        let mut v494: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v494.clone()
                    } else {
                        let mut v495: bool = v471 == v488;
                        let mut v496: i32 = v488 - 1i32;
                        let mut v497: Rc<str> = string_slice(&v0.clone(), v471 as i64, v496 as i64);
                        v497.clone()
                    };
                    US11::US11_0(v498.clone(), v488, v489, v490, v491, v492)
                }
                _ => unreachable!(),
            };
            let mut v527: US15 = match &v508 {
                US11::US11_1(v518, v519, v520, v521, v522, v523) => { // Error
                    let mut v518: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v518.clone();
                    let mut v519: i32 = v519.clone();
                    let mut v520: i32 = v520.clone();
                    let mut v521: i32 = v521.clone();
                    let mut v522: i32 = v522.clone();
                    let mut v523: i32 = v523.clone();
                    let mut v524: US14 = US14::US14_1;
                    US15::US15_0(v524.clone(), v443, v444, v445, v446, v447)
                }
                US11::US11_0(v509, v510, v511, v512, v513, v514) => { // Ok
                    let mut v509: Rc<str> = v509.clone();
                    let mut v510: i32 = v510.clone();
                    let mut v511: i32 = v511.clone();
                    let mut v512: i32 = v512.clone();
                    let mut v513: i32 = v513.clone();
                    let mut v514: i32 = v514.clone();
                    let mut v515: Rc<dyn Fn() -> Rc<str>> = closure31(v509.clone());
                    let mut v516: US14 = US14::US14_0(v515.clone());
                    US15::US15_0(v516.clone(), v510, v511, v512, v513, v514)
                }
                _ => unreachable!(),
            };
            match &v527 {
                US15::US15_1(v537, v538, v539, v540, v541, v542) => { // Error
                    let mut v537: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v537.clone();
                    let mut v538: i32 = v538.clone();
                    let mut v539: i32 = v539.clone();
                    let mut v540: i32 = v540.clone();
                    let mut v541: i32 = v541.clone();
                    let mut v542: i32 = v542.clone();
                    US13::US13_1(v537.clone(), v538, v539, v540, v541, v542)
                }
                US15::US15_0(v528, v529, v530, v531, v532, v533) => { // Ok
                    let mut v528: US14 = v528.clone();
                    let mut v529: i32 = v529.clone();
                    let mut v530: i32 = v530.clone();
                    let mut v531: i32 = v531.clone();
                    let mut v532: i32 = v532.clone();
                    let mut v533: i32 = v533.clone();
                    let mut v534: Rc<dyn Fn() -> Rc<str>> = closure32(v442.clone());
                    let mut v535: Rc<dyn Fn() -> US14> = closure33(v528.clone());
                    US13::US13_0(v534.clone(), v535.clone(), v529, v530, v531, v532, v533)
                }
                _ => unreachable!(),
            }
        }
        _ => unreachable!(),
    };
    let mut v571: US16 = match &v547 {
        US13::US13_1(v562, v563, v564, v565, v566, v567) => { // Error
            let mut v562: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v562.clone();
            let mut v563: i32 = v563.clone();
            let mut v564: i32 = v564.clone();
            let mut v565: i32 = v565.clone();
            let mut v566: i32 = v566.clone();
            let mut v567: i32 = v567.clone();
            let mut v568: Rc<dyn Fn() -> Rc<str>> = closure34(v0.clone(), v562.clone(), v563, v564, v565, v566, v567);
            US16::US16_1(v568.clone())
        }
        US13::US13_0(v548, v549, v550, v551, v552, v553, v554) => { // Ok
            let mut v548: Rc<dyn Fn() -> Rc<str>> = v548.clone();
            let mut v549: Rc<dyn Fn() -> US14> = v549.clone();
            let mut v550: i32 = v550.clone();
            let mut v551: i32 = v551.clone();
            let mut v552: i32 = v552.clone();
            let mut v553: i32 = v553.clone();
            let mut v554: i32 = v554.clone();
            let mut v555: bool = v550 >= v554;
            let mut v560: Rc<str> = if v555 {
                let mut v556: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v556.clone()
            } else {
                let mut v557: bool = v550 == v554;
                let mut v558: i32 = v554 - 1i32;
                let mut v559: Rc<str> = string_slice(&v0.clone(), v550 as i64, v558 as i64);
                v559.clone()
            };
            US16::US16_0(v548.clone(), v549.clone(), v560.clone(), v551, v552, v553, v554)
        }
        _ => unreachable!(),
    };
    let mut v591: US17 = match &v571 {
        US16::US16_1(v588) => { // Error
            let mut v588: Rc<dyn Fn() -> Rc<str>> = v588.clone();
            US17::US17_1(v588.clone())
        }
        US16::US16_0(v572, v573, v574, v575, v576, v577, v578) => { // Ok
            let mut v572: Rc<dyn Fn() -> Rc<str>> = v572.clone();
            let mut v573: Rc<dyn Fn() -> US14> = v573.clone();
            let mut v574: Rc<str> = v574.clone();
            let mut v575: i32 = v575.clone();
            let mut v576: i32 = v576.clone();
            let mut v577: i32 = v577.clone();
            let mut v578: i32 = v578.clone();
            let mut v579: Rc<str> = v572();
            let mut v580: US14 = v573();
            let mut v586: US4 = match &v580 {
                US14::US14_1 => { // None
                    US4::US4_1
                }
                US14::US14_0(v581) => { // Some
                    let mut v581: Rc<dyn Fn() -> Rc<str>> = v581.clone();
                    let mut v582: Rc<str> = v581();
                    US4::US4_0(v582.clone())
                }
                _ => unreachable!(),
            };
            US17::US17_0(v579.clone(), v586.clone())
        }
        _ => unreachable!(),
    };
    match &v591 {
        US17::US17_1(v595) => { // Error
            let mut v595: Rc<dyn Fn() -> Rc<str>> = v595.clone();
            let mut v596: Rc<str> = v595();
            US9::US9_1(v596.clone())
        }
        US17::US17_0(v592, v593) => { // Ok
            let mut v592: Rc<str> = v592.clone();
            let mut v593: US4 = v593.clone();
            US9::US9_0(v592.clone(), v593.clone())
        }
        _ => unreachable!(),
    }
}
fn closure35() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = b'\\';
        let mut v7: Rc<str> = method81(v6, v2, v3, v4, v5);
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = Rc::<str>::from(format!("{}{}", v8, v7));
        v9.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure36() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method89(v0.clone(), v6, v1);
        let mut v8: i32 = v1 + 80i32;
        let mut v9: bool = v7 < v8;
        let mut v10: i32 = if v9 {
            v7
        } else {
            v8
        };
        let mut v11: bool = v2 >= v10;
        let mut v16: Rc<str> = if v11 {
            let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v12.clone()
        } else {
            let mut v13: bool = v2 == v10;
            let mut v14: i32 = v10 - 1i32;
            let mut v15: Rc<str> = string_slice(&v0.clone(), v2 as i64, v14 as i64);
            v15.clone()
        };
        let mut v17: i32 = (v16.clone().len() as i32);
        let mut v18: bool = v17 > 0i32;
        let mut v22: bool = if v18 {
            let mut v19: i32 = v17 - 1i32;
            let mut v20: u8 = v16.clone().as_bytes()[v19 as usize];
            let mut v21: bool = v20 == b'\n';
            v21
        } else {
            false
        };
        let mut v25: Rc<str> = if v22 {
            let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v23.clone()
        } else {
            let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            v24.clone()
        };
        let mut v26: i32 = v4 - 1i32;
        let mut v27: i32 = 0i32;
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method90(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: u8 = b'\\';
        let mut v34: Rc<str> = method91(v33, v3, v4);
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / "); } LIT.with(|lit| lit.clone()) };
        let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v34));
        let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v37));
        let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v16));
        let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v32));
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v37));
        v42.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure37() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = b'`';
        let mut v7: Rc<str> = method81(v6, v2, v3, v4, v5);
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = Rc::<str>::from(format!("{}{}", v8, v7));
        v9.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure38() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: i32 = (v0.clone().len() as i32);
        let mut v7: i32 = method89(v0.clone(), v6, v1);
        let mut v8: i32 = v1 + 80i32;
        let mut v9: bool = v7 < v8;
        let mut v10: i32 = if v9 {
            v7
        } else {
            v8
        };
        let mut v11: bool = v2 >= v10;
        let mut v16: Rc<str> = if v11 {
            let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v12.clone()
        } else {
            let mut v13: bool = v2 == v10;
            let mut v14: i32 = v10 - 1i32;
            let mut v15: Rc<str> = string_slice(&v0.clone(), v2 as i64, v14 as i64);
            v15.clone()
        };
        let mut v17: i32 = (v16.clone().len() as i32);
        let mut v18: bool = v17 > 0i32;
        let mut v22: bool = if v18 {
            let mut v19: i32 = v17 - 1i32;
            let mut v20: u8 = v16.clone().as_bytes()[v19 as usize];
            let mut v21: bool = v20 == b'\n';
            v21
        } else {
            false
        };
        let mut v25: Rc<str> = if v22 {
            let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v23.clone()
        } else {
            let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            v24.clone()
        };
        let mut v26: i32 = v4 - 1i32;
        let mut v27: i32 = 0i32;
        let mut v28: Rc<dyn Fn(Rc<str>) -> Rc<str>> = method90(v26, v27);
        let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v30: Rc<str> = v28(v29.clone());
        let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("^"); } LIT.with(|lit| lit.clone()) };
        let mut v32: Rc<str> = Rc::<str>::from(format!("{}{}", v30, v31));
        let mut v33: u8 = b'`';
        let mut v34: Rc<str> = method91(v33, v3, v4);
        let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.p_char / "); } LIT.with(|lit| lit.clone()) };
        let mut v36: Rc<str> = Rc::<str>::from(format!("{}{}", v35, v34));
        let mut v37: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
        let mut v38: Rc<str> = Rc::<str>::from(format!("{}{}", v36, v37));
        let mut v39: Rc<str> = Rc::<str>::from(format!("{}{}", v38, v16));
        let mut v40: Rc<str> = Rc::<str>::from(format!("{}{}", v39, v25));
        let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v40, v32));
        let mut v42: Rc<str> = Rc::<str>::from(format!("{}{}", v41, v37));
        v42.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method112(mut v0: i32, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: Rc<str>, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32, mut v9: i32) -> (i32, i32, i32, i32, i32) {
    loop {
        let mut v10: bool = v5 >= v3;
        if v10 {
            return (v5, v6, v7, v8, v9);
        } else {
            let mut v11: u8 = v4.clone().as_bytes()[v5 as usize];
            let mut v12: bool = v11 == b'\\';
            let mut v16: bool = if v12 {
                true
            } else {
                let mut v13: bool = v11 == b'`';
                if v13 {
                    true
                } else {
                    let mut v14: bool = v11 == b'"';
                    v14
                }
            };
            let mut v17: bool = v16 == false;
            if v17 {
                let mut v18: i32 = v5 + 1i32;
                let mut v19: bool = b'\n' == v11;
                let (mut v23, mut v24, mut v25, mut v26): (i32, i32, i32, i32) = if v19 {
                    let mut v20: i32 = v6 + v8;
                    let mut v21: i32 = v7 + 1i32;
                    (v20, v21, 1i32, v9)
                } else {
                    let mut v22: i32 = v8 + 1i32;
                    (v6, v7, v22, v9)
                };
                (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0, v1, v2, v3, v4.clone(), v18, v23, v24, v25, v26);
                continue;
            } else {
                return (v5, v6, v7, v8, v9);
            }
        }
    }
}
fn method111(mut v0: i32, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: Rc<str>, mut v5: i32) -> (i32, i32, i32, i32, i32) {
    let mut v6: bool = v5 >= v3;
    if v6 {
        (v5, v0, v1, v2, v3)
    } else {
        let mut v7: u8 = v4.clone().as_bytes()[v5 as usize];
        let mut v8: bool = v7 == b'\\';
        let mut v12: bool = if v8 {
            true
        } else {
            let mut v9: bool = v7 == b'`';
            if v9 {
                true
            } else {
                let mut v10: bool = v7 == b'"';
                v10
            }
        };
        let mut v13: bool = v12 == false;
        if v13 {
            let mut v14: i32 = v5 + 1i32;
            let mut v15: bool = b'\n' == v7;
            let (mut v19, mut v20, mut v21, mut v22): (i32, i32, i32, i32) = if v15 {
                let mut v16: i32 = v0 + v2;
                let mut v17: i32 = v1 + 1i32;
                (v16, v17, 1i32, v3)
            } else {
                let mut v18: i32 = v2 + 1i32;
                (v0, v1, v18, v3)
            };
            method112(v0, v1, v2, v3, v4.clone(), v14, v19, v20, v21, v22)
        } else {
            (v5, v0, v1, v2, v3)
        }
    }
}
fn method114(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("i"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method113(mut v0: i32, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32) -> Rc<str> {
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v6: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v5.clone() }));
    method13(v6.clone());
    method114(v6.clone());
    method15(v6.clone());
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v6.clone(), v7.clone());
    method41(v6.clone());
    method96(v6.clone());
    method15(v6.clone());
    let mut v9: std::string::String = format!("{:#?}", (v1, v2, v3, v4));
    let mut v11: Rc<str> = Rc::<str>::from(v9);
    method6(v6.clone(), v11.clone());
    method16(v6.clone());
    let mut v12: Rc<str> = v6.borrow().l0.clone();
    v12.clone()
}
fn closure39() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = method113(v1, v2, v3, v4, v5);
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many1_satisfy / no matching char / "); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = Rc::<str>::from(format!("{}{}", v9, v6));
        v10.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure40() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v18: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v18.borrow_mut().push(b'"');
        let mut v19: Rc<Vec<u8>> = Rc::new(v18.borrow().clone());
        let mut v20: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v19).as_ref().clone()));
        let mut v21: Rc<str> = method93(v20.clone());
        let mut v22: Rc<str> = method94(v21.clone(), v2, v3, v4, v5);
        let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v24: Rc<str> = Rc::<str>::from(format!("{}{}", v23, v22));
        v24.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure41() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'"');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method93(v9.clone());
        let mut v11: Rc<str> = method97(v6, v10.clone(), v2, v3, v4, v5);
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v11));
        v13.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure42() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many_strings / first inner parser consumed no text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure43() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many_strings / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method115(mut v0: Rc<str>, mut v1: Rc<RefCell<std::string::String>>, mut v2: Rc<str>, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32) -> US11 {
    loop {
        let (mut v9, mut v10, mut v11, mut v12, mut v13): (i32, i32, i32, i32, i32) = method111(v5, v6, v7, v8, v0.clone(), v4);
        let mut v14: bool = v9 > v4;
        let mut v24: US11 = if v14 {
            let mut v15: bool = v4 >= v9;
            let mut v20: Rc<str> = if v15 {
                let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v16.clone()
            } else {
                let mut v17: bool = v4 == v9;
                let mut v18: i32 = v9 - 1i32;
                let mut v19: Rc<str> = string_slice(&v0.clone(), v4 as i64, v18 as i64);
                v19.clone()
            };
            US11::US11_0(v20.clone(), v9, v10, v11, v12, v13)
        } else {
            let mut v22: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
            US11::US11_1(v22.clone(), v4, v5, v6, v7, v8)
        };
        let mut v219: US11 = match &v24 {
            US11::US11_1(v31, v32, v33, v34, v35, v36) => { // Error
                let mut v31: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v31.clone();
                let mut v32: i32 = v32.clone();
                let mut v33: i32 = v33.clone();
                let mut v34: i32 = v34.clone();
                let mut v35: i32 = v35.clone();
                let mut v36: i32 = v36.clone();
                let mut v37: bool = v4 >= v8;
                let mut v55: US10 = if v37 {
                    let mut v38: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                    US10::US10_1(v38.clone(), v4, v5, v6, v7, v8)
                } else {
                    let mut v40: u8 = v0.clone().as_bytes()[v4 as usize];
                    let mut v41: bool = v40 == b'\\';
                    if v41 {
                        let mut v42: i32 = v4 + 1i32;
                        let mut v43: bool = b'\n' == v40;
                        let (mut v47, mut v48, mut v49, mut v50): (i32, i32, i32, i32) = if v43 {
                            let mut v44: i32 = v5 + v7;
                            let mut v45: i32 = v6 + 1i32;
                            (v44, v45, 1i32, v8)
                        } else {
                            let mut v46: i32 = v7 + 1i32;
                            (v5, v6, v46, v8)
                        };
                        US10::US10_0(b'\\', v42, v47, v48, v49, v50)
                    } else {
                        let mut v52: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                        US10::US10_1(v52.clone(), v4, v5, v6, v7, v8)
                    }
                };
                let mut v90: US10 = match &v55 {
                    US10::US10_1(v82, v83, v84, v85, v86, v87) => { // Error
                        let mut v82: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v82.clone();
                        let mut v83: i32 = v83.clone();
                        let mut v84: i32 = v84.clone();
                        let mut v85: i32 = v85.clone();
                        let mut v86: i32 = v86.clone();
                        let mut v87: i32 = v87.clone();
                        US10::US10_1(v82.clone(), v83, v84, v85, v86, v87)
                    }
                    US10::US10_0(v56, v57, v58, v59, v60, v61) => { // Ok
                        let mut v56: u8 = v56.clone();
                        let mut v57: i32 = v57.clone();
                        let mut v58: i32 = v58.clone();
                        let mut v59: i32 = v59.clone();
                        let mut v60: i32 = v60.clone();
                        let mut v61: i32 = v61.clone();
                        let mut v62: bool = v57 >= v61;
                        if v62 {
                            let mut v63: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                            US10::US10_1(v63.clone(), v57, v58, v59, v60, v61)
                        } else {
                            let mut v65: u8 = v0.clone().as_bytes()[v57 as usize];
                            let mut v66: bool = v65 == b'"';
                            let mut v67: bool = v66 == false;
                            if v67 {
                                let mut v68: i32 = v57 + 1i32;
                                let mut v69: bool = b'\n' == v65;
                                let (mut v73, mut v74, mut v75, mut v76): (i32, i32, i32, i32) = if v69 {
                                    let mut v70: i32 = v58 + v60;
                                    let mut v71: i32 = v59 + 1i32;
                                    (v70, v71, 1i32, v61)
                                } else {
                                    let mut v72: i32 = v60 + 1i32;
                                    (v58, v59, v72, v61)
                                };
                                US10::US10_0(v65, v68, v73, v74, v75, v76)
                            } else {
                                let mut v78: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                US10::US10_1(v78.clone(), v57, v58, v59, v60, v61)
                            }
                        }
                    }
                    _ => unreachable!(),
                };
                let mut v112: US11 = match &v90 {
                    US10::US10_1(v104, v105, v106, v107, v108, v109) => { // Error
                        let mut v104: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v104.clone();
                        let mut v105: i32 = v105.clone();
                        let mut v106: i32 = v106.clone();
                        let mut v107: i32 = v107.clone();
                        let mut v108: i32 = v108.clone();
                        let mut v109: i32 = v109.clone();
                        US11::US11_1(v104.clone(), v105, v106, v107, v108, v109)
                    }
                    US10::US10_0(v91, v92, v93, v94, v95, v96) => { // Ok
                        let mut v91: u8 = v91.clone();
                        let mut v92: i32 = v92.clone();
                        let mut v93: i32 = v93.clone();
                        let mut v94: i32 = v94.clone();
                        let mut v95: i32 = v95.clone();
                        let mut v96: i32 = v96.clone();
                        let mut v97: bool = v4 >= v92;
                        let mut v102: Rc<str> = if v97 {
                            let mut v98: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v98.clone()
                        } else {
                            let mut v99: bool = v4 == v92;
                            let mut v100: i32 = v92 - 1i32;
                            let mut v101: Rc<str> = string_slice(&v0.clone(), v4 as i64, v100 as i64);
                            v101.clone()
                        };
                        US11::US11_0(v102.clone(), v92, v93, v94, v95, v96)
                    }
                    _ => unreachable!(),
                };
                match &v112 {
                    US11::US11_1(v119, v120, v121, v122, v123, v124) => { // Error
                        let mut v119: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v119.clone();
                        let mut v120: i32 = v120.clone();
                        let mut v121: i32 = v121.clone();
                        let mut v122: i32 = v122.clone();
                        let mut v123: i32 = v123.clone();
                        let mut v124: i32 = v124.clone();
                        let mut v142: US10 = if v37 {
                            let mut v125: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                            US10::US10_1(v125.clone(), v4, v5, v6, v7, v8)
                        } else {
                            let mut v127: u8 = v0.clone().as_bytes()[v4 as usize];
                            let mut v128: bool = v127 == b'`';
                            if v128 {
                                let mut v129: i32 = v4 + 1i32;
                                let mut v130: bool = b'\n' == v127;
                                let (mut v134, mut v135, mut v136, mut v137): (i32, i32, i32, i32) = if v130 {
                                    let mut v131: i32 = v5 + v7;
                                    let mut v132: i32 = v6 + 1i32;
                                    (v131, v132, 1i32, v8)
                                } else {
                                    let mut v133: i32 = v7 + 1i32;
                                    (v5, v6, v133, v8)
                                };
                                US10::US10_0(b'`', v129, v134, v135, v136, v137)
                            } else {
                                let mut v139: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                US10::US10_1(v139.clone(), v4, v5, v6, v7, v8)
                            }
                        };
                        let mut v177: US10 = match &v142 {
                            US10::US10_1(v169, v170, v171, v172, v173, v174) => { // Error
                                let mut v169: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v169.clone();
                                let mut v170: i32 = v170.clone();
                                let mut v171: i32 = v171.clone();
                                let mut v172: i32 = v172.clone();
                                let mut v173: i32 = v173.clone();
                                let mut v174: i32 = v174.clone();
                                US10::US10_1(v169.clone(), v170, v171, v172, v173, v174)
                            }
                            US10::US10_0(v143, v144, v145, v146, v147, v148) => { // Ok
                                let mut v143: u8 = v143.clone();
                                let mut v144: i32 = v144.clone();
                                let mut v145: i32 = v145.clone();
                                let mut v146: i32 = v146.clone();
                                let mut v147: i32 = v147.clone();
                                let mut v148: i32 = v148.clone();
                                let mut v149: bool = v144 >= v148;
                                if v149 {
                                    let mut v150: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                    US10::US10_1(v150.clone(), v144, v145, v146, v147, v148)
                                } else {
                                    let mut v152: u8 = v0.clone().as_bytes()[v144 as usize];
                                    let mut v153: bool = v152 == b'"';
                                    let mut v154: bool = v153 == false;
                                    if v154 {
                                        let mut v155: i32 = v144 + 1i32;
                                        let mut v156: bool = b'\n' == v152;
                                        let (mut v160, mut v161, mut v162, mut v163): (i32, i32, i32, i32) = if v156 {
                                            let mut v157: i32 = v145 + v147;
                                            let mut v158: i32 = v146 + 1i32;
                                            (v157, v158, 1i32, v148)
                                        } else {
                                            let mut v159: i32 = v147 + 1i32;
                                            (v145, v146, v159, v148)
                                        };
                                        US10::US10_0(v152, v155, v160, v161, v162, v163)
                                    } else {
                                        let mut v165: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                        US10::US10_1(v165.clone(), v144, v145, v146, v147, v148)
                                    }
                                }
                            }
                            _ => unreachable!(),
                        };
                        let mut v199: US11 = match &v177 {
                            US10::US10_1(v191, v192, v193, v194, v195, v196) => { // Error
                                let mut v191: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v191.clone();
                                let mut v192: i32 = v192.clone();
                                let mut v193: i32 = v193.clone();
                                let mut v194: i32 = v194.clone();
                                let mut v195: i32 = v195.clone();
                                let mut v196: i32 = v196.clone();
                                US11::US11_1(v191.clone(), v192, v193, v194, v195, v196)
                            }
                            US10::US10_0(v178, v179, v180, v181, v182, v183) => { // Ok
                                let mut v178: u8 = v178.clone();
                                let mut v179: i32 = v179.clone();
                                let mut v180: i32 = v180.clone();
                                let mut v181: i32 = v181.clone();
                                let mut v182: i32 = v182.clone();
                                let mut v183: i32 = v183.clone();
                                let mut v184: bool = v4 >= v179;
                                let mut v189: Rc<str> = if v184 {
                                    let mut v185: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v185.clone()
                                } else {
                                    let mut v186: bool = v4 == v179;
                                    let mut v187: i32 = v179 - 1i32;
                                    let mut v188: Rc<str> = string_slice(&v0.clone(), v4 as i64, v187 as i64);
                                    v188.clone()
                                };
                                US11::US11_0(v189.clone(), v179, v180, v181, v182, v183)
                            }
                            _ => unreachable!(),
                        };
                        match &v199 {
                            US11::US11_1(v206, v207, v208, v209, v210, v211) => { // Error
                                let mut v206: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v206.clone();
                                let mut v207: i32 = v207.clone();
                                let mut v208: i32 = v208.clone();
                                let mut v209: i32 = v209.clone();
                                let mut v210: i32 = v210.clone();
                                let mut v211: i32 = v211.clone();
                                let mut v212: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                US11::US11_1(v212.clone(), v4, v5, v6, v7, v8)
                            }
                            US11::US11_0(v200, v201, v202, v203, v204, v205) => { // Ok
                                let mut v200: Rc<str> = v200.clone();
                                let mut v201: i32 = v201.clone();
                                let mut v202: i32 = v202.clone();
                                let mut v203: i32 = v203.clone();
                                let mut v204: i32 = v204.clone();
                                let mut v205: i32 = v205.clone();
                                v199.clone()
                            }
                            _ => unreachable!(),
                        }
                    }
                    US11::US11_0(v113, v114, v115, v116, v117, v118) => { // Ok
                        let mut v113: Rc<str> = v113.clone();
                        let mut v114: i32 = v114.clone();
                        let mut v115: i32 = v115.clone();
                        let mut v116: i32 = v116.clone();
                        let mut v117: i32 = v117.clone();
                        let mut v118: i32 = v118.clone();
                        v112.clone()
                    }
                    _ => unreachable!(),
                }
            }
            US11::US11_0(v25, v26, v27, v28, v29, v30) => { // Ok
                let mut v25: Rc<str> = v25.clone();
                let mut v26: i32 = v26.clone();
                let mut v27: i32 = v27.clone();
                let mut v28: i32 = v28.clone();
                let mut v29: i32 = v29.clone();
                let mut v30: i32 = v30.clone();
                v24.clone()
            }
            _ => unreachable!(),
        };
        match &v219 {
            US11::US11_1(v220, v221, v222, v223, v224, v225) => { // Error
                let mut v220: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v220.clone();
                let mut v221: i32 = v221.clone();
                let mut v222: i32 = v222.clone();
                let mut v223: i32 = v223.clone();
                let mut v224: i32 = v224.clone();
                let mut v225: i32 = v225.clone();
                let mut v226: bool = v3 == 0i32;
                let mut v228: Rc<str> = if v226 {
                    v2.clone()
                } else {
                    let mut v227: Rc<str> = Rc::<str>::from(v1.borrow().as_str());
                    v227.clone()
                };
                return US11::US11_0(v228.clone(), v4, v5, v6, v7, v8);
            }
            US11::US11_0(v230, v231, v232, v233, v234, v235) => { // Ok
                let mut v230: Rc<str> = v230.clone();
                let mut v231: i32 = v231.clone();
                let mut v232: i32 = v232.clone();
                let mut v233: i32 = v233.clone();
                let mut v234: i32 = v234.clone();
                let mut v235: i32 = v235.clone();
                let mut v236: bool = v231 > v4;
                if v236 {
                    let mut v237: bool = v3 == 0i32;
                    if v237 {
                        v1.borrow_mut().push_str(&*v2);
                        ()
                    };
                    v1.borrow_mut().push_str(&*v230);
                    let mut v238: i32 = v3 + 1i32;
                    (v0, v1, v2, v3, v4, v5, v6, v7, v8) = (v0.clone(), v1.clone(), v2.clone(), v238, v231, v232, v233, v234, v235);
                    continue;
                } else {
                    let mut v240: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                    return US11::US11_1(v240.clone(), v4, v5, v6, v7, v8);
                }
            }
            _ => unreachable!(),
        }
    }
}
fn method116(mut v0: i32, mut v1: i32, mut v2: i32, mut v3: i32) -> Rc<str> {
    let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v5: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v4.clone() }));
    method13(v5.clone());
    method96(v5.clone());
    method15(v5.clone());
    let mut v7: std::string::String = format!("{:#?}", (v0, v1, v2, v3));
    let mut v9: Rc<str> = Rc::<str>::from(v7);
    method6(v5.clone(), v9.clone());
    method16(v5.clone());
    let mut v10: Rc<str> = v5.borrow().l0.clone();
    v10.clone()
}
fn closure44() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = method116(v2, v3, v4, v5);
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.any_char / unexpected end of t / "); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = Rc::<str>::from(format!("{}{}", v9, v6));
        v10.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method117(mut v0: Rc<str>, mut v1: Rc<RefCell<std::string::String>>, mut v2: Rc<str>, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32) -> US11 {
    loop {
        let (mut v9, mut v10, mut v11, mut v12, mut v13): (i32, i32, i32, i32, i32) = method111(v5, v6, v7, v8, v0.clone(), v4);
        let mut v14: bool = v9 > v4;
        let mut v24: US11 = if v14 {
            let mut v15: bool = v4 >= v9;
            let mut v20: Rc<str> = if v15 {
                let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v16.clone()
            } else {
                let mut v17: bool = v4 == v9;
                let mut v18: i32 = v9 - 1i32;
                let mut v19: Rc<str> = string_slice(&v0.clone(), v4 as i64, v18 as i64);
                v19.clone()
            };
            US11::US11_0(v20.clone(), v9, v10, v11, v12, v13)
        } else {
            let mut v22: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
            US11::US11_1(v22.clone(), v4, v5, v6, v7, v8)
        };
        let mut v209: US11 = match &v24 {
            US11::US11_1(v31, v32, v33, v34, v35, v36) => { // Error
                let mut v31: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v31.clone();
                let mut v32: i32 = v32.clone();
                let mut v33: i32 = v33.clone();
                let mut v34: i32 = v34.clone();
                let mut v35: i32 = v35.clone();
                let mut v36: i32 = v36.clone();
                let mut v37: bool = v4 >= v8;
                let mut v55: US10 = if v37 {
                    let mut v38: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                    US10::US10_1(v38.clone(), v4, v5, v6, v7, v8)
                } else {
                    let mut v40: u8 = v0.clone().as_bytes()[v4 as usize];
                    let mut v41: bool = v40 == b'\\';
                    if v41 {
                        let mut v42: i32 = v4 + 1i32;
                        let mut v43: bool = b'\n' == v40;
                        let (mut v47, mut v48, mut v49, mut v50): (i32, i32, i32, i32) = if v43 {
                            let mut v44: i32 = v5 + v7;
                            let mut v45: i32 = v6 + 1i32;
                            (v44, v45, 1i32, v8)
                        } else {
                            let mut v46: i32 = v7 + 1i32;
                            (v5, v6, v46, v8)
                        };
                        US10::US10_0(b'\\', v42, v47, v48, v49, v50)
                    } else {
                        let mut v52: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                        US10::US10_1(v52.clone(), v4, v5, v6, v7, v8)
                    }
                };
                let mut v85: US10 = match &v55 {
                    US10::US10_1(v77, v78, v79, v80, v81, v82) => { // Error
                        let mut v77: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v77.clone();
                        let mut v78: i32 = v78.clone();
                        let mut v79: i32 = v79.clone();
                        let mut v80: i32 = v80.clone();
                        let mut v81: i32 = v81.clone();
                        let mut v82: i32 = v82.clone();
                        US10::US10_1(v77.clone(), v78, v79, v80, v81, v82)
                    }
                    US10::US10_0(v56, v57, v58, v59, v60, v61) => { // Ok
                        let mut v56: u8 = v56.clone();
                        let mut v57: i32 = v57.clone();
                        let mut v58: i32 = v58.clone();
                        let mut v59: i32 = v59.clone();
                        let mut v60: i32 = v60.clone();
                        let mut v61: i32 = v61.clone();
                        let mut v62: bool = v57 >= v61;
                        if v62 {
                            let mut v63: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                            US10::US10_1(v63.clone(), v57, v58, v59, v60, v61)
                        } else {
                            let mut v65: u8 = v0.clone().as_bytes()[v57 as usize];
                            let mut v66: i32 = v57 + 1i32;
                            let mut v67: bool = b'\n' == v65;
                            let (mut v71, mut v72, mut v73, mut v74): (i32, i32, i32, i32) = if v67 {
                                let mut v68: i32 = v58 + v60;
                                let mut v69: i32 = v59 + 1i32;
                                (v68, v69, 1i32, v61)
                            } else {
                                let mut v70: i32 = v60 + 1i32;
                                (v58, v59, v70, v61)
                            };
                            US10::US10_0(v65, v66, v71, v72, v73, v74)
                        }
                    }
                    _ => unreachable!(),
                };
                let mut v107: US11 = match &v85 {
                    US10::US10_1(v99, v100, v101, v102, v103, v104) => { // Error
                        let mut v99: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v99.clone();
                        let mut v100: i32 = v100.clone();
                        let mut v101: i32 = v101.clone();
                        let mut v102: i32 = v102.clone();
                        let mut v103: i32 = v103.clone();
                        let mut v104: i32 = v104.clone();
                        US11::US11_1(v99.clone(), v100, v101, v102, v103, v104)
                    }
                    US10::US10_0(v86, v87, v88, v89, v90, v91) => { // Ok
                        let mut v86: u8 = v86.clone();
                        let mut v87: i32 = v87.clone();
                        let mut v88: i32 = v88.clone();
                        let mut v89: i32 = v89.clone();
                        let mut v90: i32 = v90.clone();
                        let mut v91: i32 = v91.clone();
                        let mut v92: bool = v4 >= v87;
                        let mut v97: Rc<str> = if v92 {
                            let mut v93: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v93.clone()
                        } else {
                            let mut v94: bool = v4 == v87;
                            let mut v95: i32 = v87 - 1i32;
                            let mut v96: Rc<str> = string_slice(&v0.clone(), v4 as i64, v95 as i64);
                            v96.clone()
                        };
                        US11::US11_0(v97.clone(), v87, v88, v89, v90, v91)
                    }
                    _ => unreachable!(),
                };
                match &v107 {
                    US11::US11_1(v114, v115, v116, v117, v118, v119) => { // Error
                        let mut v114: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v114.clone();
                        let mut v115: i32 = v115.clone();
                        let mut v116: i32 = v116.clone();
                        let mut v117: i32 = v117.clone();
                        let mut v118: i32 = v118.clone();
                        let mut v119: i32 = v119.clone();
                        let mut v137: US10 = if v37 {
                            let mut v120: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                            US10::US10_1(v120.clone(), v4, v5, v6, v7, v8)
                        } else {
                            let mut v122: u8 = v0.clone().as_bytes()[v4 as usize];
                            let mut v123: bool = v122 == b'`';
                            if v123 {
                                let mut v124: i32 = v4 + 1i32;
                                let mut v125: bool = b'\n' == v122;
                                let (mut v129, mut v130, mut v131, mut v132): (i32, i32, i32, i32) = if v125 {
                                    let mut v126: i32 = v5 + v7;
                                    let mut v127: i32 = v6 + 1i32;
                                    (v126, v127, 1i32, v8)
                                } else {
                                    let mut v128: i32 = v7 + 1i32;
                                    (v5, v6, v128, v8)
                                };
                                US10::US10_0(b'`', v124, v129, v130, v131, v132)
                            } else {
                                let mut v134: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                US10::US10_1(v134.clone(), v4, v5, v6, v7, v8)
                            }
                        };
                        let mut v167: US10 = match &v137 {
                            US10::US10_1(v159, v160, v161, v162, v163, v164) => { // Error
                                let mut v159: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v159.clone();
                                let mut v160: i32 = v160.clone();
                                let mut v161: i32 = v161.clone();
                                let mut v162: i32 = v162.clone();
                                let mut v163: i32 = v163.clone();
                                let mut v164: i32 = v164.clone();
                                US10::US10_1(v159.clone(), v160, v161, v162, v163, v164)
                            }
                            US10::US10_0(v138, v139, v140, v141, v142, v143) => { // Ok
                                let mut v138: u8 = v138.clone();
                                let mut v139: i32 = v139.clone();
                                let mut v140: i32 = v140.clone();
                                let mut v141: i32 = v141.clone();
                                let mut v142: i32 = v142.clone();
                                let mut v143: i32 = v143.clone();
                                let mut v144: bool = v139 >= v143;
                                if v144 {
                                    let mut v145: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                    US10::US10_1(v145.clone(), v139, v140, v141, v142, v143)
                                } else {
                                    let mut v147: u8 = v0.clone().as_bytes()[v139 as usize];
                                    let mut v148: i32 = v139 + 1i32;
                                    let mut v149: bool = b'\n' == v147;
                                    let (mut v153, mut v154, mut v155, mut v156): (i32, i32, i32, i32) = if v149 {
                                        let mut v150: i32 = v140 + v142;
                                        let mut v151: i32 = v141 + 1i32;
                                        (v150, v151, 1i32, v143)
                                    } else {
                                        let mut v152: i32 = v142 + 1i32;
                                        (v140, v141, v152, v143)
                                    };
                                    US10::US10_0(v147, v148, v153, v154, v155, v156)
                                }
                            }
                            _ => unreachable!(),
                        };
                        let mut v189: US11 = match &v167 {
                            US10::US10_1(v181, v182, v183, v184, v185, v186) => { // Error
                                let mut v181: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v181.clone();
                                let mut v182: i32 = v182.clone();
                                let mut v183: i32 = v183.clone();
                                let mut v184: i32 = v184.clone();
                                let mut v185: i32 = v185.clone();
                                let mut v186: i32 = v186.clone();
                                US11::US11_1(v181.clone(), v182, v183, v184, v185, v186)
                            }
                            US10::US10_0(v168, v169, v170, v171, v172, v173) => { // Ok
                                let mut v168: u8 = v168.clone();
                                let mut v169: i32 = v169.clone();
                                let mut v170: i32 = v170.clone();
                                let mut v171: i32 = v171.clone();
                                let mut v172: i32 = v172.clone();
                                let mut v173: i32 = v173.clone();
                                let mut v174: bool = v4 >= v169;
                                let mut v179: Rc<str> = if v174 {
                                    let mut v175: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v175.clone()
                                } else {
                                    let mut v176: bool = v4 == v169;
                                    let mut v177: i32 = v169 - 1i32;
                                    let mut v178: Rc<str> = string_slice(&v0.clone(), v4 as i64, v177 as i64);
                                    v178.clone()
                                };
                                US11::US11_0(v179.clone(), v169, v170, v171, v172, v173)
                            }
                            _ => unreachable!(),
                        };
                        match &v189 {
                            US11::US11_1(v196, v197, v198, v199, v200, v201) => { // Error
                                let mut v196: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v196.clone();
                                let mut v197: i32 = v197.clone();
                                let mut v198: i32 = v198.clone();
                                let mut v199: i32 = v199.clone();
                                let mut v200: i32 = v200.clone();
                                let mut v201: i32 = v201.clone();
                                let mut v202: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                US11::US11_1(v202.clone(), v4, v5, v6, v7, v8)
                            }
                            US11::US11_0(v190, v191, v192, v193, v194, v195) => { // Ok
                                let mut v190: Rc<str> = v190.clone();
                                let mut v191: i32 = v191.clone();
                                let mut v192: i32 = v192.clone();
                                let mut v193: i32 = v193.clone();
                                let mut v194: i32 = v194.clone();
                                let mut v195: i32 = v195.clone();
                                v189.clone()
                            }
                            _ => unreachable!(),
                        }
                    }
                    US11::US11_0(v108, v109, v110, v111, v112, v113) => { // Ok
                        let mut v108: Rc<str> = v108.clone();
                        let mut v109: i32 = v109.clone();
                        let mut v110: i32 = v110.clone();
                        let mut v111: i32 = v111.clone();
                        let mut v112: i32 = v112.clone();
                        let mut v113: i32 = v113.clone();
                        v107.clone()
                    }
                    _ => unreachable!(),
                }
            }
            US11::US11_0(v25, v26, v27, v28, v29, v30) => { // Ok
                let mut v25: Rc<str> = v25.clone();
                let mut v26: i32 = v26.clone();
                let mut v27: i32 = v27.clone();
                let mut v28: i32 = v28.clone();
                let mut v29: i32 = v29.clone();
                let mut v30: i32 = v30.clone();
                v24.clone()
            }
            _ => unreachable!(),
        };
        match &v209 {
            US11::US11_1(v210, v211, v212, v213, v214, v215) => { // Error
                let mut v210: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v210.clone();
                let mut v211: i32 = v211.clone();
                let mut v212: i32 = v212.clone();
                let mut v213: i32 = v213.clone();
                let mut v214: i32 = v214.clone();
                let mut v215: i32 = v215.clone();
                let mut v216: bool = v3 == 0i32;
                let mut v218: Rc<str> = if v216 {
                    v2.clone()
                } else {
                    let mut v217: Rc<str> = Rc::<str>::from(v1.borrow().as_str());
                    v217.clone()
                };
                return US11::US11_0(v218.clone(), v4, v5, v6, v7, v8);
            }
            US11::US11_0(v220, v221, v222, v223, v224, v225) => { // Ok
                let mut v220: Rc<str> = v220.clone();
                let mut v221: i32 = v221.clone();
                let mut v222: i32 = v222.clone();
                let mut v223: i32 = v223.clone();
                let mut v224: i32 = v224.clone();
                let mut v225: i32 = v225.clone();
                let mut v226: bool = v221 > v4;
                if v226 {
                    let mut v227: bool = v3 == 0i32;
                    if v227 {
                        v1.borrow_mut().push_str(&*v2);
                        ()
                    };
                    v1.borrow_mut().push_str(&*v220);
                    let mut v228: i32 = v3 + 1i32;
                    (v0, v1, v2, v3, v4, v5, v6, v7, v8) = (v0.clone(), v1.clone(), v2.clone(), v228, v221, v222, v223, v224, v225);
                    continue;
                } else {
                    let mut v230: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure43();
                    return US11::US11_1(v230.clone(), v4, v5, v6, v7, v8);
                }
            }
            _ => unreachable!(),
        }
    }
}
fn method119(mut v0: i32, mut v1: Rc<str>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> (i32, i32, i32, i32, i32) {
    loop {
        let mut v7: bool = v2 >= v0;
        if v7 {
            return (v2, v3, v4, v5, v6);
        } else {
            let mut v8: u8 = v1.clone().as_bytes()[v2 as usize];
            let mut v9: bool = v8 == b'\\';
            let mut v15: bool = if v9 {
                true
            } else {
                let mut v10: bool = v8 == b'`';
                if v10 {
                    true
                } else {
                    let mut v11: bool = v8 == b'"';
                    if v11 {
                        true
                    } else {
                        let mut v12: bool = v8 == b' ';
                        v12
                    }
                }
            };
            let mut v16: bool = v15 == false;
            if v16 {
                let mut v17: i32 = v2 + 1i32;
                let mut v18: bool = b'\n' == v8;
                let (mut v22, mut v23, mut v24, mut v25): (i32, i32, i32, i32) = if v18 {
                    let mut v19: i32 = v3 + v5;
                    let mut v20: i32 = v4 + 1i32;
                    (v19, v20, 1i32, v6)
                } else {
                    let mut v21: i32 = v5 + 1i32;
                    (v3, v4, v21, v6)
                };
                (v0, v1, v2, v3, v4, v5, v6) = (v0, v1.clone(), v17, v22, v23, v24, v25);
                continue;
            } else {
                return (v2, v3, v4, v5, v6);
            }
        }
    }
}
fn method118(mut v0: i32, mut v1: Rc<str>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32) -> (i32, i32, i32, i32, i32) {
    let mut v6: bool = v2 >= v0;
    if v6 {
        (v2, v3, v4, v5, v0)
    } else {
        let mut v7: u8 = v1.clone().as_bytes()[v2 as usize];
        let mut v8: bool = v7 == b'\\';
        let mut v14: bool = if v8 {
            true
        } else {
            let mut v9: bool = v7 == b'`';
            if v9 {
                true
            } else {
                let mut v10: bool = v7 == b'"';
                if v10 {
                    true
                } else {
                    let mut v11: bool = v7 == b' ';
                    v11
                }
            }
        };
        let mut v15: bool = v14 == false;
        if v15 {
            let mut v16: i32 = v2 + 1i32;
            let mut v17: bool = b'\n' == v7;
            let (mut v21, mut v22, mut v23, mut v24): (i32, i32, i32, i32) = if v17 {
                let mut v18: i32 = v3 + v5;
                let mut v19: i32 = v4 + 1i32;
                (v18, v19, 1i32, v0)
            } else {
                let mut v20: i32 = v5 + 1i32;
                (v3, v4, v20, v0)
            };
            method119(v0, v1.clone(), v16, v21, v22, v23, v24)
        } else {
            (v2, v3, v4, v5, v0)
        }
    }
}
fn closure45() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v28: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v28.borrow_mut().push(b'\\');
        v28.borrow_mut().push(b'`');
        v28.borrow_mut().push(b'"');
        let mut v29: Rc<Vec<u8>> = Rc::new(v28.borrow().clone());
        let mut v30: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v29).as_ref().clone()));
        let mut v31: Rc<str> = method93(v30.clone());
        let mut v32: Rc<str> = method94(v31.clone(), v2, v3, v4, v5);
        let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected end of text / "); } LIT.with(|lit| lit.clone()) };
        let mut v34: Rc<str> = Rc::<str>::from(format!("{}{}", v33, v32));
        v34.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure46() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: u8 = v0.clone().as_bytes()[v1 as usize];
        let mut v7: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(Vec::new()));
        v7.borrow_mut().push(b'\\');
        v7.borrow_mut().push(b'`');
        v7.borrow_mut().push(b'"');
        let mut v8: Rc<Vec<u8>> = Rc::new(v7.borrow().clone());
        let mut v9: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new((v8).as_ref().clone()));
        let mut v10: Rc<str> = method93(v9.clone());
        let mut v11: Rc<str> = method97(v6, v10.clone(), v2, v3, v4, v5);
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.none_of / unexpected char / "); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v11));
        v13.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method121(mut v0: Rc<UH0>, mut v1: Rc<UH0>) -> Rc<UH0> {
    loop {
        match &*v0 {
            UH0::UH0_1(v2, v3) => { // Cons
                let mut v2: Rc<str> = v2.clone();
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: Rc<UH0> = Rc::new(UH0::UH0_1(v2.clone(), v1.clone()));
                (v0, v1) = (v3.clone(), v4.clone());
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v1.clone();
            }
            _ => unreachable!(),
        }
    }
}
fn closure47() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method120(mut v0: Rc<str>, mut v1: Rc<UH0>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> US19 {
    loop {
        let mut v7: bool = v2 >= v6;
        let mut v25: US10 = if v7 {
            let mut v8: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
            US10::US10_1(v8.clone(), v2, v3, v4, v5, v6)
        } else {
            let mut v10: u8 = v0.clone().as_bytes()[v2 as usize];
            let mut v11: bool = v10 == b'\\';
            if v11 {
                let mut v12: i32 = v2 + 1i32;
                let mut v13: bool = b'\n' == v10;
                let (mut v17, mut v18, mut v19, mut v20): (i32, i32, i32, i32) = if v13 {
                    let mut v14: i32 = v3 + v5;
                    let mut v15: i32 = v4 + 1i32;
                    (v14, v15, 1i32, v6)
                } else {
                    let mut v16: i32 = v5 + 1i32;
                    (v3, v4, v16, v6)
                };
                US10::US10_0(b'\\', v12, v17, v18, v19, v20)
            } else {
                let mut v22: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                US10::US10_1(v22.clone(), v2, v3, v4, v5, v6)
            }
        };
        let mut v55: US10 = match &v25 {
            US10::US10_1(v47, v48, v49, v50, v51, v52) => { // Error
                let mut v47: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v47.clone();
                let mut v48: i32 = v48.clone();
                let mut v49: i32 = v49.clone();
                let mut v50: i32 = v50.clone();
                let mut v51: i32 = v51.clone();
                let mut v52: i32 = v52.clone();
                US10::US10_1(v47.clone(), v48, v49, v50, v51, v52)
            }
            US10::US10_0(v26, v27, v28, v29, v30, v31) => { // Ok
                let mut v26: u8 = v26.clone();
                let mut v27: i32 = v27.clone();
                let mut v28: i32 = v28.clone();
                let mut v29: i32 = v29.clone();
                let mut v30: i32 = v30.clone();
                let mut v31: i32 = v31.clone();
                let mut v32: bool = v27 >= v31;
                if v32 {
                    let mut v33: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                    US10::US10_1(v33.clone(), v27, v28, v29, v30, v31)
                } else {
                    let mut v35: u8 = v0.clone().as_bytes()[v27 as usize];
                    let mut v36: i32 = v27 + 1i32;
                    let mut v37: bool = b'\n' == v35;
                    let (mut v41, mut v42, mut v43, mut v44): (i32, i32, i32, i32) = if v37 {
                        let mut v38: i32 = v28 + v30;
                        let mut v39: i32 = v29 + 1i32;
                        (v38, v39, 1i32, v31)
                    } else {
                        let mut v40: i32 = v30 + 1i32;
                        (v28, v29, v40, v31)
                    };
                    US10::US10_0(v35, v36, v41, v42, v43, v44)
                }
            }
            _ => unreachable!(),
        };
        let mut v77: US11 = match &v55 {
            US10::US10_1(v69, v70, v71, v72, v73, v74) => { // Error
                let mut v69: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v69.clone();
                let mut v70: i32 = v70.clone();
                let mut v71: i32 = v71.clone();
                let mut v72: i32 = v72.clone();
                let mut v73: i32 = v73.clone();
                let mut v74: i32 = v74.clone();
                US11::US11_1(v69.clone(), v70, v71, v72, v73, v74)
            }
            US10::US10_0(v56, v57, v58, v59, v60, v61) => { // Ok
                let mut v56: u8 = v56.clone();
                let mut v57: i32 = v57.clone();
                let mut v58: i32 = v58.clone();
                let mut v59: i32 = v59.clone();
                let mut v60: i32 = v60.clone();
                let mut v61: i32 = v61.clone();
                let mut v62: bool = v2 >= v57;
                let mut v67: Rc<str> = if v62 {
                    let mut v63: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v63.clone()
                } else {
                    let mut v64: bool = v2 == v57;
                    let mut v65: i32 = v57 - 1i32;
                    let mut v66: Rc<str> = string_slice(&v0.clone(), v2 as i64, v65 as i64);
                    v66.clone()
                };
                US11::US11_0(v67.clone(), v57, v58, v59, v60, v61)
            }
            _ => unreachable!(),
        };
        let mut v177: US11 = match &v77 {
            US11::US11_1(v84, v85, v86, v87, v88, v89) => { // Error
                let mut v84: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v84.clone();
                let mut v85: i32 = v85.clone();
                let mut v86: i32 = v86.clone();
                let mut v87: i32 = v87.clone();
                let mut v88: i32 = v88.clone();
                let mut v89: i32 = v89.clone();
                let mut v107: US10 = if v7 {
                    let mut v90: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                    US10::US10_1(v90.clone(), v2, v3, v4, v5, v6)
                } else {
                    let mut v92: u8 = v0.clone().as_bytes()[v2 as usize];
                    let mut v93: bool = v92 == b'`';
                    if v93 {
                        let mut v94: i32 = v2 + 1i32;
                        let mut v95: bool = b'\n' == v92;
                        let (mut v99, mut v100, mut v101, mut v102): (i32, i32, i32, i32) = if v95 {
                            let mut v96: i32 = v3 + v5;
                            let mut v97: i32 = v4 + 1i32;
                            (v96, v97, 1i32, v6)
                        } else {
                            let mut v98: i32 = v5 + 1i32;
                            (v3, v4, v98, v6)
                        };
                        US10::US10_0(b'`', v94, v99, v100, v101, v102)
                    } else {
                        let mut v104: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                        US10::US10_1(v104.clone(), v2, v3, v4, v5, v6)
                    }
                };
                let mut v137: US10 = match &v107 {
                    US10::US10_1(v129, v130, v131, v132, v133, v134) => { // Error
                        let mut v129: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v129.clone();
                        let mut v130: i32 = v130.clone();
                        let mut v131: i32 = v131.clone();
                        let mut v132: i32 = v132.clone();
                        let mut v133: i32 = v133.clone();
                        let mut v134: i32 = v134.clone();
                        US10::US10_1(v129.clone(), v130, v131, v132, v133, v134)
                    }
                    US10::US10_0(v108, v109, v110, v111, v112, v113) => { // Ok
                        let mut v108: u8 = v108.clone();
                        let mut v109: i32 = v109.clone();
                        let mut v110: i32 = v110.clone();
                        let mut v111: i32 = v111.clone();
                        let mut v112: i32 = v112.clone();
                        let mut v113: i32 = v113.clone();
                        let mut v114: bool = v109 >= v113;
                        if v114 {
                            let mut v115: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                            US10::US10_1(v115.clone(), v109, v110, v111, v112, v113)
                        } else {
                            let mut v117: u8 = v0.clone().as_bytes()[v109 as usize];
                            let mut v118: i32 = v109 + 1i32;
                            let mut v119: bool = b'\n' == v117;
                            let (mut v123, mut v124, mut v125, mut v126): (i32, i32, i32, i32) = if v119 {
                                let mut v120: i32 = v110 + v112;
                                let mut v121: i32 = v111 + 1i32;
                                (v120, v121, 1i32, v113)
                            } else {
                                let mut v122: i32 = v112 + 1i32;
                                (v110, v111, v122, v113)
                            };
                            US10::US10_0(v117, v118, v123, v124, v125, v126)
                        }
                    }
                    _ => unreachable!(),
                };
                let mut v159: US11 = match &v137 {
                    US10::US10_1(v151, v152, v153, v154, v155, v156) => { // Error
                        let mut v151: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v151.clone();
                        let mut v152: i32 = v152.clone();
                        let mut v153: i32 = v153.clone();
                        let mut v154: i32 = v154.clone();
                        let mut v155: i32 = v155.clone();
                        let mut v156: i32 = v156.clone();
                        US11::US11_1(v151.clone(), v152, v153, v154, v155, v156)
                    }
                    US10::US10_0(v138, v139, v140, v141, v142, v143) => { // Ok
                        let mut v138: u8 = v138.clone();
                        let mut v139: i32 = v139.clone();
                        let mut v140: i32 = v140.clone();
                        let mut v141: i32 = v141.clone();
                        let mut v142: i32 = v142.clone();
                        let mut v143: i32 = v143.clone();
                        let mut v144: bool = v2 >= v139;
                        let mut v149: Rc<str> = if v144 {
                            let mut v145: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v145.clone()
                        } else {
                            let mut v146: bool = v2 == v139;
                            let mut v147: i32 = v139 - 1i32;
                            let mut v148: Rc<str> = string_slice(&v0.clone(), v2 as i64, v147 as i64);
                            v148.clone()
                        };
                        US11::US11_0(v149.clone(), v139, v140, v141, v142, v143)
                    }
                    _ => unreachable!(),
                };
                match &v159 {
                    US11::US11_1(v166, v167, v168, v169, v170, v171) => { // Error
                        let mut v166: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v166.clone();
                        let mut v167: i32 = v167.clone();
                        let mut v168: i32 = v168.clone();
                        let mut v169: i32 = v169.clone();
                        let mut v170: i32 = v170.clone();
                        let mut v171: i32 = v171.clone();
                        let mut v172: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                        US11::US11_1(v172.clone(), v2, v3, v4, v5, v6)
                    }
                    US11::US11_0(v160, v161, v162, v163, v164, v165) => { // Ok
                        let mut v160: Rc<str> = v160.clone();
                        let mut v161: i32 = v161.clone();
                        let mut v162: i32 = v162.clone();
                        let mut v163: i32 = v163.clone();
                        let mut v164: i32 = v164.clone();
                        let mut v165: i32 = v165.clone();
                        v159.clone()
                    }
                    _ => unreachable!(),
                }
            }
            US11::US11_0(v78, v79, v80, v81, v82, v83) => { // Ok
                let mut v78: Rc<str> = v78.clone();
                let mut v79: i32 = v79.clone();
                let mut v80: i32 = v80.clone();
                let mut v81: i32 = v81.clone();
                let mut v82: i32 = v82.clone();
                let mut v83: i32 = v83.clone();
                v77.clone()
            }
            _ => unreachable!(),
        };
        let mut v194: US11 = match &v177 {
            US11::US11_1(v186, v187, v188, v189, v190, v191) => { // Error
                let mut v186: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v186.clone();
                let mut v187: i32 = v187.clone();
                let mut v188: i32 = v188.clone();
                let mut v189: i32 = v189.clone();
                let mut v190: i32 = v190.clone();
                let mut v191: i32 = v191.clone();
                US11::US11_1(v186.clone(), v187, v188, v189, v190, v191)
            }
            US11::US11_0(v178, v179, v180, v181, v182, v183) => { // Ok
                let mut v178: Rc<str> = v178.clone();
                let mut v179: i32 = v179.clone();
                let mut v180: i32 = v180.clone();
                let mut v181: i32 = v181.clone();
                let mut v182: i32 = v182.clone();
                let mut v183: i32 = v183.clone();
                let mut v184: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                US11::US11_0(v184.clone(), v179, v180, v181, v182, v183)
            }
            _ => unreachable!(),
        };
        let mut v250: US11 = match &v194 {
            US11::US11_1(v242, v243, v244, v245, v246, v247) => { // Error
                let mut v242: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v242.clone();
                let mut v243: i32 = v243.clone();
                let mut v244: i32 = v244.clone();
                let mut v245: i32 = v245.clone();
                let mut v246: i32 = v246.clone();
                let mut v247: i32 = v247.clone();
                US11::US11_1(v242.clone(), v243, v244, v245, v246, v247)
            }
            US11::US11_0(v195, v196, v197, v198, v199, v200) => { // Ok
                let mut v195: Rc<str> = v195.clone();
                let mut v196: i32 = v196.clone();
                let mut v197: i32 = v197.clone();
                let mut v198: i32 = v198.clone();
                let mut v199: i32 = v199.clone();
                let mut v200: i32 = v200.clone();
                let mut v201: bool = v196 >= v200;
                let mut v224: US10 = if v201 {
                    let mut v202: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure45();
                    US10::US10_1(v202.clone(), v196, v197, v198, v199, v200)
                } else {
                    let mut v204: u8 = v0.clone().as_bytes()[v196 as usize];
                    let mut v205: bool = v204 == b'\\';
                    let mut v209: bool = if v205 {
                        true
                    } else {
                        let mut v206: bool = v204 == b'`';
                        if v206 {
                            true
                        } else {
                            let mut v207: bool = v204 == b'"';
                            v207
                        }
                    };
                    let mut v210: bool = v209 == false;
                    if v210 {
                        let mut v211: i32 = v196 + 1i32;
                        let mut v212: bool = b'\n' == v204;
                        let (mut v216, mut v217, mut v218, mut v219): (i32, i32, i32, i32) = if v212 {
                            let mut v213: i32 = v197 + v199;
                            let mut v214: i32 = v198 + 1i32;
                            (v213, v214, 1i32, v200)
                        } else {
                            let mut v215: i32 = v199 + 1i32;
                            (v197, v198, v215, v200)
                        };
                        US10::US10_0(v204, v211, v216, v217, v218, v219)
                    } else {
                        let mut v221: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure46();
                        US10::US10_1(v221.clone(), v196, v197, v198, v199, v200)
                    }
                };
                match &v224 {
                    US10::US10_1(v233, v234, v235, v236, v237, v238) => { // Error
                        let mut v233: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v233.clone();
                        let mut v234: i32 = v234.clone();
                        let mut v235: i32 = v235.clone();
                        let mut v236: i32 = v236.clone();
                        let mut v237: i32 = v237.clone();
                        let mut v238: i32 = v238.clone();
                        US11::US11_1(v233.clone(), v234, v235, v236, v237, v238)
                    }
                    US10::US10_0(v225, v226, v227, v228, v229, v230) => { // Ok
                        let mut v225: u8 = v225.clone();
                        let mut v226: i32 = v226.clone();
                        let mut v227: i32 = v227.clone();
                        let mut v228: i32 = v228.clone();
                        let mut v229: i32 = v229.clone();
                        let mut v230: i32 = v230.clone();
                        let mut v231: Rc<str> = Rc::<str>::from((v225 as char).encode_utf8(&mut [0u8; 4]) as &str);
                        US11::US11_0(v231.clone(), v226, v227, v228, v229, v230)
                    }
                    _ => unreachable!(),
                }
            }
            _ => unreachable!(),
        };
        match &v250 {
            US11::US11_1(v251, v252, v253, v254, v255, v256) => { // Error
                let mut v251: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v251.clone();
                let mut v252: i32 = v252.clone();
                let mut v253: i32 = v253.clone();
                let mut v254: i32 = v254.clone();
                let mut v255: i32 = v255.clone();
                let mut v256: i32 = v256.clone();
                let mut v257: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
                let mut v258: Rc<UH0> = method121(v1.clone(), v257.clone());
                return US19::US19_0(v258.clone(), v2, v3, v4, v5, v6);
            }
            US11::US11_0(v260, v261, v262, v263, v264, v265) => { // Ok
                let mut v260: Rc<str> = v260.clone();
                let mut v261: i32 = v261.clone();
                let mut v262: i32 = v262.clone();
                let mut v263: i32 = v263.clone();
                let mut v264: i32 = v264.clone();
                let mut v265: i32 = v265.clone();
                let mut v266: bool = v261 > v2;
                if v266 {
                    let mut v267: Rc<UH0> = Rc::new(UH0::UH0_1(v260.clone(), v1.clone()));
                    (v0, v1, v2, v3, v4, v5, v6) = (v0.clone(), v267.clone(), v261, v262, v263, v264, v265);
                    continue;
                } else {
                    let mut v269: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure47();
                    return US19::US19_1(v269.clone(), v2, v3, v4, v5, v6);
                }
            }
            _ => unreachable!(),
        }
    }
}
fn method122(mut v0: Rc<UH0>, mut v1: Rc<str>) -> (Rc<str>, Rc<str>) {
    let (mut v11, mut v12): (Rc<str>, Rc<str>) = match &*v0 {
        UH0::UH0_1(v2, v3) => { // Cons
            let mut v2: Rc<str> = v2.clone();
            let mut v3: Rc<UH0> = v3.clone();
            let (mut v4, mut v5): (Rc<str>, Rc<str>) = method122(v3.clone(), v1.clone());
            let mut v6: Rc<str> = Rc::<str>::from(format!("{}{}", v2, v5));
            let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v4));
            let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            (v7.clone(), v8.clone())
        }
        _ => {
            let (mut v9, mut v10): (Rc<str>, Rc<str>) = match &*v0 {
                UH0::UH0_0 => { // Nil
                    (v1.clone(), v1.clone())
                }
                _ => unreachable!(),
            };
            (v9.clone(), v10.clone())
        }
    };
    (v11.clone(), v12.clone())
}
fn closure48() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.split_args / segment zero-length success"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method125(mut v0: i32, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: Rc<str>, mut v5: i32, mut v6: i32, mut v7: i32, mut v8: i32, mut v9: i32) -> (i32, i32, i32, i32, i32) {
    loop {
        let mut v10: bool = v5 >= v3;
        if v10 {
            return (v5, v6, v7, v8, v9);
        } else {
            let mut v11: u8 = v4.clone().as_bytes()[v5 as usize];
            let mut v12: bool = v11 == b'\\';
            let mut v18: bool = if v12 {
                true
            } else {
                let mut v13: bool = v11 == b'`';
                if v13 {
                    true
                } else {
                    let mut v14: bool = v11 == b'"';
                    if v14 {
                        true
                    } else {
                        let mut v15: bool = v11 == b' ';
                        v15
                    }
                }
            };
            let mut v19: bool = v18 == false;
            if v19 {
                let mut v20: i32 = v5 + 1i32;
                let mut v21: bool = b'\n' == v11;
                let (mut v25, mut v26, mut v27, mut v28): (i32, i32, i32, i32) = if v21 {
                    let mut v22: i32 = v6 + v8;
                    let mut v23: i32 = v7 + 1i32;
                    (v22, v23, 1i32, v9)
                } else {
                    let mut v24: i32 = v8 + 1i32;
                    (v6, v7, v24, v9)
                };
                (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0, v1, v2, v3, v4.clone(), v20, v25, v26, v27, v28);
                continue;
            } else {
                return (v5, v6, v7, v8, v9);
            }
        }
    }
}
fn method124(mut v0: i32, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: Rc<str>, mut v5: i32) -> (i32, i32, i32, i32, i32) {
    let mut v6: bool = v5 >= v3;
    if v6 {
        (v5, v0, v1, v2, v3)
    } else {
        let mut v7: u8 = v4.clone().as_bytes()[v5 as usize];
        let mut v8: bool = v7 == b'\\';
        let mut v14: bool = if v8 {
            true
        } else {
            let mut v9: bool = v7 == b'`';
            if v9 {
                true
            } else {
                let mut v10: bool = v7 == b'"';
                if v10 {
                    true
                } else {
                    let mut v11: bool = v7 == b' ';
                    v11
                }
            }
        };
        let mut v15: bool = v14 == false;
        if v15 {
            let mut v16: i32 = v5 + 1i32;
            let mut v17: bool = b'\n' == v7;
            let (mut v21, mut v22, mut v23, mut v24): (i32, i32, i32, i32) = if v17 {
                let mut v18: i32 = v0 + v2;
                let mut v19: i32 = v1 + 1i32;
                (v18, v19, 1i32, v3)
            } else {
                let mut v20: i32 = v2 + 1i32;
                (v0, v1, v20, v3)
            };
            method125(v0, v1, v2, v3, v4.clone(), v16, v21, v22, v23, v24)
        } else {
            (v5, v0, v1, v2, v3)
        }
    }
}
fn method126(mut v0: Rc<UH0>, mut v1: i32) -> i32 {
    loop {
        match &*v0 {
            UH0::UH0_1(v2, v3) => { // Cons
                let mut v2: Rc<str> = v2.clone();
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: i32 = (v2.clone().len() as i32);
                let mut v5: i32 = v1 + v4;
                (v0, v1) = (v3.clone(), v5);
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v1;
            }
            _ => unreachable!(),
        }
    }
}
fn method127(mut v0: Rc<RefCell<Vec<u8>>>, mut v1: Rc<UH0>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH0::UH0_1(v3, v4) => { // Cons
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                let mut v5: i32 = (v3.clone().len() as i32);
                let mut v6: i32 = v2 - v5;
                v0.borrow_mut()[v6 as usize..v2 as usize].copy_from_slice(v3.as_bytes());
                (v0, v1, v2) = (v0.clone(), v4.clone(), v6);
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v2;
            }
            _ => unreachable!(),
        }
    }
}
fn method129(mut v0: bool, mut v1: Rc<UH0>, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        match &*v1 {
            UH0::UH0_1(v3, v4) => { // Cons
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                match &*v4 {
                    UH0::UH0_1(v5, v6) => { // Cons
                        let mut v5: Rc<str> = v5.clone();
                        let mut v6: Rc<UH0> = v6.clone();
                        let mut v9: Rc<str> = if v0 {
                            let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v3));
                            v7.clone()
                        } else {
                            let mut v8: Rc<str> = Rc::<str>::from(format!("{}{}", v3, v5));
                            v8.clone()
                        };
                        let mut v10: Rc<UH0> = Rc::new(UH0::UH0_1(v9.clone(), v2.clone()));
                        (v0, v1, v2) = (v0, v6.clone(), v10.clone());
                        continue;
                    }
                    UH0::UH0_0 => { // Nil
                        return Rc::new(UH0::UH0_1(v3.clone(), v2.clone()));
                    }
                    _ => unreachable!(),
                }
            }
            UH0::UH0_0 => { // Nil
                return v2.clone();
            }
            _ => unreachable!(),
        }
    }
}
fn method128(mut v0: bool, mut v1: Rc<UH0>) -> Rc<str> {
    loop {
        match &*v1 {
            UH0::UH0_1(v3, v4) => { // Cons
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                match &*v4 {
                    UH0::UH0_0 => { // Nil
                        return v3.clone();
                    }
                    _ => {
                        let mut v5: bool = v0 == false;
                        let mut v6: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
                        let mut v7: Rc<UH0> = method129(v0, v1.clone(), v6.clone());
                        (v0, v1) = (v5, v7.clone());
                        continue;
                    }
                }
            }
            UH0::UH0_0 => { // Nil
                let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                return v2.clone();
            }
            _ => unreachable!(),
        }
    }
}
fn closure49() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.many1_strings / inner parser succeeded without consuming text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method123(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<UH0>, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32, mut v7: i32) -> US11 {
    loop {
        let mut v8: bool = v3 >= v7;
        let mut v26: US10 = if v8 {
            let mut v9: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
            US10::US10_1(v9.clone(), v3, v4, v5, v6, v7)
        } else {
            let mut v11: u8 = v0.clone().as_bytes()[v3 as usize];
            let mut v12: bool = v11 == b'\\';
            if v12 {
                let mut v13: i32 = v3 + 1i32;
                let mut v14: bool = b'\n' == v11;
                let (mut v18, mut v19, mut v20, mut v21): (i32, i32, i32, i32) = if v14 {
                    let mut v15: i32 = v4 + v6;
                    let mut v16: i32 = v5 + 1i32;
                    (v15, v16, 1i32, v7)
                } else {
                    let mut v17: i32 = v6 + 1i32;
                    (v4, v5, v17, v7)
                };
                US10::US10_0(b'\\', v13, v18, v19, v20, v21)
            } else {
                let mut v23: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                US10::US10_1(v23.clone(), v3, v4, v5, v6, v7)
            }
        };
        let mut v60: US10 = match &v26 {
            US10::US10_1(v52, v53, v54, v55, v56, v57) => { // Error
                let mut v52: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v52.clone();
                let mut v53: i32 = v53.clone();
                let mut v54: i32 = v54.clone();
                let mut v55: i32 = v55.clone();
                let mut v56: i32 = v56.clone();
                let mut v57: i32 = v57.clone();
                US10::US10_1(v52.clone(), v53, v54, v55, v56, v57)
            }
            US10::US10_0(v27, v28, v29, v30, v31, v32) => { // Ok
                let mut v27: u8 = v27.clone();
                let mut v28: i32 = v28.clone();
                let mut v29: i32 = v29.clone();
                let mut v30: i32 = v30.clone();
                let mut v31: i32 = v31.clone();
                let mut v32: i32 = v32.clone();
                let mut v33: bool = v28 >= v32;
                if v33 {
                    let mut v34: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                    US10::US10_1(v34.clone(), v28, v29, v30, v31, v32)
                } else {
                    let mut v36: u8 = v0.clone().as_bytes()[v28 as usize];
                    let mut v37: bool = v36 == b'"';
                    if v37 {
                        let mut v38: i32 = v28 + 1i32;
                        let mut v39: bool = b'\n' == v36;
                        let (mut v43, mut v44, mut v45, mut v46): (i32, i32, i32, i32) = if v39 {
                            let mut v40: i32 = v29 + v31;
                            let mut v41: i32 = v30 + 1i32;
                            (v40, v41, 1i32, v32)
                        } else {
                            let mut v42: i32 = v31 + 1i32;
                            (v29, v30, v42, v32)
                        };
                        US10::US10_0(b'"', v38, v43, v44, v45, v46)
                    } else {
                        let mut v48: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                        US10::US10_1(v48.clone(), v28, v29, v30, v31, v32)
                    }
                }
            }
            _ => unreachable!(),
        };
        let mut v76: US10 = match &v60 {
            US10::US10_1(v68, v69, v70, v71, v72, v73) => { // Error
                let mut v68: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v68.clone();
                let mut v69: i32 = v69.clone();
                let mut v70: i32 = v70.clone();
                let mut v71: i32 = v71.clone();
                let mut v72: i32 = v72.clone();
                let mut v73: i32 = v73.clone();
                US10::US10_1(v68.clone(), v69, v70, v71, v72, v73)
            }
            US10::US10_0(v61, v62, v63, v64, v65, v66) => { // Ok
                let mut v61: u8 = v61.clone();
                let mut v62: i32 = v62.clone();
                let mut v63: i32 = v63.clone();
                let mut v64: i32 = v64.clone();
                let mut v65: i32 = v65.clone();
                let mut v66: i32 = v66.clone();
                US10::US10_0(b'"', v62, v63, v64, v65, v66)
            }
            _ => unreachable!(),
        };
        let mut v174: US10 = match &v76 {
            US10::US10_1(v83, v84, v85, v86, v87, v88) => { // Error
                let mut v83: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v83.clone();
                let mut v84: i32 = v84.clone();
                let mut v85: i32 = v85.clone();
                let mut v86: i32 = v86.clone();
                let mut v87: i32 = v87.clone();
                let mut v88: i32 = v88.clone();
                let mut v106: US10 = if v8 {
                    let mut v89: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                    US10::US10_1(v89.clone(), v3, v4, v5, v6, v7)
                } else {
                    let mut v91: u8 = v0.clone().as_bytes()[v3 as usize];
                    let mut v92: bool = v91 == b'`';
                    if v92 {
                        let mut v93: i32 = v3 + 1i32;
                        let mut v94: bool = b'\n' == v91;
                        let (mut v98, mut v99, mut v100, mut v101): (i32, i32, i32, i32) = if v94 {
                            let mut v95: i32 = v4 + v6;
                            let mut v96: i32 = v5 + 1i32;
                            (v95, v96, 1i32, v7)
                        } else {
                            let mut v97: i32 = v6 + 1i32;
                            (v4, v5, v97, v7)
                        };
                        US10::US10_0(b'`', v93, v98, v99, v100, v101)
                    } else {
                        let mut v103: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                        US10::US10_1(v103.clone(), v3, v4, v5, v6, v7)
                    }
                };
                let mut v140: US10 = match &v106 {
                    US10::US10_1(v132, v133, v134, v135, v136, v137) => { // Error
                        let mut v132: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v132.clone();
                        let mut v133: i32 = v133.clone();
                        let mut v134: i32 = v134.clone();
                        let mut v135: i32 = v135.clone();
                        let mut v136: i32 = v136.clone();
                        let mut v137: i32 = v137.clone();
                        US10::US10_1(v132.clone(), v133, v134, v135, v136, v137)
                    }
                    US10::US10_0(v107, v108, v109, v110, v111, v112) => { // Ok
                        let mut v107: u8 = v107.clone();
                        let mut v108: i32 = v108.clone();
                        let mut v109: i32 = v109.clone();
                        let mut v110: i32 = v110.clone();
                        let mut v111: i32 = v111.clone();
                        let mut v112: i32 = v112.clone();
                        let mut v113: bool = v108 >= v112;
                        if v113 {
                            let mut v114: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                            US10::US10_1(v114.clone(), v108, v109, v110, v111, v112)
                        } else {
                            let mut v116: u8 = v0.clone().as_bytes()[v108 as usize];
                            let mut v117: bool = v116 == b'"';
                            if v117 {
                                let mut v118: i32 = v108 + 1i32;
                                let mut v119: bool = b'\n' == v116;
                                let (mut v123, mut v124, mut v125, mut v126): (i32, i32, i32, i32) = if v119 {
                                    let mut v120: i32 = v109 + v111;
                                    let mut v121: i32 = v110 + 1i32;
                                    (v120, v121, 1i32, v112)
                                } else {
                                    let mut v122: i32 = v111 + 1i32;
                                    (v109, v110, v122, v112)
                                };
                                US10::US10_0(b'"', v118, v123, v124, v125, v126)
                            } else {
                                let mut v128: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                US10::US10_1(v128.clone(), v108, v109, v110, v111, v112)
                            }
                        }
                    }
                    _ => unreachable!(),
                };
                let mut v156: US10 = match &v140 {
                    US10::US10_1(v148, v149, v150, v151, v152, v153) => { // Error
                        let mut v148: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v148.clone();
                        let mut v149: i32 = v149.clone();
                        let mut v150: i32 = v150.clone();
                        let mut v151: i32 = v151.clone();
                        let mut v152: i32 = v152.clone();
                        let mut v153: i32 = v153.clone();
                        US10::US10_1(v148.clone(), v149, v150, v151, v152, v153)
                    }
                    US10::US10_0(v141, v142, v143, v144, v145, v146) => { // Ok
                        let mut v141: u8 = v141.clone();
                        let mut v142: i32 = v142.clone();
                        let mut v143: i32 = v143.clone();
                        let mut v144: i32 = v144.clone();
                        let mut v145: i32 = v145.clone();
                        let mut v146: i32 = v146.clone();
                        US10::US10_0(b'"', v142, v143, v144, v145, v146)
                    }
                    _ => unreachable!(),
                };
                match &v156 {
                    US10::US10_1(v163, v164, v165, v166, v167, v168) => { // Error
                        let mut v163: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v163.clone();
                        let mut v164: i32 = v164.clone();
                        let mut v165: i32 = v165.clone();
                        let mut v166: i32 = v166.clone();
                        let mut v167: i32 = v167.clone();
                        let mut v168: i32 = v168.clone();
                        let mut v169: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                        US10::US10_1(v169.clone(), v3, v4, v5, v6, v7)
                    }
                    US10::US10_0(v157, v158, v159, v160, v161, v162) => { // Ok
                        let mut v157: u8 = v157.clone();
                        let mut v158: i32 = v158.clone();
                        let mut v159: i32 = v159.clone();
                        let mut v160: i32 = v160.clone();
                        let mut v161: i32 = v161.clone();
                        let mut v162: i32 = v162.clone();
                        v156.clone()
                    }
                    _ => unreachable!(),
                }
            }
            US10::US10_0(v77, v78, v79, v80, v81, v82) => { // Ok
                let mut v77: u8 = v77.clone();
                let mut v78: i32 = v78.clone();
                let mut v79: i32 = v79.clone();
                let mut v80: i32 = v80.clone();
                let mut v81: i32 = v81.clone();
                let mut v82: i32 = v82.clone();
                v76.clone()
            }
            _ => unreachable!(),
        };
        let mut v806: US11 = match &v174 {
            US10::US10_1(v798, v799, v800, v801, v802, v803) => { // Error
                let mut v798: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v798.clone();
                let mut v799: i32 = v799.clone();
                let mut v800: i32 = v800.clone();
                let mut v801: i32 = v801.clone();
                let mut v802: i32 = v802.clone();
                let mut v803: i32 = v803.clone();
                US11::US11_1(v798.clone(), v799, v800, v801, v802, v803)
            }
            US10::US10_0(v175, v176, v177, v178, v179, v180) => { // Ok
                let mut v175: u8 = v175.clone();
                let mut v176: i32 = v176.clone();
                let mut v177: i32 = v177.clone();
                let mut v178: i32 = v178.clone();
                let mut v179: i32 = v179.clone();
                let mut v180: i32 = v180.clone();
                let (mut v181, mut v182, mut v183, mut v184, mut v185): (i32, i32, i32, i32, i32) = method111(v177, v178, v179, v180, v0.clone(), v176);
                let mut v186: bool = v181 > v176;
                let mut v196: US11 = if v186 {
                    let mut v187: bool = v176 >= v181;
                    let mut v192: Rc<str> = if v187 {
                        let mut v188: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v188.clone()
                    } else {
                        let mut v189: bool = v176 == v181;
                        let mut v190: i32 = v181 - 1i32;
                        let mut v191: Rc<str> = string_slice(&v0.clone(), v176 as i64, v190 as i64);
                        v191.clone()
                    };
                    US11::US11_0(v192.clone(), v181, v182, v183, v184, v185)
                } else {
                    let mut v194: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                    US11::US11_1(v194.clone(), v176, v177, v178, v179, v180)
                };
                let mut v391: US11 = match &v196 {
                    US11::US11_1(v203, v204, v205, v206, v207, v208) => { // Error
                        let mut v203: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v203.clone();
                        let mut v204: i32 = v204.clone();
                        let mut v205: i32 = v205.clone();
                        let mut v206: i32 = v206.clone();
                        let mut v207: i32 = v207.clone();
                        let mut v208: i32 = v208.clone();
                        let mut v209: bool = v176 >= v180;
                        let mut v227: US10 = if v209 {
                            let mut v210: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                            US10::US10_1(v210.clone(), v176, v177, v178, v179, v180)
                        } else {
                            let mut v212: u8 = v0.clone().as_bytes()[v176 as usize];
                            let mut v213: bool = v212 == b'\\';
                            if v213 {
                                let mut v214: i32 = v176 + 1i32;
                                let mut v215: bool = b'\n' == v212;
                                let (mut v219, mut v220, mut v221, mut v222): (i32, i32, i32, i32) = if v215 {
                                    let mut v216: i32 = v177 + v179;
                                    let mut v217: i32 = v178 + 1i32;
                                    (v216, v217, 1i32, v180)
                                } else {
                                    let mut v218: i32 = v179 + 1i32;
                                    (v177, v178, v218, v180)
                                };
                                US10::US10_0(b'\\', v214, v219, v220, v221, v222)
                            } else {
                                let mut v224: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                US10::US10_1(v224.clone(), v176, v177, v178, v179, v180)
                            }
                        };
                        let mut v262: US10 = match &v227 {
                            US10::US10_1(v254, v255, v256, v257, v258, v259) => { // Error
                                let mut v254: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v254.clone();
                                let mut v255: i32 = v255.clone();
                                let mut v256: i32 = v256.clone();
                                let mut v257: i32 = v257.clone();
                                let mut v258: i32 = v258.clone();
                                let mut v259: i32 = v259.clone();
                                US10::US10_1(v254.clone(), v255, v256, v257, v258, v259)
                            }
                            US10::US10_0(v228, v229, v230, v231, v232, v233) => { // Ok
                                let mut v228: u8 = v228.clone();
                                let mut v229: i32 = v229.clone();
                                let mut v230: i32 = v230.clone();
                                let mut v231: i32 = v231.clone();
                                let mut v232: i32 = v232.clone();
                                let mut v233: i32 = v233.clone();
                                let mut v234: bool = v229 >= v233;
                                if v234 {
                                    let mut v235: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                    US10::US10_1(v235.clone(), v229, v230, v231, v232, v233)
                                } else {
                                    let mut v237: u8 = v0.clone().as_bytes()[v229 as usize];
                                    let mut v238: bool = v237 == b'"';
                                    let mut v239: bool = v238 == false;
                                    if v239 {
                                        let mut v240: i32 = v229 + 1i32;
                                        let mut v241: bool = b'\n' == v237;
                                        let (mut v245, mut v246, mut v247, mut v248): (i32, i32, i32, i32) = if v241 {
                                            let mut v242: i32 = v230 + v232;
                                            let mut v243: i32 = v231 + 1i32;
                                            (v242, v243, 1i32, v233)
                                        } else {
                                            let mut v244: i32 = v232 + 1i32;
                                            (v230, v231, v244, v233)
                                        };
                                        US10::US10_0(v237, v240, v245, v246, v247, v248)
                                    } else {
                                        let mut v250: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                        US10::US10_1(v250.clone(), v229, v230, v231, v232, v233)
                                    }
                                }
                            }
                            _ => unreachable!(),
                        };
                        let mut v284: US11 = match &v262 {
                            US10::US10_1(v276, v277, v278, v279, v280, v281) => { // Error
                                let mut v276: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v276.clone();
                                let mut v277: i32 = v277.clone();
                                let mut v278: i32 = v278.clone();
                                let mut v279: i32 = v279.clone();
                                let mut v280: i32 = v280.clone();
                                let mut v281: i32 = v281.clone();
                                US11::US11_1(v276.clone(), v277, v278, v279, v280, v281)
                            }
                            US10::US10_0(v263, v264, v265, v266, v267, v268) => { // Ok
                                let mut v263: u8 = v263.clone();
                                let mut v264: i32 = v264.clone();
                                let mut v265: i32 = v265.clone();
                                let mut v266: i32 = v266.clone();
                                let mut v267: i32 = v267.clone();
                                let mut v268: i32 = v268.clone();
                                let mut v269: bool = v176 >= v264;
                                let mut v274: Rc<str> = if v269 {
                                    let mut v270: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v270.clone()
                                } else {
                                    let mut v271: bool = v176 == v264;
                                    let mut v272: i32 = v264 - 1i32;
                                    let mut v273: Rc<str> = string_slice(&v0.clone(), v176 as i64, v272 as i64);
                                    v273.clone()
                                };
                                US11::US11_0(v274.clone(), v264, v265, v266, v267, v268)
                            }
                            _ => unreachable!(),
                        };
                        match &v284 {
                            US11::US11_1(v291, v292, v293, v294, v295, v296) => { // Error
                                let mut v291: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v291.clone();
                                let mut v292: i32 = v292.clone();
                                let mut v293: i32 = v293.clone();
                                let mut v294: i32 = v294.clone();
                                let mut v295: i32 = v295.clone();
                                let mut v296: i32 = v296.clone();
                                let mut v314: US10 = if v209 {
                                    let mut v297: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                    US10::US10_1(v297.clone(), v176, v177, v178, v179, v180)
                                } else {
                                    let mut v299: u8 = v0.clone().as_bytes()[v176 as usize];
                                    let mut v300: bool = v299 == b'`';
                                    if v300 {
                                        let mut v301: i32 = v176 + 1i32;
                                        let mut v302: bool = b'\n' == v299;
                                        let (mut v306, mut v307, mut v308, mut v309): (i32, i32, i32, i32) = if v302 {
                                            let mut v303: i32 = v177 + v179;
                                            let mut v304: i32 = v178 + 1i32;
                                            (v303, v304, 1i32, v180)
                                        } else {
                                            let mut v305: i32 = v179 + 1i32;
                                            (v177, v178, v305, v180)
                                        };
                                        US10::US10_0(b'`', v301, v306, v307, v308, v309)
                                    } else {
                                        let mut v311: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                        US10::US10_1(v311.clone(), v176, v177, v178, v179, v180)
                                    }
                                };
                                let mut v349: US10 = match &v314 {
                                    US10::US10_1(v341, v342, v343, v344, v345, v346) => { // Error
                                        let mut v341: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v341.clone();
                                        let mut v342: i32 = v342.clone();
                                        let mut v343: i32 = v343.clone();
                                        let mut v344: i32 = v344.clone();
                                        let mut v345: i32 = v345.clone();
                                        let mut v346: i32 = v346.clone();
                                        US10::US10_1(v341.clone(), v342, v343, v344, v345, v346)
                                    }
                                    US10::US10_0(v315, v316, v317, v318, v319, v320) => { // Ok
                                        let mut v315: u8 = v315.clone();
                                        let mut v316: i32 = v316.clone();
                                        let mut v317: i32 = v317.clone();
                                        let mut v318: i32 = v318.clone();
                                        let mut v319: i32 = v319.clone();
                                        let mut v320: i32 = v320.clone();
                                        let mut v321: bool = v316 >= v320;
                                        if v321 {
                                            let mut v322: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                            US10::US10_1(v322.clone(), v316, v317, v318, v319, v320)
                                        } else {
                                            let mut v324: u8 = v0.clone().as_bytes()[v316 as usize];
                                            let mut v325: bool = v324 == b'"';
                                            let mut v326: bool = v325 == false;
                                            if v326 {
                                                let mut v327: i32 = v316 + 1i32;
                                                let mut v328: bool = b'\n' == v324;
                                                let (mut v332, mut v333, mut v334, mut v335): (i32, i32, i32, i32) = if v328 {
                                                    let mut v329: i32 = v317 + v319;
                                                    let mut v330: i32 = v318 + 1i32;
                                                    (v329, v330, 1i32, v320)
                                                } else {
                                                    let mut v331: i32 = v319 + 1i32;
                                                    (v317, v318, v331, v320)
                                                };
                                                US10::US10_0(v324, v327, v332, v333, v334, v335)
                                            } else {
                                                let mut v337: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                US10::US10_1(v337.clone(), v316, v317, v318, v319, v320)
                                            }
                                        }
                                    }
                                    _ => unreachable!(),
                                };
                                let mut v371: US11 = match &v349 {
                                    US10::US10_1(v363, v364, v365, v366, v367, v368) => { // Error
                                        let mut v363: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v363.clone();
                                        let mut v364: i32 = v364.clone();
                                        let mut v365: i32 = v365.clone();
                                        let mut v366: i32 = v366.clone();
                                        let mut v367: i32 = v367.clone();
                                        let mut v368: i32 = v368.clone();
                                        US11::US11_1(v363.clone(), v364, v365, v366, v367, v368)
                                    }
                                    US10::US10_0(v350, v351, v352, v353, v354, v355) => { // Ok
                                        let mut v350: u8 = v350.clone();
                                        let mut v351: i32 = v351.clone();
                                        let mut v352: i32 = v352.clone();
                                        let mut v353: i32 = v353.clone();
                                        let mut v354: i32 = v354.clone();
                                        let mut v355: i32 = v355.clone();
                                        let mut v356: bool = v176 >= v351;
                                        let mut v361: Rc<str> = if v356 {
                                            let mut v357: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            v357.clone()
                                        } else {
                                            let mut v358: bool = v176 == v351;
                                            let mut v359: i32 = v351 - 1i32;
                                            let mut v360: Rc<str> = string_slice(&v0.clone(), v176 as i64, v359 as i64);
                                            v360.clone()
                                        };
                                        US11::US11_0(v361.clone(), v351, v352, v353, v354, v355)
                                    }
                                    _ => unreachable!(),
                                };
                                match &v371 {
                                    US11::US11_1(v378, v379, v380, v381, v382, v383) => { // Error
                                        let mut v378: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v378.clone();
                                        let mut v379: i32 = v379.clone();
                                        let mut v380: i32 = v380.clone();
                                        let mut v381: i32 = v381.clone();
                                        let mut v382: i32 = v382.clone();
                                        let mut v383: i32 = v383.clone();
                                        let mut v384: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                        US11::US11_1(v384.clone(), v176, v177, v178, v179, v180)
                                    }
                                    US11::US11_0(v372, v373, v374, v375, v376, v377) => { // Ok
                                        let mut v372: Rc<str> = v372.clone();
                                        let mut v373: i32 = v373.clone();
                                        let mut v374: i32 = v374.clone();
                                        let mut v375: i32 = v375.clone();
                                        let mut v376: i32 = v376.clone();
                                        let mut v377: i32 = v377.clone();
                                        v371.clone()
                                    }
                                    _ => unreachable!(),
                                }
                            }
                            US11::US11_0(v285, v286, v287, v288, v289, v290) => { // Ok
                                let mut v285: Rc<str> = v285.clone();
                                let mut v286: i32 = v286.clone();
                                let mut v287: i32 = v287.clone();
                                let mut v288: i32 = v288.clone();
                                let mut v289: i32 = v289.clone();
                                let mut v290: i32 = v290.clone();
                                v284.clone()
                            }
                            _ => unreachable!(),
                        }
                    }
                    US11::US11_0(v197, v198, v199, v200, v201, v202) => { // Ok
                        let mut v197: Rc<str> = v197.clone();
                        let mut v198: i32 = v198.clone();
                        let mut v199: i32 = v199.clone();
                        let mut v200: i32 = v200.clone();
                        let mut v201: i32 = v201.clone();
                        let mut v202: i32 = v202.clone();
                        v196.clone()
                    }
                    _ => unreachable!(),
                };
                let mut v414: US11 = match &v391 {
                    US11::US11_1(v392, v393, v394, v395, v396, v397) => { // Error
                        let mut v392: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v392.clone();
                        let mut v393: i32 = v393.clone();
                        let mut v394: i32 = v394.clone();
                        let mut v395: i32 = v395.clone();
                        let mut v396: i32 = v396.clone();
                        let mut v397: i32 = v397.clone();
                        let mut v398: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        US11::US11_0(v398.clone(), v176, v177, v178, v179, v180)
                    }
                    US11::US11_0(v400, v401, v402, v403, v404, v405) => { // Ok
                        let mut v400: Rc<str> = v400.clone();
                        let mut v401: i32 = v401.clone();
                        let mut v402: i32 = v402.clone();
                        let mut v403: i32 = v403.clone();
                        let mut v404: i32 = v404.clone();
                        let mut v405: i32 = v405.clone();
                        let mut v406: bool = v401 == v176;
                        if v406 {
                            let mut v407: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                            US11::US11_1(v407.clone(), v176, v177, v178, v179, v180)
                        } else {
                            let mut v409: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                            let mut v410: i32 = 0i32;
                            method115(v0.clone(), v409.clone(), v400.clone(), v410, v401, v402, v403, v404, v405)
                        }
                    }
                    _ => unreachable!(),
                };
                match &v414 {
                    US11::US11_1(v605, v606, v607, v608, v609, v610) => { // Error
                        let mut v605: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v605.clone();
                        let mut v606: i32 = v606.clone();
                        let mut v607: i32 = v607.clone();
                        let mut v608: i32 = v608.clone();
                        let mut v609: i32 = v609.clone();
                        let mut v610: i32 = v610.clone();
                        let mut v611: bool = v176 >= v180;
                        let mut v629: US10 = if v611 {
                            let mut v612: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                            US10::US10_1(v612.clone(), v176, v177, v178, v179, v180)
                        } else {
                            let mut v614: u8 = v0.clone().as_bytes()[v176 as usize];
                            let mut v615: bool = v614 == b'\\';
                            if v615 {
                                let mut v616: i32 = v176 + 1i32;
                                let mut v617: bool = b'\n' == v614;
                                let (mut v621, mut v622, mut v623, mut v624): (i32, i32, i32, i32) = if v617 {
                                    let mut v618: i32 = v177 + v179;
                                    let mut v619: i32 = v178 + 1i32;
                                    (v618, v619, 1i32, v180)
                                } else {
                                    let mut v620: i32 = v179 + 1i32;
                                    (v177, v178, v620, v180)
                                };
                                US10::US10_0(b'\\', v616, v621, v622, v623, v624)
                            } else {
                                let mut v626: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                US10::US10_1(v626.clone(), v176, v177, v178, v179, v180)
                            }
                        };
                        let mut v663: US10 = match &v629 {
                            US10::US10_1(v655, v656, v657, v658, v659, v660) => { // Error
                                let mut v655: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v655.clone();
                                let mut v656: i32 = v656.clone();
                                let mut v657: i32 = v657.clone();
                                let mut v658: i32 = v658.clone();
                                let mut v659: i32 = v659.clone();
                                let mut v660: i32 = v660.clone();
                                US10::US10_1(v655.clone(), v656, v657, v658, v659, v660)
                            }
                            US10::US10_0(v630, v631, v632, v633, v634, v635) => { // Ok
                                let mut v630: u8 = v630.clone();
                                let mut v631: i32 = v631.clone();
                                let mut v632: i32 = v632.clone();
                                let mut v633: i32 = v633.clone();
                                let mut v634: i32 = v634.clone();
                                let mut v635: i32 = v635.clone();
                                let mut v636: bool = v631 >= v635;
                                if v636 {
                                    let mut v637: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                    US10::US10_1(v637.clone(), v631, v632, v633, v634, v635)
                                } else {
                                    let mut v639: u8 = v0.clone().as_bytes()[v631 as usize];
                                    let mut v640: bool = v639 == b'"';
                                    if v640 {
                                        let mut v641: i32 = v631 + 1i32;
                                        let mut v642: bool = b'\n' == v639;
                                        let (mut v646, mut v647, mut v648, mut v649): (i32, i32, i32, i32) = if v642 {
                                            let mut v643: i32 = v632 + v634;
                                            let mut v644: i32 = v633 + 1i32;
                                            (v643, v644, 1i32, v635)
                                        } else {
                                            let mut v645: i32 = v634 + 1i32;
                                            (v632, v633, v645, v635)
                                        };
                                        US10::US10_0(b'"', v641, v646, v647, v648, v649)
                                    } else {
                                        let mut v651: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                        US10::US10_1(v651.clone(), v631, v632, v633, v634, v635)
                                    }
                                }
                            }
                            _ => unreachable!(),
                        };
                        let mut v679: US10 = match &v663 {
                            US10::US10_1(v671, v672, v673, v674, v675, v676) => { // Error
                                let mut v671: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v671.clone();
                                let mut v672: i32 = v672.clone();
                                let mut v673: i32 = v673.clone();
                                let mut v674: i32 = v674.clone();
                                let mut v675: i32 = v675.clone();
                                let mut v676: i32 = v676.clone();
                                US10::US10_1(v671.clone(), v672, v673, v674, v675, v676)
                            }
                            US10::US10_0(v664, v665, v666, v667, v668, v669) => { // Ok
                                let mut v664: u8 = v664.clone();
                                let mut v665: i32 = v665.clone();
                                let mut v666: i32 = v666.clone();
                                let mut v667: i32 = v667.clone();
                                let mut v668: i32 = v668.clone();
                                let mut v669: i32 = v669.clone();
                                US10::US10_0(b'"', v665, v666, v667, v668, v669)
                            }
                            _ => unreachable!(),
                        };
                        let mut v777: US10 = match &v679 {
                            US10::US10_1(v686, v687, v688, v689, v690, v691) => { // Error
                                let mut v686: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v686.clone();
                                let mut v687: i32 = v687.clone();
                                let mut v688: i32 = v688.clone();
                                let mut v689: i32 = v689.clone();
                                let mut v690: i32 = v690.clone();
                                let mut v691: i32 = v691.clone();
                                let mut v709: US10 = if v611 {
                                    let mut v692: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                    US10::US10_1(v692.clone(), v176, v177, v178, v179, v180)
                                } else {
                                    let mut v694: u8 = v0.clone().as_bytes()[v176 as usize];
                                    let mut v695: bool = v694 == b'`';
                                    if v695 {
                                        let mut v696: i32 = v176 + 1i32;
                                        let mut v697: bool = b'\n' == v694;
                                        let (mut v701, mut v702, mut v703, mut v704): (i32, i32, i32, i32) = if v697 {
                                            let mut v698: i32 = v177 + v179;
                                            let mut v699: i32 = v178 + 1i32;
                                            (v698, v699, 1i32, v180)
                                        } else {
                                            let mut v700: i32 = v179 + 1i32;
                                            (v177, v178, v700, v180)
                                        };
                                        US10::US10_0(b'`', v696, v701, v702, v703, v704)
                                    } else {
                                        let mut v706: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                        US10::US10_1(v706.clone(), v176, v177, v178, v179, v180)
                                    }
                                };
                                let mut v743: US10 = match &v709 {
                                    US10::US10_1(v735, v736, v737, v738, v739, v740) => { // Error
                                        let mut v735: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v735.clone();
                                        let mut v736: i32 = v736.clone();
                                        let mut v737: i32 = v737.clone();
                                        let mut v738: i32 = v738.clone();
                                        let mut v739: i32 = v739.clone();
                                        let mut v740: i32 = v740.clone();
                                        US10::US10_1(v735.clone(), v736, v737, v738, v739, v740)
                                    }
                                    US10::US10_0(v710, v711, v712, v713, v714, v715) => { // Ok
                                        let mut v710: u8 = v710.clone();
                                        let mut v711: i32 = v711.clone();
                                        let mut v712: i32 = v712.clone();
                                        let mut v713: i32 = v713.clone();
                                        let mut v714: i32 = v714.clone();
                                        let mut v715: i32 = v715.clone();
                                        let mut v716: bool = v711 >= v715;
                                        if v716 {
                                            let mut v717: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                            US10::US10_1(v717.clone(), v711, v712, v713, v714, v715)
                                        } else {
                                            let mut v719: u8 = v0.clone().as_bytes()[v711 as usize];
                                            let mut v720: bool = v719 == b'"';
                                            if v720 {
                                                let mut v721: i32 = v711 + 1i32;
                                                let mut v722: bool = b'\n' == v719;
                                                let (mut v726, mut v727, mut v728, mut v729): (i32, i32, i32, i32) = if v722 {
                                                    let mut v723: i32 = v712 + v714;
                                                    let mut v724: i32 = v713 + 1i32;
                                                    (v723, v724, 1i32, v715)
                                                } else {
                                                    let mut v725: i32 = v714 + 1i32;
                                                    (v712, v713, v725, v715)
                                                };
                                                US10::US10_0(b'"', v721, v726, v727, v728, v729)
                                            } else {
                                                let mut v731: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                US10::US10_1(v731.clone(), v711, v712, v713, v714, v715)
                                            }
                                        }
                                    }
                                    _ => unreachable!(),
                                };
                                let mut v759: US10 = match &v743 {
                                    US10::US10_1(v751, v752, v753, v754, v755, v756) => { // Error
                                        let mut v751: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v751.clone();
                                        let mut v752: i32 = v752.clone();
                                        let mut v753: i32 = v753.clone();
                                        let mut v754: i32 = v754.clone();
                                        let mut v755: i32 = v755.clone();
                                        let mut v756: i32 = v756.clone();
                                        US10::US10_1(v751.clone(), v752, v753, v754, v755, v756)
                                    }
                                    US10::US10_0(v744, v745, v746, v747, v748, v749) => { // Ok
                                        let mut v744: u8 = v744.clone();
                                        let mut v745: i32 = v745.clone();
                                        let mut v746: i32 = v746.clone();
                                        let mut v747: i32 = v747.clone();
                                        let mut v748: i32 = v748.clone();
                                        let mut v749: i32 = v749.clone();
                                        US10::US10_0(b'"', v745, v746, v747, v748, v749)
                                    }
                                    _ => unreachable!(),
                                };
                                match &v759 {
                                    US10::US10_1(v766, v767, v768, v769, v770, v771) => { // Error
                                        let mut v766: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v766.clone();
                                        let mut v767: i32 = v767.clone();
                                        let mut v768: i32 = v768.clone();
                                        let mut v769: i32 = v769.clone();
                                        let mut v770: i32 = v770.clone();
                                        let mut v771: i32 = v771.clone();
                                        let mut v772: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                        US10::US10_1(v772.clone(), v176, v177, v178, v179, v180)
                                    }
                                    US10::US10_0(v760, v761, v762, v763, v764, v765) => { // Ok
                                        let mut v760: u8 = v760.clone();
                                        let mut v761: i32 = v761.clone();
                                        let mut v762: i32 = v762.clone();
                                        let mut v763: i32 = v763.clone();
                                        let mut v764: i32 = v764.clone();
                                        let mut v765: i32 = v765.clone();
                                        v759.clone()
                                    }
                                    _ => unreachable!(),
                                }
                            }
                            US10::US10_0(v680, v681, v682, v683, v684, v685) => { // Ok
                                let mut v680: u8 = v680.clone();
                                let mut v681: i32 = v681.clone();
                                let mut v682: i32 = v682.clone();
                                let mut v683: i32 = v683.clone();
                                let mut v684: i32 = v684.clone();
                                let mut v685: i32 = v685.clone();
                                v679.clone()
                            }
                            _ => unreachable!(),
                        };
                        match &v777 {
                            US10::US10_1(v786, v787, v788, v789, v790, v791) => { // Error
                                let mut v786: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v786.clone();
                                let mut v787: i32 = v787.clone();
                                let mut v788: i32 = v788.clone();
                                let mut v789: i32 = v789.clone();
                                let mut v790: i32 = v790.clone();
                                let mut v791: i32 = v791.clone();
                                let mut v792: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                                US11::US11_1(v792.clone(), v176, v177, v178, v179, v180)
                            }
                            US10::US10_0(v778, v779, v780, v781, v782, v783) => { // Ok
                                let mut v778: u8 = v778.clone();
                                let mut v779: i32 = v779.clone();
                                let mut v780: i32 = v780.clone();
                                let mut v781: i32 = v781.clone();
                                let mut v782: i32 = v782.clone();
                                let mut v783: i32 = v783.clone();
                                let mut v784: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                US11::US11_0(v784.clone(), v779, v780, v781, v782, v783)
                            }
                            _ => unreachable!(),
                        }
                    }
                    US11::US11_0(v415, v416, v417, v418, v419, v420) => { // Ok
                        let mut v415: Rc<str> = v415.clone();
                        let mut v416: i32 = v416.clone();
                        let mut v417: i32 = v417.clone();
                        let mut v418: i32 = v418.clone();
                        let mut v419: i32 = v419.clone();
                        let mut v420: i32 = v420.clone();
                        let mut v421: bool = v416 >= v420;
                        let mut v439: US10 = if v421 {
                            let mut v422: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                            US10::US10_1(v422.clone(), v416, v417, v418, v419, v420)
                        } else {
                            let mut v424: u8 = v0.clone().as_bytes()[v416 as usize];
                            let mut v425: bool = v424 == b'\\';
                            if v425 {
                                let mut v426: i32 = v416 + 1i32;
                                let mut v427: bool = b'\n' == v424;
                                let (mut v431, mut v432, mut v433, mut v434): (i32, i32, i32, i32) = if v427 {
                                    let mut v428: i32 = v417 + v419;
                                    let mut v429: i32 = v418 + 1i32;
                                    (v428, v429, 1i32, v420)
                                } else {
                                    let mut v430: i32 = v419 + 1i32;
                                    (v417, v418, v430, v420)
                                };
                                US10::US10_0(b'\\', v426, v431, v432, v433, v434)
                            } else {
                                let mut v436: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                US10::US10_1(v436.clone(), v416, v417, v418, v419, v420)
                            }
                        };
                        let mut v473: US10 = match &v439 {
                            US10::US10_1(v465, v466, v467, v468, v469, v470) => { // Error
                                let mut v465: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v465.clone();
                                let mut v466: i32 = v466.clone();
                                let mut v467: i32 = v467.clone();
                                let mut v468: i32 = v468.clone();
                                let mut v469: i32 = v469.clone();
                                let mut v470: i32 = v470.clone();
                                US10::US10_1(v465.clone(), v466, v467, v468, v469, v470)
                            }
                            US10::US10_0(v440, v441, v442, v443, v444, v445) => { // Ok
                                let mut v440: u8 = v440.clone();
                                let mut v441: i32 = v441.clone();
                                let mut v442: i32 = v442.clone();
                                let mut v443: i32 = v443.clone();
                                let mut v444: i32 = v444.clone();
                                let mut v445: i32 = v445.clone();
                                let mut v446: bool = v441 >= v445;
                                if v446 {
                                    let mut v447: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                    US10::US10_1(v447.clone(), v441, v442, v443, v444, v445)
                                } else {
                                    let mut v449: u8 = v0.clone().as_bytes()[v441 as usize];
                                    let mut v450: bool = v449 == b'"';
                                    if v450 {
                                        let mut v451: i32 = v441 + 1i32;
                                        let mut v452: bool = b'\n' == v449;
                                        let (mut v456, mut v457, mut v458, mut v459): (i32, i32, i32, i32) = if v452 {
                                            let mut v453: i32 = v442 + v444;
                                            let mut v454: i32 = v443 + 1i32;
                                            (v453, v454, 1i32, v445)
                                        } else {
                                            let mut v455: i32 = v444 + 1i32;
                                            (v442, v443, v455, v445)
                                        };
                                        US10::US10_0(b'"', v451, v456, v457, v458, v459)
                                    } else {
                                        let mut v461: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                        US10::US10_1(v461.clone(), v441, v442, v443, v444, v445)
                                    }
                                }
                            }
                            _ => unreachable!(),
                        };
                        let mut v489: US10 = match &v473 {
                            US10::US10_1(v481, v482, v483, v484, v485, v486) => { // Error
                                let mut v481: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v481.clone();
                                let mut v482: i32 = v482.clone();
                                let mut v483: i32 = v483.clone();
                                let mut v484: i32 = v484.clone();
                                let mut v485: i32 = v485.clone();
                                let mut v486: i32 = v486.clone();
                                US10::US10_1(v481.clone(), v482, v483, v484, v485, v486)
                            }
                            US10::US10_0(v474, v475, v476, v477, v478, v479) => { // Ok
                                let mut v474: u8 = v474.clone();
                                let mut v475: i32 = v475.clone();
                                let mut v476: i32 = v476.clone();
                                let mut v477: i32 = v477.clone();
                                let mut v478: i32 = v478.clone();
                                let mut v479: i32 = v479.clone();
                                US10::US10_0(b'"', v475, v476, v477, v478, v479)
                            }
                            _ => unreachable!(),
                        };
                        let mut v587: US10 = match &v489 {
                            US10::US10_1(v496, v497, v498, v499, v500, v501) => { // Error
                                let mut v496: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v496.clone();
                                let mut v497: i32 = v497.clone();
                                let mut v498: i32 = v498.clone();
                                let mut v499: i32 = v499.clone();
                                let mut v500: i32 = v500.clone();
                                let mut v501: i32 = v501.clone();
                                let mut v519: US10 = if v421 {
                                    let mut v502: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                    US10::US10_1(v502.clone(), v416, v417, v418, v419, v420)
                                } else {
                                    let mut v504: u8 = v0.clone().as_bytes()[v416 as usize];
                                    let mut v505: bool = v504 == b'`';
                                    if v505 {
                                        let mut v506: i32 = v416 + 1i32;
                                        let mut v507: bool = b'\n' == v504;
                                        let (mut v511, mut v512, mut v513, mut v514): (i32, i32, i32, i32) = if v507 {
                                            let mut v508: i32 = v417 + v419;
                                            let mut v509: i32 = v418 + 1i32;
                                            (v508, v509, 1i32, v420)
                                        } else {
                                            let mut v510: i32 = v419 + 1i32;
                                            (v417, v418, v510, v420)
                                        };
                                        US10::US10_0(b'`', v506, v511, v512, v513, v514)
                                    } else {
                                        let mut v516: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                        US10::US10_1(v516.clone(), v416, v417, v418, v419, v420)
                                    }
                                };
                                let mut v553: US10 = match &v519 {
                                    US10::US10_1(v545, v546, v547, v548, v549, v550) => { // Error
                                        let mut v545: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v545.clone();
                                        let mut v546: i32 = v546.clone();
                                        let mut v547: i32 = v547.clone();
                                        let mut v548: i32 = v548.clone();
                                        let mut v549: i32 = v549.clone();
                                        let mut v550: i32 = v550.clone();
                                        US10::US10_1(v545.clone(), v546, v547, v548, v549, v550)
                                    }
                                    US10::US10_0(v520, v521, v522, v523, v524, v525) => { // Ok
                                        let mut v520: u8 = v520.clone();
                                        let mut v521: i32 = v521.clone();
                                        let mut v522: i32 = v522.clone();
                                        let mut v523: i32 = v523.clone();
                                        let mut v524: i32 = v524.clone();
                                        let mut v525: i32 = v525.clone();
                                        let mut v526: bool = v521 >= v525;
                                        if v526 {
                                            let mut v527: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                            US10::US10_1(v527.clone(), v521, v522, v523, v524, v525)
                                        } else {
                                            let mut v529: u8 = v0.clone().as_bytes()[v521 as usize];
                                            let mut v530: bool = v529 == b'"';
                                            if v530 {
                                                let mut v531: i32 = v521 + 1i32;
                                                let mut v532: bool = b'\n' == v529;
                                                let (mut v536, mut v537, mut v538, mut v539): (i32, i32, i32, i32) = if v532 {
                                                    let mut v533: i32 = v522 + v524;
                                                    let mut v534: i32 = v523 + 1i32;
                                                    (v533, v534, 1i32, v525)
                                                } else {
                                                    let mut v535: i32 = v524 + 1i32;
                                                    (v522, v523, v535, v525)
                                                };
                                                US10::US10_0(b'"', v531, v536, v537, v538, v539)
                                            } else {
                                                let mut v541: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                US10::US10_1(v541.clone(), v521, v522, v523, v524, v525)
                                            }
                                        }
                                    }
                                    _ => unreachable!(),
                                };
                                let mut v569: US10 = match &v553 {
                                    US10::US10_1(v561, v562, v563, v564, v565, v566) => { // Error
                                        let mut v561: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v561.clone();
                                        let mut v562: i32 = v562.clone();
                                        let mut v563: i32 = v563.clone();
                                        let mut v564: i32 = v564.clone();
                                        let mut v565: i32 = v565.clone();
                                        let mut v566: i32 = v566.clone();
                                        US10::US10_1(v561.clone(), v562, v563, v564, v565, v566)
                                    }
                                    US10::US10_0(v554, v555, v556, v557, v558, v559) => { // Ok
                                        let mut v554: u8 = v554.clone();
                                        let mut v555: i32 = v555.clone();
                                        let mut v556: i32 = v556.clone();
                                        let mut v557: i32 = v557.clone();
                                        let mut v558: i32 = v558.clone();
                                        let mut v559: i32 = v559.clone();
                                        US10::US10_0(b'"', v555, v556, v557, v558, v559)
                                    }
                                    _ => unreachable!(),
                                };
                                match &v569 {
                                    US10::US10_1(v576, v577, v578, v579, v580, v581) => { // Error
                                        let mut v576: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v576.clone();
                                        let mut v577: i32 = v577.clone();
                                        let mut v578: i32 = v578.clone();
                                        let mut v579: i32 = v579.clone();
                                        let mut v580: i32 = v580.clone();
                                        let mut v581: i32 = v581.clone();
                                        let mut v582: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                        US10::US10_1(v582.clone(), v416, v417, v418, v419, v420)
                                    }
                                    US10::US10_0(v570, v571, v572, v573, v574, v575) => { // Ok
                                        let mut v570: u8 = v570.clone();
                                        let mut v571: i32 = v571.clone();
                                        let mut v572: i32 = v572.clone();
                                        let mut v573: i32 = v573.clone();
                                        let mut v574: i32 = v574.clone();
                                        let mut v575: i32 = v575.clone();
                                        v569.clone()
                                    }
                                    _ => unreachable!(),
                                }
                            }
                            US10::US10_0(v490, v491, v492, v493, v494, v495) => { // Ok
                                let mut v490: u8 = v490.clone();
                                let mut v491: i32 = v491.clone();
                                let mut v492: i32 = v492.clone();
                                let mut v493: i32 = v493.clone();
                                let mut v494: i32 = v494.clone();
                                let mut v495: i32 = v495.clone();
                                v489.clone()
                            }
                            _ => unreachable!(),
                        };
                        match &v587 {
                            US10::US10_1(v595, v596, v597, v598, v599, v600) => { // Error
                                let mut v595: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v595.clone();
                                let mut v596: i32 = v596.clone();
                                let mut v597: i32 = v597.clone();
                                let mut v598: i32 = v598.clone();
                                let mut v599: i32 = v599.clone();
                                let mut v600: i32 = v600.clone();
                                let mut v601: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v176, v416, v595.clone(), v596, v597, v598, v599, v600);
                                US11::US11_1(v601.clone(), v416, v417, v418, v419, v420)
                            }
                            US10::US10_0(v588, v589, v590, v591, v592, v593) => { // Ok
                                let mut v588: u8 = v588.clone();
                                let mut v589: i32 = v589.clone();
                                let mut v590: i32 = v590.clone();
                                let mut v591: i32 = v591.clone();
                                let mut v592: i32 = v592.clone();
                                let mut v593: i32 = v593.clone();
                                US11::US11_0(v415.clone(), v589, v590, v591, v592, v593)
                            }
                            _ => unreachable!(),
                        }
                    }
                    _ => unreachable!(),
                }
            }
            _ => unreachable!(),
        };
        let mut v1164: US11 = match &v806 {
            US11::US11_1(v813, v814, v815, v816, v817, v818) => { // Error
                let mut v813: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v813.clone();
                let mut v814: i32 = v814.clone();
                let mut v815: i32 = v815.clone();
                let mut v816: i32 = v816.clone();
                let mut v817: i32 = v817.clone();
                let mut v818: i32 = v818.clone();
                let mut v836: US10 = if v8 {
                    let mut v819: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                    US10::US10_1(v819.clone(), v3, v4, v5, v6, v7)
                } else {
                    let mut v821: u8 = v0.clone().as_bytes()[v3 as usize];
                    let mut v822: bool = v821 == b'"';
                    if v822 {
                        let mut v823: i32 = v3 + 1i32;
                        let mut v824: bool = b'\n' == v821;
                        let (mut v828, mut v829, mut v830, mut v831): (i32, i32, i32, i32) = if v824 {
                            let mut v825: i32 = v4 + v6;
                            let mut v826: i32 = v5 + 1i32;
                            (v825, v826, 1i32, v7)
                        } else {
                            let mut v827: i32 = v6 + 1i32;
                            (v4, v5, v827, v7)
                        };
                        US10::US10_0(b'"', v823, v828, v829, v830, v831)
                    } else {
                        let mut v833: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                        US10::US10_1(v833.clone(), v3, v4, v5, v6, v7)
                    }
                };
                match &v836 {
                    US10::US10_1(v1154, v1155, v1156, v1157, v1158, v1159) => { // Error
                        let mut v1154: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1154.clone();
                        let mut v1155: i32 = v1155.clone();
                        let mut v1156: i32 = v1156.clone();
                        let mut v1157: i32 = v1157.clone();
                        let mut v1158: i32 = v1158.clone();
                        let mut v1159: i32 = v1159.clone();
                        US11::US11_1(v1154.clone(), v1155, v1156, v1157, v1158, v1159)
                    }
                    US10::US10_0(v837, v838, v839, v840, v841, v842) => { // Ok
                        let mut v837: u8 = v837.clone();
                        let mut v838: i32 = v838.clone();
                        let mut v839: i32 = v839.clone();
                        let mut v840: i32 = v840.clone();
                        let mut v841: i32 = v841.clone();
                        let mut v842: i32 = v842.clone();
                        let (mut v843, mut v844, mut v845, mut v846, mut v847): (i32, i32, i32, i32, i32) = method111(v839, v840, v841, v842, v0.clone(), v838);
                        let mut v848: bool = v843 > v838;
                        let mut v858: US11 = if v848 {
                            let mut v849: bool = v838 >= v843;
                            let mut v854: Rc<str> = if v849 {
                                let mut v850: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                v850.clone()
                            } else {
                                let mut v851: bool = v838 == v843;
                                let mut v852: i32 = v843 - 1i32;
                                let mut v853: Rc<str> = string_slice(&v0.clone(), v838 as i64, v852 as i64);
                                v853.clone()
                            };
                            US11::US11_0(v854.clone(), v843, v844, v845, v846, v847)
                        } else {
                            let mut v856: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                            US11::US11_1(v856.clone(), v838, v839, v840, v841, v842)
                        };
                        let mut v1043: US11 = match &v858 {
                            US11::US11_1(v865, v866, v867, v868, v869, v870) => { // Error
                                let mut v865: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v865.clone();
                                let mut v866: i32 = v866.clone();
                                let mut v867: i32 = v867.clone();
                                let mut v868: i32 = v868.clone();
                                let mut v869: i32 = v869.clone();
                                let mut v870: i32 = v870.clone();
                                let mut v871: bool = v838 >= v842;
                                let mut v889: US10 = if v871 {
                                    let mut v872: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                    US10::US10_1(v872.clone(), v838, v839, v840, v841, v842)
                                } else {
                                    let mut v874: u8 = v0.clone().as_bytes()[v838 as usize];
                                    let mut v875: bool = v874 == b'\\';
                                    if v875 {
                                        let mut v876: i32 = v838 + 1i32;
                                        let mut v877: bool = b'\n' == v874;
                                        let (mut v881, mut v882, mut v883, mut v884): (i32, i32, i32, i32) = if v877 {
                                            let mut v878: i32 = v839 + v841;
                                            let mut v879: i32 = v840 + 1i32;
                                            (v878, v879, 1i32, v842)
                                        } else {
                                            let mut v880: i32 = v841 + 1i32;
                                            (v839, v840, v880, v842)
                                        };
                                        US10::US10_0(b'\\', v876, v881, v882, v883, v884)
                                    } else {
                                        let mut v886: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                        US10::US10_1(v886.clone(), v838, v839, v840, v841, v842)
                                    }
                                };
                                let mut v919: US10 = match &v889 {
                                    US10::US10_1(v911, v912, v913, v914, v915, v916) => { // Error
                                        let mut v911: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v911.clone();
                                        let mut v912: i32 = v912.clone();
                                        let mut v913: i32 = v913.clone();
                                        let mut v914: i32 = v914.clone();
                                        let mut v915: i32 = v915.clone();
                                        let mut v916: i32 = v916.clone();
                                        US10::US10_1(v911.clone(), v912, v913, v914, v915, v916)
                                    }
                                    US10::US10_0(v890, v891, v892, v893, v894, v895) => { // Ok
                                        let mut v890: u8 = v890.clone();
                                        let mut v891: i32 = v891.clone();
                                        let mut v892: i32 = v892.clone();
                                        let mut v893: i32 = v893.clone();
                                        let mut v894: i32 = v894.clone();
                                        let mut v895: i32 = v895.clone();
                                        let mut v896: bool = v891 >= v895;
                                        if v896 {
                                            let mut v897: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                            US10::US10_1(v897.clone(), v891, v892, v893, v894, v895)
                                        } else {
                                            let mut v899: u8 = v0.clone().as_bytes()[v891 as usize];
                                            let mut v900: i32 = v891 + 1i32;
                                            let mut v901: bool = b'\n' == v899;
                                            let (mut v905, mut v906, mut v907, mut v908): (i32, i32, i32, i32) = if v901 {
                                                let mut v902: i32 = v892 + v894;
                                                let mut v903: i32 = v893 + 1i32;
                                                (v902, v903, 1i32, v895)
                                            } else {
                                                let mut v904: i32 = v894 + 1i32;
                                                (v892, v893, v904, v895)
                                            };
                                            US10::US10_0(v899, v900, v905, v906, v907, v908)
                                        }
                                    }
                                    _ => unreachable!(),
                                };
                                let mut v941: US11 = match &v919 {
                                    US10::US10_1(v933, v934, v935, v936, v937, v938) => { // Error
                                        let mut v933: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v933.clone();
                                        let mut v934: i32 = v934.clone();
                                        let mut v935: i32 = v935.clone();
                                        let mut v936: i32 = v936.clone();
                                        let mut v937: i32 = v937.clone();
                                        let mut v938: i32 = v938.clone();
                                        US11::US11_1(v933.clone(), v934, v935, v936, v937, v938)
                                    }
                                    US10::US10_0(v920, v921, v922, v923, v924, v925) => { // Ok
                                        let mut v920: u8 = v920.clone();
                                        let mut v921: i32 = v921.clone();
                                        let mut v922: i32 = v922.clone();
                                        let mut v923: i32 = v923.clone();
                                        let mut v924: i32 = v924.clone();
                                        let mut v925: i32 = v925.clone();
                                        let mut v926: bool = v838 >= v921;
                                        let mut v931: Rc<str> = if v926 {
                                            let mut v927: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            v927.clone()
                                        } else {
                                            let mut v928: bool = v838 == v921;
                                            let mut v929: i32 = v921 - 1i32;
                                            let mut v930: Rc<str> = string_slice(&v0.clone(), v838 as i64, v929 as i64);
                                            v930.clone()
                                        };
                                        US11::US11_0(v931.clone(), v921, v922, v923, v924, v925)
                                    }
                                    _ => unreachable!(),
                                };
                                match &v941 {
                                    US11::US11_1(v948, v949, v950, v951, v952, v953) => { // Error
                                        let mut v948: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v948.clone();
                                        let mut v949: i32 = v949.clone();
                                        let mut v950: i32 = v950.clone();
                                        let mut v951: i32 = v951.clone();
                                        let mut v952: i32 = v952.clone();
                                        let mut v953: i32 = v953.clone();
                                        let mut v971: US10 = if v871 {
                                            let mut v954: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                            US10::US10_1(v954.clone(), v838, v839, v840, v841, v842)
                                        } else {
                                            let mut v956: u8 = v0.clone().as_bytes()[v838 as usize];
                                            let mut v957: bool = v956 == b'`';
                                            if v957 {
                                                let mut v958: i32 = v838 + 1i32;
                                                let mut v959: bool = b'\n' == v956;
                                                let (mut v963, mut v964, mut v965, mut v966): (i32, i32, i32, i32) = if v959 {
                                                    let mut v960: i32 = v839 + v841;
                                                    let mut v961: i32 = v840 + 1i32;
                                                    (v960, v961, 1i32, v842)
                                                } else {
                                                    let mut v962: i32 = v841 + 1i32;
                                                    (v839, v840, v962, v842)
                                                };
                                                US10::US10_0(b'`', v958, v963, v964, v965, v966)
                                            } else {
                                                let mut v968: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                US10::US10_1(v968.clone(), v838, v839, v840, v841, v842)
                                            }
                                        };
                                        let mut v1001: US10 = match &v971 {
                                            US10::US10_1(v993, v994, v995, v996, v997, v998) => { // Error
                                                let mut v993: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v993.clone();
                                                let mut v994: i32 = v994.clone();
                                                let mut v995: i32 = v995.clone();
                                                let mut v996: i32 = v996.clone();
                                                let mut v997: i32 = v997.clone();
                                                let mut v998: i32 = v998.clone();
                                                US10::US10_1(v993.clone(), v994, v995, v996, v997, v998)
                                            }
                                            US10::US10_0(v972, v973, v974, v975, v976, v977) => { // Ok
                                                let mut v972: u8 = v972.clone();
                                                let mut v973: i32 = v973.clone();
                                                let mut v974: i32 = v974.clone();
                                                let mut v975: i32 = v975.clone();
                                                let mut v976: i32 = v976.clone();
                                                let mut v977: i32 = v977.clone();
                                                let mut v978: bool = v973 >= v977;
                                                if v978 {
                                                    let mut v979: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                    US10::US10_1(v979.clone(), v973, v974, v975, v976, v977)
                                                } else {
                                                    let mut v981: u8 = v0.clone().as_bytes()[v973 as usize];
                                                    let mut v982: i32 = v973 + 1i32;
                                                    let mut v983: bool = b'\n' == v981;
                                                    let (mut v987, mut v988, mut v989, mut v990): (i32, i32, i32, i32) = if v983 {
                                                        let mut v984: i32 = v974 + v976;
                                                        let mut v985: i32 = v975 + 1i32;
                                                        (v984, v985, 1i32, v977)
                                                    } else {
                                                        let mut v986: i32 = v976 + 1i32;
                                                        (v974, v975, v986, v977)
                                                    };
                                                    US10::US10_0(v981, v982, v987, v988, v989, v990)
                                                }
                                            }
                                            _ => unreachable!(),
                                        };
                                        let mut v1023: US11 = match &v1001 {
                                            US10::US10_1(v1015, v1016, v1017, v1018, v1019, v1020) => { // Error
                                                let mut v1015: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1015.clone();
                                                let mut v1016: i32 = v1016.clone();
                                                let mut v1017: i32 = v1017.clone();
                                                let mut v1018: i32 = v1018.clone();
                                                let mut v1019: i32 = v1019.clone();
                                                let mut v1020: i32 = v1020.clone();
                                                US11::US11_1(v1015.clone(), v1016, v1017, v1018, v1019, v1020)
                                            }
                                            US10::US10_0(v1002, v1003, v1004, v1005, v1006, v1007) => { // Ok
                                                let mut v1002: u8 = v1002.clone();
                                                let mut v1003: i32 = v1003.clone();
                                                let mut v1004: i32 = v1004.clone();
                                                let mut v1005: i32 = v1005.clone();
                                                let mut v1006: i32 = v1006.clone();
                                                let mut v1007: i32 = v1007.clone();
                                                let mut v1008: bool = v838 >= v1003;
                                                let mut v1013: Rc<str> = if v1008 {
                                                    let mut v1009: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                    v1009.clone()
                                                } else {
                                                    let mut v1010: bool = v838 == v1003;
                                                    let mut v1011: i32 = v1003 - 1i32;
                                                    let mut v1012: Rc<str> = string_slice(&v0.clone(), v838 as i64, v1011 as i64);
                                                    v1012.clone()
                                                };
                                                US11::US11_0(v1013.clone(), v1003, v1004, v1005, v1006, v1007)
                                            }
                                            _ => unreachable!(),
                                        };
                                        match &v1023 {
                                            US11::US11_1(v1030, v1031, v1032, v1033, v1034, v1035) => { // Error
                                                let mut v1030: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1030.clone();
                                                let mut v1031: i32 = v1031.clone();
                                                let mut v1032: i32 = v1032.clone();
                                                let mut v1033: i32 = v1033.clone();
                                                let mut v1034: i32 = v1034.clone();
                                                let mut v1035: i32 = v1035.clone();
                                                let mut v1036: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                                US11::US11_1(v1036.clone(), v838, v839, v840, v841, v842)
                                            }
                                            US11::US11_0(v1024, v1025, v1026, v1027, v1028, v1029) => { // Ok
                                                let mut v1024: Rc<str> = v1024.clone();
                                                let mut v1025: i32 = v1025.clone();
                                                let mut v1026: i32 = v1026.clone();
                                                let mut v1027: i32 = v1027.clone();
                                                let mut v1028: i32 = v1028.clone();
                                                let mut v1029: i32 = v1029.clone();
                                                v1023.clone()
                                            }
                                            _ => unreachable!(),
                                        }
                                    }
                                    US11::US11_0(v942, v943, v944, v945, v946, v947) => { // Ok
                                        let mut v942: Rc<str> = v942.clone();
                                        let mut v943: i32 = v943.clone();
                                        let mut v944: i32 = v944.clone();
                                        let mut v945: i32 = v945.clone();
                                        let mut v946: i32 = v946.clone();
                                        let mut v947: i32 = v947.clone();
                                        v941.clone()
                                    }
                                    _ => unreachable!(),
                                }
                            }
                            US11::US11_0(v859, v860, v861, v862, v863, v864) => { // Ok
                                let mut v859: Rc<str> = v859.clone();
                                let mut v860: i32 = v860.clone();
                                let mut v861: i32 = v861.clone();
                                let mut v862: i32 = v862.clone();
                                let mut v863: i32 = v863.clone();
                                let mut v864: i32 = v864.clone();
                                v858.clone()
                            }
                            _ => unreachable!(),
                        };
                        let mut v1066: US11 = match &v1043 {
                            US11::US11_1(v1044, v1045, v1046, v1047, v1048, v1049) => { // Error
                                let mut v1044: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1044.clone();
                                let mut v1045: i32 = v1045.clone();
                                let mut v1046: i32 = v1046.clone();
                                let mut v1047: i32 = v1047.clone();
                                let mut v1048: i32 = v1048.clone();
                                let mut v1049: i32 = v1049.clone();
                                let mut v1050: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                US11::US11_0(v1050.clone(), v838, v839, v840, v841, v842)
                            }
                            US11::US11_0(v1052, v1053, v1054, v1055, v1056, v1057) => { // Ok
                                let mut v1052: Rc<str> = v1052.clone();
                                let mut v1053: i32 = v1053.clone();
                                let mut v1054: i32 = v1054.clone();
                                let mut v1055: i32 = v1055.clone();
                                let mut v1056: i32 = v1056.clone();
                                let mut v1057: i32 = v1057.clone();
                                let mut v1058: bool = v1053 == v838;
                                if v1058 {
                                    let mut v1059: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                    US11::US11_1(v1059.clone(), v838, v839, v840, v841, v842)
                                } else {
                                    let mut v1061: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                    let mut v1062: i32 = 0i32;
                                    method117(v0.clone(), v1061.clone(), v1052.clone(), v1062, v1053, v1054, v1055, v1056, v1057)
                                }
                            }
                            _ => unreachable!(),
                        };
                        match &v1066 {
                            US11::US11_1(v1109, v1110, v1111, v1112, v1113, v1114) => { // Error
                                let mut v1109: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1109.clone();
                                let mut v1110: i32 = v1110.clone();
                                let mut v1111: i32 = v1111.clone();
                                let mut v1112: i32 = v1112.clone();
                                let mut v1113: i32 = v1113.clone();
                                let mut v1114: i32 = v1114.clone();
                                let mut v1115: bool = v838 >= v842;
                                let mut v1133: US10 = if v1115 {
                                    let mut v1116: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                    US10::US10_1(v1116.clone(), v838, v839, v840, v841, v842)
                                } else {
                                    let mut v1118: u8 = v0.clone().as_bytes()[v838 as usize];
                                    let mut v1119: bool = v1118 == b'"';
                                    if v1119 {
                                        let mut v1120: i32 = v838 + 1i32;
                                        let mut v1121: bool = b'\n' == v1118;
                                        let (mut v1125, mut v1126, mut v1127, mut v1128): (i32, i32, i32, i32) = if v1121 {
                                            let mut v1122: i32 = v839 + v841;
                                            let mut v1123: i32 = v840 + 1i32;
                                            (v1122, v1123, 1i32, v842)
                                        } else {
                                            let mut v1124: i32 = v841 + 1i32;
                                            (v839, v840, v1124, v842)
                                        };
                                        US10::US10_0(b'"', v1120, v1125, v1126, v1127, v1128)
                                    } else {
                                        let mut v1130: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                        US10::US10_1(v1130.clone(), v838, v839, v840, v841, v842)
                                    }
                                };
                                match &v1133 {
                                    US10::US10_1(v1142, v1143, v1144, v1145, v1146, v1147) => { // Error
                                        let mut v1142: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1142.clone();
                                        let mut v1143: i32 = v1143.clone();
                                        let mut v1144: i32 = v1144.clone();
                                        let mut v1145: i32 = v1145.clone();
                                        let mut v1146: i32 = v1146.clone();
                                        let mut v1147: i32 = v1147.clone();
                                        let mut v1148: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                                        US11::US11_1(v1148.clone(), v838, v839, v840, v841, v842)
                                    }
                                    US10::US10_0(v1134, v1135, v1136, v1137, v1138, v1139) => { // Ok
                                        let mut v1134: u8 = v1134.clone();
                                        let mut v1135: i32 = v1135.clone();
                                        let mut v1136: i32 = v1136.clone();
                                        let mut v1137: i32 = v1137.clone();
                                        let mut v1138: i32 = v1138.clone();
                                        let mut v1139: i32 = v1139.clone();
                                        let mut v1140: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                        US11::US11_0(v1140.clone(), v1135, v1136, v1137, v1138, v1139)
                                    }
                                    _ => unreachable!(),
                                }
                            }
                            US11::US11_0(v1067, v1068, v1069, v1070, v1071, v1072) => { // Ok
                                let mut v1067: Rc<str> = v1067.clone();
                                let mut v1068: i32 = v1068.clone();
                                let mut v1069: i32 = v1069.clone();
                                let mut v1070: i32 = v1070.clone();
                                let mut v1071: i32 = v1071.clone();
                                let mut v1072: i32 = v1072.clone();
                                let mut v1073: bool = v1068 >= v1072;
                                let mut v1091: US10 = if v1073 {
                                    let mut v1074: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                    US10::US10_1(v1074.clone(), v1068, v1069, v1070, v1071, v1072)
                                } else {
                                    let mut v1076: u8 = v0.clone().as_bytes()[v1068 as usize];
                                    let mut v1077: bool = v1076 == b'"';
                                    if v1077 {
                                        let mut v1078: i32 = v1068 + 1i32;
                                        let mut v1079: bool = b'\n' == v1076;
                                        let (mut v1083, mut v1084, mut v1085, mut v1086): (i32, i32, i32, i32) = if v1079 {
                                            let mut v1080: i32 = v1069 + v1071;
                                            let mut v1081: i32 = v1070 + 1i32;
                                            (v1080, v1081, 1i32, v1072)
                                        } else {
                                            let mut v1082: i32 = v1071 + 1i32;
                                            (v1069, v1070, v1082, v1072)
                                        };
                                        US10::US10_0(b'"', v1078, v1083, v1084, v1085, v1086)
                                    } else {
                                        let mut v1088: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                        US10::US10_1(v1088.clone(), v1068, v1069, v1070, v1071, v1072)
                                    }
                                };
                                match &v1091 {
                                    US10::US10_1(v1099, v1100, v1101, v1102, v1103, v1104) => { // Error
                                        let mut v1099: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1099.clone();
                                        let mut v1100: i32 = v1100.clone();
                                        let mut v1101: i32 = v1101.clone();
                                        let mut v1102: i32 = v1102.clone();
                                        let mut v1103: i32 = v1103.clone();
                                        let mut v1104: i32 = v1104.clone();
                                        let mut v1105: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v838, v1068, v1099.clone(), v1100, v1101, v1102, v1103, v1104);
                                        US11::US11_1(v1105.clone(), v1068, v1069, v1070, v1071, v1072)
                                    }
                                    US10::US10_0(v1092, v1093, v1094, v1095, v1096, v1097) => { // Ok
                                        let mut v1092: u8 = v1092.clone();
                                        let mut v1093: i32 = v1093.clone();
                                        let mut v1094: i32 = v1094.clone();
                                        let mut v1095: i32 = v1095.clone();
                                        let mut v1096: i32 = v1096.clone();
                                        let mut v1097: i32 = v1097.clone();
                                        US11::US11_0(v1067.clone(), v1093, v1094, v1095, v1096, v1097)
                                    }
                                    _ => unreachable!(),
                                }
                            }
                            _ => unreachable!(),
                        }
                    }
                    _ => unreachable!(),
                }
            }
            US11::US11_0(v807, v808, v809, v810, v811, v812) => { // Ok
                let mut v807: Rc<str> = v807.clone();
                let mut v808: i32 = v808.clone();
                let mut v809: i32 = v809.clone();
                let mut v810: i32 = v810.clone();
                let mut v811: i32 = v811.clone();
                let mut v812: i32 = v812.clone();
                v806.clone()
            }
            _ => unreachable!(),
        };
        let mut v1194: US11 = match &v1164 {
            US11::US11_1(v1171, v1172, v1173, v1174, v1175, v1176) => { // Error
                let mut v1171: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1171.clone();
                let mut v1172: i32 = v1172.clone();
                let mut v1173: i32 = v1173.clone();
                let mut v1174: i32 = v1174.clone();
                let mut v1175: i32 = v1175.clone();
                let mut v1176: i32 = v1176.clone();
                let (mut v1177, mut v1178, mut v1179, mut v1180, mut v1181): (i32, i32, i32, i32, i32) = method124(v4, v5, v6, v7, v0.clone(), v3);
                let mut v1182: bool = v1177 > v3;
                if v1182 {
                    let mut v1183: bool = v3 >= v1177;
                    let mut v1188: Rc<str> = if v1183 {
                        let mut v1184: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        v1184.clone()
                    } else {
                        let mut v1185: bool = v3 == v1177;
                        let mut v1186: i32 = v1177 - 1i32;
                        let mut v1187: Rc<str> = string_slice(&v0.clone(), v3 as i64, v1186 as i64);
                        v1187.clone()
                    };
                    US11::US11_0(v1188.clone(), v1177, v1178, v1179, v1180, v1181)
                } else {
                    let mut v1190: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                    US11::US11_1(v1190.clone(), v3, v4, v5, v6, v7)
                }
            }
            US11::US11_0(v1165, v1166, v1167, v1168, v1169, v1170) => { // Ok
                let mut v1165: Rc<str> = v1165.clone();
                let mut v1166: i32 = v1166.clone();
                let mut v1167: i32 = v1167.clone();
                let mut v1168: i32 = v1168.clone();
                let mut v1169: i32 = v1169.clone();
                let mut v1170: i32 = v1170.clone();
                v1164.clone()
            }
            _ => unreachable!(),
        };
        let mut v1229: US11 = match &v1194 {
            US11::US11_1(v1201, v1202, v1203, v1204, v1205, v1206) => { // Error
                let mut v1201: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1201.clone();
                let mut v1202: i32 = v1202.clone();
                let mut v1203: i32 = v1203.clone();
                let mut v1204: i32 = v1204.clone();
                let mut v1205: i32 = v1205.clone();
                let mut v1206: i32 = v1206.clone();
                let mut v1207: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
                let mut v1208: US19 = method120(v0.clone(), v1207.clone(), v3, v4, v5, v6, v7);
                match &v1208 {
                    US19::US19_1(v1219, v1220, v1221, v1222, v1223, v1224) => { // Error
                        let mut v1219: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1219.clone();
                        let mut v1220: i32 = v1220.clone();
                        let mut v1221: i32 = v1221.clone();
                        let mut v1222: i32 = v1222.clone();
                        let mut v1223: i32 = v1223.clone();
                        let mut v1224: i32 = v1224.clone();
                        US11::US11_1(v1219.clone(), v1220, v1221, v1222, v1223, v1224)
                    }
                    US19::US19_0(v1209, v1210, v1211, v1212, v1213, v1214) => { // Ok
                        let mut v1209: Rc<UH0> = v1209.clone();
                        let mut v1210: i32 = v1210.clone();
                        let mut v1211: i32 = v1211.clone();
                        let mut v1212: i32 = v1212.clone();
                        let mut v1213: i32 = v1213.clone();
                        let mut v1214: i32 = v1214.clone();
                        let mut v1215: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let (mut v1216, mut v1217): (Rc<str>, Rc<str>) = method122(v1209.clone(), v1215.clone());
                        US11::US11_0(v1216.clone(), v1210, v1211, v1212, v1213, v1214)
                    }
                    _ => unreachable!(),
                }
            }
            US11::US11_0(v1195, v1196, v1197, v1198, v1199, v1200) => { // Ok
                let mut v1195: Rc<str> = v1195.clone();
                let mut v1196: i32 = v1196.clone();
                let mut v1197: i32 = v1197.clone();
                let mut v1198: i32 = v1198.clone();
                let mut v1199: i32 = v1199.clone();
                let mut v1200: i32 = v1200.clone();
                v1194.clone()
            }
            _ => unreachable!(),
        };
        let mut v1240: US11 = match &v1229 {
            US11::US11_0(v1230, v1231, v1232, v1233, v1234, v1235) => { // Ok
                let mut v1230: Rc<str> = v1230.clone();
                let mut v1231: i32 = v1231.clone();
                let mut v1232: i32 = v1232.clone();
                let mut v1233: i32 = v1233.clone();
                let mut v1234: i32 = v1234.clone();
                let mut v1235: i32 = v1235.clone();
                let mut v1236: bool = v1231 == v3;
                if v1236 {
                    let mut v1237: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure48();
                    US11::US11_1(v1237.clone(), v3, v4, v5, v6, v7)
                } else {
                    v1229.clone()
                }
            }
            _ => {
                v1229.clone()
            }
        };
        match &v1240 {
            US11::US11_1(v1241, v1242, v1243, v1244, v1245, v1246) => { // Error
                let mut v1241: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1241.clone();
                let mut v1242: i32 = v1242.clone();
                let mut v1243: i32 = v1243.clone();
                let mut v1244: i32 = v1244.clone();
                let mut v1245: i32 = v1245.clone();
                let mut v1246: i32 = v1246.clone();
                let mut v1266: Rc<str> = match &*v2 {
                    UH0::UH0_0 => { // Nil
                        v1.clone()
                    }
                    _ => {
                        let mut v1264: Rc<str> = match &*v2 {
                            UH0::UH0_1(v1247, v1248) => { // Cons
                                let mut v1247: Rc<str> = v1247.clone();
                                let mut v1248: Rc<UH0> = v1248.clone();
                                match &*v1248 {
                                    UH0::UH0_1(v1249, v1250) => { // Cons
                                        let mut v1249: Rc<str> = v1249.clone();
                                        let mut v1250: Rc<UH0> = v1250.clone();
                                        match &*v1250 {
                                            UH0::UH0_1(v1251, v1252) => { // Cons
                                                let mut v1251: Rc<str> = v1251.clone();
                                                let mut v1252: Rc<UH0> = v1252.clone();
                                                let mut v1253: i32 = 0i32;
                                                let mut v1254: i32 = method126(v2.clone(), v1253);
                                                let mut v1255: Rc<RefCell<Vec<u8>>> = Rc::new(RefCell::new(vec![0u8; v1254 as usize]));
                                                let mut v1256: i32 = method127(v1255.clone(), v2.clone(), v1254);
                                                let mut v1257: Rc<str> = unsafe { Rc::<str>::from(std::str::from_utf8_unchecked(&v1255.borrow())) };
                                                v1257.clone()
                                            }
                                            _ => {
                                                let mut v1258: bool = true;
                                                method128(v1258, v2.clone())
                                            }
                                        }
                                    }
                                    _ => {
                                        let mut v1261: bool = true;
                                        method128(v1261, v2.clone())
                                    }
                                }
                            }
                            _ => unreachable!(),
                        };
                        let mut v1265: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v1264));
                        v1265.clone()
                    }
                };
                return US11::US11_0(v1266.clone(), v3, v4, v5, v6, v7);
            }
            US11::US11_0(v1268, v1269, v1270, v1271, v1272, v1273) => { // Ok
                let mut v1268: Rc<str> = v1268.clone();
                let mut v1269: i32 = v1269.clone();
                let mut v1270: i32 = v1270.clone();
                let mut v1271: i32 = v1271.clone();
                let mut v1272: i32 = v1272.clone();
                let mut v1273: i32 = v1273.clone();
                let mut v1274: bool = v1269 > v3;
                if v1274 {
                    let mut v1275: Rc<UH0> = Rc::new(UH0::UH0_1(v1268.clone(), v2.clone()));
                    (v0, v1, v2, v3, v4, v5, v6, v7) = (v0.clone(), v1.clone(), v1275.clone(), v1269, v1270, v1271, v1272, v1273);
                    continue;
                } else {
                    let mut v1277: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure49();
                    return US11::US11_1(v1277.clone(), v3, v4, v5, v6, v7);
                }
            }
            _ => unreachable!(),
        }
    }
}
fn closure50() -> Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = Rc::new(move |mut v0: Rc<str>, mut v1: i32, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32| -> Rc<str> {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("parsing.sep_by / separator consumed no text"); } LIT.with(|lit| lit.clone()) };
        v6.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method130(mut v0: Rc<str>, mut v1: Rc<UH0>, mut v2: i32, mut v3: i32, mut v4: i32, mut v5: i32, mut v6: i32) -> US19 {
    loop {
        let mut v7: bool = v2 >= v6;
        let (mut v20, mut v21, mut v22, mut v23, mut v24): (i32, i32, i32, i32, i32) = if v7 {
            (v2, v3, v4, v5, v6)
        } else {
            let mut v8: i32 = (v0.clone().len() as i32);
            let mut v9: i32 = method109(v0.clone(), v8, v2);
            let mut v10: bool = v9 > v6;
            let mut v11: i32 = if v10 {
                v6
            } else {
                v9
            };
            let mut v12: i32 = v11 - v2;
            let mut v13: bool = v12 == 0i32;
            if v13 {
                (v2, v3, v4, v5, v6)
            } else {
                let mut v14: i32 = v5 + v12;
                (v11, v3, v4, v14, v6)
            }
        };
        let mut v25: bool = v20 == v2;
        let mut v26: bool = v25 != true;
        let mut v30: US12 = if v26 {
            US12::US12_0(v20, v21, v22, v23, v24)
        } else {
            let mut v28: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure30();
            US12::US12_1(v28.clone(), v2, v3, v4, v5, v6)
        };
        match &v30 {
            US12::US12_1(v31, v32, v33, v34, v35, v36) => { // Error
                let mut v31: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v31.clone();
                let mut v32: i32 = v32.clone();
                let mut v33: i32 = v33.clone();
                let mut v34: i32 = v34.clone();
                let mut v35: i32 = v35.clone();
                let mut v36: i32 = v36.clone();
                let mut v37: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
                let mut v38: Rc<UH0> = method121(v1.clone(), v37.clone());
                return US19::US19_0(v38.clone(), v2, v3, v4, v5, v6);
            }
            US12::US12_0(v40, v41, v42, v43, v44) => { // Ok
                let mut v40: i32 = v40.clone();
                let mut v41: i32 = v41.clone();
                let mut v42: i32 = v42.clone();
                let mut v43: i32 = v43.clone();
                let mut v44: i32 = v44.clone();
                let mut v45: bool = v40 == v2;
                if v45 {
                    let mut v46: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure50();
                    return US19::US19_1(v46.clone(), v2, v3, v4, v5, v6);
                } else {
                    let mut v48: bool = v40 >= v44;
                    let mut v66: US10 = if v48 {
                        let mut v49: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                        US10::US10_1(v49.clone(), v40, v41, v42, v43, v44)
                    } else {
                        let mut v51: u8 = v0.clone().as_bytes()[v40 as usize];
                        let mut v52: bool = v51 == b'\\';
                        if v52 {
                            let mut v53: i32 = v40 + 1i32;
                            let mut v54: bool = b'\n' == v51;
                            let (mut v58, mut v59, mut v60, mut v61): (i32, i32, i32, i32) = if v54 {
                                let mut v55: i32 = v41 + v43;
                                let mut v56: i32 = v42 + 1i32;
                                (v55, v56, 1i32, v44)
                            } else {
                                let mut v57: i32 = v43 + 1i32;
                                (v41, v42, v57, v44)
                            };
                            US10::US10_0(b'\\', v53, v58, v59, v60, v61)
                        } else {
                            let mut v63: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                            US10::US10_1(v63.clone(), v40, v41, v42, v43, v44)
                        }
                    };
                    let mut v100: US10 = match &v66 {
                        US10::US10_1(v92, v93, v94, v95, v96, v97) => { // Error
                            let mut v92: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v92.clone();
                            let mut v93: i32 = v93.clone();
                            let mut v94: i32 = v94.clone();
                            let mut v95: i32 = v95.clone();
                            let mut v96: i32 = v96.clone();
                            let mut v97: i32 = v97.clone();
                            US10::US10_1(v92.clone(), v93, v94, v95, v96, v97)
                        }
                        US10::US10_0(v67, v68, v69, v70, v71, v72) => { // Ok
                            let mut v67: u8 = v67.clone();
                            let mut v68: i32 = v68.clone();
                            let mut v69: i32 = v69.clone();
                            let mut v70: i32 = v70.clone();
                            let mut v71: i32 = v71.clone();
                            let mut v72: i32 = v72.clone();
                            let mut v73: bool = v68 >= v72;
                            if v73 {
                                let mut v74: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_1(v74.clone(), v68, v69, v70, v71, v72)
                            } else {
                                let mut v76: u8 = v0.clone().as_bytes()[v68 as usize];
                                let mut v77: bool = v76 == b'"';
                                if v77 {
                                    let mut v78: i32 = v68 + 1i32;
                                    let mut v79: bool = b'\n' == v76;
                                    let (mut v83, mut v84, mut v85, mut v86): (i32, i32, i32, i32) = if v79 {
                                        let mut v80: i32 = v69 + v71;
                                        let mut v81: i32 = v70 + 1i32;
                                        (v80, v81, 1i32, v72)
                                    } else {
                                        let mut v82: i32 = v71 + 1i32;
                                        (v69, v70, v82, v72)
                                    };
                                    US10::US10_0(b'"', v78, v83, v84, v85, v86)
                                } else {
                                    let mut v88: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_1(v88.clone(), v68, v69, v70, v71, v72)
                                }
                            }
                        }
                        _ => unreachable!(),
                    };
                    let mut v116: US10 = match &v100 {
                        US10::US10_1(v108, v109, v110, v111, v112, v113) => { // Error
                            let mut v108: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v108.clone();
                            let mut v109: i32 = v109.clone();
                            let mut v110: i32 = v110.clone();
                            let mut v111: i32 = v111.clone();
                            let mut v112: i32 = v112.clone();
                            let mut v113: i32 = v113.clone();
                            US10::US10_1(v108.clone(), v109, v110, v111, v112, v113)
                        }
                        US10::US10_0(v101, v102, v103, v104, v105, v106) => { // Ok
                            let mut v101: u8 = v101.clone();
                            let mut v102: i32 = v102.clone();
                            let mut v103: i32 = v103.clone();
                            let mut v104: i32 = v104.clone();
                            let mut v105: i32 = v105.clone();
                            let mut v106: i32 = v106.clone();
                            US10::US10_0(b'"', v102, v103, v104, v105, v106)
                        }
                        _ => unreachable!(),
                    };
                    let mut v214: US10 = match &v116 {
                        US10::US10_1(v123, v124, v125, v126, v127, v128) => { // Error
                            let mut v123: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v123.clone();
                            let mut v124: i32 = v124.clone();
                            let mut v125: i32 = v125.clone();
                            let mut v126: i32 = v126.clone();
                            let mut v127: i32 = v127.clone();
                            let mut v128: i32 = v128.clone();
                            let mut v146: US10 = if v48 {
                                let mut v129: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                US10::US10_1(v129.clone(), v40, v41, v42, v43, v44)
                            } else {
                                let mut v131: u8 = v0.clone().as_bytes()[v40 as usize];
                                let mut v132: bool = v131 == b'`';
                                if v132 {
                                    let mut v133: i32 = v40 + 1i32;
                                    let mut v134: bool = b'\n' == v131;
                                    let (mut v138, mut v139, mut v140, mut v141): (i32, i32, i32, i32) = if v134 {
                                        let mut v135: i32 = v41 + v43;
                                        let mut v136: i32 = v42 + 1i32;
                                        (v135, v136, 1i32, v44)
                                    } else {
                                        let mut v137: i32 = v43 + 1i32;
                                        (v41, v42, v137, v44)
                                    };
                                    US10::US10_0(b'`', v133, v138, v139, v140, v141)
                                } else {
                                    let mut v143: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                    US10::US10_1(v143.clone(), v40, v41, v42, v43, v44)
                                }
                            };
                            let mut v180: US10 = match &v146 {
                                US10::US10_1(v172, v173, v174, v175, v176, v177) => { // Error
                                    let mut v172: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v172.clone();
                                    let mut v173: i32 = v173.clone();
                                    let mut v174: i32 = v174.clone();
                                    let mut v175: i32 = v175.clone();
                                    let mut v176: i32 = v176.clone();
                                    let mut v177: i32 = v177.clone();
                                    US10::US10_1(v172.clone(), v173, v174, v175, v176, v177)
                                }
                                US10::US10_0(v147, v148, v149, v150, v151, v152) => { // Ok
                                    let mut v147: u8 = v147.clone();
                                    let mut v148: i32 = v148.clone();
                                    let mut v149: i32 = v149.clone();
                                    let mut v150: i32 = v150.clone();
                                    let mut v151: i32 = v151.clone();
                                    let mut v152: i32 = v152.clone();
                                    let mut v153: bool = v148 >= v152;
                                    if v153 {
                                        let mut v154: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                        US10::US10_1(v154.clone(), v148, v149, v150, v151, v152)
                                    } else {
                                        let mut v156: u8 = v0.clone().as_bytes()[v148 as usize];
                                        let mut v157: bool = v156 == b'"';
                                        if v157 {
                                            let mut v158: i32 = v148 + 1i32;
                                            let mut v159: bool = b'\n' == v156;
                                            let (mut v163, mut v164, mut v165, mut v166): (i32, i32, i32, i32) = if v159 {
                                                let mut v160: i32 = v149 + v151;
                                                let mut v161: i32 = v150 + 1i32;
                                                (v160, v161, 1i32, v152)
                                            } else {
                                                let mut v162: i32 = v151 + 1i32;
                                                (v149, v150, v162, v152)
                                            };
                                            US10::US10_0(b'"', v158, v163, v164, v165, v166)
                                        } else {
                                            let mut v168: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                            US10::US10_1(v168.clone(), v148, v149, v150, v151, v152)
                                        }
                                    }
                                }
                                _ => unreachable!(),
                            };
                            let mut v196: US10 = match &v180 {
                                US10::US10_1(v188, v189, v190, v191, v192, v193) => { // Error
                                    let mut v188: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v188.clone();
                                    let mut v189: i32 = v189.clone();
                                    let mut v190: i32 = v190.clone();
                                    let mut v191: i32 = v191.clone();
                                    let mut v192: i32 = v192.clone();
                                    let mut v193: i32 = v193.clone();
                                    US10::US10_1(v188.clone(), v189, v190, v191, v192, v193)
                                }
                                US10::US10_0(v181, v182, v183, v184, v185, v186) => { // Ok
                                    let mut v181: u8 = v181.clone();
                                    let mut v182: i32 = v182.clone();
                                    let mut v183: i32 = v183.clone();
                                    let mut v184: i32 = v184.clone();
                                    let mut v185: i32 = v185.clone();
                                    let mut v186: i32 = v186.clone();
                                    US10::US10_0(b'"', v182, v183, v184, v185, v186)
                                }
                                _ => unreachable!(),
                            };
                            match &v196 {
                                US10::US10_1(v203, v204, v205, v206, v207, v208) => { // Error
                                    let mut v203: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v203.clone();
                                    let mut v204: i32 = v204.clone();
                                    let mut v205: i32 = v205.clone();
                                    let mut v206: i32 = v206.clone();
                                    let mut v207: i32 = v207.clone();
                                    let mut v208: i32 = v208.clone();
                                    let mut v209: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US10::US10_1(v209.clone(), v40, v41, v42, v43, v44)
                                }
                                US10::US10_0(v197, v198, v199, v200, v201, v202) => { // Ok
                                    let mut v197: u8 = v197.clone();
                                    let mut v198: i32 = v198.clone();
                                    let mut v199: i32 = v199.clone();
                                    let mut v200: i32 = v200.clone();
                                    let mut v201: i32 = v201.clone();
                                    let mut v202: i32 = v202.clone();
                                    v196.clone()
                                }
                                _ => unreachable!(),
                            }
                        }
                        US10::US10_0(v117, v118, v119, v120, v121, v122) => { // Ok
                            let mut v117: u8 = v117.clone();
                            let mut v118: i32 = v118.clone();
                            let mut v119: i32 = v119.clone();
                            let mut v120: i32 = v120.clone();
                            let mut v121: i32 = v121.clone();
                            let mut v122: i32 = v122.clone();
                            v116.clone()
                        }
                        _ => unreachable!(),
                    };
                    let mut v846: US11 = match &v214 {
                        US10::US10_1(v838, v839, v840, v841, v842, v843) => { // Error
                            let mut v838: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v838.clone();
                            let mut v839: i32 = v839.clone();
                            let mut v840: i32 = v840.clone();
                            let mut v841: i32 = v841.clone();
                            let mut v842: i32 = v842.clone();
                            let mut v843: i32 = v843.clone();
                            US11::US11_1(v838.clone(), v839, v840, v841, v842, v843)
                        }
                        US10::US10_0(v215, v216, v217, v218, v219, v220) => { // Ok
                            let mut v215: u8 = v215.clone();
                            let mut v216: i32 = v216.clone();
                            let mut v217: i32 = v217.clone();
                            let mut v218: i32 = v218.clone();
                            let mut v219: i32 = v219.clone();
                            let mut v220: i32 = v220.clone();
                            let (mut v221, mut v222, mut v223, mut v224, mut v225): (i32, i32, i32, i32, i32) = method111(v217, v218, v219, v220, v0.clone(), v216);
                            let mut v226: bool = v221 > v216;
                            let mut v236: US11 = if v226 {
                                let mut v227: bool = v216 >= v221;
                                let mut v232: Rc<str> = if v227 {
                                    let mut v228: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v228.clone()
                                } else {
                                    let mut v229: bool = v216 == v221;
                                    let mut v230: i32 = v221 - 1i32;
                                    let mut v231: Rc<str> = string_slice(&v0.clone(), v216 as i64, v230 as i64);
                                    v231.clone()
                                };
                                US11::US11_0(v232.clone(), v221, v222, v223, v224, v225)
                            } else {
                                let mut v234: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                US11::US11_1(v234.clone(), v216, v217, v218, v219, v220)
                            };
                            let mut v431: US11 = match &v236 {
                                US11::US11_1(v243, v244, v245, v246, v247, v248) => { // Error
                                    let mut v243: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v243.clone();
                                    let mut v244: i32 = v244.clone();
                                    let mut v245: i32 = v245.clone();
                                    let mut v246: i32 = v246.clone();
                                    let mut v247: i32 = v247.clone();
                                    let mut v248: i32 = v248.clone();
                                    let mut v249: bool = v216 >= v220;
                                    let mut v267: US10 = if v249 {
                                        let mut v250: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                        US10::US10_1(v250.clone(), v216, v217, v218, v219, v220)
                                    } else {
                                        let mut v252: u8 = v0.clone().as_bytes()[v216 as usize];
                                        let mut v253: bool = v252 == b'\\';
                                        if v253 {
                                            let mut v254: i32 = v216 + 1i32;
                                            let mut v255: bool = b'\n' == v252;
                                            let (mut v259, mut v260, mut v261, mut v262): (i32, i32, i32, i32) = if v255 {
                                                let mut v256: i32 = v217 + v219;
                                                let mut v257: i32 = v218 + 1i32;
                                                (v256, v257, 1i32, v220)
                                            } else {
                                                let mut v258: i32 = v219 + 1i32;
                                                (v217, v218, v258, v220)
                                            };
                                            US10::US10_0(b'\\', v254, v259, v260, v261, v262)
                                        } else {
                                            let mut v264: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                            US10::US10_1(v264.clone(), v216, v217, v218, v219, v220)
                                        }
                                    };
                                    let mut v302: US10 = match &v267 {
                                        US10::US10_1(v294, v295, v296, v297, v298, v299) => { // Error
                                            let mut v294: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v294.clone();
                                            let mut v295: i32 = v295.clone();
                                            let mut v296: i32 = v296.clone();
                                            let mut v297: i32 = v297.clone();
                                            let mut v298: i32 = v298.clone();
                                            let mut v299: i32 = v299.clone();
                                            US10::US10_1(v294.clone(), v295, v296, v297, v298, v299)
                                        }
                                        US10::US10_0(v268, v269, v270, v271, v272, v273) => { // Ok
                                            let mut v268: u8 = v268.clone();
                                            let mut v269: i32 = v269.clone();
                                            let mut v270: i32 = v270.clone();
                                            let mut v271: i32 = v271.clone();
                                            let mut v272: i32 = v272.clone();
                                            let mut v273: i32 = v273.clone();
                                            let mut v274: bool = v269 >= v273;
                                            if v274 {
                                                let mut v275: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                                US10::US10_1(v275.clone(), v269, v270, v271, v272, v273)
                                            } else {
                                                let mut v277: u8 = v0.clone().as_bytes()[v269 as usize];
                                                let mut v278: bool = v277 == b'"';
                                                let mut v279: bool = v278 == false;
                                                if v279 {
                                                    let mut v280: i32 = v269 + 1i32;
                                                    let mut v281: bool = b'\n' == v277;
                                                    let (mut v285, mut v286, mut v287, mut v288): (i32, i32, i32, i32) = if v281 {
                                                        let mut v282: i32 = v270 + v272;
                                                        let mut v283: i32 = v271 + 1i32;
                                                        (v282, v283, 1i32, v273)
                                                    } else {
                                                        let mut v284: i32 = v272 + 1i32;
                                                        (v270, v271, v284, v273)
                                                    };
                                                    US10::US10_0(v277, v280, v285, v286, v287, v288)
                                                } else {
                                                    let mut v290: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                    US10::US10_1(v290.clone(), v269, v270, v271, v272, v273)
                                                }
                                            }
                                        }
                                        _ => unreachable!(),
                                    };
                                    let mut v324: US11 = match &v302 {
                                        US10::US10_1(v316, v317, v318, v319, v320, v321) => { // Error
                                            let mut v316: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v316.clone();
                                            let mut v317: i32 = v317.clone();
                                            let mut v318: i32 = v318.clone();
                                            let mut v319: i32 = v319.clone();
                                            let mut v320: i32 = v320.clone();
                                            let mut v321: i32 = v321.clone();
                                            US11::US11_1(v316.clone(), v317, v318, v319, v320, v321)
                                        }
                                        US10::US10_0(v303, v304, v305, v306, v307, v308) => { // Ok
                                            let mut v303: u8 = v303.clone();
                                            let mut v304: i32 = v304.clone();
                                            let mut v305: i32 = v305.clone();
                                            let mut v306: i32 = v306.clone();
                                            let mut v307: i32 = v307.clone();
                                            let mut v308: i32 = v308.clone();
                                            let mut v309: bool = v216 >= v304;
                                            let mut v314: Rc<str> = if v309 {
                                                let mut v310: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                v310.clone()
                                            } else {
                                                let mut v311: bool = v216 == v304;
                                                let mut v312: i32 = v304 - 1i32;
                                                let mut v313: Rc<str> = string_slice(&v0.clone(), v216 as i64, v312 as i64);
                                                v313.clone()
                                            };
                                            US11::US11_0(v314.clone(), v304, v305, v306, v307, v308)
                                        }
                                        _ => unreachable!(),
                                    };
                                    match &v324 {
                                        US11::US11_1(v331, v332, v333, v334, v335, v336) => { // Error
                                            let mut v331: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v331.clone();
                                            let mut v332: i32 = v332.clone();
                                            let mut v333: i32 = v333.clone();
                                            let mut v334: i32 = v334.clone();
                                            let mut v335: i32 = v335.clone();
                                            let mut v336: i32 = v336.clone();
                                            let mut v354: US10 = if v249 {
                                                let mut v337: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                                US10::US10_1(v337.clone(), v216, v217, v218, v219, v220)
                                            } else {
                                                let mut v339: u8 = v0.clone().as_bytes()[v216 as usize];
                                                let mut v340: bool = v339 == b'`';
                                                if v340 {
                                                    let mut v341: i32 = v216 + 1i32;
                                                    let mut v342: bool = b'\n' == v339;
                                                    let (mut v346, mut v347, mut v348, mut v349): (i32, i32, i32, i32) = if v342 {
                                                        let mut v343: i32 = v217 + v219;
                                                        let mut v344: i32 = v218 + 1i32;
                                                        (v343, v344, 1i32, v220)
                                                    } else {
                                                        let mut v345: i32 = v219 + 1i32;
                                                        (v217, v218, v345, v220)
                                                    };
                                                    US10::US10_0(b'`', v341, v346, v347, v348, v349)
                                                } else {
                                                    let mut v351: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                    US10::US10_1(v351.clone(), v216, v217, v218, v219, v220)
                                                }
                                            };
                                            let mut v389: US10 = match &v354 {
                                                US10::US10_1(v381, v382, v383, v384, v385, v386) => { // Error
                                                    let mut v381: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v381.clone();
                                                    let mut v382: i32 = v382.clone();
                                                    let mut v383: i32 = v383.clone();
                                                    let mut v384: i32 = v384.clone();
                                                    let mut v385: i32 = v385.clone();
                                                    let mut v386: i32 = v386.clone();
                                                    US10::US10_1(v381.clone(), v382, v383, v384, v385, v386)
                                                }
                                                US10::US10_0(v355, v356, v357, v358, v359, v360) => { // Ok
                                                    let mut v355: u8 = v355.clone();
                                                    let mut v356: i32 = v356.clone();
                                                    let mut v357: i32 = v357.clone();
                                                    let mut v358: i32 = v358.clone();
                                                    let mut v359: i32 = v359.clone();
                                                    let mut v360: i32 = v360.clone();
                                                    let mut v361: bool = v356 >= v360;
                                                    if v361 {
                                                        let mut v362: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                                        US10::US10_1(v362.clone(), v356, v357, v358, v359, v360)
                                                    } else {
                                                        let mut v364: u8 = v0.clone().as_bytes()[v356 as usize];
                                                        let mut v365: bool = v364 == b'"';
                                                        let mut v366: bool = v365 == false;
                                                        if v366 {
                                                            let mut v367: i32 = v356 + 1i32;
                                                            let mut v368: bool = b'\n' == v364;
                                                            let (mut v372, mut v373, mut v374, mut v375): (i32, i32, i32, i32) = if v368 {
                                                                let mut v369: i32 = v357 + v359;
                                                                let mut v370: i32 = v358 + 1i32;
                                                                (v369, v370, 1i32, v360)
                                                            } else {
                                                                let mut v371: i32 = v359 + 1i32;
                                                                (v357, v358, v371, v360)
                                                            };
                                                            US10::US10_0(v364, v367, v372, v373, v374, v375)
                                                        } else {
                                                            let mut v377: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                                            US10::US10_1(v377.clone(), v356, v357, v358, v359, v360)
                                                        }
                                                    }
                                                }
                                                _ => unreachable!(),
                                            };
                                            let mut v411: US11 = match &v389 {
                                                US10::US10_1(v403, v404, v405, v406, v407, v408) => { // Error
                                                    let mut v403: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v403.clone();
                                                    let mut v404: i32 = v404.clone();
                                                    let mut v405: i32 = v405.clone();
                                                    let mut v406: i32 = v406.clone();
                                                    let mut v407: i32 = v407.clone();
                                                    let mut v408: i32 = v408.clone();
                                                    US11::US11_1(v403.clone(), v404, v405, v406, v407, v408)
                                                }
                                                US10::US10_0(v390, v391, v392, v393, v394, v395) => { // Ok
                                                    let mut v390: u8 = v390.clone();
                                                    let mut v391: i32 = v391.clone();
                                                    let mut v392: i32 = v392.clone();
                                                    let mut v393: i32 = v393.clone();
                                                    let mut v394: i32 = v394.clone();
                                                    let mut v395: i32 = v395.clone();
                                                    let mut v396: bool = v216 >= v391;
                                                    let mut v401: Rc<str> = if v396 {
                                                        let mut v397: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                        v397.clone()
                                                    } else {
                                                        let mut v398: bool = v216 == v391;
                                                        let mut v399: i32 = v391 - 1i32;
                                                        let mut v400: Rc<str> = string_slice(&v0.clone(), v216 as i64, v399 as i64);
                                                        v400.clone()
                                                    };
                                                    US11::US11_0(v401.clone(), v391, v392, v393, v394, v395)
                                                }
                                                _ => unreachable!(),
                                            };
                                            match &v411 {
                                                US11::US11_1(v418, v419, v420, v421, v422, v423) => { // Error
                                                    let mut v418: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v418.clone();
                                                    let mut v419: i32 = v419.clone();
                                                    let mut v420: i32 = v420.clone();
                                                    let mut v421: i32 = v421.clone();
                                                    let mut v422: i32 = v422.clone();
                                                    let mut v423: i32 = v423.clone();
                                                    let mut v424: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                                    US11::US11_1(v424.clone(), v216, v217, v218, v219, v220)
                                                }
                                                US11::US11_0(v412, v413, v414, v415, v416, v417) => { // Ok
                                                    let mut v412: Rc<str> = v412.clone();
                                                    let mut v413: i32 = v413.clone();
                                                    let mut v414: i32 = v414.clone();
                                                    let mut v415: i32 = v415.clone();
                                                    let mut v416: i32 = v416.clone();
                                                    let mut v417: i32 = v417.clone();
                                                    v411.clone()
                                                }
                                                _ => unreachable!(),
                                            }
                                        }
                                        US11::US11_0(v325, v326, v327, v328, v329, v330) => { // Ok
                                            let mut v325: Rc<str> = v325.clone();
                                            let mut v326: i32 = v326.clone();
                                            let mut v327: i32 = v327.clone();
                                            let mut v328: i32 = v328.clone();
                                            let mut v329: i32 = v329.clone();
                                            let mut v330: i32 = v330.clone();
                                            v324.clone()
                                        }
                                        _ => unreachable!(),
                                    }
                                }
                                US11::US11_0(v237, v238, v239, v240, v241, v242) => { // Ok
                                    let mut v237: Rc<str> = v237.clone();
                                    let mut v238: i32 = v238.clone();
                                    let mut v239: i32 = v239.clone();
                                    let mut v240: i32 = v240.clone();
                                    let mut v241: i32 = v241.clone();
                                    let mut v242: i32 = v242.clone();
                                    v236.clone()
                                }
                                _ => unreachable!(),
                            };
                            let mut v454: US11 = match &v431 {
                                US11::US11_1(v432, v433, v434, v435, v436, v437) => { // Error
                                    let mut v432: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v432.clone();
                                    let mut v433: i32 = v433.clone();
                                    let mut v434: i32 = v434.clone();
                                    let mut v435: i32 = v435.clone();
                                    let mut v436: i32 = v436.clone();
                                    let mut v437: i32 = v437.clone();
                                    let mut v438: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    US11::US11_0(v438.clone(), v216, v217, v218, v219, v220)
                                }
                                US11::US11_0(v440, v441, v442, v443, v444, v445) => { // Ok
                                    let mut v440: Rc<str> = v440.clone();
                                    let mut v441: i32 = v441.clone();
                                    let mut v442: i32 = v442.clone();
                                    let mut v443: i32 = v443.clone();
                                    let mut v444: i32 = v444.clone();
                                    let mut v445: i32 = v445.clone();
                                    let mut v446: bool = v441 == v216;
                                    if v446 {
                                        let mut v447: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                        US11::US11_1(v447.clone(), v216, v217, v218, v219, v220)
                                    } else {
                                        let mut v449: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                        let mut v450: i32 = 0i32;
                                        method115(v0.clone(), v449.clone(), v440.clone(), v450, v441, v442, v443, v444, v445)
                                    }
                                }
                                _ => unreachable!(),
                            };
                            match &v454 {
                                US11::US11_1(v645, v646, v647, v648, v649, v650) => { // Error
                                    let mut v645: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v645.clone();
                                    let mut v646: i32 = v646.clone();
                                    let mut v647: i32 = v647.clone();
                                    let mut v648: i32 = v648.clone();
                                    let mut v649: i32 = v649.clone();
                                    let mut v650: i32 = v650.clone();
                                    let mut v651: bool = v216 >= v220;
                                    let mut v669: US10 = if v651 {
                                        let mut v652: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                        US10::US10_1(v652.clone(), v216, v217, v218, v219, v220)
                                    } else {
                                        let mut v654: u8 = v0.clone().as_bytes()[v216 as usize];
                                        let mut v655: bool = v654 == b'\\';
                                        if v655 {
                                            let mut v656: i32 = v216 + 1i32;
                                            let mut v657: bool = b'\n' == v654;
                                            let (mut v661, mut v662, mut v663, mut v664): (i32, i32, i32, i32) = if v657 {
                                                let mut v658: i32 = v217 + v219;
                                                let mut v659: i32 = v218 + 1i32;
                                                (v658, v659, 1i32, v220)
                                            } else {
                                                let mut v660: i32 = v219 + 1i32;
                                                (v217, v218, v660, v220)
                                            };
                                            US10::US10_0(b'\\', v656, v661, v662, v663, v664)
                                        } else {
                                            let mut v666: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                            US10::US10_1(v666.clone(), v216, v217, v218, v219, v220)
                                        }
                                    };
                                    let mut v703: US10 = match &v669 {
                                        US10::US10_1(v695, v696, v697, v698, v699, v700) => { // Error
                                            let mut v695: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v695.clone();
                                            let mut v696: i32 = v696.clone();
                                            let mut v697: i32 = v697.clone();
                                            let mut v698: i32 = v698.clone();
                                            let mut v699: i32 = v699.clone();
                                            let mut v700: i32 = v700.clone();
                                            US10::US10_1(v695.clone(), v696, v697, v698, v699, v700)
                                        }
                                        US10::US10_0(v670, v671, v672, v673, v674, v675) => { // Ok
                                            let mut v670: u8 = v670.clone();
                                            let mut v671: i32 = v671.clone();
                                            let mut v672: i32 = v672.clone();
                                            let mut v673: i32 = v673.clone();
                                            let mut v674: i32 = v674.clone();
                                            let mut v675: i32 = v675.clone();
                                            let mut v676: bool = v671 >= v675;
                                            if v676 {
                                                let mut v677: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                US10::US10_1(v677.clone(), v671, v672, v673, v674, v675)
                                            } else {
                                                let mut v679: u8 = v0.clone().as_bytes()[v671 as usize];
                                                let mut v680: bool = v679 == b'"';
                                                if v680 {
                                                    let mut v681: i32 = v671 + 1i32;
                                                    let mut v682: bool = b'\n' == v679;
                                                    let (mut v686, mut v687, mut v688, mut v689): (i32, i32, i32, i32) = if v682 {
                                                        let mut v683: i32 = v672 + v674;
                                                        let mut v684: i32 = v673 + 1i32;
                                                        (v683, v684, 1i32, v675)
                                                    } else {
                                                        let mut v685: i32 = v674 + 1i32;
                                                        (v672, v673, v685, v675)
                                                    };
                                                    US10::US10_0(b'"', v681, v686, v687, v688, v689)
                                                } else {
                                                    let mut v691: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                    US10::US10_1(v691.clone(), v671, v672, v673, v674, v675)
                                                }
                                            }
                                        }
                                        _ => unreachable!(),
                                    };
                                    let mut v719: US10 = match &v703 {
                                        US10::US10_1(v711, v712, v713, v714, v715, v716) => { // Error
                                            let mut v711: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v711.clone();
                                            let mut v712: i32 = v712.clone();
                                            let mut v713: i32 = v713.clone();
                                            let mut v714: i32 = v714.clone();
                                            let mut v715: i32 = v715.clone();
                                            let mut v716: i32 = v716.clone();
                                            US10::US10_1(v711.clone(), v712, v713, v714, v715, v716)
                                        }
                                        US10::US10_0(v704, v705, v706, v707, v708, v709) => { // Ok
                                            let mut v704: u8 = v704.clone();
                                            let mut v705: i32 = v705.clone();
                                            let mut v706: i32 = v706.clone();
                                            let mut v707: i32 = v707.clone();
                                            let mut v708: i32 = v708.clone();
                                            let mut v709: i32 = v709.clone();
                                            US10::US10_0(b'"', v705, v706, v707, v708, v709)
                                        }
                                        _ => unreachable!(),
                                    };
                                    let mut v817: US10 = match &v719 {
                                        US10::US10_1(v726, v727, v728, v729, v730, v731) => { // Error
                                            let mut v726: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v726.clone();
                                            let mut v727: i32 = v727.clone();
                                            let mut v728: i32 = v728.clone();
                                            let mut v729: i32 = v729.clone();
                                            let mut v730: i32 = v730.clone();
                                            let mut v731: i32 = v731.clone();
                                            let mut v749: US10 = if v651 {
                                                let mut v732: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                                US10::US10_1(v732.clone(), v216, v217, v218, v219, v220)
                                            } else {
                                                let mut v734: u8 = v0.clone().as_bytes()[v216 as usize];
                                                let mut v735: bool = v734 == b'`';
                                                if v735 {
                                                    let mut v736: i32 = v216 + 1i32;
                                                    let mut v737: bool = b'\n' == v734;
                                                    let (mut v741, mut v742, mut v743, mut v744): (i32, i32, i32, i32) = if v737 {
                                                        let mut v738: i32 = v217 + v219;
                                                        let mut v739: i32 = v218 + 1i32;
                                                        (v738, v739, 1i32, v220)
                                                    } else {
                                                        let mut v740: i32 = v219 + 1i32;
                                                        (v217, v218, v740, v220)
                                                    };
                                                    US10::US10_0(b'`', v736, v741, v742, v743, v744)
                                                } else {
                                                    let mut v746: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                    US10::US10_1(v746.clone(), v216, v217, v218, v219, v220)
                                                }
                                            };
                                            let mut v783: US10 = match &v749 {
                                                US10::US10_1(v775, v776, v777, v778, v779, v780) => { // Error
                                                    let mut v775: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v775.clone();
                                                    let mut v776: i32 = v776.clone();
                                                    let mut v777: i32 = v777.clone();
                                                    let mut v778: i32 = v778.clone();
                                                    let mut v779: i32 = v779.clone();
                                                    let mut v780: i32 = v780.clone();
                                                    US10::US10_1(v775.clone(), v776, v777, v778, v779, v780)
                                                }
                                                US10::US10_0(v750, v751, v752, v753, v754, v755) => { // Ok
                                                    let mut v750: u8 = v750.clone();
                                                    let mut v751: i32 = v751.clone();
                                                    let mut v752: i32 = v752.clone();
                                                    let mut v753: i32 = v753.clone();
                                                    let mut v754: i32 = v754.clone();
                                                    let mut v755: i32 = v755.clone();
                                                    let mut v756: bool = v751 >= v755;
                                                    if v756 {
                                                        let mut v757: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                        US10::US10_1(v757.clone(), v751, v752, v753, v754, v755)
                                                    } else {
                                                        let mut v759: u8 = v0.clone().as_bytes()[v751 as usize];
                                                        let mut v760: bool = v759 == b'"';
                                                        if v760 {
                                                            let mut v761: i32 = v751 + 1i32;
                                                            let mut v762: bool = b'\n' == v759;
                                                            let (mut v766, mut v767, mut v768, mut v769): (i32, i32, i32, i32) = if v762 {
                                                                let mut v763: i32 = v752 + v754;
                                                                let mut v764: i32 = v753 + 1i32;
                                                                (v763, v764, 1i32, v755)
                                                            } else {
                                                                let mut v765: i32 = v754 + 1i32;
                                                                (v752, v753, v765, v755)
                                                            };
                                                            US10::US10_0(b'"', v761, v766, v767, v768, v769)
                                                        } else {
                                                            let mut v771: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                            US10::US10_1(v771.clone(), v751, v752, v753, v754, v755)
                                                        }
                                                    }
                                                }
                                                _ => unreachable!(),
                                            };
                                            let mut v799: US10 = match &v783 {
                                                US10::US10_1(v791, v792, v793, v794, v795, v796) => { // Error
                                                    let mut v791: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v791.clone();
                                                    let mut v792: i32 = v792.clone();
                                                    let mut v793: i32 = v793.clone();
                                                    let mut v794: i32 = v794.clone();
                                                    let mut v795: i32 = v795.clone();
                                                    let mut v796: i32 = v796.clone();
                                                    US10::US10_1(v791.clone(), v792, v793, v794, v795, v796)
                                                }
                                                US10::US10_0(v784, v785, v786, v787, v788, v789) => { // Ok
                                                    let mut v784: u8 = v784.clone();
                                                    let mut v785: i32 = v785.clone();
                                                    let mut v786: i32 = v786.clone();
                                                    let mut v787: i32 = v787.clone();
                                                    let mut v788: i32 = v788.clone();
                                                    let mut v789: i32 = v789.clone();
                                                    US10::US10_0(b'"', v785, v786, v787, v788, v789)
                                                }
                                                _ => unreachable!(),
                                            };
                                            match &v799 {
                                                US10::US10_1(v806, v807, v808, v809, v810, v811) => { // Error
                                                    let mut v806: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v806.clone();
                                                    let mut v807: i32 = v807.clone();
                                                    let mut v808: i32 = v808.clone();
                                                    let mut v809: i32 = v809.clone();
                                                    let mut v810: i32 = v810.clone();
                                                    let mut v811: i32 = v811.clone();
                                                    let mut v812: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                                    US10::US10_1(v812.clone(), v216, v217, v218, v219, v220)
                                                }
                                                US10::US10_0(v800, v801, v802, v803, v804, v805) => { // Ok
                                                    let mut v800: u8 = v800.clone();
                                                    let mut v801: i32 = v801.clone();
                                                    let mut v802: i32 = v802.clone();
                                                    let mut v803: i32 = v803.clone();
                                                    let mut v804: i32 = v804.clone();
                                                    let mut v805: i32 = v805.clone();
                                                    v799.clone()
                                                }
                                                _ => unreachable!(),
                                            }
                                        }
                                        US10::US10_0(v720, v721, v722, v723, v724, v725) => { // Ok
                                            let mut v720: u8 = v720.clone();
                                            let mut v721: i32 = v721.clone();
                                            let mut v722: i32 = v722.clone();
                                            let mut v723: i32 = v723.clone();
                                            let mut v724: i32 = v724.clone();
                                            let mut v725: i32 = v725.clone();
                                            v719.clone()
                                        }
                                        _ => unreachable!(),
                                    };
                                    match &v817 {
                                        US10::US10_1(v826, v827, v828, v829, v830, v831) => { // Error
                                            let mut v826: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v826.clone();
                                            let mut v827: i32 = v827.clone();
                                            let mut v828: i32 = v828.clone();
                                            let mut v829: i32 = v829.clone();
                                            let mut v830: i32 = v830.clone();
                                            let mut v831: i32 = v831.clone();
                                            let mut v832: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                                            US11::US11_1(v832.clone(), v216, v217, v218, v219, v220)
                                        }
                                        US10::US10_0(v818, v819, v820, v821, v822, v823) => { // Ok
                                            let mut v818: u8 = v818.clone();
                                            let mut v819: i32 = v819.clone();
                                            let mut v820: i32 = v820.clone();
                                            let mut v821: i32 = v821.clone();
                                            let mut v822: i32 = v822.clone();
                                            let mut v823: i32 = v823.clone();
                                            let mut v824: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            US11::US11_0(v824.clone(), v819, v820, v821, v822, v823)
                                        }
                                        _ => unreachable!(),
                                    }
                                }
                                US11::US11_0(v455, v456, v457, v458, v459, v460) => { // Ok
                                    let mut v455: Rc<str> = v455.clone();
                                    let mut v456: i32 = v456.clone();
                                    let mut v457: i32 = v457.clone();
                                    let mut v458: i32 = v458.clone();
                                    let mut v459: i32 = v459.clone();
                                    let mut v460: i32 = v460.clone();
                                    let mut v461: bool = v456 >= v460;
                                    let mut v479: US10 = if v461 {
                                        let mut v462: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                        US10::US10_1(v462.clone(), v456, v457, v458, v459, v460)
                                    } else {
                                        let mut v464: u8 = v0.clone().as_bytes()[v456 as usize];
                                        let mut v465: bool = v464 == b'\\';
                                        if v465 {
                                            let mut v466: i32 = v456 + 1i32;
                                            let mut v467: bool = b'\n' == v464;
                                            let (mut v471, mut v472, mut v473, mut v474): (i32, i32, i32, i32) = if v467 {
                                                let mut v468: i32 = v457 + v459;
                                                let mut v469: i32 = v458 + 1i32;
                                                (v468, v469, 1i32, v460)
                                            } else {
                                                let mut v470: i32 = v459 + 1i32;
                                                (v457, v458, v470, v460)
                                            };
                                            US10::US10_0(b'\\', v466, v471, v472, v473, v474)
                                        } else {
                                            let mut v476: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                            US10::US10_1(v476.clone(), v456, v457, v458, v459, v460)
                                        }
                                    };
                                    let mut v513: US10 = match &v479 {
                                        US10::US10_1(v505, v506, v507, v508, v509, v510) => { // Error
                                            let mut v505: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v505.clone();
                                            let mut v506: i32 = v506.clone();
                                            let mut v507: i32 = v507.clone();
                                            let mut v508: i32 = v508.clone();
                                            let mut v509: i32 = v509.clone();
                                            let mut v510: i32 = v510.clone();
                                            US10::US10_1(v505.clone(), v506, v507, v508, v509, v510)
                                        }
                                        US10::US10_0(v480, v481, v482, v483, v484, v485) => { // Ok
                                            let mut v480: u8 = v480.clone();
                                            let mut v481: i32 = v481.clone();
                                            let mut v482: i32 = v482.clone();
                                            let mut v483: i32 = v483.clone();
                                            let mut v484: i32 = v484.clone();
                                            let mut v485: i32 = v485.clone();
                                            let mut v486: bool = v481 >= v485;
                                            if v486 {
                                                let mut v487: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                US10::US10_1(v487.clone(), v481, v482, v483, v484, v485)
                                            } else {
                                                let mut v489: u8 = v0.clone().as_bytes()[v481 as usize];
                                                let mut v490: bool = v489 == b'"';
                                                if v490 {
                                                    let mut v491: i32 = v481 + 1i32;
                                                    let mut v492: bool = b'\n' == v489;
                                                    let (mut v496, mut v497, mut v498, mut v499): (i32, i32, i32, i32) = if v492 {
                                                        let mut v493: i32 = v482 + v484;
                                                        let mut v494: i32 = v483 + 1i32;
                                                        (v493, v494, 1i32, v485)
                                                    } else {
                                                        let mut v495: i32 = v484 + 1i32;
                                                        (v482, v483, v495, v485)
                                                    };
                                                    US10::US10_0(b'"', v491, v496, v497, v498, v499)
                                                } else {
                                                    let mut v501: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                    US10::US10_1(v501.clone(), v481, v482, v483, v484, v485)
                                                }
                                            }
                                        }
                                        _ => unreachable!(),
                                    };
                                    let mut v529: US10 = match &v513 {
                                        US10::US10_1(v521, v522, v523, v524, v525, v526) => { // Error
                                            let mut v521: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v521.clone();
                                            let mut v522: i32 = v522.clone();
                                            let mut v523: i32 = v523.clone();
                                            let mut v524: i32 = v524.clone();
                                            let mut v525: i32 = v525.clone();
                                            let mut v526: i32 = v526.clone();
                                            US10::US10_1(v521.clone(), v522, v523, v524, v525, v526)
                                        }
                                        US10::US10_0(v514, v515, v516, v517, v518, v519) => { // Ok
                                            let mut v514: u8 = v514.clone();
                                            let mut v515: i32 = v515.clone();
                                            let mut v516: i32 = v516.clone();
                                            let mut v517: i32 = v517.clone();
                                            let mut v518: i32 = v518.clone();
                                            let mut v519: i32 = v519.clone();
                                            US10::US10_0(b'"', v515, v516, v517, v518, v519)
                                        }
                                        _ => unreachable!(),
                                    };
                                    let mut v627: US10 = match &v529 {
                                        US10::US10_1(v536, v537, v538, v539, v540, v541) => { // Error
                                            let mut v536: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v536.clone();
                                            let mut v537: i32 = v537.clone();
                                            let mut v538: i32 = v538.clone();
                                            let mut v539: i32 = v539.clone();
                                            let mut v540: i32 = v540.clone();
                                            let mut v541: i32 = v541.clone();
                                            let mut v559: US10 = if v461 {
                                                let mut v542: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                                US10::US10_1(v542.clone(), v456, v457, v458, v459, v460)
                                            } else {
                                                let mut v544: u8 = v0.clone().as_bytes()[v456 as usize];
                                                let mut v545: bool = v544 == b'`';
                                                if v545 {
                                                    let mut v546: i32 = v456 + 1i32;
                                                    let mut v547: bool = b'\n' == v544;
                                                    let (mut v551, mut v552, mut v553, mut v554): (i32, i32, i32, i32) = if v547 {
                                                        let mut v548: i32 = v457 + v459;
                                                        let mut v549: i32 = v458 + 1i32;
                                                        (v548, v549, 1i32, v460)
                                                    } else {
                                                        let mut v550: i32 = v459 + 1i32;
                                                        (v457, v458, v550, v460)
                                                    };
                                                    US10::US10_0(b'`', v546, v551, v552, v553, v554)
                                                } else {
                                                    let mut v556: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                    US10::US10_1(v556.clone(), v456, v457, v458, v459, v460)
                                                }
                                            };
                                            let mut v593: US10 = match &v559 {
                                                US10::US10_1(v585, v586, v587, v588, v589, v590) => { // Error
                                                    let mut v585: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v585.clone();
                                                    let mut v586: i32 = v586.clone();
                                                    let mut v587: i32 = v587.clone();
                                                    let mut v588: i32 = v588.clone();
                                                    let mut v589: i32 = v589.clone();
                                                    let mut v590: i32 = v590.clone();
                                                    US10::US10_1(v585.clone(), v586, v587, v588, v589, v590)
                                                }
                                                US10::US10_0(v560, v561, v562, v563, v564, v565) => { // Ok
                                                    let mut v560: u8 = v560.clone();
                                                    let mut v561: i32 = v561.clone();
                                                    let mut v562: i32 = v562.clone();
                                                    let mut v563: i32 = v563.clone();
                                                    let mut v564: i32 = v564.clone();
                                                    let mut v565: i32 = v565.clone();
                                                    let mut v566: bool = v561 >= v565;
                                                    if v566 {
                                                        let mut v567: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                        US10::US10_1(v567.clone(), v561, v562, v563, v564, v565)
                                                    } else {
                                                        let mut v569: u8 = v0.clone().as_bytes()[v561 as usize];
                                                        let mut v570: bool = v569 == b'"';
                                                        if v570 {
                                                            let mut v571: i32 = v561 + 1i32;
                                                            let mut v572: bool = b'\n' == v569;
                                                            let (mut v576, mut v577, mut v578, mut v579): (i32, i32, i32, i32) = if v572 {
                                                                let mut v573: i32 = v562 + v564;
                                                                let mut v574: i32 = v563 + 1i32;
                                                                (v573, v574, 1i32, v565)
                                                            } else {
                                                                let mut v575: i32 = v564 + 1i32;
                                                                (v562, v563, v575, v565)
                                                            };
                                                            US10::US10_0(b'"', v571, v576, v577, v578, v579)
                                                        } else {
                                                            let mut v581: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                            US10::US10_1(v581.clone(), v561, v562, v563, v564, v565)
                                                        }
                                                    }
                                                }
                                                _ => unreachable!(),
                                            };
                                            let mut v609: US10 = match &v593 {
                                                US10::US10_1(v601, v602, v603, v604, v605, v606) => { // Error
                                                    let mut v601: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v601.clone();
                                                    let mut v602: i32 = v602.clone();
                                                    let mut v603: i32 = v603.clone();
                                                    let mut v604: i32 = v604.clone();
                                                    let mut v605: i32 = v605.clone();
                                                    let mut v606: i32 = v606.clone();
                                                    US10::US10_1(v601.clone(), v602, v603, v604, v605, v606)
                                                }
                                                US10::US10_0(v594, v595, v596, v597, v598, v599) => { // Ok
                                                    let mut v594: u8 = v594.clone();
                                                    let mut v595: i32 = v595.clone();
                                                    let mut v596: i32 = v596.clone();
                                                    let mut v597: i32 = v597.clone();
                                                    let mut v598: i32 = v598.clone();
                                                    let mut v599: i32 = v599.clone();
                                                    US10::US10_0(b'"', v595, v596, v597, v598, v599)
                                                }
                                                _ => unreachable!(),
                                            };
                                            match &v609 {
                                                US10::US10_1(v616, v617, v618, v619, v620, v621) => { // Error
                                                    let mut v616: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v616.clone();
                                                    let mut v617: i32 = v617.clone();
                                                    let mut v618: i32 = v618.clone();
                                                    let mut v619: i32 = v619.clone();
                                                    let mut v620: i32 = v620.clone();
                                                    let mut v621: i32 = v621.clone();
                                                    let mut v622: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                                    US10::US10_1(v622.clone(), v456, v457, v458, v459, v460)
                                                }
                                                US10::US10_0(v610, v611, v612, v613, v614, v615) => { // Ok
                                                    let mut v610: u8 = v610.clone();
                                                    let mut v611: i32 = v611.clone();
                                                    let mut v612: i32 = v612.clone();
                                                    let mut v613: i32 = v613.clone();
                                                    let mut v614: i32 = v614.clone();
                                                    let mut v615: i32 = v615.clone();
                                                    v609.clone()
                                                }
                                                _ => unreachable!(),
                                            }
                                        }
                                        US10::US10_0(v530, v531, v532, v533, v534, v535) => { // Ok
                                            let mut v530: u8 = v530.clone();
                                            let mut v531: i32 = v531.clone();
                                            let mut v532: i32 = v532.clone();
                                            let mut v533: i32 = v533.clone();
                                            let mut v534: i32 = v534.clone();
                                            let mut v535: i32 = v535.clone();
                                            v529.clone()
                                        }
                                        _ => unreachable!(),
                                    };
                                    match &v627 {
                                        US10::US10_1(v635, v636, v637, v638, v639, v640) => { // Error
                                            let mut v635: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v635.clone();
                                            let mut v636: i32 = v636.clone();
                                            let mut v637: i32 = v637.clone();
                                            let mut v638: i32 = v638.clone();
                                            let mut v639: i32 = v639.clone();
                                            let mut v640: i32 = v640.clone();
                                            let mut v641: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v216, v456, v635.clone(), v636, v637, v638, v639, v640);
                                            US11::US11_1(v641.clone(), v456, v457, v458, v459, v460)
                                        }
                                        US10::US10_0(v628, v629, v630, v631, v632, v633) => { // Ok
                                            let mut v628: u8 = v628.clone();
                                            let mut v629: i32 = v629.clone();
                                            let mut v630: i32 = v630.clone();
                                            let mut v631: i32 = v631.clone();
                                            let mut v632: i32 = v632.clone();
                                            let mut v633: i32 = v633.clone();
                                            US11::US11_0(v455.clone(), v629, v630, v631, v632, v633)
                                        }
                                        _ => unreachable!(),
                                    }
                                }
                                _ => unreachable!(),
                            }
                        }
                        _ => unreachable!(),
                    };
                    let mut v1204: US11 = match &v846 {
                        US11::US11_1(v853, v854, v855, v856, v857, v858) => { // Error
                            let mut v853: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v853.clone();
                            let mut v854: i32 = v854.clone();
                            let mut v855: i32 = v855.clone();
                            let mut v856: i32 = v856.clone();
                            let mut v857: i32 = v857.clone();
                            let mut v858: i32 = v858.clone();
                            let mut v876: US10 = if v48 {
                                let mut v859: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_1(v859.clone(), v40, v41, v42, v43, v44)
                            } else {
                                let mut v861: u8 = v0.clone().as_bytes()[v40 as usize];
                                let mut v862: bool = v861 == b'"';
                                if v862 {
                                    let mut v863: i32 = v40 + 1i32;
                                    let mut v864: bool = b'\n' == v861;
                                    let (mut v868, mut v869, mut v870, mut v871): (i32, i32, i32, i32) = if v864 {
                                        let mut v865: i32 = v41 + v43;
                                        let mut v866: i32 = v42 + 1i32;
                                        (v865, v866, 1i32, v44)
                                    } else {
                                        let mut v867: i32 = v43 + 1i32;
                                        (v41, v42, v867, v44)
                                    };
                                    US10::US10_0(b'"', v863, v868, v869, v870, v871)
                                } else {
                                    let mut v873: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_1(v873.clone(), v40, v41, v42, v43, v44)
                                }
                            };
                            match &v876 {
                                US10::US10_1(v1194, v1195, v1196, v1197, v1198, v1199) => { // Error
                                    let mut v1194: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1194.clone();
                                    let mut v1195: i32 = v1195.clone();
                                    let mut v1196: i32 = v1196.clone();
                                    let mut v1197: i32 = v1197.clone();
                                    let mut v1198: i32 = v1198.clone();
                                    let mut v1199: i32 = v1199.clone();
                                    US11::US11_1(v1194.clone(), v1195, v1196, v1197, v1198, v1199)
                                }
                                US10::US10_0(v877, v878, v879, v880, v881, v882) => { // Ok
                                    let mut v877: u8 = v877.clone();
                                    let mut v878: i32 = v878.clone();
                                    let mut v879: i32 = v879.clone();
                                    let mut v880: i32 = v880.clone();
                                    let mut v881: i32 = v881.clone();
                                    let mut v882: i32 = v882.clone();
                                    let (mut v883, mut v884, mut v885, mut v886, mut v887): (i32, i32, i32, i32, i32) = method111(v879, v880, v881, v882, v0.clone(), v878);
                                    let mut v888: bool = v883 > v878;
                                    let mut v898: US11 = if v888 {
                                        let mut v889: bool = v878 >= v883;
                                        let mut v894: Rc<str> = if v889 {
                                            let mut v890: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            v890.clone()
                                        } else {
                                            let mut v891: bool = v878 == v883;
                                            let mut v892: i32 = v883 - 1i32;
                                            let mut v893: Rc<str> = string_slice(&v0.clone(), v878 as i64, v892 as i64);
                                            v893.clone()
                                        };
                                        US11::US11_0(v894.clone(), v883, v884, v885, v886, v887)
                                    } else {
                                        let mut v896: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                        US11::US11_1(v896.clone(), v878, v879, v880, v881, v882)
                                    };
                                    let mut v1083: US11 = match &v898 {
                                        US11::US11_1(v905, v906, v907, v908, v909, v910) => { // Error
                                            let mut v905: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v905.clone();
                                            let mut v906: i32 = v906.clone();
                                            let mut v907: i32 = v907.clone();
                                            let mut v908: i32 = v908.clone();
                                            let mut v909: i32 = v909.clone();
                                            let mut v910: i32 = v910.clone();
                                            let mut v911: bool = v878 >= v882;
                                            let mut v929: US10 = if v911 {
                                                let mut v912: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                                US10::US10_1(v912.clone(), v878, v879, v880, v881, v882)
                                            } else {
                                                let mut v914: u8 = v0.clone().as_bytes()[v878 as usize];
                                                let mut v915: bool = v914 == b'\\';
                                                if v915 {
                                                    let mut v916: i32 = v878 + 1i32;
                                                    let mut v917: bool = b'\n' == v914;
                                                    let (mut v921, mut v922, mut v923, mut v924): (i32, i32, i32, i32) = if v917 {
                                                        let mut v918: i32 = v879 + v881;
                                                        let mut v919: i32 = v880 + 1i32;
                                                        (v918, v919, 1i32, v882)
                                                    } else {
                                                        let mut v920: i32 = v881 + 1i32;
                                                        (v879, v880, v920, v882)
                                                    };
                                                    US10::US10_0(b'\\', v916, v921, v922, v923, v924)
                                                } else {
                                                    let mut v926: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                                    US10::US10_1(v926.clone(), v878, v879, v880, v881, v882)
                                                }
                                            };
                                            let mut v959: US10 = match &v929 {
                                                US10::US10_1(v951, v952, v953, v954, v955, v956) => { // Error
                                                    let mut v951: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v951.clone();
                                                    let mut v952: i32 = v952.clone();
                                                    let mut v953: i32 = v953.clone();
                                                    let mut v954: i32 = v954.clone();
                                                    let mut v955: i32 = v955.clone();
                                                    let mut v956: i32 = v956.clone();
                                                    US10::US10_1(v951.clone(), v952, v953, v954, v955, v956)
                                                }
                                                US10::US10_0(v930, v931, v932, v933, v934, v935) => { // Ok
                                                    let mut v930: u8 = v930.clone();
                                                    let mut v931: i32 = v931.clone();
                                                    let mut v932: i32 = v932.clone();
                                                    let mut v933: i32 = v933.clone();
                                                    let mut v934: i32 = v934.clone();
                                                    let mut v935: i32 = v935.clone();
                                                    let mut v936: bool = v931 >= v935;
                                                    if v936 {
                                                        let mut v937: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                        US10::US10_1(v937.clone(), v931, v932, v933, v934, v935)
                                                    } else {
                                                        let mut v939: u8 = v0.clone().as_bytes()[v931 as usize];
                                                        let mut v940: i32 = v931 + 1i32;
                                                        let mut v941: bool = b'\n' == v939;
                                                        let (mut v945, mut v946, mut v947, mut v948): (i32, i32, i32, i32) = if v941 {
                                                            let mut v942: i32 = v932 + v934;
                                                            let mut v943: i32 = v933 + 1i32;
                                                            (v942, v943, 1i32, v935)
                                                        } else {
                                                            let mut v944: i32 = v934 + 1i32;
                                                            (v932, v933, v944, v935)
                                                        };
                                                        US10::US10_0(v939, v940, v945, v946, v947, v948)
                                                    }
                                                }
                                                _ => unreachable!(),
                                            };
                                            let mut v981: US11 = match &v959 {
                                                US10::US10_1(v973, v974, v975, v976, v977, v978) => { // Error
                                                    let mut v973: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v973.clone();
                                                    let mut v974: i32 = v974.clone();
                                                    let mut v975: i32 = v975.clone();
                                                    let mut v976: i32 = v976.clone();
                                                    let mut v977: i32 = v977.clone();
                                                    let mut v978: i32 = v978.clone();
                                                    US11::US11_1(v973.clone(), v974, v975, v976, v977, v978)
                                                }
                                                US10::US10_0(v960, v961, v962, v963, v964, v965) => { // Ok
                                                    let mut v960: u8 = v960.clone();
                                                    let mut v961: i32 = v961.clone();
                                                    let mut v962: i32 = v962.clone();
                                                    let mut v963: i32 = v963.clone();
                                                    let mut v964: i32 = v964.clone();
                                                    let mut v965: i32 = v965.clone();
                                                    let mut v966: bool = v878 >= v961;
                                                    let mut v971: Rc<str> = if v966 {
                                                        let mut v967: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                        v967.clone()
                                                    } else {
                                                        let mut v968: bool = v878 == v961;
                                                        let mut v969: i32 = v961 - 1i32;
                                                        let mut v970: Rc<str> = string_slice(&v0.clone(), v878 as i64, v969 as i64);
                                                        v970.clone()
                                                    };
                                                    US11::US11_0(v971.clone(), v961, v962, v963, v964, v965)
                                                }
                                                _ => unreachable!(),
                                            };
                                            match &v981 {
                                                US11::US11_1(v988, v989, v990, v991, v992, v993) => { // Error
                                                    let mut v988: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v988.clone();
                                                    let mut v989: i32 = v989.clone();
                                                    let mut v990: i32 = v990.clone();
                                                    let mut v991: i32 = v991.clone();
                                                    let mut v992: i32 = v992.clone();
                                                    let mut v993: i32 = v993.clone();
                                                    let mut v1011: US10 = if v911 {
                                                        let mut v994: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                                        US10::US10_1(v994.clone(), v878, v879, v880, v881, v882)
                                                    } else {
                                                        let mut v996: u8 = v0.clone().as_bytes()[v878 as usize];
                                                        let mut v997: bool = v996 == b'`';
                                                        if v997 {
                                                            let mut v998: i32 = v878 + 1i32;
                                                            let mut v999: bool = b'\n' == v996;
                                                            let (mut v1003, mut v1004, mut v1005, mut v1006): (i32, i32, i32, i32) = if v999 {
                                                                let mut v1000: i32 = v879 + v881;
                                                                let mut v1001: i32 = v880 + 1i32;
                                                                (v1000, v1001, 1i32, v882)
                                                            } else {
                                                                let mut v1002: i32 = v881 + 1i32;
                                                                (v879, v880, v1002, v882)
                                                            };
                                                            US10::US10_0(b'`', v998, v1003, v1004, v1005, v1006)
                                                        } else {
                                                            let mut v1008: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                                            US10::US10_1(v1008.clone(), v878, v879, v880, v881, v882)
                                                        }
                                                    };
                                                    let mut v1041: US10 = match &v1011 {
                                                        US10::US10_1(v1033, v1034, v1035, v1036, v1037, v1038) => { // Error
                                                            let mut v1033: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1033.clone();
                                                            let mut v1034: i32 = v1034.clone();
                                                            let mut v1035: i32 = v1035.clone();
                                                            let mut v1036: i32 = v1036.clone();
                                                            let mut v1037: i32 = v1037.clone();
                                                            let mut v1038: i32 = v1038.clone();
                                                            US10::US10_1(v1033.clone(), v1034, v1035, v1036, v1037, v1038)
                                                        }
                                                        US10::US10_0(v1012, v1013, v1014, v1015, v1016, v1017) => { // Ok
                                                            let mut v1012: u8 = v1012.clone();
                                                            let mut v1013: i32 = v1013.clone();
                                                            let mut v1014: i32 = v1014.clone();
                                                            let mut v1015: i32 = v1015.clone();
                                                            let mut v1016: i32 = v1016.clone();
                                                            let mut v1017: i32 = v1017.clone();
                                                            let mut v1018: bool = v1013 >= v1017;
                                                            if v1018 {
                                                                let mut v1019: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                                US10::US10_1(v1019.clone(), v1013, v1014, v1015, v1016, v1017)
                                                            } else {
                                                                let mut v1021: u8 = v0.clone().as_bytes()[v1013 as usize];
                                                                let mut v1022: i32 = v1013 + 1i32;
                                                                let mut v1023: bool = b'\n' == v1021;
                                                                let (mut v1027, mut v1028, mut v1029, mut v1030): (i32, i32, i32, i32) = if v1023 {
                                                                    let mut v1024: i32 = v1014 + v1016;
                                                                    let mut v1025: i32 = v1015 + 1i32;
                                                                    (v1024, v1025, 1i32, v1017)
                                                                } else {
                                                                    let mut v1026: i32 = v1016 + 1i32;
                                                                    (v1014, v1015, v1026, v1017)
                                                                };
                                                                US10::US10_0(v1021, v1022, v1027, v1028, v1029, v1030)
                                                            }
                                                        }
                                                        _ => unreachable!(),
                                                    };
                                                    let mut v1063: US11 = match &v1041 {
                                                        US10::US10_1(v1055, v1056, v1057, v1058, v1059, v1060) => { // Error
                                                            let mut v1055: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1055.clone();
                                                            let mut v1056: i32 = v1056.clone();
                                                            let mut v1057: i32 = v1057.clone();
                                                            let mut v1058: i32 = v1058.clone();
                                                            let mut v1059: i32 = v1059.clone();
                                                            let mut v1060: i32 = v1060.clone();
                                                            US11::US11_1(v1055.clone(), v1056, v1057, v1058, v1059, v1060)
                                                        }
                                                        US10::US10_0(v1042, v1043, v1044, v1045, v1046, v1047) => { // Ok
                                                            let mut v1042: u8 = v1042.clone();
                                                            let mut v1043: i32 = v1043.clone();
                                                            let mut v1044: i32 = v1044.clone();
                                                            let mut v1045: i32 = v1045.clone();
                                                            let mut v1046: i32 = v1046.clone();
                                                            let mut v1047: i32 = v1047.clone();
                                                            let mut v1048: bool = v878 >= v1043;
                                                            let mut v1053: Rc<str> = if v1048 {
                                                                let mut v1049: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                                v1049.clone()
                                                            } else {
                                                                let mut v1050: bool = v878 == v1043;
                                                                let mut v1051: i32 = v1043 - 1i32;
                                                                let mut v1052: Rc<str> = string_slice(&v0.clone(), v878 as i64, v1051 as i64);
                                                                v1052.clone()
                                                            };
                                                            US11::US11_0(v1053.clone(), v1043, v1044, v1045, v1046, v1047)
                                                        }
                                                        _ => unreachable!(),
                                                    };
                                                    match &v1063 {
                                                        US11::US11_1(v1070, v1071, v1072, v1073, v1074, v1075) => { // Error
                                                            let mut v1070: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1070.clone();
                                                            let mut v1071: i32 = v1071.clone();
                                                            let mut v1072: i32 = v1072.clone();
                                                            let mut v1073: i32 = v1073.clone();
                                                            let mut v1074: i32 = v1074.clone();
                                                            let mut v1075: i32 = v1075.clone();
                                                            let mut v1076: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                                            US11::US11_1(v1076.clone(), v878, v879, v880, v881, v882)
                                                        }
                                                        US11::US11_0(v1064, v1065, v1066, v1067, v1068, v1069) => { // Ok
                                                            let mut v1064: Rc<str> = v1064.clone();
                                                            let mut v1065: i32 = v1065.clone();
                                                            let mut v1066: i32 = v1066.clone();
                                                            let mut v1067: i32 = v1067.clone();
                                                            let mut v1068: i32 = v1068.clone();
                                                            let mut v1069: i32 = v1069.clone();
                                                            v1063.clone()
                                                        }
                                                        _ => unreachable!(),
                                                    }
                                                }
                                                US11::US11_0(v982, v983, v984, v985, v986, v987) => { // Ok
                                                    let mut v982: Rc<str> = v982.clone();
                                                    let mut v983: i32 = v983.clone();
                                                    let mut v984: i32 = v984.clone();
                                                    let mut v985: i32 = v985.clone();
                                                    let mut v986: i32 = v986.clone();
                                                    let mut v987: i32 = v987.clone();
                                                    v981.clone()
                                                }
                                                _ => unreachable!(),
                                            }
                                        }
                                        US11::US11_0(v899, v900, v901, v902, v903, v904) => { // Ok
                                            let mut v899: Rc<str> = v899.clone();
                                            let mut v900: i32 = v900.clone();
                                            let mut v901: i32 = v901.clone();
                                            let mut v902: i32 = v902.clone();
                                            let mut v903: i32 = v903.clone();
                                            let mut v904: i32 = v904.clone();
                                            v898.clone()
                                        }
                                        _ => unreachable!(),
                                    };
                                    let mut v1106: US11 = match &v1083 {
                                        US11::US11_1(v1084, v1085, v1086, v1087, v1088, v1089) => { // Error
                                            let mut v1084: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1084.clone();
                                            let mut v1085: i32 = v1085.clone();
                                            let mut v1086: i32 = v1086.clone();
                                            let mut v1087: i32 = v1087.clone();
                                            let mut v1088: i32 = v1088.clone();
                                            let mut v1089: i32 = v1089.clone();
                                            let mut v1090: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                            US11::US11_0(v1090.clone(), v878, v879, v880, v881, v882)
                                        }
                                        US11::US11_0(v1092, v1093, v1094, v1095, v1096, v1097) => { // Ok
                                            let mut v1092: Rc<str> = v1092.clone();
                                            let mut v1093: i32 = v1093.clone();
                                            let mut v1094: i32 = v1094.clone();
                                            let mut v1095: i32 = v1095.clone();
                                            let mut v1096: i32 = v1096.clone();
                                            let mut v1097: i32 = v1097.clone();
                                            let mut v1098: bool = v1093 == v878;
                                            if v1098 {
                                                let mut v1099: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                                US11::US11_1(v1099.clone(), v878, v879, v880, v881, v882)
                                            } else {
                                                let mut v1101: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                                let mut v1102: i32 = 0i32;
                                                method117(v0.clone(), v1101.clone(), v1092.clone(), v1102, v1093, v1094, v1095, v1096, v1097)
                                            }
                                        }
                                        _ => unreachable!(),
                                    };
                                    match &v1106 {
                                        US11::US11_1(v1149, v1150, v1151, v1152, v1153, v1154) => { // Error
                                            let mut v1149: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1149.clone();
                                            let mut v1150: i32 = v1150.clone();
                                            let mut v1151: i32 = v1151.clone();
                                            let mut v1152: i32 = v1152.clone();
                                            let mut v1153: i32 = v1153.clone();
                                            let mut v1154: i32 = v1154.clone();
                                            let mut v1155: bool = v878 >= v882;
                                            let mut v1173: US10 = if v1155 {
                                                let mut v1156: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                US10::US10_1(v1156.clone(), v878, v879, v880, v881, v882)
                                            } else {
                                                let mut v1158: u8 = v0.clone().as_bytes()[v878 as usize];
                                                let mut v1159: bool = v1158 == b'"';
                                                if v1159 {
                                                    let mut v1160: i32 = v878 + 1i32;
                                                    let mut v1161: bool = b'\n' == v1158;
                                                    let (mut v1165, mut v1166, mut v1167, mut v1168): (i32, i32, i32, i32) = if v1161 {
                                                        let mut v1162: i32 = v879 + v881;
                                                        let mut v1163: i32 = v880 + 1i32;
                                                        (v1162, v1163, 1i32, v882)
                                                    } else {
                                                        let mut v1164: i32 = v881 + 1i32;
                                                        (v879, v880, v1164, v882)
                                                    };
                                                    US10::US10_0(b'"', v1160, v1165, v1166, v1167, v1168)
                                                } else {
                                                    let mut v1170: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                    US10::US10_1(v1170.clone(), v878, v879, v880, v881, v882)
                                                }
                                            };
                                            match &v1173 {
                                                US10::US10_1(v1182, v1183, v1184, v1185, v1186, v1187) => { // Error
                                                    let mut v1182: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1182.clone();
                                                    let mut v1183: i32 = v1183.clone();
                                                    let mut v1184: i32 = v1184.clone();
                                                    let mut v1185: i32 = v1185.clone();
                                                    let mut v1186: i32 = v1186.clone();
                                                    let mut v1187: i32 = v1187.clone();
                                                    let mut v1188: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                                                    US11::US11_1(v1188.clone(), v878, v879, v880, v881, v882)
                                                }
                                                US10::US10_0(v1174, v1175, v1176, v1177, v1178, v1179) => { // Ok
                                                    let mut v1174: u8 = v1174.clone();
                                                    let mut v1175: i32 = v1175.clone();
                                                    let mut v1176: i32 = v1176.clone();
                                                    let mut v1177: i32 = v1177.clone();
                                                    let mut v1178: i32 = v1178.clone();
                                                    let mut v1179: i32 = v1179.clone();
                                                    let mut v1180: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                    US11::US11_0(v1180.clone(), v1175, v1176, v1177, v1178, v1179)
                                                }
                                                _ => unreachable!(),
                                            }
                                        }
                                        US11::US11_0(v1107, v1108, v1109, v1110, v1111, v1112) => { // Ok
                                            let mut v1107: Rc<str> = v1107.clone();
                                            let mut v1108: i32 = v1108.clone();
                                            let mut v1109: i32 = v1109.clone();
                                            let mut v1110: i32 = v1110.clone();
                                            let mut v1111: i32 = v1111.clone();
                                            let mut v1112: i32 = v1112.clone();
                                            let mut v1113: bool = v1108 >= v1112;
                                            let mut v1131: US10 = if v1113 {
                                                let mut v1114: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                                US10::US10_1(v1114.clone(), v1108, v1109, v1110, v1111, v1112)
                                            } else {
                                                let mut v1116: u8 = v0.clone().as_bytes()[v1108 as usize];
                                                let mut v1117: bool = v1116 == b'"';
                                                if v1117 {
                                                    let mut v1118: i32 = v1108 + 1i32;
                                                    let mut v1119: bool = b'\n' == v1116;
                                                    let (mut v1123, mut v1124, mut v1125, mut v1126): (i32, i32, i32, i32) = if v1119 {
                                                        let mut v1120: i32 = v1109 + v1111;
                                                        let mut v1121: i32 = v1110 + 1i32;
                                                        (v1120, v1121, 1i32, v1112)
                                                    } else {
                                                        let mut v1122: i32 = v1111 + 1i32;
                                                        (v1109, v1110, v1122, v1112)
                                                    };
                                                    US10::US10_0(b'"', v1118, v1123, v1124, v1125, v1126)
                                                } else {
                                                    let mut v1128: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                                    US10::US10_1(v1128.clone(), v1108, v1109, v1110, v1111, v1112)
                                                }
                                            };
                                            match &v1131 {
                                                US10::US10_1(v1139, v1140, v1141, v1142, v1143, v1144) => { // Error
                                                    let mut v1139: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1139.clone();
                                                    let mut v1140: i32 = v1140.clone();
                                                    let mut v1141: i32 = v1141.clone();
                                                    let mut v1142: i32 = v1142.clone();
                                                    let mut v1143: i32 = v1143.clone();
                                                    let mut v1144: i32 = v1144.clone();
                                                    let mut v1145: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v878, v1108, v1139.clone(), v1140, v1141, v1142, v1143, v1144);
                                                    US11::US11_1(v1145.clone(), v1108, v1109, v1110, v1111, v1112)
                                                }
                                                US10::US10_0(v1132, v1133, v1134, v1135, v1136, v1137) => { // Ok
                                                    let mut v1132: u8 = v1132.clone();
                                                    let mut v1133: i32 = v1133.clone();
                                                    let mut v1134: i32 = v1134.clone();
                                                    let mut v1135: i32 = v1135.clone();
                                                    let mut v1136: i32 = v1136.clone();
                                                    let mut v1137: i32 = v1137.clone();
                                                    US11::US11_0(v1107.clone(), v1133, v1134, v1135, v1136, v1137)
                                                }
                                                _ => unreachable!(),
                                            }
                                        }
                                        _ => unreachable!(),
                                    }
                                }
                                _ => unreachable!(),
                            }
                        }
                        US11::US11_0(v847, v848, v849, v850, v851, v852) => { // Ok
                            let mut v847: Rc<str> = v847.clone();
                            let mut v848: i32 = v848.clone();
                            let mut v849: i32 = v849.clone();
                            let mut v850: i32 = v850.clone();
                            let mut v851: i32 = v851.clone();
                            let mut v852: i32 = v852.clone();
                            v846.clone()
                        }
                        _ => unreachable!(),
                    };
                    let mut v1234: US11 = match &v1204 {
                        US11::US11_1(v1211, v1212, v1213, v1214, v1215, v1216) => { // Error
                            let mut v1211: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1211.clone();
                            let mut v1212: i32 = v1212.clone();
                            let mut v1213: i32 = v1213.clone();
                            let mut v1214: i32 = v1214.clone();
                            let mut v1215: i32 = v1215.clone();
                            let mut v1216: i32 = v1216.clone();
                            let (mut v1217, mut v1218, mut v1219, mut v1220, mut v1221): (i32, i32, i32, i32, i32) = method124(v41, v42, v43, v44, v0.clone(), v40);
                            let mut v1222: bool = v1217 > v40;
                            if v1222 {
                                let mut v1223: bool = v40 >= v1217;
                                let mut v1228: Rc<str> = if v1223 {
                                    let mut v1224: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    v1224.clone()
                                } else {
                                    let mut v1225: bool = v40 == v1217;
                                    let mut v1226: i32 = v1217 - 1i32;
                                    let mut v1227: Rc<str> = string_slice(&v0.clone(), v40 as i64, v1226 as i64);
                                    v1227.clone()
                                };
                                US11::US11_0(v1228.clone(), v1217, v1218, v1219, v1220, v1221)
                            } else {
                                let mut v1230: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                                US11::US11_1(v1230.clone(), v40, v41, v42, v43, v44)
                            }
                        }
                        US11::US11_0(v1205, v1206, v1207, v1208, v1209, v1210) => { // Ok
                            let mut v1205: Rc<str> = v1205.clone();
                            let mut v1206: i32 = v1206.clone();
                            let mut v1207: i32 = v1207.clone();
                            let mut v1208: i32 = v1208.clone();
                            let mut v1209: i32 = v1209.clone();
                            let mut v1210: i32 = v1210.clone();
                            v1204.clone()
                        }
                        _ => unreachable!(),
                    };
                    let mut v1269: US11 = match &v1234 {
                        US11::US11_1(v1241, v1242, v1243, v1244, v1245, v1246) => { // Error
                            let mut v1241: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1241.clone();
                            let mut v1242: i32 = v1242.clone();
                            let mut v1243: i32 = v1243.clone();
                            let mut v1244: i32 = v1244.clone();
                            let mut v1245: i32 = v1245.clone();
                            let mut v1246: i32 = v1246.clone();
                            let mut v1247: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
                            let mut v1248: US19 = method120(v0.clone(), v1247.clone(), v40, v41, v42, v43, v44);
                            match &v1248 {
                                US19::US19_1(v1259, v1260, v1261, v1262, v1263, v1264) => { // Error
                                    let mut v1259: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1259.clone();
                                    let mut v1260: i32 = v1260.clone();
                                    let mut v1261: i32 = v1261.clone();
                                    let mut v1262: i32 = v1262.clone();
                                    let mut v1263: i32 = v1263.clone();
                                    let mut v1264: i32 = v1264.clone();
                                    US11::US11_1(v1259.clone(), v1260, v1261, v1262, v1263, v1264)
                                }
                                US19::US19_0(v1249, v1250, v1251, v1252, v1253, v1254) => { // Ok
                                    let mut v1249: Rc<UH0> = v1249.clone();
                                    let mut v1250: i32 = v1250.clone();
                                    let mut v1251: i32 = v1251.clone();
                                    let mut v1252: i32 = v1252.clone();
                                    let mut v1253: i32 = v1253.clone();
                                    let mut v1254: i32 = v1254.clone();
                                    let mut v1255: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    let (mut v1256, mut v1257): (Rc<str>, Rc<str>) = method122(v1249.clone(), v1255.clone());
                                    US11::US11_0(v1256.clone(), v1250, v1251, v1252, v1253, v1254)
                                }
                                _ => unreachable!(),
                            }
                        }
                        US11::US11_0(v1235, v1236, v1237, v1238, v1239, v1240) => { // Ok
                            let mut v1235: Rc<str> = v1235.clone();
                            let mut v1236: i32 = v1236.clone();
                            let mut v1237: i32 = v1237.clone();
                            let mut v1238: i32 = v1238.clone();
                            let mut v1239: i32 = v1239.clone();
                            let mut v1240: i32 = v1240.clone();
                            v1234.clone()
                        }
                        _ => unreachable!(),
                    };
                    let mut v1280: US11 = match &v1269 {
                        US11::US11_0(v1270, v1271, v1272, v1273, v1274, v1275) => { // Ok
                            let mut v1270: Rc<str> = v1270.clone();
                            let mut v1271: i32 = v1271.clone();
                            let mut v1272: i32 = v1272.clone();
                            let mut v1273: i32 = v1273.clone();
                            let mut v1274: i32 = v1274.clone();
                            let mut v1275: i32 = v1275.clone();
                            let mut v1276: bool = v1271 == v40;
                            if v1276 {
                                let mut v1277: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure48();
                                US11::US11_1(v1277.clone(), v40, v41, v42, v43, v44)
                            } else {
                                v1269.clone()
                            }
                        }
                        _ => {
                            v1269.clone()
                        }
                    };
                    let mut v1297: US11 = match &v1280 {
                        US11::US11_1(v1281, v1282, v1283, v1284, v1285, v1286) => { // Error
                            let mut v1281: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1281.clone();
                            let mut v1282: i32 = v1282.clone();
                            let mut v1283: i32 = v1283.clone();
                            let mut v1284: i32 = v1284.clone();
                            let mut v1285: i32 = v1285.clone();
                            let mut v1286: i32 = v1286.clone();
                            US11::US11_1(v1281.clone(), v1282, v1283, v1284, v1285, v1286)
                        }
                        US11::US11_0(v1288, v1289, v1290, v1291, v1292, v1293) => { // Ok
                            let mut v1288: Rc<str> = v1288.clone();
                            let mut v1289: i32 = v1289.clone();
                            let mut v1290: i32 = v1290.clone();
                            let mut v1291: i32 = v1291.clone();
                            let mut v1292: i32 = v1292.clone();
                            let mut v1293: i32 = v1293.clone();
                            let mut v1294: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
                            method123(v0.clone(), v1288.clone(), v1294.clone(), v1289, v1290, v1291, v1292, v1293)
                        }
                        _ => unreachable!(),
                    };
                    match &v1297 {
                        US11::US11_1(v1306, v1307, v1308, v1309, v1310, v1311) => { // Error
                            let mut v1306: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1306.clone();
                            let mut v1307: i32 = v1307.clone();
                            let mut v1308: i32 = v1308.clone();
                            let mut v1309: i32 = v1309.clone();
                            let mut v1310: i32 = v1310.clone();
                            let mut v1311: i32 = v1311.clone();
                            let mut v1312: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
                            let mut v1313: Rc<UH0> = method121(v1.clone(), v1312.clone());
                            return US19::US19_0(v1313.clone(), v2, v3, v4, v5, v6);
                        }
                        US11::US11_0(v1298, v1299, v1300, v1301, v1302, v1303) => { // Ok
                            let mut v1298: Rc<str> = v1298.clone();
                            let mut v1299: i32 = v1299.clone();
                            let mut v1300: i32 = v1300.clone();
                            let mut v1301: i32 = v1301.clone();
                            let mut v1302: i32 = v1302.clone();
                            let mut v1303: i32 = v1303.clone();
                            let mut v1304: Rc<UH0> = Rc::new(UH0::UH0_1(v1298.clone(), v1.clone()));
                            (v0, v1, v2, v3, v4, v5, v6) = (v0.clone(), v1304.clone(), v1299, v1300, v1301, v1302, v1303);
                            continue;
                        }
                        _ => unreachable!(),
                    }
                }
            }
            _ => unreachable!(),
        }
    }
}
fn method131(mut v0: Rc<UH0>, mut v1: i32) -> i32 {
    loop {
        match &*v0 {
            UH0::UH0_1(v2, v3) => { // Cons
                let mut v2: Rc<str> = v2.clone();
                let mut v3: Rc<UH0> = v3.clone();
                let mut v4: i32 = v1 + 1i32;
                (v0, v1) = (v3.clone(), v4);
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v1;
            }
            _ => unreachable!(),
        }
    }
}
fn method132(mut v0: Rc<RefCell<Vec<Rc<str>>>>, mut v1: Rc<UH0>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH0::UH0_1(v3, v4) => { // Cons
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<UH0> = v4.clone();
                v0.borrow_mut().push(v3);
                let mut v5: i32 = v2 + 1i32;
                (v0, v1, v2) = (v0.clone(), v4.clone(), v5);
                continue;
            }
            UH0::UH0_0 => { // Nil
                return v2;
            }
            _ => unreachable!(),
        }
    }
}
fn method110(mut v0: Rc<str>) -> US18 {
    let mut v1: i32 = (v0.clone().len() as i32);
    let mut v2: bool = 0i32 >= v1;
    let mut v16: US10 = if v2 {
        let mut v3: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
        US10::US10_1(v3.clone(), 0i32, 0i32, 1i32, 1i32, v1)
    } else {
        let mut v5: u8 = v0.clone().as_bytes()[0i32 as usize];
        let mut v6: bool = v5 == b'\\';
        if v6 {
            let mut v7: bool = b'\n' == v5;
            let (mut v8, mut v9, mut v10, mut v11): (i32, i32, i32, i32) = if v7 {
                (1i32, 2i32, 1i32, v1)
            } else {
                (0i32, 1i32, 2i32, v1)
            };
            US10::US10_0(b'\\', 1i32, v8, v9, v10, v11)
        } else {
            let mut v13: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
            US10::US10_1(v13.clone(), 0i32, 0i32, 1i32, 1i32, v1)
        }
    };
    let mut v50: US10 = match &v16 {
        US10::US10_1(v42, v43, v44, v45, v46, v47) => { // Error
            let mut v42: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v42.clone();
            let mut v43: i32 = v43.clone();
            let mut v44: i32 = v44.clone();
            let mut v45: i32 = v45.clone();
            let mut v46: i32 = v46.clone();
            let mut v47: i32 = v47.clone();
            US10::US10_1(v42.clone(), v43, v44, v45, v46, v47)
        }
        US10::US10_0(v17, v18, v19, v20, v21, v22) => { // Ok
            let mut v17: u8 = v17.clone();
            let mut v18: i32 = v18.clone();
            let mut v19: i32 = v19.clone();
            let mut v20: i32 = v20.clone();
            let mut v21: i32 = v21.clone();
            let mut v22: i32 = v22.clone();
            let mut v23: bool = v18 >= v22;
            if v23 {
                let mut v24: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                US10::US10_1(v24.clone(), v18, v19, v20, v21, v22)
            } else {
                let mut v26: u8 = v0.clone().as_bytes()[v18 as usize];
                let mut v27: bool = v26 == b'"';
                if v27 {
                    let mut v28: i32 = v18 + 1i32;
                    let mut v29: bool = b'\n' == v26;
                    let (mut v33, mut v34, mut v35, mut v36): (i32, i32, i32, i32) = if v29 {
                        let mut v30: i32 = v19 + v21;
                        let mut v31: i32 = v20 + 1i32;
                        (v30, v31, 1i32, v22)
                    } else {
                        let mut v32: i32 = v21 + 1i32;
                        (v19, v20, v32, v22)
                    };
                    US10::US10_0(b'"', v28, v33, v34, v35, v36)
                } else {
                    let mut v38: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                    US10::US10_1(v38.clone(), v18, v19, v20, v21, v22)
                }
            }
        }
        _ => unreachable!(),
    };
    let mut v66: US10 = match &v50 {
        US10::US10_1(v58, v59, v60, v61, v62, v63) => { // Error
            let mut v58: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v58.clone();
            let mut v59: i32 = v59.clone();
            let mut v60: i32 = v60.clone();
            let mut v61: i32 = v61.clone();
            let mut v62: i32 = v62.clone();
            let mut v63: i32 = v63.clone();
            US10::US10_1(v58.clone(), v59, v60, v61, v62, v63)
        }
        US10::US10_0(v51, v52, v53, v54, v55, v56) => { // Ok
            let mut v51: u8 = v51.clone();
            let mut v52: i32 = v52.clone();
            let mut v53: i32 = v53.clone();
            let mut v54: i32 = v54.clone();
            let mut v55: i32 = v55.clone();
            let mut v56: i32 = v56.clone();
            US10::US10_0(b'"', v52, v53, v54, v55, v56)
        }
        _ => unreachable!(),
    };
    let mut v160: US10 = match &v66 {
        US10::US10_1(v73, v74, v75, v76, v77, v78) => { // Error
            let mut v73: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v73.clone();
            let mut v74: i32 = v74.clone();
            let mut v75: i32 = v75.clone();
            let mut v76: i32 = v76.clone();
            let mut v77: i32 = v77.clone();
            let mut v78: i32 = v78.clone();
            let mut v92: US10 = if v2 {
                let mut v79: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                US10::US10_1(v79.clone(), 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let mut v81: u8 = v0.clone().as_bytes()[0i32 as usize];
                let mut v82: bool = v81 == b'`';
                if v82 {
                    let mut v83: bool = b'\n' == v81;
                    let (mut v84, mut v85, mut v86, mut v87): (i32, i32, i32, i32) = if v83 {
                        (1i32, 2i32, 1i32, v1)
                    } else {
                        (0i32, 1i32, 2i32, v1)
                    };
                    US10::US10_0(b'`', 1i32, v84, v85, v86, v87)
                } else {
                    let mut v89: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                    US10::US10_1(v89.clone(), 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            let mut v126: US10 = match &v92 {
                US10::US10_1(v118, v119, v120, v121, v122, v123) => { // Error
                    let mut v118: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v118.clone();
                    let mut v119: i32 = v119.clone();
                    let mut v120: i32 = v120.clone();
                    let mut v121: i32 = v121.clone();
                    let mut v122: i32 = v122.clone();
                    let mut v123: i32 = v123.clone();
                    US10::US10_1(v118.clone(), v119, v120, v121, v122, v123)
                }
                US10::US10_0(v93, v94, v95, v96, v97, v98) => { // Ok
                    let mut v93: u8 = v93.clone();
                    let mut v94: i32 = v94.clone();
                    let mut v95: i32 = v95.clone();
                    let mut v96: i32 = v96.clone();
                    let mut v97: i32 = v97.clone();
                    let mut v98: i32 = v98.clone();
                    let mut v99: bool = v94 >= v98;
                    if v99 {
                        let mut v100: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                        US10::US10_1(v100.clone(), v94, v95, v96, v97, v98)
                    } else {
                        let mut v102: u8 = v0.clone().as_bytes()[v94 as usize];
                        let mut v103: bool = v102 == b'"';
                        if v103 {
                            let mut v104: i32 = v94 + 1i32;
                            let mut v105: bool = b'\n' == v102;
                            let (mut v109, mut v110, mut v111, mut v112): (i32, i32, i32, i32) = if v105 {
                                let mut v106: i32 = v95 + v97;
                                let mut v107: i32 = v96 + 1i32;
                                (v106, v107, 1i32, v98)
                            } else {
                                let mut v108: i32 = v97 + 1i32;
                                (v95, v96, v108, v98)
                            };
                            US10::US10_0(b'"', v104, v109, v110, v111, v112)
                        } else {
                            let mut v114: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                            US10::US10_1(v114.clone(), v94, v95, v96, v97, v98)
                        }
                    }
                }
                _ => unreachable!(),
            };
            let mut v142: US10 = match &v126 {
                US10::US10_1(v134, v135, v136, v137, v138, v139) => { // Error
                    let mut v134: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v134.clone();
                    let mut v135: i32 = v135.clone();
                    let mut v136: i32 = v136.clone();
                    let mut v137: i32 = v137.clone();
                    let mut v138: i32 = v138.clone();
                    let mut v139: i32 = v139.clone();
                    US10::US10_1(v134.clone(), v135, v136, v137, v138, v139)
                }
                US10::US10_0(v127, v128, v129, v130, v131, v132) => { // Ok
                    let mut v127: u8 = v127.clone();
                    let mut v128: i32 = v128.clone();
                    let mut v129: i32 = v129.clone();
                    let mut v130: i32 = v130.clone();
                    let mut v131: i32 = v131.clone();
                    let mut v132: i32 = v132.clone();
                    US10::US10_0(b'"', v128, v129, v130, v131, v132)
                }
                _ => unreachable!(),
            };
            match &v142 {
                US10::US10_1(v149, v150, v151, v152, v153, v154) => { // Error
                    let mut v149: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v149.clone();
                    let mut v150: i32 = v150.clone();
                    let mut v151: i32 = v151.clone();
                    let mut v152: i32 = v152.clone();
                    let mut v153: i32 = v153.clone();
                    let mut v154: i32 = v154.clone();
                    let mut v155: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                    US10::US10_1(v155.clone(), 0i32, 0i32, 1i32, 1i32, v1)
                }
                US10::US10_0(v143, v144, v145, v146, v147, v148) => { // Ok
                    let mut v143: u8 = v143.clone();
                    let mut v144: i32 = v144.clone();
                    let mut v145: i32 = v145.clone();
                    let mut v146: i32 = v146.clone();
                    let mut v147: i32 = v147.clone();
                    let mut v148: i32 = v148.clone();
                    v142.clone()
                }
                _ => unreachable!(),
            }
        }
        US10::US10_0(v67, v68, v69, v70, v71, v72) => { // Ok
            let mut v67: u8 = v67.clone();
            let mut v68: i32 = v68.clone();
            let mut v69: i32 = v69.clone();
            let mut v70: i32 = v70.clone();
            let mut v71: i32 = v71.clone();
            let mut v72: i32 = v72.clone();
            v66.clone()
        }
        _ => unreachable!(),
    };
    let mut v792: US11 = match &v160 {
        US10::US10_1(v784, v785, v786, v787, v788, v789) => { // Error
            let mut v784: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v784.clone();
            let mut v785: i32 = v785.clone();
            let mut v786: i32 = v786.clone();
            let mut v787: i32 = v787.clone();
            let mut v788: i32 = v788.clone();
            let mut v789: i32 = v789.clone();
            US11::US11_1(v784.clone(), v785, v786, v787, v788, v789)
        }
        US10::US10_0(v161, v162, v163, v164, v165, v166) => { // Ok
            let mut v161: u8 = v161.clone();
            let mut v162: i32 = v162.clone();
            let mut v163: i32 = v163.clone();
            let mut v164: i32 = v164.clone();
            let mut v165: i32 = v165.clone();
            let mut v166: i32 = v166.clone();
            let (mut v167, mut v168, mut v169, mut v170, mut v171): (i32, i32, i32, i32, i32) = method111(v163, v164, v165, v166, v0.clone(), v162);
            let mut v172: bool = v167 > v162;
            let mut v182: US11 = if v172 {
                let mut v173: bool = v162 >= v167;
                let mut v178: Rc<str> = if v173 {
                    let mut v174: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v174.clone()
                } else {
                    let mut v175: bool = v162 == v167;
                    let mut v176: i32 = v167 - 1i32;
                    let mut v177: Rc<str> = string_slice(&v0.clone(), v162 as i64, v176 as i64);
                    v177.clone()
                };
                US11::US11_0(v178.clone(), v167, v168, v169, v170, v171)
            } else {
                let mut v180: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                US11::US11_1(v180.clone(), v162, v163, v164, v165, v166)
            };
            let mut v377: US11 = match &v182 {
                US11::US11_1(v189, v190, v191, v192, v193, v194) => { // Error
                    let mut v189: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v189.clone();
                    let mut v190: i32 = v190.clone();
                    let mut v191: i32 = v191.clone();
                    let mut v192: i32 = v192.clone();
                    let mut v193: i32 = v193.clone();
                    let mut v194: i32 = v194.clone();
                    let mut v195: bool = v162 >= v166;
                    let mut v213: US10 = if v195 {
                        let mut v196: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                        US10::US10_1(v196.clone(), v162, v163, v164, v165, v166)
                    } else {
                        let mut v198: u8 = v0.clone().as_bytes()[v162 as usize];
                        let mut v199: bool = v198 == b'\\';
                        if v199 {
                            let mut v200: i32 = v162 + 1i32;
                            let mut v201: bool = b'\n' == v198;
                            let (mut v205, mut v206, mut v207, mut v208): (i32, i32, i32, i32) = if v201 {
                                let mut v202: i32 = v163 + v165;
                                let mut v203: i32 = v164 + 1i32;
                                (v202, v203, 1i32, v166)
                            } else {
                                let mut v204: i32 = v165 + 1i32;
                                (v163, v164, v204, v166)
                            };
                            US10::US10_0(b'\\', v200, v205, v206, v207, v208)
                        } else {
                            let mut v210: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                            US10::US10_1(v210.clone(), v162, v163, v164, v165, v166)
                        }
                    };
                    let mut v248: US10 = match &v213 {
                        US10::US10_1(v240, v241, v242, v243, v244, v245) => { // Error
                            let mut v240: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v240.clone();
                            let mut v241: i32 = v241.clone();
                            let mut v242: i32 = v242.clone();
                            let mut v243: i32 = v243.clone();
                            let mut v244: i32 = v244.clone();
                            let mut v245: i32 = v245.clone();
                            US10::US10_1(v240.clone(), v241, v242, v243, v244, v245)
                        }
                        US10::US10_0(v214, v215, v216, v217, v218, v219) => { // Ok
                            let mut v214: u8 = v214.clone();
                            let mut v215: i32 = v215.clone();
                            let mut v216: i32 = v216.clone();
                            let mut v217: i32 = v217.clone();
                            let mut v218: i32 = v218.clone();
                            let mut v219: i32 = v219.clone();
                            let mut v220: bool = v215 >= v219;
                            if v220 {
                                let mut v221: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                US10::US10_1(v221.clone(), v215, v216, v217, v218, v219)
                            } else {
                                let mut v223: u8 = v0.clone().as_bytes()[v215 as usize];
                                let mut v224: bool = v223 == b'"';
                                let mut v225: bool = v224 == false;
                                if v225 {
                                    let mut v226: i32 = v215 + 1i32;
                                    let mut v227: bool = b'\n' == v223;
                                    let (mut v231, mut v232, mut v233, mut v234): (i32, i32, i32, i32) = if v227 {
                                        let mut v228: i32 = v216 + v218;
                                        let mut v229: i32 = v217 + 1i32;
                                        (v228, v229, 1i32, v219)
                                    } else {
                                        let mut v230: i32 = v218 + 1i32;
                                        (v216, v217, v230, v219)
                                    };
                                    US10::US10_0(v223, v226, v231, v232, v233, v234)
                                } else {
                                    let mut v236: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                    US10::US10_1(v236.clone(), v215, v216, v217, v218, v219)
                                }
                            }
                        }
                        _ => unreachable!(),
                    };
                    let mut v270: US11 = match &v248 {
                        US10::US10_1(v262, v263, v264, v265, v266, v267) => { // Error
                            let mut v262: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v262.clone();
                            let mut v263: i32 = v263.clone();
                            let mut v264: i32 = v264.clone();
                            let mut v265: i32 = v265.clone();
                            let mut v266: i32 = v266.clone();
                            let mut v267: i32 = v267.clone();
                            US11::US11_1(v262.clone(), v263, v264, v265, v266, v267)
                        }
                        US10::US10_0(v249, v250, v251, v252, v253, v254) => { // Ok
                            let mut v249: u8 = v249.clone();
                            let mut v250: i32 = v250.clone();
                            let mut v251: i32 = v251.clone();
                            let mut v252: i32 = v252.clone();
                            let mut v253: i32 = v253.clone();
                            let mut v254: i32 = v254.clone();
                            let mut v255: bool = v162 >= v250;
                            let mut v260: Rc<str> = if v255 {
                                let mut v256: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                v256.clone()
                            } else {
                                let mut v257: bool = v162 == v250;
                                let mut v258: i32 = v250 - 1i32;
                                let mut v259: Rc<str> = string_slice(&v0.clone(), v162 as i64, v258 as i64);
                                v259.clone()
                            };
                            US11::US11_0(v260.clone(), v250, v251, v252, v253, v254)
                        }
                        _ => unreachable!(),
                    };
                    match &v270 {
                        US11::US11_1(v277, v278, v279, v280, v281, v282) => { // Error
                            let mut v277: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v277.clone();
                            let mut v278: i32 = v278.clone();
                            let mut v279: i32 = v279.clone();
                            let mut v280: i32 = v280.clone();
                            let mut v281: i32 = v281.clone();
                            let mut v282: i32 = v282.clone();
                            let mut v300: US10 = if v195 {
                                let mut v283: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                US10::US10_1(v283.clone(), v162, v163, v164, v165, v166)
                            } else {
                                let mut v285: u8 = v0.clone().as_bytes()[v162 as usize];
                                let mut v286: bool = v285 == b'`';
                                if v286 {
                                    let mut v287: i32 = v162 + 1i32;
                                    let mut v288: bool = b'\n' == v285;
                                    let (mut v292, mut v293, mut v294, mut v295): (i32, i32, i32, i32) = if v288 {
                                        let mut v289: i32 = v163 + v165;
                                        let mut v290: i32 = v164 + 1i32;
                                        (v289, v290, 1i32, v166)
                                    } else {
                                        let mut v291: i32 = v165 + 1i32;
                                        (v163, v164, v291, v166)
                                    };
                                    US10::US10_0(b'`', v287, v292, v293, v294, v295)
                                } else {
                                    let mut v297: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                    US10::US10_1(v297.clone(), v162, v163, v164, v165, v166)
                                }
                            };
                            let mut v335: US10 = match &v300 {
                                US10::US10_1(v327, v328, v329, v330, v331, v332) => { // Error
                                    let mut v327: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v327.clone();
                                    let mut v328: i32 = v328.clone();
                                    let mut v329: i32 = v329.clone();
                                    let mut v330: i32 = v330.clone();
                                    let mut v331: i32 = v331.clone();
                                    let mut v332: i32 = v332.clone();
                                    US10::US10_1(v327.clone(), v328, v329, v330, v331, v332)
                                }
                                US10::US10_0(v301, v302, v303, v304, v305, v306) => { // Ok
                                    let mut v301: u8 = v301.clone();
                                    let mut v302: i32 = v302.clone();
                                    let mut v303: i32 = v303.clone();
                                    let mut v304: i32 = v304.clone();
                                    let mut v305: i32 = v305.clone();
                                    let mut v306: i32 = v306.clone();
                                    let mut v307: bool = v302 >= v306;
                                    if v307 {
                                        let mut v308: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure40();
                                        US10::US10_1(v308.clone(), v302, v303, v304, v305, v306)
                                    } else {
                                        let mut v310: u8 = v0.clone().as_bytes()[v302 as usize];
                                        let mut v311: bool = v310 == b'"';
                                        let mut v312: bool = v311 == false;
                                        if v312 {
                                            let mut v313: i32 = v302 + 1i32;
                                            let mut v314: bool = b'\n' == v310;
                                            let (mut v318, mut v319, mut v320, mut v321): (i32, i32, i32, i32) = if v314 {
                                                let mut v315: i32 = v303 + v305;
                                                let mut v316: i32 = v304 + 1i32;
                                                (v315, v316, 1i32, v306)
                                            } else {
                                                let mut v317: i32 = v305 + 1i32;
                                                (v303, v304, v317, v306)
                                            };
                                            US10::US10_0(v310, v313, v318, v319, v320, v321)
                                        } else {
                                            let mut v323: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure41();
                                            US10::US10_1(v323.clone(), v302, v303, v304, v305, v306)
                                        }
                                    }
                                }
                                _ => unreachable!(),
                            };
                            let mut v357: US11 = match &v335 {
                                US10::US10_1(v349, v350, v351, v352, v353, v354) => { // Error
                                    let mut v349: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v349.clone();
                                    let mut v350: i32 = v350.clone();
                                    let mut v351: i32 = v351.clone();
                                    let mut v352: i32 = v352.clone();
                                    let mut v353: i32 = v353.clone();
                                    let mut v354: i32 = v354.clone();
                                    US11::US11_1(v349.clone(), v350, v351, v352, v353, v354)
                                }
                                US10::US10_0(v336, v337, v338, v339, v340, v341) => { // Ok
                                    let mut v336: u8 = v336.clone();
                                    let mut v337: i32 = v337.clone();
                                    let mut v338: i32 = v338.clone();
                                    let mut v339: i32 = v339.clone();
                                    let mut v340: i32 = v340.clone();
                                    let mut v341: i32 = v341.clone();
                                    let mut v342: bool = v162 >= v337;
                                    let mut v347: Rc<str> = if v342 {
                                        let mut v343: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                        v343.clone()
                                    } else {
                                        let mut v344: bool = v162 == v337;
                                        let mut v345: i32 = v337 - 1i32;
                                        let mut v346: Rc<str> = string_slice(&v0.clone(), v162 as i64, v345 as i64);
                                        v346.clone()
                                    };
                                    US11::US11_0(v347.clone(), v337, v338, v339, v340, v341)
                                }
                                _ => unreachable!(),
                            };
                            match &v357 {
                                US11::US11_1(v364, v365, v366, v367, v368, v369) => { // Error
                                    let mut v364: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v364.clone();
                                    let mut v365: i32 = v365.clone();
                                    let mut v366: i32 = v366.clone();
                                    let mut v367: i32 = v367.clone();
                                    let mut v368: i32 = v368.clone();
                                    let mut v369: i32 = v369.clone();
                                    let mut v370: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US11::US11_1(v370.clone(), v162, v163, v164, v165, v166)
                                }
                                US11::US11_0(v358, v359, v360, v361, v362, v363) => { // Ok
                                    let mut v358: Rc<str> = v358.clone();
                                    let mut v359: i32 = v359.clone();
                                    let mut v360: i32 = v360.clone();
                                    let mut v361: i32 = v361.clone();
                                    let mut v362: i32 = v362.clone();
                                    let mut v363: i32 = v363.clone();
                                    v357.clone()
                                }
                                _ => unreachable!(),
                            }
                        }
                        US11::US11_0(v271, v272, v273, v274, v275, v276) => { // Ok
                            let mut v271: Rc<str> = v271.clone();
                            let mut v272: i32 = v272.clone();
                            let mut v273: i32 = v273.clone();
                            let mut v274: i32 = v274.clone();
                            let mut v275: i32 = v275.clone();
                            let mut v276: i32 = v276.clone();
                            v270.clone()
                        }
                        _ => unreachable!(),
                    }
                }
                US11::US11_0(v183, v184, v185, v186, v187, v188) => { // Ok
                    let mut v183: Rc<str> = v183.clone();
                    let mut v184: i32 = v184.clone();
                    let mut v185: i32 = v185.clone();
                    let mut v186: i32 = v186.clone();
                    let mut v187: i32 = v187.clone();
                    let mut v188: i32 = v188.clone();
                    v182.clone()
                }
                _ => unreachable!(),
            };
            let mut v400: US11 = match &v377 {
                US11::US11_1(v378, v379, v380, v381, v382, v383) => { // Error
                    let mut v378: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v378.clone();
                    let mut v379: i32 = v379.clone();
                    let mut v380: i32 = v380.clone();
                    let mut v381: i32 = v381.clone();
                    let mut v382: i32 = v382.clone();
                    let mut v383: i32 = v383.clone();
                    let mut v384: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    US11::US11_0(v384.clone(), v162, v163, v164, v165, v166)
                }
                US11::US11_0(v386, v387, v388, v389, v390, v391) => { // Ok
                    let mut v386: Rc<str> = v386.clone();
                    let mut v387: i32 = v387.clone();
                    let mut v388: i32 = v388.clone();
                    let mut v389: i32 = v389.clone();
                    let mut v390: i32 = v390.clone();
                    let mut v391: i32 = v391.clone();
                    let mut v392: bool = v387 == v162;
                    if v392 {
                        let mut v393: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                        US11::US11_1(v393.clone(), v162, v163, v164, v165, v166)
                    } else {
                        let mut v395: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                        let mut v396: i32 = 0i32;
                        method115(v0.clone(), v395.clone(), v386.clone(), v396, v387, v388, v389, v390, v391)
                    }
                }
                _ => unreachable!(),
            };
            match &v400 {
                US11::US11_1(v591, v592, v593, v594, v595, v596) => { // Error
                    let mut v591: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v591.clone();
                    let mut v592: i32 = v592.clone();
                    let mut v593: i32 = v593.clone();
                    let mut v594: i32 = v594.clone();
                    let mut v595: i32 = v595.clone();
                    let mut v596: i32 = v596.clone();
                    let mut v597: bool = v162 >= v166;
                    let mut v615: US10 = if v597 {
                        let mut v598: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                        US10::US10_1(v598.clone(), v162, v163, v164, v165, v166)
                    } else {
                        let mut v600: u8 = v0.clone().as_bytes()[v162 as usize];
                        let mut v601: bool = v600 == b'\\';
                        if v601 {
                            let mut v602: i32 = v162 + 1i32;
                            let mut v603: bool = b'\n' == v600;
                            let (mut v607, mut v608, mut v609, mut v610): (i32, i32, i32, i32) = if v603 {
                                let mut v604: i32 = v163 + v165;
                                let mut v605: i32 = v164 + 1i32;
                                (v604, v605, 1i32, v166)
                            } else {
                                let mut v606: i32 = v165 + 1i32;
                                (v163, v164, v606, v166)
                            };
                            US10::US10_0(b'\\', v602, v607, v608, v609, v610)
                        } else {
                            let mut v612: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                            US10::US10_1(v612.clone(), v162, v163, v164, v165, v166)
                        }
                    };
                    let mut v649: US10 = match &v615 {
                        US10::US10_1(v641, v642, v643, v644, v645, v646) => { // Error
                            let mut v641: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v641.clone();
                            let mut v642: i32 = v642.clone();
                            let mut v643: i32 = v643.clone();
                            let mut v644: i32 = v644.clone();
                            let mut v645: i32 = v645.clone();
                            let mut v646: i32 = v646.clone();
                            US10::US10_1(v641.clone(), v642, v643, v644, v645, v646)
                        }
                        US10::US10_0(v616, v617, v618, v619, v620, v621) => { // Ok
                            let mut v616: u8 = v616.clone();
                            let mut v617: i32 = v617.clone();
                            let mut v618: i32 = v618.clone();
                            let mut v619: i32 = v619.clone();
                            let mut v620: i32 = v620.clone();
                            let mut v621: i32 = v621.clone();
                            let mut v622: bool = v617 >= v621;
                            if v622 {
                                let mut v623: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_1(v623.clone(), v617, v618, v619, v620, v621)
                            } else {
                                let mut v625: u8 = v0.clone().as_bytes()[v617 as usize];
                                let mut v626: bool = v625 == b'"';
                                if v626 {
                                    let mut v627: i32 = v617 + 1i32;
                                    let mut v628: bool = b'\n' == v625;
                                    let (mut v632, mut v633, mut v634, mut v635): (i32, i32, i32, i32) = if v628 {
                                        let mut v629: i32 = v618 + v620;
                                        let mut v630: i32 = v619 + 1i32;
                                        (v629, v630, 1i32, v621)
                                    } else {
                                        let mut v631: i32 = v620 + 1i32;
                                        (v618, v619, v631, v621)
                                    };
                                    US10::US10_0(b'"', v627, v632, v633, v634, v635)
                                } else {
                                    let mut v637: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_1(v637.clone(), v617, v618, v619, v620, v621)
                                }
                            }
                        }
                        _ => unreachable!(),
                    };
                    let mut v665: US10 = match &v649 {
                        US10::US10_1(v657, v658, v659, v660, v661, v662) => { // Error
                            let mut v657: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v657.clone();
                            let mut v658: i32 = v658.clone();
                            let mut v659: i32 = v659.clone();
                            let mut v660: i32 = v660.clone();
                            let mut v661: i32 = v661.clone();
                            let mut v662: i32 = v662.clone();
                            US10::US10_1(v657.clone(), v658, v659, v660, v661, v662)
                        }
                        US10::US10_0(v650, v651, v652, v653, v654, v655) => { // Ok
                            let mut v650: u8 = v650.clone();
                            let mut v651: i32 = v651.clone();
                            let mut v652: i32 = v652.clone();
                            let mut v653: i32 = v653.clone();
                            let mut v654: i32 = v654.clone();
                            let mut v655: i32 = v655.clone();
                            US10::US10_0(b'"', v651, v652, v653, v654, v655)
                        }
                        _ => unreachable!(),
                    };
                    let mut v763: US10 = match &v665 {
                        US10::US10_1(v672, v673, v674, v675, v676, v677) => { // Error
                            let mut v672: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v672.clone();
                            let mut v673: i32 = v673.clone();
                            let mut v674: i32 = v674.clone();
                            let mut v675: i32 = v675.clone();
                            let mut v676: i32 = v676.clone();
                            let mut v677: i32 = v677.clone();
                            let mut v695: US10 = if v597 {
                                let mut v678: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                US10::US10_1(v678.clone(), v162, v163, v164, v165, v166)
                            } else {
                                let mut v680: u8 = v0.clone().as_bytes()[v162 as usize];
                                let mut v681: bool = v680 == b'`';
                                if v681 {
                                    let mut v682: i32 = v162 + 1i32;
                                    let mut v683: bool = b'\n' == v680;
                                    let (mut v687, mut v688, mut v689, mut v690): (i32, i32, i32, i32) = if v683 {
                                        let mut v684: i32 = v163 + v165;
                                        let mut v685: i32 = v164 + 1i32;
                                        (v684, v685, 1i32, v166)
                                    } else {
                                        let mut v686: i32 = v165 + 1i32;
                                        (v163, v164, v686, v166)
                                    };
                                    US10::US10_0(b'`', v682, v687, v688, v689, v690)
                                } else {
                                    let mut v692: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                    US10::US10_1(v692.clone(), v162, v163, v164, v165, v166)
                                }
                            };
                            let mut v729: US10 = match &v695 {
                                US10::US10_1(v721, v722, v723, v724, v725, v726) => { // Error
                                    let mut v721: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v721.clone();
                                    let mut v722: i32 = v722.clone();
                                    let mut v723: i32 = v723.clone();
                                    let mut v724: i32 = v724.clone();
                                    let mut v725: i32 = v725.clone();
                                    let mut v726: i32 = v726.clone();
                                    US10::US10_1(v721.clone(), v722, v723, v724, v725, v726)
                                }
                                US10::US10_0(v696, v697, v698, v699, v700, v701) => { // Ok
                                    let mut v696: u8 = v696.clone();
                                    let mut v697: i32 = v697.clone();
                                    let mut v698: i32 = v698.clone();
                                    let mut v699: i32 = v699.clone();
                                    let mut v700: i32 = v700.clone();
                                    let mut v701: i32 = v701.clone();
                                    let mut v702: bool = v697 >= v701;
                                    if v702 {
                                        let mut v703: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                        US10::US10_1(v703.clone(), v697, v698, v699, v700, v701)
                                    } else {
                                        let mut v705: u8 = v0.clone().as_bytes()[v697 as usize];
                                        let mut v706: bool = v705 == b'"';
                                        if v706 {
                                            let mut v707: i32 = v697 + 1i32;
                                            let mut v708: bool = b'\n' == v705;
                                            let (mut v712, mut v713, mut v714, mut v715): (i32, i32, i32, i32) = if v708 {
                                                let mut v709: i32 = v698 + v700;
                                                let mut v710: i32 = v699 + 1i32;
                                                (v709, v710, 1i32, v701)
                                            } else {
                                                let mut v711: i32 = v700 + 1i32;
                                                (v698, v699, v711, v701)
                                            };
                                            US10::US10_0(b'"', v707, v712, v713, v714, v715)
                                        } else {
                                            let mut v717: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                            US10::US10_1(v717.clone(), v697, v698, v699, v700, v701)
                                        }
                                    }
                                }
                                _ => unreachable!(),
                            };
                            let mut v745: US10 = match &v729 {
                                US10::US10_1(v737, v738, v739, v740, v741, v742) => { // Error
                                    let mut v737: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v737.clone();
                                    let mut v738: i32 = v738.clone();
                                    let mut v739: i32 = v739.clone();
                                    let mut v740: i32 = v740.clone();
                                    let mut v741: i32 = v741.clone();
                                    let mut v742: i32 = v742.clone();
                                    US10::US10_1(v737.clone(), v738, v739, v740, v741, v742)
                                }
                                US10::US10_0(v730, v731, v732, v733, v734, v735) => { // Ok
                                    let mut v730: u8 = v730.clone();
                                    let mut v731: i32 = v731.clone();
                                    let mut v732: i32 = v732.clone();
                                    let mut v733: i32 = v733.clone();
                                    let mut v734: i32 = v734.clone();
                                    let mut v735: i32 = v735.clone();
                                    US10::US10_0(b'"', v731, v732, v733, v734, v735)
                                }
                                _ => unreachable!(),
                            };
                            match &v745 {
                                US10::US10_1(v752, v753, v754, v755, v756, v757) => { // Error
                                    let mut v752: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v752.clone();
                                    let mut v753: i32 = v753.clone();
                                    let mut v754: i32 = v754.clone();
                                    let mut v755: i32 = v755.clone();
                                    let mut v756: i32 = v756.clone();
                                    let mut v757: i32 = v757.clone();
                                    let mut v758: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US10::US10_1(v758.clone(), v162, v163, v164, v165, v166)
                                }
                                US10::US10_0(v746, v747, v748, v749, v750, v751) => { // Ok
                                    let mut v746: u8 = v746.clone();
                                    let mut v747: i32 = v747.clone();
                                    let mut v748: i32 = v748.clone();
                                    let mut v749: i32 = v749.clone();
                                    let mut v750: i32 = v750.clone();
                                    let mut v751: i32 = v751.clone();
                                    v745.clone()
                                }
                                _ => unreachable!(),
                            }
                        }
                        US10::US10_0(v666, v667, v668, v669, v670, v671) => { // Ok
                            let mut v666: u8 = v666.clone();
                            let mut v667: i32 = v667.clone();
                            let mut v668: i32 = v668.clone();
                            let mut v669: i32 = v669.clone();
                            let mut v670: i32 = v670.clone();
                            let mut v671: i32 = v671.clone();
                            v665.clone()
                        }
                        _ => unreachable!(),
                    };
                    match &v763 {
                        US10::US10_1(v772, v773, v774, v775, v776, v777) => { // Error
                            let mut v772: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v772.clone();
                            let mut v773: i32 = v773.clone();
                            let mut v774: i32 = v774.clone();
                            let mut v775: i32 = v775.clone();
                            let mut v776: i32 = v776.clone();
                            let mut v777: i32 = v777.clone();
                            let mut v778: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                            US11::US11_1(v778.clone(), v162, v163, v164, v165, v166)
                        }
                        US10::US10_0(v764, v765, v766, v767, v768, v769) => { // Ok
                            let mut v764: u8 = v764.clone();
                            let mut v765: i32 = v765.clone();
                            let mut v766: i32 = v766.clone();
                            let mut v767: i32 = v767.clone();
                            let mut v768: i32 = v768.clone();
                            let mut v769: i32 = v769.clone();
                            let mut v770: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            US11::US11_0(v770.clone(), v765, v766, v767, v768, v769)
                        }
                        _ => unreachable!(),
                    }
                }
                US11::US11_0(v401, v402, v403, v404, v405, v406) => { // Ok
                    let mut v401: Rc<str> = v401.clone();
                    let mut v402: i32 = v402.clone();
                    let mut v403: i32 = v403.clone();
                    let mut v404: i32 = v404.clone();
                    let mut v405: i32 = v405.clone();
                    let mut v406: i32 = v406.clone();
                    let mut v407: bool = v402 >= v406;
                    let mut v425: US10 = if v407 {
                        let mut v408: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                        US10::US10_1(v408.clone(), v402, v403, v404, v405, v406)
                    } else {
                        let mut v410: u8 = v0.clone().as_bytes()[v402 as usize];
                        let mut v411: bool = v410 == b'\\';
                        if v411 {
                            let mut v412: i32 = v402 + 1i32;
                            let mut v413: bool = b'\n' == v410;
                            let (mut v417, mut v418, mut v419, mut v420): (i32, i32, i32, i32) = if v413 {
                                let mut v414: i32 = v403 + v405;
                                let mut v415: i32 = v404 + 1i32;
                                (v414, v415, 1i32, v406)
                            } else {
                                let mut v416: i32 = v405 + 1i32;
                                (v403, v404, v416, v406)
                            };
                            US10::US10_0(b'\\', v412, v417, v418, v419, v420)
                        } else {
                            let mut v422: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                            US10::US10_1(v422.clone(), v402, v403, v404, v405, v406)
                        }
                    };
                    let mut v459: US10 = match &v425 {
                        US10::US10_1(v451, v452, v453, v454, v455, v456) => { // Error
                            let mut v451: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v451.clone();
                            let mut v452: i32 = v452.clone();
                            let mut v453: i32 = v453.clone();
                            let mut v454: i32 = v454.clone();
                            let mut v455: i32 = v455.clone();
                            let mut v456: i32 = v456.clone();
                            US10::US10_1(v451.clone(), v452, v453, v454, v455, v456)
                        }
                        US10::US10_0(v426, v427, v428, v429, v430, v431) => { // Ok
                            let mut v426: u8 = v426.clone();
                            let mut v427: i32 = v427.clone();
                            let mut v428: i32 = v428.clone();
                            let mut v429: i32 = v429.clone();
                            let mut v430: i32 = v430.clone();
                            let mut v431: i32 = v431.clone();
                            let mut v432: bool = v427 >= v431;
                            if v432 {
                                let mut v433: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_1(v433.clone(), v427, v428, v429, v430, v431)
                            } else {
                                let mut v435: u8 = v0.clone().as_bytes()[v427 as usize];
                                let mut v436: bool = v435 == b'"';
                                if v436 {
                                    let mut v437: i32 = v427 + 1i32;
                                    let mut v438: bool = b'\n' == v435;
                                    let (mut v442, mut v443, mut v444, mut v445): (i32, i32, i32, i32) = if v438 {
                                        let mut v439: i32 = v428 + v430;
                                        let mut v440: i32 = v429 + 1i32;
                                        (v439, v440, 1i32, v431)
                                    } else {
                                        let mut v441: i32 = v430 + 1i32;
                                        (v428, v429, v441, v431)
                                    };
                                    US10::US10_0(b'"', v437, v442, v443, v444, v445)
                                } else {
                                    let mut v447: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_1(v447.clone(), v427, v428, v429, v430, v431)
                                }
                            }
                        }
                        _ => unreachable!(),
                    };
                    let mut v475: US10 = match &v459 {
                        US10::US10_1(v467, v468, v469, v470, v471, v472) => { // Error
                            let mut v467: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v467.clone();
                            let mut v468: i32 = v468.clone();
                            let mut v469: i32 = v469.clone();
                            let mut v470: i32 = v470.clone();
                            let mut v471: i32 = v471.clone();
                            let mut v472: i32 = v472.clone();
                            US10::US10_1(v467.clone(), v468, v469, v470, v471, v472)
                        }
                        US10::US10_0(v460, v461, v462, v463, v464, v465) => { // Ok
                            let mut v460: u8 = v460.clone();
                            let mut v461: i32 = v461.clone();
                            let mut v462: i32 = v462.clone();
                            let mut v463: i32 = v463.clone();
                            let mut v464: i32 = v464.clone();
                            let mut v465: i32 = v465.clone();
                            US10::US10_0(b'"', v461, v462, v463, v464, v465)
                        }
                        _ => unreachable!(),
                    };
                    let mut v573: US10 = match &v475 {
                        US10::US10_1(v482, v483, v484, v485, v486, v487) => { // Error
                            let mut v482: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v482.clone();
                            let mut v483: i32 = v483.clone();
                            let mut v484: i32 = v484.clone();
                            let mut v485: i32 = v485.clone();
                            let mut v486: i32 = v486.clone();
                            let mut v487: i32 = v487.clone();
                            let mut v505: US10 = if v407 {
                                let mut v488: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                US10::US10_1(v488.clone(), v402, v403, v404, v405, v406)
                            } else {
                                let mut v490: u8 = v0.clone().as_bytes()[v402 as usize];
                                let mut v491: bool = v490 == b'`';
                                if v491 {
                                    let mut v492: i32 = v402 + 1i32;
                                    let mut v493: bool = b'\n' == v490;
                                    let (mut v497, mut v498, mut v499, mut v500): (i32, i32, i32, i32) = if v493 {
                                        let mut v494: i32 = v403 + v405;
                                        let mut v495: i32 = v404 + 1i32;
                                        (v494, v495, 1i32, v406)
                                    } else {
                                        let mut v496: i32 = v405 + 1i32;
                                        (v403, v404, v496, v406)
                                    };
                                    US10::US10_0(b'`', v492, v497, v498, v499, v500)
                                } else {
                                    let mut v502: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                    US10::US10_1(v502.clone(), v402, v403, v404, v405, v406)
                                }
                            };
                            let mut v539: US10 = match &v505 {
                                US10::US10_1(v531, v532, v533, v534, v535, v536) => { // Error
                                    let mut v531: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v531.clone();
                                    let mut v532: i32 = v532.clone();
                                    let mut v533: i32 = v533.clone();
                                    let mut v534: i32 = v534.clone();
                                    let mut v535: i32 = v535.clone();
                                    let mut v536: i32 = v536.clone();
                                    US10::US10_1(v531.clone(), v532, v533, v534, v535, v536)
                                }
                                US10::US10_0(v506, v507, v508, v509, v510, v511) => { // Ok
                                    let mut v506: u8 = v506.clone();
                                    let mut v507: i32 = v507.clone();
                                    let mut v508: i32 = v508.clone();
                                    let mut v509: i32 = v509.clone();
                                    let mut v510: i32 = v510.clone();
                                    let mut v511: i32 = v511.clone();
                                    let mut v512: bool = v507 >= v511;
                                    if v512 {
                                        let mut v513: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                        US10::US10_1(v513.clone(), v507, v508, v509, v510, v511)
                                    } else {
                                        let mut v515: u8 = v0.clone().as_bytes()[v507 as usize];
                                        let mut v516: bool = v515 == b'"';
                                        if v516 {
                                            let mut v517: i32 = v507 + 1i32;
                                            let mut v518: bool = b'\n' == v515;
                                            let (mut v522, mut v523, mut v524, mut v525): (i32, i32, i32, i32) = if v518 {
                                                let mut v519: i32 = v508 + v510;
                                                let mut v520: i32 = v509 + 1i32;
                                                (v519, v520, 1i32, v511)
                                            } else {
                                                let mut v521: i32 = v510 + 1i32;
                                                (v508, v509, v521, v511)
                                            };
                                            US10::US10_0(b'"', v517, v522, v523, v524, v525)
                                        } else {
                                            let mut v527: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                            US10::US10_1(v527.clone(), v507, v508, v509, v510, v511)
                                        }
                                    }
                                }
                                _ => unreachable!(),
                            };
                            let mut v555: US10 = match &v539 {
                                US10::US10_1(v547, v548, v549, v550, v551, v552) => { // Error
                                    let mut v547: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v547.clone();
                                    let mut v548: i32 = v548.clone();
                                    let mut v549: i32 = v549.clone();
                                    let mut v550: i32 = v550.clone();
                                    let mut v551: i32 = v551.clone();
                                    let mut v552: i32 = v552.clone();
                                    US10::US10_1(v547.clone(), v548, v549, v550, v551, v552)
                                }
                                US10::US10_0(v540, v541, v542, v543, v544, v545) => { // Ok
                                    let mut v540: u8 = v540.clone();
                                    let mut v541: i32 = v541.clone();
                                    let mut v542: i32 = v542.clone();
                                    let mut v543: i32 = v543.clone();
                                    let mut v544: i32 = v544.clone();
                                    let mut v545: i32 = v545.clone();
                                    US10::US10_0(b'"', v541, v542, v543, v544, v545)
                                }
                                _ => unreachable!(),
                            };
                            match &v555 {
                                US10::US10_1(v562, v563, v564, v565, v566, v567) => { // Error
                                    let mut v562: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v562.clone();
                                    let mut v563: i32 = v563.clone();
                                    let mut v564: i32 = v564.clone();
                                    let mut v565: i32 = v565.clone();
                                    let mut v566: i32 = v566.clone();
                                    let mut v567: i32 = v567.clone();
                                    let mut v568: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                    US10::US10_1(v568.clone(), v402, v403, v404, v405, v406)
                                }
                                US10::US10_0(v556, v557, v558, v559, v560, v561) => { // Ok
                                    let mut v556: u8 = v556.clone();
                                    let mut v557: i32 = v557.clone();
                                    let mut v558: i32 = v558.clone();
                                    let mut v559: i32 = v559.clone();
                                    let mut v560: i32 = v560.clone();
                                    let mut v561: i32 = v561.clone();
                                    v555.clone()
                                }
                                _ => unreachable!(),
                            }
                        }
                        US10::US10_0(v476, v477, v478, v479, v480, v481) => { // Ok
                            let mut v476: u8 = v476.clone();
                            let mut v477: i32 = v477.clone();
                            let mut v478: i32 = v478.clone();
                            let mut v479: i32 = v479.clone();
                            let mut v480: i32 = v480.clone();
                            let mut v481: i32 = v481.clone();
                            v475.clone()
                        }
                        _ => unreachable!(),
                    };
                    match &v573 {
                        US10::US10_1(v581, v582, v583, v584, v585, v586) => { // Error
                            let mut v581: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v581.clone();
                            let mut v582: i32 = v582.clone();
                            let mut v583: i32 = v583.clone();
                            let mut v584: i32 = v584.clone();
                            let mut v585: i32 = v585.clone();
                            let mut v586: i32 = v586.clone();
                            let mut v587: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v162, v402, v581.clone(), v582, v583, v584, v585, v586);
                            US11::US11_1(v587.clone(), v402, v403, v404, v405, v406)
                        }
                        US10::US10_0(v574, v575, v576, v577, v578, v579) => { // Ok
                            let mut v574: u8 = v574.clone();
                            let mut v575: i32 = v575.clone();
                            let mut v576: i32 = v576.clone();
                            let mut v577: i32 = v577.clone();
                            let mut v578: i32 = v578.clone();
                            let mut v579: i32 = v579.clone();
                            US11::US11_0(v401.clone(), v575, v576, v577, v578, v579)
                        }
                        _ => unreachable!(),
                    }
                }
                _ => unreachable!(),
            }
        }
        _ => unreachable!(),
    };
    let mut v1146: US11 = match &v792 {
        US11::US11_1(v799, v800, v801, v802, v803, v804) => { // Error
            let mut v799: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v799.clone();
            let mut v800: i32 = v800.clone();
            let mut v801: i32 = v801.clone();
            let mut v802: i32 = v802.clone();
            let mut v803: i32 = v803.clone();
            let mut v804: i32 = v804.clone();
            let mut v818: US10 = if v2 {
                let mut v805: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                US10::US10_1(v805.clone(), 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                let mut v807: u8 = v0.clone().as_bytes()[0i32 as usize];
                let mut v808: bool = v807 == b'"';
                if v808 {
                    let mut v809: bool = b'\n' == v807;
                    let (mut v810, mut v811, mut v812, mut v813): (i32, i32, i32, i32) = if v809 {
                        (1i32, 2i32, 1i32, v1)
                    } else {
                        (0i32, 1i32, 2i32, v1)
                    };
                    US10::US10_0(b'"', 1i32, v810, v811, v812, v813)
                } else {
                    let mut v815: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                    US10::US10_1(v815.clone(), 0i32, 0i32, 1i32, 1i32, v1)
                }
            };
            match &v818 {
                US10::US10_1(v1136, v1137, v1138, v1139, v1140, v1141) => { // Error
                    let mut v1136: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1136.clone();
                    let mut v1137: i32 = v1137.clone();
                    let mut v1138: i32 = v1138.clone();
                    let mut v1139: i32 = v1139.clone();
                    let mut v1140: i32 = v1140.clone();
                    let mut v1141: i32 = v1141.clone();
                    US11::US11_1(v1136.clone(), v1137, v1138, v1139, v1140, v1141)
                }
                US10::US10_0(v819, v820, v821, v822, v823, v824) => { // Ok
                    let mut v819: u8 = v819.clone();
                    let mut v820: i32 = v820.clone();
                    let mut v821: i32 = v821.clone();
                    let mut v822: i32 = v822.clone();
                    let mut v823: i32 = v823.clone();
                    let mut v824: i32 = v824.clone();
                    let (mut v825, mut v826, mut v827, mut v828, mut v829): (i32, i32, i32, i32, i32) = method111(v821, v822, v823, v824, v0.clone(), v820);
                    let mut v830: bool = v825 > v820;
                    let mut v840: US11 = if v830 {
                        let mut v831: bool = v820 >= v825;
                        let mut v836: Rc<str> = if v831 {
                            let mut v832: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v832.clone()
                        } else {
                            let mut v833: bool = v820 == v825;
                            let mut v834: i32 = v825 - 1i32;
                            let mut v835: Rc<str> = string_slice(&v0.clone(), v820 as i64, v834 as i64);
                            v835.clone()
                        };
                        US11::US11_0(v836.clone(), v825, v826, v827, v828, v829)
                    } else {
                        let mut v838: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                        US11::US11_1(v838.clone(), v820, v821, v822, v823, v824)
                    };
                    let mut v1025: US11 = match &v840 {
                        US11::US11_1(v847, v848, v849, v850, v851, v852) => { // Error
                            let mut v847: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v847.clone();
                            let mut v848: i32 = v848.clone();
                            let mut v849: i32 = v849.clone();
                            let mut v850: i32 = v850.clone();
                            let mut v851: i32 = v851.clone();
                            let mut v852: i32 = v852.clone();
                            let mut v853: bool = v820 >= v824;
                            let mut v871: US10 = if v853 {
                                let mut v854: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure35();
                                US10::US10_1(v854.clone(), v820, v821, v822, v823, v824)
                            } else {
                                let mut v856: u8 = v0.clone().as_bytes()[v820 as usize];
                                let mut v857: bool = v856 == b'\\';
                                if v857 {
                                    let mut v858: i32 = v820 + 1i32;
                                    let mut v859: bool = b'\n' == v856;
                                    let (mut v863, mut v864, mut v865, mut v866): (i32, i32, i32, i32) = if v859 {
                                        let mut v860: i32 = v821 + v823;
                                        let mut v861: i32 = v822 + 1i32;
                                        (v860, v861, 1i32, v824)
                                    } else {
                                        let mut v862: i32 = v823 + 1i32;
                                        (v821, v822, v862, v824)
                                    };
                                    US10::US10_0(b'\\', v858, v863, v864, v865, v866)
                                } else {
                                    let mut v868: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure36();
                                    US10::US10_1(v868.clone(), v820, v821, v822, v823, v824)
                                }
                            };
                            let mut v901: US10 = match &v871 {
                                US10::US10_1(v893, v894, v895, v896, v897, v898) => { // Error
                                    let mut v893: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v893.clone();
                                    let mut v894: i32 = v894.clone();
                                    let mut v895: i32 = v895.clone();
                                    let mut v896: i32 = v896.clone();
                                    let mut v897: i32 = v897.clone();
                                    let mut v898: i32 = v898.clone();
                                    US10::US10_1(v893.clone(), v894, v895, v896, v897, v898)
                                }
                                US10::US10_0(v872, v873, v874, v875, v876, v877) => { // Ok
                                    let mut v872: u8 = v872.clone();
                                    let mut v873: i32 = v873.clone();
                                    let mut v874: i32 = v874.clone();
                                    let mut v875: i32 = v875.clone();
                                    let mut v876: i32 = v876.clone();
                                    let mut v877: i32 = v877.clone();
                                    let mut v878: bool = v873 >= v877;
                                    if v878 {
                                        let mut v879: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                        US10::US10_1(v879.clone(), v873, v874, v875, v876, v877)
                                    } else {
                                        let mut v881: u8 = v0.clone().as_bytes()[v873 as usize];
                                        let mut v882: i32 = v873 + 1i32;
                                        let mut v883: bool = b'\n' == v881;
                                        let (mut v887, mut v888, mut v889, mut v890): (i32, i32, i32, i32) = if v883 {
                                            let mut v884: i32 = v874 + v876;
                                            let mut v885: i32 = v875 + 1i32;
                                            (v884, v885, 1i32, v877)
                                        } else {
                                            let mut v886: i32 = v876 + 1i32;
                                            (v874, v875, v886, v877)
                                        };
                                        US10::US10_0(v881, v882, v887, v888, v889, v890)
                                    }
                                }
                                _ => unreachable!(),
                            };
                            let mut v923: US11 = match &v901 {
                                US10::US10_1(v915, v916, v917, v918, v919, v920) => { // Error
                                    let mut v915: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v915.clone();
                                    let mut v916: i32 = v916.clone();
                                    let mut v917: i32 = v917.clone();
                                    let mut v918: i32 = v918.clone();
                                    let mut v919: i32 = v919.clone();
                                    let mut v920: i32 = v920.clone();
                                    US11::US11_1(v915.clone(), v916, v917, v918, v919, v920)
                                }
                                US10::US10_0(v902, v903, v904, v905, v906, v907) => { // Ok
                                    let mut v902: u8 = v902.clone();
                                    let mut v903: i32 = v903.clone();
                                    let mut v904: i32 = v904.clone();
                                    let mut v905: i32 = v905.clone();
                                    let mut v906: i32 = v906.clone();
                                    let mut v907: i32 = v907.clone();
                                    let mut v908: bool = v820 >= v903;
                                    let mut v913: Rc<str> = if v908 {
                                        let mut v909: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                        v909.clone()
                                    } else {
                                        let mut v910: bool = v820 == v903;
                                        let mut v911: i32 = v903 - 1i32;
                                        let mut v912: Rc<str> = string_slice(&v0.clone(), v820 as i64, v911 as i64);
                                        v912.clone()
                                    };
                                    US11::US11_0(v913.clone(), v903, v904, v905, v906, v907)
                                }
                                _ => unreachable!(),
                            };
                            match &v923 {
                                US11::US11_1(v930, v931, v932, v933, v934, v935) => { // Error
                                    let mut v930: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v930.clone();
                                    let mut v931: i32 = v931.clone();
                                    let mut v932: i32 = v932.clone();
                                    let mut v933: i32 = v933.clone();
                                    let mut v934: i32 = v934.clone();
                                    let mut v935: i32 = v935.clone();
                                    let mut v953: US10 = if v853 {
                                        let mut v936: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure37();
                                        US10::US10_1(v936.clone(), v820, v821, v822, v823, v824)
                                    } else {
                                        let mut v938: u8 = v0.clone().as_bytes()[v820 as usize];
                                        let mut v939: bool = v938 == b'`';
                                        if v939 {
                                            let mut v940: i32 = v820 + 1i32;
                                            let mut v941: bool = b'\n' == v938;
                                            let (mut v945, mut v946, mut v947, mut v948): (i32, i32, i32, i32) = if v941 {
                                                let mut v942: i32 = v821 + v823;
                                                let mut v943: i32 = v822 + 1i32;
                                                (v942, v943, 1i32, v824)
                                            } else {
                                                let mut v944: i32 = v823 + 1i32;
                                                (v821, v822, v944, v824)
                                            };
                                            US10::US10_0(b'`', v940, v945, v946, v947, v948)
                                        } else {
                                            let mut v950: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure38();
                                            US10::US10_1(v950.clone(), v820, v821, v822, v823, v824)
                                        }
                                    };
                                    let mut v983: US10 = match &v953 {
                                        US10::US10_1(v975, v976, v977, v978, v979, v980) => { // Error
                                            let mut v975: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v975.clone();
                                            let mut v976: i32 = v976.clone();
                                            let mut v977: i32 = v977.clone();
                                            let mut v978: i32 = v978.clone();
                                            let mut v979: i32 = v979.clone();
                                            let mut v980: i32 = v980.clone();
                                            US10::US10_1(v975.clone(), v976, v977, v978, v979, v980)
                                        }
                                        US10::US10_0(v954, v955, v956, v957, v958, v959) => { // Ok
                                            let mut v954: u8 = v954.clone();
                                            let mut v955: i32 = v955.clone();
                                            let mut v956: i32 = v956.clone();
                                            let mut v957: i32 = v957.clone();
                                            let mut v958: i32 = v958.clone();
                                            let mut v959: i32 = v959.clone();
                                            let mut v960: bool = v955 >= v959;
                                            if v960 {
                                                let mut v961: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure44();
                                                US10::US10_1(v961.clone(), v955, v956, v957, v958, v959)
                                            } else {
                                                let mut v963: u8 = v0.clone().as_bytes()[v955 as usize];
                                                let mut v964: i32 = v955 + 1i32;
                                                let mut v965: bool = b'\n' == v963;
                                                let (mut v969, mut v970, mut v971, mut v972): (i32, i32, i32, i32) = if v965 {
                                                    let mut v966: i32 = v956 + v958;
                                                    let mut v967: i32 = v957 + 1i32;
                                                    (v966, v967, 1i32, v959)
                                                } else {
                                                    let mut v968: i32 = v958 + 1i32;
                                                    (v956, v957, v968, v959)
                                                };
                                                US10::US10_0(v963, v964, v969, v970, v971, v972)
                                            }
                                        }
                                        _ => unreachable!(),
                                    };
                                    let mut v1005: US11 = match &v983 {
                                        US10::US10_1(v997, v998, v999, v1000, v1001, v1002) => { // Error
                                            let mut v997: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v997.clone();
                                            let mut v998: i32 = v998.clone();
                                            let mut v999: i32 = v999.clone();
                                            let mut v1000: i32 = v1000.clone();
                                            let mut v1001: i32 = v1001.clone();
                                            let mut v1002: i32 = v1002.clone();
                                            US11::US11_1(v997.clone(), v998, v999, v1000, v1001, v1002)
                                        }
                                        US10::US10_0(v984, v985, v986, v987, v988, v989) => { // Ok
                                            let mut v984: u8 = v984.clone();
                                            let mut v985: i32 = v985.clone();
                                            let mut v986: i32 = v986.clone();
                                            let mut v987: i32 = v987.clone();
                                            let mut v988: i32 = v988.clone();
                                            let mut v989: i32 = v989.clone();
                                            let mut v990: bool = v820 >= v985;
                                            let mut v995: Rc<str> = if v990 {
                                                let mut v991: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                                v991.clone()
                                            } else {
                                                let mut v992: bool = v820 == v985;
                                                let mut v993: i32 = v985 - 1i32;
                                                let mut v994: Rc<str> = string_slice(&v0.clone(), v820 as i64, v993 as i64);
                                                v994.clone()
                                            };
                                            US11::US11_0(v995.clone(), v985, v986, v987, v988, v989)
                                        }
                                        _ => unreachable!(),
                                    };
                                    match &v1005 {
                                        US11::US11_1(v1012, v1013, v1014, v1015, v1016, v1017) => { // Error
                                            let mut v1012: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1012.clone();
                                            let mut v1013: i32 = v1013.clone();
                                            let mut v1014: i32 = v1014.clone();
                                            let mut v1015: i32 = v1015.clone();
                                            let mut v1016: i32 = v1016.clone();
                                            let mut v1017: i32 = v1017.clone();
                                            let mut v1018: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure20();
                                            US11::US11_1(v1018.clone(), v820, v821, v822, v823, v824)
                                        }
                                        US11::US11_0(v1006, v1007, v1008, v1009, v1010, v1011) => { // Ok
                                            let mut v1006: Rc<str> = v1006.clone();
                                            let mut v1007: i32 = v1007.clone();
                                            let mut v1008: i32 = v1008.clone();
                                            let mut v1009: i32 = v1009.clone();
                                            let mut v1010: i32 = v1010.clone();
                                            let mut v1011: i32 = v1011.clone();
                                            v1005.clone()
                                        }
                                        _ => unreachable!(),
                                    }
                                }
                                US11::US11_0(v924, v925, v926, v927, v928, v929) => { // Ok
                                    let mut v924: Rc<str> = v924.clone();
                                    let mut v925: i32 = v925.clone();
                                    let mut v926: i32 = v926.clone();
                                    let mut v927: i32 = v927.clone();
                                    let mut v928: i32 = v928.clone();
                                    let mut v929: i32 = v929.clone();
                                    v923.clone()
                                }
                                _ => unreachable!(),
                            }
                        }
                        US11::US11_0(v841, v842, v843, v844, v845, v846) => { // Ok
                            let mut v841: Rc<str> = v841.clone();
                            let mut v842: i32 = v842.clone();
                            let mut v843: i32 = v843.clone();
                            let mut v844: i32 = v844.clone();
                            let mut v845: i32 = v845.clone();
                            let mut v846: i32 = v846.clone();
                            v840.clone()
                        }
                        _ => unreachable!(),
                    };
                    let mut v1048: US11 = match &v1025 {
                        US11::US11_1(v1026, v1027, v1028, v1029, v1030, v1031) => { // Error
                            let mut v1026: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1026.clone();
                            let mut v1027: i32 = v1027.clone();
                            let mut v1028: i32 = v1028.clone();
                            let mut v1029: i32 = v1029.clone();
                            let mut v1030: i32 = v1030.clone();
                            let mut v1031: i32 = v1031.clone();
                            let mut v1032: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            US11::US11_0(v1032.clone(), v820, v821, v822, v823, v824)
                        }
                        US11::US11_0(v1034, v1035, v1036, v1037, v1038, v1039) => { // Ok
                            let mut v1034: Rc<str> = v1034.clone();
                            let mut v1035: i32 = v1035.clone();
                            let mut v1036: i32 = v1036.clone();
                            let mut v1037: i32 = v1037.clone();
                            let mut v1038: i32 = v1038.clone();
                            let mut v1039: i32 = v1039.clone();
                            let mut v1040: bool = v1035 == v820;
                            if v1040 {
                                let mut v1041: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure42();
                                US11::US11_1(v1041.clone(), v820, v821, v822, v823, v824)
                            } else {
                                let mut v1043: Rc<RefCell<std::string::String>> = Rc::new(RefCell::new(std::string::String::new()));
                                let mut v1044: i32 = 0i32;
                                method117(v0.clone(), v1043.clone(), v1034.clone(), v1044, v1035, v1036, v1037, v1038, v1039)
                            }
                        }
                        _ => unreachable!(),
                    };
                    match &v1048 {
                        US11::US11_1(v1091, v1092, v1093, v1094, v1095, v1096) => { // Error
                            let mut v1091: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1091.clone();
                            let mut v1092: i32 = v1092.clone();
                            let mut v1093: i32 = v1093.clone();
                            let mut v1094: i32 = v1094.clone();
                            let mut v1095: i32 = v1095.clone();
                            let mut v1096: i32 = v1096.clone();
                            let mut v1097: bool = v820 >= v824;
                            let mut v1115: US10 = if v1097 {
                                let mut v1098: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_1(v1098.clone(), v820, v821, v822, v823, v824)
                            } else {
                                let mut v1100: u8 = v0.clone().as_bytes()[v820 as usize];
                                let mut v1101: bool = v1100 == b'"';
                                if v1101 {
                                    let mut v1102: i32 = v820 + 1i32;
                                    let mut v1103: bool = b'\n' == v1100;
                                    let (mut v1107, mut v1108, mut v1109, mut v1110): (i32, i32, i32, i32) = if v1103 {
                                        let mut v1104: i32 = v821 + v823;
                                        let mut v1105: i32 = v822 + 1i32;
                                        (v1104, v1105, 1i32, v824)
                                    } else {
                                        let mut v1106: i32 = v823 + 1i32;
                                        (v821, v822, v1106, v824)
                                    };
                                    US10::US10_0(b'"', v1102, v1107, v1108, v1109, v1110)
                                } else {
                                    let mut v1112: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_1(v1112.clone(), v820, v821, v822, v823, v824)
                                }
                            };
                            match &v1115 {
                                US10::US10_1(v1124, v1125, v1126, v1127, v1128, v1129) => { // Error
                                    let mut v1124: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1124.clone();
                                    let mut v1125: i32 = v1125.clone();
                                    let mut v1126: i32 = v1126.clone();
                                    let mut v1127: i32 = v1127.clone();
                                    let mut v1128: i32 = v1128.clone();
                                    let mut v1129: i32 = v1129.clone();
                                    let mut v1130: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure24();
                                    US11::US11_1(v1130.clone(), v820, v821, v822, v823, v824)
                                }
                                US10::US10_0(v1116, v1117, v1118, v1119, v1120, v1121) => { // Ok
                                    let mut v1116: u8 = v1116.clone();
                                    let mut v1117: i32 = v1117.clone();
                                    let mut v1118: i32 = v1118.clone();
                                    let mut v1119: i32 = v1119.clone();
                                    let mut v1120: i32 = v1120.clone();
                                    let mut v1121: i32 = v1121.clone();
                                    let mut v1122: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    US11::US11_0(v1122.clone(), v1117, v1118, v1119, v1120, v1121)
                                }
                                _ => unreachable!(),
                            }
                        }
                        US11::US11_0(v1049, v1050, v1051, v1052, v1053, v1054) => { // Ok
                            let mut v1049: Rc<str> = v1049.clone();
                            let mut v1050: i32 = v1050.clone();
                            let mut v1051: i32 = v1051.clone();
                            let mut v1052: i32 = v1052.clone();
                            let mut v1053: i32 = v1053.clone();
                            let mut v1054: i32 = v1054.clone();
                            let mut v1055: bool = v1050 >= v1054;
                            let mut v1073: US10 = if v1055 {
                                let mut v1056: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure15();
                                US10::US10_1(v1056.clone(), v1050, v1051, v1052, v1053, v1054)
                            } else {
                                let mut v1058: u8 = v0.clone().as_bytes()[v1050 as usize];
                                let mut v1059: bool = v1058 == b'"';
                                if v1059 {
                                    let mut v1060: i32 = v1050 + 1i32;
                                    let mut v1061: bool = b'\n' == v1058;
                                    let (mut v1065, mut v1066, mut v1067, mut v1068): (i32, i32, i32, i32) = if v1061 {
                                        let mut v1062: i32 = v1051 + v1053;
                                        let mut v1063: i32 = v1052 + 1i32;
                                        (v1062, v1063, 1i32, v1054)
                                    } else {
                                        let mut v1064: i32 = v1053 + 1i32;
                                        (v1051, v1052, v1064, v1054)
                                    };
                                    US10::US10_0(b'"', v1060, v1065, v1066, v1067, v1068)
                                } else {
                                    let mut v1070: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure16();
                                    US10::US10_1(v1070.clone(), v1050, v1051, v1052, v1053, v1054)
                                }
                            };
                            match &v1073 {
                                US10::US10_1(v1081, v1082, v1083, v1084, v1085, v1086) => { // Error
                                    let mut v1081: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1081.clone();
                                    let mut v1082: i32 = v1082.clone();
                                    let mut v1083: i32 = v1083.clone();
                                    let mut v1084: i32 = v1084.clone();
                                    let mut v1085: i32 = v1085.clone();
                                    let mut v1086: i32 = v1086.clone();
                                    let mut v1087: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure25(v820, v1050, v1081.clone(), v1082, v1083, v1084, v1085, v1086);
                                    US11::US11_1(v1087.clone(), v1050, v1051, v1052, v1053, v1054)
                                }
                                US10::US10_0(v1074, v1075, v1076, v1077, v1078, v1079) => { // Ok
                                    let mut v1074: u8 = v1074.clone();
                                    let mut v1075: i32 = v1075.clone();
                                    let mut v1076: i32 = v1076.clone();
                                    let mut v1077: i32 = v1077.clone();
                                    let mut v1078: i32 = v1078.clone();
                                    let mut v1079: i32 = v1079.clone();
                                    US11::US11_0(v1049.clone(), v1075, v1076, v1077, v1078, v1079)
                                }
                                _ => unreachable!(),
                            }
                        }
                        _ => unreachable!(),
                    }
                }
                _ => unreachable!(),
            }
        }
        US11::US11_0(v793, v794, v795, v796, v797, v798) => { // Ok
            let mut v793: Rc<str> = v793.clone();
            let mut v794: i32 = v794.clone();
            let mut v795: i32 = v795.clone();
            let mut v796: i32 = v796.clone();
            let mut v797: i32 = v797.clone();
            let mut v798: i32 = v798.clone();
            v792.clone()
        }
        _ => unreachable!(),
    };
    let mut v1180: US11 = match &v1146 {
        US11::US11_1(v1153, v1154, v1155, v1156, v1157, v1158) => { // Error
            let mut v1153: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1153.clone();
            let mut v1154: i32 = v1154.clone();
            let mut v1155: i32 = v1155.clone();
            let mut v1156: i32 = v1156.clone();
            let mut v1157: i32 = v1157.clone();
            let mut v1158: i32 = v1158.clone();
            let mut v1159: i32 = 0i32;
            let mut v1160: i32 = 0i32;
            let mut v1161: i32 = 1i32;
            let mut v1162: i32 = 1i32;
            let (mut v1163, mut v1164, mut v1165, mut v1166, mut v1167): (i32, i32, i32, i32, i32) = method118(v1, v0.clone(), v1159, v1160, v1161, v1162);
            let mut v1168: bool = v1163 > 0i32;
            if v1168 {
                let mut v1169: bool = 0i32 >= v1163;
                let mut v1174: Rc<str> = if v1169 {
                    let mut v1170: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    v1170.clone()
                } else {
                    let mut v1171: bool = 0i32 == v1163;
                    let mut v1172: i32 = v1163 - 1i32;
                    let mut v1173: Rc<str> = string_slice(&v0.clone(), 0i32 as i64, v1172 as i64);
                    v1173.clone()
                };
                US11::US11_0(v1174.clone(), v1163, v1164, v1165, v1166, v1167)
            } else {
                let mut v1176: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure39();
                US11::US11_1(v1176.clone(), 0i32, 0i32, 1i32, 1i32, v1)
            }
        }
        US11::US11_0(v1147, v1148, v1149, v1150, v1151, v1152) => { // Ok
            let mut v1147: Rc<str> = v1147.clone();
            let mut v1148: i32 = v1148.clone();
            let mut v1149: i32 = v1149.clone();
            let mut v1150: i32 = v1150.clone();
            let mut v1151: i32 = v1151.clone();
            let mut v1152: i32 = v1152.clone();
            v1146.clone()
        }
        _ => unreachable!(),
    };
    let mut v1219: US11 = match &v1180 {
        US11::US11_1(v1187, v1188, v1189, v1190, v1191, v1192) => { // Error
            let mut v1187: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1187.clone();
            let mut v1188: i32 = v1188.clone();
            let mut v1189: i32 = v1189.clone();
            let mut v1190: i32 = v1190.clone();
            let mut v1191: i32 = v1191.clone();
            let mut v1192: i32 = v1192.clone();
            let mut v1193: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
            let mut v1194: i32 = 0i32;
            let mut v1195: i32 = 0i32;
            let mut v1196: i32 = 1i32;
            let mut v1197: i32 = 1i32;
            let mut v1198: US19 = method120(v0.clone(), v1193.clone(), v1194, v1195, v1196, v1197, v1);
            match &v1198 {
                US19::US19_1(v1209, v1210, v1211, v1212, v1213, v1214) => { // Error
                    let mut v1209: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1209.clone();
                    let mut v1210: i32 = v1210.clone();
                    let mut v1211: i32 = v1211.clone();
                    let mut v1212: i32 = v1212.clone();
                    let mut v1213: i32 = v1213.clone();
                    let mut v1214: i32 = v1214.clone();
                    US11::US11_1(v1209.clone(), v1210, v1211, v1212, v1213, v1214)
                }
                US19::US19_0(v1199, v1200, v1201, v1202, v1203, v1204) => { // Ok
                    let mut v1199: Rc<UH0> = v1199.clone();
                    let mut v1200: i32 = v1200.clone();
                    let mut v1201: i32 = v1201.clone();
                    let mut v1202: i32 = v1202.clone();
                    let mut v1203: i32 = v1203.clone();
                    let mut v1204: i32 = v1204.clone();
                    let mut v1205: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let (mut v1206, mut v1207): (Rc<str>, Rc<str>) = method122(v1199.clone(), v1205.clone());
                    US11::US11_0(v1206.clone(), v1200, v1201, v1202, v1203, v1204)
                }
                _ => unreachable!(),
            }
        }
        US11::US11_0(v1181, v1182, v1183, v1184, v1185, v1186) => { // Ok
            let mut v1181: Rc<str> = v1181.clone();
            let mut v1182: i32 = v1182.clone();
            let mut v1183: i32 = v1183.clone();
            let mut v1184: i32 = v1184.clone();
            let mut v1185: i32 = v1185.clone();
            let mut v1186: i32 = v1186.clone();
            v1180.clone()
        }
        _ => unreachable!(),
    };
    let mut v1230: US11 = match &v1219 {
        US11::US11_0(v1220, v1221, v1222, v1223, v1224, v1225) => { // Ok
            let mut v1220: Rc<str> = v1220.clone();
            let mut v1221: i32 = v1221.clone();
            let mut v1222: i32 = v1222.clone();
            let mut v1223: i32 = v1223.clone();
            let mut v1224: i32 = v1224.clone();
            let mut v1225: i32 = v1225.clone();
            let mut v1226: bool = v1221 == 0i32;
            if v1226 {
                let mut v1227: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = closure48();
                US11::US11_1(v1227.clone(), 0i32, 0i32, 1i32, 1i32, v1)
            } else {
                v1219.clone()
            }
        }
        _ => {
            v1219.clone()
        }
    };
    let mut v1247: US11 = match &v1230 {
        US11::US11_1(v1231, v1232, v1233, v1234, v1235, v1236) => { // Error
            let mut v1231: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1231.clone();
            let mut v1232: i32 = v1232.clone();
            let mut v1233: i32 = v1233.clone();
            let mut v1234: i32 = v1234.clone();
            let mut v1235: i32 = v1235.clone();
            let mut v1236: i32 = v1236.clone();
            US11::US11_1(v1231.clone(), v1232, v1233, v1234, v1235, v1236)
        }
        US11::US11_0(v1238, v1239, v1240, v1241, v1242, v1243) => { // Ok
            let mut v1238: Rc<str> = v1238.clone();
            let mut v1239: i32 = v1239.clone();
            let mut v1240: i32 = v1240.clone();
            let mut v1241: i32 = v1241.clone();
            let mut v1242: i32 = v1242.clone();
            let mut v1243: i32 = v1243.clone();
            let mut v1244: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
            method123(v0.clone(), v1238.clone(), v1244.clone(), v1239, v1240, v1241, v1242, v1243)
        }
        _ => unreachable!(),
    };
    let mut v1266: US19 = match &v1247 {
        US11::US11_1(v1248, v1249, v1250, v1251, v1252, v1253) => { // Error
            let mut v1248: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1248.clone();
            let mut v1249: i32 = v1249.clone();
            let mut v1250: i32 = v1250.clone();
            let mut v1251: i32 = v1251.clone();
            let mut v1252: i32 = v1252.clone();
            let mut v1253: i32 = v1253.clone();
            let mut v1254: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
            US19::US19_0(v1254.clone(), 0i32, 0i32, 1i32, 1i32, v1)
        }
        US11::US11_0(v1256, v1257, v1258, v1259, v1260, v1261) => { // Ok
            let mut v1256: Rc<str> = v1256.clone();
            let mut v1257: i32 = v1257.clone();
            let mut v1258: i32 = v1258.clone();
            let mut v1259: i32 = v1259.clone();
            let mut v1260: i32 = v1260.clone();
            let mut v1261: i32 = v1261.clone();
            let mut v1262: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
            let mut v1263: Rc<UH0> = Rc::new(UH0::UH0_1(v1256.clone(), v1262.clone()));
            method130(v0.clone(), v1263.clone(), v1257, v1258, v1259, v1260, v1261)
        }
        _ => unreachable!(),
    };
    let mut v1289: US20 = match &v1266 {
        US19::US19_1(v1280, v1281, v1282, v1283, v1284, v1285) => { // Error
            let mut v1280: Rc<dyn Fn(Rc<str>, i32, i32, i32, i32, i32) -> Rc<str>> = v1280.clone();
            let mut v1281: i32 = v1281.clone();
            let mut v1282: i32 = v1282.clone();
            let mut v1283: i32 = v1283.clone();
            let mut v1284: i32 = v1284.clone();
            let mut v1285: i32 = v1285.clone();
            let mut v1286: Rc<dyn Fn() -> Rc<str>> = closure34(v0.clone(), v1280.clone(), v1281, v1282, v1283, v1284, v1285);
            US20::US20_1(v1286.clone())
        }
        US19::US19_0(v1267, v1268, v1269, v1270, v1271, v1272) => { // Ok
            let mut v1267: Rc<UH0> = v1267.clone();
            let mut v1268: i32 = v1268.clone();
            let mut v1269: i32 = v1269.clone();
            let mut v1270: i32 = v1270.clone();
            let mut v1271: i32 = v1271.clone();
            let mut v1272: i32 = v1272.clone();
            let mut v1273: bool = v1268 >= v1272;
            let mut v1278: Rc<str> = if v1273 {
                let mut v1274: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v1274.clone()
            } else {
                let mut v1275: bool = v1268 == v1272;
                let mut v1276: i32 = v1272 - 1i32;
                let mut v1277: Rc<str> = string_slice(&v0.clone(), v1268 as i64, v1276 as i64);
                v1277.clone()
            };
            US20::US20_0(v1267.clone(), v1278.clone(), v1269, v1270, v1271, v1272)
        }
        _ => unreachable!(),
    };
    let mut v1305: US21 = match &v1289 {
        US20::US20_1(v1302) => { // Error
            let mut v1302: Rc<dyn Fn() -> Rc<str>> = v1302.clone();
            US21::US21_1(v1302.clone())
        }
        US20::US20_0(v1290, v1291, v1292, v1293, v1294, v1295) => { // Ok
            let mut v1290: Rc<UH0> = v1290.clone();
            let mut v1291: Rc<str> = v1291.clone();
            let mut v1292: i32 = v1292.clone();
            let mut v1293: i32 = v1293.clone();
            let mut v1294: i32 = v1294.clone();
            let mut v1295: i32 = v1295.clone();
            let mut v1296: i32 = 0i32;
            let mut v1297: i32 = method131(v1290.clone(), v1296);
            let mut v1298: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(Vec::with_capacity(v1297 as usize)));
            let mut v1299: i32 = 0i32;
            let mut v1300: i32 = method132(v1298.clone(), v1290.clone(), v1299);
            US21::US21_0(v1298.clone())
        }
        _ => unreachable!(),
    };
    match &v1305 {
        US21::US21_1(v1308) => { // Error
            let mut v1308: Rc<dyn Fn() -> Rc<str>> = v1308.clone();
            let mut v1309: Rc<str> = v1308();
            US18::US18_1(v1309.clone())
        }
        US21::US21_0(v1306) => { // Ok
            let mut v1306: Rc<RefCell<Vec<Rc<str>>>> = v1306.clone();
            US18::US18_0(v1306.clone())
        }
        _ => unreachable!(),
    }
}
fn closure51() -> Rc<dyn Fn((Rc<str>)) -> std::string::String> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((Rc<str>)) -> std::string::String> = Rc::new(move |mut v0: (Rc<str>)| -> std::string::String {
        let mut v1: Rc<str> = (v0);
        let mut v3: &str = &*v1;
        let mut v5: std::string::String = String::from(v3);
        v5.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method135(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_name"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method136(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("arguments"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method134(mut v0: Rc<str>, mut v1: Rc<str>) -> Rc<str> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v2.clone() }));
    method13(v3.clone());
    method135(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v0.clone());
    method41(v3.clone());
    method136(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v1.clone());
    method16(v3.clone());
    let mut v4: Rc<str> = v3.borrow().l0.clone();
    v4.clone()
}
fn method133(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = method11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.execute_with_options"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = method134(v8.clone(), v9.clone());
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    method8(v22.clone())
}
fn closure53() -> Rc<dyn Fn(std::string::String) -> US22> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US22> = Rc::new(move |mut v0: std::string::String| -> US22 {
        US22::US22_0(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method137() -> Rc<dyn Fn(std::string::String) -> US22> {
    closure53()
}
fn closure54() -> Rc<dyn Fn(std::string::String) -> US22> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US22> = Rc::new(move |mut v0: std::string::String| -> US22 {
        US22::US22_1(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method138() -> Rc<dyn Fn(std::string::String) -> US22> {
    closure54()
}
fn method139() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[91m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Critical"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.clone().as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = method5(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7.clone()
}
fn method142(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("trace'"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method141(mut v0: bool, mut v1: std::string::String) -> Rc<str> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v2.clone() }));
    method13(v3.clone());
    method142(v3.clone());
    method15(v3.clone());
    let mut v6: Rc<str> = if v0 {
        let mut v4: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("true"); } LIT.with(|lit| lit.clone()) };
        v4.clone()
    } else {
        let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("false"); } LIT.with(|lit| lit.clone()) };
        v5.clone()
    };
    method6(v3.clone(), v6.clone());
    method41(v3.clone());
    method103(v3.clone());
    method15(v3.clone());
    let mut v8: std::string::String = format!("{:#?}", v1);
    let mut v10: Rc<str> = Rc::<str>::from(v8);
    method6(v3.clone(), v10.clone());
    method16(v3.clone());
    let mut v11: Rc<str> = v3.borrow().l0.clone();
    v11.clone()
}
fn method140(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: bool, mut v9: std::string::String) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = method11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.stdio_line"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = method141(v8, v9.clone());
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    method8(v22.clone())
}
fn method143() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[90m"); } LIT.with(|lit| lit.clone()) };
    ;
    ;
    ;
    ;
    ;
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Verbose"); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<str> = Rc::<str>::from(v1.to_lowercase());
    let mut v3: u8 = v2.clone().as_bytes()[0i32 as usize];
    let mut v4: Rc<str> = method5(v3);
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}{}", v0, v4));
    let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("[0m"); } LIT.with(|lit| lit.clone()) };
    let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v5, v6));
    v7.clone()
}
fn method145() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v1: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v0.clone() }));
    let mut v2: Rc<str> = v1.borrow().l0.clone();
    v2.clone()
}
fn method144(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = method11(v9);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v10));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v8));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = method145();
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    method8(v20.clone())
}
fn closure52(mut v0: bool) -> Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> {
    Rc::new(move |mut v1: Result<std::string::String, std::string::String>| -> std::string::String {
        let mut v2: Rc<dyn Fn(std::string::String) -> US22> = method137();
        let mut v3: Rc<dyn Fn(std::string::String) -> US22> = method138();
        let mut v4: US22 = match v1 { Ok(x) => v2(x), Err(e) => v3(e) };
        match &v4 {
            US22::US22_1(v282) => { // Error
                let mut v282: std::string::String = v282.clone();
                let mut v430: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                { let _ = spiral_trace_hold(&v430); };
                let mut v432: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                let (mut v433, mut v434, mut v435, mut v436, mut v437, mut v438): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v432) };
                let mut v439: US0 = v437.borrow().l0.clone();
                let mut v444: i32 = match &v439 {
                    US0::US0_4 => { // Critical
                        50i32
                    }
                    US0::US0_1 => { // Debug
                        20i32
                    }
                    US0::US0_2 => { // Info
                        30i32
                    }
                    US0::US0_0 => { // Verbose
                        10i32
                    }
                    US0::US0_3 => { // Warning
                        40i32
                    }
                    _ => unreachable!(),
                };
                let mut v445: bool = v435.borrow().l0.clone();
                let mut v446: bool = v445 == false;
                let mut v448: bool = if v446 {
                    false
                } else {
                    let mut v447: bool = 50i32 >= v444;
                    v447
                };
                let mut v449: bool = v448 == false;
                let mut v494: US2 = if v449 {
                    US2::US2_1
                } else {
                    { let _ = spiral_trace_hold(&v430); };
                    let (mut v453, mut v454, mut v455, mut v456, mut v457, mut v458): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v432) };
                    let mut v459: Rc<str> = method3(v453.clone(), v454.clone(), v455.clone(), v456.clone(), v457.clone(), v458.clone());
                    let mut v460: Rc<str> = method139();
                    let mut v461: Rc<str> = method140(v453.clone(), v454.clone(), v455.clone(), v456.clone(), v457.clone(), v458.clone(), v459.clone(), v460.clone(), v0, v282.clone());
                    { let _ = spiral_trace_hold(&v430); };
                    let (mut v464, mut v465, mut v466, mut v467, mut v468, mut v469): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v432) };
                    let mut v470: i64 = v464.borrow().l0.clone();
                    let mut v471: i64 = v470 + 1i64;
                    v464.borrow_mut().l0 = v471;
                    let mut v472: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let mut v473: bool = cfg!(target_arch = "wasm32");
                    if v473 {
                        let mut v474: Rc<str> = v467.borrow().l0.clone();
                        let mut v475: bool = v474.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v483: Rc<str> = if v475 {
                            v461.clone()
                        } else {
                            let mut v476: bool = v461.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v476 {
                                let mut v477: Rc<str> = v467.borrow().l0.clone();
                                v477.clone()
                            } else {
                                let mut v478: Rc<str> = v467.borrow().l0.clone();
                                let mut v479: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v480: Rc<str> = Rc::<str>::from(format!("{}{}", v478, v479));
                                let mut v481: Rc<str> = Rc::<str>::from(format!("{}{}", v480, v461));
                                v481.clone()
                            }
                        };
                        let mut v485: i32 = ((v483.chars().count() + 14999) / 15000) as i32;
                        let mut v486: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v487: bool = v461 != v486 ;
                        let mut v489: bool = if v487 {
                            let mut v488: bool = v485 <= 1i32;
                            v488
                        } else {
                            false
                        };
                        if v489 {
                            v467.borrow_mut().l0 = v483.clone();
                            ()
                        } else {
                            v467.borrow_mut().l0 = v486.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v483); };
                            ()
                        }
                    } else {
                        println!("{}", v461);
                        ()
                    };
                    let mut v492: Rc<dyn Fn(Rc<str>) -> ()> = v465.borrow().l0.clone();
                    v492(v461.clone());
                    US2::US2_0(v464.clone(), v465.clone(), v466.clone(), v467.clone(), v468.clone(), v469.clone())
                };
                let mut v539: Rc<str> = Rc::<str>::from(format!("\u{001b}[4;7m{}\u{001b}[0m", v282));
                let mut v541: &str = &*v539;
                let mut v543: std::string::String = String::from(v541);
                v543.clone()
            }
            US22::US22_0(v5) => { // Ok
                let mut v5: std::string::String = v5.clone();
                let mut v7: std::string::String = v5.clone();
                let mut v9: Rc<str> = Rc::<str>::from(String::as_str(&v7));
                let mut v10: Rc<str> = Rc::<str>::from(format!("> {}", v9));
                if v0 {
                    let mut v167: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                    { let _ = spiral_trace_hold(&v167); };
                    let mut v169: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                    let (mut v170, mut v171, mut v172, mut v173, mut v174, mut v175): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v169) };
                    let mut v176: US0 = v174.borrow().l0.clone();
                    let mut v181: i32 = match &v176 {
                        US0::US0_4 => { // Critical
                            50i32
                        }
                        US0::US0_1 => { // Debug
                            20i32
                        }
                        US0::US0_2 => { // Info
                            30i32
                        }
                        US0::US0_0 => { // Verbose
                            10i32
                        }
                        US0::US0_3 => { // Warning
                            40i32
                        }
                        _ => unreachable!(),
                    };
                    let mut v182: bool = v172.borrow().l0.clone();
                    let mut v183: bool = v182 == false;
                    let mut v185: bool = if v183 {
                        false
                    } else {
                        let mut v184: bool = 10i32 >= v181;
                        v184
                    };
                    let mut v186: bool = v185 == false;
                    let mut v234: US2 = if v186 {
                        US2::US2_1
                    } else {
                        { let _ = spiral_trace_hold(&v167); };
                        let (mut v190, mut v191, mut v192, mut v193, mut v194, mut v195): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v169) };
                        let mut v196: Rc<str> = method3(v190.clone(), v191.clone(), v192.clone(), v193.clone(), v194.clone(), v195.clone());
                        let mut v197: Rc<str> = method143();
                        let mut v198: bool = v10.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v201: Rc<str> = if v198 {
                            let mut v199: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v199.clone()
                        } else {
                            method144(v190.clone(), v191.clone(), v192.clone(), v193.clone(), v194.clone(), v195.clone(), v196.clone(), v197.clone(), v10.clone())
                        };
                        { let _ = spiral_trace_hold(&v167); };
                        let (mut v204, mut v205, mut v206, mut v207, mut v208, mut v209): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v169) };
                        let mut v210: i64 = v204.borrow().l0.clone();
                        let mut v211: i64 = v210 + 1i64;
                        v204.borrow_mut().l0 = v211;
                        let mut v212: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                        let mut v213: bool = cfg!(target_arch = "wasm32");
                        if v213 {
                            let mut v214: Rc<str> = v207.borrow().l0.clone();
                            let mut v215: bool = v214.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v223: Rc<str> = if v215 {
                                v201.clone()
                            } else {
                                let mut v216: bool = v201.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                if v216 {
                                    let mut v217: Rc<str> = v207.borrow().l0.clone();
                                    v217.clone()
                                } else {
                                    let mut v218: Rc<str> = v207.borrow().l0.clone();
                                    let mut v219: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                    let mut v220: Rc<str> = Rc::<str>::from(format!("{}{}", v218, v219));
                                    let mut v221: Rc<str> = Rc::<str>::from(format!("{}{}", v220, v201));
                                    v221.clone()
                                }
                            };
                            let mut v225: i32 = ((v223.chars().count() + 14999) / 15000) as i32;
                            let mut v226: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v227: bool = v201 != v226 ;
                            let mut v229: bool = if v227 {
                                let mut v228: bool = v225 <= 1i32;
                                v228
                            } else {
                                false
                            };
                            if v229 {
                                v207.borrow_mut().l0 = v223.clone();
                                ()
                            } else {
                                v207.borrow_mut().l0 = v226.clone();
                                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v223); };
                                ()
                            }
                        } else {
                            println!("{}", v201);
                            ()
                        };
                        let mut v232: Rc<dyn Fn(Rc<str>) -> ()> = v205.borrow().l0.clone();
                        v232(v201.clone());
                        US2::US2_0(v204.clone(), v205.clone(), v206.clone(), v207.clone(), v208.clone(), v209.clone())
                    };
                    ()
                } else {
                    println!("{}", v10);
                    ()
                };
                v5.clone()
            }
            _ => unreachable!(),
        }
    })
}
fn closure55(mut v0: bool) -> Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> {
    Rc::new(move |mut v1: Result<std::string::String, std::string::String>| -> std::string::String {
        let mut v2: Rc<dyn Fn(std::string::String) -> US22> = method137();
        let mut v3: Rc<dyn Fn(std::string::String) -> US22> = method138();
        let mut v4: US22 = match v1 { Ok(x) => v2(x), Err(e) => v3(e) };
        match &v4 {
            US22::US22_1(v85) => { // Error
                let mut v85: std::string::String = v85.clone();
                let mut v87: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                { let _ = spiral_trace_hold(&v87); };
                let mut v89: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                let (mut v90, mut v91, mut v92, mut v93, mut v94, mut v95): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v89) };
                let mut v96: US0 = v94.borrow().l0.clone();
                let mut v101: i32 = match &v96 {
                    US0::US0_4 => { // Critical
                        50i32
                    }
                    US0::US0_1 => { // Debug
                        20i32
                    }
                    US0::US0_2 => { // Info
                        30i32
                    }
                    US0::US0_0 => { // Verbose
                        10i32
                    }
                    US0::US0_3 => { // Warning
                        40i32
                    }
                    _ => unreachable!(),
                };
                let mut v102: bool = v92.borrow().l0.clone();
                let mut v103: bool = v102 == false;
                let mut v105: bool = if v103 {
                    false
                } else {
                    let mut v104: bool = 50i32 >= v101;
                    v104
                };
                let mut v106: bool = v105 == false;
                let mut v151: US2 = if v106 {
                    US2::US2_1
                } else {
                    { let _ = spiral_trace_hold(&v87); };
                    let (mut v110, mut v111, mut v112, mut v113, mut v114, mut v115): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v89) };
                    let mut v116: Rc<str> = method3(v110.clone(), v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone());
                    let mut v117: Rc<str> = method139();
                    let mut v118: Rc<str> = method140(v110.clone(), v111.clone(), v112.clone(), v113.clone(), v114.clone(), v115.clone(), v116.clone(), v117.clone(), v0, v85.clone());
                    { let _ = spiral_trace_hold(&v87); };
                    let (mut v121, mut v122, mut v123, mut v124, mut v125, mut v126): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v89) };
                    let mut v127: i64 = v121.borrow().l0.clone();
                    let mut v128: i64 = v127 + 1i64;
                    v121.borrow_mut().l0 = v128;
                    let mut v129: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                    let mut v130: bool = cfg!(target_arch = "wasm32");
                    if v130 {
                        let mut v131: Rc<str> = v124.borrow().l0.clone();
                        let mut v132: bool = v131.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v140: Rc<str> = if v132 {
                            v118.clone()
                        } else {
                            let mut v133: bool = v118.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            if v133 {
                                let mut v134: Rc<str> = v124.borrow().l0.clone();
                                v134.clone()
                            } else {
                                let mut v135: Rc<str> = v124.borrow().l0.clone();
                                let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                let mut v137: Rc<str> = Rc::<str>::from(format!("{}{}", v135, v136));
                                let mut v138: Rc<str> = Rc::<str>::from(format!("{}{}", v137, v118));
                                v138.clone()
                            }
                        };
                        let mut v142: i32 = ((v140.chars().count() + 14999) / 15000) as i32;
                        let mut v143: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v144: bool = v118 != v143 ;
                        let mut v146: bool = if v144 {
                            let mut v145: bool = v142 <= 1i32;
                            v145
                        } else {
                            false
                        };
                        if v146 {
                            v124.borrow_mut().l0 = v140.clone();
                            ()
                        } else {
                            v124.borrow_mut().l0 = v143.clone();
                            { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v140); };
                            ()
                        }
                    } else {
                        println!("{}", v118);
                        ()
                    };
                    let mut v149: Rc<dyn Fn(Rc<str>) -> ()> = v122.borrow().l0.clone();
                    v149(v118.clone());
                    US2::US2_0(v121.clone(), v122.clone(), v123.clone(), v124.clone(), v125.clone(), v126.clone())
                };
                let mut v152: Rc<str> = Rc::<str>::from(format!("\u{001b}[4;7m{}\u{001b}[0m", v85));
                let mut v154: &str = &*v152;
                let mut v156: std::string::String = String::from(v154);
                v156.clone()
            }
            US22::US22_0(v5) => { // Ok
                let mut v5: std::string::String = v5.clone();
                let mut v7: std::string::String = v5.clone();
                let mut v9: Rc<str> = Rc::<str>::from(String::as_str(&v7));
                let mut v10: Rc<str> = Rc::<str>::from(format!("! {}", v9));
                if v0 {
                    let mut v12: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                    { let _ = spiral_trace_hold(&v12); };
                    let mut v14: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                    let (mut v15, mut v16, mut v17, mut v18, mut v19, mut v20): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                    let mut v21: US0 = v19.borrow().l0.clone();
                    let mut v26: i32 = match &v21 {
                        US0::US0_4 => { // Critical
                            50i32
                        }
                        US0::US0_1 => { // Debug
                            20i32
                        }
                        US0::US0_2 => { // Info
                            30i32
                        }
                        US0::US0_0 => { // Verbose
                            10i32
                        }
                        US0::US0_3 => { // Warning
                            40i32
                        }
                        _ => unreachable!(),
                    };
                    let mut v27: bool = v17.borrow().l0.clone();
                    let mut v28: bool = v27 == false;
                    let mut v30: bool = if v28 {
                        false
                    } else {
                        let mut v29: bool = 10i32 >= v26;
                        v29
                    };
                    let mut v31: bool = v30 == false;
                    let mut v79: US2 = if v31 {
                        US2::US2_1
                    } else {
                        { let _ = spiral_trace_hold(&v12); };
                        let (mut v35, mut v36, mut v37, mut v38, mut v39, mut v40): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                        let mut v41: Rc<str> = method3(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone());
                        let mut v42: Rc<str> = method143();
                        let mut v43: bool = v10.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        let mut v46: Rc<str> = if v43 {
                            let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            v44.clone()
                        } else {
                            method144(v35.clone(), v36.clone(), v37.clone(), v38.clone(), v39.clone(), v40.clone(), v41.clone(), v42.clone(), v10.clone())
                        };
                        { let _ = spiral_trace_hold(&v12); };
                        let (mut v49, mut v50, mut v51, mut v52, mut v53, mut v54): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v14) };
                        let mut v55: i64 = v49.borrow().l0.clone();
                        let mut v56: i64 = v55 + 1i64;
                        v49.borrow_mut().l0 = v56;
                        let mut v57: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                        let mut v58: bool = cfg!(target_arch = "wasm32");
                        if v58 {
                            let mut v59: Rc<str> = v52.borrow().l0.clone();
                            let mut v60: bool = v59.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v68: Rc<str> = if v60 {
                                v46.clone()
                            } else {
                                let mut v61: bool = v46.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                if v61 {
                                    let mut v62: Rc<str> = v52.borrow().l0.clone();
                                    v62.clone()
                                } else {
                                    let mut v63: Rc<str> = v52.borrow().l0.clone();
                                    let mut v64: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                    let mut v65: Rc<str> = Rc::<str>::from(format!("{}{}", v63, v64));
                                    let mut v66: Rc<str> = Rc::<str>::from(format!("{}{}", v65, v46));
                                    v66.clone()
                                }
                            };
                            let mut v70: i32 = ((v68.chars().count() + 14999) / 15000) as i32;
                            let mut v71: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v72: bool = v46 != v71 ;
                            let mut v74: bool = if v72 {
                                let mut v73: bool = v70 <= 1i32;
                                v73
                            } else {
                                false
                            };
                            if v74 {
                                v52.borrow_mut().l0 = v68.clone();
                                ()
                            } else {
                                v52.borrow_mut().l0 = v71.clone();
                                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v68); };
                                ()
                            }
                        } else {
                            println!("{}", v46);
                            ()
                        };
                        let mut v77: Rc<dyn Fn(Rc<str>) -> ()> = v50.borrow().l0.clone();
                        v77(v46.clone());
                        US2::US2_0(v49.clone(), v50.clone(), v51.clone(), v52.clone(), v53.clone(), v54.clone())
                    };
                    ()
                } else {
                    println!("{}", v10);
                    ()
                };
                let mut v80: Rc<str> = Rc::<str>::from(format!("\u{001b}[4;7m{}\u{001b}[0m", v5));
                let mut v82: &str = &*v80;
                let mut v84: std::string::String = String::from(v82);
                v84.clone()
            }
            _ => unreachable!(),
        }
    })
}
fn method147(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method42(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v0.clone());
    method41(v4.clone());
    method135(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v1.clone());
    method41(v4.clone());
    method136(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v2.clone());
    method16(v4.clone());
    let mut v5: Rc<str> = v4.borrow().l0.clone();
    v5.clone()
}
fn method146(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.execute_with_options / child error"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method147(v8.clone(), v9.clone(), v10.clone());
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
}
fn method148(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.execute_with_options / output error"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method147(v8.clone(), v9.clone(), v10.clone());
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
}
fn method149(mut v0: Option<i32>) -> Option<i32> {
    v0.clone()
}
fn closure56() -> Rc<dyn Fn((i32)) -> US23> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((i32)) -> US23> = Rc::new(move |mut v0: (i32)| -> US23 {
        let mut v1: i32 = (v0);
        US23::US23_0(v1)
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn closure57() -> Rc<dyn Fn((std::string::String)) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((std::string::String)) -> Rc<str>> = Rc::new(move |mut v0: (std::string::String)| -> Rc<str> {
        let mut v1: std::string::String = (v0);
        let mut v3: Rc<str> = Rc::<str>::from(String::as_str(&v1));
        v3.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method150(mut v0: Vec<Rc<str>>) -> Vec<Rc<str>> {
    v0.clone()
}
fn method151(mut v0: Rc<str>, mut v1: i32) -> i32 {
    loop {
        let mut v2: bool = v1 <= 0i32;
        if v2 {
            return -1i32;
        } else {
            let mut v3: i32 = v1 - 1i32;
            let mut v4: u8 = v0.clone().as_bytes()[v3 as usize];
            let mut v5: bool = v4 == b' ';
            let mut v11: bool = if v5 {
                true
            } else {
                let mut v6: bool = v4 == b'\t';
                if v6 {
                    true
                } else {
                    let mut v7: bool = v4 == b'\r';
                    if v7 {
                        true
                    } else {
                        let mut v8: bool = v4 == b'\n';
                        v8
                    }
                }
            };
            if v11 {
                (v0, v1) = (v0.clone(), v3);
                continue;
            } else {
                return v3;
            }
        }
    }
}
fn method154(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method155(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("std_trace_len"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method153(mut v0: Rc<str>, mut v1: i32, mut v2: i32) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method135(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v0.clone());
    method41(v4.clone());
    method154(v4.clone());
    method15(v4.clone());
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v4.clone(), v5.clone());
    method41(v4.clone());
    method155(v4.clone());
    method15(v4.clone());
    let mut v6: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v4.clone(), v6.clone());
    method16(v4.clone());
    let mut v7: Rc<str> = v4.borrow().l0.clone();
    v7.clone()
}
fn method152(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: i32, mut v10: i32) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.execute_with_options / result"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method153(v8.clone(), v9, v10);
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
}
fn method78(mut v0: Rc<str>, mut v1: Option<std::sync::Arc<std::sync::atomic::AtomicBool>>, mut v2: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>>, mut v3: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>>, mut v4: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>>, mut v5: bool, mut v6: Option<Rc<str>>, mut v7: bool) -> (i32, Rc<str>) {
    let mut v933: Rc<str> = method79(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5, v6.clone(), v7);
    let mut v934: US9 = method80(v933.clone());
    let (mut v943, mut v944): (Rc<str>, US4) = match &v934 {
        US9::US9_1(v937) => { // Error
            let mut v937: Rc<str> = v937.clone();
            let mut v938: Rc<str> = Rc::<str>::from(format!("resultm.get / Error x: {:?}", v937));
            std::panic::panic_any::<std::string::String>(format!("{}", v938.clone()))
        }
        US9::US9_0(v935, v936) => { // Ok
            let mut v935: Rc<str> = v935.clone();
            let mut v936: US4 = v936.clone();
            (v935.clone(), v936.clone())
        }
        _ => unreachable!(),
    };
    let mut v948: Rc<str> = match &v944 {
        US4::US4_1 => { // None
            let mut v946: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            v946.clone()
        }
        US4::US4_0(v945) => { // Some
            let mut v945: Rc<str> = v945.clone();
            v945.clone()
        }
        _ => unreachable!(),
    };
    let mut v949: US18 = method110(v948.clone());
    let mut v955: Rc<RefCell<Vec<Rc<str>>>> = match &v949 {
        US18::US18_1(v951) => { // Error
            let mut v951: Rc<str> = v951.clone();
            let mut v952: Rc<str> = Rc::<str>::from(format!("resultm.get / Error x: {:?}", v951));
            std::panic::panic_any::<std::string::String>(format!("{}", v952.clone()))
        }
        US18::US18_0(v950) => { // Ok
            let mut v950: Rc<RefCell<Vec<Rc<str>>>> = v950.clone();
            v950.clone()
        }
        _ => unreachable!(),
    };
    let mut v956: Vec<Rc<str>> = (v955).borrow().clone();
    let mut v958: Rc<dyn Fn((Rc<str>)) -> std::string::String> = closure51();
    let mut v959: Vec<std::string::String> = v956.iter().map(|x| v958(x.clone())).collect::<Vec<_>>();
    let mut v961: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
    { let _ = spiral_trace_hold(&v961); };
    let mut v963: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
    let (mut v964, mut v965, mut v966, mut v967, mut v968, mut v969): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
    let mut v970: US0 = v968.borrow().l0.clone();
    let mut v975: i32 = match &v970 {
        US0::US0_4 => { // Critical
            50i32
        }
        US0::US0_1 => { // Debug
            20i32
        }
        US0::US0_2 => { // Info
            30i32
        }
        US0::US0_0 => { // Verbose
            10i32
        }
        US0::US0_3 => { // Warning
            40i32
        }
        _ => unreachable!(),
    };
    let mut v976: bool = v966.borrow().l0.clone();
    let mut v977: bool = v976 == false;
    let mut v979: bool = if v977 {
        false
    } else {
        let mut v978: bool = 20i32 >= v975;
        v978
    };
    let mut v980: bool = v979 == false;
    let mut v1026: US2 = if v980 {
        US2::US2_1
    } else {
        { let _ = spiral_trace_hold(&v961); };
        let (mut v984, mut v985, mut v986, mut v987, mut v988, mut v989): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
        let mut v990: Rc<str> = method3(v984.clone(), v985.clone(), v986.clone(), v987.clone(), v988.clone(), v989.clone());
        let mut v991: Rc<str> = method62();
        let mut v992: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<std::string::String>>") } } (&&W(&v959)).s() });
        let mut v993: Rc<str> = method133(v984.clone(), v985.clone(), v986.clone(), v987.clone(), v988.clone(), v989.clone(), v990.clone(), v991.clone(), v943.clone(), v992.clone());
        { let _ = spiral_trace_hold(&v961); };
        let (mut v996, mut v997, mut v998, mut v999, mut v1000, mut v1001): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
        let mut v1002: i64 = v996.borrow().l0.clone();
        let mut v1003: i64 = v1002 + 1i64;
        v996.borrow_mut().l0 = v1003;
        let mut v1004: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let mut v1005: bool = cfg!(target_arch = "wasm32");
        if v1005 {
            let mut v1006: Rc<str> = v999.borrow().l0.clone();
            let mut v1007: bool = v1006.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v1015: Rc<str> = if v1007 {
                v993.clone()
            } else {
                let mut v1008: bool = v993.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v1008 {
                    let mut v1009: Rc<str> = v999.borrow().l0.clone();
                    v1009.clone()
                } else {
                    let mut v1010: Rc<str> = v999.borrow().l0.clone();
                    let mut v1011: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let mut v1012: Rc<str> = Rc::<str>::from(format!("{}{}", v1010, v1011));
                    let mut v1013: Rc<str> = Rc::<str>::from(format!("{}{}", v1012, v993));
                    v1013.clone()
                }
            };
            let mut v1017: i32 = ((v1015.chars().count() + 14999) / 15000) as i32;
            let mut v1018: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v1019: bool = v993 != v1018 ;
            let mut v1021: bool = if v1019 {
                let mut v1020: bool = v1017 <= 1i32;
                v1020
            } else {
                false
            };
            if v1021 {
                v999.borrow_mut().l0 = v1015.clone();
                ()
            } else {
                v999.borrow_mut().l0 = v1018.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1015); };
                ()
            }
        } else {
            println!("{}", v993);
            ()
        };
        let mut v1024: Rc<dyn Fn(Rc<str>) -> ()> = v997.borrow().l0.clone();
        v1024(v993.clone());
        US2::US2_0(v996.clone(), v997.clone(), v998.clone(), v999.clone(), v1000.clone(), v1001.clone())
    };
    let mut v1028: Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> = closure52(v5);
    let mut v1029: Rc<dyn Fn(Result<std::string::String, std::string::String>) -> std::string::String> = closure55(v5);
    let (mut v1030, mut v1031, mut v1032, mut v1033): (i32, Option<i32>, Option<std::string::String>, Vec<std::string::String>) = { let wd: Option<std::rc::Rc<str>> = v6.clone(); let stdin_fn: Option<std::rc::Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>)>> = v4.clone(); let token: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = v1.clone(); let stderr_on: bool = v7; let mut c = std::process::Command::new(&*v943); c.args(&*v959); c.stdout(std::process::Stdio::piped()); c.stderr(std::process::Stdio::piped()); c.stdin(std::process::Stdio::piped()); if let Some(d) = &wd { c.current_dir(&**d); } for (k, v) in v2.borrow().iter() { c.env(&**k, &**v); } match c.spawn() { Err(e) => (1i32, None, Some(format!("{}", e)), Vec::new()), Ok(mut child) => { let out = child.stdout.take().unwrap(); let err = child.stderr.take().unwrap(); let (tx, rx) = std::sync::mpsc::channel::<(bool, Result<std::string::String, std::string::String>)>(); let tx2 = tx.clone(); let h1 = std::thread::spawn(move || { for l in std::io::BufRead::lines(std::io::BufReader::new(encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(out))) { if tx.send((false, l.map_err(|e| format!("{}", e)))).is_err() { break; } } }); let h2 = std::thread::spawn(move || { for l in std::io::BufRead::lines(std::io::BufReader::new(encoding_rs_io::DecodeReaderBytesBuilder::new().utf8_passthru(true).build(err))) { if stderr_on && tx2.send((true, l.map_err(|e| format!("{}", e)))).is_err() { break; } } }); if let (Some(f), Some(s)) = (&stdin_fn, child.stdin.take()) { let a = std::sync::Arc::new(std::sync::Mutex::new(s)); f(a.clone()); let _ = std::io::Write::flush(&mut *a.lock().unwrap()); } let mut lines: Vec<std::string::String> = Vec::new(); let mut cancelled = false; loop { if let Some(t) = &token { if t.load(std::sync::atomic::Ordering::SeqCst) { let _ = child.kill(); cancelled = true; break; } } match rx.recv_timeout(std::time::Duration::from_millis(100)) { Ok((false, l)) => lines.push(v1028(l)), Ok((true, l)) => lines.push(v1029(l)), Err(std::sync::mpsc::RecvTimeoutError::Timeout) => {}, Err(std::sync::mpsc::RecvTimeoutError::Disconnected) => break } } if !cancelled { let _ = h1.join(); let _ = h2.join(); } match child.wait() { Ok(s) => (0i32, s.code(), None, lines), Err(e) => (2i32, None, Some(format!("{}", e)), lines) } } } };
    let mut v1034: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v1036: &str = &*v1034;
    let mut v1038: std::string::String = String::from(v1036);
    let mut v1039: std::string::String = v1032.unwrap_or(v1038);
    let mut v1041: Rc<str> = Rc::<str>::from(String::as_str(&v1039));
    let mut v1042: bool = v1030 == 1i32;
    let (mut v1203, mut v1204): (i32, Rc<str>) = if v1042 {
        { let _ = spiral_trace_hold(&v961); };
        let (mut v1045, mut v1046, mut v1047, mut v1048, mut v1049, mut v1050): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
        let mut v1051: US0 = v1049.borrow().l0.clone();
        let mut v1056: i32 = match &v1051 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
            _ => unreachable!(),
        };
        let mut v1057: bool = v1047.borrow().l0.clone();
        let mut v1058: bool = v1057 == false;
        let mut v1060: bool = if v1058 {
            false
        } else {
            let mut v1059: bool = 50i32 >= v1056;
            v1059
        };
        let mut v1061: bool = v1060 == false;
        let mut v1106: US2 = if v1061 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v961); };
            let (mut v1065, mut v1066, mut v1067, mut v1068, mut v1069, mut v1070): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
            let mut v1071: Rc<str> = method3(v1065.clone(), v1066.clone(), v1067.clone(), v1068.clone(), v1069.clone(), v1070.clone());
            let mut v1072: Rc<str> = method139();
            let mut v1073: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<std::string::String>>") } } (&&W(&v959)).s() });
            let mut v1074: Rc<str> = method146(v1065.clone(), v1066.clone(), v1067.clone(), v1068.clone(), v1069.clone(), v1070.clone(), v1071.clone(), v1072.clone(), v1041.clone(), v943.clone(), v1073.clone());
            { let _ = spiral_trace_hold(&v961); };
            let (mut v1077, mut v1078, mut v1079, mut v1080, mut v1081, mut v1082): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
            let mut v1083: i64 = v1077.borrow().l0.clone();
            let mut v1084: i64 = v1083 + 1i64;
            v1077.borrow_mut().l0 = v1084;
            let mut v1085: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
            let mut v1086: bool = cfg!(target_arch = "wasm32");
            if v1086 {
                let mut v1087: Rc<str> = v1080.borrow().l0.clone();
                let mut v1088: bool = v1087.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v1096: Rc<str> = if v1088 {
                    v1074.clone()
                } else {
                    let mut v1089: bool = v1074.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v1089 {
                        let mut v1090: Rc<str> = v1080.borrow().l0.clone();
                        v1090.clone()
                    } else {
                        let mut v1091: Rc<str> = v1080.borrow().l0.clone();
                        let mut v1092: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v1093: Rc<str> = Rc::<str>::from(format!("{}{}", v1091, v1092));
                        let mut v1094: Rc<str> = Rc::<str>::from(format!("{}{}", v1093, v1074));
                        v1094.clone()
                    }
                };
                let mut v1098: i32 = ((v1096.chars().count() + 14999) / 15000) as i32;
                let mut v1099: bool = v1074 != v1034 ;
                let mut v1101: bool = if v1099 {
                    let mut v1100: bool = v1098 <= 1i32;
                    v1100
                } else {
                    false
                };
                if v1101 {
                    v1080.borrow_mut().l0 = v1096.clone();
                    ()
                } else {
                    v1080.borrow_mut().l0 = v1034.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1096); };
                    ()
                }
            } else {
                println!("{}", v1074);
                ()
            };
            let mut v1104: Rc<dyn Fn(Rc<str>) -> ()> = v1078.borrow().l0.clone();
            v1104(v1074.clone());
            US2::US2_0(v1077.clone(), v1078.clone(), v1079.clone(), v1080.clone(), v1081.clone(), v1082.clone())
        };
        (-1i32, v1041.clone())
    } else {
        let mut v1107: bool = v1030 == 2i32;
        if v1107 {
            { let _ = spiral_trace_hold(&v961); };
            let (mut v1110, mut v1111, mut v1112, mut v1113, mut v1114, mut v1115): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
            let mut v1116: US0 = v1114.borrow().l0.clone();
            let mut v1121: i32 = match &v1116 {
                US0::US0_4 => { // Critical
                    50i32
                }
                US0::US0_1 => { // Debug
                    20i32
                }
                US0::US0_2 => { // Info
                    30i32
                }
                US0::US0_0 => { // Verbose
                    10i32
                }
                US0::US0_3 => { // Warning
                    40i32
                }
                _ => unreachable!(),
            };
            let mut v1122: bool = v1112.borrow().l0.clone();
            let mut v1123: bool = v1122 == false;
            let mut v1125: bool = if v1123 {
                false
            } else {
                let mut v1124: bool = 50i32 >= v1121;
                v1124
            };
            let mut v1126: bool = v1125 == false;
            let mut v1171: US2 = if v1126 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v961); };
                let (mut v1130, mut v1131, mut v1132, mut v1133, mut v1134, mut v1135): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
                let mut v1136: Rc<str> = method3(v1130.clone(), v1131.clone(), v1132.clone(), v1133.clone(), v1134.clone(), v1135.clone());
                let mut v1137: Rc<str> = method139();
                let mut v1138: Rc<str> = Rc::<str>::from({ struct W<T>(T); trait D { fn s(&self) -> String; } impl<T: std::fmt::Debug> D for &W<T> { fn s(&self) -> String { format!("{:?}", self.0) } } trait P { fn s(&self) -> String; } impl<T> P for W<T> { fn s(&self) -> String { String::from("<Vec<std::string::String>>") } } (&&W(&v959)).s() });
                let mut v1139: Rc<str> = method148(v1130.clone(), v1131.clone(), v1132.clone(), v1133.clone(), v1134.clone(), v1135.clone(), v1136.clone(), v1137.clone(), v1041.clone(), v943.clone(), v1138.clone());
                { let _ = spiral_trace_hold(&v961); };
                let (mut v1142, mut v1143, mut v1144, mut v1145, mut v1146, mut v1147): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
                let mut v1148: i64 = v1142.borrow().l0.clone();
                let mut v1149: i64 = v1148 + 1i64;
                v1142.borrow_mut().l0 = v1149;
                let mut v1150: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                let mut v1151: bool = cfg!(target_arch = "wasm32");
                if v1151 {
                    let mut v1152: Rc<str> = v1145.borrow().l0.clone();
                    let mut v1153: bool = v1152.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v1161: Rc<str> = if v1153 {
                        v1139.clone()
                    } else {
                        let mut v1154: bool = v1139.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v1154 {
                            let mut v1155: Rc<str> = v1145.borrow().l0.clone();
                            v1155.clone()
                        } else {
                            let mut v1156: Rc<str> = v1145.borrow().l0.clone();
                            let mut v1157: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v1158: Rc<str> = Rc::<str>::from(format!("{}{}", v1156, v1157));
                            let mut v1159: Rc<str> = Rc::<str>::from(format!("{}{}", v1158, v1139));
                            v1159.clone()
                        }
                    };
                    let mut v1163: i32 = ((v1161.chars().count() + 14999) / 15000) as i32;
                    let mut v1164: bool = v1139 != v1034 ;
                    let mut v1166: bool = if v1164 {
                        let mut v1165: bool = v1163 <= 1i32;
                        v1165
                    } else {
                        false
                    };
                    if v1166 {
                        v1145.borrow_mut().l0 = v1161.clone();
                        ()
                    } else {
                        v1145.borrow_mut().l0 = v1034.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1161); };
                        ()
                    }
                } else {
                    println!("{}", v1139);
                    ()
                };
                let mut v1169: Rc<dyn Fn(Rc<str>) -> ()> = v1143.borrow().l0.clone();
                v1169(v1139.clone());
                US2::US2_0(v1142.clone(), v1143.clone(), v1144.clone(), v1145.clone(), v1146.clone(), v1147.clone())
            };
            (-2i32, v1041.clone())
        } else {
            let mut v1172: Option<i32> = method149(v1031.clone());
            let mut v1173: Rc<dyn Fn((i32)) -> US23> = closure56();
            let mut v1174: Option<US23> = v1172.map(|x| v1173(x));
            let mut v1175: US23 = US23::US23_1;
            let mut v1176: US23 = v1174.unwrap_or(v1175);
            let (mut v1181, mut v1182): (i32, Rc<str>) = match &v1176 {
                US23::US23_1 => { // None
                    let mut v1178: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("runtime.execute_with_options / exit_code=None"); } LIT.with(|lit| lit.clone()) };
                    (-1i32, v1178.clone())
                }
                US23::US23_0(v1177) => { // Some
                    let mut v1177: i32 = v1177.clone();
                    (v1177, v1034.clone())
                }
                _ => unreachable!(),
            };
            let mut v1184: Rc<dyn Fn((std::string::String)) -> Rc<str>> = closure57();
            let mut v1185: Vec<Rc<str>> = v1033.iter().map(|x| v1184(x.clone())).collect::<Vec<_>>();
            let mut v1186: Vec<Rc<str>> = method150(v1185.clone());
            let mut v1187: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v1186));
            let mut v1188: Rc<Vec<Rc<str>>> = Rc::new(v1187.borrow().clone());
            let mut v1189: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
            let mut v1190: Rc<str> = Rc::<str>::from(v1188.iter().map(|x| x.to_string()).collect::<Vec<_>>().join(&*v1189));
            let mut v1191: i32 = (v1190.clone().len() as i32);
            let mut v1192: i32 = 0i32;
            let mut v1193: i32 = method9(v1190.clone(), v1191, v1192);
            let mut v1194: i32 = v1191 - 1i32;
            let mut v1195: Rc<str> = string_slice(&v1190.clone(), v1193 as i64, v1194 as i64);
            let mut v1196: i32 = (v1195.clone().len() as i32);
            let mut v1197: i32 = method151(v1195.clone(), v1196);
            let mut v1198: Rc<str> = string_slice(&v1195.clone(), 0i32 as i64, v1197 as i64);
            let mut v1199: bool = v1198.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v1200: Rc<str> = if v1199 {
                v1182.clone()
            } else {
                v1198.clone()
            };
            (v1181, v1200.clone())
        }
    };
    { let _ = spiral_trace_hold(&v961); };
    let (mut v1207, mut v1208, mut v1209, mut v1210, mut v1211, mut v1212): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
    let mut v1213: US0 = v1211.borrow().l0.clone();
    let mut v1218: i32 = match &v1213 {
        US0::US0_4 => { // Critical
            50i32
        }
        US0::US0_1 => { // Debug
            20i32
        }
        US0::US0_2 => { // Info
            30i32
        }
        US0::US0_0 => { // Verbose
            10i32
        }
        US0::US0_3 => { // Warning
            40i32
        }
        _ => unreachable!(),
    };
    let mut v1219: bool = v1209.borrow().l0.clone();
    let mut v1220: bool = v1219 == false;
    let mut v1222: bool = if v1220 {
        false
    } else {
        let mut v1221: bool = 10i32 >= v1218;
        v1221
    };
    let mut v1223: bool = v1222 == false;
    let mut v1268: US2 = if v1223 {
        US2::US2_1
    } else {
        { let _ = spiral_trace_hold(&v961); };
        let (mut v1227, mut v1228, mut v1229, mut v1230, mut v1231, mut v1232): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
        let mut v1233: Rc<str> = method3(v1227.clone(), v1228.clone(), v1229.clone(), v1230.clone(), v1231.clone(), v1232.clone());
        let mut v1234: Rc<str> = method143();
        let mut v1235: i32 = (v1204.clone().len() as i32);
        let mut v1236: Rc<str> = method152(v1227.clone(), v1228.clone(), v1229.clone(), v1230.clone(), v1231.clone(), v1232.clone(), v1233.clone(), v1234.clone(), v943.clone(), v1203, v1235);
        { let _ = spiral_trace_hold(&v961); };
        let (mut v1239, mut v1240, mut v1241, mut v1242, mut v1243, mut v1244): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v963) };
        let mut v1245: i64 = v1239.borrow().l0.clone();
        let mut v1246: i64 = v1245 + 1i64;
        v1239.borrow_mut().l0 = v1246;
        let mut v1247: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let mut v1248: bool = cfg!(target_arch = "wasm32");
        if v1248 {
            let mut v1249: Rc<str> = v1242.borrow().l0.clone();
            let mut v1250: bool = v1249.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v1258: Rc<str> = if v1250 {
                v1236.clone()
            } else {
                let mut v1251: bool = v1236.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v1251 {
                    let mut v1252: Rc<str> = v1242.borrow().l0.clone();
                    v1252.clone()
                } else {
                    let mut v1253: Rc<str> = v1242.borrow().l0.clone();
                    let mut v1254: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let mut v1255: Rc<str> = Rc::<str>::from(format!("{}{}", v1253, v1254));
                    let mut v1256: Rc<str> = Rc::<str>::from(format!("{}{}", v1255, v1236));
                    v1256.clone()
                }
            };
            let mut v1260: i32 = ((v1258.chars().count() + 14999) / 15000) as i32;
            let mut v1261: bool = v1236 != v1034 ;
            let mut v1263: bool = if v1261 {
                let mut v1262: bool = v1260 <= 1i32;
                v1262
            } else {
                false
            };
            if v1263 {
                v1242.borrow_mut().l0 = v1258.clone();
                ()
            } else {
                v1242.borrow_mut().l0 = v1034.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1258); };
                ()
            }
        } else {
            println!("{}", v1236);
            ()
        };
        let mut v1266: Rc<dyn Fn(Rc<str>) -> ()> = v1240.borrow().l0.clone();
        v1266(v1236.clone());
        US2::US2_0(v1239.clone(), v1240.clone(), v1241.clone(), v1242.clone(), v1243.clone(), v1244.clone())
    };
    (v1203, v1204.clone())
}
fn method156(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>) -> (Rc<str>, Rc<str>) {
    let mut v3: Rc<str> = method47(v1.clone());
    let mut v4: Rc<str> = method29(v2.clone(), v3.clone());
    let mut v5: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("."); } LIT.with(|lit| lit.clone()) };
    let mut v13: i32 = v1.rfind(&*v5).map(|i| i as i32).unwrap_or(-1);
    let mut v14: i32 = v13 - 1i32;
    let mut v15: Rc<str> = string_slice(&v1.clone(), 0i32 as i64, v14 as i64);
    let mut v16: i32 = v4.rfind(&*v5).map(|i| i as i32).unwrap_or(-1);
    let mut v17: i32 = v16 - 1i32;
    let mut v18: Rc<str> = string_slice(&v4.clone(), 0i32 as i64, v17 as i64);
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".md"); } LIT.with(|lit| lit.clone()) };
    let mut v20: bool = v0.ends_with(&*v19);
    let mut v21: bool = v20 == false;
    let mut v24: Rc<str> = if v21 {
        let mut v22: Rc<str> = Rc::<str>::from(format!("{}.{}", v1, v0));
        v22.clone()
    } else {
        let mut v23: Rc<str> = Rc::<str>::from(format!("{}.{}", v15, v0));
        v23.clone()
    };
    let mut v27: Rc<str> = if v21 {
        let mut v25: Rc<str> = Rc::<str>::from(format!("{}.{}", v4, v0));
        v25.clone()
    } else {
        let mut v26: Rc<str> = Rc::<str>::from(format!("{}.{}", v18, v0));
        v26.clone()
    };
    (v24.clone(), v27.clone())
}
fn closure58() -> Rc<dyn Fn((u8)) -> Rc<str>> {
    thread_local!{ static CLOSURE: Rc<dyn Fn((u8)) -> Rc<str>> = Rc::new(move |mut v0: (u8)| -> Rc<str> {
        let mut v1: u8 = (v0);
        let mut v3: std::string::String = format!("{:02x}", v1);
        let mut v5: Rc<str> = Rc::<str>::from(String::as_str(&v3));
        v5.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method157(mut v0: Vec<Rc<str>>) -> Vec<Rc<str>> {
    v0.clone()
}
fn method158(mut v0: Rc<Vec<Rc<str>>>, mut v1: i32, mut v2: Rc<UH0>) -> Rc<UH0> {
    loop {
        let mut v3: bool = v1 < 0i32;
        if v3 {
            return v2.clone();
        } else {
            let mut v4: Rc<str> = (v0)[v1 as usize].clone();
            let mut v5: i32 = v1 - 1i32;
            let mut v6: Rc<UH0> = Rc::new(UH0::UH0_1(v4.clone(), v2.clone()));
            (v0, v1, v2) = (v0.clone(), v5, v6.clone());
            continue;
        }
    }
}
fn method159() -> Rc<str> {
    let mut v0: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    v0.clone()
}
fn method160(mut v0: Rc<str>, mut v1: Rc<UH0>, mut v2: Rc<str>) -> (Rc<str>, Rc<str>) {
    let (mut v11, mut v12): (Rc<str>, Rc<str>) = match &*v1 {
        UH0::UH0_1(v3, v4) => { // Cons
            let mut v3: Rc<str> = v3.clone();
            let mut v4: Rc<UH0> = v4.clone();
            let (mut v5, mut v6): (Rc<str>, Rc<str>) = method160(v0.clone(), v4.clone(), v2.clone());
            let mut v7: Rc<str> = Rc::<str>::from(format!("{}{}", v3, v6));
            let mut v8: Rc<str> = Rc::<str>::from(format!("{}{}", v7, v5));
            (v8.clone(), v0.clone())
        }
        _ => {
            let (mut v9, mut v10): (Rc<str>, Rc<str>) = match &*v1 {
                UH0::UH0_0 => { // Nil
                    (v2.clone(), v2.clone())
                }
                _ => unreachable!(),
            };
            (v9.clone(), v10.clone())
        }
    };
    (v11.clone(), v12.clone())
}
fn closure59() -> Rc<dyn Fn(std::io::Error) -> std::string::String> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::io::Error) -> std::string::String> = Rc::new(move |mut v0: std::io::Error| -> std::string::String {
        let mut v2: std::string::String = format!("{}", v0);
        v2.clone()
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method161() -> Rc<dyn Fn(std::io::Error) -> std::string::String> {
    closure59()
}
fn closure60() -> Rc<dyn Fn(Rc<str>) -> US25> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Rc<str>) -> US25> = Rc::new(move |mut v0: Rc<str>| -> US25 {
        US25::US25_0(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method162() -> Rc<dyn Fn(Rc<str>) -> US25> {
    closure60()
}
fn closure61() -> Rc<dyn Fn(std::string::String) -> US25> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US25> = Rc::new(move |mut v0: std::string::String| -> US25 {
        US25::US25_1(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method163() -> Rc<dyn Fn(std::string::String) -> US25> {
    closure61()
}
fn method166(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method167(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("real_path"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method168(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("relative_path"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method169(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("origin_hash_exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method170(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("origin_hash"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method171(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("local_git_hash_exit_code"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method172(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("local_git_hash"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method173(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hash1"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method174(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hash2"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method175(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("dist_path"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method176(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("cache_path"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method165(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: i32, mut v4: Rc<str>, mut v5: i32, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: US4, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v11.clone() }));
    method13(v12.clone());
    method166(v12.clone());
    method15(v12.clone());
    method6(v12.clone(), v0.clone());
    method41(v12.clone());
    method167(v12.clone());
    method15(v12.clone());
    method6(v12.clone(), v1.clone());
    method41(v12.clone());
    method168(v12.clone());
    method15(v12.clone());
    method6(v12.clone(), v2.clone());
    method41(v12.clone());
    method169(v12.clone());
    method15(v12.clone());
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}", v3));
    method6(v12.clone(), v13.clone());
    method41(v12.clone());
    method170(v12.clone());
    method15(v12.clone());
    method6(v12.clone(), v4.clone());
    method41(v12.clone());
    method171(v12.clone());
    method15(v12.clone());
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}", v5));
    method6(v12.clone(), v14.clone());
    method41(v12.clone());
    method172(v12.clone());
    method15(v12.clone());
    method6(v12.clone(), v6.clone());
    method41(v12.clone());
    method173(v12.clone());
    method15(v12.clone());
    method6(v12.clone(), v7.clone());
    method41(v12.clone());
    method174(v12.clone());
    method15(v12.clone());
    let mut v15: Rc<str> = method70(v8.clone());
    method6(v12.clone(), v15.clone());
    method41(v12.clone());
    method175(v12.clone());
    method15(v12.clone());
    method6(v12.clone(), v9.clone());
    method41(v12.clone());
    method176(v12.clone());
    method15(v12.clone());
    method6(v12.clone(), v10.clone());
    method16(v12.clone());
    let mut v16: Rc<str> = v12.borrow().l0.clone();
    v16.clone()
}
fn method164(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: Rc<str>, mut v11: Rc<str>, mut v12: i32, mut v13: Rc<str>, mut v14: i32, mut v15: Rc<str>, mut v16: Rc<str>, mut v17: US4, mut v18: Rc<str>, mut v19: Rc<str>) -> Rc<str> {
    let mut v20: i64 = v0.borrow().l0.clone();
    let mut v21: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v21));
    let mut v23: Rc<str> = method11(v20);
    let mut v24: Rc<str> = Rc::<str>::from(format!("{}{}", v22, v23));
    let mut v25: Rc<str> = Rc::<str>::from(format!("{}{}", v24, v7));
    let mut v26: Rc<str> = Rc::<str>::from(format!("{}{}", v25, v21));
    let mut v27: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v8));
    let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v29: Rc<str> = Rc::<str>::from(format!("{}{}", v27, v28));
    let mut v30: Rc<str> = method165(v9.clone(), v10.clone(), v11.clone(), v12, v13.clone(), v14, v15.clone(), v16.clone(), v17.clone(), v18.clone(), v19.clone());
    let mut v31: Rc<str> = Rc::<str>::from(format!("{}{}", v29, v30));
    method8(v31.clone())
}
fn closure62() -> Rc<dyn Fn(u64) -> US26> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(u64) -> US26> = Rc::new(move |mut v0: u64| -> US26 {
        US26::US26_0(v0)
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method178() -> Rc<dyn Fn(u64) -> US26> {
    closure62()
}
fn closure63() -> Rc<dyn Fn(std::string::String) -> US26> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US26> = Rc::new(move |mut v0: std::string::String| -> US26 {
        US26::US26_1(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method179() -> Rc<dyn Fn(std::string::String) -> US26> {
    closure63()
}
fn method182(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("old_path"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method183(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("new_path"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method181(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: std::string::String) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method182(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v0.clone());
    method41(v4.clone());
    method183(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v1.clone());
    method41(v4.clone());
    method42(v4.clone());
    method15(v4.clone());
    let mut v6: std::string::String = format!("{:#?}", v2);
    let mut v8: Rc<str> = Rc::<str>::from(v6);
    method6(v4.clone(), v8.clone());
    method16(v4.clone());
    let mut v9: Rc<str> = v4.borrow().l0.clone();
    v9.clone()
}
fn method180(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: std::string::String) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.file_copy"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method181(v8.clone(), v9.clone(), v10.clone());
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
}
fn method186(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method185(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: u64) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method182(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v0.clone());
    method41(v4.clone());
    method183(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v1.clone());
    method41(v4.clone());
    method186(v4.clone());
    method15(v4.clone());
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}", v2));
    method6(v4.clone(), v5.clone());
    method16(v4.clone());
    let mut v6: Rc<str> = v4.borrow().l0.clone();
    v6.clone()
}
fn method184(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>, mut v10: u64) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("file_system.file_copy"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method185(v8.clone(), v9.clone(), v10);
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
}
fn method177(mut v0: Rc<str>, mut v1: Rc<str>) -> () {
    let mut v28: Result<u64, std::io::Error> = std::fs::copy(&*v1, &*v0);
    let mut v29: Rc<dyn Fn(std::io::Error) -> std::string::String> = method161();
    let mut v31: Result<u64, std::string::String> = v28.map_err(|x| v29(x));
    let mut v32: Rc<dyn Fn(u64) -> US26> = method178();
    let mut v33: Rc<dyn Fn(std::string::String) -> US26> = method179();
    let mut v34: US26 = match v31 { Ok(x) => v32(x), Err(e) => v33(e) };
    match &v34 {
        US26::US26_1(v102) => { // Error
            let mut v102: std::string::String = v102.clone();
            let mut v104: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
            { let _ = spiral_trace_hold(&v104); };
            let mut v106: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
            let (mut v107, mut v108, mut v109, mut v110, mut v111, mut v112): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v106) };
            let mut v113: US0 = v111.borrow().l0.clone();
            let mut v118: i32 = match &v113 {
                US0::US0_4 => { // Critical
                    50i32
                }
                US0::US0_1 => { // Debug
                    20i32
                }
                US0::US0_2 => { // Info
                    30i32
                }
                US0::US0_0 => { // Verbose
                    10i32
                }
                US0::US0_3 => { // Warning
                    40i32
                }
                _ => unreachable!(),
            };
            let mut v119: bool = v109.borrow().l0.clone();
            let mut v120: bool = v119 == false;
            let mut v122: bool = if v120 {
                false
            } else {
                let mut v121: bool = 40i32 >= v118;
                v121
            };
            let mut v123: bool = v122 == false;
            let mut v168: US2 = if v123 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v104); };
                let (mut v127, mut v128, mut v129, mut v130, mut v131, mut v132): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v106) };
                let mut v133: Rc<str> = method3(v127.clone(), v128.clone(), v129.clone(), v130.clone(), v131.clone(), v132.clone());
                let mut v134: Rc<str> = method37();
                let mut v135: Rc<str> = method180(v127.clone(), v128.clone(), v129.clone(), v130.clone(), v131.clone(), v132.clone(), v133.clone(), v134.clone(), v1.clone(), v0.clone(), v102.clone());
                { let _ = spiral_trace_hold(&v104); };
                let (mut v138, mut v139, mut v140, mut v141, mut v142, mut v143): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v106) };
                let mut v144: i64 = v138.borrow().l0.clone();
                let mut v145: i64 = v144 + 1i64;
                v138.borrow_mut().l0 = v145;
                let mut v146: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                let mut v147: bool = cfg!(target_arch = "wasm32");
                if v147 {
                    let mut v148: Rc<str> = v141.borrow().l0.clone();
                    let mut v149: bool = v148.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v157: Rc<str> = if v149 {
                        v135.clone()
                    } else {
                        let mut v150: bool = v135.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v150 {
                            let mut v151: Rc<str> = v141.borrow().l0.clone();
                            v151.clone()
                        } else {
                            let mut v152: Rc<str> = v141.borrow().l0.clone();
                            let mut v153: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v154: Rc<str> = Rc::<str>::from(format!("{}{}", v152, v153));
                            let mut v155: Rc<str> = Rc::<str>::from(format!("{}{}", v154, v135));
                            v155.clone()
                        }
                    };
                    let mut v159: i32 = ((v157.chars().count() + 14999) / 15000) as i32;
                    let mut v160: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v161: bool = v135 != v160 ;
                    let mut v163: bool = if v161 {
                        let mut v162: bool = v159 <= 1i32;
                        v162
                    } else {
                        false
                    };
                    if v163 {
                        v141.borrow_mut().l0 = v157.clone();
                        ()
                    } else {
                        v141.borrow_mut().l0 = v160.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v157); };
                        ()
                    }
                } else {
                    println!("{}", v135);
                    ()
                };
                let mut v166: Rc<dyn Fn(Rc<str>) -> ()> = v139.borrow().l0.clone();
                v166(v135.clone());
                US2::US2_0(v138.clone(), v139.clone(), v140.clone(), v141.clone(), v142.clone(), v143.clone())
            };
            ()
        }
        US26::US26_0(v35) => { // Ok
            let mut v35: u64 = v35.clone();
            let mut v37: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
            { let _ = spiral_trace_hold(&v37); };
            let mut v39: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
            let (mut v40, mut v41, mut v42, mut v43, mut v44, mut v45): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v39) };
            let mut v46: US0 = v44.borrow().l0.clone();
            let mut v51: i32 = match &v46 {
                US0::US0_4 => { // Critical
                    50i32
                }
                US0::US0_1 => { // Debug
                    20i32
                }
                US0::US0_2 => { // Info
                    30i32
                }
                US0::US0_0 => { // Verbose
                    10i32
                }
                US0::US0_3 => { // Warning
                    40i32
                }
                _ => unreachable!(),
            };
            let mut v52: bool = v42.borrow().l0.clone();
            let mut v53: bool = v52 == false;
            let mut v55: bool = if v53 {
                false
            } else {
                let mut v54: bool = 20i32 >= v51;
                v54
            };
            let mut v56: bool = v55 == false;
            let mut v101: US2 = if v56 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v37); };
                let (mut v60, mut v61, mut v62, mut v63, mut v64, mut v65): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v39) };
                let mut v66: Rc<str> = method3(v60.clone(), v61.clone(), v62.clone(), v63.clone(), v64.clone(), v65.clone());
                let mut v67: Rc<str> = method62();
                let mut v68: Rc<str> = method184(v60.clone(), v61.clone(), v62.clone(), v63.clone(), v64.clone(), v65.clone(), v66.clone(), v67.clone(), v1.clone(), v0.clone(), v35);
                { let _ = spiral_trace_hold(&v37); };
                let (mut v71, mut v72, mut v73, mut v74, mut v75, mut v76): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v39) };
                let mut v77: i64 = v71.borrow().l0.clone();
                let mut v78: i64 = v77 + 1i64;
                v71.borrow_mut().l0 = v78;
                let mut v79: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                let mut v80: bool = cfg!(target_arch = "wasm32");
                if v80 {
                    let mut v81: Rc<str> = v74.borrow().l0.clone();
                    let mut v82: bool = v81.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v90: Rc<str> = if v82 {
                        v68.clone()
                    } else {
                        let mut v83: bool = v68.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v83 {
                            let mut v84: Rc<str> = v74.borrow().l0.clone();
                            v84.clone()
                        } else {
                            let mut v85: Rc<str> = v74.borrow().l0.clone();
                            let mut v86: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v87: Rc<str> = Rc::<str>::from(format!("{}{}", v85, v86));
                            let mut v88: Rc<str> = Rc::<str>::from(format!("{}{}", v87, v68));
                            v88.clone()
                        }
                    };
                    let mut v92: i32 = ((v90.chars().count() + 14999) / 15000) as i32;
                    let mut v93: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v94: bool = v68 != v93 ;
                    let mut v96: bool = if v94 {
                        let mut v95: bool = v92 <= 1i32;
                        v95
                    } else {
                        false
                    };
                    if v96 {
                        v74.borrow_mut().l0 = v90.clone();
                        ()
                    } else {
                        v74.borrow_mut().l0 = v93.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v90); };
                        ()
                    }
                } else {
                    println!("{}", v68);
                    ()
                };
                let mut v99: Rc<dyn Fn(Rc<str>) -> ()> = v72.borrow().l0.clone();
                v99(v68.clone());
                US2::US2_0(v71.clone(), v72.clone(), v73.clone(), v74.clone(), v75.clone(), v76.clone())
            };
            ()
        }
        _ => unreachable!(),
    }
}
fn method188(mut v0: Vec<u8>) -> Vec<u8> {
    v0.clone()
}
fn method189(mut v0: i32, mut v1: Rc<RefCell<Mut8>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn method190(mut v0: Rc<str>) -> Rc<str> {
    v0.clone()
}
fn closure66(mut v0: Rc<str>) -> Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()> {
    Rc::new(move |mut v1: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>| -> () {
        let mut v3: std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>> = v1;
        let mut v5: Result<std::sync::MutexGuard<std::process::ChildStdin>, std::sync::PoisonError<std::sync::MutexGuard<std::process::ChildStdin>>> = v3.lock();
        let mut v7: std::sync::MutexGuard<std::process::ChildStdin> = v5.unwrap();
        let mut v8: Rc<str> = method190(v0.clone());
        let mut v10: &[u8] = v8.as_bytes();
        let mut v12: bool = true; std::io::Write::write_all(&mut *v7, v10).unwrap();
        ()
    })
}
fn method191(mut v0: i32, mut v1: Rc<RefCell<Mut9>>) -> bool {
    let mut v2: i32 = v1.borrow().l0.clone();
    let mut v3: bool = v2 < v0;
    v3
}
fn method194(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("result_len"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method195(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_path"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method193(mut v0: i32, mut v1: i32, mut v2: Rc<str>) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method154(v4.clone());
    method15(v4.clone());
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v4.clone(), v5.clone());
    method41(v4.clone());
    method194(v4.clone());
    method15(v4.clone());
    let mut v6: Rc<str> = Rc::<str>::from(format!("{}", v1));
    method6(v4.clone(), v6.clone());
    method41(v4.clone());
    method195(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v2.clone());
    method16(v4.clone());
    let mut v7: Rc<str> = v4.borrow().l0.clone();
    v7.clone()
}
fn method192(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: i32, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.hangul"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method193(v8, v9, v10.clone());
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
}
fn method187(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool, mut v3: Rc<str>, mut v4: Rc<str>) -> US27 {
    let mut v31: Result<Vec<u8>, std::io::Error> = std::fs::read(&*v4);
    let mut v33: Vec<u8> = v31.unwrap();
    let mut v34: Vec<u8> = method188(v33.clone());
    let mut v36: Result<std::string::String, std::string::FromUtf8Error> = std::string::String::from_utf8(v34);
    let mut v38: std::string::String = v36.unwrap();
    let mut v40: Rc<str> = Rc::<str>::from(String::as_str(&v38));
    let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
    let mut v44: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v40.split(&*v43).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
    let mut v45: i32 = (v44.clone().borrow().len() as i32);
    let mut v46: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v45 as usize]));
    let mut v47: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: 0i32 }));
    while method60(v45, v47.clone()) {
        let mut v49: i32 = v47.borrow().l0.clone();
        let mut v50: Rc<str> = v44.clone().borrow()[v49 as usize].clone();
        let mut v51: i32 = (v50.clone().len() as i32);
        let mut v52: i32 = 0i32;
        let mut v53: i32 = method9(v50.clone(), v51, v52);
        let mut v54: i32 = v51 - 1i32;
        let mut v55: Rc<str> = string_slice(&v50.clone(), v53 as i64, v54 as i64);
        let mut v56: i32 = (v55.clone().len() as i32);
        let mut v57: i32 = method151(v55.clone(), v56);
        let mut v58: Rc<str> = string_slice(&v55.clone(), 0i32 as i64, v57 as i64);
        v46.clone().borrow_mut()[v49 as usize] = v58.clone();
        let mut v59: i32 = v49 + 1i32;
        v47.borrow_mut().l0 = v59;
        ()
    };
    let mut v60: i32 = (v46.clone().borrow().len() as i32);
    let mut v61: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v60 as usize]));
    let mut v62: Rc<RefCell<Mut8>> = Rc::new(RefCell::new(Mut8 { l0: 0i32, l1: 0i32 }));
    while method189(v60, v62.clone()) {
        let mut v64: i32 = v62.borrow().l0.clone();
        let mut v65: i32 = v62.borrow().l1.clone();
        let mut v66: Rc<str> = v46.clone().borrow()[v64 as usize].clone();
        let mut v67: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let mut v68: bool = v66 != v67 ;
        let mut v70: i32 = if v68 {
            v61.clone().borrow_mut()[v65 as usize] = v66.clone();
            let mut v69: i32 = v65 + 1i32;
            v69
        } else {
            v65
        };
        let mut v71: i32 = v64 + 1i32;
        v62.borrow_mut().l0 = v71;
        v62.borrow_mut().l1 = v70;
        ()
    };
    let mut v72: i32 = v62.borrow().l1.clone();
    let mut v73: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(vec![<Rc<str>>::default(); v72 as usize]));
    let mut v74: Rc<RefCell<Mut7>> = Rc::new(RefCell::new(Mut7 { l0: 0i32 }));
    while method60(v72, v74.clone()) {
        let mut v76: i32 = v74.borrow().l0.clone();
        let mut v77: Rc<str> = v61.clone().borrow()[v76 as usize].clone();
        v73.clone().borrow_mut()[v76 as usize] = v77.clone();
        let mut v78: i32 = v76 + 1i32;
        v74.borrow_mut().l0 = v78;
        ()
    };
    let mut v79: Rc<Vec<Rc<str>>> = Rc::new(v73.borrow().clone());
    let mut v80: Rc<str> = Rc::<str>::from(v79.iter().map(|x| x.to_string()).collect::<Vec<_>>().join(&*v43));
    let mut v81: Rc<str> = Rc::<str>::from(format!("{}

", v80));
    let mut v84: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" the "); } LIT.with(|lit| lit.clone()) };
    let mut v85: bool = v81.contains(&*v84);
    let mut v90: bool = if v85 {
        let mut v88: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" and "); } LIT.with(|lit| lit.clone()) };
        let mut v89: bool = v81.contains(&*v88);
        v89
    } else {
        false
    };
    let mut v92: Rc<str> = if v90 {
        let mut v91: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("eng"); } LIT.with(|lit| lit.clone()) };
        v91.clone()
    } else {
        v1.clone()
    };
    let mut v93: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
    let mut v94: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
    let mut v95: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
    let mut v96: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
    let mut v97: Option<Rc<str>> = None;
    let mut v112: bool = cfg!(windows);
    let mut v115: Rc<str> = if v112 {
        let mut v113: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(".exe"); } LIT.with(|lit| lit.clone()) };
        v113.clone()
    } else {
        let mut v114: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        v114.clone()
    };
    let mut v116: Rc<str> = Rc::<str>::from(format!("../alphabet/deps/hangulize/cmd/hangulize/hangulize{}", v115));
    let mut v117: Rc<str> = method29(v0.clone(), v116.clone());
    let mut v118: Rc<str> = Rc::<str>::from(format!("{} {}", v117, v92));
    let mut v121: Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()> = closure66(v81.clone());
    let mut v122: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = Some(v121.clone());
    let mut v123: bool = true;
    let mut v124: bool = true;
    let (mut v125, mut v126): (i32, Rc<str>) = method78(v118.clone(), v93.clone(), v94.clone(), v95.clone(), v122.clone(), v123, v97.clone(), v124);
    let mut v127: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v126.split(&*v43).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
    let mut v128: i32 = (v127.clone().borrow().len() as i32);
    let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v130: Rc<RefCell<Mut9>> = Rc::new(RefCell::new(Mut9 { l0: 0i32, l1: v129.clone(), l2: 0i32, l3: 0i32 }));
    while method191(v60, v130.clone()) {
        let mut v132: i32 = v130.borrow().l0.clone();
        let (mut v133, mut v134, mut v135): (Rc<str>, i32, i32) = (v130.borrow().l1.clone(), v130.borrow().l2.clone(), v130.borrow().l3.clone());
        let mut v136: Rc<str> = v46.clone().borrow()[v132 as usize].clone();
        let mut v137: bool = v136.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
        let (mut v159, mut v160, mut v161): (Rc<str>, i32, i32) = if v137 {
            let mut v138: Rc<str> = Rc::<str>::from(format!("{}{}", v133, v43));
            let mut v139: i32 = v134 + 1i32;
            let mut v140: i32 = v135 + 1i32;
            (v138.clone(), v139, v140)
        } else {
            let mut v141: i32 = v134 - v135;
            let mut v142: bool = v141 >= v128;
            let mut v157: Rc<str> = if v142 {
                v133.clone()
            } else {
                let mut v143: Rc<str> = v127.clone().borrow()[v141 as usize].clone();
                let mut v146: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("://"); } LIT.with(|lit| lit.clone()) };
                let mut v147: bool = v143.contains(&*v146);
                let mut v148: Rc<str> = if v147 {
                    v136.clone()
                } else {
                    v143.clone()
                };
                let mut v149: Rc<str> = Rc::<str>::from(format!("{}{}", v133, v148));
                let mut v152: Rc<str> = if v2 {
                    v149.clone()
                } else {
                    let mut v150: Rc<str> = Rc::<str>::from(format!("{}{}", v149, v43));
                    let mut v151: Rc<str> = Rc::<str>::from(format!("{}{}", v150, v136));
                    v151.clone()
                };
                let mut v153: i32 = v128 - 1i32;
                let mut v154: bool = v141 == v153;
                if v154 {
                    v152.clone()
                } else {
                    let mut v155: Rc<str> = Rc::<str>::from(format!("{}{}", v152, v43));
                    v155.clone()
                }
            };
            let mut v158: i32 = v134 + 1i32;
            (v157.clone(), v158, v135)
        };
        let mut v162: i32 = v132 + 1i32;
        v130.borrow_mut().l0 = v162;
        v130.borrow_mut().l1 = v159.clone();
        v130.borrow_mut().l2 = v160;
        v130.borrow_mut().l3 = v161;
        ()
    };
    let (mut v163, mut v164, mut v165): (Rc<str>, i32, i32) = (v130.borrow().l1.clone(), v130.borrow().l2.clone(), v130.borrow().l3.clone());
    std::fs::write(&*v3, &*v163).unwrap();
    let mut v173: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
    { let _ = spiral_trace_hold(&v173); };
    let mut v175: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
    let (mut v176, mut v177, mut v178, mut v179, mut v180, mut v181): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v175) };
    let mut v182: US0 = v180.borrow().l0.clone();
    let mut v187: i32 = match &v182 {
        US0::US0_4 => { // Critical
            50i32
        }
        US0::US0_1 => { // Debug
            20i32
        }
        US0::US0_2 => { // Info
            30i32
        }
        US0::US0_0 => { // Verbose
            10i32
        }
        US0::US0_3 => { // Warning
            40i32
        }
        _ => unreachable!(),
    };
    let mut v188: bool = v178.borrow().l0.clone();
    let mut v189: bool = v188 == false;
    let mut v191: bool = if v189 {
        false
    } else {
        let mut v190: bool = 30i32 >= v187;
        v190
    };
    let mut v192: bool = v191 == false;
    let mut v236: US2 = if v192 {
        US2::US2_1
    } else {
        { let _ = spiral_trace_hold(&v173); };
        let (mut v196, mut v197, mut v198, mut v199, mut v200, mut v201): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v175) };
        let mut v202: Rc<str> = method3(v196.clone(), v197.clone(), v198.clone(), v199.clone(), v200.clone(), v201.clone());
        let mut v203: Rc<str> = method4();
        let mut v204: i32 = (v163.clone().len() as i32);
        let mut v205: Rc<str> = method192(v196.clone(), v197.clone(), v198.clone(), v199.clone(), v200.clone(), v201.clone(), v202.clone(), v203.clone(), v125, v204, v3.clone());
        { let _ = spiral_trace_hold(&v173); };
        let (mut v208, mut v209, mut v210, mut v211, mut v212, mut v213): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v175) };
        let mut v214: i64 = v208.borrow().l0.clone();
        let mut v215: i64 = v214 + 1i64;
        v208.borrow_mut().l0 = v215;
        let mut v216: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let mut v217: bool = cfg!(target_arch = "wasm32");
        if v217 {
            let mut v218: Rc<str> = v211.borrow().l0.clone();
            let mut v219: bool = v218.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v226: Rc<str> = if v219 {
                v205.clone()
            } else {
                let mut v220: bool = v205.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v220 {
                    let mut v221: Rc<str> = v211.borrow().l0.clone();
                    v221.clone()
                } else {
                    let mut v222: Rc<str> = v211.borrow().l0.clone();
                    let mut v223: Rc<str> = Rc::<str>::from(format!("{}{}", v222, v43));
                    let mut v224: Rc<str> = Rc::<str>::from(format!("{}{}", v223, v205));
                    v224.clone()
                }
            };
            let mut v228: i32 = ((v226.chars().count() + 14999) / 15000) as i32;
            let mut v229: bool = v205 != v129 ;
            let mut v231: bool = if v229 {
                let mut v230: bool = v228 <= 1i32;
                v230
            } else {
                false
            };
            if v231 {
                v211.borrow_mut().l0 = v226.clone();
                ()
            } else {
                v211.borrow_mut().l0 = v129.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v226); };
                ()
            }
        } else {
            println!("{}", v205);
            ()
        };
        let mut v234: Rc<dyn Fn(Rc<str>) -> ()> = v209.borrow().l0.clone();
        v234(v205.clone());
        US2::US2_0(v208.clone(), v209.clone(), v210.clone(), v211.clone(), v212.clone(), v213.clone())
    };
    US27::US27_0(v125, v163.clone())
}
fn method196(mut v0: Rc<str>, mut v1: Rc<str>) -> (Rc<str>, Rc<str>) {
    (v0.clone(), v1.clone())
}
fn method198(mut v0: i32, mut v1: Rc<str>) -> Rc<str> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v2.clone() }));
    method13(v3.clone());
    method154(v3.clone());
    method15(v3.clone());
    let mut v4: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v3.clone(), v4.clone());
    method41(v3.clone());
    method186(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v1.clone());
    method16(v3.clone());
    let mut v5: Rc<str> = v3.borrow().l0.clone();
    v5.clone()
}
fn method197(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = method11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.files_fn / error"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = method198(v8, v9.clone());
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    method8(v22.clone())
}
fn closure65(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: bool, mut v5: Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24> {
    Rc::new(move |mut v6: Rc<str>| -> US24 {
        let (mut v7, mut v8): (Rc<str>, Rc<str>) = method156(v6.clone(), v5.clone(), v0.clone());
        let mut v9: bool = method35(v7.clone());
        let mut v10: bool = v9 == false;
        let mut v13: bool = if v10 {
            true
        } else {
            let mut v11: bool = method35(v8.clone());
            let mut v12: bool = v11 == false;
            v12
        };
        let mut v167: bool = if v13 {
            false
        } else {
            let mut v14: Rc<str> = method43(v7.clone());
            let mut v16: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v14);
            let mut v18: std::fs::File = v16.unwrap();
            let mut v20: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v18);
            let mut v22: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v20);
            let mut v24: bool = true; let mut v22 = v22;
            let mut v26: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
            let mut v28: sha2::Sha256 = result;
            let mut v30: bool = true; let mut v28 = v28;
            let mut v31: usize = ((0i32) as usize);
            let mut v33: _ = [0u8; 1024i32 as usize];
            let mut v35: bool = true; loop { // rust.loop 1;
            let mut v37: bool = true; let mut v33 = v33;
            let mut v39: Result<usize, std::io::Error> = std::io::Read::read(&mut v22, &mut v33);
            let mut v41: usize = v39.unwrap();
            let mut v42: bool = v41 == v31 ;
            let mut v45: bool = if v42 {
                let mut v44: bool = true; break ();
                true
            } else {
                false
            };
            let mut v46: usize = ((v41) as usize);
            let mut v47: usize = (v46.clone());
            let mut v49: usize = v33.len();
            let mut v50: bool = v47 == v49 ;
            let mut v55: &_ = if v50 {
                let mut v52: &_ = &v33[v31..];
                v52.clone()
            } else {
                let mut v54: &_ = &v33[v31..v46];
                v54.clone()
            };
            let mut v57: bool = true; sha2::Digest::update(&mut v28, v55);
            let mut v59: bool = true; } // rust.loop 3;
            let mut v61: &[u8] = &sha2::Digest::finalize(v28);
            let mut v63: Vec<u8> = v61.iter().map(|x| *x).collect::<Vec<_>>();
            let mut v65: Rc<dyn Fn((u8)) -> Rc<str>> = closure58();
            let mut v66: Vec<Rc<str>> = v63.iter().map(|x| v65(x.clone())).collect::<Vec<_>>();
            let mut v67: Vec<Rc<str>> = method157(v66.clone());
            let mut v68: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v67));
            let mut v69: Rc<Vec<Rc<str>>> = Rc::new((v68).borrow().clone());
            let mut v70: i32 = (v69).len() as i32;
            let mut v71: i32 = v70 - 1i32;
            let mut v72: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
            let mut v73: Rc<UH0> = method158(v69.clone(), v71, v72.clone());
            let mut v74: Rc<str> = method159();
            let mut v75: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let (mut v76, mut v77): (Rc<str>, Rc<str>) = method160(v74.clone(), v73.clone(), v75.clone());
            let mut v78: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v76);
            let mut v79: Rc<dyn Fn(std::io::Error) -> std::string::String> = method161();
            let mut v81: Result<Rc<str>, std::string::String> = v78.map_err(|x| v79(x));
            let mut v82: Rc<dyn Fn(Rc<str>) -> US25> = method162();
            let mut v83: Rc<dyn Fn(std::string::String) -> US25> = method163();
            let mut v84: US25 = match v81 { Ok(x) => v82(x), Err(e) => v83(e) };
            let mut v90: Rc<str> = match &v84 {
                US25::US25_1(v86) => { // Error
                    let mut v86: std::string::String = v86.clone();
                    let mut v87: Rc<str> = Rc::<str>::from(format!("resultm.get / Error x: {:?}", v86));
                    std::panic::panic_any::<std::string::String>(format!("{}", v87.clone()))
                }
                US25::US25_0(v85) => { // Ok
                    let mut v85: Rc<str> = v85.clone();
                    v85.clone()
                }
                _ => unreachable!(),
            };
            let mut v91: Rc<str> = method43(v8.clone());
            let mut v93: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v91);
            let mut v95: std::fs::File = v93.unwrap();
            let mut v97: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v95);
            let mut v99: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v97);
            let mut v101: bool = true; let mut v99 = v99;
            let mut v103: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
            let mut v105: sha2::Sha256 = result;
            let mut v107: bool = true; let mut v105 = v105;
            let mut v108: usize = ((0i32) as usize);
            let mut v110: _ = [0u8; 1024i32 as usize];
            let mut v112: bool = true; loop { // rust.loop 1;
            let mut v114: bool = true; let mut v110 = v110;
            let mut v116: Result<usize, std::io::Error> = std::io::Read::read(&mut v99, &mut v110);
            let mut v118: usize = v116.unwrap();
            let mut v119: bool = v118 == v108 ;
            let mut v122: bool = if v119 {
                let mut v121: bool = true; break ();
                true
            } else {
                false
            };
            let mut v123: usize = ((v118) as usize);
            let mut v124: usize = (v123.clone());
            let mut v126: usize = v110.len();
            let mut v127: bool = v124 == v126 ;
            let mut v132: &_ = if v127 {
                let mut v129: &_ = &v110[v108..];
                v129.clone()
            } else {
                let mut v131: &_ = &v110[v108..v123];
                v131.clone()
            };
            let mut v134: bool = true; sha2::Digest::update(&mut v105, v132);
            let mut v136: bool = true; } // rust.loop 3;
            let mut v138: &[u8] = &sha2::Digest::finalize(v105);
            let mut v140: Vec<u8> = v138.iter().map(|x| *x).collect::<Vec<_>>();
            let mut v142: Vec<Rc<str>> = v140.iter().map(|x| v65(x.clone())).collect::<Vec<_>>();
            let mut v143: Vec<Rc<str>> = method157(v142.clone());
            let mut v144: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v143));
            let mut v145: Rc<Vec<Rc<str>>> = Rc::new((v144).borrow().clone());
            let mut v146: i32 = (v145).len() as i32;
            let mut v147: i32 = v146 - 1i32;
            let mut v148: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
            let mut v149: Rc<UH0> = method158(v145.clone(), v147, v148.clone());
            let mut v150: Rc<str> = method159();
            let (mut v151, mut v152): (Rc<str>, Rc<str>) = method160(v150.clone(), v149.clone(), v75.clone());
            let mut v153: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v151);
            let mut v154: Rc<dyn Fn(std::io::Error) -> std::string::String> = method161();
            let mut v156: Result<Rc<str>, std::string::String> = v153.map_err(|x| v154(x));
            let mut v157: Rc<dyn Fn(Rc<str>) -> US25> = method162();
            let mut v158: Rc<dyn Fn(std::string::String) -> US25> = method163();
            let mut v159: US25 = match v156 { Ok(x) => v157(x), Err(e) => v158(e) };
            let mut v165: Rc<str> = match &v159 {
                US25::US25_1(v161) => { // Error
                    let mut v161: std::string::String = v161.clone();
                    let mut v162: Rc<str> = Rc::<str>::from(format!("resultm.get / Error x: {:?}", v161));
                    std::panic::panic_any::<std::string::String>(format!("{}", v162.clone()))
                }
                US25::US25_0(v160) => { // Ok
                    let mut v160: Rc<str> = v160.clone();
                    v160.clone()
                }
                _ => unreachable!(),
            };
            let mut v166: bool = v90.clone() == v165.clone();
            v166
        };
        if v167 {
            US24::US24_1
        } else {
            let mut v169: US27 = method187(v2.clone(), v3.clone(), v4, v7.clone(), v5.clone());
            match &v169 {
                US27::US27_1(v256, v257) => { // Error
                    let mut v256: i32 = v256.clone();
                    let mut v257: Rc<str> = v257.clone();
                    let (mut v258, mut v259): (Rc<str>, Rc<str>) = method196(v7.clone(), v257.clone());
                    let mut v260: (Rc<str>, Rc<str>) = (v258, v259);
                    let mut v261: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v260);
                    US24::US24_0(v261.clone())
                }
                US27::US27_0(v170, v171) => { // Ok
                    let mut v170: i32 = v170.clone();
                    let mut v171: Rc<str> = v171.clone();
                    let mut v173: bool = v170 != 0i32 ;
                    if v173 {
                        let mut v178: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                        { let _ = spiral_trace_hold(&v178); };
                        let mut v180: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v181, mut v182, mut v183, mut v184, mut v185, mut v186): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v180) };
                        let mut v187: US0 = v185.borrow().l0.clone();
                        let mut v192: i32 = match &v187 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
                        };
                        let mut v193: bool = v183.borrow().l0.clone();
                        let mut v194: bool = v193 == false;
                        let mut v196: bool = if v194 {
                            false
                        } else {
                            let mut v195: bool = 30i32 >= v192;
                            v195
                        };
                        let mut v197: bool = v196 == false;
                        let mut v242: US2 = if v197 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v178); };
                            let (mut v201, mut v202, mut v203, mut v204, mut v205, mut v206): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v180) };
                            let mut v207: Rc<str> = method3(v201.clone(), v202.clone(), v203.clone(), v204.clone(), v205.clone(), v206.clone());
                            let mut v208: Rc<str> = method4();
                            let mut v209: Rc<str> = method197(v201.clone(), v202.clone(), v203.clone(), v204.clone(), v205.clone(), v206.clone(), v207.clone(), v208.clone(), v170, v171.clone());
                            { let _ = spiral_trace_hold(&v178); };
                            let (mut v212, mut v213, mut v214, mut v215, mut v216, mut v217): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v180) };
                            let mut v218: i64 = v212.borrow().l0.clone();
                            let mut v219: i64 = v218 + 1i64;
                            v212.borrow_mut().l0 = v219;
                            let mut v220: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let mut v221: bool = cfg!(target_arch = "wasm32");
                            if v221 {
                                let mut v222: Rc<str> = v215.borrow().l0.clone();
                                let mut v223: bool = v222.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v231: Rc<str> = if v223 {
                                    v209.clone()
                                } else {
                                    let mut v224: bool = v209.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v224 {
                                        let mut v225: Rc<str> = v215.borrow().l0.clone();
                                        v225.clone()
                                    } else {
                                        let mut v226: Rc<str> = v215.borrow().l0.clone();
                                        let mut v227: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v228: Rc<str> = Rc::<str>::from(format!("{}{}", v226, v227));
                                        let mut v229: Rc<str> = Rc::<str>::from(format!("{}{}", v228, v209));
                                        v229.clone()
                                    }
                                };
                                let mut v233: i32 = ((v231.chars().count() + 14999) / 15000) as i32;
                                let mut v234: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v235: bool = v209 != v234 ;
                                let mut v237: bool = if v235 {
                                    let mut v236: bool = v233 <= 1i32;
                                    v236
                                } else {
                                    false
                                };
                                if v237 {
                                    v215.borrow_mut().l0 = v231.clone();
                                    ()
                                } else {
                                    v215.borrow_mut().l0 = v234.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v231); };
                                    ()
                                }
                            } else {
                                println!("{}", v209);
                                ()
                            };
                            let mut v240: Rc<dyn Fn(Rc<str>) -> ()> = v213.borrow().l0.clone();
                            v240(v209.clone());
                            US2::US2_0(v212.clone(), v213.clone(), v214.clone(), v215.clone(), v216.clone(), v217.clone())
                        };
                        let (mut v244, mut v245): (Rc<str>, Rc<str>) = method196(v7.clone(), v171.clone());
                        let mut v246: (Rc<str>, Rc<str>) = (v244, v245);
                        let mut v248: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v246);
                        US24::US24_0(v248.clone())
                    } else {
                        let mut v250: bool = method35(v7.clone());
                        if v250 {
                            method177(v8.clone(), v7.clone())
                        } else {
                            let mut v251: Rc<str> = Rc::<str>::from(format!("documents.files_fn / {} should exist", v7));
                            std::panic::panic_any::<std::string::String>(format!("{}", v251.clone()))
                        };
                        let mut v253: Result<Rc<str>, (Rc<str>, Rc<str>)> = Ok::<Rc<str>, (Rc<str>, Rc<str>)>(v7);
                        US24::US24_0(v253.clone())
                    }
                }
                _ => unreachable!(),
            }
        }
    })
}
fn closure64(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: bool) -> Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> {
    Rc::new(move |mut v5: Rc<str>| -> Rc<dyn Fn(Rc<str>) -> US24> {
        closure65(v0.clone(), v1.clone(), v2.clone(), v3.clone(), v4, v5.clone())
    })
}
fn method201(mut v0: i32, mut v1: Rc<str>, mut v2: Rc<str>) -> Rc<str> {
    let mut v3: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v4: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v3.clone() }));
    method13(v4.clone());
    method154(v4.clone());
    method15(v4.clone());
    let mut v5: Rc<str> = Rc::<str>::from(format!("{}", v0));
    method6(v4.clone(), v5.clone());
    method41(v4.clone());
    method195(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v1.clone());
    method41(v4.clone());
    method186(v4.clone());
    method15(v4.clone());
    method6(v4.clone(), v2.clone());
    method16(v4.clone());
    let mut v6: Rc<str> = v4.borrow().l0.clone();
    v6.clone()
}
fn method200(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.crowbook / attempt error"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method201(v8, v9.clone(), v10.clone());
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
}
fn method202(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: i32, mut v9: Rc<str>, mut v10: Rc<str>) -> Rc<str> {
    let mut v11: i64 = v0.borrow().l0.clone();
    let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v12));
    let mut v14: Rc<str> = method11(v11);
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v14));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v7));
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v12));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.crowbook / result contains ERROR"); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    let mut v22: Rc<str> = method201(v8, v9.clone(), v10.clone());
    let mut v23: Rc<str> = Rc::<str>::from(format!("{}{}", v21, v22));
    method8(v23.clone())
}
fn method199(mut v0: bool, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: Rc<str>) -> US27 {
    let mut v5: bool = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("html"); } LIT.with(|lit| lit.clone()) } == v4.clone();
    let mut v61: Rc<str> = if v5 {
        let mut v6: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set"); } LIT.with(|lit| lit.clone()) };
        let mut v7: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" html.css.add \\\"'"); } LIT.with(|lit| lit.clone()) };
        let mut v8: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"'"); } LIT.with(|lit| lit.clone()) };
        let mut v9: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" body { color: #e8e6e3; background-color: #202324; }"); } LIT.with(|lit| lit.clone()) };
        let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"' body { color: #e8e6e3; background-color: #202324; }"); } LIT.with(|lit| lit.clone()) };
        let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" a { color: #989693; }"); } LIT.with(|lit| lit.clone()) };
        let mut v12: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; }"); } LIT.with(|lit| lit.clone()) };
        let mut v13: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" pre { background-color: #1b1b1b; padding: 10px; }"); } LIT.with(|lit| lit.clone()) };
        let mut v14: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; }"); } LIT.with(|lit| lit.clone()) };
        let mut v15: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" '\\\""); } LIT.with(|lit| lit.clone()) };
        let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } '\\\""); } LIT.with(|lit| lit.clone()) };
        let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.num_depth 6"); } LIT.with(|lit| lit.clone()) };
        let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
        let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
        let mut v20: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set html.css.add \\\"' body { color: #e8e6e3; background-color: #202324; } a { color: #989693; } pre { background-color: #1b1b1b; padding: 10px; } '\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
        v20.clone()
    } else {
        let mut v21: bool = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("pdf"); } LIT.with(|lit| lit.clone()) } == v4.clone();
        if v21 {
            let mut v22: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set"); } LIT.with(|lit| lit.clone()) };
            let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.paper.size a4paper"); } LIT.with(|lit| lit.clone()) };
            let mut v24: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set tex.paper.size a4paper"); } LIT.with(|lit| lit.clone()) };
            let mut v25: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\pagenumbering{gobble}\""); } LIT.with(|lit| lit.clone()) };
            let mut v26: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set tex.paper.size a4paper tex.template.add \"\\pagenumbering{gobble}\""); } LIT.with(|lit| lit.clone()) };
            let mut v27: bool = v0 == false;
            let mut v36: Rc<str> = if v27 {
                let mut v28: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v28.clone()
            } else {
                let mut v29: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\usepackage{polyglossia}\""); } LIT.with(|lit| lit.clone()) };
                let mut v30: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\setmainlanguage{korean}\""); } LIT.with(|lit| lit.clone()) };
                let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\""); } LIT.with(|lit| lit.clone()) };
                let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\setmainfont{NanumGothicCoding}\""); } LIT.with(|lit| lit.clone()) };
                let mut v33: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\""); } LIT.with(|lit| lit.clone()) };
                let mut v34: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.font.size 13"); } LIT.with(|lit| lit.clone()) };
                let mut v35: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" tex.template.add \"\\usepackage{polyglossia}\" tex.template.add \"\\setmainlanguage{korean}\" tex.template.add \"\\setmainfont{NanumGothicCoding}\" tex.font.size 13"); } LIT.with(|lit| lit.clone()) };
                v35.clone()
            };
            let mut v37: Rc<str> = Rc::<str>::from(format!("{}{}", v26, v36));
            let mut v38: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.num_depth 6"); } LIT.with(|lit| lit.clone()) };
            let mut v39: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
            let mut v40: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
            let mut v41: Rc<str> = Rc::<str>::from(format!("{}{}", v37, v40));
            v41.clone()
        } else {
            let mut v42: bool = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epub"); } LIT.with(|lit| lit.clone()) } == v4.clone();
            if v42 {
                let mut v43: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set"); } LIT.with(|lit| lit.clone()) };
                let mut v44: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" epub.version 3"); } LIT.with(|lit| lit.clone()) };
                let mut v45: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3"); } LIT.with(|lit| lit.clone()) };
                let mut v46: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" html.css.add \\\"' "); } LIT.with(|lit| lit.clone()) };
                let mut v47: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3 html.css.add \\\"' "); } LIT.with(|lit| lit.clone()) };
                let mut v48: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" body { color: #e8e6e3; background-color: #202324; } "); } LIT.with(|lit| lit.clone()) };
                let mut v49: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3 html.css.add \\\"'  body { color: #e8e6e3; background-color: #202324; } "); } LIT.with(|lit| lit.clone()) };
                let mut v50: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" a { color: #989693; } "); } LIT.with(|lit| lit.clone()) };
                let mut v51: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3 html.css.add \\\"'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; } "); } LIT.with(|lit| lit.clone()) };
                let mut v52: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" '\\\""); } LIT.with(|lit| lit.clone()) };
                let mut v53: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3 html.css.add \\\"'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  '\\\""); } LIT.with(|lit| lit.clone()) };
                let mut v54: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.num_depth 6"); } LIT.with(|lit| lit.clone()) };
                let mut v55: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
                let mut v56: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
                let mut v57: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("--set epub.version 3 html.css.add \\\"'  body { color: #e8e6e3; background-color: #202324; }  a { color: #989693; }  '\\\" rendering.num_depth 6 rendering.highlight.theme \\\"Solarized (dark)\\\""); } LIT.with(|lit| lit.clone()) };
                v57.clone()
            } else {
                let mut v58: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                v58.clone()
            }
        }
    };
    let mut v62: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
    let mut v63: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
    let mut v64: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
    let mut v65: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
    let mut v66: Option<Rc<str>> = None;
    let mut v67: Rc<str> = Rc::<str>::from(format!("crowbook --verbose --to {}", v4));
    let mut v68: Rc<str> = Rc::<str>::from(format!(" --single \"{}\" --output \"{}\" {}", v2, v1, v61));
    let mut v69: Rc<str> = Rc::<str>::from(format!("{}{}", v67, v68));
    let mut v70: Option<Rc<str>> = Some(v3.clone());
    let mut v71: bool = true;
    let mut v72: bool = true;
    let (mut v73, mut v74): (i32, Rc<str>) = method78(v69.clone(), v62.clone(), v63.clone(), v64.clone(), v65.clone(), v71, v70.clone(), v72);
    let mut v75: bool = v73 == 0i32;
    let (mut v158, mut v159): (i32, Rc<str>) = if v75 {
        (v73, v74.clone())
    } else {
        let mut v80: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
        { let _ = spiral_trace_hold(&v80); };
        let mut v82: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v83, mut v84, mut v85, mut v86, mut v87, mut v88): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v82) };
        let mut v89: US0 = v87.borrow().l0.clone();
        let mut v94: i32 = match &v89 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
            _ => unreachable!(),
        };
        let mut v95: bool = v85.borrow().l0.clone();
        let mut v96: bool = v95 == false;
        let mut v98: bool = if v96 {
            false
        } else {
            let mut v97: bool = 40i32 >= v94;
            v97
        };
        let mut v99: bool = v98 == false;
        let mut v144: US2 = if v99 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v80); };
            let (mut v103, mut v104, mut v105, mut v106, mut v107, mut v108): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v82) };
            let mut v109: Rc<str> = method3(v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone());
            let mut v110: Rc<str> = method37();
            let mut v111: Rc<str> = method200(v103.clone(), v104.clone(), v105.clone(), v106.clone(), v107.clone(), v108.clone(), v109.clone(), v110.clone(), v73, v1.clone(), v74.clone());
            { let _ = spiral_trace_hold(&v80); };
            let (mut v114, mut v115, mut v116, mut v117, mut v118, mut v119): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v82) };
            let mut v120: i64 = v114.borrow().l0.clone();
            let mut v121: i64 = v120 + 1i64;
            v114.borrow_mut().l0 = v121;
            let mut v122: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
            let mut v123: bool = cfg!(target_arch = "wasm32");
            if v123 {
                let mut v124: Rc<str> = v117.borrow().l0.clone();
                let mut v125: bool = v124.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v133: Rc<str> = if v125 {
                    v111.clone()
                } else {
                    let mut v126: bool = v111.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v126 {
                        let mut v127: Rc<str> = v117.borrow().l0.clone();
                        v127.clone()
                    } else {
                        let mut v128: Rc<str> = v117.borrow().l0.clone();
                        let mut v129: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v130: Rc<str> = Rc::<str>::from(format!("{}{}", v128, v129));
                        let mut v131: Rc<str> = Rc::<str>::from(format!("{}{}", v130, v111));
                        v131.clone()
                    }
                };
                let mut v135: i32 = ((v133.chars().count() + 14999) / 15000) as i32;
                let mut v136: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v137: bool = v111 != v136 ;
                let mut v139: bool = if v137 {
                    let mut v138: bool = v135 <= 1i32;
                    v138
                } else {
                    false
                };
                if v139 {
                    v117.borrow_mut().l0 = v133.clone();
                    ()
                } else {
                    v117.borrow_mut().l0 = v136.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v133); };
                    ()
                }
            } else {
                println!("{}", v111);
                ()
            };
            let mut v142: Rc<dyn Fn(Rc<str>) -> ()> = v115.borrow().l0.clone();
            v142(v111.clone());
            US2::US2_0(v114.clone(), v115.clone(), v116.clone(), v117.clone(), v118.clone(), v119.clone())
        };
        let mut v145: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
        let mut v146: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
        let mut v147: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
        let mut v148: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
        let mut v149: Option<Rc<str>> = None;
        let mut v150: Rc<str> = Rc::<str>::from(format!("crowbook --verbose --to {}", v4));
        let mut v151: Rc<str> = Rc::<str>::from(format!(" --single \"{}\" --output \"{}\"", v2, v1));
        let mut v152: Rc<str> = Rc::<str>::from(format!("{}{}", v150, v151));
        let mut v153: Option<Rc<str>> = Some(v3.clone());
        let mut v154: bool = true;
        let mut v155: bool = true;
        method78(v152.clone(), v145.clone(), v146.clone(), v147.clone(), v148.clone(), v154, v153.clone(), v155)
    };
    let mut v162: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("ERROR"); } LIT.with(|lit| lit.clone()) };
    let mut v163: bool = v159.contains(&*v162);
    let mut v164: bool = v163 == false;
    if v164 {
        US27::US27_0(v158, v159.clone())
    } else {
        let mut v170: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
        { let _ = spiral_trace_hold(&v170); };
        let mut v172: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
        let (mut v173, mut v174, mut v175, mut v176, mut v177, mut v178): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v172) };
        let mut v179: US0 = v177.borrow().l0.clone();
        let mut v184: i32 = match &v179 {
            US0::US0_4 => { // Critical
                50i32
            }
            US0::US0_1 => { // Debug
                20i32
            }
            US0::US0_2 => { // Info
                30i32
            }
            US0::US0_0 => { // Verbose
                10i32
            }
            US0::US0_3 => { // Warning
                40i32
            }
            _ => unreachable!(),
        };
        let mut v185: bool = v175.borrow().l0.clone();
        let mut v186: bool = v185 == false;
        let mut v188: bool = if v186 {
            false
        } else {
            let mut v187: bool = 40i32 >= v184;
            v187
        };
        let mut v189: bool = v188 == false;
        let mut v234: US2 = if v189 {
            US2::US2_1
        } else {
            { let _ = spiral_trace_hold(&v170); };
            let (mut v193, mut v194, mut v195, mut v196, mut v197, mut v198): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v172) };
            let mut v199: Rc<str> = method3(v193.clone(), v194.clone(), v195.clone(), v196.clone(), v197.clone(), v198.clone());
            let mut v200: Rc<str> = method37();
            let mut v201: Rc<str> = method202(v193.clone(), v194.clone(), v195.clone(), v196.clone(), v197.clone(), v198.clone(), v199.clone(), v200.clone(), v158, v1.clone(), v159.clone());
            { let _ = spiral_trace_hold(&v170); };
            let (mut v204, mut v205, mut v206, mut v207, mut v208, mut v209): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v172) };
            let mut v210: i64 = v204.borrow().l0.clone();
            let mut v211: i64 = v210 + 1i64;
            v204.borrow_mut().l0 = v211;
            let mut v212: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
            let mut v213: bool = cfg!(target_arch = "wasm32");
            if v213 {
                let mut v214: Rc<str> = v207.borrow().l0.clone();
                let mut v215: bool = v214.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v223: Rc<str> = if v215 {
                    v201.clone()
                } else {
                    let mut v216: bool = v201.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    if v216 {
                        let mut v217: Rc<str> = v207.borrow().l0.clone();
                        v217.clone()
                    } else {
                        let mut v218: Rc<str> = v207.borrow().l0.clone();
                        let mut v219: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                        let mut v220: Rc<str> = Rc::<str>::from(format!("{}{}", v218, v219));
                        let mut v221: Rc<str> = Rc::<str>::from(format!("{}{}", v220, v201));
                        v221.clone()
                    }
                };
                let mut v225: i32 = ((v223.chars().count() + 14999) / 15000) as i32;
                let mut v226: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let mut v227: bool = v201 != v226 ;
                let mut v229: bool = if v227 {
                    let mut v228: bool = v225 <= 1i32;
                    v228
                } else {
                    false
                };
                if v229 {
                    v207.borrow_mut().l0 = v223.clone();
                    ()
                } else {
                    v207.borrow_mut().l0 = v226.clone();
                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v223); };
                    ()
                }
            } else {
                println!("{}", v201);
                ()
            };
            let mut v232: Rc<dyn Fn(Rc<str>) -> ()> = v205.borrow().l0.clone();
            v232(v201.clone());
            US2::US2_0(v204.clone(), v205.clone(), v206.clone(), v207.clone(), v208.clone(), v209.clone())
        };
        US27::US27_1(v158, v159.clone())
    }
}
fn closure68(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool, mut v3: Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24> {
    Rc::new(move |mut v4: Rc<str>| -> US24 {
        let (mut v5, mut v6): (Rc<str>, Rc<str>) = method156(v4.clone(), v3.clone(), v0.clone());
        let mut v7: bool = method35(v5.clone());
        let mut v8: bool = v7 == false;
        let mut v11: bool = if v8 {
            true
        } else {
            let mut v9: bool = method35(v6.clone());
            let mut v10: bool = v9 == false;
            v10
        };
        let mut v165: bool = if v11 {
            false
        } else {
            let mut v12: Rc<str> = method43(v5.clone());
            let mut v14: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v12);
            let mut v16: std::fs::File = v14.unwrap();
            let mut v18: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v16);
            let mut v20: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v18);
            let mut v22: bool = true; let mut v20 = v20;
            let mut v24: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
            let mut v26: sha2::Sha256 = result;
            let mut v28: bool = true; let mut v26 = v26;
            let mut v29: usize = ((0i32) as usize);
            let mut v31: _ = [0u8; 1024i32 as usize];
            let mut v33: bool = true; loop { // rust.loop 1;
            let mut v35: bool = true; let mut v31 = v31;
            let mut v37: Result<usize, std::io::Error> = std::io::Read::read(&mut v20, &mut v31);
            let mut v39: usize = v37.unwrap();
            let mut v40: bool = v39 == v29 ;
            let mut v43: bool = if v40 {
                let mut v42: bool = true; break ();
                true
            } else {
                false
            };
            let mut v44: usize = ((v39) as usize);
            let mut v45: usize = (v44.clone());
            let mut v47: usize = v31.len();
            let mut v48: bool = v45 == v47 ;
            let mut v53: &_ = if v48 {
                let mut v50: &_ = &v31[v29..];
                v50.clone()
            } else {
                let mut v52: &_ = &v31[v29..v44];
                v52.clone()
            };
            let mut v55: bool = true; sha2::Digest::update(&mut v26, v53);
            let mut v57: bool = true; } // rust.loop 3;
            let mut v59: &[u8] = &sha2::Digest::finalize(v26);
            let mut v61: Vec<u8> = v59.iter().map(|x| *x).collect::<Vec<_>>();
            let mut v63: Rc<dyn Fn((u8)) -> Rc<str>> = closure58();
            let mut v64: Vec<Rc<str>> = v61.iter().map(|x| v63(x.clone())).collect::<Vec<_>>();
            let mut v65: Vec<Rc<str>> = method157(v64.clone());
            let mut v66: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v65));
            let mut v67: Rc<Vec<Rc<str>>> = Rc::new((v66).borrow().clone());
            let mut v68: i32 = (v67).len() as i32;
            let mut v69: i32 = v68 - 1i32;
            let mut v70: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
            let mut v71: Rc<UH0> = method158(v67.clone(), v69, v70.clone());
            let mut v72: Rc<str> = method159();
            let mut v73: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let (mut v74, mut v75): (Rc<str>, Rc<str>) = method160(v72.clone(), v71.clone(), v73.clone());
            let mut v76: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v74);
            let mut v77: Rc<dyn Fn(std::io::Error) -> std::string::String> = method161();
            let mut v79: Result<Rc<str>, std::string::String> = v76.map_err(|x| v77(x));
            let mut v80: Rc<dyn Fn(Rc<str>) -> US25> = method162();
            let mut v81: Rc<dyn Fn(std::string::String) -> US25> = method163();
            let mut v82: US25 = match v79 { Ok(x) => v80(x), Err(e) => v81(e) };
            let mut v88: Rc<str> = match &v82 {
                US25::US25_1(v84) => { // Error
                    let mut v84: std::string::String = v84.clone();
                    let mut v85: Rc<str> = Rc::<str>::from(format!("resultm.get / Error x: {:?}", v84));
                    std::panic::panic_any::<std::string::String>(format!("{}", v85.clone()))
                }
                US25::US25_0(v83) => { // Ok
                    let mut v83: Rc<str> = v83.clone();
                    v83.clone()
                }
                _ => unreachable!(),
            };
            let mut v89: Rc<str> = method43(v6.clone());
            let mut v91: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v89);
            let mut v93: std::fs::File = v91.unwrap();
            let mut v95: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v93);
            let mut v97: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v95);
            let mut v99: bool = true; let mut v97 = v97;
            let mut v101: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
            let mut v103: sha2::Sha256 = result;
            let mut v105: bool = true; let mut v103 = v103;
            let mut v106: usize = ((0i32) as usize);
            let mut v108: _ = [0u8; 1024i32 as usize];
            let mut v110: bool = true; loop { // rust.loop 1;
            let mut v112: bool = true; let mut v108 = v108;
            let mut v114: Result<usize, std::io::Error> = std::io::Read::read(&mut v97, &mut v108);
            let mut v116: usize = v114.unwrap();
            let mut v117: bool = v116 == v106 ;
            let mut v120: bool = if v117 {
                let mut v119: bool = true; break ();
                true
            } else {
                false
            };
            let mut v121: usize = ((v116) as usize);
            let mut v122: usize = (v121.clone());
            let mut v124: usize = v108.len();
            let mut v125: bool = v122 == v124 ;
            let mut v130: &_ = if v125 {
                let mut v127: &_ = &v108[v106..];
                v127.clone()
            } else {
                let mut v129: &_ = &v108[v106..v121];
                v129.clone()
            };
            let mut v132: bool = true; sha2::Digest::update(&mut v103, v130);
            let mut v134: bool = true; } // rust.loop 3;
            let mut v136: &[u8] = &sha2::Digest::finalize(v103);
            let mut v138: Vec<u8> = v136.iter().map(|x| *x).collect::<Vec<_>>();
            let mut v140: Vec<Rc<str>> = v138.iter().map(|x| v63(x.clone())).collect::<Vec<_>>();
            let mut v141: Vec<Rc<str>> = method157(v140.clone());
            let mut v142: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v141));
            let mut v143: Rc<Vec<Rc<str>>> = Rc::new((v142).borrow().clone());
            let mut v144: i32 = (v143).len() as i32;
            let mut v145: i32 = v144 - 1i32;
            let mut v146: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
            let mut v147: Rc<UH0> = method158(v143.clone(), v145, v146.clone());
            let mut v148: Rc<str> = method159();
            let (mut v149, mut v150): (Rc<str>, Rc<str>) = method160(v148.clone(), v147.clone(), v73.clone());
            let mut v151: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v149);
            let mut v152: Rc<dyn Fn(std::io::Error) -> std::string::String> = method161();
            let mut v154: Result<Rc<str>, std::string::String> = v151.map_err(|x| v152(x));
            let mut v155: Rc<dyn Fn(Rc<str>) -> US25> = method162();
            let mut v156: Rc<dyn Fn(std::string::String) -> US25> = method163();
            let mut v157: US25 = match v154 { Ok(x) => v155(x), Err(e) => v156(e) };
            let mut v163: Rc<str> = match &v157 {
                US25::US25_1(v159) => { // Error
                    let mut v159: std::string::String = v159.clone();
                    let mut v160: Rc<str> = Rc::<str>::from(format!("resultm.get / Error x: {:?}", v159));
                    std::panic::panic_any::<std::string::String>(format!("{}", v160.clone()))
                }
                US25::US25_0(v158) => { // Ok
                    let mut v158: Rc<str> = v158.clone();
                    v158.clone()
                }
                _ => unreachable!(),
            };
            let mut v164: bool = v88.clone() == v163.clone();
            v164
        };
        if v165 {
            US24::US24_1
        } else {
            let mut v167: US27 = method199(v2, v5.clone(), v3.clone(), v1.clone(), v4.clone());
            match &v167 {
                US27::US27_1(v247, v248) => { // Error
                    let mut v247: i32 = v247.clone();
                    let mut v248: Rc<str> = v248.clone();
                    let (mut v249, mut v250): (Rc<str>, Rc<str>) = method196(v5.clone(), v248.clone());
                    let mut v251: (Rc<str>, Rc<str>) = (v249, v250);
                    let mut v252: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v251);
                    US24::US24_0(v252.clone())
                }
                US27::US27_0(v168, v169) => { // Ok
                    let mut v168: i32 = v168.clone();
                    let mut v169: Rc<str> = v169.clone();
                    let mut v170: bool = v168 != 0i32 ;
                    if v170 {
                        let mut v172: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                        { let _ = spiral_trace_hold(&v172); };
                        let mut v174: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v175, mut v176, mut v177, mut v178, mut v179, mut v180): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v174) };
                        let mut v181: US0 = v179.borrow().l0.clone();
                        let mut v186: i32 = match &v181 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
                        };
                        let mut v187: bool = v177.borrow().l0.clone();
                        let mut v188: bool = v187 == false;
                        let mut v190: bool = if v188 {
                            false
                        } else {
                            let mut v189: bool = 30i32 >= v186;
                            v189
                        };
                        let mut v191: bool = v190 == false;
                        let mut v236: US2 = if v191 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v172); };
                            let (mut v195, mut v196, mut v197, mut v198, mut v199, mut v200): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v174) };
                            let mut v201: Rc<str> = method3(v195.clone(), v196.clone(), v197.clone(), v198.clone(), v199.clone(), v200.clone());
                            let mut v202: Rc<str> = method4();
                            let mut v203: Rc<str> = method197(v195.clone(), v196.clone(), v197.clone(), v198.clone(), v199.clone(), v200.clone(), v201.clone(), v202.clone(), v168, v169.clone());
                            { let _ = spiral_trace_hold(&v172); };
                            let (mut v206, mut v207, mut v208, mut v209, mut v210, mut v211): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v174) };
                            let mut v212: i64 = v206.borrow().l0.clone();
                            let mut v213: i64 = v212 + 1i64;
                            v206.borrow_mut().l0 = v213;
                            let mut v214: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let mut v215: bool = cfg!(target_arch = "wasm32");
                            if v215 {
                                let mut v216: Rc<str> = v209.borrow().l0.clone();
                                let mut v217: bool = v216.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v225: Rc<str> = if v217 {
                                    v203.clone()
                                } else {
                                    let mut v218: bool = v203.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v218 {
                                        let mut v219: Rc<str> = v209.borrow().l0.clone();
                                        v219.clone()
                                    } else {
                                        let mut v220: Rc<str> = v209.borrow().l0.clone();
                                        let mut v221: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v222: Rc<str> = Rc::<str>::from(format!("{}{}", v220, v221));
                                        let mut v223: Rc<str> = Rc::<str>::from(format!("{}{}", v222, v203));
                                        v223.clone()
                                    }
                                };
                                let mut v227: i32 = ((v225.chars().count() + 14999) / 15000) as i32;
                                let mut v228: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v229: bool = v203 != v228 ;
                                let mut v231: bool = if v229 {
                                    let mut v230: bool = v227 <= 1i32;
                                    v230
                                } else {
                                    false
                                };
                                if v231 {
                                    v209.borrow_mut().l0 = v225.clone();
                                    ()
                                } else {
                                    v209.borrow_mut().l0 = v228.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v225); };
                                    ()
                                }
                            } else {
                                println!("{}", v203);
                                ()
                            };
                            let mut v234: Rc<dyn Fn(Rc<str>) -> ()> = v207.borrow().l0.clone();
                            v234(v203.clone());
                            US2::US2_0(v206.clone(), v207.clone(), v208.clone(), v209.clone(), v210.clone(), v211.clone())
                        };
                        let (mut v237, mut v238): (Rc<str>, Rc<str>) = method196(v5.clone(), v169.clone());
                        let mut v239: (Rc<str>, Rc<str>) = (v237, v238);
                        let mut v240: Result<Rc<str>, (Rc<str>, Rc<str>)> = Err::<Rc<str>, (Rc<str>, Rc<str>)>(v239);
                        US24::US24_0(v240.clone())
                    } else {
                        let mut v242: bool = method35(v5.clone());
                        if v242 {
                            method177(v6.clone(), v5.clone())
                        } else {
                            let mut v243: Rc<str> = Rc::<str>::from(format!("documents.files_fn / {} should exist", v5));
                            std::panic::panic_any::<std::string::String>(format!("{}", v243.clone()))
                        };
                        let mut v244: Result<Rc<str>, (Rc<str>, Rc<str>)> = Ok::<Rc<str>, (Rc<str>, Rc<str>)>(v5);
                        US24::US24_0(v244.clone())
                    }
                }
                _ => unreachable!(),
            }
        }
    })
}
fn closure67(mut v0: Rc<str>, mut v1: Rc<str>, mut v2: bool) -> Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> {
    Rc::new(move |mut v3: Rc<str>| -> Rc<dyn Fn(Rc<str>) -> US24> {
        closure68(v0.clone(), v1.clone(), v2, v3.clone())
    })
}
fn method205(mut v0: Rc<RefCell<Mut3>>) -> () {
    let mut v1: Rc<str> = v0.borrow().l0.clone();
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("output_cache_path"); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<str> = Rc::<str>::from(format!("{}{}", v1, v2));
    v0.borrow_mut().l0 = v3.clone();
    ()
}
fn method204(mut v0: Rc<str>, mut v1: Rc<str>) -> Rc<str> {
    let mut v2: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v3: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v2.clone() }));
    method13(v3.clone());
    method195(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v0.clone());
    method41(v3.clone());
    method205(v3.clone());
    method15(v3.clone());
    method6(v3.clone(), v1.clone());
    method16(v3.clone());
    let mut v4: Rc<str> = v3.borrow().l0.clone();
    v4.clone()
}
fn method203(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: Rc<str>, mut v9: Rc<str>) -> Rc<str> {
    let mut v10: i64 = v0.borrow().l0.clone();
    let mut v11: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v12: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v11));
    let mut v13: Rc<str> = method11(v10);
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v12, v13));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v7));
    let mut v16: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v11));
    let mut v17: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / files' = [] / listm.iter"); } LIT.with(|lit| lit.clone()) };
    let mut v18: Rc<str> = Rc::<str>::from(format!("{}{}", v16, v17));
    let mut v19: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v20: Rc<str> = Rc::<str>::from(format!("{}{}", v18, v19));
    let mut v21: Rc<str> = method204(v8.clone(), v9.clone());
    let mut v22: Rc<str> = Rc::<str>::from(format!("{}{}", v20, v21));
    method8(v22.clone())
}
fn method206(mut v0: Rc<RefCell<Vec<Rc<UH2>>>>, mut v1: Rc<UH1>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH1::UH1_1(v3, v4) => { // Cons
                let mut v3: Rc<UH2> = v3.clone();
                let mut v4: Rc<UH1> = v4.clone();
                v0.borrow_mut().push(v3);
                let mut v5: i32 = v2 + 1i32;
                (v0, v1, v2) = (v0.clone(), v4.clone(), v5);
                continue;
            }
            UH1::UH1_0 => { // Nil
                return v2;
            }
            _ => unreachable!(),
        }
    }
}
fn method207(mut v0: Vec<Rc<UH2>>) -> Vec<Rc<UH2>> {
    v0.clone()
}
fn method208(mut v0: Rc<Vec<Rc<UH2>>>, mut v1: i32, mut v2: Rc<UH1>) -> Rc<UH1> {
    loop {
        let mut v3: bool = v1 < 0i32;
        if v3 {
            return v2.clone();
        } else {
            let mut v4: Rc<UH2> = (v0)[v1 as usize].clone();
            let mut v5: i32 = v1 - 1i32;
            let mut v6: Rc<UH1> = Rc::new(UH1::UH1_1(v4.clone(), v2.clone()));
            (v0, v1, v2) = (v0.clone(), v5, v6.clone());
            continue;
        }
    }
}
fn method210(mut v0: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>>, mut v1: Rc<UH2>, mut v2: i32) -> i32 {
    loop {
        match &*v1 {
            UH2::UH2_1(v3, v4, v5, v6) => { // Cons
                let mut v3: Rc<str> = v3.clone();
                let mut v4: Rc<str> = v4.clone();
                let mut v5: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = v5.clone();
                let mut v6: Rc<UH2> = v6.clone();
                v0.borrow_mut().push((v3.clone(), v4.clone(), v5.clone()));
                let mut v7: i32 = v2 + 1i32;
                (v0, v1, v2) = (v0.clone(), v6.clone(), v7);
                continue;
            }
            UH2::UH2_0 => { // Nil
                return v2;
            }
            _ => unreachable!(),
        }
    }
}
fn method212(mut v0: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>) -> Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> {
    v0.clone()
}
fn method213(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0.clone()
}
fn method211(mut v0: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>>, mut v1: i32, mut v2: i32, mut v3: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    loop {
        let mut v4: bool = v2 < v1;
        if v4 {
            let mut v5: i32 = v2 + 1i32;
            let (mut v22, mut v23, mut v24): (Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>) = v0.clone().borrow()[v2 as usize].clone();
            let mut v32: Rc<dyn Fn(Rc<str>) -> US24> = v24(v23.clone());
            let mut v33: US24 = v32(v22.clone());
            let mut v40: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = match &v33 {
                US24::US24_1 => { // None
                    let mut v38: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = None;
                    v38.clone()
                }
                US24::US24_0(v34) => { // Some
                    let mut v34: Result<Rc<str>, (Rc<str>, Rc<str>)> = v34.clone();
                    let mut v36: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = Some(v34.clone());
                    v36.clone()
                }
                _ => unreachable!(),
            };
            let mut v41: Option<Result<Rc<str>, (Rc<str>, Rc<str>)>> = method212(v40.clone());
            let mut v42: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method213(v3.clone());
            let mut v44: bool = true; let mut v42 = v42;
            let mut v46: bool = true; v42.push(v41);
            let mut v48: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = v42;
            (v0, v1, v2, v3) = (v0.clone(), v1, v5, v48.clone());
            continue;
        } else {
            return v3.clone();
        }
    }
}
fn method214(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0.clone()
}
fn method215(mut v0: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    v0.clone()
}
fn method209(mut v0: Rc<UH1>, mut v1: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> {
    loop {
        match &*v0 {
            UH1::UH1_1(v2, v3) => { // Cons
                let mut v2: Rc<UH2> = v2.clone();
                let mut v3: Rc<UH1> = v3.clone();
                let mut v16: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>> = Rc::new(RefCell::new(Vec::new()));
                let mut v17: i32 = 0i32;
                let mut v18: i32 = method210(v16.clone(), v2.clone(), v17);
                let mut v19: Rc<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>> = Rc::new(v16.borrow().clone());
                let mut v22: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>> = Rc::new(RefCell::new((v19).as_ref().clone()));
                let mut v25: Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)> = (v22).borrow().clone();
                let mut v28: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>> = Rc::new(RefCell::new(v25.clone()));
                let mut v32: Rc<RefCell<Vec<(Rc<str>, Rc<str>, Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>>)>>> = (v28);
                let mut v33: i32 = (v32.borrow().len() as i32);
                let mut v34: i32 = 0i32;
                let mut v35: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = Vec::new();
                let mut v36: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method211(v32.clone(), v33, v34, v35.clone());
                let mut v37: Rc<RefCell<Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>>> = Rc::new(RefCell::new(v36));
                let mut v40: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = (v37).borrow().clone();
                let mut v41: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method214(v40.clone());
                let mut v42: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method215(v1.clone());
                let mut v44: bool = true; let mut v42 = v42;
                let mut v46: bool = true; v42.extend(v41);
                let mut v48: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = v42;
                (v0, v1) = (v3.clone(), v48.clone());
                continue;
            }
            UH1::UH1_0 => { // Nil
                return v1.clone();
            }
            _ => unreachable!(),
        }
    }
}
fn method216(mut v0: Rc<str>, mut v1: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) -> (Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) {
    (v0.clone(), v1.clone())
}
fn method217(mut v0: Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>) -> Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String> {
    v0.clone()
}
fn method218(mut v0: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> {
    v0.clone()
}
fn method75(mut v0: bool, mut v1: Rc<str>, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: Rc<str>, mut v5: Rc<str>, mut v6: Rc<RefCell<Vec<Rc<str>>>>, mut v7: i32, mut v8: i32, mut v9: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> {
    loop {
        let mut v10: bool = v8 < v7;
        if v10 {
            let mut v11: i32 = v8 + 1i32;
            let mut v13: Rc<str> = v6.clone().borrow()[v8 as usize].clone();
            let mut v14: Rc<str> = method58(v13.clone());
            let mut v16: &str = &*v14;
            let mut v18: std::string::String = String::from(v16);
            let mut v20: std::path::PathBuf = std::path::PathBuf::from(v18);
            let mut v21: std::path::PathBuf = method27(v20.clone());
            let mut v23: std::path::Display = v21.display();
            let mut v25: std::string::String = format!("{}", v23);
            let mut v27: Rc<str> = Rc::<str>::from(String::as_str(&v25));
            let mut v28: Rc<str> = method76();
            let mut v30: Rc<str> = Rc::<str>::from(v27.replace(&*v4, &*v28));
            let mut v31: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\\"); } LIT.with(|lit| lit.clone()) };
            let mut v32: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/"); } LIT.with(|lit| lit.clone()) };
            let mut v33: Rc<str> = Rc::<str>::from(v30.replace(&*v31, &*v32));
            let mut v34: Rc<str> = Rc::<str>::from(format!(".{}", v33));
            let mut v35: Rc<str> = method43(v14.clone());
            let mut v36: Rc<str> = method29(v3.clone(), v34.clone());
            let mut v37: Rc<str> = method77(v36.clone());
            let mut v39: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
            let mut v40: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
            let mut v42: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
            let mut v43: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
            let mut v44: Option<Rc<str>> = None;
            let mut v45: Rc<str> = Rc::<str>::from(format!("git ls-tree --format='%(objectname)' origin/gh-pages \"{}\"", v37));
            let mut v46: Option<Rc<str>> = Some(v3.clone());
            let mut v47: bool = true;
            let mut v48: bool = true;
            let (mut v49, mut v50): (i32, Rc<str>) = method78(v45.clone(), v39.clone(), v40.clone(), v42.clone(), v43.clone(), v47, v46.clone(), v48);
            let mut v51: Rc<str> = method29(v4.clone(), v34.clone());
            let mut v52: Rc<str> = method77(v51.clone());
            let mut v53: Option<std::sync::Arc<std::sync::atomic::AtomicBool>> = None;
            let mut v54: Rc<RefCell<Vec<(Rc<str>, Rc<str>)>>> = Rc::new(RefCell::new(vec![]));
            let mut v55: Option<Rc<dyn Fn(i32, Rc<str>, bool) -> std::pin::Pin<Box<dyn std::future::Future<Output = ()>>>>> = None;
            let mut v56: Option<Rc<dyn Fn(std::sync::Arc<std::sync::Mutex<std::process::ChildStdin>>) -> ()>> = None;
            let mut v57: Option<Rc<str>> = None;
            let mut v58: Rc<str> = Rc::<str>::from(format!("git hash-object \"{}\"", v52));
            let mut v59: Option<Rc<str>> = Some(v4.clone());
            let mut v60: bool = true;
            let mut v61: bool = true;
            let (mut v62, mut v63): (i32, Rc<str>) = method78(v58.clone(), v53.clone(), v54.clone(), v55.clone(), v56.clone(), v60, v59.clone(), v61);
            let mut v64: Rc<str> = method29(v5.clone(), v34.clone());
            let mut v65: Rc<str> = method77(v64.clone());
            let mut v66: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("hangul.md"); } LIT.with(|lit| lit.clone()) };
            let (mut v67, mut v68): (Rc<str>, Rc<str>) = method156(v66.clone(), v52.clone(), v5.clone());
            let mut v69: bool = false;
            let mut v70: bool = false;
            let mut v71: bool = false;
            let mut v72: bool = true;
            let mut v73: bool = true;
            let mut v74: bool = true;
            let mut v75: bool = v50.contains(&*v63);
            let mut v497: Rc<UH1> = if v75 {
                { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_0); } CASE.with(|case| case.clone()) }
            } else {
                let mut v77: Rc<str> = method43(v52.clone());
                let mut v79: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v77);
                let mut v81: std::fs::File = v79.unwrap();
                let mut v83: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v81);
                let mut v85: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v83);
                let mut v87: bool = true; let mut v85 = v85;
                let mut v89: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
                let mut v91: sha2::Sha256 = result;
                let mut v93: bool = true; let mut v91 = v91;
                let mut v101: usize = ((0i32) as usize);
                let mut v103: _ = [0u8; 1024i32 as usize];
                let mut v105: bool = true; loop { // rust.loop 1;
                let mut v107: bool = true; let mut v103 = v103;
                let mut v109: Result<usize, std::io::Error> = std::io::Read::read(&mut v85, &mut v103);
                let mut v111: usize = v109.unwrap();
                let mut v113: bool = v111 == v101 ;
                let mut v116: bool = if v113 {
                    let mut v115: bool = true; break ();
                    true
                } else {
                    false
                };
                let mut v124: usize = ((v111) as usize);
                let mut v126: usize = (v124.clone());
                let mut v128: usize = v103.len();
                let mut v129: bool = v126 == v128 ;
                let mut v134: &_ = if v129 {
                    let mut v131: &_ = &v103[v101..];
                    v131.clone()
                } else {
                    let mut v133: &_ = &v103[v101..v124];
                    v133.clone()
                };
                let mut v136: bool = true; sha2::Digest::update(&mut v91, v134);
                let mut v138: bool = true; } // rust.loop 3;
                let mut v140: &[u8] = &sha2::Digest::finalize(v91);
                let mut v142: Vec<u8> = v140.iter().map(|x| *x).collect::<Vec<_>>();
                let mut v144: Rc<dyn Fn((u8)) -> Rc<str>> = closure58();
                let mut v145: Vec<Rc<str>> = v142.iter().map(|x| v144(x.clone())).collect::<Vec<_>>();
                let mut v148: Vec<Rc<str>> = method157(v145.clone());
                let mut v149: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v148));
                let mut v151: Rc<Vec<Rc<str>>> = Rc::new((v149).borrow().clone());
                let mut v158: i32 = (v151).len() as i32;
                let mut v159: i32 = v158 - 1i32;
                let mut v160: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
                let mut v161: Rc<UH0> = method158(v151.clone(), v159, v160.clone());
                let mut v162: Rc<str> = method159();
                let mut v163: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                let (mut v164, mut v165): (Rc<str>, Rc<str>) = method160(v162.clone(), v161.clone(), v163.clone());
                let mut v167: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v164);
                let mut v168: Rc<dyn Fn(std::io::Error) -> std::string::String> = method161();
                let mut v180: Result<Rc<str>, std::string::String> = v167.map_err(|x| v168(x));
                let mut v181: Rc<dyn Fn(Rc<str>) -> US25> = method162();
                let mut v182: Rc<dyn Fn(std::string::String) -> US25> = method163();
                let mut v199: US25 = match v180 { Ok(x) => v181(x), Err(e) => v182(e) };
                let mut v221: Rc<str> = match &v199 {
                    US25::US25_1(v216) => { // Error
                        let mut v216: std::string::String = v216.clone();
                        let mut v218: Rc<str> = Rc::<str>::from(format!("resultm.get / Error x: {:?}", v216));
                        std::panic::panic_any::<std::string::String>(format!("{}", v218.clone()))
                    }
                    US25::US25_0(v215) => { // Ok
                        let mut v215: Rc<str> = v215.clone();
                        v215.clone()
                    }
                    _ => unreachable!(),
                };
                let mut v222: bool = method35(v65.clone());
                let mut v223: bool = v222 == false;
                let mut v300: US4 = if v223 {
                    US4::US4_1
                } else {
                    let mut v225: Rc<str> = method43(v65.clone());
                    let mut v227: Result<std::fs::File, std::io::Error> = std::fs::File::open(&*v225);
                    let mut v229: std::fs::File = v227.unwrap();
                    let mut v231: std::io::BufReader<std::fs::File> = std::io::BufReader::new(v229);
                    let mut v233: std::io::BufReader<std::io::BufReader<std::fs::File>> = std::io::BufReader::new(v231);
                    let mut v235: bool = true; let mut v233 = v233;
                    let mut v237: bool = true; let result : sha2::Sha256 = sha2::Digest::new();
                    let mut v239: sha2::Sha256 = result;
                    let mut v241: bool = true; let mut v239 = v239;
                    let mut v242: usize = ((0i32) as usize);
                    let mut v244: _ = [0u8; 1024i32 as usize];
                    let mut v246: bool = true; loop { // rust.loop 1;
                    let mut v248: bool = true; let mut v244 = v244;
                    let mut v250: Result<usize, std::io::Error> = std::io::Read::read(&mut v233, &mut v244);
                    let mut v252: usize = v250.unwrap();
                    let mut v253: bool = v252 == v242 ;
                    let mut v256: bool = if v253 {
                        let mut v255: bool = true; break ();
                        true
                    } else {
                        false
                    };
                    let mut v257: usize = ((v252) as usize);
                    let mut v258: usize = (v257.clone());
                    let mut v260: usize = v244.len();
                    let mut v261: bool = v258 == v260 ;
                    let mut v266: &_ = if v261 {
                        let mut v263: &_ = &v244[v242..];
                        v263.clone()
                    } else {
                        let mut v265: &_ = &v244[v242..v257];
                        v265.clone()
                    };
                    let mut v268: bool = true; sha2::Digest::update(&mut v239, v266);
                    let mut v270: bool = true; } // rust.loop 3;
                    let mut v272: &[u8] = &sha2::Digest::finalize(v239);
                    let mut v274: Vec<u8> = v272.iter().map(|x| *x).collect::<Vec<_>>();
                    let mut v276: Vec<Rc<str>> = v274.iter().map(|x| v144(x.clone())).collect::<Vec<_>>();
                    let mut v277: Vec<Rc<str>> = method157(v276.clone());
                    let mut v278: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v277));
                    let mut v279: Rc<Vec<Rc<str>>> = Rc::new((v278).borrow().clone());
                    let mut v280: i32 = (v279).len() as i32;
                    let mut v281: i32 = v280 - 1i32;
                    let mut v282: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_0); } CASE.with(|case| case.clone()) };
                    let mut v283: Rc<UH0> = method158(v279.clone(), v281, v282.clone());
                    let mut v284: Rc<str> = method159();
                    let (mut v285, mut v286): (Rc<str>, Rc<str>) = method160(v284.clone(), v283.clone(), v163.clone());
                    let mut v287: Result<Rc<str>, std::io::Error> = Ok::<Rc<str>, std::io::Error>(v285);
                    let mut v288: Rc<dyn Fn(std::io::Error) -> std::string::String> = method161();
                    let mut v290: Result<Rc<str>, std::string::String> = v287.map_err(|x| v288(x));
                    let mut v291: Rc<dyn Fn(Rc<str>) -> US25> = method162();
                    let mut v292: Rc<dyn Fn(std::string::String) -> US25> = method163();
                    let mut v293: US25 = match v290 { Ok(x) => v291(x), Err(e) => v292(e) };
                    match &v293 {
                        US25::US25_1(v296) => { // Error
                            let mut v296: std::string::String = v296.clone();
                            US4::US4_1
                        }
                        US25::US25_0(v294) => { // Ok
                            let mut v294: Rc<str> = v294.clone();
                            US4::US4_0(v294.clone())
                        }
                        _ => unreachable!(),
                    }
                };
                match &v300 {
                    US4::US4_0(v301) => { // Some
                        let mut v301: Rc<str> = v301.clone();
                        let mut v302: bool = v221.clone() == v301.clone();
                        if v302 {
                            { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_0); } CASE.with(|case| case.clone()) }
                        } else {
                            let mut v308: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                            { let _ = spiral_trace_hold(&v308); };
                            let mut v310: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                            let (mut v311, mut v312, mut v313, mut v314, mut v315, mut v316): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v310) };
                            let mut v317: US0 = v315.borrow().l0.clone();
                            let mut v322: i32 = match &v317 {
                                US0::US0_4 => { // Critical
                                    50i32
                                }
                                US0::US0_1 => { // Debug
                                    20i32
                                }
                                US0::US0_2 => { // Info
                                    30i32
                                }
                                US0::US0_0 => { // Verbose
                                    10i32
                                }
                                US0::US0_3 => { // Warning
                                    40i32
                                }
                                _ => unreachable!(),
                            };
                            let mut v323: bool = v313.borrow().l0.clone();
                            let mut v324: bool = v323 == false;
                            let mut v326: bool = if v324 {
                                false
                            } else {
                                let mut v325: bool = 30i32 >= v322;
                                v325
                            };
                            let mut v327: bool = v326 == false;
                            let mut v378: US2 = if v327 {
                                US2::US2_1
                            } else {
                                { let _ = spiral_trace_hold(&v308); };
                                let (mut v331, mut v332, mut v333, mut v334, mut v335, mut v336): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v310) };
                                let mut v337: Rc<str> = method3(v331.clone(), v332.clone(), v333.clone(), v334.clone(), v335.clone(), v336.clone());
                                let mut v338: Rc<str> = method4();
                                let mut v339: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map"); } LIT.with(|lit| lit.clone()) };
                                let mut v340: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                                let mut v341: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                                let mut v342: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                                let mut v343: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                                let mut v344: bool = v343.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v346: Rc<str> = if v344 {
                                    v163.clone()
                                } else {
                                    method164(v331.clone(), v332.clone(), v333.clone(), v334.clone(), v335.clone(), v336.clone(), v337.clone(), v338.clone(), v343.clone(), v35.clone(), v37.clone(), v34.clone(), v49, v50.clone(), v62, v63.clone(), v221.clone(), v300.clone(), v52.clone(), v65.clone())
                                };
                                { let _ = spiral_trace_hold(&v308); };
                                let (mut v349, mut v350, mut v351, mut v352, mut v353, mut v354): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v310) };
                                let mut v355: i64 = v349.borrow().l0.clone();
                                let mut v356: i64 = v355 + 1i64;
                                v349.borrow_mut().l0 = v356;
                                let mut v357: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                                let mut v358: bool = cfg!(target_arch = "wasm32");
                                if v358 {
                                    let mut v359: Rc<str> = v352.borrow().l0.clone();
                                    let mut v360: bool = v359.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    let mut v368: Rc<str> = if v360 {
                                        v346.clone()
                                    } else {
                                        let mut v361: bool = v346.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                        if v361 {
                                            let mut v362: Rc<str> = v352.borrow().l0.clone();
                                            v362.clone()
                                        } else {
                                            let mut v363: Rc<str> = v352.borrow().l0.clone();
                                            let mut v364: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                            let mut v365: Rc<str> = Rc::<str>::from(format!("{}{}", v363, v364));
                                            let mut v366: Rc<str> = Rc::<str>::from(format!("{}{}", v365, v346));
                                            v366.clone()
                                        }
                                    };
                                    let mut v370: i32 = ((v368.chars().count() + 14999) / 15000) as i32;
                                    let mut v371: bool = v346 != v163 ;
                                    let mut v373: bool = if v371 {
                                        let mut v372: bool = v370 <= 1i32;
                                        v372
                                    } else {
                                        false
                                    };
                                    if v373 {
                                        v352.borrow_mut().l0 = v368.clone();
                                        ()
                                    } else {
                                        v352.borrow_mut().l0 = v163.clone();
                                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v368); };
                                        ()
                                    }
                                } else {
                                    println!("{}", v346);
                                    ()
                                };
                                let mut v376: Rc<dyn Fn(Rc<str>) -> ()> = v350.borrow().l0.clone();
                                v376(v346.clone());
                                US2::US2_0(v349.clone(), v350.clone(), v351.clone(), v352.clone(), v353.clone(), v354.clone())
                            };
                            method177(v65.clone(), v52.clone());
                            let mut v379: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure64(v5.clone(), v4.clone(), v2.clone(), v1.clone(), v0);
                            let mut v380: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_0); } CASE.with(|case| case.clone()) };
                            let mut v381: Rc<UH2> = Rc::new(UH2::UH2_1(v66.clone(), v52.clone(), v379.clone(), v380.clone()));
                            let mut v382: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("html"); } LIT.with(|lit| lit.clone()) };
                            let mut v383: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v69);
                            let mut v384: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("pdf"); } LIT.with(|lit| lit.clone()) };
                            let mut v385: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v70);
                            let mut v386: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epub"); } LIT.with(|lit| lit.clone()) };
                            let mut v387: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v71);
                            let mut v388: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v72);
                            let mut v389: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v73);
                            let mut v390: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v74);
                            let mut v391: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_0); } CASE.with(|case| case.clone()) };
                            let mut v392: Rc<UH2> = Rc::new(UH2::UH2_1(v386.clone(), v67.clone(), v390.clone(), v391.clone()));
                            let mut v393: Rc<UH2> = Rc::new(UH2::UH2_1(v384.clone(), v67.clone(), v389.clone(), v392.clone()));
                            let mut v394: Rc<UH2> = Rc::new(UH2::UH2_1(v382.clone(), v67.clone(), v388.clone(), v393.clone()));
                            let mut v395: Rc<UH2> = Rc::new(UH2::UH2_1(v386.clone(), v52.clone(), v387.clone(), v394.clone()));
                            let mut v396: Rc<UH2> = Rc::new(UH2::UH2_1(v384.clone(), v52.clone(), v385.clone(), v395.clone()));
                            let mut v397: Rc<UH2> = Rc::new(UH2::UH2_1(v382.clone(), v52.clone(), v383.clone(), v396.clone()));
                            let mut v398: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_0); } CASE.with(|case| case.clone()) };
                            let mut v399: Rc<UH1> = Rc::new(UH1::UH1_1(v397.clone(), v398.clone()));
                            Rc::new(UH1::UH1_1(v381.clone(), v399.clone()))
                        }
                    }
                    _ => {
                        let mut v403: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                        { let _ = spiral_trace_hold(&v403); };
                        let mut v405: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v406, mut v407, mut v408, mut v409, mut v410, mut v411): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v405) };
                        let mut v412: US0 = v410.borrow().l0.clone();
                        let mut v417: i32 = match &v412 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
                        };
                        let mut v418: bool = v408.borrow().l0.clone();
                        let mut v419: bool = v418 == false;
                        let mut v421: bool = if v419 {
                            false
                        } else {
                            let mut v420: bool = 30i32 >= v417;
                            v420
                        };
                        let mut v422: bool = v421 == false;
                        let mut v473: US2 = if v422 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v403); };
                            let (mut v426, mut v427, mut v428, mut v429, mut v430, mut v431): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v405) };
                            let mut v432: Rc<str> = method3(v426.clone(), v427.clone(), v428.clone(), v429.clone(), v430.clone(), v431.clone());
                            let mut v433: Rc<str> = method4();
                            let mut v434: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map"); } LIT.with(|lit| lit.clone()) };
                            let mut v435: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                            let mut v436: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not"); } LIT.with(|lit| lit.clone()) };
                            let mut v437: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                            let mut v438: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.run / par_map / origin_hash |> sm'.contains local_git_hash |> not / Some hash2 when hash1 = hash2"); } LIT.with(|lit| lit.clone()) };
                            let mut v439: bool = v438.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                            let mut v441: Rc<str> = if v439 {
                                v163.clone()
                            } else {
                                method164(v426.clone(), v427.clone(), v428.clone(), v429.clone(), v430.clone(), v431.clone(), v432.clone(), v433.clone(), v438.clone(), v35.clone(), v37.clone(), v34.clone(), v49, v50.clone(), v62, v63.clone(), v221.clone(), v300.clone(), v52.clone(), v65.clone())
                            };
                            { let _ = spiral_trace_hold(&v403); };
                            let (mut v444, mut v445, mut v446, mut v447, mut v448, mut v449): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v405) };
                            let mut v450: i64 = v444.borrow().l0.clone();
                            let mut v451: i64 = v450 + 1i64;
                            v444.borrow_mut().l0 = v451;
                            let mut v452: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let mut v453: bool = cfg!(target_arch = "wasm32");
                            if v453 {
                                let mut v454: Rc<str> = v447.borrow().l0.clone();
                                let mut v455: bool = v454.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v463: Rc<str> = if v455 {
                                    v441.clone()
                                } else {
                                    let mut v456: bool = v441.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v456 {
                                        let mut v457: Rc<str> = v447.borrow().l0.clone();
                                        v457.clone()
                                    } else {
                                        let mut v458: Rc<str> = v447.borrow().l0.clone();
                                        let mut v459: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v460: Rc<str> = Rc::<str>::from(format!("{}{}", v458, v459));
                                        let mut v461: Rc<str> = Rc::<str>::from(format!("{}{}", v460, v441));
                                        v461.clone()
                                    }
                                };
                                let mut v465: i32 = ((v463.chars().count() + 14999) / 15000) as i32;
                                let mut v466: bool = v441 != v163 ;
                                let mut v468: bool = if v466 {
                                    let mut v467: bool = v465 <= 1i32;
                                    v467
                                } else {
                                    false
                                };
                                if v468 {
                                    v447.borrow_mut().l0 = v463.clone();
                                    ()
                                } else {
                                    v447.borrow_mut().l0 = v163.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v463); };
                                    ()
                                }
                            } else {
                                println!("{}", v441);
                                ()
                            };
                            let mut v471: Rc<dyn Fn(Rc<str>) -> ()> = v445.borrow().l0.clone();
                            v471(v441.clone());
                            US2::US2_0(v444.clone(), v445.clone(), v446.clone(), v447.clone(), v448.clone(), v449.clone())
                        };
                        method177(v65.clone(), v52.clone());
                        let mut v474: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure64(v5.clone(), v4.clone(), v2.clone(), v1.clone(), v0);
                        let mut v475: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_0); } CASE.with(|case| case.clone()) };
                        let mut v476: Rc<UH2> = Rc::new(UH2::UH2_1(v66.clone(), v52.clone(), v474.clone(), v475.clone()));
                        let mut v477: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("html"); } LIT.with(|lit| lit.clone()) };
                        let mut v478: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v69);
                        let mut v479: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("pdf"); } LIT.with(|lit| lit.clone()) };
                        let mut v480: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v70);
                        let mut v481: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epub"); } LIT.with(|lit| lit.clone()) };
                        let mut v482: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v71);
                        let mut v483: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v72);
                        let mut v484: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v73);
                        let mut v485: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v74);
                        let mut v486: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_0); } CASE.with(|case| case.clone()) };
                        let mut v487: Rc<UH2> = Rc::new(UH2::UH2_1(v481.clone(), v67.clone(), v485.clone(), v486.clone()));
                        let mut v488: Rc<UH2> = Rc::new(UH2::UH2_1(v479.clone(), v67.clone(), v484.clone(), v487.clone()));
                        let mut v489: Rc<UH2> = Rc::new(UH2::UH2_1(v477.clone(), v67.clone(), v483.clone(), v488.clone()));
                        let mut v490: Rc<UH2> = Rc::new(UH2::UH2_1(v481.clone(), v52.clone(), v482.clone(), v489.clone()));
                        let mut v491: Rc<UH2> = Rc::new(UH2::UH2_1(v479.clone(), v52.clone(), v480.clone(), v490.clone()));
                        let mut v492: Rc<UH2> = Rc::new(UH2::UH2_1(v477.clone(), v52.clone(), v478.clone(), v491.clone()));
                        let mut v493: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_0); } CASE.with(|case| case.clone()) };
                        let mut v494: Rc<UH1> = Rc::new(UH1::UH1_1(v492.clone(), v493.clone()));
                        Rc::new(UH1::UH1_1(v476.clone(), v494.clone()))
                    }
                }
            };
            let mut v498: bool = match &*v497 {
                UH1::UH1_0 => { // Nil
                    true
                }
                _ => {
                    false
                }
            };
            let mut v499: bool = v498 != true;
            let mut v1045: Rc<UH1> = if v499 {
                v497.clone()
            } else {
                let mut v500: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("epub"); } LIT.with(|lit| lit.clone()) };
                let (mut v501, mut v502): (Rc<str>, Rc<str>) = method156(v500.clone(), v67.clone(), v5.clone());
                let mut v503: bool = method35(v501.clone());
                let mut v576: bool = if v503 {
                    true
                } else {
                    let mut v504: bool = method35(v502.clone());
                    let mut v505: bool = v504 == false;
                    if v505 {
                        true
                    } else {
                        let mut v510: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                        { let _ = spiral_trace_hold(&v510); };
                        let mut v512: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v513, mut v514, mut v515, mut v516, mut v517, mut v518): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v512) };
                        let mut v519: US0 = v517.borrow().l0.clone();
                        let mut v524: i32 = match &v519 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
                        };
                        let mut v525: bool = v515.borrow().l0.clone();
                        let mut v526: bool = v525 == false;
                        let mut v528: bool = if v526 {
                            false
                        } else {
                            let mut v527: bool = 30i32 >= v524;
                            v527
                        };
                        let mut v529: bool = v528 == false;
                        let mut v574: US2 = if v529 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v510); };
                            let (mut v533, mut v534, mut v535, mut v536, mut v537, mut v538): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v512) };
                            let mut v539: Rc<str> = method3(v533.clone(), v534.clone(), v535.clone(), v536.clone(), v537.clone(), v538.clone());
                            let mut v540: Rc<str> = method4();
                            let mut v541: Rc<str> = method203(v533.clone(), v534.clone(), v535.clone(), v536.clone(), v537.clone(), v538.clone(), v539.clone(), v540.clone(), v501.clone(), v502.clone());
                            { let _ = spiral_trace_hold(&v510); };
                            let (mut v544, mut v545, mut v546, mut v547, mut v548, mut v549): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v512) };
                            let mut v550: i64 = v544.borrow().l0.clone();
                            let mut v551: i64 = v550 + 1i64;
                            v544.borrow_mut().l0 = v551;
                            let mut v552: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let mut v553: bool = cfg!(target_arch = "wasm32");
                            if v553 {
                                let mut v554: Rc<str> = v547.borrow().l0.clone();
                                let mut v555: bool = v554.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v563: Rc<str> = if v555 {
                                    v541.clone()
                                } else {
                                    let mut v556: bool = v541.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v556 {
                                        let mut v557: Rc<str> = v547.borrow().l0.clone();
                                        v557.clone()
                                    } else {
                                        let mut v558: Rc<str> = v547.borrow().l0.clone();
                                        let mut v559: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v560: Rc<str> = Rc::<str>::from(format!("{}{}", v558, v559));
                                        let mut v561: Rc<str> = Rc::<str>::from(format!("{}{}", v560, v541));
                                        v561.clone()
                                    }
                                };
                                let mut v565: i32 = ((v563.chars().count() + 14999) / 15000) as i32;
                                let mut v566: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v567: bool = v541 != v566 ;
                                let mut v569: bool = if v567 {
                                    let mut v568: bool = v565 <= 1i32;
                                    v568
                                } else {
                                    false
                                };
                                if v569 {
                                    v547.borrow_mut().l0 = v563.clone();
                                    ()
                                } else {
                                    v547.borrow_mut().l0 = v566.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v563); };
                                    ()
                                }
                            } else {
                                println!("{}", v541);
                                ()
                            };
                            let mut v572: Rc<dyn Fn(Rc<str>) -> ()> = v545.borrow().l0.clone();
                            v572(v541.clone());
                            US2::US2_0(v544.clone(), v545.clone(), v546.clone(), v547.clone(), v548.clone(), v549.clone())
                        };
                        method177(v501.clone(), v502.clone());
                        false
                    }
                };
                let mut v581: Rc<UH2> = if v576 {
                    let mut v577: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v74);
                    let mut v578: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_0); } CASE.with(|case| case.clone()) };
                    Rc::new(UH2::UH2_1(v500.clone(), v67.clone(), v577.clone(), v578.clone()))
                } else {
                    { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_0); } CASE.with(|case| case.clone()) }
                };
                let mut v582: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("pdf"); } LIT.with(|lit| lit.clone()) };
                let (mut v583, mut v584): (Rc<str>, Rc<str>) = method156(v582.clone(), v67.clone(), v5.clone());
                let mut v585: bool = method35(v583.clone());
                let mut v655: bool = if v585 {
                    true
                } else {
                    let mut v586: bool = method35(v584.clone());
                    let mut v587: bool = v586 == false;
                    if v587 {
                        true
                    } else {
                        let mut v589: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                        { let _ = spiral_trace_hold(&v589); };
                        let mut v591: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v592, mut v593, mut v594, mut v595, mut v596, mut v597): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v591) };
                        let mut v598: US0 = v596.borrow().l0.clone();
                        let mut v603: i32 = match &v598 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
                        };
                        let mut v604: bool = v594.borrow().l0.clone();
                        let mut v605: bool = v604 == false;
                        let mut v607: bool = if v605 {
                            false
                        } else {
                            let mut v606: bool = 30i32 >= v603;
                            v606
                        };
                        let mut v608: bool = v607 == false;
                        let mut v653: US2 = if v608 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v589); };
                            let (mut v612, mut v613, mut v614, mut v615, mut v616, mut v617): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v591) };
                            let mut v618: Rc<str> = method3(v612.clone(), v613.clone(), v614.clone(), v615.clone(), v616.clone(), v617.clone());
                            let mut v619: Rc<str> = method4();
                            let mut v620: Rc<str> = method203(v612.clone(), v613.clone(), v614.clone(), v615.clone(), v616.clone(), v617.clone(), v618.clone(), v619.clone(), v583.clone(), v584.clone());
                            { let _ = spiral_trace_hold(&v589); };
                            let (mut v623, mut v624, mut v625, mut v626, mut v627, mut v628): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v591) };
                            let mut v629: i64 = v623.borrow().l0.clone();
                            let mut v630: i64 = v629 + 1i64;
                            v623.borrow_mut().l0 = v630;
                            let mut v631: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let mut v632: bool = cfg!(target_arch = "wasm32");
                            if v632 {
                                let mut v633: Rc<str> = v626.borrow().l0.clone();
                                let mut v634: bool = v633.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v642: Rc<str> = if v634 {
                                    v620.clone()
                                } else {
                                    let mut v635: bool = v620.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v635 {
                                        let mut v636: Rc<str> = v626.borrow().l0.clone();
                                        v636.clone()
                                    } else {
                                        let mut v637: Rc<str> = v626.borrow().l0.clone();
                                        let mut v638: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v639: Rc<str> = Rc::<str>::from(format!("{}{}", v637, v638));
                                        let mut v640: Rc<str> = Rc::<str>::from(format!("{}{}", v639, v620));
                                        v640.clone()
                                    }
                                };
                                let mut v644: i32 = ((v642.chars().count() + 14999) / 15000) as i32;
                                let mut v645: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v646: bool = v620 != v645 ;
                                let mut v648: bool = if v646 {
                                    let mut v647: bool = v644 <= 1i32;
                                    v647
                                } else {
                                    false
                                };
                                if v648 {
                                    v626.borrow_mut().l0 = v642.clone();
                                    ()
                                } else {
                                    v626.borrow_mut().l0 = v645.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v642); };
                                    ()
                                }
                            } else {
                                println!("{}", v620);
                                ()
                            };
                            let mut v651: Rc<dyn Fn(Rc<str>) -> ()> = v624.borrow().l0.clone();
                            v651(v620.clone());
                            US2::US2_0(v623.clone(), v624.clone(), v625.clone(), v626.clone(), v627.clone(), v628.clone())
                        };
                        method177(v583.clone(), v584.clone());
                        false
                    }
                };
                let mut v658: Rc<UH2> = if v655 {
                    let mut v656: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v73);
                    Rc::new(UH2::UH2_1(v582.clone(), v67.clone(), v656.clone(), v581.clone()))
                } else {
                    v581.clone()
                };
                let mut v659: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("html"); } LIT.with(|lit| lit.clone()) };
                let (mut v660, mut v661): (Rc<str>, Rc<str>) = method156(v659.clone(), v67.clone(), v5.clone());
                let mut v662: bool = method35(v660.clone());
                let mut v732: bool = if v662 {
                    true
                } else {
                    let mut v663: bool = method35(v661.clone());
                    let mut v664: bool = v663 == false;
                    if v664 {
                        true
                    } else {
                        let mut v666: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                        { let _ = spiral_trace_hold(&v666); };
                        let mut v668: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v669, mut v670, mut v671, mut v672, mut v673, mut v674): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v668) };
                        let mut v675: US0 = v673.borrow().l0.clone();
                        let mut v680: i32 = match &v675 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
                        };
                        let mut v681: bool = v671.borrow().l0.clone();
                        let mut v682: bool = v681 == false;
                        let mut v684: bool = if v682 {
                            false
                        } else {
                            let mut v683: bool = 30i32 >= v680;
                            v683
                        };
                        let mut v685: bool = v684 == false;
                        let mut v730: US2 = if v685 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v666); };
                            let (mut v689, mut v690, mut v691, mut v692, mut v693, mut v694): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v668) };
                            let mut v695: Rc<str> = method3(v689.clone(), v690.clone(), v691.clone(), v692.clone(), v693.clone(), v694.clone());
                            let mut v696: Rc<str> = method4();
                            let mut v697: Rc<str> = method203(v689.clone(), v690.clone(), v691.clone(), v692.clone(), v693.clone(), v694.clone(), v695.clone(), v696.clone(), v660.clone(), v661.clone());
                            { let _ = spiral_trace_hold(&v666); };
                            let (mut v700, mut v701, mut v702, mut v703, mut v704, mut v705): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v668) };
                            let mut v706: i64 = v700.borrow().l0.clone();
                            let mut v707: i64 = v706 + 1i64;
                            v700.borrow_mut().l0 = v707;
                            let mut v708: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let mut v709: bool = cfg!(target_arch = "wasm32");
                            if v709 {
                                let mut v710: Rc<str> = v703.borrow().l0.clone();
                                let mut v711: bool = v710.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v719: Rc<str> = if v711 {
                                    v697.clone()
                                } else {
                                    let mut v712: bool = v697.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v712 {
                                        let mut v713: Rc<str> = v703.borrow().l0.clone();
                                        v713.clone()
                                    } else {
                                        let mut v714: Rc<str> = v703.borrow().l0.clone();
                                        let mut v715: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v716: Rc<str> = Rc::<str>::from(format!("{}{}", v714, v715));
                                        let mut v717: Rc<str> = Rc::<str>::from(format!("{}{}", v716, v697));
                                        v717.clone()
                                    }
                                };
                                let mut v721: i32 = ((v719.chars().count() + 14999) / 15000) as i32;
                                let mut v722: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v723: bool = v697 != v722 ;
                                let mut v725: bool = if v723 {
                                    let mut v724: bool = v721 <= 1i32;
                                    v724
                                } else {
                                    false
                                };
                                if v725 {
                                    v703.borrow_mut().l0 = v719.clone();
                                    ()
                                } else {
                                    v703.borrow_mut().l0 = v722.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v719); };
                                    ()
                                }
                            } else {
                                println!("{}", v697);
                                ()
                            };
                            let mut v728: Rc<dyn Fn(Rc<str>) -> ()> = v701.borrow().l0.clone();
                            v728(v697.clone());
                            US2::US2_0(v700.clone(), v701.clone(), v702.clone(), v703.clone(), v704.clone(), v705.clone())
                        };
                        method177(v660.clone(), v661.clone());
                        false
                    }
                };
                let mut v735: Rc<UH2> = if v732 {
                    let mut v733: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v72);
                    Rc::new(UH2::UH2_1(v659.clone(), v67.clone(), v733.clone(), v658.clone()))
                } else {
                    v658.clone()
                };
                let (mut v736, mut v737): (Rc<str>, Rc<str>) = method156(v500.clone(), v52.clone(), v5.clone());
                let mut v738: bool = method35(v736.clone());
                let mut v808: bool = if v738 {
                    true
                } else {
                    let mut v739: bool = method35(v737.clone());
                    let mut v740: bool = v739 == false;
                    if v740 {
                        true
                    } else {
                        let mut v742: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                        { let _ = spiral_trace_hold(&v742); };
                        let mut v744: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v745, mut v746, mut v747, mut v748, mut v749, mut v750): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v744) };
                        let mut v751: US0 = v749.borrow().l0.clone();
                        let mut v756: i32 = match &v751 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
                        };
                        let mut v757: bool = v747.borrow().l0.clone();
                        let mut v758: bool = v757 == false;
                        let mut v760: bool = if v758 {
                            false
                        } else {
                            let mut v759: bool = 30i32 >= v756;
                            v759
                        };
                        let mut v761: bool = v760 == false;
                        let mut v806: US2 = if v761 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v742); };
                            let (mut v765, mut v766, mut v767, mut v768, mut v769, mut v770): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v744) };
                            let mut v771: Rc<str> = method3(v765.clone(), v766.clone(), v767.clone(), v768.clone(), v769.clone(), v770.clone());
                            let mut v772: Rc<str> = method4();
                            let mut v773: Rc<str> = method203(v765.clone(), v766.clone(), v767.clone(), v768.clone(), v769.clone(), v770.clone(), v771.clone(), v772.clone(), v736.clone(), v737.clone());
                            { let _ = spiral_trace_hold(&v742); };
                            let (mut v776, mut v777, mut v778, mut v779, mut v780, mut v781): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v744) };
                            let mut v782: i64 = v776.borrow().l0.clone();
                            let mut v783: i64 = v782 + 1i64;
                            v776.borrow_mut().l0 = v783;
                            let mut v784: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let mut v785: bool = cfg!(target_arch = "wasm32");
                            if v785 {
                                let mut v786: Rc<str> = v779.borrow().l0.clone();
                                let mut v787: bool = v786.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v795: Rc<str> = if v787 {
                                    v773.clone()
                                } else {
                                    let mut v788: bool = v773.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v788 {
                                        let mut v789: Rc<str> = v779.borrow().l0.clone();
                                        v789.clone()
                                    } else {
                                        let mut v790: Rc<str> = v779.borrow().l0.clone();
                                        let mut v791: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v792: Rc<str> = Rc::<str>::from(format!("{}{}", v790, v791));
                                        let mut v793: Rc<str> = Rc::<str>::from(format!("{}{}", v792, v773));
                                        v793.clone()
                                    }
                                };
                                let mut v797: i32 = ((v795.chars().count() + 14999) / 15000) as i32;
                                let mut v798: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v799: bool = v773 != v798 ;
                                let mut v801: bool = if v799 {
                                    let mut v800: bool = v797 <= 1i32;
                                    v800
                                } else {
                                    false
                                };
                                if v801 {
                                    v779.borrow_mut().l0 = v795.clone();
                                    ()
                                } else {
                                    v779.borrow_mut().l0 = v798.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v795); };
                                    ()
                                }
                            } else {
                                println!("{}", v773);
                                ()
                            };
                            let mut v804: Rc<dyn Fn(Rc<str>) -> ()> = v777.borrow().l0.clone();
                            v804(v773.clone());
                            US2::US2_0(v776.clone(), v777.clone(), v778.clone(), v779.clone(), v780.clone(), v781.clone())
                        };
                        method177(v736.clone(), v737.clone());
                        false
                    }
                };
                let mut v811: Rc<UH2> = if v808 {
                    let mut v809: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v71);
                    Rc::new(UH2::UH2_1(v500.clone(), v52.clone(), v809.clone(), v735.clone()))
                } else {
                    v735.clone()
                };
                let (mut v812, mut v813): (Rc<str>, Rc<str>) = method156(v582.clone(), v52.clone(), v5.clone());
                let mut v814: bool = method35(v812.clone());
                let mut v884: bool = if v814 {
                    true
                } else {
                    let mut v815: bool = method35(v813.clone());
                    let mut v816: bool = v815 == false;
                    if v816 {
                        true
                    } else {
                        let mut v818: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                        { let _ = spiral_trace_hold(&v818); };
                        let mut v820: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v821, mut v822, mut v823, mut v824, mut v825, mut v826): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v820) };
                        let mut v827: US0 = v825.borrow().l0.clone();
                        let mut v832: i32 = match &v827 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
                        };
                        let mut v833: bool = v823.borrow().l0.clone();
                        let mut v834: bool = v833 == false;
                        let mut v836: bool = if v834 {
                            false
                        } else {
                            let mut v835: bool = 30i32 >= v832;
                            v835
                        };
                        let mut v837: bool = v836 == false;
                        let mut v882: US2 = if v837 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v818); };
                            let (mut v841, mut v842, mut v843, mut v844, mut v845, mut v846): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v820) };
                            let mut v847: Rc<str> = method3(v841.clone(), v842.clone(), v843.clone(), v844.clone(), v845.clone(), v846.clone());
                            let mut v848: Rc<str> = method4();
                            let mut v849: Rc<str> = method203(v841.clone(), v842.clone(), v843.clone(), v844.clone(), v845.clone(), v846.clone(), v847.clone(), v848.clone(), v812.clone(), v813.clone());
                            { let _ = spiral_trace_hold(&v818); };
                            let (mut v852, mut v853, mut v854, mut v855, mut v856, mut v857): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v820) };
                            let mut v858: i64 = v852.borrow().l0.clone();
                            let mut v859: i64 = v858 + 1i64;
                            v852.borrow_mut().l0 = v859;
                            let mut v860: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let mut v861: bool = cfg!(target_arch = "wasm32");
                            if v861 {
                                let mut v862: Rc<str> = v855.borrow().l0.clone();
                                let mut v863: bool = v862.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v871: Rc<str> = if v863 {
                                    v849.clone()
                                } else {
                                    let mut v864: bool = v849.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v864 {
                                        let mut v865: Rc<str> = v855.borrow().l0.clone();
                                        v865.clone()
                                    } else {
                                        let mut v866: Rc<str> = v855.borrow().l0.clone();
                                        let mut v867: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v868: Rc<str> = Rc::<str>::from(format!("{}{}", v866, v867));
                                        let mut v869: Rc<str> = Rc::<str>::from(format!("{}{}", v868, v849));
                                        v869.clone()
                                    }
                                };
                                let mut v873: i32 = ((v871.chars().count() + 14999) / 15000) as i32;
                                let mut v874: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v875: bool = v849 != v874 ;
                                let mut v877: bool = if v875 {
                                    let mut v876: bool = v873 <= 1i32;
                                    v876
                                } else {
                                    false
                                };
                                if v877 {
                                    v855.borrow_mut().l0 = v871.clone();
                                    ()
                                } else {
                                    v855.borrow_mut().l0 = v874.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v871); };
                                    ()
                                }
                            } else {
                                println!("{}", v849);
                                ()
                            };
                            let mut v880: Rc<dyn Fn(Rc<str>) -> ()> = v853.borrow().l0.clone();
                            v880(v849.clone());
                            US2::US2_0(v852.clone(), v853.clone(), v854.clone(), v855.clone(), v856.clone(), v857.clone())
                        };
                        method177(v812.clone(), v813.clone());
                        false
                    }
                };
                let mut v887: Rc<UH2> = if v884 {
                    let mut v885: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v70);
                    Rc::new(UH2::UH2_1(v582.clone(), v52.clone(), v885.clone(), v811.clone()))
                } else {
                    v811.clone()
                };
                let (mut v888, mut v889): (Rc<str>, Rc<str>) = method156(v659.clone(), v52.clone(), v5.clone());
                let mut v890: bool = method35(v888.clone());
                let mut v960: bool = if v890 {
                    true
                } else {
                    let mut v891: bool = method35(v889.clone());
                    let mut v892: bool = v891 == false;
                    if v892 {
                        true
                    } else {
                        let mut v894: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                        { let _ = spiral_trace_hold(&v894); };
                        let mut v896: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v897, mut v898, mut v899, mut v900, mut v901, mut v902): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v896) };
                        let mut v903: US0 = v901.borrow().l0.clone();
                        let mut v908: i32 = match &v903 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
                        };
                        let mut v909: bool = v899.borrow().l0.clone();
                        let mut v910: bool = v909 == false;
                        let mut v912: bool = if v910 {
                            false
                        } else {
                            let mut v911: bool = 30i32 >= v908;
                            v911
                        };
                        let mut v913: bool = v912 == false;
                        let mut v958: US2 = if v913 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v894); };
                            let (mut v917, mut v918, mut v919, mut v920, mut v921, mut v922): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v896) };
                            let mut v923: Rc<str> = method3(v917.clone(), v918.clone(), v919.clone(), v920.clone(), v921.clone(), v922.clone());
                            let mut v924: Rc<str> = method4();
                            let mut v925: Rc<str> = method203(v917.clone(), v918.clone(), v919.clone(), v920.clone(), v921.clone(), v922.clone(), v923.clone(), v924.clone(), v888.clone(), v889.clone());
                            { let _ = spiral_trace_hold(&v894); };
                            let (mut v928, mut v929, mut v930, mut v931, mut v932, mut v933): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v896) };
                            let mut v934: i64 = v928.borrow().l0.clone();
                            let mut v935: i64 = v934 + 1i64;
                            v928.borrow_mut().l0 = v935;
                            let mut v936: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let mut v937: bool = cfg!(target_arch = "wasm32");
                            if v937 {
                                let mut v938: Rc<str> = v931.borrow().l0.clone();
                                let mut v939: bool = v938.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v947: Rc<str> = if v939 {
                                    v925.clone()
                                } else {
                                    let mut v940: bool = v925.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v940 {
                                        let mut v941: Rc<str> = v931.borrow().l0.clone();
                                        v941.clone()
                                    } else {
                                        let mut v942: Rc<str> = v931.borrow().l0.clone();
                                        let mut v943: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v944: Rc<str> = Rc::<str>::from(format!("{}{}", v942, v943));
                                        let mut v945: Rc<str> = Rc::<str>::from(format!("{}{}", v944, v925));
                                        v945.clone()
                                    }
                                };
                                let mut v949: i32 = ((v947.chars().count() + 14999) / 15000) as i32;
                                let mut v950: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v951: bool = v925 != v950 ;
                                let mut v953: bool = if v951 {
                                    let mut v952: bool = v949 <= 1i32;
                                    v952
                                } else {
                                    false
                                };
                                if v953 {
                                    v931.borrow_mut().l0 = v947.clone();
                                    ()
                                } else {
                                    v931.borrow_mut().l0 = v950.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v947); };
                                    ()
                                }
                            } else {
                                println!("{}", v925);
                                ()
                            };
                            let mut v956: Rc<dyn Fn(Rc<str>) -> ()> = v929.borrow().l0.clone();
                            v956(v925.clone());
                            US2::US2_0(v928.clone(), v929.clone(), v930.clone(), v931.clone(), v932.clone(), v933.clone())
                        };
                        method177(v888.clone(), v889.clone());
                        false
                    }
                };
                let mut v963: Rc<UH2> = if v960 {
                    let mut v961: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure67(v5.clone(), v4.clone(), v69);
                    Rc::new(UH2::UH2_1(v659.clone(), v52.clone(), v961.clone(), v887.clone()))
                } else {
                    v887.clone()
                };
                let (mut v964, mut v965): (Rc<str>, Rc<str>) = method156(v66.clone(), v52.clone(), v5.clone());
                let mut v966: bool = method35(v964.clone());
                let mut v1036: bool = if v966 {
                    true
                } else {
                    let mut v967: bool = method35(v965.clone());
                    let mut v968: bool = v967 == false;
                    if v968 {
                        true
                    } else {
                        let mut v970: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
                        { let _ = spiral_trace_hold(&v970); };
                        let mut v972: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
                        let (mut v973, mut v974, mut v975, mut v976, mut v977, mut v978): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v972) };
                        let mut v979: US0 = v977.borrow().l0.clone();
                        let mut v984: i32 = match &v979 {
                            US0::US0_4 => { // Critical
                                50i32
                            }
                            US0::US0_1 => { // Debug
                                20i32
                            }
                            US0::US0_2 => { // Info
                                30i32
                            }
                            US0::US0_0 => { // Verbose
                                10i32
                            }
                            US0::US0_3 => { // Warning
                                40i32
                            }
                            _ => unreachable!(),
                        };
                        let mut v985: bool = v975.borrow().l0.clone();
                        let mut v986: bool = v985 == false;
                        let mut v988: bool = if v986 {
                            false
                        } else {
                            let mut v987: bool = 30i32 >= v984;
                            v987
                        };
                        let mut v989: bool = v988 == false;
                        let mut v1034: US2 = if v989 {
                            US2::US2_1
                        } else {
                            { let _ = spiral_trace_hold(&v970); };
                            let (mut v993, mut v994, mut v995, mut v996, mut v997, mut v998): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v972) };
                            let mut v999: Rc<str> = method3(v993.clone(), v994.clone(), v995.clone(), v996.clone(), v997.clone(), v998.clone());
                            let mut v1000: Rc<str> = method4();
                            let mut v1001: Rc<str> = method203(v993.clone(), v994.clone(), v995.clone(), v996.clone(), v997.clone(), v998.clone(), v999.clone(), v1000.clone(), v964.clone(), v965.clone());
                            { let _ = spiral_trace_hold(&v970); };
                            let (mut v1004, mut v1005, mut v1006, mut v1007, mut v1008, mut v1009): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v972) };
                            let mut v1010: i64 = v1004.borrow().l0.clone();
                            let mut v1011: i64 = v1010 + 1i64;
                            v1004.borrow_mut().l0 = v1011;
                            let mut v1012: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                            let mut v1013: bool = cfg!(target_arch = "wasm32");
                            if v1013 {
                                let mut v1014: Rc<str> = v1007.borrow().l0.clone();
                                let mut v1015: bool = v1014.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v1023: Rc<str> = if v1015 {
                                    v1001.clone()
                                } else {
                                    let mut v1016: bool = v1001.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                    if v1016 {
                                        let mut v1017: Rc<str> = v1007.borrow().l0.clone();
                                        v1017.clone()
                                    } else {
                                        let mut v1018: Rc<str> = v1007.borrow().l0.clone();
                                        let mut v1019: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                                        let mut v1020: Rc<str> = Rc::<str>::from(format!("{}{}", v1018, v1019));
                                        let mut v1021: Rc<str> = Rc::<str>::from(format!("{}{}", v1020, v1001));
                                        v1021.clone()
                                    }
                                };
                                let mut v1025: i32 = ((v1023.chars().count() + 14999) / 15000) as i32;
                                let mut v1026: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                                let mut v1027: bool = v1001 != v1026 ;
                                let mut v1029: bool = if v1027 {
                                    let mut v1028: bool = v1025 <= 1i32;
                                    v1028
                                } else {
                                    false
                                };
                                if v1029 {
                                    v1007.borrow_mut().l0 = v1023.clone();
                                    ()
                                } else {
                                    v1007.borrow_mut().l0 = v1026.clone();
                                    { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v1023); };
                                    ()
                                }
                            } else {
                                println!("{}", v1001);
                                ()
                            };
                            let mut v1032: Rc<dyn Fn(Rc<str>) -> ()> = v1005.borrow().l0.clone();
                            v1032(v1001.clone());
                            US2::US2_0(v1004.clone(), v1005.clone(), v1006.clone(), v1007.clone(), v1008.clone(), v1009.clone())
                        };
                        method177(v964.clone(), v965.clone());
                        false
                    }
                };
                let mut v1041: Rc<UH2> = if v1036 {
                    let mut v1037: Rc<dyn Fn(Rc<str>) -> Rc<dyn Fn(Rc<str>) -> US24>> = closure64(v5.clone(), v4.clone(), v2.clone(), v1.clone(), v0);
                    let mut v1038: Rc<UH2> = { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_0); } CASE.with(|case| case.clone()) };
                    Rc::new(UH2::UH2_1(v66.clone(), v52.clone(), v1037.clone(), v1038.clone()))
                } else {
                    { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_0); } CASE.with(|case| case.clone()) }
                };
                let mut v1042: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_0); } CASE.with(|case| case.clone()) };
                let mut v1043: Rc<UH1> = Rc::new(UH1::UH1_1(v963.clone(), v1042.clone()));
                Rc::new(UH1::UH1_1(v1041.clone(), v1043.clone()))
            };
            let mut v1058: Rc<RefCell<Vec<Rc<UH2>>>> = Rc::new(RefCell::new(Vec::new()));
            let mut v1059: i32 = 0i32;
            let mut v1060: i32 = method206(v1058.clone(), v1045.clone(), v1059);
            let mut v1061: Rc<Vec<Rc<UH2>>> = Rc::new(v1058.borrow().clone());
            let mut v1064: Rc<RefCell<Vec<Rc<UH2>>>> = Rc::new(RefCell::new((v1061).as_ref().clone()));
            let mut v1067: Vec<Rc<UH2>> = (v1064).borrow().clone();
            let mut v1068: Rc<RefCell<Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>>> = Rc::new(RefCell::new(vec![]));
            let mut v1071: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = (v1068).borrow().clone();
            let mut v1074: Vec<Rc<UH2>> = method207(v1067.clone());
            let mut v1075: Rc<RefCell<Vec<Rc<UH2>>>> = Rc::new(RefCell::new(v1074));
            let mut v1077: Rc<Vec<Rc<UH2>>> = Rc::new((v1075).borrow().clone());
            let mut v1084: i32 = (v1077).len() as i32;
            let mut v1085: i32 = v1084 - 1i32;
            let mut v1086: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_0); } CASE.with(|case| case.clone()) };
            let mut v1087: Rc<UH1> = method208(v1077.clone(), v1085, v1086.clone());
            let mut v1088: Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>> = method209(v1087.clone(), v1071.clone());
            let (mut v1090, mut v1091): (Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) = method216(v35.clone(), v1088.clone());
            let mut v1092: (Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>) = (v1090, v1091);
            let mut v1094: Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String> = Ok::<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>(v1092);
            let mut v1095: Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String> = method217(v1094.clone());
            let mut v1096: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = method218(v9.clone());
            let mut v1098: bool = true; let mut v1096 = v1096;
            let mut v1100: bool = true; v1096.push(v1095);
            let mut v1102: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = v1096;
            (v0, v1, v2, v3, v4, v5, v6, v7, v8, v9) = (v0, v1.clone(), v2.clone(), v3.clone(), v4.clone(), v5.clone(), v6.clone(), v7, v11, v1102.clone());
            continue;
        } else {
            return v9.clone();
        }
    }
}
fn method25(mut v0: bool, mut v1: US4, mut v2: Rc<str>, mut v3: Rc<str>, mut v4: Rc<str>, mut v5: Rc<str>) -> std::pin::Pin<Box<dyn std::future::Future<Output = Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>>>> {
    let mut v6: Rc<str> = method26();
    let mut v7: US4 = method28(v6.clone());
    let mut v20: US4 = match &v7 {
        US4::US4_1 => { // None
            let mut v17: Rc<str> = Rc::<str>::from(env!("CARGO_MANIFEST_DIR"));
            method28(v17.clone())
        }
        US4::US4_0(v8) => { // Some
            let mut v8: Rc<str> = v8.clone();
            US4::US4_0(v8.clone())
        }
        _ => unreachable!(),
    };
    let mut v26: US4 = match &v20 {
        US4::US4_1 => { // None
            let mut v23: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("/workspaces"); } LIT.with(|lit| lit.clone()) };
            method28(v23.clone())
        }
        US4::US4_0(v21) => { // Some
            let mut v21: Rc<str> = v21.clone();
            US4::US4_0(v21.clone())
        }
        _ => unreachable!(),
    };
    let mut v30: Rc<str> = match &v26 {
        US4::US4_1 => { // None
            std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
        }
        US4::US4_0(v27) => { // Some
            let mut v27: Rc<str> = v27.clone();
            v27.clone()
        }
        _ => unreachable!(),
    };
    let mut v31: Rc<str> = method47(v30.clone());
    let mut v32: bool = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("deps"); } LIT.with(|lit| lit.clone()) } == v31.clone();
    let mut v41: Rc<str> = if v32 {
        let mut v33: Option<Rc<str>> = method33(v30.clone());
        let mut v35: Rc<str> = v33.unwrap();
        let mut v36: US4 = method28(v35.clone());
        match &v36 {
            US4::US4_1 => { // None
                std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
            }
            US4::US4_0(v37) => { // Some
                let mut v37: Rc<str> = v37.clone();
                v37.clone()
            }
            _ => unreachable!(),
        }
    } else {
        v30.clone()
    };
    let mut v42: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("polyglot"); } LIT.with(|lit| lit.clone()) };
    let mut v43: Rc<str> = method29(v41.clone(), v42.clone());
    let mut v44: Rc<str> = method58(v5.clone());
    let mut v45: Rc<str> = method58(v4.clone());
    let mut v46: Rc<str> = method58(v3.clone());
    let mut v51: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
    { let _ = spiral_trace_hold(&v51); };
    let mut v53: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
    let (mut v54, mut v55, mut v56, mut v57, mut v58, mut v59): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v53) };
    let mut v60: US0 = v58.borrow().l0.clone();
    let mut v65: i32 = match &v60 {
        US0::US0_4 => { // Critical
            50i32
        }
        US0::US0_1 => { // Debug
            20i32
        }
        US0::US0_2 => { // Info
            30i32
        }
        US0::US0_0 => { // Verbose
            10i32
        }
        US0::US0_3 => { // Warning
            40i32
        }
        _ => unreachable!(),
    };
    let mut v66: bool = v56.borrow().l0.clone();
    let mut v67: bool = v66 == false;
    let mut v69: bool = if v67 {
        false
    } else {
        let mut v68: bool = 20i32 >= v65;
        v68
    };
    let mut v70: bool = v69 == false;
    let mut v115: US2 = if v70 {
        US2::US2_1
    } else {
        { let _ = spiral_trace_hold(&v51); };
        let (mut v74, mut v75, mut v76, mut v77, mut v78, mut v79): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v53) };
        let mut v80: Rc<str> = method3(v74.clone(), v75.clone(), v76.clone(), v77.clone(), v78.clone(), v79.clone());
        let mut v81: Rc<str> = method62();
        let mut v82: Rc<str> = method63(v74.clone(), v75.clone(), v76.clone(), v77.clone(), v78.clone(), v79.clone(), v80.clone(), v81.clone(), v44.clone(), v45.clone(), v46.clone(), v2.clone(), v1.clone(), v0);
        { let _ = spiral_trace_hold(&v51); };
        let (mut v85, mut v86, mut v87, mut v88, mut v89, mut v90): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v53) };
        let mut v91: i64 = v85.borrow().l0.clone();
        let mut v92: i64 = v91 + 1i64;
        v85.borrow_mut().l0 = v92;
        let mut v93: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let mut v94: bool = cfg!(target_arch = "wasm32");
        if v94 {
            let mut v95: Rc<str> = v88.borrow().l0.clone();
            let mut v96: bool = v95.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v104: Rc<str> = if v96 {
                v82.clone()
            } else {
                let mut v97: bool = v82.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v97 {
                    let mut v98: Rc<str> = v88.borrow().l0.clone();
                    v98.clone()
                } else {
                    let mut v99: Rc<str> = v88.borrow().l0.clone();
                    let mut v100: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let mut v101: Rc<str> = Rc::<str>::from(format!("{}{}", v99, v100));
                    let mut v102: Rc<str> = Rc::<str>::from(format!("{}{}", v101, v82));
                    v102.clone()
                }
            };
            let mut v106: i32 = ((v104.chars().count() + 14999) / 15000) as i32;
            let mut v107: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v108: bool = v82 != v107 ;
            let mut v110: bool = if v108 {
                let mut v109: bool = v106 <= 1i32;
                v109
            } else {
                false
            };
            if v110 {
                v88.borrow_mut().l0 = v104.clone();
                ()
            } else {
                v88.borrow_mut().l0 = v107.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v104); };
                ()
            }
        } else {
            println!("{}", v82);
            ()
        };
        let mut v113: Rc<dyn Fn(Rc<str>) -> ()> = v86.borrow().l0.clone();
        v113(v82.clone());
        US2::US2_0(v85.clone(), v86.clone(), v87.clone(), v88.clone(), v89.clone(), v90.clone())
    };
    let mut v117: bool = true; let __future_init = Box::pin(/*;
    let mut v119: bool = */ async move { /*;
    let mut v121: bool = */ ();
    let (mut v188, mut v189): (Rc<str>, bool) = match &v1 {
        US4::US4_1 => { // None
            let mut v185: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            (v185.clone(), false)
        }
        US4::US4_0(v184) => { // Some
            let mut v184: Rc<str> = v184.clone();
            (v184.clone(), true)
        }
        _ => unreachable!(),
    };
    let mut v190: Vec<Rc<str>> = { let mut out: Vec<Rc<str>> = Vec::new(); let mut stack = vec![std::path::PathBuf::from(&*v45)]; while let Some(dir) = stack.pop() { if let Ok(entries) = std::fs::read_dir(&dir) { for entry in entries.flatten() { let path = entry.path(); if path.is_dir() { stack.push(path) } else { let s = path.display().to_string(); if s.ends_with(".md") && !s.ends_with(".hangul.md") && (!v189 || s.contains(&*v188)) { out.push(Rc::from(s.as_str())) } } } } } out };
    { let _ = spiral_trace_hold(&v51); };
    let (mut v196, mut v197, mut v198, mut v199, mut v200, mut v201): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v53) };
    let mut v202: US0 = v200.borrow().l0.clone();
    let mut v207: i32 = match &v202 {
        US0::US0_4 => { // Critical
            50i32
        }
        US0::US0_1 => { // Debug
            20i32
        }
        US0::US0_2 => { // Info
            30i32
        }
        US0::US0_0 => { // Verbose
            10i32
        }
        US0::US0_3 => { // Warning
            40i32
        }
        _ => unreachable!(),
    };
    let mut v208: bool = v198.borrow().l0.clone();
    let mut v209: bool = v208 == false;
    let mut v211: bool = if v209 {
        false
    } else {
        let mut v210: bool = 20i32 >= v207;
        v210
    };
    let mut v212: bool = v211 == false;
    let mut v258: US2 = if v212 {
        US2::US2_1
    } else {
        { let _ = spiral_trace_hold(&v51); };
        let (mut v216, mut v217, mut v218, mut v219, mut v220, mut v221): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v53) };
        let mut v222: Rc<str> = method3(v216.clone(), v217.clone(), v218.clone(), v219.clone(), v220.clone(), v221.clone());
        let mut v223: Rc<str> = method62();
        let mut v224: usize = ((v190).len() as usize);
        let mut v225: Rc<str> = method72(v216.clone(), v217.clone(), v218.clone(), v219.clone(), v220.clone(), v221.clone(), v222.clone(), v223.clone(), v224.clone());
        { let _ = spiral_trace_hold(&v51); };
        let (mut v228, mut v229, mut v230, mut v231, mut v232, mut v233): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v53) };
        let mut v234: i64 = v228.borrow().l0.clone();
        let mut v235: i64 = v234 + 1i64;
        v228.borrow_mut().l0 = v235;
        let mut v236: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let mut v237: bool = cfg!(target_arch = "wasm32");
        if v237 {
            let mut v238: Rc<str> = v231.borrow().l0.clone();
            let mut v239: bool = v238.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v247: Rc<str> = if v239 {
                v225.clone()
            } else {
                let mut v240: bool = v225.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v240 {
                    let mut v241: Rc<str> = v231.borrow().l0.clone();
                    v241.clone()
                } else {
                    let mut v242: Rc<str> = v231.borrow().l0.clone();
                    let mut v243: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let mut v244: Rc<str> = Rc::<str>::from(format!("{}{}", v242, v243));
                    let mut v245: Rc<str> = Rc::<str>::from(format!("{}{}", v244, v225));
                    v245.clone()
                }
            };
            let mut v249: i32 = ((v247.chars().count() + 14999) / 15000) as i32;
            let mut v250: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v251: bool = v225 != v250 ;
            let mut v253: bool = if v251 {
                let mut v252: bool = v249 <= 1i32;
                v252
            } else {
                false
            };
            if v253 {
                v231.borrow_mut().l0 = v247.clone();
                ()
            } else {
                v231.borrow_mut().l0 = v250.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v247); };
                ()
            }
        } else {
            println!("{}", v225);
            ()
        };
        let mut v256: Rc<dyn Fn(Rc<str>) -> ()> = v229.borrow().l0.clone();
        v256(v225.clone());
        US2::US2_0(v228.clone(), v229.clone(), v230.clone(), v231.clone(), v232.clone(), v233.clone())
    };
    let mut v261: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(v190.clone()));
    let mut v265: Rc<RefCell<Vec<Rc<str>>>> = (v261);
    let mut v266: i32 = (v265.borrow().len() as i32);
    let mut v267: i32 = 0i32;
    let mut v268: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = Vec::new();
    let mut v269: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = method75(v0, v2.clone(), v43.clone(), v44.clone(), v45.clone(), v46.clone(), v265.clone(), v266, v267, v268.clone());
    let mut v270: Rc<RefCell<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>>> = Rc::new(RefCell::new(v269));
    let mut v273: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = (v270).borrow().clone();
    let mut v275: Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String> = Ok::<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>(v273);
    let mut v291: bool = true; (v275) }); //;
    let mut v293: _ = __future_init;
    let mut v295: std::pin::Pin<Box<dyn std::future::Future<Output = Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>>>> = v293;
    v295
}
fn closure69() -> Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US28> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US28> = Rc::new(move |mut v0: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>| -> US28 {
        US28::US28_0(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method219() -> Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US28> {
    closure69()
}
fn closure70() -> Rc<dyn Fn(std::string::String) -> US28> {
    thread_local!{ static CLOSURE: Rc<dyn Fn(std::string::String) -> US28> = Rc::new(move |mut v0: std::string::String| -> US28 {
        US28::US28_1(v0.clone())
    }); }
    CLOSURE.with(|closure| closure.clone())
}
fn method220() -> Rc<dyn Fn(std::string::String) -> US28> {
    closure70()
}
fn method222(mut v0: std::string::String) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    method13(v2.clone());
    method42(v2.clone());
    method15(v2.clone());
    let mut v4: std::string::String = format!("{:#?}", v0);
    let mut v6: Rc<str> = Rc::<str>::from(v4);
    method6(v2.clone(), v6.clone());
    method16(v2.clone());
    let mut v7: Rc<str> = v2.borrow().l0.clone();
    v7.clone()
}
fn method221(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: std::string::String) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = method11(v9);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v10));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.main"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = method222(v8.clone());
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    method8(v21.clone())
}
fn method224(mut v0: usize) -> Rc<str> {
    let mut v1: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
    let mut v2: Rc<RefCell<Mut3>> = Rc::new(RefCell::new(Mut3 { l0: v1.clone() }));
    method13(v2.clone());
    method194(v2.clone());
    method15(v2.clone());
    let mut v4: std::string::String = format!("{:#?}", v0);
    let mut v6: Rc<str> = Rc::<str>::from(v4);
    method6(v2.clone(), v6.clone());
    method16(v2.clone());
    let mut v7: Rc<str> = v2.borrow().l0.clone();
    v7.clone()
}
fn method223(mut v0: Rc<RefCell<Mut0>>, mut v1: Rc<RefCell<Mut1>>, mut v2: Rc<RefCell<Mut2>>, mut v3: Rc<RefCell<Mut3>>, mut v4: Rc<RefCell<Mut4>>, mut v5: Option<i64>, mut v6: Rc<str>, mut v7: Rc<str>, mut v8: usize) -> Rc<str> {
    let mut v9: i64 = v0.borrow().l0.clone();
    let mut v10: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" "); } LIT.with(|lit| lit.clone()) };
    let mut v11: Rc<str> = Rc::<str>::from(format!("{}{}", v6, v10));
    let mut v12: Rc<str> = method11(v9);
    let mut v13: Rc<str> = Rc::<str>::from(format!("{}{}", v11, v12));
    let mut v14: Rc<str> = Rc::<str>::from(format!("{}{}", v13, v7));
    let mut v15: Rc<str> = Rc::<str>::from(format!("{}{}", v14, v10));
    let mut v16: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("documents.main"); } LIT.with(|lit| lit.clone()) };
    let mut v17: Rc<str> = Rc::<str>::from(format!("{}{}", v15, v16));
    let mut v18: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(" / "); } LIT.with(|lit| lit.clone()) };
    let mut v19: Rc<str> = Rc::<str>::from(format!("{}{}", v17, v18));
    let mut v20: Rc<str> = method224(v8.clone());
    let mut v21: Rc<str> = Rc::<str>::from(format!("{}{}", v19, v20));
    method8(v21.clone())
}
fn spiral_main() -> i32 {
    let mut v10: Rc<RefCell<Vec<Rc<str>>>> = Rc::new(RefCell::new(std::env::args().skip(1).map(|x| Rc::<str>::from(x)).collect::<Vec<Rc<str>>>()));
    let mut v15: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure0();
    { let _ = spiral_trace_hold(&v15); };
    let mut v20: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure2();
    { let _ = spiral_trace_hold(&v20); };
    let mut v22: Rc<dyn Fn() -> (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>)> = closure3();
    let (mut v23, mut v24, mut v25, mut v26, mut v27, mut v28): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v22) };
    let mut v29: US0 = v27.borrow().l0.clone();
    let mut v34: i32 = match &v29 {
        US0::US0_4 => { // Critical
            50i32
        }
        US0::US0_1 => { // Debug
            20i32
        }
        US0::US0_2 => { // Info
            30i32
        }
        US0::US0_0 => { // Verbose
            10i32
        }
        US0::US0_3 => { // Warning
            40i32
        }
        _ => unreachable!(),
    };
    let mut v35: bool = v25.borrow().l0.clone();
    let mut v36: bool = v35 == false;
    let mut v38: bool = if v36 {
        false
    } else {
        let mut v37: bool = 30i32 >= v34;
        v37
    };
    let mut v39: bool = v38 == false;
    let mut v84: US2 = if v39 {
        US2::US2_1
    } else {
        { let _ = spiral_trace_hold(&v20); };
        let (mut v43, mut v44, mut v45, mut v46, mut v47, mut v48): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v22) };
        let mut v49: Rc<str> = method3(v43.clone(), v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone());
        let mut v50: Rc<str> = method4();
        let mut v51: Rc<str> = method7(v43.clone(), v44.clone(), v45.clone(), v46.clone(), v47.clone(), v48.clone(), v49.clone(), v50.clone(), v10.clone());
        { let _ = spiral_trace_hold(&v20); };
        let (mut v54, mut v55, mut v56, mut v57, mut v58, mut v59): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v22) };
        let mut v60: i64 = v54.borrow().l0.clone();
        let mut v61: i64 = v60 + 1i64;
        v54.borrow_mut().l0 = v61;
        let mut v62: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
        let mut v63: bool = cfg!(target_arch = "wasm32");
        if v63 {
            let mut v64: Rc<str> = v57.borrow().l0.clone();
            let mut v65: bool = v64.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v73: Rc<str> = if v65 {
                v51.clone()
            } else {
                let mut v66: bool = v51.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                if v66 {
                    let mut v67: Rc<str> = v57.borrow().l0.clone();
                    v67.clone()
                } else {
                    let mut v68: Rc<str> = v57.borrow().l0.clone();
                    let mut v69: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                    let mut v70: Rc<str> = Rc::<str>::from(format!("{}{}", v68, v69));
                    let mut v71: Rc<str> = Rc::<str>::from(format!("{}{}", v70, v51));
                    v71.clone()
                }
            };
            let mut v75: i32 = ((v73.chars().count() + 14999) / 15000) as i32;
            let mut v76: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
            let mut v77: bool = v51 != v76 ;
            let mut v79: bool = if v77 {
                let mut v78: bool = v75 <= 1i32;
                v78
            } else {
                false
            };
            if v79 {
                v57.borrow_mut().l0 = v73.clone();
                ()
            } else {
                v57.borrow_mut().l0 = v76.clone();
                { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v73); };
                ()
            }
        } else {
            println!("{}", v51);
            ()
        };
        let mut v82: Rc<dyn Fn(Rc<str>) -> ()> = v55.borrow().l0.clone();
        v82(v51.clone());
        US2::US2_0(v54.clone(), v55.clone(), v56.clone(), v57.clone(), v58.clone(), v59.clone())
    };
    let mut v85: clap::Command = method17();
    let mut v87: clap::ArgMatches = clap::Command::get_matches(v85);
    let mut v88: Rc<str> = method18();
    let mut v90: &str = &*v88;
    let mut v92: Option<std::string::String> = clap::ArgMatches::get_one(&v87, v90).cloned();
    let mut v95: Option<std::string::String> = method19(v92.clone());
    let mut v96: Rc<dyn Fn((std::string::String)) -> US3> = closure5();
    let mut v97: Option<US3> = v95.map(|x| v96(x));
    let mut v100: US3 = US3::US3_1;
    let mut v101: US3 = v97.unwrap_or(v100);
    let mut v105: std::string::String = match &v101 {
        US3::US3_1 => { // None
            std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
        }
        US3::US3_0(v102) => { // Some
            let mut v102: std::string::String = v102.clone();
            v102.clone()
        }
        _ => unreachable!(),
    };
    let mut v107: Rc<str> = Rc::<str>::from(String::as_str(&v105));
    let mut v108: Rc<str> = method20();
    let mut v110: &str = &*v108;
    let mut v112: Option<std::string::String> = clap::ArgMatches::get_one(&v87, v110).cloned();
    let mut v113: Option<std::string::String> = method19(v112.clone());
    let mut v114: Option<US3> = v113.map(|x| v96(x));
    let mut v115: US3 = US3::US3_1;
    let mut v116: US3 = v114.unwrap_or(v115);
    let mut v120: std::string::String = match &v116 {
        US3::US3_1 => { // None
            std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
        }
        US3::US3_0(v117) => { // Some
            let mut v117: std::string::String = v117.clone();
            v117.clone()
        }
        _ => unreachable!(),
    };
    let mut v122: Rc<str> = Rc::<str>::from(String::as_str(&v120));
    let mut v123: Rc<str> = method21();
    let mut v125: &str = &*v123;
    let mut v127: Option<std::string::String> = clap::ArgMatches::get_one(&v87, v125).cloned();
    let mut v128: Option<std::string::String> = method19(v127.clone());
    let mut v129: Option<US3> = v128.map(|x| v96(x));
    let mut v130: US3 = US3::US3_1;
    let mut v131: US3 = v129.unwrap_or(v130);
    let mut v135: std::string::String = match &v131 {
        US3::US3_1 => { // None
            std::panic::panic_any::<std::string::String>(format!("{}", { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("Option does not have a value."); } LIT.with(|lit| lit.clone()) }))
        }
        US3::US3_0(v132) => { // Some
            let mut v132: std::string::String = v132.clone();
            v132.clone()
        }
        _ => unreachable!(),
    };
    let mut v137: Rc<str> = Rc::<str>::from(String::as_str(&v135));
    let mut v138: Rc<str> = method22();
    let mut v140: &str = &*v138;
    let mut v142: Option<std::string::String> = clap::ArgMatches::get_one(&v87, v140).cloned();
    let mut v143: Option<std::string::String> = method19(v142.clone());
    let mut v144: Option<US3> = v143.map(|x| v96(x));
    let mut v145: US3 = US3::US3_1;
    let mut v146: US3 = v144.unwrap_or(v145);
    let mut v153: US4 = match &v146 {
        US3::US3_1 => { // None
            US4::US4_1
        }
        US3::US3_0(v147) => { // Some
            let mut v147: std::string::String = v147.clone();
            let mut v149: Rc<str> = Rc::<str>::from(String::as_str(&v147));
            US4::US4_0(v149.clone())
        }
        _ => unreachable!(),
    };
    let mut v157: Rc<str> = match &v153 {
        US4::US4_1 => { // None
            let mut v155: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("por-br"); } LIT.with(|lit| lit.clone()) };
            v155.clone()
        }
        US4::US4_0(v154) => { // Some
            let mut v154: Rc<str> = v154.clone();
            v154.clone()
        }
        _ => unreachable!(),
    };
    let mut v158: Rc<str> = method23();
    let mut v160: &str = &*v158;
    let mut v162: Option<std::string::String> = clap::ArgMatches::get_one(&v87, v160).cloned();
    let mut v163: Option<std::string::String> = method19(v162.clone());
    let mut v164: Option<US3> = v163.map(|x| v96(x));
    let mut v165: US3 = US3::US3_1;
    let mut v166: US3 = v164.unwrap_or(v165);
    let mut v173: US4 = match &v166 {
        US3::US3_1 => { // None
            US4::US4_1
        }
        US3::US3_0(v167) => { // Some
            let mut v167: std::string::String = v167.clone();
            let mut v169: Rc<str> = Rc::<str>::from(String::as_str(&v167));
            US4::US4_0(v169.clone())
        }
        _ => unreachable!(),
    };
    let mut v174: Rc<str> = method24();
    let mut v176: &str = &*v174;
    let mut v178: bool = clap::ArgMatches::get_flag(&v87, v176);
    let mut v179: std::pin::Pin<Box<dyn std::future::Future<Output = Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String>>>> = method25(v178, v173.clone(), v157.clone(), v137.clone(), v122.clone(), v107.clone());
    let mut v181: Result<Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>, std::string::String> = futures::executor::block_on(v179);
    let mut v182: Rc<dyn Fn(Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>>) -> US28> = method219();
    let mut v183: Rc<dyn Fn(std::string::String) -> US28> = method220();
    let mut v185: US28 = match v181 { Ok(x) => v182(x), Err(e) => v183(e) };
    let mut v324: i32 = match &v185 {
        US28::US28_1(v255) => { // Error
            let mut v255: std::string::String = v255.clone();
            { let _ = spiral_trace_hold(&v20); };
            let (mut v261, mut v262, mut v263, mut v264, mut v265, mut v266): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v22) };
            let mut v267: US0 = v265.borrow().l0.clone();
            let mut v272: i32 = match &v267 {
                US0::US0_4 => { // Critical
                    50i32
                }
                US0::US0_1 => { // Debug
                    20i32
                }
                US0::US0_2 => { // Info
                    30i32
                }
                US0::US0_0 => { // Verbose
                    10i32
                }
                US0::US0_3 => { // Warning
                    40i32
                }
                _ => unreachable!(),
            };
            let mut v273: bool = v263.borrow().l0.clone();
            let mut v274: bool = v273 == false;
            let mut v276: bool = if v274 {
                false
            } else {
                let mut v275: bool = 50i32 >= v272;
                v275
            };
            let mut v277: bool = v276 == false;
            let mut v322: US2 = if v277 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v20); };
                let (mut v281, mut v282, mut v283, mut v284, mut v285, mut v286): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v22) };
                let mut v287: Rc<str> = method3(v281.clone(), v282.clone(), v283.clone(), v284.clone(), v285.clone(), v286.clone());
                let mut v288: Rc<str> = method139();
                let mut v289: Rc<str> = method221(v281.clone(), v282.clone(), v283.clone(), v284.clone(), v285.clone(), v286.clone(), v287.clone(), v288.clone(), v255.clone());
                { let _ = spiral_trace_hold(&v20); };
                let (mut v292, mut v293, mut v294, mut v295, mut v296, mut v297): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v22) };
                let mut v298: i64 = v292.borrow().l0.clone();
                let mut v299: i64 = v298 + 1i64;
                v292.borrow_mut().l0 = v299;
                let mut v300: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                let mut v301: bool = cfg!(target_arch = "wasm32");
                if v301 {
                    let mut v302: Rc<str> = v295.borrow().l0.clone();
                    let mut v303: bool = v302.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v311: Rc<str> = if v303 {
                        v289.clone()
                    } else {
                        let mut v304: bool = v289.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v304 {
                            let mut v305: Rc<str> = v295.borrow().l0.clone();
                            v305.clone()
                        } else {
                            let mut v306: Rc<str> = v295.borrow().l0.clone();
                            let mut v307: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v308: Rc<str> = Rc::<str>::from(format!("{}{}", v306, v307));
                            let mut v309: Rc<str> = Rc::<str>::from(format!("{}{}", v308, v289));
                            v309.clone()
                        }
                    };
                    let mut v313: i32 = ((v311.chars().count() + 14999) / 15000) as i32;
                    let mut v314: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v315: bool = v289 != v314 ;
                    let mut v317: bool = if v315 {
                        let mut v316: bool = v313 <= 1i32;
                        v316
                    } else {
                        false
                    };
                    if v317 {
                        v295.borrow_mut().l0 = v311.clone();
                        ()
                    } else {
                        v295.borrow_mut().l0 = v314.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v311); };
                        ()
                    }
                } else {
                    println!("{}", v289);
                    ()
                };
                let mut v320: Rc<dyn Fn(Rc<str>) -> ()> = v293.borrow().l0.clone();
                v320(v289.clone());
                US2::US2_0(v292.clone(), v293.clone(), v294.clone(), v295.clone(), v296.clone(), v297.clone())
            };
            1i32
        }
        US28::US28_0(v186) => { // Ok
            let mut v186: Vec<Result<(Rc<str>, Vec<Option<Result<Rc<str>, (Rc<str>, Rc<str>)>>>), std::string::String>> = v186.clone();
            { let _ = spiral_trace_hold(&v20); };
            let (mut v192, mut v193, mut v194, mut v195, mut v196, mut v197): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v22) };
            let mut v198: US0 = v196.borrow().l0.clone();
            let mut v203: i32 = match &v198 {
                US0::US0_4 => { // Critical
                    50i32
                }
                US0::US0_1 => { // Debug
                    20i32
                }
                US0::US0_2 => { // Info
                    30i32
                }
                US0::US0_0 => { // Verbose
                    10i32
                }
                US0::US0_3 => { // Warning
                    40i32
                }
                _ => unreachable!(),
            };
            let mut v204: bool = v194.borrow().l0.clone();
            let mut v205: bool = v204 == false;
            let mut v207: bool = if v205 {
                false
            } else {
                let mut v206: bool = 30i32 >= v203;
                v206
            };
            let mut v208: bool = v207 == false;
            let mut v254: US2 = if v208 {
                US2::US2_1
            } else {
                { let _ = spiral_trace_hold(&v20); };
                let (mut v212, mut v213, mut v214, mut v215, mut v216, mut v217): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v22) };
                let mut v218: Rc<str> = method3(v212.clone(), v213.clone(), v214.clone(), v215.clone(), v216.clone(), v217.clone());
                let mut v219: Rc<str> = method4();
                let mut v220: usize = ((v186).len() as usize);
                let mut v221: Rc<str> = method223(v212.clone(), v213.clone(), v214.clone(), v215.clone(), v216.clone(), v217.clone(), v218.clone(), v219.clone(), v220.clone());
                { let _ = spiral_trace_hold(&v20); };
                let (mut v224, mut v225, mut v226, mut v227, mut v228, mut v229): (Rc<RefCell<Mut0>>, Rc<RefCell<Mut1>>, Rc<RefCell<Mut2>>, Rc<RefCell<Mut3>>, Rc<RefCell<Mut4>>, Option<i64>) = { spiral_trace_hold(&v22) };
                let mut v230: i64 = v224.borrow().l0.clone();
                let mut v231: i64 = v230 + 1i64;
                v224.borrow_mut().l0 = v231;
                let mut v232: Rc<dyn Fn(Rc<str>) -> ()> = closure4();
                let mut v233: bool = cfg!(target_arch = "wasm32");
                if v233 {
                    let mut v234: Rc<str> = v227.borrow().l0.clone();
                    let mut v235: bool = v234.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v243: Rc<str> = if v235 {
                        v221.clone()
                    } else {
                        let mut v236: bool = v221.clone() == { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                        if v236 {
                            let mut v237: Rc<str> = v227.borrow().l0.clone();
                            v237.clone()
                        } else {
                            let mut v238: Rc<str> = v227.borrow().l0.clone();
                            let mut v239: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from("\n"); } LIT.with(|lit| lit.clone()) };
                            let mut v240: Rc<str> = Rc::<str>::from(format!("{}{}", v238, v239));
                            let mut v241: Rc<str> = Rc::<str>::from(format!("{}{}", v240, v221));
                            v241.clone()
                        }
                    };
                    let mut v245: i32 = ((v243.chars().count() + 14999) / 15000) as i32;
                    let mut v246: Rc<str> = { thread_local!{ static LIT: Rc<str> = Rc::<str>::from(""); } LIT.with(|lit| lit.clone()) };
                    let mut v247: bool = v221 != v246 ;
                    let mut v249: bool = if v247 {
                        let mut v248: bool = v245 <= 1i32;
                        v248
                    } else {
                        false
                    };
                    if v249 {
                        v227.borrow_mut().l0 = v243.clone();
                        ()
                    } else {
                        v227.borrow_mut().l0 = v246.clone();
                        { #[cfg(target_arch = "wasm32")] spiral_trace_near_log(&v243); };
                        ()
                    }
                } else {
                    println!("{}", v221);
                    ()
                };
                let mut v252: Rc<dyn Fn(Rc<str>) -> ()> = v225.borrow().l0.clone();
                v252(v221.clone());
                US2::US2_0(v224.clone(), v225.clone(), v226.clone(), v227.clone(), v228.clone(), v229.clone())
            };
            0i32
        }
        _ => unreachable!(),
    };
    if v324 != 0 { std::process::exit(v324) };
    0
}
#[cfg(not(target_arch = "wasm32"))]
fn main() {
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 101 });
}
#[cfg(target_arch = "wasm32")]
fn main() {
    spiral_main();
}
