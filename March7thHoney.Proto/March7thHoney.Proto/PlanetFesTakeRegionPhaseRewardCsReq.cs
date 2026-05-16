using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesTakeRegionPhaseRewardCsReq : IMessage<PlanetFesTakeRegionPhaseRewardCsReq>, IMessage, IEquatable<PlanetFesTakeRegionPhaseRewardCsReq>, IDeepCloneable<PlanetFesTakeRegionPhaseRewardCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesTakeRegionPhaseRewardCsReq> _parser = new MessageParser<PlanetFesTakeRegionPhaseRewardCsReq>(() => new PlanetFesTakeRegionPhaseRewardCsReq());

	private UnknownFieldSet _unknownFields;

	public const int HJMGGLANHMLFieldNumber = 13;

	private uint hJMGGLANHML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesTakeRegionPhaseRewardCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesTakeRegionPhaseRewardCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJMGGLANHML
	{
		get
		{
			return hJMGGLANHML_;
		}
		set
		{
			hJMGGLANHML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesTakeRegionPhaseRewardCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesTakeRegionPhaseRewardCsReq(PlanetFesTakeRegionPhaseRewardCsReq other)
		: this()
	{
		hJMGGLANHML_ = other.hJMGGLANHML_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesTakeRegionPhaseRewardCsReq Clone()
	{
		return new PlanetFesTakeRegionPhaseRewardCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesTakeRegionPhaseRewardCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesTakeRegionPhaseRewardCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (HJMGGLANHML != other.HJMGGLANHML)
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
		if (HJMGGLANHML != 0)
		{
			num ^= HJMGGLANHML.GetHashCode();
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
		if (HJMGGLANHML != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HJMGGLANHML);
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
		if (HJMGGLANHML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJMGGLANHML);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesTakeRegionPhaseRewardCsReq other)
	{
		if (other != null)
		{
			if (other.HJMGGLANHML != 0)
			{
				HJMGGLANHML = other.HJMGGLANHML;
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
			if (num != 104)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				HJMGGLANHML = input.ReadUInt32();
			}
		}
	}
}
