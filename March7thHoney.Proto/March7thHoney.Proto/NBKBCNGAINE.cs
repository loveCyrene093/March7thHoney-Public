using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class NBKBCNGAINE : IMessage<NBKBCNGAINE>, IMessage, IEquatable<NBKBCNGAINE>, IDeepCloneable<NBKBCNGAINE>, IBufferMessage
{
	private static readonly MessageParser<NBKBCNGAINE> _parser = new MessageParser<NBKBCNGAINE>(() => new NBKBCNGAINE());

	private UnknownFieldSet _unknownFields;

	public const int TargetSideFieldNumber = 2;

	private uint targetSide_;

	public const int KKFDJPNPBFLFieldNumber = 4;

	private uint kKFDJPNPBFL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<NBKBCNGAINE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => NBKBCNGAINEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TargetSide
	{
		get
		{
			return targetSide_;
		}
		set
		{
			targetSide_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKFDJPNPBFL
	{
		get
		{
			return kKFDJPNPBFL_;
		}
		set
		{
			kKFDJPNPBFL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBKBCNGAINE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBKBCNGAINE(NBKBCNGAINE other)
		: this()
	{
		targetSide_ = other.targetSide_;
		kKFDJPNPBFL_ = other.kKFDJPNPBFL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NBKBCNGAINE Clone()
	{
		return new NBKBCNGAINE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as NBKBCNGAINE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(NBKBCNGAINE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (TargetSide != other.TargetSide)
		{
			return false;
		}
		if (KKFDJPNPBFL != other.KKFDJPNPBFL)
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
		if (TargetSide != 0)
		{
			num ^= TargetSide.GetHashCode();
		}
		if (KKFDJPNPBFL != 0)
		{
			num ^= KKFDJPNPBFL.GetHashCode();
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
		if (TargetSide != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(TargetSide);
		}
		if (KKFDJPNPBFL != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(KKFDJPNPBFL);
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
		if (TargetSide != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TargetSide);
		}
		if (KKFDJPNPBFL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKFDJPNPBFL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(NBKBCNGAINE other)
	{
		if (other != null)
		{
			if (other.TargetSide != 0)
			{
				TargetSide = other.TargetSide;
			}
			if (other.KKFDJPNPBFL != 0)
			{
				KKFDJPNPBFL = other.KKFDJPNPBFL;
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
				TargetSide = input.ReadUInt32();
				break;
			case 32u:
				KKFDJPNPBFL = input.ReadUInt32();
				break;
			}
		}
	}
}
