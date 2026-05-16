using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MatchThreeV2SetBirdPosScRsp : IMessage<MatchThreeV2SetBirdPosScRsp>, IMessage, IEquatable<MatchThreeV2SetBirdPosScRsp>, IDeepCloneable<MatchThreeV2SetBirdPosScRsp>, IBufferMessage
{
	private static readonly MessageParser<MatchThreeV2SetBirdPosScRsp> _parser = new MessageParser<MatchThreeV2SetBirdPosScRsp>(() => new MatchThreeV2SetBirdPosScRsp());

	private UnknownFieldSet _unknownFields;

	public const int NLOCDHMLGJHFieldNumber = 1;

	private uint nLOCDHMLGJH_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int PosFieldNumber = 13;

	private uint pos_;

	public const int DLDHPGFDFHPFieldNumber = 14;

	private uint dLDHPGFDFHP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MatchThreeV2SetBirdPosScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MatchThreeV2SetBirdPosScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NLOCDHMLGJH
	{
		get
		{
			return nLOCDHMLGJH_;
		}
		set
		{
			nLOCDHMLGJH_ = value;
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
	public uint Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DLDHPGFDFHP
	{
		get
		{
			return dLDHPGFDFHP_;
		}
		set
		{
			dLDHPGFDFHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2SetBirdPosScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2SetBirdPosScRsp(MatchThreeV2SetBirdPosScRsp other)
		: this()
	{
		nLOCDHMLGJH_ = other.nLOCDHMLGJH_;
		retcode_ = other.retcode_;
		pos_ = other.pos_;
		dLDHPGFDFHP_ = other.dLDHPGFDFHP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MatchThreeV2SetBirdPosScRsp Clone()
	{
		return new MatchThreeV2SetBirdPosScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MatchThreeV2SetBirdPosScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MatchThreeV2SetBirdPosScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NLOCDHMLGJH != other.NLOCDHMLGJH)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (DLDHPGFDFHP != other.DLDHPGFDFHP)
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
		if (NLOCDHMLGJH != 0)
		{
			num ^= NLOCDHMLGJH.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (DLDHPGFDFHP != 0)
		{
			num ^= DLDHPGFDFHP.GetHashCode();
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
		if (NLOCDHMLGJH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(NLOCDHMLGJH);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (Pos != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Pos);
		}
		if (DLDHPGFDFHP != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(DLDHPGFDFHP);
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
		if (NLOCDHMLGJH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NLOCDHMLGJH);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (DLDHPGFDFHP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DLDHPGFDFHP);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MatchThreeV2SetBirdPosScRsp other)
	{
		if (other != null)
		{
			if (other.NLOCDHMLGJH != 0)
			{
				NLOCDHMLGJH = other.NLOCDHMLGJH;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.DLDHPGFDFHP != 0)
			{
				DLDHPGFDFHP = other.DLDHPGFDFHP;
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
				NLOCDHMLGJH = input.ReadUInt32();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				Pos = input.ReadUInt32();
				break;
			case 112u:
				DLDHPGFDFHP = input.ReadUInt32();
				break;
			}
		}
	}
}
