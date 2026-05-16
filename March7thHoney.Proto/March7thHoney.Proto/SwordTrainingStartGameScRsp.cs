using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwordTrainingStartGameScRsp : IMessage<SwordTrainingStartGameScRsp>, IMessage, IEquatable<SwordTrainingStartGameScRsp>, IDeepCloneable<SwordTrainingStartGameScRsp>, IBufferMessage
{
	private static readonly MessageParser<SwordTrainingStartGameScRsp> _parser = new MessageParser<SwordTrainingStartGameScRsp>(() => new SwordTrainingStartGameScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BMKAEFAKNFJFieldNumber = 6;

	private LMBHDCFPPLL bMKAEFAKNFJ_;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwordTrainingStartGameScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwordTrainingStartGameScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LMBHDCFPPLL BMKAEFAKNFJ
	{
		get
		{
			return bMKAEFAKNFJ_;
		}
		set
		{
			bMKAEFAKNFJ_ = value;
		}
	}

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
	public SwordTrainingStartGameScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingStartGameScRsp(SwordTrainingStartGameScRsp other)
		: this()
	{
		bMKAEFAKNFJ_ = ((other.bMKAEFAKNFJ_ != null) ? other.bMKAEFAKNFJ_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingStartGameScRsp Clone()
	{
		return new SwordTrainingStartGameScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwordTrainingStartGameScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwordTrainingStartGameScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BMKAEFAKNFJ, other.BMKAEFAKNFJ))
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
		if (bMKAEFAKNFJ_ != null)
		{
			num ^= BMKAEFAKNFJ.GetHashCode();
		}
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
		if (bMKAEFAKNFJ_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(BMKAEFAKNFJ);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
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
		if (bMKAEFAKNFJ_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BMKAEFAKNFJ);
		}
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
	public void MergeFrom(SwordTrainingStartGameScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bMKAEFAKNFJ_ != null)
		{
			if (bMKAEFAKNFJ_ == null)
			{
				BMKAEFAKNFJ = new LMBHDCFPPLL();
			}
			BMKAEFAKNFJ.MergeFrom(other.BMKAEFAKNFJ);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
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
			case 50u:
				if (bMKAEFAKNFJ_ == null)
				{
					BMKAEFAKNFJ = new LMBHDCFPPLL();
				}
				input.ReadMessage(BMKAEFAKNFJ);
				break;
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
