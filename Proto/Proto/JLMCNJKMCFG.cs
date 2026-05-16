using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JLMCNJKMCFG : IMessage<JLMCNJKMCFG>, IMessage, IEquatable<JLMCNJKMCFG>, IDeepCloneable<JLMCNJKMCFG>, IBufferMessage
{
	private static readonly MessageParser<JLMCNJKMCFG> _parser = new MessageParser<JLMCNJKMCFG>(() => new JLMCNJKMCFG());

	private UnknownFieldSet _unknownFields;

	public const int DAIKNKALKCMFieldNumber = 8;

	private bool dAIKNKALKCM_;

	public const int JACCJGBGJOAFieldNumber = 12;

	private uint jACCJGBGJOA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JLMCNJKMCFG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JLMCNJKMCFGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DAIKNKALKCM
	{
		get
		{
			return dAIKNKALKCM_;
		}
		set
		{
			dAIKNKALKCM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JACCJGBGJOA
	{
		get
		{
			return jACCJGBGJOA_;
		}
		set
		{
			jACCJGBGJOA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLMCNJKMCFG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLMCNJKMCFG(JLMCNJKMCFG other)
		: this()
	{
		dAIKNKALKCM_ = other.dAIKNKALKCM_;
		jACCJGBGJOA_ = other.jACCJGBGJOA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JLMCNJKMCFG Clone()
	{
		return new JLMCNJKMCFG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JLMCNJKMCFG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JLMCNJKMCFG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DAIKNKALKCM != other.DAIKNKALKCM)
		{
			return false;
		}
		if (JACCJGBGJOA != other.JACCJGBGJOA)
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
		if (DAIKNKALKCM)
		{
			num ^= DAIKNKALKCM.GetHashCode();
		}
		if (JACCJGBGJOA != 0)
		{
			num ^= JACCJGBGJOA.GetHashCode();
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
		if (DAIKNKALKCM)
		{
			output.WriteRawTag(64);
			output.WriteBool(DAIKNKALKCM);
		}
		if (JACCJGBGJOA != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(JACCJGBGJOA);
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
		if (DAIKNKALKCM)
		{
			num += 2;
		}
		if (JACCJGBGJOA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JACCJGBGJOA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JLMCNJKMCFG other)
	{
		if (other != null)
		{
			if (other.DAIKNKALKCM)
			{
				DAIKNKALKCM = other.DAIKNKALKCM;
			}
			if (other.JACCJGBGJOA != 0)
			{
				JACCJGBGJOA = other.JACCJGBGJOA;
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
			case 64u:
				DAIKNKALKCM = input.ReadBool();
				break;
			case 96u:
				JACCJGBGJOA = input.ReadUInt32();
				break;
			}
		}
	}
}
