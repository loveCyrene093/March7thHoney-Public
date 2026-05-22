using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MarkRelicFilterPlanScRsp : IMessage<MarkRelicFilterPlanScRsp>, IMessage, IEquatable<MarkRelicFilterPlanScRsp>, IDeepCloneable<MarkRelicFilterPlanScRsp>, IBufferMessage
{
	private static readonly MessageParser<MarkRelicFilterPlanScRsp> _parser = new MessageParser<MarkRelicFilterPlanScRsp>(() => new MarkRelicFilterPlanScRsp());

	private UnknownFieldSet _unknownFields;

	public const int KIPBINBIDAEFieldNumber = 2;

	private bool kIPBINBIDAE_;

	public const int KBNKNAHGPHGFieldNumber = 4;

	private bool kBNKNAHGPHG_;

	public const int IBJMBIACFEKFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_iBJMBIACFEK_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> iBJMBIACFEK_ = new RepeatedField<uint>();

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MarkRelicFilterPlanScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MarkRelicFilterPlanScRspReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<uint> IBJMBIACFEK => iBJMBIACFEK_;

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
	public MarkRelicFilterPlanScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkRelicFilterPlanScRsp(MarkRelicFilterPlanScRsp other)
		: this()
	{
		kIPBINBIDAE_ = other.kIPBINBIDAE_;
		kBNKNAHGPHG_ = other.kBNKNAHGPHG_;
		iBJMBIACFEK_ = other.iBJMBIACFEK_.Clone();
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MarkRelicFilterPlanScRsp Clone()
	{
		return new MarkRelicFilterPlanScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MarkRelicFilterPlanScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MarkRelicFilterPlanScRsp other)
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
		if (KBNKNAHGPHG != other.KBNKNAHGPHG)
		{
			return false;
		}
		if (!iBJMBIACFEK_.Equals(other.iBJMBIACFEK_))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (KBNKNAHGPHG)
		{
			num ^= KBNKNAHGPHG.GetHashCode();
		}
		num ^= iBJMBIACFEK_.GetHashCode();
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (KIPBINBIDAE)
		{
			output.WriteRawTag(16);
			output.WriteBool(KIPBINBIDAE);
		}
		if (KBNKNAHGPHG)
		{
			output.WriteRawTag(32);
			output.WriteBool(KBNKNAHGPHG);
		}
		iBJMBIACFEK_.WriteTo(ref output, _repeated_iBJMBIACFEK_codec);
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
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
		if (KIPBINBIDAE)
		{
			num += 2;
		}
		if (KBNKNAHGPHG)
		{
			num += 2;
		}
		num += iBJMBIACFEK_.CalculateSize(_repeated_iBJMBIACFEK_codec);
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MarkRelicFilterPlanScRsp other)
	{
		if (other != null)
		{
			if (other.KIPBINBIDAE)
			{
				KIPBINBIDAE = other.KIPBINBIDAE;
			}
			if (other.KBNKNAHGPHG)
			{
				KBNKNAHGPHG = other.KBNKNAHGPHG;
			}
			iBJMBIACFEK_.Add(other.iBJMBIACFEK_);
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
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
				KIPBINBIDAE = input.ReadBool();
				break;
			case 32u:
				KBNKNAHGPHG = input.ReadBool();
				break;
			case 56u:
			case 58u:
				iBJMBIACFEK_.AddEntriesFrom(ref input, _repeated_iBJMBIACFEK_codec);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
