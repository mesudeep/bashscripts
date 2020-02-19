node(){
    stage('Checkout'){
        chechout scm
    }
    stage('Build'){
        sh "sh untilloop.sh"

    }
    stage('Array'){
        sh "array"
    }
    stage('Notify'){
        sh 'mail -s “the job ran file” timalsinasrijana77@gmail.com'

    }
}