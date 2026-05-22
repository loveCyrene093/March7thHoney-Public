using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwordTrainingResumeGameScRsp : IMessage<SwordTrainingResumeGameScRsp>, IMessage, IEquatable<SwordTrainingResumeGameScRsp>, IDeepCloneable<SwordTrainingResumeGameScRsp>, IBufferMessage
{
	private static readonly MessageParser<SwordTrainingResumeGameScRsp> _parser = new MessageParser<SwordTrainingResumeGameScRsp>(() => new SwordTrainingResumeGameScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BMKAEFAKNFJFieldNumber = 3;

	private LMBHDCFPPLL bMKAEFAKNFJ_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwordTrainingResumeGameScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwordTrainingResumeGameScRspReflection.Descriptor.MessageTypes[0];

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
	public SwordTrainingResumeGameScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingResumeGameScRsp(SwordTrainingResumeGameScRsp other)
		: this()
	{
		bMKAEFAKNFJ_ = ((other.bMKAEFAKNFJ_ != null) ? other.bMKAEFAKNFJ_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwordTrainingResumeGameScRsp Clone()
	{
		return new SwordTrainingResumeGameScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwordTrainingResumeGameScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwordTrainingResumeGameScRsp other)
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
			output.WriteRawTag(26);
			output.WriteMessage(BMKAEFAKNFJ);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
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
	public void MergeFrom(SwordTrainingResumeGameScRsp other)
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
			case 26u:
				if (bMKAEFAKNFJ_ == null)
				{
					BMKAEFAKNFJ = new LMBHDCFPPLL();
				}
				input.ReadMessage(BMKAEFAKNFJ);
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
