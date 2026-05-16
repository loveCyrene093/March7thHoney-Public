using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DeleteRelicFilterPlanCsReq : IMessage<DeleteRelicFilterPlanCsReq>, IMessage, IEquatable<DeleteRelicFilterPlanCsReq>, IDeepCloneable<DeleteRelicFilterPlanCsReq>, IBufferMessage
{
	private static readonly MessageParser<DeleteRelicFilterPlanCsReq> _parser = new MessageParser<DeleteRelicFilterPlanCsReq>(() => new DeleteRelicFilterPlanCsReq());

	private UnknownFieldSet _unknownFields;

	public const int KIPBINBIDAEFieldNumber = 4;

	private bool kIPBINBIDAE_;

	public const int IBJMBIACFEKFieldNumber = 13;

	private static readonly FieldCodec<uint> _repeated_iBJMBIACFEK_codec = FieldCodec.ForUInt32(106u);

	private readonly RepeatedField<uint> iBJMBIACFEK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DeleteRelicFilterPlanCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DeleteRelicFilterPlanCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<uint> IBJMBIACFEK => iBJMBIACFEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteRelicFilterPlanCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteRelicFilterPlanCsReq(DeleteRelicFilterPlanCsReq other)
		: this()
	{
		kIPBINBIDAE_ = other.kIPBINBIDAE_;
		iBJMBIACFEK_ = other.iBJMBIACFEK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteRelicFilterPlanCsReq Clone()
	{
		return new DeleteRelicFilterPlanCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DeleteRelicFilterPlanCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DeleteRelicFilterPlanCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KIPBINBIDAE != other.KIPBINBIDAE)
		{
			return false;
		}
		if (!iBJMBIACFEK_.Equals(other.iBJMBIACFEK_))
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
		if (KIPBINBIDAE)
		{
			num ^= KIPBINBIDAE.GetHashCode();
		}
		num ^= iBJMBIACFEK_.GetHashCode();
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
		if (KIPBINBIDAE)
		{
			output.WriteRawTag(32);
			output.WriteBool(KIPBINBIDAE);
		}
		iBJMBIACFEK_.WriteTo(ref output, _repeated_iBJMBIACFEK_codec);
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
		if (KIPBINBIDAE)
		{
			num += 2;
		}
		num += iBJMBIACFEK_.CalculateSize(_repeated_iBJMBIACFEK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DeleteRelicFilterPlanCsReq other)
	{
		if (other != null)
		{
			if (other.KIPBINBIDAE)
			{
				KIPBINBIDAE = other.KIPBINBIDAE;
			}
			iBJMBIACFEK_.Add(other.iBJMBIACFEK_);
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
			case 32u:
				KIPBINBIDAE = input.ReadBool();
				break;
			case 104u:
			case 106u:
				iBJMBIACFEK_.AddEntriesFrom(ref input, _repeated_iBJMBIACFEK_codec);
				break;
			}
		}
	}
}
