#![allow(unused_mut, unused_variables, unused_imports, unused_parens, unused_braces, unused_assignments, dead_code, non_snake_case, non_camel_case_types, unreachable_code, while_true)]
use std::cell::RefCell;
use std::rc::Rc;
#[derive(Clone)]
enum US0 {
    US0_CLine(f64, f64),
    US0_CQuad(f64, f64, f64, f64),
    US0_CCubic(f64, f64, f64, f64, f64, f64),
}
#[derive(Clone)]
enum UH0 {
    UH0_Nil,
    UH0_Cons(US0, Rc<UH0>),
}
#[derive(Clone)]
enum UH1 {
    UH1_Nil,
    UH1_Cons(f64, f64, Rc<UH0>, Rc<UH1>),
}
#[derive(Clone)]
enum US1 {
    US1_QLine(f64, f64),
    US1_QQuad(f64, f64, f64, f64),
}
#[derive(Clone)]
enum UH3 {
    UH3_Nil,
    UH3_Cons(US1, Rc<UH3>),
}
#[derive(Clone)]
enum UH2 {
    UH2_Nil,
    UH2_Cons(f64, f64, Rc<UH3>, Rc<UH2>),
}
fn lower_segs_1(mut v0: f64, mut v1: f64, mut v2: Rc<UH0>) -> Rc<UH3> {
    match Rc::unwrap_or_clone(v2) {
        UH0::UH0_Cons(v3, v4) => {
            let v3: US0 = v3;
            let v4: Rc<UH0> = v4;
            match v3 {
                US0::US0_CCubic(v17, v18, v19, v20, v21, v22) => {
                    let v17: f64 = v17;
                    let v18: f64 = v18;
                    let v19: f64 = v19;
                    let v20: f64 = v20;
                    let v21: f64 = v21;
                    let v22: f64 = v22;
                    let v23: f64 = 3.0f64 * v17;
                    let v24: f64 = 3.0f64 * v18;
                    let v25: f64 = 3.0f64 * v19;
                    let v26: f64 = 3.0f64 * v20;
                    let v27: f64 = v23 + v25;
                    let v28: f64 = v24 + v26;
                    let v29: f64 = v0 + v21;
                    let v30: f64 = v1 + v22;
                    let v31: f64 = v27 - v29;
                    let v32: f64 = v28 - v30;
                    let v33: f64 = 0.25f64 * v31;
                    let v34: f64 = 0.25f64 * v32;
                    let v35: Rc<UH3> = lower_segs_1(v21, v22, v4);
                    let v36: US1 = US1::US1_QQuad(v33, v34, v21, v22);
                    Rc::new(UH3::UH3_Cons(v36, v35))
                }
                US0::US0_CLine(v5, v6) => {
                    let v5: f64 = v5;
                    let v6: f64 = v6;
                    let v7: Rc<UH3> = lower_segs_1(v5, v6, v4);
                    let v8: US1 = US1::US1_QLine(v5, v6);
                    Rc::new(UH3::UH3_Cons(v8, v7))
                }
                US0::US0_CQuad(v10, v11, v12, v13) => {
                    let v10: f64 = v10;
                    let v11: f64 = v11;
                    let v12: f64 = v12;
                    let v13: f64 = v13;
                    let v14: Rc<UH3> = lower_segs_1(v12, v13, v4);
                    let v15: US1 = US1::US1_QQuad(v10, v11, v12, v13);
                    Rc::new(UH3::UH3_Cons(v15, v14))
                }
            }
        }
        UH0::UH0_Nil => {
            { thread_local!{ static CASE: Rc<UH3> = Rc::new(UH3::UH3_Nil); } CASE.with(|case| case.clone()) }
        }
    }
}
fn lower_contours_0(mut v0: Rc<UH1>) -> Rc<UH2> {
    match Rc::unwrap_or_clone(v0) {
        UH1::UH1_Cons(v1, v2, v3, v4) => {
            let v1: f64 = v1;
            let v2: f64 = v2;
            let v3: Rc<UH0> = v3;
            let v4: Rc<UH1> = v4;
            let v5: Rc<UH3> = lower_segs_1(v1, v2, v3);
            let v6: Rc<UH2> = lower_contours_0(v4);
            Rc::new(UH2::UH2_Cons(v1, v2, v5, v6))
        }
        UH1::UH1_Nil => {
            { thread_local!{ static CASE: Rc<UH2> = Rc::new(UH2::UH2_Nil); } CASE.with(|case| case.clone()) }
        }
    }
}
fn thread_segs_3(mut v0: kurbo::BezPath, mut v1: Rc<UH3>) -> kurbo::BezPath {
    loop {
        match Rc::unwrap_or_clone(v1) {
            UH3::UH3_Cons(v2, v3) => {
                let v2: US1 = v2;
                let v3: Rc<UH3> = v3;
                match v2 {
                    US1::US1_QLine(v4, v5) => {
                        let v4: f64 = v4;
                        let v5: f64 = v5;
                        let v7: kurbo::BezPath = { let mut q = v0; q.line_to((v4, v5)); q };
                        (v0, v1) = (v7, v3);
                        continue;
                    }
                    US1::US1_QQuad(v9, v10, v11, v12) => {
                        let v9: f64 = v9;
                        let v10: f64 = v10;
                        let v11: f64 = v11;
                        let v12: f64 = v12;
                        let v14: kurbo::BezPath = { let mut q = v0; q.quad_to((v9, v10), (v11, v12)); q };
                        (v0, v1) = (v14, v3);
                        continue;
                    }
                }
            }
            UH3::UH3_Nil => {
                return v0;
            }
        }
    }
}
fn thread_contours_2(mut v0: kurbo::BezPath, mut v1: Rc<UH2>) -> kurbo::BezPath {
    loop {
        match Rc::unwrap_or_clone(v1) {
            UH2::UH2_Cons(v2, v3, v4, v5) => {
                let v2: f64 = v2;
                let v3: f64 = v3;
                let v4: Rc<UH3> = v4;
                let v5: Rc<UH2> = v5;
                let v7: kurbo::BezPath = { let mut q = v0; q.move_to((v2, v3)); q };
                let v8: kurbo::BezPath = thread_segs_3(v7, v4);
                let v10: kurbo::BezPath = { let mut q = v8; q.close_path(); q };
                (v0, v1) = (v10, v5);
                continue;
            }
            UH2::UH2_Nil => {
                return v0;
            }
        }
    }
}
fn spiral_main() -> i32 {
    let v0: f64 = 72.0f64;
    let v1: f64 = 0.0f64;
    let v2: f64 = 162.0f64;
    let v3: US0 = US0::US0_CLine(v2, v1);
    let v4: f64 = 710.0f64;
    let v5: US0 = US0::US0_CLine(v2, v4);
    let v6: US0 = US0::US0_CLine(v0, v4);
    let v7: Rc<UH0> = { thread_local!{ static CASE: Rc<UH0> = Rc::new(UH0::UH0_Nil); } CASE.with(|case| case.clone()) };
    let v8: Rc<UH0> = Rc::new(UH0::UH0_Cons(v6, v7));
    let v9: Rc<UH0> = Rc::new(UH0::UH0_Cons(v5, v8));
    let v10: Rc<UH0> = Rc::new(UH0::UH0_Cons(v3, v9));
    let v11: Rc<UH1> = { thread_local!{ static CASE: Rc<UH1> = Rc::new(UH1::UH1_Nil); } CASE.with(|case| case.clone()) };
    let v12: Rc<UH1> = Rc::new(UH1::UH1_Cons(v0, v1, v10, v11));
    let v13: Rc<UH2> = lower_contours_0(v12);
    let v15: kurbo::BezPath = kurbo::BezPath::new();
    let v16: kurbo::BezPath = thread_contours_2(v15, v13);
    let v18: i32 = { use write_fonts::tables::glyf::{GlyfLocaBuilder, SimpleGlyph}; let sg = SimpleGlyph::from_bezpath(&v16).unwrap(); let mut gl = GlyfLocaBuilder::new(); gl.add_glyph(&sg).unwrap(); let (glyf, loca, _f) = gl.build(); let mut b = write_fonts::FontBuilder::new(); b.add_table(&glyf).unwrap(); b.add_table(&loca).unwrap(); b.build().len() as i32 };
    v18
}
fn main() { #[cfg(target_arch = "wasm32")] { spiral_main(); return; }
    let main = std::thread::Builder::new().stack_size(1 << 30).spawn(spiral_main).unwrap();
    std::process::exit(match main.join() { Ok(code) => code, Err(_) => 1 });
}
