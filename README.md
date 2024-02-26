# WPF Kiosk
## 이벤트 바인딩 절차
1. CustomControl 구현
2. ICommand 바인딩 속성(DependencyProperty) 추가
3. Selection 이벤트 구현
4. ICommand Execute
5. 뷰모델에서 ICommand 속성 생성
6. RelayCommand를 생성하여 콜백 메소드 구현
7. 뷰를 통한 SelectionCommand 바인딩

## TODO
- [X] CustomControl 기반의 BaseWindow 생성
- [X] CustomControl 기반의 Icon Control 생성
- [X] DependencyProperty를 이용한 Close window 이벤트 추가
- [X] Prism를 이용한 ViewModel 종속성 주입 기능 개발
- [ ] 대분류 메뉴 CustomControl 모듈 개발
- [ ] 상품 목록 CustomControl 모듈 개발
- [ ] 상품 상세 정보 CustomControl 모듈 개발
- [ ] 장바구니 CustomControl 모듈 개발
- [ ] 결제 CustomControl 모듈 개발

