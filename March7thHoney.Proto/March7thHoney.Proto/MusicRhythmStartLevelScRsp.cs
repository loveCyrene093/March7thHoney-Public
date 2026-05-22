using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MusicRhythmStartLevelScRsp : IMessage<MusicRhythmStartLevelScRsp>, IMessage, IEquatable<MusicRhythmStartLevelScRsp>, IDeepCloneable<MusicRhythmStartLevelScRsp>, IBufferMessage
{
	private static readonly MessageParser<MusicRhythmStartLevelScRsp> _parser = new MessageParser<MusicRhythmStartLevelScRsp>(() => new MusicRhythmStartLevelScRsp());

	private UnknownFieldSet _unknownFields;

	public const int LevelIdFieldNumber = 2;

	private uint levelId_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int MDILDJMPNGHFieldNumber = 8;

	private string mDILDJMPNGH_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MusicRhythmStartLevelScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MusicRhythmStartLevelScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LevelId
	{
		get
		{
			return levelId_;
		}
		set
		{
			levelId_ = value;
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
	public string MDILDJMPNGH
	{
		get
		{
			return mDILDJMPNGH_;
		}
		set
		{
			mDILDJMPNGH_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmStartLevelScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmStartLevelScRsp(MusicRhythmStartLevelScRsp other)
		: this()
	{
		levelId_ = other.levelId_;
		retcode_ = other.retcode_;
		mDILDJMPNGH_ = other.mDILDJMPNGH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmStartLevelScRsp Clone()
	{
		return new MusicRhythmStartLevelScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MusicRhythmStartLevelScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MusicRhythmStartLevelScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LevelId != other.LevelId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (MDILDJMPNGH != other.MDILDJMPNGH)
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
		if (LevelId != 0)
		{
			num ^= LevelId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (MDILDJMPNGH.Length != 0)
		{
			num ^= MDILDJMPNGH.GetHashCode();
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
		if (LevelId != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(LevelId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		if (MDILDJMPNGH.Length != 0)
		{
			output.WriteRawTag(66);
			output.WriteString(MDILDJMPNGH);
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
		if (LevelId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LevelId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (MDILDJMPNGH.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(MDILDJMPNGH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MusicRhythmStartLevelScRsp other)
	{
		if (other != null)
		{
			if (other.LevelId != 0)
			{
				LevelId = other.LevelId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.MDILDJMPNGH.Length != 0)
			{
				MDILDJMPNGH = other.MDILDJMPNGH;
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
				LevelId = input.ReadUInt32();
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 66u:
				MDILDJMPNGH = input.ReadString();
				break;
			}
		}
	}
}
