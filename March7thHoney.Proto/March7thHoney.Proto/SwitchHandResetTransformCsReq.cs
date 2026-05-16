using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SwitchHandResetTransformCsReq : IMessage<SwitchHandResetTransformCsReq>, IMessage, IEquatable<SwitchHandResetTransformCsReq>, IDeepCloneable<SwitchHandResetTransformCsReq>, IBufferMessage
{
	private static readonly MessageParser<SwitchHandResetTransformCsReq> _parser = new MessageParser<SwitchHandResetTransformCsReq>(() => new SwitchHandResetTransformCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PLFAOCPBBCPFieldNumber = 9;

	private MotionInfo pLFAOCPBBCP_;

	public const int ConfigIdFieldNumber = 13;

	private uint configId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SwitchHandResetTransformCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SwitchHandResetTransformCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public SwitchHandResetTransformCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandResetTransformCsReq(SwitchHandResetTransformCsReq other)
		: this()
	{
		pLFAOCPBBCP_ = ((other.pLFAOCPBBCP_ != null) ? other.pLFAOCPBBCP_.Clone() : null);
		configId_ = other.configId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SwitchHandResetTransformCsReq Clone()
	{
		return new SwitchHandResetTransformCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SwitchHandResetTransformCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SwitchHandResetTransformCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(PLFAOCPBBCP, other.PLFAOCPBBCP))
		{
			return false;
		}
		if (ConfigId != other.ConfigId)
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
		if (pLFAOCPBBCP_ != null)
		{
			num ^= PLFAOCPBBCP.GetHashCode();
		}
		if (ConfigId != 0)
		{
			num ^= ConfigId.GetHashCode();
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
		if (pLFAOCPBBCP_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(PLFAOCPBBCP);
		}
		if (ConfigId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ConfigId);
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
		if (pLFAOCPBBCP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(PLFAOCPBBCP);
		}
		if (ConfigId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ConfigId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SwitchHandResetTransformCsReq other)
	{
		if (other == null)
		{
			return;
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
			case 74u:
				if (pLFAOCPBBCP_ == null)
				{
					PLFAOCPBBCP = new MotionInfo();
				}
				input.ReadMessage(PLFAOCPBBCP);
				break;
			case 104u:
				ConfigId = input.ReadUInt32();
				break;
			}
		}
	}
}
