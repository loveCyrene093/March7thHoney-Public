using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFDJPDIKLDI : IMessage<IFDJPDIKLDI>, IMessage, IEquatable<IFDJPDIKLDI>, IDeepCloneable<IFDJPDIKLDI>, IBufferMessage
{
	private static readonly MessageParser<IFDJPDIKLDI> _parser = new MessageParser<IFDJPDIKLDI>(() => new IFDJPDIKLDI());

	private UnknownFieldSet _unknownFields;

	public const int MOOOPAMBOFKFieldNumber = 2;

	private uint mOOOPAMBOFK_;

	public const int MFJCDEKMNLGFieldNumber = 9;

	private ulong mFJCDEKMNLG_;

	public const int ConfigIdFieldNumber = 10;

	private uint configId_;

	public const int LevelFieldNumber = 11;

	private uint level_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFDJPDIKLDI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFDJPDIKLDIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MOOOPAMBOFK
	{
		get
		{
			return mOOOPAMBOFK_;
		}
		set
		{
			mOOOPAMBOFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong MFJCDEKMNLG
	{
		get
		{
			return mFJCDEKMNLG_;
		}
		set
		{
			mFJCDEKMNLG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ConfigId
	{
		get
		{
			return configId_;
		}
		set
		{
			configId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFDJPDIKLDI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFDJPDIKLDI(IFDJPDIKLDI other)
		: this()
	{
		mOOOPAMBOFK_ = other.mOOOPAMBOFK_;
		mFJCDEKMNLG_ = other.mFJCDEKMNLG_;
		configId_ = other.configId_;
		level_ = other.level_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFDJPDIKLDI Clone()
	{
		return new IFDJPDIKLDI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFDJPDIKLDI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFDJPDIKLDI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MOOOPAMBOFK != other.MOOOPAMBOFK)
		{
			return false;
		}
		if (MFJCDEKMNLG != other.MFJCDEKMNLG)
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (Level != other.Level)
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
		if (MOOOPAMBOFK != 0)
		{
			num ^= MOOOPAMBOFK.GetHashCode();
		}
		if (MFJCDEKMNLG != 0L)
		{
			num ^= MFJCDEKMNLG.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
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
		if (MOOOPAMBOFK != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MOOOPAMBOFK);
		}
		if (MFJCDEKMNLG != 0L)
		{
			output.WriteRawTag(72);
			output.WriteUInt64(MFJCDEKMNLG);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(ConfigId);
		}
		if (Level != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(Level);
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
		if (MOOOPAMBOFK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MOOOPAMBOFK);
		}
		if (MFJCDEKMNLG != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MFJCDEKMNLG);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFDJPDIKLDI other)
	{
		if (other != null)
		{
			if (other.MOOOPAMBOFK != 0)
			{
				MOOOPAMBOFK = other.MOOOPAMBOFK;
			}
			if (other.MFJCDEKMNLG != 0L)
			{
				MFJCDEKMNLG = other.MFJCDEKMNLG;
			}
			if (other.ConfigId != 0)
			{
				ConfigId = other.ConfigId;
			}
			if (other.Level != 0)
			{
				Level = other.Level;
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
				MOOOPAMBOFK = input.ReadUInt32();
				break;
			case 72u:
				MFJCDEKMNLG = input.ReadUInt64();
				break;
			case 80u:
				ConfigId = input.ReadUInt32();
				break;
			case 88u:
				Level = input.ReadUInt32();
				break;
			}
		}
	}
}
