# VR-Fair-Project

해당 프로젝트는 Unity로 제작되었으나, 용량의 문제로 해당 프로젝트를 진행하면서 사용했던 스크립트 위주로 올렸습니다.
<br>멀티플레이는 UNITY내부에서 제공하는 PHOTON을 가지고 사용하였습니다.

## 모두쇼 : VR박람회 플랫폼
가상환경에서 체험할 수 있는 박람회 플랫폼 개발
<br>진행기간 2020/10/10 - 2020/11/27
<br><img src="https://img.shields.io/badge/Unity-FFFFFF?style=for-the-badge&logo=Unity&logoColor=black">
<br> 맡은 역할:
<br>Back-End 1명, UI연결 1명,
환경 배치 및 내부 연결 2명(본인포함)

![image](https://user-images.githubusercontent.com/76572665/223203971-b507585e-e864-4714-9782-1c87f8dc7e6d.png)

- **사용 대상:**
    - 오프라인 채용 박람회, 대학 박람회 등의 박람회를 필요로 하는 사람
    - 대학교 및 기업, 학생 및 구직자 등
- **문제:**
    - 코로나와 같은 이유로 취소되는 박람회가 발생하여 준비한 박람회를 취소하게 됨
    - 박람회에서 정보를 얻고 싶지만, 개인적인 부상 등으로 대면으로 박람회에 참석하기 어려운 상황이 발생
- **솔루션:**
    - 가상 공간에서 박람회를 체험하고 정보를 제공합니다.
    - 해당 기업에 문의할 수 있는 공간을 제공합니다.
    - VR 박람회에서 다른 사람들과 소통을 통해 정보 공유의 기회를 제공합니다.
- **기대 효과:**
    - 가상 환경에서 진행하므로 건강의 위험과 위생 문제로부터 안전합니다.
    - 대관료나 부스 비용, 인건비를 절감할 수 있습니다.
    - 사람이 많음으로 생기는 문제(절도, 밀림)를 방지합니다.
    - 특정 위치에 사용자가 직접 찾아올 필요 없이 집에서도 참여할 수 있습니다.
    - 기업이나 대학 참여 수, 사용자 수에 제한이 없습니다.
    - 다양한 콘텐츠를 제공할 수 있습니다.
    - 팜플렛 제공 대신 파일 공유를 통해 종이 낭비를 줄일 수 있습니다.
- **활용 방안:**
    - 오프라인 채용박람회, 대학박람회 등의 박람회가 필요한 사람
    - 대학교 및 기업, 학생 및 구직자 등

## 🖥 사용 기술 및 라이브러리

- Unity, Unity Teams
- Photon Unity Networking
- Virtual Reality (VR), VRTK, 삼성 오디세이VR

## 🖱 담당한 기능

- 모델링을 배치하여 1:1 상담할 수 있는 가상 환경을 만듭니다.
- 사용자의 데이터를 가져와 참가자와 기업을 구별하여 연결하며, 특정 ‘키’를 입력하면 기업으로 분류됩니다. 그 외에는 일반 참가자로 입장합니다.
- 상담 시스템을 구현하였으며, 참가자가 ‘상담하기’ 버튼을 누르면 기업에서 ‘수락하기’ 버튼이 나타나고, 이 버튼을 클릭하면 새로운 상담 방이 생성되어 둘이서만 대화할 수 있는 공간을 제공합니다.

## 🎈기타

- 복지서비스 모델 제안 컴페티션 - 입상
- 관련 링크 : [https://pleasefixthebug.tistory.com/entry/ALLshow](https://pleasefixthebug.tistory.com/entry/ALLshow)
