using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class QuickStartCocoonStageCsReq : IMessage<QuickStartCocoonStageCsReq>, IMessage, IEquatable<QuickStartCocoonStageCsReq>, IDeepCloneable<QuickStartCocoonStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<QuickStartCocoonStageCsReq> _parser = new MessageParser<QuickStartCocoonStageCsReq>(() => new QuickStartCocoonStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int WorldLevelFieldNumber = 2;

	private uint worldLevel_;

	public const int WaveFieldNumber = 4;

	private uint wave_;

	public const int CountFieldNumber = 5;

	private uint count_;

	public const int DLACEEFJAHBFieldNumber = 11;

	private NKNAADIGGNA dLACEEFJAHB_;

	public const int CocoonIdFieldNumber = 12;

	private uint cocoonId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<QuickStartCocoonStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => QuickStartCocoonStageCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint WorldLevel
	{
		get
		{
			return worldLevel_;
		}
		set
		{
			worldLevel_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Wave
	{
		get
		{
			return wave_;
		}
		set
		{
			wave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Count
	{
		get
		{
			return count_;
		}
		set
		{
			count_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NKNAADIGGNA DLACEEFJAHB
	{
		get
		{
			return dLACEEFJAHB_;
		}
		set
		{
			dLACEEFJAHB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CocoonId
	{
		get
		{
			return cocoonId_;
		}
		set
		{
			cocoonId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuickStartCocoonStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuickStartCocoonStageCsReq(QuickStartCocoonStageCsReq other)
		: this()
	{
		worldLevel_ = other.worldLevel_;
		wave_ = other.wave_;
		count_ = other.count_;
		dLACEEFJAHB_ = ((other.dLACEEFJAHB_ != null) ? other.dLACEEFJAHB_.Clone() : null);
		cocoonId_ = other.cocoonId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public QuickStartCocoonStageCsReq Clone()
	{
		return new QuickStartCocoonStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as QuickStartCocoonStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(QuickStartCocoonStageCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (WorldLevel != other.WorldLevel)
		{
			return false;
		}
		if (Wave != other.Wave)
		{
			return false;
		}
		if (Count != other.Count)
		{
			return false;
		}
		if (!object.Equals(DLACEEFJAHB, other.DLACEEFJAHB))
		{
			return false;
		}
		if (CocoonId != other.CocoonId)
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
		if (WorldLevel != 0)
		{
			num ^= WorldLevel.GetHashCode();
		}
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
		}
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (dLACEEFJAHB_ != null)
		{
			num ^= DLACEEFJAHB.GetHashCode();
		}
		if (CocoonId != 0)
		{
			num ^= CocoonId.GetHashCode();
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
		if (WorldLevel != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(WorldLevel);
		}
		if (Wave != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Wave);
		}
		if (Count != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Count);
		}
		if (dLACEEFJAHB_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(DLACEEFJAHB);
		}
		if (CocoonId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(CocoonId);
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
		if (WorldLevel != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(WorldLevel);
		}
		if (Wave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Wave);
		}
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (dLACEEFJAHB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DLACEEFJAHB);
		}
		if (CocoonId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CocoonId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(QuickStartCocoonStageCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.WorldLevel != 0)
		{
			WorldLevel = other.WorldLevel;
		}
		if (other.Wave != 0)
		{
			Wave = other.Wave;
		}
		if (other.Count != 0)
		{
			Count = other.Count;
		}
		if (other.dLACEEFJAHB_ != null)
		{
			if (dLACEEFJAHB_ == null)
			{
				DLACEEFJAHB = new NKNAADIGGNA();
			}
			DLACEEFJAHB.MergeFrom(other.DLACEEFJAHB);
		}
		if (other.CocoonId != 0)
		{
			CocoonId = other.CocoonId;
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
			case 16u:
				WorldLevel = input.ReadUInt32();
				break;
			case 32u:
				Wave = input.ReadUInt32();
				break;
			case 40u:
				Count = input.ReadUInt32();
				break;
			case 90u:
				if (dLACEEFJAHB_ == null)
				{
					DLACEEFJAHB = new NKNAADIGGNA();
				}
				input.ReadMessage(DLACEEFJAHB);
				break;
			case 96u:
				CocoonId = input.ReadUInt32();
				break;
			}
		}
	}
}
