using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightGetDataScRsp : IMessage<GridFightGetDataScRsp>, IMessage, IEquatable<GridFightGetDataScRsp>, IDeepCloneable<GridFightGetDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<GridFightGetDataScRsp> _parser = new MessageParser<GridFightGetDataScRsp>(() => new GridFightGetDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int RogueGetInfoFieldNumber = 4;

	private GridFightSystemInfo rogueGetInfo_;

	public const int FightCurrentInfoFieldNumber = 13;

	private GridFightCurrentInfo fightCurrentInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightGetDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightGetDataScRspReflection.Descriptor.MessageTypes[0];

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
	public GridFightSystemInfo RogueGetInfo
	{
		get
		{
			return rogueGetInfo_;
		}
		set
		{
			rogueGetInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightCurrentInfo FightCurrentInfo
	{
		get
		{
			return fightCurrentInfo_;
		}
		set
		{
			fightCurrentInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGetDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGetDataScRsp(GridFightGetDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
		fightCurrentInfo_ = ((other.fightCurrentInfo_ != null) ? other.fightCurrentInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightGetDataScRsp Clone()
	{
		return new GridFightGetDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightGetDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightGetDataScRsp other)
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
		if (!object.Equals(RogueGetInfo, other.RogueGetInfo))
		{
			return false;
		}
		if (!object.Equals(FightCurrentInfo, other.FightCurrentInfo))
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
		if (rogueGetInfo_ != null)
		{
			num ^= RogueGetInfo.GetHashCode();
		}
		if (fightCurrentInfo_ != null)
		{
			num ^= FightCurrentInfo.GetHashCode();
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
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (rogueGetInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(RogueGetInfo);
		}
		if (fightCurrentInfo_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(FightCurrentInfo);
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
		if (rogueGetInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGetInfo);
		}
		if (fightCurrentInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FightCurrentInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightGetDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.rogueGetInfo_ != null)
		{
			if (rogueGetInfo_ == null)
			{
				RogueGetInfo = new GridFightSystemInfo();
			}
			RogueGetInfo.MergeFrom(other.RogueGetInfo);
		}
		if (other.fightCurrentInfo_ != null)
		{
			if (fightCurrentInfo_ == null)
			{
				FightCurrentInfo = new GridFightCurrentInfo();
			}
			FightCurrentInfo.MergeFrom(other.FightCurrentInfo);
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
				Retcode = input.ReadUInt32();
				break;
			case 34u:
				if (rogueGetInfo_ == null)
				{
					RogueGetInfo = new GridFightSystemInfo();
				}
				input.ReadMessage(RogueGetInfo);
				break;
			case 106u:
				if (fightCurrentInfo_ == null)
				{
					FightCurrentInfo = new GridFightCurrentInfo();
				}
				input.ReadMessage(FightCurrentInfo);
				break;
			}
		}
	}
}
