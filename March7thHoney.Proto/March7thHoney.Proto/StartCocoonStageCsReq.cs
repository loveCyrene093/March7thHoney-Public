using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartCocoonStageCsReq : IMessage<StartCocoonStageCsReq>, IMessage, IEquatable<StartCocoonStageCsReq>, IDeepCloneable<StartCocoonStageCsReq>, IBufferMessage
{
	private static readonly MessageParser<StartCocoonStageCsReq> _parser = new MessageParser<StartCocoonStageCsReq>(() => new StartCocoonStageCsReq());

	private UnknownFieldSet _unknownFields;

	public const int WorldLevelFieldNumber = 2;

	private uint worldLevel_;

	public const int CountFieldNumber = 5;

	private uint count_;

	public const int DLACEEFJAHBFieldNumber = 10;

	private NKNAADIGGNA dLACEEFJAHB_;

	public const int PropEntityIdFieldNumber = 12;

	private uint propEntityId_;

	public const int WaveFieldNumber = 14;

	private uint wave_;

	public const int CocoonIdFieldNumber = 15;

	private uint cocoonId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartCocoonStageCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartCocoonStageCsReqReflection.Descriptor.MessageTypes[0];

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
	public uint PropEntityId
	{
		get
		{
			return propEntityId_;
		}
		set
		{
			propEntityId_ = value;
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
	public StartCocoonStageCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartCocoonStageCsReq(StartCocoonStageCsReq other)
		: this()
	{
		worldLevel_ = other.worldLevel_;
		count_ = other.count_;
		dLACEEFJAHB_ = ((other.dLACEEFJAHB_ != null) ? other.dLACEEFJAHB_.Clone() : null);
		propEntityId_ = other.propEntityId_;
		wave_ = other.wave_;
		cocoonId_ = other.cocoonId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartCocoonStageCsReq Clone()
	{
		return new StartCocoonStageCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartCocoonStageCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartCocoonStageCsReq other)
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
		if (Count != other.Count)
		{
			return false;
		}
		if (!object.Equals(DLACEEFJAHB, other.DLACEEFJAHB))
		{
			return false;
		}
		if (PropEntityId != other.PropEntityId)
		{
			return false;
		}
		if (Wave != other.Wave)
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
		if (Count != 0)
		{
			num ^= Count.GetHashCode();
		}
		if (dLACEEFJAHB_ != null)
		{
			num ^= DLACEEFJAHB.GetHashCode();
		}
		if (PropEntityId != 0)
		{
			num ^= PropEntityId.GetHashCode();
		}
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
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
		if (Count != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Count);
		}
		if (dLACEEFJAHB_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DLACEEFJAHB);
		}
		if (PropEntityId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(PropEntityId);
		}
		if (Wave != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Wave);
		}
		if (CocoonId != 0)
		{
			output.WriteRawTag(120);
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
		if (Count != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Count);
		}
		if (dLACEEFJAHB_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DLACEEFJAHB);
		}
		if (PropEntityId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PropEntityId);
		}
		if (Wave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Wave);
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
	public void MergeFrom(StartCocoonStageCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.WorldLevel != 0)
		{
			WorldLevel = other.WorldLevel;
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
		if (other.PropEntityId != 0)
		{
			PropEntityId = other.PropEntityId;
		}
		if (other.Wave != 0)
		{
			Wave = other.Wave;
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
			case 40u:
				Count = input.ReadUInt32();
				break;
			case 82u:
				if (dLACEEFJAHB_ == null)
				{
					DLACEEFJAHB = new NKNAADIGGNA();
				}
				input.ReadMessage(DLACEEFJAHB);
				break;
			case 96u:
				PropEntityId = input.ReadUInt32();
				break;
			case 112u:
				Wave = input.ReadUInt32();
				break;
			case 120u:
				CocoonId = input.ReadUInt32();
				break;
			}
		}
	}
}
