import { Injectable } from '@angular/core';
import { ClarityIcons, clipboardIcon, usersIcon, logoutIcon, downloadIcon, userIcon, envelopeIcon, phoneHandsetIcon, checkIcon, fileIcon, angleIcon, infoStandardIcon } from '@cds/core/icon';

@Injectable({
  providedIn: 'root'
})
export class FacultyIconsService {

  icons: any = [
    ["mcq-performance-icon", `<svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" version="1.1" x="0px" y="0px" viewBox="0 0 100 125" style="enable-background:new 0 0 100 100;" xml:space="preserve"> <g> <path fill="#fff" d="M87.5,8.15c-8.78,36.99-42.08,63.5-80.45,63.5c-0.55,0-1,0.45-1,1s0.45,1,1,1c39.08,0,73.03-26.86,82.25-64.42l-0.61-2.27 L87.5,8.15z" /> <path fill="#fff" d="M90.75,93.97h-2.31V34.83c0-0.55-0.45-1-1-1s-1,0.45-1,1v59.14H73.35V55.34c0-0.55-0.45-1-1-1s-1,0.45-1,1v38.62H58.27 V66.13c0-0.55-0.45-1-1-1s-1,0.45-1,1v27.84H43.19V72.79c0-0.55-0.45-1-1-1s-1,0.45-1,1v21.18H28.1V76.7c0-0.55-0.45-1-1-1 s-1,0.45-1,1v17.27H13.02V78.49c0-0.55-0.45-1-1-1s-1,0.45-1,1v15.48H7.06c-0.55,0-1,0.45-1,1s0.45,1,1,1h83.69c0.55,0,1-0.45,1-1 S91.3,93.97,90.75,93.97z" /> <path fill="#fff" d="M93.91,18.73L89.73,3.1L78.29,14.53c-0.39,0.39-0.39,1.02,0,1.41c0.39,0.39,1.02,0.39,1.41,0l7.81-7.8 c0.26-1.1,0.5-2.2,0.72-3.31c0.11-0.54,0.63-0.9,1.17-0.79c0.54,0.11,0.9,0.63,0.79,1.17c-0.26,1.35-0.56,2.68-0.89,4.01 l2.68,10.02c0.12,0.45,0.52,0.74,0.97,0.74c0.09,0,0.17-0.01,0.26-0.03C93.74,19.81,94.05,19.26,93.91,18.73z" /> </g> </svg> `],
    ["mcq-api-icon", `<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 25 31.25" x="0px" y="0px"> <g data-name="Multiple Choice"> <path fill="#fff" d="M20.4,12.5a.5.5,0,0,1-.5.5H11.288a.5.5,0,0,1,0-1H19.9A.5.5,0,0,1,20.4,12.5ZM11.288,6.948H19.9a.5.5,0,0,0,0-1H11.288a.5.5,0,0,0,0,1Zm8.611,11.1H11.288a.5.5,0,0,0,0,1H19.9a.5.5,0,0,0,0-1ZM9.1,12.5a2.249,2.249,0,1,1-2.249-2.249A2.252,2.252,0,0,1,9.1,12.5Zm-1,0a1.249,1.249,0,1,0-1.249,1.249A1.251,1.251,0,0,0,8.1,12.5Zm1,6.052A2.249,2.249,0,1,1,6.849,16.3,2.252,2.252,0,0,1,9.1,18.552Zm-1,0A1.249,1.249,0,1,0,6.849,19.8,1.25,1.25,0,0,0,8.1,18.552ZM8.951,4.346a.5.5,0,0,0-.707,0L6.849,5.741l-1.4-1.395a.5.5,0,0,0-.707.707l1.4,1.4-1.4,1.395a.5.5,0,0,0,.707.707l1.4-1.4,1.395,1.4a.5.5,0,0,0,.707-.707l-1.4-1.395,1.4-1.4A.5.5,0,0,0,8.951,4.346Z" /> </g> </svg>`],
    ["graded-essays-icon", `<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 64 80" fill="#fff" x="0px" y="0px"> <path d="M43 17C43.5523 17 44 16.5523 44 16C44 15.4477 43.5523 15 43 15H13C12.4477 15 12 15.4477 12 16C12 16.5523 12.4477 17 13 17H43Z" fill="#fff" /> <path d="M44 24C44 24.5523 43.5523 25 43 25H13C12.4477 25 12 24.5523 12 24C12 23.4477 12.4477 23 13 23H43C43.5523 23 44 23.4477 44 24Z" fill="#fff" /> <path d="M27 32C27 32.5523 26.5523 33 26 33H13C12.4477 33 12 32.5523 12 32C12 31.4477 12.4477 31 13 31H26C26.5523 31 27 31.4477 27 32Z" fill="#fff" /> <path fill-rule="evenodd" clip-rule="evenodd" d="M50 32.3616V57C50 58.6569 48.6569 60 47 60H9C7.34315 60 6 58.6569 6 57V7C6 5.34314 7.34315 4 9 4H47C48.6569 4 50 5.34315 50 7V23.6384L53.3455 20.2929C53.736 19.9024 54.3692 19.9024 54.7597 20.2929L57.7071 23.2403C57.8946 23.4278 58 23.6822 58 23.9474C58 24.2126 57.8946 24.4669 57.7071 24.6545L50 32.3616ZM8 7C8 6.44771 8.44771 6 9 6H47C47.5523 6 48 6.44772 48 7V25.6384L32.7139 40.9245C32.6024 41.036 32.5189 41.1723 32.4701 41.3222L31.049 45.6907C30.9327 46.0484 31.0269 46.4411 31.2929 46.7071C31.5589 46.9731 31.9516 47.0673 32.3093 46.951L36.6778 45.5299C36.8277 45.4811 36.964 45.3976 37.0755 45.2861L48 34.3616V57C48 57.5523 47.5523 58 47 58H9C8.44772 58 8 57.5523 8 57V7ZM34.2978 42.1691L54.0526 22.4142L55.5858 23.9474L35.8309 43.7022L33.5586 44.4414L34.2978 42.1691Z" fill="#fff" /> </svg>`],
    ["practice-exams-icon", `<svg xmlns:x="http://ns.adobe.com/Extensibility/1.0/" xmlns:i="http://ns.adobe.com/AdobeIllustrator/10.0/" xmlns:graph="http://ns.adobe.com/Graphs/1.0/" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" version="1.1" x="0px" y="0px" viewBox="0 0 100 125" style="enable-background:new 0 0 100 100;" xml:space="preserve"> <switch> <foreignObject requiredExtensions="http://ns.adobe.com/AdobeIllustrator/10.0/" x="0" y="0" width="1" height="1" /> <g i:extraneous="self"> <g> <path d="M37.6,84.7C22,84.7,9.4,72,9.4,56.5c0-15.6,12.7-28.2,28.2-28.2c4.3,0,8.4,1,12.1,2.7l5.1-5.1 c-5.1-2.9-10.9-4.5-17.2-4.5c-19.4,0-35.1,15.8-35.1,35.1c0,19.4,15.7,35.1,35.1,35.1c19.2,0,34.9-15.5,35.1-34.7l-7,1.9 C64.6,73.3,52.4,84.7,37.6,84.7z" /> <path d="M37.6,41.5c0.5,0,1,0,1.5,0.1l5.7-5.7c-2.2-0.8-4.6-1.3-7.2-1.3c-12.1,0-21.9,9.8-21.9,21.9c0,12.1,9.8,21.9,21.9,21.9 c10.7,0,19.6-7.7,21.5-17.8l-7.8,2.1c-2.3,5.2-7.6,8.8-13.6,8.8c-8.3,0-15-6.7-15-15C22.6,48.2,29.3,41.5,37.6,41.5z" /> <path d="M96.2,45.8l-5.9-3.4l3.4-5.9c0.5-0.9,0.4-2-0.2-2.9c-0.6-0.8-1.7-1.2-2.7-0.9l-9.7,2.6c-0.7,0.2-1.2,0.6-1.6,1.2L76,42.6 l-26.9,7.2l19.7-19.7H76c0.7,0,1.3-0.3,1.8-0.8l7.1-7.1c0.7-0.7,1-1.8,0.6-2.8c-0.4-1-1.3-1.6-2.4-1.6h-6.8V11c0-1-0.6-2-1.6-2.4 c-1-0.4-2.1-0.2-2.8,0.6l-7.1,7.1c-0.5,0.5-0.8,1.1-0.8,1.8v7.1L40.8,48.5c-1-0.4-2-0.6-3.2-0.6c-4.8,0-8.6,3.9-8.6,8.6 s3.9,8.6,8.6,8.6c4.3,0,7.9-3.2,8.5-7.4l31.7-8.5l6.2,3.6c0.6,0.3,1.3,0.4,2,0.3l9.7-2.6c1-0.3,1.8-1.1,1.9-2.2 C97.6,47.3,97.1,46.3,96.2,45.8z" /> </g> </g> </switch> </svg>`],
    clipboardIcon,
    usersIcon,
    logoutIcon,
    downloadIcon,
    userIcon,
    envelopeIcon,
    phoneHandsetIcon,
    checkIcon,
    fileIcon,
    angleIcon,
    infoStandardIcon
  ]

  public load() {
    ClarityIcons.addIcons(...this.icons)
  }

}
