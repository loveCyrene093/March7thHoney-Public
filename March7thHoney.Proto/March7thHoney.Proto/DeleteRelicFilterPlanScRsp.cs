using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DeleteRelicFilterPlanScRsp : IMessage<DeleteRelicFilterPlanScRsp>, IMessage, IEquatable<DeleteRelicFilterPlanScRsp>, IDeepCloneable<DeleteRelicFilterPlanScRsp>, IBufferMessage
{
	private static readonly MessageParser<DeleteRelicFilterPlanScRsp> _parser = new MessageParser<DeleteRelicFilterPlanScRsp>(() => new DeleteRelicFilterPlanScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int IBJMBIACFEKFieldNumber = 4;

	private static readonly FieldCodec<uint> _repeated_iBJMBIACFEK_codec = FieldCodec.ForUInt32(34u);

	private readonly RepeatedField<uint> iBJMBIACFEK_ = new RepeatedField<uint>();

	public const int KIPBINBIDAEFieldNumber = 10;

	private bool kIPBINBIDAE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DeleteRelicFilterPlanScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DeleteRelicFilterPlanScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IBJMBIACFEK => iBJMBIACFEK_;

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
	public DeleteRelicFilterPlanScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteRelicFilterPlanScRsp(DeleteRelicFilterPlanScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		iBJMBIACFEK_ = other.iBJMBIACFEK_.Clone();
		kIPBINBIDAE_ = other.kIPBINBIDAE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DeleteRelicFilterPlanScRsp Clone()
	{
		return new DeleteRelicFilterPlanScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DeleteRelicFilterPlanScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DeleteRelicFilterPlanScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!iBJMBIACFEK_.Equals(other.iBJMBIACFEK_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= iBJMBIACFEK_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		iBJMBIACFEK_.WriteTo(ref output, _repeated_iBJMBIACFEK_codec);
		if (KIPBINBIDAE)
		{
			output.WriteRawTag(80);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += iBJMBIACFEK_.CalculateSize(_repeated_iBJMBIACFEK_codec);
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
	public void MergeFrom(DeleteRelicFilterPlanScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			iBJMBIACFEK_.Add(other.iBJMBIACFEK_);
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
				Retcode = input.ReadUInt32();
				break;
			case 32u:
			case 34u:
				iBJMBIACFEK_.AddEntriesFrom(ref input, _repeated_iBJMBIACFEK_codec);
				break;
			case 80u:
				KIPBINBIDAE = input.ReadBool();
				break;
			}
		}
	}
}
