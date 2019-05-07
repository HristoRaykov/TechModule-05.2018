<?php

/* @WebProfiler/Collector/ajax.html.twig */
class __TwigTemplate_b85f29821be27aa8b1bc98519436461388017d9d368062ef3d8575c22bceff2f extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/ajax.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_72dd71a6b338faa2f1f5b491f7513ba1cf10864beb6b9eaecae1eb2032c6e8ed = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_72dd71a6b338faa2f1f5b491f7513ba1cf10864beb6b9eaecae1eb2032c6e8ed->enter($__internal_72dd71a6b338faa2f1f5b491f7513ba1cf10864beb6b9eaecae1eb2032c6e8ed_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/ajax.html.twig"));

        $__internal_4ab8aee4690ed71fd28b62aed80adde853cf612bc5aeeaf3febdd3a2540895dc = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4ab8aee4690ed71fd28b62aed80adde853cf612bc5aeeaf3febdd3a2540895dc->enter($__internal_4ab8aee4690ed71fd28b62aed80adde853cf612bc5aeeaf3febdd3a2540895dc_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/ajax.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_72dd71a6b338faa2f1f5b491f7513ba1cf10864beb6b9eaecae1eb2032c6e8ed->leave($__internal_72dd71a6b338faa2f1f5b491f7513ba1cf10864beb6b9eaecae1eb2032c6e8ed_prof);

        
        $__internal_4ab8aee4690ed71fd28b62aed80adde853cf612bc5aeeaf3febdd3a2540895dc->leave($__internal_4ab8aee4690ed71fd28b62aed80adde853cf612bc5aeeaf3febdd3a2540895dc_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_08f7582270aeabc6c62bc028d86d9e0b7c7b91fc62d077355d491afca84bc949 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_08f7582270aeabc6c62bc028d86d9e0b7c7b91fc62d077355d491afca84bc949->enter($__internal_08f7582270aeabc6c62bc028d86d9e0b7c7b91fc62d077355d491afca84bc949_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_86878baa51ce6eb9e34a696d8d2525c5cba0280b8c001fc43cdfa6288e3d9282 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_86878baa51ce6eb9e34a696d8d2525c5cba0280b8c001fc43cdfa6288e3d9282->enter($__internal_86878baa51ce6eb9e34a696d8d2525c5cba0280b8c001fc43cdfa6288e3d9282_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        // line 4
        echo "    ";
        ob_start();
        // line 5
        echo "        ";
        echo twig_include($this->env, $context, "@WebProfiler/Icon/ajax.svg");
        echo "
        <span class=\"sf-toolbar-value sf-toolbar-ajax-request-counter\">0</span>
    ";
        $context["icon"] = ('' === $tmp = ob_get_clean()) ? '' : new Twig_Markup($tmp, $this->env->getCharset());
        // line 8
        echo "
    ";
        // line 9
        $context["text"] = ('' === $tmp = "        <div class=\"sf-toolbar-info-piece\">
            <b class=\"sf-toolbar-ajax-info\"></b>
        </div>
        <div class=\"sf-toolbar-info-piece\">
            <table class=\"sf-toolbar-ajax-requests\">
                <thead>
                    <tr>
                        <th>Method</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>URL</th>
                        <th>Time</th>
                        <th>Profile</th>
                    </tr>
                </thead>
                <tbody class=\"sf-toolbar-ajax-request-list\"></tbody>
            </table>
        </div>
    ") ? '' : new Twig_Markup($tmp, $this->env->getCharset());
        // line 29
        echo "
    ";
        // line 30
        echo twig_include($this->env, $context, "@WebProfiler/Profiler/toolbar_item.html.twig", array("link" => false));
        echo "
";
        
        $__internal_86878baa51ce6eb9e34a696d8d2525c5cba0280b8c001fc43cdfa6288e3d9282->leave($__internal_86878baa51ce6eb9e34a696d8d2525c5cba0280b8c001fc43cdfa6288e3d9282_prof);

        
        $__internal_08f7582270aeabc6c62bc028d86d9e0b7c7b91fc62d077355d491afca84bc949->leave($__internal_08f7582270aeabc6c62bc028d86d9e0b7c7b91fc62d077355d491afca84bc949_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/ajax.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  85 => 30,  82 => 29,  62 => 9,  59 => 8,  52 => 5,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}
    {% set icon %}
        {{ include('@WebProfiler/Icon/ajax.svg') }}
        <span class=\"sf-toolbar-value sf-toolbar-ajax-request-counter\">0</span>
    {% endset %}

    {% set text %}
        <div class=\"sf-toolbar-info-piece\">
            <b class=\"sf-toolbar-ajax-info\"></b>
        </div>
        <div class=\"sf-toolbar-info-piece\">
            <table class=\"sf-toolbar-ajax-requests\">
                <thead>
                    <tr>
                        <th>Method</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>URL</th>
                        <th>Time</th>
                        <th>Profile</th>
                    </tr>
                </thead>
                <tbody class=\"sf-toolbar-ajax-request-list\"></tbody>
            </table>
        </div>
    {% endset %}

    {{ include('@WebProfiler/Profiler/toolbar_item.html.twig', { link: false }) }}
{% endblock %}
", "@WebProfiler/Collector/ajax.html.twig", "C:\\xampp\\htdocs\\MyProjects\\PHP-Calculator\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\ajax.html.twig");
    }
}
