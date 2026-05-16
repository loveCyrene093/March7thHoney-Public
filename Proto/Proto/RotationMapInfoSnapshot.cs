using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RotationMapInfoSnapshot : IMessage<RotationMapInfoSnapshot>, IMessage, IEquatable<RotationMapInfoSnapshot>, IDeepCloneable<RotationMapInfoSnapshot>, IBufferMessage
{
	private static readonly MessageParser<RotationMapInfoSnapshot> _parser = new MessageParser<RotationMapInfoSnapshot>(() => new RotationMapInfoSnapshot());

	private UnknownFieldSet _unknownFields;

	public const int MapPosFieldNumber = 1;

	private VectorSnapshot mapPos_;

	public const int MapRotFieldNumber = 2;

	private VectorSnapshot mapRot_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RotationMapInfoSnapshot> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RotationMapInfoSnapshotReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public VectorSnapshot MapPos
	{
		get
		{
			return mapPos_;
		}
		set
		{
			mapPos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public VectorSnapshot MapRot
	{
		get
		{
			return mapRot_;
		}
		set
		{
			mapRot_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotationMapInfoSnapshot()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotationMapInfoSnapshot(RotationMapInfoSnapshot other)
		: this()
	{
		mapPos_ = ((other.mapPos_ != null) ? other.mapPos_.Clone() : null);
		mapRot_ = ((other.mapRot_ != null) ? other.mapRot_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RotationMapInfoSnapshot Clone()
	{
		return new RotationMapInfoSnapshot(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RotationMapInfoSnapshot);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RotationMapInfoSnapshot other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MapPos, other.MapPos))
		{
			return false;
		}
		if (!object.Equals(MapRot, other.MapRot))
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
		if (mapPos_ != null)
		{
			num ^= MapPos.GetHashCode();
		}
		if (mapRot_ != null)
		{
			num ^= MapRot.GetHashCode();
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
		if (mapPos_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(MapPos);
		}
		if (mapRot_ != null)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MapRot);
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
		if (mapPos_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MapPos);
		}
		if (mapRot_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MapRot);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RotationMapInfoSnapshot other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mapPos_ != null)
		{
			if (mapPos_ == null)
			{
				MapPos = new VectorSnapshot();
			}
			MapPos.MergeFrom(other.MapPos);
		}
		if (other.mapRot_ != null)
		{
			if (mapRot_ == null)
			{
				MapRot = new VectorSnapshot();
			}
			MapRot.MergeFrom(other.MapRot);
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
				if (mapPos_ == null)
				{
					MapPos = new VectorSnapshot();
				}
				input.ReadMessage(MapPos);
				break;
			case 18u:
				if (mapRot_ == null)
				{
					MapRot = new VectorSnapshot();
				}
				input.ReadMessage(MapRot);
				break;
			}
		}
	}
}
