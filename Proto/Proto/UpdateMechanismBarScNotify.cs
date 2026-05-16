using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateMechanismBarScNotify : IMessage<UpdateMechanismBarScNotify>, IMessage, IEquatable<UpdateMechanismBarScNotify>, IDeepCloneable<UpdateMechanismBarScNotify>, IBufferMessage
{
	private static readonly MessageParser<UpdateMechanismBarScNotify> _parser = new MessageParser<UpdateMechanismBarScNotify>(() => new UpdateMechanismBarScNotify());

	private UnknownFieldSet _unknownFields;

	public const int FloorIdFieldNumber = 5;

	private uint floorId_;

	public const int GMKEACBMOJAFieldNumber = 8;

	private MCBEKLOKGCD gMKEACBMOJA_;

	public const int PlaneIdFieldNumber = 9;

	private uint planeId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateMechanismBarScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateMechanismBarScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FloorId
	{
		get
		{
			return floorId_;
		}
		set
		{
			floorId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCBEKLOKGCD GMKEACBMOJA
	{
		get
		{
			return gMKEACBMOJA_;
		}
		set
		{
			gMKEACBMOJA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PlaneId
	{
		get
		{
			return planeId_;
		}
		set
		{
			planeId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMechanismBarScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMechanismBarScNotify(UpdateMechanismBarScNotify other)
		: this()
	{
		floorId_ = other.floorId_;
		gMKEACBMOJA_ = ((other.gMKEACBMOJA_ != null) ? other.gMKEACBMOJA_.Clone() : null);
		planeId_ = other.planeId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMechanismBarScNotify Clone()
	{
		return new UpdateMechanismBarScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateMechanismBarScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateMechanismBarScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (FloorId != other.FloorId)
		{
			return false;
		}
		if (!object.Equals(GMKEACBMOJA, other.GMKEACBMOJA))
		{
			return false;
		}
		if (PlaneId != other.PlaneId)
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
		if (FloorId != 0)
		{
			num ^= FloorId.GetHashCode();
		}
		if (gMKEACBMOJA_ != null)
		{
			num ^= GMKEACBMOJA.GetHashCode();
		}
		if (PlaneId != 0)
		{
			num ^= PlaneId.GetHashCode();
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
		if (FloorId != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(FloorId);
		}
		if (gMKEACBMOJA_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(GMKEACBMOJA);
		}
		if (PlaneId != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PlaneId);
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
		if (FloorId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FloorId);
		}
		if (gMKEACBMOJA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(GMKEACBMOJA);
		}
		if (PlaneId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PlaneId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateMechanismBarScNotify other)
	{
		if (other == null)
		{
			return;
		}
		if (other.FloorId != 0)
		{
			FloorId = other.FloorId;
		}
		if (other.gMKEACBMOJA_ != null)
		{
			if (gMKEACBMOJA_ == null)
			{
				GMKEACBMOJA = new MCBEKLOKGCD();
			}
			GMKEACBMOJA.MergeFrom(other.GMKEACBMOJA);
		}
		if (other.PlaneId != 0)
		{
			PlaneId = other.PlaneId;
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
			case 40u:
				FloorId = input.ReadUInt32();
				break;
			case 66u:
				if (gMKEACBMOJA_ == null)
				{
					GMKEACBMOJA = new MCBEKLOKGCD();
				}
				input.ReadMessage(GMKEACBMOJA);
				break;
			case 72u:
				PlaneId = input.ReadUInt32();
				break;
			}
		}
	}
}
