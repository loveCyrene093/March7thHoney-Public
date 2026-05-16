using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DPLDPPPMMGH : IMessage<DPLDPPPMMGH>, IMessage, IEquatable<DPLDPPPMMGH>, IDeepCloneable<DPLDPPPMMGH>, IBufferMessage
{
	private static readonly MessageParser<DPLDPPPMMGH> _parser = new MessageParser<DPLDPPPMMGH>(() => new DPLDPPPMMGH());

	private UnknownFieldSet _unknownFields;

	public const int OCDHOGILIMOFieldNumber = 1;

	private static readonly FieldCodec<LDPLIJAMIOE> _repeated_oCDHOGILIMO_codec = FieldCodec.ForMessage(10u, LDPLIJAMIOE.Parser);

	private readonly RepeatedField<LDPLIJAMIOE> oCDHOGILIMO_ = new RepeatedField<LDPLIJAMIOE>();

	public const int AJCENJOAMEDFieldNumber = 3;

	private static readonly FieldCodec<LDPLIJAMIOE> _repeated_aJCENJOAMED_codec = FieldCodec.ForMessage(26u, LDPLIJAMIOE.Parser);

	private readonly RepeatedField<LDPLIJAMIOE> aJCENJOAMED_ = new RepeatedField<LDPLIJAMIOE>();

	public const int DIKCBKKNINMFieldNumber = 5;

	private static readonly FieldCodec<GKDDGHBGGAM> _repeated_dIKCBKKNINM_codec = FieldCodec.ForMessage(42u, GKDDGHBGGAM.Parser);

	private readonly RepeatedField<GKDDGHBGGAM> dIKCBKKNINM_ = new RepeatedField<GKDDGHBGGAM>();

	public const int CNLIALBPABNFieldNumber = 6;

	private LDPLIJAMIOE cNLIALBPABN_;

	public const int DDLHPDBHGJDFieldNumber = 15;

	private static readonly FieldCodec<KNGLMKEJBAB> _repeated_dDLHPDBHGJD_codec = FieldCodec.ForMessage(122u, KNGLMKEJBAB.Parser);

	private readonly RepeatedField<KNGLMKEJBAB> dDLHPDBHGJD_ = new RepeatedField<KNGLMKEJBAB>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DPLDPPPMMGH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DPLDPPPMMGHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LDPLIJAMIOE> OCDHOGILIMO => oCDHOGILIMO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<LDPLIJAMIOE> AJCENJOAMED => aJCENJOAMED_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDDGHBGGAM> DIKCBKKNINM => dIKCBKKNINM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LDPLIJAMIOE CNLIALBPABN
	{
		get
		{
			return cNLIALBPABN_;
		}
		set
		{
			cNLIALBPABN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KNGLMKEJBAB> DDLHPDBHGJD => dDLHPDBHGJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPLDPPPMMGH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPLDPPPMMGH(DPLDPPPMMGH other)
		: this()
	{
		oCDHOGILIMO_ = other.oCDHOGILIMO_.Clone();
		aJCENJOAMED_ = other.aJCENJOAMED_.Clone();
		dIKCBKKNINM_ = other.dIKCBKKNINM_.Clone();
		cNLIALBPABN_ = ((other.cNLIALBPABN_ != null) ? other.cNLIALBPABN_.Clone() : null);
		dDLHPDBHGJD_ = other.dDLHPDBHGJD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPLDPPPMMGH Clone()
	{
		return new DPLDPPPMMGH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DPLDPPPMMGH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DPLDPPPMMGH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oCDHOGILIMO_.Equals(other.oCDHOGILIMO_))
		{
			return false;
		}
		if (!aJCENJOAMED_.Equals(other.aJCENJOAMED_))
		{
			return false;
		}
		if (!dIKCBKKNINM_.Equals(other.dIKCBKKNINM_))
		{
			return false;
		}
		if (!object.Equals(CNLIALBPABN, other.CNLIALBPABN))
		{
			return false;
		}
		if (!dDLHPDBHGJD_.Equals(other.dDLHPDBHGJD_))
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		num ^= oCDHOGILIMO_.GetHashCode();
		num ^= aJCENJOAMED_.GetHashCode();
		num ^= dIKCBKKNINM_.GetHashCode();
		if (cNLIALBPABN_ != null)
		{
			num ^= CNLIALBPABN.GetHashCode();
		}
		num ^= dDLHPDBHGJD_.GetHashCode();
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		oCDHOGILIMO_.WriteTo(ref output, _repeated_oCDHOGILIMO_codec);
		aJCENJOAMED_.WriteTo(ref output, _repeated_aJCENJOAMED_codec);
		dIKCBKKNINM_.WriteTo(ref output, _repeated_dIKCBKKNINM_codec);
		if (cNLIALBPABN_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(CNLIALBPABN);
		}
		dDLHPDBHGJD_.WriteTo(ref output, _repeated_dDLHPDBHGJD_codec);
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		num += oCDHOGILIMO_.CalculateSize(_repeated_oCDHOGILIMO_codec);
		num += aJCENJOAMED_.CalculateSize(_repeated_aJCENJOAMED_codec);
		num += dIKCBKKNINM_.CalculateSize(_repeated_dIKCBKKNINM_codec);
		if (cNLIALBPABN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CNLIALBPABN);
		}
		num += dDLHPDBHGJD_.CalculateSize(_repeated_dDLHPDBHGJD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DPLDPPPMMGH other)
	{
		if (other == null)
		{
			return;
		}
		oCDHOGILIMO_.Add(other.oCDHOGILIMO_);
		aJCENJOAMED_.Add(other.aJCENJOAMED_);
		dIKCBKKNINM_.Add(other.dIKCBKKNINM_);
		if (other.cNLIALBPABN_ != null)
		{
			if (cNLIALBPABN_ == null)
			{
				CNLIALBPABN = new LDPLIJAMIOE();
			}
			CNLIALBPABN.MergeFrom(other.CNLIALBPABN);
		}
		dDLHPDBHGJD_.Add(other.dDLHPDBHGJD_);
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
				oCDHOGILIMO_.AddEntriesFrom(ref input, _repeated_oCDHOGILIMO_codec);
				break;
			case 26u:
				aJCENJOAMED_.AddEntriesFrom(ref input, _repeated_aJCENJOAMED_codec);
				break;
			case 42u:
				dIKCBKKNINM_.AddEntriesFrom(ref input, _repeated_dIKCBKKNINM_codec);
				break;
			case 50u:
				if (cNLIALBPABN_ == null)
				{
					CNLIALBPABN = new LDPLIJAMIOE();
				}
				input.ReadMessage(CNLIALBPABN);
				break;
			case 122u:
				dDLHPDBHGJD_.AddEntriesFrom(ref input, _repeated_dDLHPDBHGJD_codec);
				break;
			}
		}
	}
}
