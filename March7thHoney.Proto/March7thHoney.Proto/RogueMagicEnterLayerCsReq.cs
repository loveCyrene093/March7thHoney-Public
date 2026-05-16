using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueMagicEnterLayerCsReq : IMessage<RogueMagicEnterLayerCsReq>, IMessage, IEquatable<RogueMagicEnterLayerCsReq>, IDeepCloneable<RogueMagicEnterLayerCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueMagicEnterLayerCsReq> _parser = new MessageParser<RogueMagicEnterLayerCsReq>(() => new RogueMagicEnterLayerCsReq());

	private UnknownFieldSet _unknownFields;

	public const int MNMAFKLOJCCFieldNumber = 12;

	private uint mNMAFKLOJCC_;

	public const int APMIAKDPHJLFieldNumber = 13;

	private uint aPMIAKDPHJL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueMagicEnterLayerCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueMagicEnterLayerCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MNMAFKLOJCC
	{
		get
		{
			return mNMAFKLOJCC_;
		}
		set
		{
			mNMAFKLOJCC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint APMIAKDPHJL
	{
		get
		{
			return aPMIAKDPHJL_;
		}
		set
		{
			aPMIAKDPHJL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicEnterLayerCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicEnterLayerCsReq(RogueMagicEnterLayerCsReq other)
		: this()
	{
		mNMAFKLOJCC_ = other.mNMAFKLOJCC_;
		aPMIAKDPHJL_ = other.aPMIAKDPHJL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueMagicEnterLayerCsReq Clone()
	{
		return new RogueMagicEnterLayerCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueMagicEnterLayerCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueMagicEnterLayerCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MNMAFKLOJCC != other.MNMAFKLOJCC)
		{
			return false;
		}
		if (APMIAKDPHJL != other.APMIAKDPHJL)
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
		if (MNMAFKLOJCC != 0)
		{
			num ^= MNMAFKLOJCC.GetHashCode();
		}
		if (APMIAKDPHJL != 0)
		{
			num ^= APMIAKDPHJL.GetHashCode();
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
		if (MNMAFKLOJCC != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MNMAFKLOJCC);
		}
		if (APMIAKDPHJL != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(APMIAKDPHJL);
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
		if (MNMAFKLOJCC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MNMAFKLOJCC);
		}
		if (APMIAKDPHJL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(APMIAKDPHJL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueMagicEnterLayerCsReq other)
	{
		if (other != null)
		{
			if (other.MNMAFKLOJCC != 0)
			{
				MNMAFKLOJCC = other.MNMAFKLOJCC;
			}
			if (other.APMIAKDPHJL != 0)
			{
				APMIAKDPHJL = other.APMIAKDPHJL;
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
			case 96u:
				MNMAFKLOJCC = input.ReadUInt32();
				break;
			case 104u:
				APMIAKDPHJL = input.ReadUInt32();
				break;
			}
		}
	}
}
