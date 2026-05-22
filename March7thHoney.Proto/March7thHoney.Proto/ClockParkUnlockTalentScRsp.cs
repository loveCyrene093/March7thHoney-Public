using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ClockParkUnlockTalentScRsp : IMessage<ClockParkUnlockTalentScRsp>, IMessage, IEquatable<ClockParkUnlockTalentScRsp>, IDeepCloneable<ClockParkUnlockTalentScRsp>, IBufferMessage
{
	private static readonly MessageParser<ClockParkUnlockTalentScRsp> _parser = new MessageParser<ClockParkUnlockTalentScRsp>(() => new ClockParkUnlockTalentScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int KFJEMIOJLPJFieldNumber = 4;

	private uint kFJEMIOJLPJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ClockParkUnlockTalentScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ClockParkUnlockTalentScRspReflection.Descriptor.MessageTypes[0];

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
	public uint KFJEMIOJLPJ
	{
		get
		{
			return kFJEMIOJLPJ_;
		}
		set
		{
			kFJEMIOJLPJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkUnlockTalentScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkUnlockTalentScRsp(ClockParkUnlockTalentScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		kFJEMIOJLPJ_ = other.kFJEMIOJLPJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ClockParkUnlockTalentScRsp Clone()
	{
		return new ClockParkUnlockTalentScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ClockParkUnlockTalentScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ClockParkUnlockTalentScRsp other)
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
		if (KFJEMIOJLPJ != other.KFJEMIOJLPJ)
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
		if (KFJEMIOJLPJ != 0)
		{
			num ^= KFJEMIOJLPJ.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (KFJEMIOJLPJ != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(KFJEMIOJLPJ);
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
		if (KFJEMIOJLPJ != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KFJEMIOJLPJ);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ClockParkUnlockTalentScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.KFJEMIOJLPJ != 0)
			{
				KFJEMIOJLPJ = other.KFJEMIOJLPJ;
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
				Retcode = input.ReadUInt32();
				break;
			case 32u:
				KFJEMIOJLPJ = input.ReadUInt32();
				break;
			}
		}
	}
}
