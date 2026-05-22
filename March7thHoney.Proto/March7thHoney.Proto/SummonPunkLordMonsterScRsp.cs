using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SummonPunkLordMonsterScRsp : IMessage<SummonPunkLordMonsterScRsp>, IMessage, IEquatable<SummonPunkLordMonsterScRsp>, IDeepCloneable<SummonPunkLordMonsterScRsp>, IBufferMessage
{
	private static readonly MessageParser<SummonPunkLordMonsterScRsp> _parser = new MessageParser<SummonPunkLordMonsterScRsp>(() => new SummonPunkLordMonsterScRsp());

	private UnknownFieldSet _unknownFields;

	public const int FFCDPHMJJKGFieldNumber = 12;

	private CIKJHLMOOIK fFCDPHMJJKG_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SummonPunkLordMonsterScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SummonPunkLordMonsterScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIKJHLMOOIK FFCDPHMJJKG
	{
		get
		{
			return fFCDPHMJJKG_;
		}
		set
		{
			fFCDPHMJJKG_ = value;
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
	public SummonPunkLordMonsterScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SummonPunkLordMonsterScRsp(SummonPunkLordMonsterScRsp other)
		: this()
	{
		fFCDPHMJJKG_ = ((other.fFCDPHMJJKG_ != null) ? other.fFCDPHMJJKG_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SummonPunkLordMonsterScRsp Clone()
	{
		return new SummonPunkLordMonsterScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SummonPunkLordMonsterScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SummonPunkLordMonsterScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(FFCDPHMJJKG, other.FFCDPHMJJKG))
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
		if (fFCDPHMJJKG_ != null)
		{
			num ^= FFCDPHMJJKG.GetHashCode();
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
		if (fFCDPHMJJKG_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(FFCDPHMJJKG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
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
		if (fFCDPHMJJKG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FFCDPHMJJKG);
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
	public void MergeFrom(SummonPunkLordMonsterScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.fFCDPHMJJKG_ != null)
		{
			if (fFCDPHMJJKG_ == null)
			{
				FFCDPHMJJKG = new CIKJHLMOOIK();
			}
			FFCDPHMJJKG.MergeFrom(other.FFCDPHMJJKG);
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
			case 98u:
				if (fFCDPHMJJKG_ == null)
				{
					FFCDPHMJJKG = new CIKJHLMOOIK();
				}
				input.ReadMessage(FFCDPHMJJKG);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
