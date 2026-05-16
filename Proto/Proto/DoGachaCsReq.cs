using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DoGachaCsReq : IMessage<DoGachaCsReq>, IMessage, IEquatable<DoGachaCsReq>, IDeepCloneable<DoGachaCsReq>, IBufferMessage
{
	private static readonly MessageParser<DoGachaCsReq> _parser = new MessageParser<DoGachaCsReq>(() => new DoGachaCsReq());

	private UnknownFieldSet _unknownFields;

	public const int GachaRandomFieldNumber = 2;

	private uint gachaRandom_;

	public const int SimulateMagicFieldNumber = 10;

	private uint simulateMagic_;

	public const int GachaIdFieldNumber = 12;

	private uint gachaId_;

	public const int GachaNumFieldNumber = 15;

	private uint gachaNum_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DoGachaCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DoGachaCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaRandom
	{
		get
		{
			return gachaRandom_;
		}
		set
		{
			gachaRandom_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SimulateMagic
	{
		get
		{
			return simulateMagic_;
		}
		set
		{
			simulateMagic_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaId
	{
		get
		{
			return gachaId_;
		}
		set
		{
			gachaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GachaNum
	{
		get
		{
			return gachaNum_;
		}
		set
		{
			gachaNum_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaCsReq(DoGachaCsReq other)
		: this()
	{
		gachaRandom_ = other.gachaRandom_;
		simulateMagic_ = other.simulateMagic_;
		gachaId_ = other.gachaId_;
		gachaNum_ = other.gachaNum_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DoGachaCsReq Clone()
	{
		return new DoGachaCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DoGachaCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DoGachaCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GachaRandom != other.GachaRandom)
		{
			return false;
		}
		if (SimulateMagic != other.SimulateMagic)
		{
			return false;
		}
		if (GachaId != other.GachaId)
		{
			return false;
		}
		if (GachaNum != other.GachaNum)
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
		if (GachaRandom != 0)
		{
			num ^= GachaRandom.GetHashCode();
		}
		if (SimulateMagic != 0)
		{
			num ^= SimulateMagic.GetHashCode();
		}
		if (GachaId != 0)
		{
			num ^= GachaId.GetHashCode();
		}
		if (GachaNum != 0)
		{
			num ^= GachaNum.GetHashCode();
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
		if (GachaRandom != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GachaRandom);
		}
		if (SimulateMagic != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(SimulateMagic);
		}
		if (GachaId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(GachaId);
		}
		if (GachaNum != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GachaNum);
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
		if (GachaRandom != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaRandom);
		}
		if (SimulateMagic != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SimulateMagic);
		}
		if (GachaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaId);
		}
		if (GachaNum != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GachaNum);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DoGachaCsReq other)
	{
		if (other != null)
		{
			if (other.GachaRandom != 0)
			{
				GachaRandom = other.GachaRandom;
			}
			if (other.SimulateMagic != 0)
			{
				SimulateMagic = other.SimulateMagic;
			}
			if (other.GachaId != 0)
			{
				GachaId = other.GachaId;
			}
			if (other.GachaNum != 0)
			{
				GachaNum = other.GachaNum;
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
				GachaRandom = input.ReadUInt32();
				break;
			case 80u:
				SimulateMagic = input.ReadUInt32();
				break;
			case 96u:
				GachaId = input.ReadUInt32();
				break;
			case 120u:
				GachaNum = input.ReadUInt32();
				break;
			}
		}
	}
}
