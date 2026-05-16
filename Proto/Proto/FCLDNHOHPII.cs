using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FCLDNHOHPII : IMessage<FCLDNHOHPII>, IMessage, IEquatable<FCLDNHOHPII>, IDeepCloneable<FCLDNHOHPII>, IBufferMessage
{
	private static readonly MessageParser<FCLDNHOHPII> _parser = new MessageParser<FCLDNHOHPII>(() => new FCLDNHOHPII());

	private UnknownFieldSet _unknownFields;

	public const int StageIdFieldNumber = 10;

	private uint stageId_;

	public const int CEBPAJAAJPPFieldNumber = 11;

	private bool cEBPAJAAJPP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FCLDNHOHPII> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FCLDNHOHPIIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CEBPAJAAJPP
	{
		get
		{
			return cEBPAJAAJPP_;
		}
		set
		{
			cEBPAJAAJPP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCLDNHOHPII()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCLDNHOHPII(FCLDNHOHPII other)
		: this()
	{
		stageId_ = other.stageId_;
		cEBPAJAAJPP_ = other.cEBPAJAAJPP_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCLDNHOHPII Clone()
	{
		return new FCLDNHOHPII(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FCLDNHOHPII);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FCLDNHOHPII other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (CEBPAJAAJPP != other.CEBPAJAAJPP)
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
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (CEBPAJAAJPP)
		{
			num ^= CEBPAJAAJPP.GetHashCode();
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
		if (StageId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(StageId);
		}
		if (CEBPAJAAJPP)
		{
			output.WriteRawTag(88);
			output.WriteBool(CEBPAJAAJPP);
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
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (CEBPAJAAJPP)
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
	public void MergeFrom(FCLDNHOHPII other)
	{
		if (other != null)
		{
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			if (other.CEBPAJAAJPP)
			{
				CEBPAJAAJPP = other.CEBPAJAAJPP;
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
			case 80u:
				StageId = input.ReadUInt32();
				break;
			case 88u:
				CEBPAJAAJPP = input.ReadBool();
				break;
			}
		}
	}
}
