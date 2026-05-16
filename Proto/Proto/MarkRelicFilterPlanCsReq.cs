using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MarkRelicFilterPlanCsReq : IMessage<MarkRelicFilterPlanCsReq>, IMessage, IEquatable<MarkRelicFilterPlanCsReq>, IDeepCloneable<MarkRelicFilterPlanCsReq>, IBufferMessage
{
	private static readonly MessageParser<MarkRelicFilterPlanCsReq> _parser = new MessageParser<MarkRelicFilterPlanCsReq>(() => new MarkRelicFilterPlanCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IBJMBIACFEKFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_iBJMBIACFEK_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> iBJMBIACFEK_ = new RepeatedField<uint>();

	public const int KBNKNAHGPHGFieldNumber = 10;

	private bool kBNKNAHGPHG_;

	public const int KIPBINBIDAEFieldNumber = 15;

	private bool kIPBINBIDAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MarkRelicFilterPlanCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MarkRelicFilterPlanCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IBJMBIACFEK => iBJMBIACFEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KBNKNAHGPHG
	{
		get
		{
			return kBNKNAHGPHG_;
		}
		set
		{
			kBNKNAHGPHG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KIPBINBIDAE
	{
		get
		{
			return kIPBINBIDAE_;
		}
		set
		{
			kIPBINBIDAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkRelicFilterPlanCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkRelicFilterPlanCsReq(MarkRelicFilterPlanCsReq other)
		: this()
	{
		iBJMBIACFEK_ = other.iBJMBIACFEK_.Clone();
		kBNKNAHGPHG_ = other.kBNKNAHGPHG_;
		kIPBINBIDAE_ = other.kIPBINBIDAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkRelicFilterPlanCsReq Clone()
	{
		return new MarkRelicFilterPlanCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MarkRelicFilterPlanCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MarkRelicFilterPlanCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iBJMBIACFEK_.Equals(other.iBJMBIACFEK_))
		{
			return false;
		}
		if (KBNKNAHGPHG != other.KBNKNAHGPHG)
		{
			return false;
		}
		if (KIPBINBIDAE != other.KIPBINBIDAE)
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
		num ^= iBJMBIACFEK_.GetHashCode();
		if (KBNKNAHGPHG)
		{
			num ^= KBNKNAHGPHG.GetHashCode();
		}
		if (KIPBINBIDAE)
		{
			num ^= KIPBINBIDAE.GetHashCode();
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
		iBJMBIACFEK_.WriteTo(ref output, _repeated_iBJMBIACFEK_codec);
		if (KBNKNAHGPHG)
		{
			output.WriteRawTag(80);
			output.WriteBool(KBNKNAHGPHG);
		}
		if (KIPBINBIDAE)
		{
			output.WriteRawTag(120);
			output.WriteBool(KIPBINBIDAE);
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
		num += iBJMBIACFEK_.CalculateSize(_repeated_iBJMBIACFEK_codec);
		if (KBNKNAHGPHG)
		{
			num += 2;
		}
		if (KIPBINBIDAE)
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
	public void MergeFrom(MarkRelicFilterPlanCsReq other)
	{
		if (other != null)
		{
			iBJMBIACFEK_.Add(other.iBJMBIACFEK_);
			if (other.KBNKNAHGPHG)
			{
				KBNKNAHGPHG = other.KBNKNAHGPHG;
			}
			if (other.KIPBINBIDAE)
			{
				KIPBINBIDAE = other.KIPBINBIDAE;
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
			case 16u:
			case 18u:
				iBJMBIACFEK_.AddEntriesFrom(ref input, _repeated_iBJMBIACFEK_codec);
				break;
			case 80u:
				KBNKNAHGPHG = input.ReadBool();
				break;
			case 120u:
				KIPBINBIDAE = input.ReadBool();
				break;
			}
		}
	}
}
