using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CENOIEMJPKK : IMessage<CENOIEMJPKK>, IMessage, IEquatable<CENOIEMJPKK>, IDeepCloneable<CENOIEMJPKK>, IBufferMessage
{
	private static readonly MessageParser<CENOIEMJPKK> _parser = new MessageParser<CENOIEMJPKK>(() => new CENOIEMJPKK());

	private UnknownFieldSet _unknownFields;

	public const int TypeFieldNumber = 1;

	private FeatureSwitchType type_;

	public const int JKMBDCBOFOGFieldNumber = 2;

	private static readonly FieldCodec<ANHCDHLNEJN> _repeated_jKMBDCBOFOG_codec = FieldCodec.ForMessage(18u, ANHCDHLNEJN.Parser);

	private readonly RepeatedField<ANHCDHLNEJN> jKMBDCBOFOG_ = new RepeatedField<ANHCDHLNEJN>();

	public const int OOPCLHPKJBOFieldNumber = 3;

	private bool oOPCLHPKJBO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CENOIEMJPKK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CENOIEMJPKKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSwitchType Type
	{
		get
		{
			return type_;
		}
		set
		{
			type_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ANHCDHLNEJN> JKMBDCBOFOG => jKMBDCBOFOG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool OOPCLHPKJBO
	{
		get
		{
			return oOPCLHPKJBO_;
		}
		set
		{
			oOPCLHPKJBO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CENOIEMJPKK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CENOIEMJPKK(CENOIEMJPKK other)
		: this()
	{
		type_ = other.type_;
		jKMBDCBOFOG_ = other.jKMBDCBOFOG_.Clone();
		oOPCLHPKJBO_ = other.oOPCLHPKJBO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CENOIEMJPKK Clone()
	{
		return new CENOIEMJPKK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CENOIEMJPKK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CENOIEMJPKK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Type != other.Type)
		{
			return false;
		}
		if (!jKMBDCBOFOG_.Equals(other.jKMBDCBOFOG_))
		{
			return false;
		}
		if (OOPCLHPKJBO != other.OOPCLHPKJBO)
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
		if (Type != FeatureSwitchType.IgckijddjfjAhmckdaolne)
		{
			num ^= Type.GetHashCode();
		}
		num ^= jKMBDCBOFOG_.GetHashCode();
		if (OOPCLHPKJBO)
		{
			num ^= OOPCLHPKJBO.GetHashCode();
		}
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
		if (Type != FeatureSwitchType.IgckijddjfjAhmckdaolne)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)Type);
		}
		jKMBDCBOFOG_.WriteTo(ref output, _repeated_jKMBDCBOFOG_codec);
		if (OOPCLHPKJBO)
		{
			output.WriteRawTag(24);
			output.WriteBool(OOPCLHPKJBO);
		}
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
		if (Type != FeatureSwitchType.IgckijddjfjAhmckdaolne)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)Type);
		}
		num += jKMBDCBOFOG_.CalculateSize(_repeated_jKMBDCBOFOG_codec);
		if (OOPCLHPKJBO)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CENOIEMJPKK other)
	{
		if (other != null)
		{
			if (other.Type != FeatureSwitchType.IgckijddjfjAhmckdaolne)
			{
				Type = other.Type;
			}
			jKMBDCBOFOG_.Add(other.jKMBDCBOFOG_);
			if (other.OOPCLHPKJBO)
			{
				OOPCLHPKJBO = other.OOPCLHPKJBO;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 8u:
				Type = (FeatureSwitchType)input.ReadEnum();
				break;
			case 18u:
				jKMBDCBOFOG_.AddEntriesFrom(ref input, _repeated_jKMBDCBOFOG_codec);
				break;
			case 24u:
				OOPCLHPKJBO = input.ReadBool();
				break;
			}
		}
	}
}
