<?php

/* base.html.twig */
class __TwigTemplate_4bbe4cb00ce6f8d465c8dd6727bc2b9ec28634a7580dd9013cb65806d5629e1e extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'footer' => array($this, 'block_footer'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_580ecb9a8f6a76a8f58a7375d54cee6126c994b993657bead93e1c670ec23621 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_580ecb9a8f6a76a8f58a7375d54cee6126c994b993657bead93e1c670ec23621->enter($__internal_580ecb9a8f6a76a8f58a7375d54cee6126c994b993657bead93e1c670ec23621_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_cfb4f1f1b1651721e08b15c484c821bd233efd0ac87dd61961b00fe61c6da9f0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cfb4f1f1b1651721e08b15c484c821bd233efd0ac87dd61961b00fe61c6da9f0->enter($__internal_cfb4f1f1b1651721e08b15c484c821bd233efd0ac87dd61961b00fe61c6da9f0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>

";
        // line 50
        $this->displayBlock('footer', $context, $blocks);
        // line 57
        echo "
";
        // line 58
        $this->displayBlock('javascripts', $context, $blocks);
        // line 64
        echo "
</body>
</html>
";
        
        $__internal_580ecb9a8f6a76a8f58a7375d54cee6126c994b993657bead93e1c670ec23621->leave($__internal_580ecb9a8f6a76a8f58a7375d54cee6126c994b993657bead93e1c670ec23621_prof);

        
        $__internal_cfb4f1f1b1651721e08b15c484c821bd233efd0ac87dd61961b00fe61c6da9f0->leave($__internal_cfb4f1f1b1651721e08b15c484c821bd233efd0ac87dd61961b00fe61c6da9f0_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_0fdeb4cf6172b9ddb45a0f92aed5f4a10c4b483a3bf06cddabc0bb159988c1ef = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_0fdeb4cf6172b9ddb45a0f92aed5f4a10c4b483a3bf06cddabc0bb159988c1ef->enter($__internal_0fdeb4cf6172b9ddb45a0f92aed5f4a10c4b483a3bf06cddabc0bb159988c1ef_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_75137e3a3a31d0d7d3175bbca1687ba9c65bc21bed0f0fdcdeb507acd9fae514 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_75137e3a3a31d0d7d3175bbca1687ba9c65bc21bed0f0fdcdeb507acd9fae514->enter($__internal_75137e3a3a31d0d7d3175bbca1687ba9c65bc21bed0f0fdcdeb507acd9fae514_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_75137e3a3a31d0d7d3175bbca1687ba9c65bc21bed0f0fdcdeb507acd9fae514->leave($__internal_75137e3a3a31d0d7d3175bbca1687ba9c65bc21bed0f0fdcdeb507acd9fae514_prof);

        
        $__internal_0fdeb4cf6172b9ddb45a0f92aed5f4a10c4b483a3bf06cddabc0bb159988c1ef->leave($__internal_0fdeb4cf6172b9ddb45a0f92aed5f4a10c4b483a3bf06cddabc0bb159988c1ef_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_9ba965fae76c3976a71a02dc1c4446f707a2ed5cacab9b3239656580f0b0b5a9 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_9ba965fae76c3976a71a02dc1c4446f707a2ed5cacab9b3239656580f0b0b5a9->enter($__internal_9ba965fae76c3976a71a02dc1c4446f707a2ed5cacab9b3239656580f0b0b5a9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_ea9c1980a4fe0cc6a8c771675628ef24fe750f5d89f2ff9c85d2f47450f940aa = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ea9c1980a4fe0cc6a8c771675628ef24fe750f5d89f2ff9c85d2f47450f940aa->enter($__internal_ea9c1980a4fe0cc6a8c771675628ef24fe750f5d89f2ff9c85d2f47450f940aa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_ea9c1980a4fe0cc6a8c771675628ef24fe750f5d89f2ff9c85d2f47450f940aa->leave($__internal_ea9c1980a4fe0cc6a8c771675628ef24fe750f5d89f2ff9c85d2f47450f940aa_prof);

        
        $__internal_9ba965fae76c3976a71a02dc1c4446f707a2ed5cacab9b3239656580f0b0b5a9->leave($__internal_9ba965fae76c3976a71a02dc1c4446f707a2ed5cacab9b3239656580f0b0b5a9_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_c45c6d41da6578eede3d41ed8dfb0d18e058fc59841f8ce4abb3bb3e6a982720 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_c45c6d41da6578eede3d41ed8dfb0d18e058fc59841f8ce4abb3bb3e6a982720->enter($__internal_c45c6d41da6578eede3d41ed8dfb0d18e058fc59841f8ce4abb3bb3e6a982720_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_8c4ec89ffbd6c76d087e457fdce1b128ad1a89378650b2a7f530e6a273f10c2e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_8c4ec89ffbd6c76d087e457fdce1b128ad1a89378650b2a7f530e6a273f10c2e->enter($__internal_8c4ec89ffbd6c76d087e457fdce1b128ad1a89378650b2a7f530e6a273f10c2e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_8c4ec89ffbd6c76d087e457fdce1b128ad1a89378650b2a7f530e6a273f10c2e->leave($__internal_8c4ec89ffbd6c76d087e457fdce1b128ad1a89378650b2a7f530e6a273f10c2e_prof);

        
        $__internal_c45c6d41da6578eede3d41ed8dfb0d18e058fc59841f8ce4abb3bb3e6a982720->leave($__internal_c45c6d41da6578eede3d41ed8dfb0d18e058fc59841f8ce4abb3bb3e6a982720_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_9a1bed8b7c0c1bf20db4b2d98b913bcf8f1aa7e8cb7dbf09e414ef8aa515f866 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_9a1bed8b7c0c1bf20db4b2d98b913bcf8f1aa7e8cb7dbf09e414ef8aa515f866->enter($__internal_9a1bed8b7c0c1bf20db4b2d98b913bcf8f1aa7e8cb7dbf09e414ef8aa515f866_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        $__internal_66980f6bf793163c0e76ba7f331380ea5d75a6cab4012fac60b769ac4fb492c4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_66980f6bf793163c0e76ba7f331380ea5d75a6cab4012fac60b769ac4fb492c4->enter($__internal_66980f6bf793163c0e76ba7f331380ea5d75a6cab4012fac60b769ac4fb492c4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_66980f6bf793163c0e76ba7f331380ea5d75a6cab4012fac60b769ac4fb492c4->leave($__internal_66980f6bf793163c0e76ba7f331380ea5d75a6cab4012fac60b769ac4fb492c4_prof);

        
        $__internal_9a1bed8b7c0c1bf20db4b2d98b913bcf8f1aa7e8cb7dbf09e414ef8aa515f866->leave($__internal_9a1bed8b7c0c1bf20db4b2d98b913bcf8f1aa7e8cb7dbf09e414ef8aa515f866_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_0df155a74b5548f75c52d4523efb769f74e59628921cf34b48f5e8fc2cb248e3 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_0df155a74b5548f75c52d4523efb769f74e59628921cf34b48f5e8fc2cb248e3->enter($__internal_0df155a74b5548f75c52d4523efb769f74e59628921cf34b48f5e8fc2cb248e3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_63c06b0231c7bf9d705d976324293aa3eea4f660893b60c930f502afa42354d3 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_63c06b0231c7bf9d705d976324293aa3eea4f660893b60c930f502afa42354d3->enter($__internal_63c06b0231c7bf9d705d976324293aa3eea4f660893b60c930f502afa42354d3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_63c06b0231c7bf9d705d976324293aa3eea4f660893b60c930f502afa42354d3->leave($__internal_63c06b0231c7bf9d705d976324293aa3eea4f660893b60c930f502afa42354d3_prof);

        
        $__internal_0df155a74b5548f75c52d4523efb769f74e59628921cf34b48f5e8fc2cb248e3->leave($__internal_0df155a74b5548f75c52d4523efb769f74e59628921cf34b48f5e8fc2cb248e3_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_d7b02cc1f7e6f4a7a80239e35162fc0eb098d7a2853b1c340db319fde1d386fa = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_d7b02cc1f7e6f4a7a80239e35162fc0eb098d7a2853b1c340db319fde1d386fa->enter($__internal_d7b02cc1f7e6f4a7a80239e35162fc0eb098d7a2853b1c340db319fde1d386fa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_aab1f6179b08b8da4d306af6eaf2ba475fffd3ddc43f3261c23a876ed290188f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_aab1f6179b08b8da4d306af6eaf2ba475fffd3ddc43f3261c23a876ed290188f->enter($__internal_aab1f6179b08b8da4d306af6eaf2ba475fffd3ddc43f3261c23a876ed290188f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_aab1f6179b08b8da4d306af6eaf2ba475fffd3ddc43f3261c23a876ed290188f->leave($__internal_aab1f6179b08b8da4d306af6eaf2ba475fffd3ddc43f3261c23a876ed290188f_prof);

        
        $__internal_d7b02cc1f7e6f4a7a80239e35162fc0eb098d7a2853b1c340db319fde1d386fa->leave($__internal_d7b02cc1f7e6f4a7a80239e35162fc0eb098d7a2853b1c340db319fde1d386fa_prof);

    }

    // line 50
    public function block_footer($context, array $blocks = array())
    {
        $__internal_f127583fdfe9a491150f86c4641f4780902e72cd5b099c49005414bb403e488e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f127583fdfe9a491150f86c4641f4780902e72cd5b099c49005414bb403e488e->enter($__internal_f127583fdfe9a491150f86c4641f4780902e72cd5b099c49005414bb403e488e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "footer"));

        $__internal_48f296db363a4e8561e27b62a8c8823e8d3af83e860568fe5045c43b0bd3ed9d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_48f296db363a4e8561e27b62a8c8823e8d3af83e860568fe5045c43b0bd3ed9d->enter($__internal_48f296db363a4e8561e27b62a8c8823e8d3af83e860568fe5045c43b0bd3ed9d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "footer"));

        // line 51
        echo "    <footer>
        <div class=\"container modal-footer\">
            <p>&copy; 2018 - Software University Foundation</p>
        </div>
    </footer>
";
        
        $__internal_48f296db363a4e8561e27b62a8c8823e8d3af83e860568fe5045c43b0bd3ed9d->leave($__internal_48f296db363a4e8561e27b62a8c8823e8d3af83e860568fe5045c43b0bd3ed9d_prof);

        
        $__internal_f127583fdfe9a491150f86c4641f4780902e72cd5b099c49005414bb403e488e->leave($__internal_f127583fdfe9a491150f86c4641f4780902e72cd5b099c49005414bb403e488e_prof);

    }

    // line 58
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_8a00ba5a89dd31328f33c5d3c4b79e7ee284e0bba389a9af881a7543b0c4f449 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_8a00ba5a89dd31328f33c5d3c4b79e7ee284e0bba389a9af881a7543b0c4f449->enter($__internal_8a00ba5a89dd31328f33c5d3c4b79e7ee284e0bba389a9af881a7543b0c4f449_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        $__internal_79db1cfa12b3cc1ffe1eb8c0636c8bc3d2ea68b421775ed35c18b02aa8a43517 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_79db1cfa12b3cc1ffe1eb8c0636c8bc3d2ea68b421775ed35c18b02aa8a43517->enter($__internal_79db1cfa12b3cc1ffe1eb8c0636c8bc3d2ea68b421775ed35c18b02aa8a43517_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 59
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 60
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 61
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 62
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_79db1cfa12b3cc1ffe1eb8c0636c8bc3d2ea68b421775ed35c18b02aa8a43517->leave($__internal_79db1cfa12b3cc1ffe1eb8c0636c8bc3d2ea68b421775ed35c18b02aa8a43517_prof);

        
        $__internal_8a00ba5a89dd31328f33c5d3c4b79e7ee284e0bba389a9af881a7543b0c4f449->leave($__internal_8a00ba5a89dd31328f33c5d3c4b79e7ee284e0bba389a9af881a7543b0c4f449_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  279 => 62,  275 => 61,  271 => 60,  266 => 59,  257 => 58,  242 => 51,  233 => 50,  216 => 44,  204 => 45,  202 => 44,  198 => 42,  189 => 41,  166 => 26,  160 => 22,  151 => 21,  134 => 19,  122 => 14,  117 => 13,  108 => 12,  90 => 11,  77 => 64,  75 => 58,  72 => 57,  70 => 50,  66 => 48,  64 => 41,  60 => 39,  58 => 21,  53 => 19,  46 => 16,  44 => 12,  40 => 11,  33 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>

{% block footer %}
    <footer>
        <div class=\"container modal-footer\">
            <p>&copy; 2018 - Software University Foundation</p>
        </div>
    </footer>
{% endblock %}

{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
", "base.html.twig", "C:\\xampp\\htdocs\\MyProjects\\PHP-Calculator\\app\\Resources\\views\\base.html.twig");
    }
}
