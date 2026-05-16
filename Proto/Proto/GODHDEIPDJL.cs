using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GODHDEIPDJL : IMessage<GODHDEIPDJL>, IMessage, IEquatable<GODHDEIPDJL>, IDeepCloneable<GODHDEIPDJL>, IBufferMessage
{
	private static readonly MessageParser<GODHDEIPDJL> _parser = new MessageParser<GODHDEIPDJL>(() => new GODHDEIPDJL());

	private UnknownFieldSet _unknownFields;

	public const int MHINKADJCCGFieldNumber = 1;

	private ByteString mHINKADJCCG_ = ByteString.Empty;

	public const int AMBLLFLFKHCFieldNumber = 4;

	private uint aMBLLFLFKHC_;

	public const int PLFAOCPBBCPFieldNumber = 5;

	private MotionInfo pLFAOCPBBCP_;

	public const int ConfigIdFieldNumber = 6;

	private uint configId_;

	public const int JLMJFEDNBMFFieldNumber = 9;

	private uint jLMJFEDNBMF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GODHDEIPDJL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GODHDEIPDJLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString MHINKADJCCG
	{
		get
		{
			return mHINKADJCCG_;
		}
		set
		{
			mHINKADJCCG_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AMBLLFLFKHC
	{
		get
		{
			return aMBLLFLFKHC_;
		}
		set
		{
			aMBLLFLFKHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo PLFAOCPBBCP
	{
		get
		{
			return pLFAOCPBBCP_;
		}
		set
		{
			pLFAOCPBBCP_ = value;
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
	public uint JLMJFEDNBMF
	{
		get
		{
			return jLMJFEDNBMF_;
		}
		set
		{
			jLMJFEDNBMF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GODHDEIPDJL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GODHDEIPDJL(GODHDEIPDJL other)
		: this()
	{
		mHINKADJCCG_ = other.mHINKADJCCG_;
		aMBLLFLFKHC_ = other.aMBLLFLFKHC_;
		pLFAOCPBBCP_ = ((other.pLFAOCPBBCP_ != null) ? other.pLFAOCPBBCP_.Clone() : null);
		configId_ = other.configId_;
		jLMJFEDNBMF_ = other.jLMJFEDNBMF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GODHDEIPDJL Clone()
	{
		return new GODHDEIPDJL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GODHDEIPDJL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GODHDEIPDJL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MHINKADJCCG != other.MHINKADJCCG)
		{
			return false;
		}
		if (AMBLLFLFKHC != other.AMBLLFLFKHC)
		{
			return false;
		}
		if (!object.Equals(PLFAOCPBBCP, other.PLFAOCPBBCP))
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
		{
			return false;
		}
		if (JLMJFEDNBMF != other.JLMJFEDNBMF)
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
		if (MHINKADJCCG.Length != 0)
		{
			num ^= MHINKADJCCG.GetHashCode();
		}
		if (AMBLLFLFKHC != 0)
		{
			num ^= AMBLLFLFKHC.GetHashCode();
		}
		if (pLFAOCPBBCP_ != null)
		{
			num ^= PLFAOCPBBCP.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
		}
		if (JLMJFEDNBMF != 0)
		{
			num ^= JLMJFEDNBMF.GetHashCode();
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
		if (MHINKADJCCG.Length != 0)
		{
			output.WriteRawTag(10);
			output.WriteBytes(MHINKADJCCG);
		}
		if (AMBLLFLFKHC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AMBLLFLFKHC);
		}
		if (pLFAOCPBBCP_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(PLFAOCPBBCP);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(ConfigId);
		}
		if (JLMJFEDNBMF != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(JLMJFEDNBMF);
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
		if (MHINKADJCCG.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeBytesSize(MHINKADJCCG);
		}
		if (AMBLLFLFKHC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AMBLLFLFKHC);
		}
		if (pLFAOCPBBCP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PLFAOCPBBCP);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (JLMJFEDNBMF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JLMJFEDNBMF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GODHDEIPDJL other)
	{
		if (other == null)
		{
			return;
		}
		if (other.MHINKADJCCG.Length != 0)
		{
			MHINKADJCCG = other.MHINKADJCCG;
		}
		if (other.AMBLLFLFKHC != 0)
		{
			AMBLLFLFKHC = other.AMBLLFLFKHC;
		}
		if (other.pLFAOCPBBCP_ != null)
		{
			if (pLFAOCPBBCP_ == null)
			{
				PLFAOCPBBCP = new MotionInfo();
			}
			PLFAOCPBBCP.MergeFrom(other.PLFAOCPBBCP);
		}
		if (other.ConfigId != 0)
		{
			ConfigId = other.ConfigId;
		}
		if (other.JLMJFEDNBMF != 0)
		{
			JLMJFEDNBMF = other.JLMJFEDNBMF;
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
				MHINKADJCCG = input.ReadBytes();
				break;
			case 32u:
				AMBLLFLFKHC = input.ReadUInt32();
				break;
			case 42u:
				if (pLFAOCPBBCP_ == null)
				{
					PLFAOCPBBCP = new MotionInfo();
				}
				input.ReadMessage(PLFAOCPBBCP);
				break;
			case 48u:
				ConfigId = input.ReadUInt32();
				break;
			case 72u:
				JLMJFEDNBMF = input.ReadUInt32();
				break;
			}
		}
	}
}
