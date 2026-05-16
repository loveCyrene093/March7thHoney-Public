using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnterMapRotationRegionCsReq : IMessage<EnterMapRotationRegionCsReq>, IMessage, IEquatable<EnterMapRotationRegionCsReq>, IDeepCloneable<EnterMapRotationRegionCsReq>, IBufferMessage
{
	private static readonly MessageParser<EnterMapRotationRegionCsReq> _parser = new MessageParser<EnterMapRotationRegionCsReq>(() => new EnterMapRotationRegionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JHDLNBPNEKGFieldNumber = 1;

	private uint jHDLNBPNEKG_;

	public const int BCPCBHMFIINFieldNumber = 7;

	private uint bCPCBHMFIIN_;

	public const int MotionFieldNumber = 15;

	private MotionInfo motion_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnterMapRotationRegionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EnterMapRotationRegionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHDLNBPNEKG
	{
		get
		{
			return jHDLNBPNEKG_;
		}
		set
		{
			jHDLNBPNEKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BCPCBHMFIIN
	{
		get
		{
			return bCPCBHMFIIN_;
		}
		set
		{
			bCPCBHMFIIN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MotionInfo Motion
	{
		get
		{
			return motion_;
		}
		set
		{
			motion_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterMapRotationRegionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterMapRotationRegionCsReq(EnterMapRotationRegionCsReq other)
		: this()
	{
		jHDLNBPNEKG_ = other.jHDLNBPNEKG_;
		bCPCBHMFIIN_ = other.bCPCBHMFIIN_;
		motion_ = ((other.motion_ != null) ? other.motion_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnterMapRotationRegionCsReq Clone()
	{
		return new EnterMapRotationRegionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EnterMapRotationRegionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EnterMapRotationRegionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JHDLNBPNEKG != other.JHDLNBPNEKG)
		{
			return false;
		}
		if (BCPCBHMFIIN != other.BCPCBHMFIIN)
		{
			return false;
		}
		if (!object.Equals(Motion, other.Motion))
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
		if (JHDLNBPNEKG != 0)
		{
			num ^= JHDLNBPNEKG.GetHashCode();
		}
		if (BCPCBHMFIIN != 0)
		{
			num ^= BCPCBHMFIIN.GetHashCode();
		}
		if (motion_ != null)
		{
			num ^= Motion.GetHashCode();
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
		if (JHDLNBPNEKG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(JHDLNBPNEKG);
		}
		if (BCPCBHMFIIN != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(BCPCBHMFIIN);
		}
		if (motion_ != null)
		{
			output.WriteRawTag(122);
			output.WriteMessage(Motion);
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
		if (JHDLNBPNEKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHDLNBPNEKG);
		}
		if (BCPCBHMFIIN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BCPCBHMFIIN);
		}
		if (motion_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Motion);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EnterMapRotationRegionCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.JHDLNBPNEKG != 0)
		{
			JHDLNBPNEKG = other.JHDLNBPNEKG;
		}
		if (other.BCPCBHMFIIN != 0)
		{
			BCPCBHMFIIN = other.BCPCBHMFIIN;
		}
		if (other.motion_ != null)
		{
			if (motion_ == null)
			{
				Motion = new MotionInfo();
			}
			Motion.MergeFrom(other.Motion);
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
			case 8u:
				JHDLNBPNEKG = input.ReadUInt32();
				break;
			case 56u:
				BCPCBHMFIIN = input.ReadUInt32();
				break;
			case 122u:
				if (motion_ == null)
				{
					Motion = new MotionInfo();
				}
				input.ReadMessage(Motion);
				break;
			}
		}
	}
}
