using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FJJNFNALLGA : IMessage<FJJNFNALLGA>, IMessage, IEquatable<FJJNFNALLGA>, IDeepCloneable<FJJNFNALLGA>, IBufferMessage
{
	private static readonly MessageParser<FJJNFNALLGA> _parser = new MessageParser<FJJNFNALLGA>(() => new FJJNFNALLGA());

	private UnknownFieldSet _unknownFields;

	public const int RoomIdFieldNumber = 1;

	private string roomId_ = "";

	public const int JAFNCOMGABGFieldNumber = 2;

	private uint jAFNCOMGABG_;

	public const int SectionIdFieldNumber = 3;

	private uint sectionId_;

	public const int PlayerInfoFieldNumber = 4;

	private KKNHIMGNMPG playerInfo_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FJJNFNALLGA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FJJNFNALLGAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RoomId
	{
		get
		{
			return roomId_;
		}
		set
		{
			roomId_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JAFNCOMGABG
	{
		get
		{
			return jAFNCOMGABG_;
		}
		set
		{
			jAFNCOMGABG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint SectionId
	{
		get
		{
			return sectionId_;
		}
		set
		{
			sectionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKNHIMGNMPG PlayerInfo
	{
		get
		{
			return playerInfo_;
		}
		set
		{
			playerInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJJNFNALLGA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJJNFNALLGA(FJJNFNALLGA other)
		: this()
	{
		roomId_ = other.roomId_;
		jAFNCOMGABG_ = other.jAFNCOMGABG_;
		sectionId_ = other.sectionId_;
		playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FJJNFNALLGA Clone()
	{
		return new FJJNFNALLGA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FJJNFNALLGA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FJJNFNALLGA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (RoomId != other.RoomId)
		{
			return false;
		}
		if (JAFNCOMGABG != other.JAFNCOMGABG)
		{
			return false;
		}
		if (SectionId != other.SectionId)
		{
			return false;
		}
		if (!object.Equals(PlayerInfo, other.PlayerInfo))
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
		if (RoomId.Length != 0)
		{
			num ^= RoomId.GetHashCode();
		}
		if (JAFNCOMGABG != 0)
		{
			num ^= JAFNCOMGABG.GetHashCode();
		}
		if (SectionId != 0)
		{
			num ^= SectionId.GetHashCode();
		}
		if (playerInfo_ != null)
		{
			num ^= PlayerInfo.GetHashCode();
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
		if (RoomId.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteString(RoomId);
		}
		if (JAFNCOMGABG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JAFNCOMGABG);
		}
		if (SectionId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(SectionId);
		}
		if (playerInfo_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(PlayerInfo);
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
		if (RoomId.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RoomId);
		}
		if (JAFNCOMGABG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JAFNCOMGABG);
		}
		if (SectionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SectionId);
		}
		if (playerInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PlayerInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FJJNFNALLGA other)
	{
		if (other == null)
		{
			return;
		}
		if (other.RoomId.Length != 0)
		{
			RoomId = other.RoomId;
		}
		if (other.JAFNCOMGABG != 0)
		{
			JAFNCOMGABG = other.JAFNCOMGABG;
		}
		if (other.SectionId != 0)
		{
			SectionId = other.SectionId;
		}
		if (other.playerInfo_ != null)
		{
			if (playerInfo_ == null)
			{
				PlayerInfo = new KKNHIMGNMPG();
			}
			PlayerInfo.MergeFrom(other.PlayerInfo);
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
			case 10u:
				RoomId = input.ReadString();
				break;
			case 16u:
				JAFNCOMGABG = input.ReadUInt32();
				break;
			case 24u:
				SectionId = input.ReadUInt32();
				break;
			case 34u:
				if (playerInfo_ == null)
				{
					PlayerInfo = new KKNHIMGNMPG();
				}
				input.ReadMessage(PlayerInfo);
				break;
			}
		}
	}
}
