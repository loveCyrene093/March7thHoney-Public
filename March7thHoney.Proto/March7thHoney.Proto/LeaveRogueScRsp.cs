using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LeaveRogueScRsp : IMessage<LeaveRogueScRsp>, IMessage, IEquatable<LeaveRogueScRsp>, IDeepCloneable<LeaveRogueScRsp>, IBufferMessage
{
	private static readonly MessageParser<LeaveRogueScRsp> _parser = new MessageParser<LeaveRogueScRsp>(() => new LeaveRogueScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int LineupFieldNumber = 5;

	private LineupInfo lineup_;

	public const int SceneFieldNumber = 8;

	private SceneInfo scene_;

	public const int RogueGameInfoFieldNumber = 9;

	private JPFGHCPGHGO rogueGameInfo_;

	public const int ENPAICNLCMKFieldNumber = 10;

	private MADEENABOKE eNPAICNLCMK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LeaveRogueScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LeaveRogueScRspReflection.Descriptor.MessageTypes[0];

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
	public LineupInfo Lineup
	{
		get
		{
			return lineup_;
		}
		set
		{
			lineup_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SceneInfo Scene
	{
		get
		{
			return scene_;
		}
		set
		{
			scene_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JPFGHCPGHGO RogueGameInfo
	{
		get
		{
			return rogueGameInfo_;
		}
		set
		{
			rogueGameInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MADEENABOKE ENPAICNLCMK
	{
		get
		{
			return eNPAICNLCMK_;
		}
		set
		{
			eNPAICNLCMK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LeaveRogueScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LeaveRogueScRsp(LeaveRogueScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
		scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
		rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
		eNPAICNLCMK_ = ((other.eNPAICNLCMK_ != null) ? other.eNPAICNLCMK_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LeaveRogueScRsp Clone()
	{
		return new LeaveRogueScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LeaveRogueScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LeaveRogueScRsp other)
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
		if (!object.Equals(Lineup, other.Lineup))
		{
			return false;
		}
		if (!object.Equals(Scene, other.Scene))
		{
			return false;
		}
		if (!object.Equals(RogueGameInfo, other.RogueGameInfo))
		{
			return false;
		}
		if (!object.Equals(ENPAICNLCMK, other.ENPAICNLCMK))
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
		if (lineup_ != null)
		{
			num ^= Lineup.GetHashCode();
		}
		if (scene_ != null)
		{
			num ^= Scene.GetHashCode();
		}
		if (rogueGameInfo_ != null)
		{
			num ^= RogueGameInfo.GetHashCode();
		}
		if (eNPAICNLCMK_ != null)
		{
			num ^= ENPAICNLCMK.GetHashCode();
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
		if (lineup_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(Lineup);
		}
		if (scene_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(Scene);
		}
		if (rogueGameInfo_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(RogueGameInfo);
		}
		if (eNPAICNLCMK_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(ENPAICNLCMK);
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
		if (lineup_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Lineup);
		}
		if (scene_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Scene);
		}
		if (rogueGameInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RogueGameInfo);
		}
		if (eNPAICNLCMK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ENPAICNLCMK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LeaveRogueScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.lineup_ != null)
		{
			if (lineup_ == null)
			{
				Lineup = new LineupInfo();
			}
			Lineup.MergeFrom(other.Lineup);
		}
		if (other.scene_ != null)
		{
			if (scene_ == null)
			{
				Scene = new SceneInfo();
			}
			Scene.MergeFrom(other.Scene);
		}
		if (other.rogueGameInfo_ != null)
		{
			if (rogueGameInfo_ == null)
			{
				RogueGameInfo = new JPFGHCPGHGO();
			}
			RogueGameInfo.MergeFrom(other.RogueGameInfo);
		}
		if (other.eNPAICNLCMK_ != null)
		{
			if (eNPAICNLCMK_ == null)
			{
				ENPAICNLCMK = new MADEENABOKE();
			}
			ENPAICNLCMK.MergeFrom(other.ENPAICNLCMK);
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
			case 42u:
				if (lineup_ == null)
				{
					Lineup = new LineupInfo();
				}
				input.ReadMessage(Lineup);
				break;
			case 66u:
				if (scene_ == null)
				{
					Scene = new SceneInfo();
				}
				input.ReadMessage(Scene);
				break;
			case 74u:
				if (rogueGameInfo_ == null)
				{
					RogueGameInfo = new JPFGHCPGHGO();
				}
				input.ReadMessage(RogueGameInfo);
				break;
			case 82u:
				if (eNPAICNLCMK_ == null)
				{
					ENPAICNLCMK = new MADEENABOKE();
				}
				input.ReadMessage(ENPAICNLCMK);
				break;
			}
		}
	}
}
