using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MDFEFKDEFML : IMessage<MDFEFKDEFML>, IMessage, IEquatable<MDFEFKDEFML>, IDeepCloneable<MDFEFKDEFML>, IBufferMessage
{
	private static readonly MessageParser<MDFEFKDEFML> _parser = new MessageParser<MDFEFKDEFML>(() => new MDFEFKDEFML());

	private UnknownFieldSet _unknownFields;

	public const int StageIdFieldNumber = 12;

	private uint stageId_;

	public const int BPNBNPGPFJKFieldNumber = 13;

	private uint bPNBNPGPFJK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MDFEFKDEFML> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MDFEFKDEFMLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint StageId
	{
		get
		{
			return stageId_;
		}
		set
		{
			stageId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BPNBNPGPFJK
	{
		get
		{
			return bPNBNPGPFJK_;
		}
		set
		{
			bPNBNPGPFJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDFEFKDEFML()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDFEFKDEFML(MDFEFKDEFML other)
		: this()
	{
		stageId_ = other.stageId_;
		bPNBNPGPFJK_ = other.bPNBNPGPFJK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MDFEFKDEFML Clone()
	{
		return new MDFEFKDEFML(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MDFEFKDEFML);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MDFEFKDEFML other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (StageId != other.StageId)
		{
			return false;
		}
		if (BPNBNPGPFJK != other.BPNBNPGPFJK)
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
		if (StageId != 0)
		{
			num ^= StageId.GetHashCode();
		}
		if (BPNBNPGPFJK != 0)
		{
			num ^= BPNBNPGPFJK.GetHashCode();
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
		if (StageId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(StageId);
		}
		if (BPNBNPGPFJK != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(BPNBNPGPFJK);
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
		if (StageId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(StageId);
		}
		if (BPNBNPGPFJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BPNBNPGPFJK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MDFEFKDEFML other)
	{
		if (other != null)
		{
			if (other.StageId != 0)
			{
				StageId = other.StageId;
			}
			if (other.BPNBNPGPFJK != 0)
			{
				BPNBNPGPFJK = other.BPNBNPGPFJK;
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
				StageId = input.ReadUInt32();
				break;
			case 104u:
				BPNBNPGPFJK = input.ReadUInt32();
				break;
			}
		}
	}
}
