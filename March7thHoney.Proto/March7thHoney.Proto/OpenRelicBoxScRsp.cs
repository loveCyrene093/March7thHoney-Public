using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OpenRelicBoxScRsp : IMessage<OpenRelicBoxScRsp>, IMessage, IEquatable<OpenRelicBoxScRsp>, IDeepCloneable<OpenRelicBoxScRsp>, IBufferMessage
{
	private static readonly MessageParser<OpenRelicBoxScRsp> _parser = new MessageParser<OpenRelicBoxScRsp>(() => new OpenRelicBoxScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BDCJKFPGMFLFieldNumber = 1;

	private uint bDCJKFPGMFL_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int CGCJLHFLEPNFieldNumber = 12;

	private PGLFACHCGCB cGCJLHFLEPN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OpenRelicBoxScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OpenRelicBoxScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BDCJKFPGMFL
	{
		get
		{
			return bDCJKFPGMFL_;
		}
		set
		{
			bDCJKFPGMFL_ = value;
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
	public PGLFACHCGCB CGCJLHFLEPN
	{
		get
		{
			return cGCJLHFLEPN_;
		}
		set
		{
			cGCJLHFLEPN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenRelicBoxScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenRelicBoxScRsp(OpenRelicBoxScRsp other)
		: this()
	{
		bDCJKFPGMFL_ = other.bDCJKFPGMFL_;
		retcode_ = other.retcode_;
		cGCJLHFLEPN_ = ((other.cGCJLHFLEPN_ != null) ? other.cGCJLHFLEPN_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenRelicBoxScRsp Clone()
	{
		return new OpenRelicBoxScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OpenRelicBoxScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OpenRelicBoxScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BDCJKFPGMFL != other.BDCJKFPGMFL)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(CGCJLHFLEPN, other.CGCJLHFLEPN))
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
		if (BDCJKFPGMFL != 0)
		{
			num ^= BDCJKFPGMFL.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (cGCJLHFLEPN_ != null)
		{
			num ^= CGCJLHFLEPN.GetHashCode();
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
		if (BDCJKFPGMFL != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(BDCJKFPGMFL);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (cGCJLHFLEPN_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(CGCJLHFLEPN);
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
		if (BDCJKFPGMFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BDCJKFPGMFL);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (cGCJLHFLEPN_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CGCJLHFLEPN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OpenRelicBoxScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.BDCJKFPGMFL != 0)
		{
			BDCJKFPGMFL = other.BDCJKFPGMFL;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.cGCJLHFLEPN_ != null)
		{
			if (cGCJLHFLEPN_ == null)
			{
				CGCJLHFLEPN = new PGLFACHCGCB();
			}
			CGCJLHFLEPN.MergeFrom(other.CGCJLHFLEPN);
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
			case 8u:
				BDCJKFPGMFL = input.ReadUInt32();
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 98u:
				if (cGCJLHFLEPN_ == null)
				{
					CGCJLHFLEPN = new PGLFACHCGCB();
				}
				input.ReadMessage(CGCJLHFLEPN);
				break;
			}
		}
	}
}
